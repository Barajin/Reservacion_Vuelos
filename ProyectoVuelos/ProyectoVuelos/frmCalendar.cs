using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LibreriaBD;
using System.Data.SqlClient;

namespace ProyectoVuelos {
    public partial class frmCalendar : Form {
        SqlConnection conn;

        public frmCalendar() {
            InitializeComponent();
            frmMenu f = new frmMenu();
            conn = f.conn;
            bold();



            // Change the color.
            calendar1.BackColor = System.Drawing.SystemColors.Info;
            calendar1.ForeColor = System.Drawing.Color.FromArgb(
                                     ((System.Byte)(192)),((System.Byte)(0)),((System.Byte)(192)));
            calendar1.TitleBackColor = Color.Purple;
            calendar1.TitleForeColor = Color.Yellow;
            calendar1.TrailingForeColor = Color.FromArgb(
                                     ((System.Byte)(192)),((System.Byte)(192)),((System.Byte)(0)));



            // Set the calendar to move one month at a time when navigating using the arrows.
            calendar1.ScrollChange = 1;


         
        }

  

        private void buscarFecha (DateTime fecha) {
            SqlDataReader lector = null;
            string strComando = "SELECT cveVuelo FROM fecha_vuelo WHERE DATEPART(DAY, fecha) = '" + fecha.Day + "' ";
                strComando += " AND DATEPART(MONTH, fecha) = '" + fecha.Month + "' AND DATEPART(YEAR,fecha) = '" + fecha.Year + "'";
            
       
            lector = UsoDB.Consulta(strComando,conn);

            listBox1.Items.Clear();
            if (lector.HasRows)
                while (lector.Read())
                    listBox1.Items.Add(lector.GetValue(0).ToString());
            else {
                listBox1.Items.Clear();
                limpiar();
            }

     
            lector.Close();
        }

        

        private void frmCalendar_Load(object sender,EventArgs e) {
            bold();
        }

        private void bold () {
            SqlDataReader lector = null;
            string strComando = "SELECT fecha FROM fecha_vuelo;";
            lector = UsoDB.Consulta(strComando,conn);


            if (lector.HasRows)
                while (lector.Read())
                    calendar1.AddBoldedDate(Convert.ToDateTime(lector.GetValue(0)));



            lector.Close();
        }

        private void calendar1_DateChanged(object sender,DateRangeEventArgs e) {
            DateTime fecha = e.Start.Date;
            buscarFecha(fecha.Date);
        
        }

        private void limpiar () {
            txtHora.Text = "";
            txtDestino.Text = "";
            txtBoletosVendidos.Text = "";
            txtOrigen.Text = "";
        }


        private void listBox1_SelectedIndexChanged(object sender,EventArgs e) {
            
            int claveVuelo = Convert.ToInt32(listBox1.SelectedItem);
            SqlDataReader lector = null;
            string strComando = "SELECT o.nombreCiudad, d.nombreCiudad, fecha FROM vuelo v INNER JOIN ciudad o ON v.origen = o.cveCiudad ";
            strComando += "INNER JOIN ciudad d ON d.cveCiudad = v.destino INNER JOIN fecha_vuelo f ON f.cveVuelo = v.cveVuelo";
            strComando += " WHERE v.cveVuelo = " + claveVuelo;

            lector = UsoDB.Consulta(strComando,conn);


            if (lector.HasRows)
                while (lector.Read()) {
                    txtOrigen.Text = lector.GetValue(0).ToString();
                    txtDestino.Text = lector.GetValue(1).ToString();
                    txtHora.Text = Convert.ToDateTime(lector.GetValue(2)).Hour.ToString() + ":" + Convert.ToDateTime(lector.GetValue(2)).Minute.ToString();
                    txtBoletosVendidos.Text = "";

                } 
            else
                limpiar();


            lector.Close();
        }
    }
}
