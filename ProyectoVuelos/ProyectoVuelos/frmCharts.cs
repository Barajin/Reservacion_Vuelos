using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoVuelos {
    public partial class frmCharts : Form {
        public frmCharts() {
            InitializeComponent();
        }

        private void frmCharts_Load(object sender,EventArgs e) {
             chart1.Series["Series1"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
             chart1.Series["Series1"].Points.AddXY(DateTime.Now,12.00m);
             chart1.Series["Series1"].Points.AddXY(DateTime.Now.AddDays(1),13m);
             chart1.Series["Series1"].Points.AddXY(DateTime.Now.AddDays(2),8m);
             chart1.Series["Series1"].ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
             chart1.Series["Series1"].BorderWidth = 3;
             chart1.ChartAreas["0"].AxisX.Interval = 1;
        }
    }
}
