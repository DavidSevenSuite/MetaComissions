namespace MetaComissions
{
    partial class Menu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.tbMenu = new System.Windows.Forms.TabControl();
            this.tbPutClie = new System.Windows.Forms.TabPage();
            this.lblComi = new System.Windows.Forms.Label();
            this.lblRefer = new System.Windows.Forms.Label();
            this.lblArti = new System.Windows.Forms.Label();
            this.lblIden = new System.Windows.Forms.Label();
            this.lblCorreo = new System.Windows.Forms.Label();
            this.lblTelef = new System.Windows.Forms.Label();
            this.lblNomClie = new System.Windows.Forms.Label();
            this.gbDatosGen = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbGetClie = new System.Windows.Forms.TabPage();
            this.txtNomClie = new System.Windows.Forms.TextBox();
            this.txtTelef = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtIden = new System.Windows.Forms.TextBox();
            this.txtArti = new System.Windows.Forms.TextBox();
            this.txtRefer = new System.Windows.Forms.TextBox();
            this.rbComi1 = new System.Windows.Forms.RadioButton();
            this.rbComi2 = new System.Windows.Forms.RadioButton();
            this.btnClean = new System.Windows.Forms.Button();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.tbMenu.SuspendLayout();
            this.tbPutClie.SuspendLayout();
            this.gbDatosGen.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbMenu
            // 
            this.tbMenu.Controls.Add(this.tbPutClie);
            this.tbMenu.Controls.Add(this.tbGetClie);
            this.tbMenu.Location = new System.Drawing.Point(13, 25);
            this.tbMenu.Margin = new System.Windows.Forms.Padding(4);
            this.tbMenu.Name = "tbMenu";
            this.tbMenu.SelectedIndex = 0;
            this.tbMenu.Size = new System.Drawing.Size(906, 571);
            this.tbMenu.TabIndex = 0;
            // 
            // tbPutClie
            // 
            this.tbPutClie.BackColor = System.Drawing.Color.Gainsboro;
            this.tbPutClie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPutClie.Controls.Add(this.btnGuardar);
            this.tbPutClie.Controls.Add(this.btnClean);
            this.tbPutClie.Controls.Add(this.rbComi2);
            this.tbPutClie.Controls.Add(this.rbComi1);
            this.tbPutClie.Controls.Add(this.txtRefer);
            this.tbPutClie.Controls.Add(this.txtArti);
            this.tbPutClie.Controls.Add(this.txtIden);
            this.tbPutClie.Controls.Add(this.txtCorreo);
            this.tbPutClie.Controls.Add(this.txtTelef);
            this.tbPutClie.Controls.Add(this.txtNomClie);
            this.tbPutClie.Controls.Add(this.lblComi);
            this.tbPutClie.Controls.Add(this.lblRefer);
            this.tbPutClie.Controls.Add(this.lblArti);
            this.tbPutClie.Controls.Add(this.lblIden);
            this.tbPutClie.Controls.Add(this.lblCorreo);
            this.tbPutClie.Controls.Add(this.lblTelef);
            this.tbPutClie.Controls.Add(this.lblNomClie);
            this.tbPutClie.Controls.Add(this.gbDatosGen);
            this.tbPutClie.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbPutClie.Location = new System.Drawing.Point(4, 25);
            this.tbPutClie.Margin = new System.Windows.Forms.Padding(4);
            this.tbPutClie.Name = "tbPutClie";
            this.tbPutClie.Padding = new System.Windows.Forms.Padding(4);
            this.tbPutClie.Size = new System.Drawing.Size(898, 542);
            this.tbPutClie.TabIndex = 0;
            this.tbPutClie.Text = "Insertar Clientes";
            // 
            // lblComi
            // 
            this.lblComi.AutoSize = true;
            this.lblComi.BackColor = System.Drawing.Color.Transparent;
            this.lblComi.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComi.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblComi.Location = new System.Drawing.Point(475, 298);
            this.lblComi.Name = "lblComi";
            this.lblComi.Size = new System.Drawing.Size(85, 19);
            this.lblComi.TabIndex = 7;
            this.lblComi.Text = "Comision:";
            // 
            // lblRefer
            // 
            this.lblRefer.AutoSize = true;
            this.lblRefer.BackColor = System.Drawing.Color.Transparent;
            this.lblRefer.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRefer.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblRefer.Location = new System.Drawing.Point(475, 213);
            this.lblRefer.Name = "lblRefer";
            this.lblRefer.Size = new System.Drawing.Size(95, 19);
            this.lblRefer.TabIndex = 6;
            this.lblRefer.Text = "Referencia:";
            // 
            // lblArti
            // 
            this.lblArti.AutoSize = true;
            this.lblArti.BackColor = System.Drawing.Color.Transparent;
            this.lblArti.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblArti.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblArti.Location = new System.Drawing.Point(475, 124);
            this.lblArti.Name = "lblArti";
            this.lblArti.Size = new System.Drawing.Size(139, 19);
            this.lblArti.TabIndex = 5;
            this.lblArti.Text = "Articulo vendido:";
            // 
            // lblIden
            // 
            this.lblIden.AutoSize = true;
            this.lblIden.BackColor = System.Drawing.Color.Transparent;
            this.lblIden.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIden.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblIden.Location = new System.Drawing.Point(18, 384);
            this.lblIden.Name = "lblIden";
            this.lblIden.Size = new System.Drawing.Size(182, 19);
            this.lblIden.TabIndex = 4;
            this.lblIden.Text = "Identifiacion(opcional):";
            // 
            // lblCorreo
            // 
            this.lblCorreo.AutoSize = true;
            this.lblCorreo.BackColor = System.Drawing.Color.Transparent;
            this.lblCorreo.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCorreo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblCorreo.Location = new System.Drawing.Point(18, 298);
            this.lblCorreo.Name = "lblCorreo";
            this.lblCorreo.Size = new System.Drawing.Size(65, 19);
            this.lblCorreo.TabIndex = 3;
            this.lblCorreo.Text = "Correo:";
            // 
            // lblTelef
            // 
            this.lblTelef.AutoSize = true;
            this.lblTelef.BackColor = System.Drawing.Color.Transparent;
            this.lblTelef.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelef.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblTelef.Location = new System.Drawing.Point(18, 213);
            this.lblTelef.Name = "lblTelef";
            this.lblTelef.Size = new System.Drawing.Size(78, 19);
            this.lblTelef.TabIndex = 2;
            this.lblTelef.Text = "Telefono:";
            // 
            // lblNomClie
            // 
            this.lblNomClie.AutoSize = true;
            this.lblNomClie.BackColor = System.Drawing.Color.Transparent;
            this.lblNomClie.Font = new System.Drawing.Font("Arial Black", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomClie.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lblNomClie.Location = new System.Drawing.Point(18, 124);
            this.lblNomClie.Name = "lblNomClie";
            this.lblNomClie.Size = new System.Drawing.Size(158, 19);
            this.lblNomClie.TabIndex = 1;
            this.lblNomClie.Text = "Nombre del cliente:";
            // 
            // gbDatosGen
            // 
            this.gbDatosGen.BackColor = System.Drawing.Color.LightSteelBlue;
            this.gbDatosGen.Controls.Add(this.label1);
            this.gbDatosGen.Location = new System.Drawing.Point(-1, 2);
            this.gbDatosGen.Name = "gbDatosGen";
            this.gbDatosGen.Size = new System.Drawing.Size(895, 54);
            this.gbDatosGen.TabIndex = 0;
            this.gbDatosGen.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label1.Location = new System.Drawing.Point(19, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Datos Generales";
            // 
            // tbGetClie
            // 
            this.tbGetClie.BackColor = System.Drawing.Color.Gainsboro;
            this.tbGetClie.Font = new System.Drawing.Font("Arial Black", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbGetClie.Location = new System.Drawing.Point(4, 25);
            this.tbGetClie.Margin = new System.Windows.Forms.Padding(4);
            this.tbGetClie.Name = "tbGetClie";
            this.tbGetClie.Padding = new System.Windows.Forms.Padding(4);
            this.tbGetClie.Size = new System.Drawing.Size(898, 542);
            this.tbGetClie.TabIndex = 1;
            this.tbGetClie.Text = "Buscar Clientes";
            // 
            // txtNomClie
            // 
            this.txtNomClie.Location = new System.Drawing.Point(206, 124);
            this.txtNomClie.Multiline = true;
            this.txtNomClie.Name = "txtNomClie";
            this.txtNomClie.Size = new System.Drawing.Size(260, 33);
            this.txtNomClie.TabIndex = 8;
            // 
            // txtTelef
            // 
            this.txtTelef.Location = new System.Drawing.Point(206, 216);
            this.txtTelef.Multiline = true;
            this.txtTelef.Name = "txtTelef";
            this.txtTelef.Size = new System.Drawing.Size(260, 34);
            this.txtTelef.TabIndex = 9;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(206, 298);
            this.txtCorreo.Multiline = true;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(260, 35);
            this.txtCorreo.TabIndex = 10;
            // 
            // txtIden
            // 
            this.txtIden.Location = new System.Drawing.Point(206, 381);
            this.txtIden.Multiline = true;
            this.txtIden.Name = "txtIden";
            this.txtIden.Size = new System.Drawing.Size(260, 36);
            this.txtIden.TabIndex = 11;
            // 
            // txtArti
            // 
            this.txtArti.Location = new System.Drawing.Point(629, 124);
            this.txtArti.Multiline = true;
            this.txtArti.Name = "txtArti";
            this.txtArti.Size = new System.Drawing.Size(260, 33);
            this.txtArti.TabIndex = 12;
            // 
            // txtRefer
            // 
            this.txtRefer.Location = new System.Drawing.Point(629, 210);
            this.txtRefer.Multiline = true;
            this.txtRefer.Name = "txtRefer";
            this.txtRefer.Size = new System.Drawing.Size(260, 34);
            this.txtRefer.TabIndex = 13;
            // 
            // rbComi1
            // 
            this.rbComi1.AutoSize = true;
            this.rbComi1.BackColor = System.Drawing.Color.Transparent;
            this.rbComi1.Checked = true;
            this.rbComi1.Location = new System.Drawing.Point(629, 299);
            this.rbComi1.Name = "rbComi1";
            this.rbComi1.Size = new System.Drawing.Size(39, 22);
            this.rbComi1.TabIndex = 14;
            this.rbComi1.TabStop = true;
            this.rbComi1.Text = "Si";
            this.rbComi1.UseVisualStyleBackColor = false;
            // 
            // rbComi2
            // 
            this.rbComi2.AutoSize = true;
            this.rbComi2.Location = new System.Drawing.Point(693, 299);
            this.rbComi2.Name = "rbComi2";
            this.rbComi2.Size = new System.Drawing.Size(46, 22);
            this.rbComi2.TabIndex = 15;
            this.rbComi2.Text = "No";
            this.rbComi2.UseVisualStyleBackColor = true;
            // 
            // btnClean
            // 
            this.btnClean.BackColor = System.Drawing.Color.Red;
            this.btnClean.Font = new System.Drawing.Font("Arial Black", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClean.ForeColor = System.Drawing.Color.White;
            this.btnClean.Location = new System.Drawing.Point(354, 481);
            this.btnClean.Name = "btnClean";
            this.btnClean.Size = new System.Drawing.Size(112, 35);
            this.btnClean.TabIndex = 16;
            this.btnClean.Text = "Limpiar Todo";
            this.btnClean.UseVisualStyleBackColor = false;
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.Red;
            this.btnGuardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(479, 481);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(112, 35);
            this.btnGuardar.TabIndex = 17;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(932, 607);
            this.Controls.Add(this.tbMenu);
            this.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Menu";
            this.Text = "Menu";
            this.tbMenu.ResumeLayout(false);
            this.tbPutClie.ResumeLayout(false);
            this.tbPutClie.PerformLayout();
            this.gbDatosGen.ResumeLayout(false);
            this.gbDatosGen.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tbMenu;
        private System.Windows.Forms.TabPage tbPutClie;
        private System.Windows.Forms.TabPage tbGetClie;
        private System.Windows.Forms.Label lblCorreo;
        private System.Windows.Forms.Label lblTelef;
        private System.Windows.Forms.Label lblNomClie;
        private System.Windows.Forms.GroupBox gbDatosGen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblComi;
        private System.Windows.Forms.Label lblRefer;
        private System.Windows.Forms.Label lblArti;
        private System.Windows.Forms.Label lblIden;
        private System.Windows.Forms.TextBox txtRefer;
        private System.Windows.Forms.TextBox txtArti;
        private System.Windows.Forms.TextBox txtIden;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.TextBox txtTelef;
        private System.Windows.Forms.TextBox txtNomClie;
        private System.Windows.Forms.RadioButton rbComi2;
        private System.Windows.Forms.RadioButton rbComi1;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnClean;
    }
}