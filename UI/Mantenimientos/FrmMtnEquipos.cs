using AppJuegoOlimpico.BLL;
using AppJuegoOlimpico.Entities;
using ProyectoV1.Utilities.Utilities;
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
    public partial class FrmMtnEquipos : Form
    {
        public FrmMtnEquipos()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMtnEquipos_Load(object sender, EventArgs e)
        {
            try
            {
                Refrescar();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        void Refrescar()
        {
            dataGridViewEquipos.DataSource = new EquipoBLL().GetAll();
            dataGridViewEquipos.ClearSelection();
            txtNombre.Text = "";
            numericUpDownId.Value = 0;
            chkEstado.Checked = false;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClean_Click(object sender, EventArgs e)
        {
            Refrescar();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                var bll = new EquipoBLL();
                var equipo = new Entities.Equipo()
                {
                    Equipo_Id= (int)numericUpDownId.Value,
                    Equipo_Nombre = txtNombre.Text,
                    Estado = chkEstado.Checked
                };

                bll.Save(equipo);
                Refrescar();
                txtNombre.Text = "";
                numericUpDownId.Value = 0; 
                chkEstado.Checked = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewEquipos.SelectedRows.Count == 0)
                {
                    throw new ApplicationException("Debe seleccionar el Id del equipo");
                }
                // obtiene el objeto seleccionado en el grid
                var equipo = (Equipo)dataGridViewEquipos.SelectedRows[0].DataBoundItem;

                string msg = "Esta seguro?";
                var res = MessageBox.Show(msg, "Question",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    var bll = new EquipoBLL();
                    bll.Delete(equipo);
                    Refrescar();

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataGridViewEquipos_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewEquipos.SelectedRows.Count > 0)
            {
                // obtiene el objeto seleccionado en el grid
                var equipo = (Equipo)dataGridViewEquipos.SelectedRows[0].DataBoundItem;
                numericUpDownId.Value = equipo.Equipo_Id;
                txtNombre.Text = equipo.Equipo_Nombre;
                chkEstado.Checked = equipo.Estado;

            }
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnPDF_Click(object sender, EventArgs e)
        {
            ExportarGrid exportar = new ExportarGrid();
            exportar.ExportarPDF2(dataGridViewEquipos, "Nuevo Equipo");
        }
    }
}


