using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inicio
{
    public partial class frmInicio : Form
    {
        
        


        public frmInicio()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmInicio_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string cep;
            WebClient client = new WebClient();
            var content = client.DownloadString("https://viacep.com.br/ws/" + cep + "/json/");
        }

        private void URL(object aPI)
        {
            throw new NotImplementedException();
        }

        private void btnHoras_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            MessageBox.Show(now.ToString("HH:mm"));
        }

        private void btnDiaHj_Click(object sender, EventArgs e)
        {
            DateTime now = DateTime.Now;
            MessageBox.Show(now.ToString("MM/dd"));
        }

        private void btnUSDBRL_Click(object sender, EventArgs e)
        {
            
            WebClient client = new WebClient();
            var content = client.DownloadString("https://economia.awesomeapi.com.br/json/last/BRL-USD");
        }

        private void btnBRLUSD_Click(object sender, EventArgs e)
        {

        }
    }
}
