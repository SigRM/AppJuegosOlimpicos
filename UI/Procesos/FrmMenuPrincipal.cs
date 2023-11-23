using AppJuegoOlimpico.Entities;
using AppJuegoOlimpico.UI.Mantenimientos;
using AppJuegoOlimpico.UI.Procesos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppJuegoOlimpico
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void cerrarAppToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Close();
            }
            catch (Exception)
            {

                throw;
            }
       
        }

        private void quinesSomosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                FrmAcercaDe about = new FrmAcercaDe();
                about.Show();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int valorLogin = 0;
            string usuarioDato = "";
            string claveDato = "";

            FrmLogIn ofrmLoging = new FrmLogIn(valorLogin, usuarioDato, claveDato);
            try
            {
                ofrmLoging.ShowDialog(this);
                if (ofrmLoging.DialogResult == DialogResult.Abort || ofrmLoging.DialogResult == DialogResult.Cancel)
                {
                    Application.Exit();
                }
                this.Text = string.Format("{0} {1}", Application.ProductName, Application.ProductVersion);
                //validar el tipo de seguridad reportada
                Seguridad();

            }
            catch (Exception er)
            {
                StringBuilder msg = new StringBuilder();
                msg.AppendFormat("Message        {0}\n", er.Message);
                msg.AppendFormat("Source         {0}\n", er.Source);
                msg.AppendFormat("InnerException {0}\n", er.InnerException);
                msg.AppendFormat("StackTrace     {0}\n", er.StackTrace);
                msg.AppendFormat("TargetSite     {0}\n", er.TargetSite);
                MessageBox.Show(msg.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Seguridad()
        {
            LogIn oUsuario = LogIn.GetInstance();
            string nombre = oUsuario.Identificacion;
            string clave = oUsuario.contrasena;
            string rol = oUsuario.rol;

            string nombreRol = "";
            if (oUsuario.rol.ToString() == "1")
            {
                nombreRol = "REPORTES";
            }
            else if (oUsuario.rol.ToString() == "2")
            {
                nombreRol = "JUEZ";
            }
            else
            {
                nombreRol = "ADMINISTRADOR";
            }

            string persona = "Sigrid Rojas Murillo";

            this.Text = "App Juego Olimpico  -- Bienvenido! " + persona + " Rol: " + nombreRol;
            //   Utilities.Utiles.hablar(100, 0, this.Text);

            List<string> menus = new List<string>();//Reportes
            List<string> menus1 = new List<string>();//Juez
            List<string> menus2 = new List<string>();//Administrador

            //si el usuario es de tipo Juez
            menus1.Add("reportsToolStripMenuItem");
            menus1.Add("maintenanceToolStripMenuItem");
            menus1.Add("salirToolStripMenuItem");

            //si el usuario es de tipo Administrator
            menus2.Add("procesosToolStripMenuItem"); 
            menus2.Add("mantenimientosToolStripMenuItem"); 
            menus2.Add("reportesToolStripMenuItem");
            menus2.Add("acercaDeToolStripMenuItem");
            menus2.Add("salirToolStripMenuItem"); 

            //si el usuario es de tipo Reportes
            menus.Add("reportesToolStripMenuItem"); 
            menus.Add("salirToolStripMenuItem"); 

            if (rol != null && !rol.ToString().Trim().ToUpper().Equals(""))
            {
                if (rol.ToString().ToUpper() == "ADMINISTRATOR")
                {
                    //Deshabilitar todas las opciones del menú
                    foreach (ToolStripMenuItem opcionMenu in menuStrip1.Items) //para cada opción de la barra de menú
                    {
                        ((ToolStripMenuItem)(opcionMenu)).Enabled = false;
                    }

                    foreach (ToolStripMenuItem opcionMenu in menuStrip1.Items) //para cada opción de la barra de menú
                    {
                        opcionMenu.Enabled = menus.Exists(p => p.Equals(opcionMenu.Name, StringComparison.InvariantCultureIgnoreCase));
                    }
                }
                else
                {
                    if (rol.ToString().ToUpper() == "JUEZ")
                    {
                        //Deshabilitar todas las opciones del menú
                        foreach (ToolStripMenuItem opcionMenu in menuStrip1.Items) //para cada opción de la barra de menú
                        {
                            //((ToolStripMenuItem)(opcionMenu)).Enabled = false;
                            ((ToolStripMenuItem)(opcionMenu)).Visible = false;
                        }

                        foreach (ToolStripMenuItem opcionMenu in menuStrip1.Items) //para cada opción de la barra de menú
                        {
                            //opcionMenu.Enabled = menus1.Exists(p => p.Equals(opcionMenu.Name, StringComparison.InvariantCultureIgnoreCase));
                            opcionMenu.Visible = menus1.Exists(p => p.Equals(opcionMenu.Name, StringComparison.InvariantCultureIgnoreCase));
                        }
                    }//END EMPLOYEE
                    else
                    {
                        //Deshabilitar todas las opciones del menú
                        foreach (ToolStripMenuItem opcionMenu in menuStrip1.Items) //para cada opción de la barra de menú
                        {
                            ((ToolStripMenuItem)(opcionMenu)).Enabled = false;
                        }

                        foreach (ToolStripMenuItem opcionMenu in menuStrip1.Items) //para cada opción de la barra de menú
                        {
                            opcionMenu.Enabled = menus2.Exists(p => p.Equals(opcionMenu.Name, StringComparison.InvariantCultureIgnoreCase));
                        }
                    }//END
                }
            }
        }

        private void mantenimientoJugadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMtnJugador jugadores = new FrmMtnJugador();
            jugadores.Show();
        }

        private void mantenimientoEquiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMtnEquipos equipos = new FrmMtnEquipos();
            equipos.Show();
        }

        private void inscripcionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmInscripciones inscripciones = new FrmInscripciones();
            inscripciones.Show();
        }

        private void generarQRToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmQR qr = new FrmQR();
            qr.Show();
        }

        private void mantenimientoTorneosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMtnTorneos frm = new FrmMtnTorneos();
            frm.Show();
        }

        private void mantenimientoCompetenciasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMtnCompetencias frm = new FrmMtnCompetencias();
            frm.Show();
        }

        private void mantenimientoUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMtnUsuarios frm = new FrmMtnUsuarios();
            frm.Show();

        }

        private void mantenimientoRolesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmMtnRoles frm = new FrmMtnRoles();
            frm.Show();
        }
    }
    }
