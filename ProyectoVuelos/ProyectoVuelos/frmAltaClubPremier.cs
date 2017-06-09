using System;
using System.Collections;
using System.Windows.Forms;
using System.Data.SqlClient;
using LibreriaBD;
using System.Drawing;

namespace ProyectoVuelos {
	public partial class frmAltaClubPremier : Form {

        SqlConnection conn;

        public frmAltaClubPremier() {
			InitializeComponent();
            frmMenu f = new frmMenu();
            this.conn = f.conn;

        }

        public frmAltaClubPremier(string nombre) {
            InitializeComponent();
            frmMenu f = new frmMenu();
            this.conn = f.conn;
            txtNombre.Text = nombre;
            txtNombre.Enabled = false;
        }

        private void btnGuardar_Click(object sender,EventArgs e) {
            string nombre, domicilio;
			double millas = 0.0;
        
			nombre = txtNombre.Text;

			if(nombre == "" || txtDomicilio.Text == "") { 
				MessageBox.Show("DEBE LLENAR TODOS LOS CAMPOS.","ATENCIÓN",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				return;
			}

			if (ValidarNombre(nombre))
				MessageBox.Show("ESE CLIENTE YA ESTÁ REGISTRADO.","ATENCIÓN",MessageBoxButtons.OK,MessageBoxIcon.Warning);
			else {
				domicilio = txtDomicilio.Text;
                string strComando = "";
                int claveCliente = buscarCliente(nombre);
                SqlCommand cmd;

                if (claveCliente == -1) {
                    strComando =
                        "INSERT INTO cliente(nombre)";
                    strComando += " VALUES ( @nombre);";

                     cmd = new SqlCommand(strComando,conn);
                    cmd.Parameters.AddWithValue("@nombre",nombre);


                    try {
                        cmd.ExecuteNonQuery();
                    } catch (Exception ex) {
                        MessageBox.Show(ex.Message);
                        return;
                    }

                    claveCliente = ultimaClave("cveCliente","cliente"); 
                } else
                    eliminarGenerico(claveCliente);

                strComando =
                        "INSERT INTO club_premier(claveClubPremier, cveCliente, domicilio, millasAcumuladas, fecha_nacimiento)";
                    strComando += " VALUES (@cP, @cC, @d, @m, @f);";

                    String clavePremier = txtClave.Text;
                   
                    DateTime fecha = dateTimePicker1.Value;

                    cmd = new SqlCommand(strComando,conn);
                    cmd.Parameters.AddWithValue("@cP",clavePremier);
                    cmd.Parameters.AddWithValue("@cC",claveCliente);
                    cmd.Parameters.AddWithValue("@d",domicilio);
                    cmd.Parameters.AddWithValue("@m",millas);
                    cmd.Parameters.AddWithValue("@f",fecha);

                    try {
                        cmd.ExecuteNonQuery();
                    } catch (Exception ex) {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                

				MessageBox.Show("CLIENTE REGISTRADO.","ALTA",MessageBoxButtons.OK,MessageBoxIcon.Information);
				Limpiar();
			}
		}

        private void eliminarGenerico (int cve) {
            string strComando = "DELETE FROM clienteGenérico ";
            strComando += "WHERE cveCliente = @clave" ;

            SqlCommand cmd = new SqlCommand(strComando,conn);
            cmd.Parameters.AddWithValue("@clave", cve);

            try {
                cmd.ExecuteNonQuery();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        public int buscarCliente(string nombre) {
            int clave = -1;
            string strComando = "SELECT cveCliente FROM cliente WHERE nombre = '" + nombre + "';";
            SqlDataReader lector = UsoDB.Consulta(strComando,conn);

            if (lector.HasRows)
                while (lector.Read())
                    clave = Convert.ToInt32(lector.GetValue(0));

            lector.Close();
            return clave;
        }


		public bool ValidarNombre(string n) {

			string strComando = "SELECT * FROM club_premier cp" +
			" INNER JOIN cliente c ON c.cveCliente = cp.cveCliente WHERE " +
			"nombre = '" + n + "';";
			SqlDataReader lector = UsoDB.Consulta(strComando,conn);

			if (lector.HasRows)
				return true;

            lector.Close();
			return false;

		}

        private int ultimaClave (string campo, string tabla) {
            int r = 0;
            string str = "SELECT MAX("+campo+") FROM "+tabla+";";
            SqlDataReader lector = UsoDB.Consulta(str,conn);
            if (lector.HasRows)
                while (lector.Read())
                    r = Convert.ToInt16(lector.GetValue(0));

            lector.Close();
            return r;
        }

		private void Limpiar() {
			txtDomicilio.Text = "";
			txtNombre.Text = "";
            txtClave.Text = "";
            dateTimePicker1.Value = dateTimePicker1.MinDate;
            txtNombre.Enabled = true;
		}

		private void txtNombre_KeyPress(object sender,KeyPressEventArgs e) {
			if ((char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
				errorPNombre.SetError(txtNombre,"Sólo se permiten letras.");
			else
				errorPNombre.SetError(txtNombre,"");
		}


        private void txtNombre_Leave(object sender,EventArgs e) {
            if(txtDomicilio.Text != null && txtNombre.Text!= null && txtNombre.Text != "" && txtDomicilio.Text != "") {
                string nombre = txtNombre.Text;
                string domicilio = txtDomicilio.Text;
                string clave = "";
                string c = "";

                if (buscarCliente() == -1)
                    c = (ultimaClave("cveCliente","cliente") + 1).ToString();
                else
                    c = buscarCliente().ToString();


                if (nombre.Length >3 && domicilio.Length>2)
                   clave = nombre.Substring(0,3) + c + domicilio.Substring(0,2);
                else 
                    clave = nombre.Substring(0,1) + "XX" + c + domicilio.Substring(0,1) + "X";

                txtClave.Text = clave;
            }
        }

        private int buscarCliente() {
            int clave = -1;
            SqlDataReader lector = null;
            string strComando = "SELECT cveCliente FROM cliente WHERE nombre='" + txtNombre.Text + "';";

            lector = UsoDB.Consulta(strComando,conn);

            if (lector.HasRows)
                while (lector.Read())
                    clave = Convert.ToInt32(lector.GetValue(0));


            lector.Close();
            return clave;


        }

        private void btnRegresar_Click(object sender,EventArgs e) {
            this.Close();
        }
    }
}
