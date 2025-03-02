using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MetaComissions
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            #region Validaciones
            //Validaciones
            if (string.IsNullOrWhiteSpace(txtNomClie.Text))
            {
                txtNomClie.Text = "*Este campo esta vacio";
                txtNomClie.ForeColor = Color.Red;
                MessageBox.Show("El campo 'Nombre de cliente' esta vacio. Por favor verifique que este campo no este vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(string.IsNullOrWhiteSpace(txtTelef.Text))
            {
                txtTelef.Text = "*Este campo esta vacio";
                txtTelef.ForeColor = Color.Red;
                MessageBox.Show("El campo 'Telefono' esta vacio. Por favor verifique que este campo no este vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                txtCorreo.Text = "*Este campo esta vacio";
                txtCorreo.ForeColor = Color.Red;
                MessageBox.Show("El campo 'Correo' esta vacio. Por favor verifique que este campo no este vacio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            #endregion
        }
    }
}
