using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Objects;
using Data;

namespace MetaComissions
{
    public partial class Menu : Form
    {

        public Menu()
        {
            InitializeComponent();
        }

        private void txtNomClie_TextChanged(object sender, EventArgs e)
        {
            if(lblMsgError.Text.Length != 0)
            {
                lblMsgError.Text = "";
                lblMsgError.Visible = false;
            }
        }

        private void txtTelef_TextChanged(object sender, EventArgs e)
        {
            if (lblMsgError.Text.Length != 0)
            {
                lblMsgError.Text = "";
                lblMsgError.Visible = false;
            }
        }

        private void txtCorreo_TextChanged(object sender, EventArgs e)
        {
            if (lblMsgError.Text.Length != 0)
            {
                lblMsgError.Text = "";
                lblMsgError.Visible = false;
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            //region 1.1//
            #region Validaciones

            //Validaciones
            if (string.IsNullOrWhiteSpace(txtNomClie.Text))
            {
                lblMsgError.Text = "El campo 'Nombre de Cliente' esta vacio";
                lblMsgError.Visible = true;
                MessageBox.Show("El campo 'Nombre de cliente' esta vacio. Por favor verifique que este campo no este vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (string.IsNullOrWhiteSpace(txtTelef.Text))
            {
                lblMsgError.Text = "El campo 'Telefono' esta vacio";
                lblMsgError.Visible = true;
                MessageBox.Show("El campo 'Telefono' esta vacio. Por favor verifique que este campo no este vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                lblMsgError.Text = "El campo 'Correo' esta vacio";
                lblMsgError.Visible = true;
                MessageBox.Show("El campo 'Correo' esta vacio. Por favor verifique que este campo no este vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            #endregion

            // region 1.2 //
            // Mostrar el progressBar y inhabilitar el boton de guardar
            progressBar1.Visible = true;
            progressBar1.Style = ProgressBarStyle.Marquee;
            btnGuardar.Enabled = false;
            bool ok = false;
            try
            {
                // region 1.3//
                //Asignacion los datos al objeto

                Clientes elemento = new Clientes();
                elemento.nombre_clie = txtNomClie.Text;
                elemento.telefono = int.Parse(txtTelef.Text);
                elemento.correo = txtCorreo.Text;
                elemento.identificacion = int.Parse(txtIden.Text);
                elemento.articulo_vendi = txtArti.Text;
                elemento.referencia = txtRefer.Text;
                elemento.comision = chComi.Checked;

                //region 1.3//
                // Se envia a la clase Access aqui es donde se conecta con el SQL y inserta los datos
                int res;

                res = Access.PutClientes(0, elemento, false);

                if(res == -247890)
                {
                    MessageBox.Show("Error! No se pudieron guardar estos datos","Error",MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ok = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                progressBar1.Visible = false;
                btnGuardar.Enabled = true;
                if (!ok) { ClearText(this); }
            }

        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            ClearText(this);
        }

        // Funcion para limpiar todos los textbox
        private void ClearText(Control contenedor)
        {
            foreach(Control control in contenedor.Controls)
            {
                if(control is TextBox)
                {
                    if (((TextBox)control).Name != "txtDataSource" && ((TextBox)control).Name != "txtUser" &&
                    ((TextBox)control).Name != "txtPassword")
                    {
                       ((TextBox)control).Text = "";
                    }
                }
                else if(control.HasChildren)
                {
                    ClearText(control);
                }
            }
        }

        #region Guardar y cargar datos del connection string

        // Region 1.99
        //Registrar datos de la instancia del SQL
        private void btnRegristar_Click(object sender, EventArgs e)
        {

            Properties.Settings.Default.DataSource = txtDataSource.Text;
            //Properties.Settings.Default.DataBase = txtDataBase.Text;
            Properties.Settings.Default.User = txtUser.Text;
            Properties.Settings.Default.Password = txtPassword.Text;
            Properties.Settings.Default.Save();

            if(txtDataSource.Text.Length != 0 || txtDataBase.Text.Length != 0 ||
               txtUser.Text.Length != 0 || txtPassword.Text.Length != 0)
            {
                 MessageBox.Show("Datos guardados con exito!", "Exito!", MessageBoxButtons.OK);
            }
            else
            {
                MessageBox.Show("Por favor verifique sus datos ya que estan vacios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        // Funcion para cargar los datos del connection en los campos en el Load del form
        private void ChargeConfig()
        {

            txtDataSource.Text = Properties.Settings.Default.DataSource;
            //txtDataBase.Text = Properties.Settings.Default.DataBase;
            txtUser.Text = Properties.Settings.Default.User;
            txtPassword.Text = Properties.Settings.Default.Password;

            //Colocamos los datos del Connection string en la clase

            ConnectionString.DataSource = Properties.Settings.Default.DataSource;
            ConnectionString.User = Properties.Settings.Default.User;
            ConnectionString.Password = Properties.Settings.Default.Password;

        }

        #endregion

        private void Menu_Load(object sender, EventArgs e)
        {
            ChargeConfig();
            //dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                ClientesFil elemento = new ClientesFil();
                DataTable dt = new DataTable();

                elemento.Filnombre_clie = txtFilNomClie.Text;
                elemento.Filtelefono = (txtFilTelef.Text == "" ? 0 : int.Parse(txtFilTelef.Text));
                elemento.Filcorreo = txtFilCorreo.Text;
                elemento.Filidentificacion =(txtFilIden.Text == "" ? 0 : int.Parse(txtFilIden.Text));
                elemento.Filarticulo_vendi = txtFilArtiVendi.Text;
                elemento.Filreferencia = txtFilRefer.Text;
                elemento.Filcomision = chComi.Checked;

                dt = Access.GetClientes(elemento);

                dataGridView1.DataSource = dt;

                DataGridViewCheckBoxColumn column = new DataGridViewCheckBoxColumn();
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                //Personalizacion del dataGridView
                dataGridView1.Columns["Id"].Visible = false;
                dataGridView1.Columns["Comision"].Visible = false;
                dataGridView1.Columns["Nombre_clie"].HeaderText = "Nombre";
                dataGridView1.Columns["Telefono"].HeaderText = "Telefono";
                dataGridView1.Columns["Correo"].HeaderText = "Correo";
                dataGridView1.Columns["Identificacion"].HeaderText = "Iden.";
                dataGridView1.Columns["Arti_vendi"].HeaderText = "Articulo";
                dataGridView1.Columns["referencia"].HeaderText = "Referencia";
                column.Name = "Comision";
                column.HeaderText = "Comision";
                dataGridView1.Columns.Add(column);
                dataGridView1.Columns["Comi"].DataPropertyName = "Comision";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos: {ex.Message}");
            }
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            Clientes elemento = new Clientes();

            int id_clie = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["Id"].ToString());
            elemento.nombre_clie = dataGridView1.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();
            elemento.telefono = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["Telefono"].Value.ToString());
            elemento.correo = dataGridView1.Rows[e.RowIndex].Cells["Telefono"].Value.ToString();
            elemento.identificacion = int.Parse(dataGridView1.Rows[e.RowIndex].Cells.ToString());
            elemento.articulo_vendi = dataGridView1.Rows[e.RowIndex].Cells["Artiuclo"].ToString();
            elemento.referencia = dataGridView1.Rows[e.RowIndex].Cells["Referencia"].ToString();
            elemento.comision = bool.Parse(dataGridView1.Rows[e.RowIndex].Cells["Comision"].ToString());

            Access.PutClientes(id_clie, elemento, false);
        }
    }
}
