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
            this.chComi = new System.Windows.Forms.CheckBox();
            this.lblMsgError = new System.Windows.Forms.Label();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnClean = new System.Windows.Forms.Button();
            this.txtRefer = new System.Windows.Forms.TextBox();
            this.txtArti = new System.Windows.Forms.TextBox();
            this.txtIden = new System.Windows.Forms.TextBox();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.txtTelef = new System.Windows.Forms.TextBox();
            this.txtNomClie = new System.Windows.Forms.TextBox();
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
            this.tbDtSql = new System.Windows.Forms.TabPage();
            this.btnRegristar = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUser = new System.Windows.Forms.TextBox();
            this.txtDataBase = new System.Windows.Forms.TextBox();
            this.txtDataSource = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblDataBase = new System.Windows.Forms.Label();
            this.lblDataSource = new System.Windows.Forms.Label();
            this.lblDatos = new System.Windows.Forms.Label();
            this.tbMenu.SuspendLayout();
            this.tbPutClie.SuspendLayout();
            this.gbDatosGen.SuspendLayout();
            this.tbDtSql.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbMenu
            // 
            this.tbMenu.Controls.Add(this.tbPutClie);
            this.tbMenu.Controls.Add(this.tbGetClie);
            this.tbMenu.Controls.Add(this.tbDtSql);
            this.tbMenu.Location = new System.Drawing.Point(13, 25);
            this.tbMenu.Margin = new System.Windows.Forms.Padding(4);
            this.tbMenu.Name = "tbMenu";
            this.tbMenu.SelectedIndex = 0;
            this.tbMenu.Size = new System.Drawing.Size(906, 571);
            this.tbMenu.TabIndex = 0;
            // 
            // tbPutClie
            // 
            this.tbPutClie.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tbPutClie.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPutClie.Controls.Add(this.chComi);
            this.tbPutClie.Controls.Add(this.lblMsgError);
            this.tbPutClie.Controls.Add(this.btnGuardar);
            this.tbPutClie.Controls.Add(this.btnClean);
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
            this.tbPutClie.ForeColor = System.Drawing.Color.Transparent;
            this.tbPutClie.Location = new System.Drawing.Point(4, 25);
            this.tbPutClie.Margin = new System.Windows.Forms.Padding(4);
            this.tbPutClie.Name = "tbPutClie";
            this.tbPutClie.Padding = new System.Windows.Forms.Padding(4);
            this.tbPutClie.Size = new System.Drawing.Size(898, 542);
            this.tbPutClie.TabIndex = 0;
            this.tbPutClie.Text = "Insertar Clientes";
            // 
            // chComi
            // 
            this.chComi.AutoSize = true;
            this.chComi.BackColor = System.Drawing.Color.Transparent;
            this.chComi.Location = new System.Drawing.Point(629, 301);
            this.chComi.Name = "chComi";
            this.chComi.Size = new System.Drawing.Size(15, 14);
            this.chComi.TabIndex = 19;
            this.chComi.UseVisualStyleBackColor = false;
            // 
            // lblMsgError
            // 
            this.lblMsgError.AutoSize = true;
            this.lblMsgError.BackColor = System.Drawing.Color.LightCoral;
            this.lblMsgError.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblMsgError.Enabled = false;
            this.lblMsgError.ForeColor = System.Drawing.Color.Maroon;
            this.lblMsgError.Location = new System.Drawing.Point(354, 68);
            this.lblMsgError.Name = "lblMsgError";
            this.lblMsgError.Size = new System.Drawing.Size(2, 20);
            this.lblMsgError.TabIndex = 18;
            this.lblMsgError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblMsgError.Visible = false;
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
            this.btnClean.Click += new System.EventHandler(this.btnClean_Click);
            // 
            // txtRefer
            // 
            this.txtRefer.Location = new System.Drawing.Point(629, 210);
            this.txtRefer.Multiline = true;
            this.txtRefer.Name = "txtRefer";
            this.txtRefer.Size = new System.Drawing.Size(260, 34);
            this.txtRefer.TabIndex = 13;
            // 
            // txtArti
            // 
            this.txtArti.Location = new System.Drawing.Point(629, 124);
            this.txtArti.Multiline = true;
            this.txtArti.Name = "txtArti";
            this.txtArti.Size = new System.Drawing.Size(260, 33);
            this.txtArti.TabIndex = 12;
            // 
            // txtIden
            // 
            this.txtIden.Location = new System.Drawing.Point(206, 381);
            this.txtIden.Multiline = true;
            this.txtIden.Name = "txtIden";
            this.txtIden.Size = new System.Drawing.Size(260, 36);
            this.txtIden.TabIndex = 11;
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(206, 298);
            this.txtCorreo.Multiline = true;
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(260, 35);
            this.txtCorreo.TabIndex = 10;
            this.txtCorreo.TextChanged += new System.EventHandler(this.txtCorreo_TextChanged);
            // 
            // txtTelef
            // 
            this.txtTelef.Location = new System.Drawing.Point(206, 216);
            this.txtTelef.Multiline = true;
            this.txtTelef.Name = "txtTelef";
            this.txtTelef.Size = new System.Drawing.Size(260, 34);
            this.txtTelef.TabIndex = 9;
            this.txtTelef.TextChanged += new System.EventHandler(this.txtTelef_TextChanged);
            // 
            // txtNomClie
            // 
            this.txtNomClie.Location = new System.Drawing.Point(206, 124);
            this.txtNomClie.Multiline = true;
            this.txtNomClie.Name = "txtNomClie";
            this.txtNomClie.Size = new System.Drawing.Size(260, 33);
            this.txtNomClie.TabIndex = 8;
            this.txtNomClie.TextChanged += new System.EventHandler(this.txtNomClie_TextChanged);
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
            // tbDtSql
            // 
            this.tbDtSql.BackColor = System.Drawing.Color.Gainsboro;
            this.tbDtSql.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbDtSql.Controls.Add(this.btnRegristar);
            this.tbDtSql.Controls.Add(this.txtPassword);
            this.tbDtSql.Controls.Add(this.txtUser);
            this.tbDtSql.Controls.Add(this.txtDataBase);
            this.tbDtSql.Controls.Add(this.txtDataSource);
            this.tbDtSql.Controls.Add(this.lblPass);
            this.tbDtSql.Controls.Add(this.lblUser);
            this.tbDtSql.Controls.Add(this.lblDataBase);
            this.tbDtSql.Controls.Add(this.lblDataSource);
            this.tbDtSql.Controls.Add(this.lblDatos);
            this.tbDtSql.Location = new System.Drawing.Point(4, 25);
            this.tbDtSql.Name = "tbDtSql";
            this.tbDtSql.Padding = new System.Windows.Forms.Padding(3);
            this.tbDtSql.Size = new System.Drawing.Size(898, 542);
            this.tbDtSql.TabIndex = 2;
            this.tbDtSql.Text = "Datos SQL";
            // 
            // btnRegristar
            // 
            this.btnRegristar.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegristar.Location = new System.Drawing.Point(444, 476);
            this.btnRegristar.Name = "btnRegristar";
            this.btnRegristar.Size = new System.Drawing.Size(110, 29);
            this.btnRegristar.TabIndex = 9;
            this.btnRegristar.Text = "Registrar";
            this.btnRegristar.UseVisualStyleBackColor = true;
            this.btnRegristar.Click += new System.EventHandler(this.btnRegristar_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(188, 388);
            this.txtPassword.Multiline = true;
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(309, 33);
            this.txtPassword.TabIndex = 8;
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(188, 306);
            this.txtUser.Multiline = true;
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(309, 33);
            this.txtUser.TabIndex = 7;
            // 
            // txtDataBase
            // 
            this.txtDataBase.Location = new System.Drawing.Point(188, 219);
            this.txtDataBase.Multiline = true;
            this.txtDataBase.Name = "txtDataBase";
            this.txtDataBase.Size = new System.Drawing.Size(309, 33);
            this.txtDataBase.TabIndex = 6;
            // 
            // txtDataSource
            // 
            this.txtDataSource.Location = new System.Drawing.Point(188, 137);
            this.txtDataSource.Multiline = true;
            this.txtDataSource.Name = "txtDataSource";
            this.txtDataSource.Size = new System.Drawing.Size(309, 33);
            this.txtDataSource.TabIndex = 5;
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.BackColor = System.Drawing.Color.Transparent;
            this.lblPass.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPass.Location = new System.Drawing.Point(60, 390);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(82, 18);
            this.lblPass.TabIndex = 4;
            this.lblPass.Text = "Password:";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.BackColor = System.Drawing.Color.Transparent;
            this.lblUser.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(60, 308);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(47, 18);
            this.lblUser.TabIndex = 3;
            this.lblUser.Text = "User:";
            // 
            // lblDataBase
            // 
            this.lblDataBase.AutoSize = true;
            this.lblDataBase.BackColor = System.Drawing.Color.Transparent;
            this.lblDataBase.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataBase.Location = new System.Drawing.Point(60, 221);
            this.lblDataBase.Name = "lblDataBase";
            this.lblDataBase.Size = new System.Drawing.Size(82, 18);
            this.lblDataBase.TabIndex = 2;
            this.lblDataBase.Text = "DataBase:";
            // 
            // lblDataSource
            // 
            this.lblDataSource.AutoSize = true;
            this.lblDataSource.BackColor = System.Drawing.Color.Transparent;
            this.lblDataSource.Font = new System.Drawing.Font("Arial Black", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataSource.Location = new System.Drawing.Point(60, 139);
            this.lblDataSource.Name = "lblDataSource";
            this.lblDataSource.Size = new System.Drawing.Size(97, 18);
            this.lblDataSource.TabIndex = 1;
            this.lblDataSource.Text = "DataSource:";
            // 
            // lblDatos
            // 
            this.lblDatos.AutoSize = true;
            this.lblDatos.BackColor = System.Drawing.Color.Transparent;
            this.lblDatos.Font = new System.Drawing.Font("Arial Black", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatos.Location = new System.Drawing.Point(57, 34);
            this.lblDatos.Name = "lblDatos";
            this.lblDatos.Size = new System.Drawing.Size(92, 33);
            this.lblDatos.TabIndex = 0;
            this.lblDatos.Text = "Datos";
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
            this.Load += new System.EventHandler(this.Menu_Load);
            this.tbMenu.ResumeLayout(false);
            this.tbPutClie.ResumeLayout(false);
            this.tbPutClie.PerformLayout();
            this.gbDatosGen.ResumeLayout(false);
            this.gbDatosGen.PerformLayout();
            this.tbDtSql.ResumeLayout(false);
            this.tbDtSql.PerformLayout();
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
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnClean;
        private System.Windows.Forms.Label lblMsgError;
        private System.Windows.Forms.CheckBox chComi;
        private System.Windows.Forms.TabPage tbDtSql;
        private System.Windows.Forms.TextBox txtUser;
        private System.Windows.Forms.TextBox txtDataBase;
        private System.Windows.Forms.TextBox txtDataSource;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblDataBase;
        private System.Windows.Forms.Label lblDataSource;
        private System.Windows.Forms.Label lblDatos;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnRegristar;
        private System.Windows.Forms.Label lblUser;
    }
}