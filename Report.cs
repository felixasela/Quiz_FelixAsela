using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_FelixAsela
{
    public partial class Report : Form
    {
        public Report(string pMensaje)
        {
            InitializeComponent();

            rtxtReporte.Text = pMensaje;
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
