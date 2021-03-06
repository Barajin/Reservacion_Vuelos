﻿using System;
using System.Windows.Forms;
using LibreriaBD;
using System.Data.SqlClient;
using Google.Maps;
using Google.Maps.StaticMaps;
using System.Net;
using System.IO;

namespace ProyectoVuelos {
	public partial class frmAltaCiudad : Form {

        SqlConnection conn;

		public frmAltaCiudad() {
			InitializeComponent();
            frmMenu f = new frmMenu();
            this.conn = f.conn;

            
		}


		private void btnGuardar_Click(object sender,EventArgs e) {

			string clave = txtClave.Text;
			string ciudad = txtCiudad.Text.Trim();
			string estado = txtEstado.Text.Trim();

			if (clave == "" || ciudad == "" || estado == "") {
				MessageBox.Show("DEBE LLENAR TODOS LOS CAMPOS.","ATENCIÓN",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				return;
			}

			if (ValidarClave(clave)) {
				MessageBox.Show("YA EXISTE UNA CIUDAD CON ESA CLAVE.","ATENCIÓN",MessageBoxButtons.OK,MessageBoxIcon.Warning);
				return;
			}


            if (ValidarCiudad(ciudad, estado)) {
                MessageBox.Show("YA EXISTE ESA CIUDAD.","ATENCIÓN",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            string strComando = "INSERT INTO ciudad(cveCiudad, nombreCiudad, estado)";
			strComando += " VALUES (@clave, @nombre, @estado)";

			SqlCommand cmd = new SqlCommand(strComando,conn);
			cmd.Parameters.AddWithValue("@clave",clave);
			cmd.Parameters.AddWithValue("@nombre",ciudad);
            cmd.Parameters.AddWithValue("@estado",estado);

			try {
				cmd.ExecuteNonQuery();
			} catch (Exception ex) {

				MessageBox.Show(ex.Message);
				return;
			}

			MessageBox.Show("CIUDAD GUARDADA.","ALTA",MessageBoxButtons.OK,MessageBoxIcon.Information);
			Limpiar();

		}

		private bool ValidarClave(string cve) {
			string strComando = "SELECT * FROM ciudad WHERE cveCiudad = '" + cve + "';";

			SqlDataReader lector = UsoDB.Consulta(strComando,conn);

            if (lector.HasRows) {
                lector.Close();
                return true;
            }

            lector.Close();
            return false;
		}

        private bool ValidarCiudad(string nombre, string estado) {
            string strComando = "SELECT * FROM ciudad WHERE nombreCiudad = '" + nombre + "' AND estado = '"+estado+"';";

            SqlDataReader lector = UsoDB.Consulta(strComando,conn);

            if (lector.HasRows) {
                lector.Close();
                return true;
            }

            lector.Close();
            return false;
        }

        private void Limpiar () {
			txtEstado.Text = "";
			txtClave.Text = "";
			txtCiudad.Text = "";
            pictureBox1.Image = null;
		}

		private void txtCiudad_KeyPress(object sender,KeyPressEventArgs e) {
			if ((char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
				errorPCiudad.SetError(txtCiudad,"Sólo se permiten letras.");
			else
				errorPCiudad.SetError(txtCiudad,"");
		}

		private void txtEstado_KeyPress(object sender,KeyPressEventArgs e) {
			if ((char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
				errorPEstado.SetError(txtEstado,"Sólo se permiten letras.");
			else
				errorPEstado.SetError(txtEstado,"");
		}

		private void txtClave_KeyPress(object sender,KeyPressEventArgs e) {
			if ((char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
				errorPClave.SetError(txtClave,"Sólo se permiten letras.");
			else
				errorPClave.SetError(txtClave,"");
		}

        private void frmAltaCiudad_Load(object sender,EventArgs e) {


        }

        private void btnBuscar_Click(object sender,EventArgs e) {
            if (txtCiudad.Text == "" || txtEstado.Text == "") {
                MessageBox.Show("DEBE LLENAR TODOS LOS CAMPOS.","ATENCIÓN",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
           
            var map = new StaticMapRequest();
            map.Center = new Location(txtCiudad.Text.Trim() + ", " + txtEstado.Text.Trim());
            map.Size = new System.Drawing.Size(600,400);
            map.Zoom = 11;
            map.Sensor = false;
            var imgTagSrc = map.ToUri();


            WebClient wc = new WebClient();
            try {
                byte[] bytes = wc.DownloadData(imgTagSrc);
                MemoryStream ms = new MemoryStream(bytes);
                System.Drawing.Image img = System.Drawing.Image.FromStream(ms);

                pictureBox1.Image = img;
            } catch {
                return;
            }
            
        }

        private void bunifuTileButton1_Click(object sender,EventArgs e) {
            this.Close();
        }

        private void bunifuMaterialTextbox1_KeyPress(object sender,KeyPressEventArgs e) {

            try {
                if (txtClave.Text.Length >= 3 && !Char.IsControl(e.KeyChar))
                    e.Handled = true;
                else {
                    if (Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar)) {
                        e.KeyChar = Char.ToUpper(e.KeyChar);
                        e.Handled = false;
                    } else {
                        e.Handled = true;
                    }
                }
            } catch (FormatException) {
            }
        }

        private void txtCiudad_KeyPress_1(object sender,KeyPressEventArgs e) {
            try {
                if (txtCiudad.Text.Length >= 20 && !Char.IsControl(e.KeyChar))
                    e.Handled = true;
                else {
                    if (Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar)) {
                        e.KeyChar = Char.ToUpper(e.KeyChar);
                        e.Handled = false;
                    } else {
                        e.Handled = true;
                    }
                }
            } catch (FormatException) {
            }
        }

        private void txtEstado_KeyPress_1(object sender,KeyPressEventArgs e) {
            try {
                if (txtEstado.Text.Length >= 20 && !Char.IsControl(e.KeyChar))
                    e.Handled = true;
                else {
                    if (Char.IsLetter(e.KeyChar) || Char.IsControl(e.KeyChar) || Char.IsWhiteSpace(e.KeyChar)) {
                        e.KeyChar = Char.ToUpper(e.KeyChar);
                        e.Handled = false;
                    } else {
                        e.Handled = true;
                    }
                }
            } catch (FormatException) {
            }
        }
    }
}
