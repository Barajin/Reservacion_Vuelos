using System;
using System.Collections;
using System.Linq;
using System.Windows.Forms;
using System.Data.SqlClient;
using LibreriaBD;
using System.Data;


namespace ProyectoVuelos {
	public partial class frmCompraBoleto : Form {

		private Random random = new Random();
		string claveBoleto;

        SqlConnection conn;

		public frmCompraBoleto() {
			InitializeComponent();
            frmMenu f = new frmMenu();
            this.conn = f.conn;
        }

		private void btnComprar_Click(object sender,EventArgs e) {
            int claveVuelo;
            string claveClub;
			string nomPasajero = txtNombrePasajero.Text;

			if(cmbCveVuelo.SelectedItem == null) {
				MessageBox.Show("DEBE SELECCIONAR UN VUELO.","AVISO",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				return;
			}

			claveVuelo = Convert.ToInt16(cmbCveVuelo.SelectedItem);

            if (chkClubPremier.Checked) {
                claveClub = txtClavePremier.Text;

                if (!existe("'" + claveClub + "'","claveClubPremier","club_premier")) {
                    MessageBox.Show("NO EXISTE ESA CLAVE DE CLUB PREMIER.","AVISO",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                }

            }

                if (nomPasajero == "") {
                    MessageBox.Show("DEBE INGRESAR EL NOMBRE DEL PASAJERO.","AVISO",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                }

                if (txtEdad.Text == "") {
                    MessageBox.Show("DEBE INGRESAR LA EDAD DEL PASAJERO.","AVISO",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                    return;
                }

                int edad = Convert.ToInt16(txtEdad.Text);
				

				if(edad<1) {
					MessageBox.Show("INGRESE UNA EDAD VÁLIDA.","AVISO",MessageBoxButtons.OK,MessageBoxIcon.Warning);
					return;
				}

            string strComando = "INSERT INTO boleto(claveBoleto, cveVuelo, cveCliente, fecha_compra)";
            strComando += " VALUES (@boleto, @vuelo, @cliente, @fecha)";

            SqlCommand cmd = new SqlCommand(strComando,conn);
            cmd.Parameters.AddWithValue("@boleto",txtClaveBoleto.Text);
            cmd.Parameters.AddWithValue("@vuelo",claveVuelo);
            int claveCliente = buscarClub(nomPasajero);
            if (claveCliente == -1) {
                guardarClienteGenerico(nomPasajero, edad);
            }
            cmd.Parameters.AddWithValue("@cliente", claveCliente);
            cmd.Parameters.AddWithValue("@fecha", DateTime.Now);

            try {
                cmd.ExecuteNonQuery();
            } catch (Exception ex) {

                MessageBox.Show(ex.Message);
                return;
            }


            MessageBox.Show("BOLETO VENDIDO.","VENTA",MessageBoxButtons.OK,MessageBoxIcon.Information);

            if (!chkClubPremier.Checked)
                revisarMillas(nomPasajero);
            else
                acumularMillas (claveCliente,claveVuelo);
			

			Limpiar();
		}

        private void acumularMillas (int clave, int vuelo) {
            // sacar millas del vuelo
            SqlDataReader lector = null;
            string strComando = "SELECT millas FROM vuelo WHERE cveVuelo = " + vuelo;
            Double millas = 0;
            lector = UsoDB.Consulta(strComando,conn);

            if (lector.HasRows)
                while (lector.Read())
                    millas = Convert.ToDouble(lector.GetValue(0));
           

            lector.Close();


            // actualizar datos
            strComando = "UPDATE club_premier SET millasAcumuladas = millasAcumuladas + @m";
            strComando += " WHERE cveCliente = @cliente";

            SqlCommand cmd = new SqlCommand(strComando,conn);
            cmd.Parameters.AddWithValue("@m", millas);
            cmd.Parameters.AddWithValue("@cliente", clave);

            try {
                cmd.ExecuteNonQuery();
            } catch (Exception ex) {

                MessageBox.Show(ex.Message);
                return;
            }
        }

        private bool existe (string valor, string campo, string tabla) {
            SqlDataReader lector = null;
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            string strComando = "SELECT * FROM " + tabla + " WHERE "+campo+ " = " + valor +";";

            lector = UsoDB.Consulta(strComando,conn);

            if (lector.HasRows) {
                lector.Close();
                return true;
            }
             
            lector.Close();
            return false;
        }

        private void revisarMillas(string nombre) {
            SqlDataReader lector;
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "MillasCliente";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@nombre",SqlDbType.VarChar,25).Value = nombre;
            cmd.Connection = conn;

            try {
               lector = cmd.ExecuteReader();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
                return;
            }
            Double resultado = 0;

            if (lector.HasRows)
                while (lector.Read())
                    resultado = Convert.ToDouble(lector.GetValue(0));

            if(resultado >5000) {
                 DialogResult result = MessageBox.Show("EL CLIENTE " + nombre + " HA VIAJADO MUCHO SIN BENEFICIOS. ¿DESEA AGREGARLO AL CLUB PREMIER?","AVISO",MessageBoxButtons.YesNo,MessageBoxIcon.Information);
                if (result.Equals(DialogResult.Yes)) {
                    frmAltaClubPremier f = new frmAltaClubPremier(nombre);
                    f.ShowDialog();
                }
            }

            lector.Close();


        }

        private void guardarClienteGenerico(string nombre, int edad) {
            string strComando = "INSERT INTO cliente(nombre)";
            strComando += " VALUES (@nombre)";

            SqlCommand cmd = new SqlCommand(strComando,conn);
            cmd.Parameters.AddWithValue("@nombre", nombre);

            try {
                cmd.ExecuteNonQuery();
            } catch (Exception ex) {

                MessageBox.Show(ex.Message);
                return;
            }

            cmd = null;

            strComando = "INSERT INTO clienteGenérico(cveCliente, edad)";
            strComando += " VALUES (@clave, @edad)";
            int clave = 0;

            string str = "SELECT MAX(cveCliente) FROM cliente";
            SqlDataReader lector = UsoDB.Consulta(str,conn);
            if (lector.HasRows)
                while (lector.Read())
                    clave = Convert.ToInt16(lector.GetValue(0));

            lector.Close();

            cmd = new SqlCommand(strComando,conn);
            cmd.Parameters.AddWithValue("@clave", clave);
            cmd.Parameters.AddWithValue("@edad", edad);

            try {
                cmd.ExecuteNonQuery();
            } catch (Exception ex) {

                MessageBox.Show(ex.Message);
                return;
            }



        }

        private int buscarClub (string nombre) {
            int clave = -1;
            SqlDataReader lector = null;
            string strComando = "SELECT cveCliente FROM cliente WHERE nombre='" + nombre+"';";

            lector = UsoDB.Consulta(strComando,conn);

            if (lector.HasRows)
                while (lector.Read())
                    clave = Convert.ToInt32(lector.GetValue(0));
                    
               

            lector.Close();
            return clave;
  

         }



    private string RandomKey(int length) {
			const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
			return new string(Enumerable.Repeat(chars,length)
			  .Select(s => s[random.Next(s.Length)]).ToArray());
		}



		private void Limpiar() {
			lblCostoTotal.Text = "";
			txtDestino.Text = "";
			txtEdad.Text = "";
			txtNombrePasajero.Text = "";
			txtOrigen.Text = "";
			lblCvePremier.Enabled = false;
			lblCvePremier.Visible = false;
			txtClavePremier.Enabled = false;
			txtClavePremier.Visible = false;
			txtNombrePasajero.Enabled = true;
			txtNombrePasajero.Text = "";
			txtClavePremier.Text = "";
			chkClubPremier.Checked = false;
			cmbCveVuelo.SelectedItem = null;

			int cont = 0;

	

			if(cont == 0) {
				MessageBox.Show("YA NO HAY VUELOS CON CAPACIDAD.","AVISO",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				this.Close();
			}

			



			CrearClave();


		}

		private void frmCompraBoleto_Load(object sender,EventArgs e) {
			CrearClave();
            SqlDataReader lector = null;
            string strComando = "SELECT v.cveVuelo FROM vuelo v INNER JOIN fecha_vuelo f ON v.cveVuelo = f.cveVuelo WHERE fecha > GETDATE();";
            lector = UsoDB.Consulta(strComando,conn);


            if (lector.HasRows) {
                cmbCveVuelo.Items.Clear();
                while (lector.Read())
                    cmbCveVuelo.Items.Add(lector.GetValue(0).ToString());
            }



            lector.Close();
          

            AutoCompleteStringCollection collection = generateCollection("claveClubPremier","club_premier");
            txtClavePremier.AutoCompleteCustomSource = collection;
            txtClavePremier.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtClavePremier.AutoCompleteSource = AutoCompleteSource.CustomSource;

            AutoCompleteStringCollection collection2 = generateCollection("nombre","cliente");
            txtNombrePasajero.AutoCompleteCustomSource = collection2;
            txtNombrePasajero.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            txtNombrePasajero.AutoCompleteSource = AutoCompleteSource.CustomSource;



        }

        private void CrearClave () {
			do {
				claveBoleto = RandomKey(15).Trim().ToUpper();
			} while (existe("'" + claveBoleto + "'","claveBoleto","boleto"));

			txtClaveBoleto.Text = claveBoleto;
		}

		private void txtClavePremier_Leave(object sender,EventArgs e) {

            revisarClave();
            


		}

        private void revisarClave () {
            if (txtClavePremier.Text == "")
                return;

            string claveClub = txtClavePremier.Text;

            SqlDataReader lector = null;
            string strComando = "SELECT c.nombre, fecha_nacimiento FROM club_premier cp INNER JOIN cliente c ON cp.cveCliente = c.cveCliente";
            strComando += " WHERE claveClubpremier = '" + claveClub + "';";

            lector = UsoDB.Consulta(strComando,conn);


            if (lector.HasRows)
                while (lector.Read()) {
                    txtNombrePasajero.Text = lector.GetValue(0).ToString();
                    DateTime fecha = Convert.ToDateTime(lector.GetValue(1));
                    int dias = (DateTime.Now.Subtract(fecha)).Days;
                    int edad = dias / 365;
                    txtEdad.Text = edad.ToString();
                } else {
                MessageBox.Show("NO EXISTE ESA CLAVE DE CLUB PREMIER.","AVISO",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                txtNombrePasajero.Text = "";
                txtEdad.Text = "";

            }

            lector.Close();

        }

        private AutoCompleteStringCollection generateCollection (string campo, string tabla) {
            SqlDataReader lector = null;
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            string strComando = "SELECT "+ campo + " FROM " + tabla+";";

            lector = UsoDB.Consulta(strComando,conn);


            if (lector.HasRows)
                while (lector.Read())
                    collection.Add(lector.GetValue(0).ToString());
                   
            


            lector.Close();
            return collection;
        }

		private void chkClubPremier_CheckedChanged(object sender,EventArgs e) {
			if (chkClubPremier.Checked) {
				lblCvePremier.Enabled = true;
				lblCvePremier.Visible = true;
				txtClavePremier.Enabled = true;
				txtClavePremier.Visible = true;
				txtNombrePasajero.Enabled = false;
                txtEdad.Enabled = false;
			} else {
				txtClavePremier.Text = "";
				lblCvePremier.Enabled = false;
				lblCvePremier.Visible = false;
				txtClavePremier.Enabled = false;
				txtClavePremier.Visible = false;
				txtNombrePasajero.Enabled = true;
                txtEdad.Enabled = true;
                txtNombrePasajero.Text = "";
                txtEdad.Text = "";
            }
		}

		private void cmbCveVuelo_SelectedIndexChanged(object sender,EventArgs e) {
			int claveVuelo = Convert.ToInt16(cmbCveVuelo.SelectedItem);

            SqlDataReader lector = null;
            string strComando = "SELECT o.nombreCiudad, d.nombreCiudad, fecha, costo FROM vuelo v INNER JOIN ciudad o ON v.origen = o.cveCiudad ";
                strComando += "INNER JOIN ciudad d ON d.cveCiudad = v.destino INNER JOIN fecha_vuelo f ON f.cveVuelo = v.cveVuelo";
                strComando += " WHERE v.cveVuelo = " + claveVuelo;

            lector = UsoDB.Consulta(strComando,conn);


            if (lector.HasRows)
                while (lector.Read()) {
                    txtOrigen.Text = lector.GetValue(0).ToString();
                    txtDestino.Text = lector.GetValue(1).ToString();
                    dateTimePicker1.Value = Convert.ToDateTime(lector.GetValue(2));
                    lblHora.Text = dateTimePicker1.Value.Hour.ToString() + ":" + dateTimePicker1.Value.Minute.ToString();
                    lblCostoTotal.Text = "$" + lector.GetValue(3).ToString();
                }
                   




            lector.Close();

		}



		private void txtEdad_KeyPress(object sender,KeyPressEventArgs e) {
			if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
				errorPEdad.SetError(txtEdad,"Sólo se permiten números.");
			else
				errorPEdad.SetError(txtEdad,"");

		}


		private void txtNombrePasajero_KeyPress(object sender,KeyPressEventArgs e) {
			if ((char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
				errorPNombre.SetError(txtNombrePasajero,"Sólo se permiten letras.");
			else
				errorPNombre.SetError(txtNombrePasajero ,"");
		}

        private void txtClavePremier_AcceptsTabChanged(object sender,EventArgs e) {
            revisarClave();
        }

        private void txtNombrePasajero_Leave(object sender,EventArgs e) {
            if (chkClubPremier.Checked)
                return;

            string nombre = txtNombrePasajero.Text;
            SqlDataReader lector = null;
            string strComando = "SELECT edad FROM cliente c INNER JOIN clienteGenérico cg ON c.cveCliente = cg.cveCliente";
                strComando += " WHERE nombre = '"+nombre+"';";

            lector = UsoDB.Consulta(strComando,conn);


            if (lector.HasRows)
                while (lector.Read())
                    txtEdad.Text = Convert.ToInt32(lector.GetValue(0)).ToString();


            lector.Close();
                
        }
    }
}
