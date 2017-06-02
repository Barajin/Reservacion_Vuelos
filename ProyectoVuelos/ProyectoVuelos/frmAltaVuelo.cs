using System;
using System.Collections;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.Data.SqlClient;
using Google.Maps;
using Google.Maps.StaticMaps;
using System.Net;
using System.IO;
using LibreriaBD;

namespace ProyectoVuelos {
    public partial class frmAltaVuelo : Form {
   
        SqlConnection conn;
    
        string dias = "DIARIO";

        public frmAltaVuelo() {
            InitializeComponent();
            frmMenu f = new frmMenu();
            this.conn = f.conn;
        }

        private void btnGuardar_Click(object sender,EventArgs e) {
            int numPasajeros;
            string origen, destino;
            double costo, millas;
            DateTime fecha;


            if (cmbOrigen.SelectedItem == null || cmbDestino.SelectedItem == null) {
                MessageBox.Show("DEBE SELECCIONAR ORIGEN Y DESTINO.","ATENCIÓN",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }
      
            origen = cmbOrigen.SelectedItem.ToString();
            destino = cmbDestino.SelectedItem.ToString();

            if (destino == origen) {
                MessageBox.Show("EL DESTINO NO PUEDE SER IGUAL AL ORIGEN.","ATENCIÓN",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                return;
            }

            string ori = "", des = "";
            string str = "SELECT cveCiudad FROM ciudad WHERE nombreCiudad = '" + origen + "';";
            SqlDataReader lector = UsoDB.Consulta(str,conn);

            if (lector.HasRows)
                while (lector.Read())
                    ori = lector.GetValue(0).ToString();

            lector = null;
            lector.Close();

            str = "SELECT cveCiudad FROM ciudad WHERE nombreCiudad = '" + destino + "';";
            lector = UsoDB.Consulta(str,conn);

            if (lector.HasRows)
                while (lector.Read())
                    des = lector.GetValue(0).ToString();

            lector.Close();

            numPasajeros = Convert.ToInt16(numericNumPasajeros.Value);
            fecha = dateTimePicker0.Value;

            try {
                costo = Convert.ToDouble(txtCosto.Text);
            } catch (FormatException ne) {
                MessageBox.Show("EL COSTO DEBE SER NUMÉRICO","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }

            if (costo <= 0) {
                MessageBox.Show("EL COSTO DEBE SER MAYOR A 0.","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }

            try {
                millas = Convert.ToDouble(txtMillas.Text);
            } catch (FormatException ne) {
                MessageBox.Show("LAS MILLAS DEBEN SER NUMÉRICAS.","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }

            if (millas <= 0) {
                MessageBox.Show("LAS MILLAS DEBEN SER MAYOR QUE 0.","Aviso",MessageBoxButtons.OK,MessageBoxIcon.Information);
                return;
            }

            string strComando = "INSERT INTO vuelo(origen, destino, capacidad, costo, millas)";
            strComando += " VALUES (@origen, @destino, @capacidad, @costo, @millas)";

            SqlCommand cmd = new SqlCommand(strComando,conn);
            cmd.Parameters.AddWithValue("@origen",ori);
            cmd.Parameters.AddWithValue("@destino",des);
            cmd.Parameters.AddWithValue("@capacidad", numPasajeros);
            cmd.Parameters.AddWithValue("@costo", costo);
            cmd.Parameters.AddWithValue("@millas", millas);

            try {
                cmd.ExecuteNonQuery();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
                return;
            }

            GuardarFechas();

            MessageBox.Show("VUELO AÑADIDO CON ÉXITO.","ALTA",MessageBoxButtons.OK,MessageBoxIcon.Information);
            Limpiar();
        }

        private void GuardarFechas () {
            ArrayList fechas = new ArrayList();
            fechas.Add(dateTimePicker0.Value);
            if (chkFecha1.Checked)
                fechas.Add(dateTimePicker1.Value);
            if (chkFecha2.Checked)
                fechas.Add(dateTimePicker2.Value);
            if (chkFecha3.Checked)
                fechas.Add(dateTimePicker3.Value);
            if (chkFecha4.Checked)
                fechas.Add(dateTimePicker4.Value);

            for(int i = 0; i<fechas.Count; i++) {
                string strComando = "INSERT INTO fecha_vuelo(cveVuelo, fecha)";
                strComando += " VALUES (@clave, @fecha)";

                SqlCommand cmd = new SqlCommand(strComando,conn);
                cmd.Parameters.AddWithValue("@fecha", fechas[i].ToString());
                cmd.Parameters.AddWithValue("@clave", "");

                try {
                    cmd.ExecuteNonQuery();
                } catch (Exception ex) {

                    MessageBox.Show(ex.Message);
                    return;
                }
            }

        }



        public string getDistance(string origin,string destination) {
            System.Threading.Thread.Sleep(1000);
            String distance = "";
            string url = "http://maps.googleapis.com/maps/api/directions/json?origin=" + origin + "&destination=" + destination + "&sensor=false";
            string requesturl = url;
            string content = fileGetContents(requesturl);
            JObject o = JObject.Parse(content);
            try {
                distance = (string)o.SelectToken("routes[0].legs[0].distance.text");
                return distance;
            } catch {
                return distance;
            }

        }

        protected string fileGetContents(string fileName) {
            string sContents = string.Empty;
            string me = string.Empty;
            try {
                if (fileName.ToLower().IndexOf("http:") > -1) {
                    System.Net.WebClient wc = new System.Net.WebClient();
                    byte[] response = wc.DownloadData(fileName);
                    sContents = System.Text.Encoding.ASCII.GetString(response);

                } else {
                    System.IO.StreamReader sr = new System.IO.StreamReader(fileName);
                    sContents = sr.ReadToEnd();
                    sr.Close();
                }
            } catch { sContents = "unable to connect to server "; }
            return sContents;
        }

        private void Limpiar() {
            txtCosto.Text = "";
            txtCveVuelo.Text = "";
            txtMillas.Text = "";
            cmbDestino.SelectedItem = null;
            cmbOrigen.SelectedItem = null;
            numericNumPasajeros.Value = 1;
            dias = "DIARIO";
            txtCveVuelo.Text = "";
     


        }


        private void frmAltaVuelo_Load(object sender,EventArgs e) {

            string strComando = "SELECT nombreCiudad FROM ciudad;";
            SqlDataReader lector = UsoDB.Consulta(strComando,conn);


            if (lector.HasRows) {
                cmbOrigen.Items.Clear();
                cmbDestino.Items.Clear();
                while (lector.Read()) {
                    string ciudad = lector.GetValue(0).ToString();
                    cmbOrigen.Items.Add(ciudad);
                    cmbDestino.Items.Add(ciudad);
                }

            }

            lector.Close();

        



        }

        private void txtCosto_KeyPress(object sender,KeyPressEventArgs e) {

            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != '.'))
                errorPCosto.SetError(txtCosto,"Sólo se permiten números.");
            else
                errorPCosto.SetError(txtCosto,"");
        }

        private void txtMillas_KeyPress(object sender,KeyPressEventArgs e) {

            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back) && (e.KeyChar != '.'))
                errorPMillas.SetError(txtMillas,"Sólo se permiten números.");
            else
                errorPMillas.SetError(txtMillas,"");
        }

    
	
	

        private Double convertirMillas(string res) {
            string distancia = "";

            if (res == "" || res == null) 
                return 1;
            
            for (int i = 0; i<res.Length; i++) {
                if (Char.IsNumber(res[i]) || res[i] == '.')
                    distancia += res[i];
            }

            Double millas = Convert.ToDouble(distancia) * 0.621371;
            return millas;

        }

        private void cmbDestino_SelectedIndexChanged(object sender,EventArgs e) {
            if(cmbOrigen.SelectedItem != null)
                apiMapas();

        }

        private void cmbOrigen_SelectedIndexChanged(object sender,EventArgs e) {
            if (cmbDestino.SelectedItem != null)
                apiMapas();
        }

        private void apiMapas () {
            string origen = cmbOrigen.SelectedItem.ToString();
            string destino = cmbDestino.SelectedItem.ToString();

            txtMillas.Text = convertirMillas(getDistance(origen,destino)).ToString();

            var map = new StaticMapRequest();       
            map.Size = new System.Drawing.Size(509,333);
            map.Zoom = 1;
            map.Sensor = false;
            map.Path = new Google.Maps.Path(origen,destino);
            var imgTagSrc = map.ToUri();


            WebClient wc = new WebClient();
            byte[] bytes = wc.DownloadData(imgTagSrc);
            MemoryStream ms = new MemoryStream(bytes);
            System.Drawing.Image img = System.Drawing.Image.FromStream(ms);

            pictureBox1.Image = img;
        }

        private void btnAgregar_Click(object sender,EventArgs e) {
            panel1.Enabled = true;
            btnAgregar.Enabled = false;
        }

        private void chkFecha1_CheckedChanged(object sender,EventArgs e) {
            if (chkFecha1.Checked) 
                dateTimePicker1.Enabled = true;
            else
                dateTimePicker1.Enabled = false;

            if (chkFecha2.Checked)
                dateTimePicker2.Enabled = true;
            else
                dateTimePicker2.Enabled = false;

            if (chkFecha3.Checked)
                dateTimePicker3.Enabled = true;
            else
                dateTimePicker3.Enabled = false;

            if (chkFecha4.Checked)
                dateTimePicker4.Enabled = true;
            else
                dateTimePicker4.Enabled = false;
        }
    }
}
