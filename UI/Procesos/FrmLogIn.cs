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

namespace AppJuegoOlimpico.UI.Procesos
{
    public partial class FrmLogIn : Form
    {
        private int contador = 0;
        private int indicativo = 0;
        private string userDato = "";
        private string passDato = "";
        /// <summary>
        /// 
        /// </summary>
        /// <param name="pIndicativo"></param>
        /// <param name="pUserDato"></param>
        /// <param name="pPassDato"></param>
        public FrmLogIn(int pIndicativo, string pUserDato, string pPassDato)
        {
            indicativo = pIndicativo;
            userDato = pUserDato;
            passDato = pPassDato;
            InitializeComponent();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmLogIn_Load(object sender, EventArgs e)
        {
            this.cmbRoles.Items.Clear();
            this.txtUsuario.Clear();
            this.txtContrasena.Clear();
            this.cmbRoles.Items.Add("Administrador");
            this.cmbRoles.Items.Add("Juez");
            this.cmbRoles.Items.Add("Reportes");
            this.cmbRoles.SelectedIndex = 0;
            this.txtUsuario.Focus();

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                LogIn oUsuario = LogIn.GetInstance();
                oUsuario.Identificacion = this.txtUsuario.Text;
                oUsuario.contrasena = this.txtContrasena.Text;
                oUsuario.rol = (this.cmbRoles.Text);
                if ((oUsuario.rol.ToString().Trim().ToUpper().Equals("ADMINISTRADOR") && oUsuario.Identificacion.ToString().Trim().ToUpper().Equals("ADMIN") && oUsuario.contrasena.ToString().Trim().ToUpper().Equals("ADMIN")) ||
                    (oUsuario.rol.ToString().Trim().ToUpper().Equals("JUEZ") && oUsuario.Identificacion.ToString().Trim().ToUpper().Equals("JUEZ") && oUsuario.contrasena.ToString().Trim().ToUpper().Equals("JUEZ")) ||
                    (oUsuario.rol.ToString().Trim().ToUpper().Equals("REPORTES") && oUsuario.Identificacion.ToString().Trim().ToUpper().Equals("REPORTES") && oUsuario.contrasena.ToString().Trim().ToUpper().Equals("REPORTES")))
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    contador++;
                    MessageBox.Show("Usuario inválido, intento No " + contador, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtContrasena.Focus();
                    if (contador == 3)
                    {
                        this.DialogResult = DialogResult.Abort;
                        Close();
                    }
                }
            }
            catch (Exception error)
            {
                contador++;
                if (error.Message.Trim().Contains("Error de inicio de sesión del usuario") == true || error.Message.Trim().Contains("Login failed") == true)
                    MessageBox.Show("Usuario inválido, intento No " + contador, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Error ->" + error.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                if (contador == 3)
                {
                    this.DialogResult = DialogResult.Abort;
                    Close();
                }
            }
        }
    }
}
