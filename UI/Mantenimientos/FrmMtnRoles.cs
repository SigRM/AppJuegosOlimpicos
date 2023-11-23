using AppJuegoOlimpico.BLL;
using AppJuegoOlimpico.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppJuegoOlimpico.UI.Mantenimientos
{
    public partial class FrmMtnRoles : Form
    {
        public FrmMtnRoles()
        {
            InitializeComponent();
        }

        private void FrmMtnRoles_Load(object sender, EventArgs e)
        {
            Refrescar();
        }

        void Refrescar()
        {
            dgvRoles.DataSource = new RolesBLL().GetAll();
            dgvRoles.ClearSelection();
            txtCodigo.Text = "";
            txtNombre.Text = "";

        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                var bll = new RolesBLL();
                var roles = new Entities.Roles
                {
                    Codigo = Convert.ToInt32(txtCodigo.Text),
                    Nombre = txtNombre.Text,
                };

                bll.Save(roles);
                Refrescar();
                txtCodigo.Text = "";
                txtNombre.Text = "";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvRoles.SelectedRows.Count == 0)
                {
                    throw new ApplicationException("Debe seleccionar el rol");
                }
                // obtiene el objeto seleccionado en el grid
                var roles = (Roles)dgvRoles.SelectedRows[0].DataBoundItem;

                string msg = "Are you sure?";
                var res = MessageBox.Show(msg, "Question",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    var bll = new RolesBLL();
                    bll.Delete(roles);
                    Refrescar();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void dgvRoles_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvRoles.SelectedRows.Count > 0)
            {
                // obtiene el objeto seleccionado en el grid
                var roles = (Roles)dgvRoles.SelectedRows[0].DataBoundItem;
                txtCodigo.Text = Convert.ToInt32(roles.Codigo).ToString();
                txtNombre.Text = roles.Nombre;

            }
        }
    }
}
