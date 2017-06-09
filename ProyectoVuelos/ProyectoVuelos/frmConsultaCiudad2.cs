using System;
using System.Windows.Forms;
using LibreriaBD;
using System.Data.SqlClient;
using Google.Maps;
using Google.Maps.StaticMaps;
using System.Net;
using System.IO;

namespace ProyectoVuelos {
    public partial class frmConsultaCiudad2 : Form {
        SqlConnection conn;
        public frmConsultaCiudad2() {
            InitializeComponent();

            frmMenuPrincipal f = new frmMenuPrincipal();
            conn = f.conn;
        }

        private void frmConsultaCiudad2_Load(object sender,EventArgs e) {
            AutoCompleteStringCollection collection = new AutoCompleteStringCollection();
            string strComando = "SELECT cveCiudad FROM ciudad;";
            SqlDataReader lector = UsoDB.Consulta(strComando,conn);

            if (lector.HasRows) {
                cmbCiudad.Items.Clear();
                while (lector.Read()) {
                    string ciudad = lector.GetValue(0).ToString();
                    cmbCve.Items.Add(ciudad);
                    collection.Add(ciudad);
                }

            }

            cmbCiudad.AutoCompleteCustomSource = collection;
            cmbCiudad.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cmbCiudad.AutoCompleteSource = AutoCompleteSource.CustomSource;
            lector.Close();
        }

        private void cmbCve_SelectedIndexChanged(object sender,EventArgs e) {

            string strComando = "SELECT nombreCiudad, estado FROM ciudad WHERE cveCiudad = '"+ cmbCve.SelectedItem.ToString() +"';";
            SqlDataReader lector = UsoDB.Consulta(strComando,conn);
            string origen = "", destino = "";
            if (lector.HasRows) {
                cmbCiudad.Items.Clear();
                while (lector.Read()) {
                    origen = lector.GetValue(0).ToString();
                    destino = lector.GetValue(1).ToString();

                }

            }

            lector.Close();

            txtEstado.Text = destino;
            txtNombre.Text = origen;

            var map = new StaticMapRequest();
            map.Center = new Location(origen + ", " + destino);
            map.Size = new System.Drawing.Size(552,238);
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
    }
}
