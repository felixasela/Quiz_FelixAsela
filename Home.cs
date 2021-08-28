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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            rtxtResults.Text = "";
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            rtxtResults.Text = txtNombre.Text + "\r\n" + txtApellido.Text + "\r\n" + lblfecha.Text + "\r\n";

            if (rbMasculino.Checked == true)
            {
                lblGeneroselec.Text = "Masculino";
            }
            if (rbFemenino.Checked == true)
            {
                lblGeneroselec.Text = "Femenino";
            }

            rtxtResults.Text = txtNombre.Text + "\r\n" + txtApellido.Text + "\r\n" + lblfecha.Text + "\r\n" + lblGeneroselec.Text + "\r\n";

            if (chkSistemas.Checked == true)
            {
                rtxtResults.Text = txtNombre.Text + "\r\n" + txtApellido.Text + "\r\n" + lblfecha.Text + "\r\n" + lblGeneroselec.Text + "\r\n" + chkSistemas.Text + "\r\n";
            }
            if (chkIndustrial.Checked == true)
            {
                rtxtResults.Text = txtNombre.Text + "\r\n" + txtApellido.Text + "\r\n" + lblfecha.Text + "\r\n" + lblGeneroselec.Text + "\r\n" + chkIndustrial.Text + "\r\n";
            }
            if (chkCivil.Checked == true)
            {
                rtxtResults.Text = txtNombre.Text + "\r\n" + txtApellido.Text + "\r\n" + lblfecha.Text + "\r\n" + lblGeneroselec.Text + "\r\n" + chkCivil.Text + "\r\n";
            }
        }

                private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chlbEstudio_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dtpNacimiento_ValueChanged(object sender, EventArgs e)
        {
            DateTime fecha = dtpNacimiento.Value;

            lblfecha.Text = fecha.ToString();
        }

        private void lblNombre_Click(object sender, EventArgs e)
        {

        }

        private void txtApellido_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblApellido_Click(object sender, EventArgs e)
        {

        }

        private void lblNacimiento_Click(object sender, EventArgs e)
        {

        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            Report miforma = new Report(rtxtResults.Text);

            miforma.ShowDialog();
        }

        private void gboxGenero_Enter(object sender, EventArgs e)
        {

        }

        private void rbMasculino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbFemenino_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rtxtResults_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void gpboxFacultad_Enter(object sender, EventArgs e)
        {

        }

        private void chkCivil_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkIndustrial_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
