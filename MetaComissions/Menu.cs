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
            }
            else if (string.IsNullOrWhiteSpace(txtTelef.Text))
            {
                lblMsgError.Text = "El campo 'Telefono' esta vacio";
                lblMsgError.Visible = true;
                MessageBox.Show("El campo 'Telefono' esta vacio. Por favor verifique que este campo no este vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                lblMsgError.Text = "El campo 'Correo' esta vacio";
                lblMsgError.Visible = true;
                MessageBox.Show("El campo 'Correo' esta vacio. Por favor verifique que este campo no este vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            #endregion

            // region 1.2//
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

            res = Access.PutClientes(elemento);


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
                    ((TextBox)control).Text = "";
                }
                else if(control.HasChildren)
                {
                    ClearText(control);
                }
            }
        }

    }
}
