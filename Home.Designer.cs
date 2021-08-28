
namespace Quiz_FelixAsela
{
    partial class Home
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNombre = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.gboxGenero = new System.Windows.Forms.GroupBox();
            this.rbMasculino = new System.Windows.Forms.RadioButton();
            this.rbFemenino = new System.Windows.Forms.RadioButton();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.dtpNacimiento = new System.Windows.Forms.DateTimePicker();
            this.lblNacimiento = new System.Windows.Forms.Label();
            this.lblfecha = new System.Windows.Forms.Label();
            this.btnReporte = new System.Windows.Forms.Button();
            this.rtxtResults = new System.Windows.Forms.RichTextBox();
            this.gpboxFacultad = new System.Windows.Forms.GroupBox();
            this.chkCivil = new System.Windows.Forms.CheckBox();
            this.chkIndustrial = new System.Windows.Forms.CheckBox();
            this.chkSistemas = new System.Windows.Forms.CheckBox();
            this.lblGeneroselec = new System.Windows.Forms.Label();
            this.gboxGenero.SuspendLayout();
            this.gpboxFacultad.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(30, 35);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(50, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre :";
            this.lblNombre.Click += new System.EventHandler(this.lblNombre_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(86, 32);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 1;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(261, 222);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 33);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gboxGenero
            // 
            this.gboxGenero.Controls.Add(this.rbMasculino);
            this.gboxGenero.Controls.Add(this.rbFemenino);
            this.gboxGenero.Location = new System.Drawing.Point(33, 193);
            this.gboxGenero.Name = "gboxGenero";
            this.gboxGenero.Size = new System.Drawing.Size(164, 53);
            this.gboxGenero.TabIndex = 3;
            this.gboxGenero.TabStop = false;
            this.gboxGenero.Text = "Genero";
            this.gboxGenero.Enter += new System.EventHandler(this.gboxGenero_Enter);
            // 
            // rbMasculino
            // 
            this.rbMasculino.AutoSize = true;
            this.rbMasculino.Location = new System.Drawing.Point(7, 20);
            this.rbMasculino.Name = "rbMasculino";
            this.rbMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbMasculino.TabIndex = 2;
            this.rbMasculino.Text = "Masculino";
            this.rbMasculino.UseVisualStyleBackColor = true;
            this.rbMasculino.CheckedChanged += new System.EventHandler(this.rbMasculino_CheckedChanged);
            // 
            // rbFemenino
            // 
            this.rbFemenino.AutoSize = true;
            this.rbFemenino.Location = new System.Drawing.Point(86, 20);
            this.rbFemenino.Name = "rbFemenino";
            this.rbFemenino.Size = new System.Drawing.Size(71, 17);
            this.rbFemenino.TabIndex = 1;
            this.rbFemenino.Text = "Femenino";
            this.rbFemenino.UseVisualStyleBackColor = true;
            this.rbFemenino.CheckedChanged += new System.EventHandler(this.rbFemenino_CheckedChanged);
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(30, 70);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(50, 13);
            this.lblApellido.TabIndex = 4;
            this.lblApellido.Text = "Apellido :";
            this.lblApellido.Click += new System.EventHandler(this.lblApellido_Click);
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(86, 67);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 5;
            this.txtApellido.TextChanged += new System.EventHandler(this.txtApellido_TextChanged);
            // 
            // dtpNacimiento
            // 
            this.dtpNacimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpNacimiento.Location = new System.Drawing.Point(33, 142);
            this.dtpNacimiento.Name = "dtpNacimiento";
            this.dtpNacimiento.Size = new System.Drawing.Size(196, 20);
            this.dtpNacimiento.TabIndex = 7;
            this.dtpNacimiento.Value = new System.DateTime(2021, 8, 27, 0, 0, 0, 0);
            this.dtpNacimiento.ValueChanged += new System.EventHandler(this.dtpNacimiento_ValueChanged);
            // 
            // lblNacimiento
            // 
            this.lblNacimiento.AutoSize = true;
            this.lblNacimiento.Location = new System.Drawing.Point(30, 126);
            this.lblNacimiento.Name = "lblNacimiento";
            this.lblNacimiento.Size = new System.Drawing.Size(181, 13);
            this.lblNacimiento.TabIndex = 8;
            this.lblNacimiento.Text = "Seleccione su fecha de Nacimiento :";
            this.lblNacimiento.Click += new System.EventHandler(this.lblNacimiento_Click);
            // 
            // lblfecha
            // 
            this.lblfecha.AutoSize = true;
            this.lblfecha.Location = new System.Drawing.Point(37, 177);
            this.lblfecha.Name = "lblfecha";
            this.lblfecha.Size = new System.Drawing.Size(0, 13);
            this.lblfecha.TabIndex = 9;
            // 
            // btnReporte
            // 
            this.btnReporte.Location = new System.Drawing.Point(343, 222);
            this.btnReporte.Name = "btnReporte";
            this.btnReporte.Size = new System.Drawing.Size(74, 33);
            this.btnReporte.TabIndex = 10;
            this.btnReporte.Text = "Reporte";
            this.btnReporte.UseVisualStyleBackColor = true;
            this.btnReporte.Click += new System.EventHandler(this.btnReporte_Click);
            // 
            // rtxtResults
            // 
            this.rtxtResults.Location = new System.Drawing.Point(261, 108);
            this.rtxtResults.Name = "rtxtResults";
            this.rtxtResults.Size = new System.Drawing.Size(156, 96);
            this.rtxtResults.TabIndex = 11;
            this.rtxtResults.Text = "";
            this.rtxtResults.TextChanged += new System.EventHandler(this.rtxtResults_TextChanged);
            // 
            // gpboxFacultad
            // 
            this.gpboxFacultad.Controls.Add(this.chkCivil);
            this.gpboxFacultad.Controls.Add(this.chkIndustrial);
            this.gpboxFacultad.Controls.Add(this.chkSistemas);
            this.gpboxFacultad.Location = new System.Drawing.Point(250, 12);
            this.gpboxFacultad.Name = "gpboxFacultad";
            this.gpboxFacultad.Size = new System.Drawing.Size(167, 90);
            this.gpboxFacultad.TabIndex = 12;
            this.gpboxFacultad.TabStop = false;
            this.gpboxFacultad.Text = "Facultad a la que pertenece: ";
            this.gpboxFacultad.Enter += new System.EventHandler(this.gpboxFacultad_Enter);
            // 
            // chkCivil
            // 
            this.chkCivil.AutoSize = true;
            this.chkCivil.Location = new System.Drawing.Point(11, 65);
            this.chkCivil.Name = "chkCivil";
            this.chkCivil.Size = new System.Drawing.Size(66, 17);
            this.chkCivil.TabIndex = 2;
            this.chkCivil.Text = "Ing. Civil";
            this.chkCivil.UseVisualStyleBackColor = true;
            this.chkCivil.CheckedChanged += new System.EventHandler(this.chkCivil_CheckedChanged);
            // 
            // chkIndustrial
            // 
            this.chkIndustrial.AutoSize = true;
            this.chkIndustrial.Location = new System.Drawing.Point(11, 42);
            this.chkIndustrial.Name = "chkIndustrial";
            this.chkIndustrial.Size = new System.Drawing.Size(89, 17);
            this.chkIndustrial.TabIndex = 1;
            this.chkIndustrial.Text = "Ing. Industrial";
            this.chkIndustrial.UseVisualStyleBackColor = true;
            this.chkIndustrial.CheckedChanged += new System.EventHandler(this.chkIndustrial_CheckedChanged);
            // 
            // chkSistemas
            // 
            this.chkSistemas.AutoSize = true;
            this.chkSistemas.Location = new System.Drawing.Point(11, 19);
            this.chkSistemas.Name = "chkSistemas";
            this.chkSistemas.Size = new System.Drawing.Size(153, 17);
            this.chkSistemas.TabIndex = 0;
            this.chkSistemas.Text = "Ing. Sistemas e Informatica";
            this.chkSistemas.UseVisualStyleBackColor = true;
            this.chkSistemas.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // lblGeneroselec
            // 
            this.lblGeneroselec.AutoSize = true;
            this.lblGeneroselec.Location = new System.Drawing.Point(33, 250);
            this.lblGeneroselec.Name = "lblGeneroselec";
            this.lblGeneroselec.Size = new System.Drawing.Size(0, 13);
            this.lblGeneroselec.TabIndex = 13;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 275);
            this.Controls.Add(this.lblGeneroselec);
            this.Controls.Add(this.gpboxFacultad);
            this.Controls.Add(this.rtxtResults);
            this.Controls.Add(this.btnReporte);
            this.Controls.Add(this.lblfecha);
            this.Controls.Add(this.lblNacimiento);
            this.Controls.Add(this.dtpNacimiento);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblApellido);
            this.Controls.Add(this.gboxGenero);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblNombre);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.gboxGenero.ResumeLayout(false);
            this.gboxGenero.PerformLayout();
            this.gpboxFacultad.ResumeLayout(false);
            this.gpboxFacultad.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.GroupBox gboxGenero;
        private System.Windows.Forms.RadioButton rbFemenino;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.DateTimePicker dtpNacimiento;
        private System.Windows.Forms.Label lblNacimiento;
        private System.Windows.Forms.Label lblfecha;
        private System.Windows.Forms.Button btnReporte;
        private System.Windows.Forms.RadioButton rbMasculino;
        private System.Windows.Forms.RichTextBox rtxtResults;
        private System.Windows.Forms.GroupBox gpboxFacultad;
        private System.Windows.Forms.CheckBox chkSistemas;
        private System.Windows.Forms.CheckBox chkCivil;
        private System.Windows.Forms.CheckBox chkIndustrial;
        private System.Windows.Forms.Label lblGeneroselec;
    }
}

