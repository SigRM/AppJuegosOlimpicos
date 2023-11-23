using AppJuegoOlimpico.BLL;
using AppJuegoOlimpico.Entities;
using appLaboratorioMedico.Utilities;
using ProyectoV1.Utilities.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppJuegoOlimpico.UI.Mantenimientos
{
    public partial class FrmMtnJugador : Form
    {
        //Se crean las variables para la instancia del formulario
        public static bool HayInstancia = false;
        public static FrmMtnJugador InstanciaActiva = null;
        Utiles utiles = new Utiles();  //Se crea una instancia a utilitarios
        LeerDatos leerDatos = new LeerDatos();
        List<Jugador> jugadorList = new List<Jugador>(); //Se crea una instancia a la clase clientes como tipo lista
        private ErrorProvider oErrorProvider = new ErrorProvider();

        public FrmMtnJugador()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMtnJugador_Load(object sender, EventArgs e)
        {
            try
            {
                /*cmbNacionalidad.DisplayMember = "Nacionalidad";
                  cmbNacionalidad.ValueMember = "Identificacion";
                  cmbNacionalidad.DataSource = new JugadorBLL().GetJugadores();*/
                

                    cmbSexo.DisplayMember = "Nombre";
                    cmbSexo.ValueMember = "Codigo";
                    cmbSexo.DataSource = new SexoBLL().GetAll();
                    Refrescar();


             /* cmbNacionalidad.Items.Add("Costarricense");
                cmbNacionalidad.Items.Add("Nicaraguense");
                cmbNacionalidad.Items.Add("Aleman");
                cmbNacionalidad.Items.Add("Italiano");

                cmbSexo.Items.Add("Mujer");
                cmbSexo.Items.Add("Hombre");*/

            }
            catch (Exception ex)
                {
                    MessageBox.Show("oooops. " + ex.Message);
                }
            }
        /// <summary>
        /// 
        /// </summary>
            private void Refrescar()
            {
                dataGridView1.DataSource = new JugadorBLL().GetJugadores();

                dataGridView1.ClearSelection();
                txtID.Text = "";
                txtIdentificacion.Text = "";
                txtTelefono.Text = "";
                txtDireccion.Text = "";
                txtCodigoEquipo.Text = "";
                txtEmail.Text = "";
          //     cmbNacionalidad.SelectedIndex = -1;
                cmbSexo.SelectedIndex = -1;
                pictureBoxCedula.Image = Properties.Resources.download__1_;
                pictureBoxCedula.Tag = null;
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
            private void pictureBoxCedula_Click(object sender, EventArgs e)
            {
                try
                {
                    var result = openFileDialog.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        pictureBoxCedula.SizeMode = PictureBoxSizeMode.Zoom;
                        pictureBoxCedula.Image = Image.FromFile(openFileDialog.FileName);
                        pictureBoxCedula.Tag = System.IO.File.ReadAllBytes(openFileDialog.FileName);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("oooops. " + ex.Message);
                }
            }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
            private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {
                // obtiene el objeto seleccionado en el grid
                var jugador = (Jugador)dataGridView1.SelectedRows[0].DataBoundItem;

                jugador.Jugador_Id = int.Parse(txtID.Text);              
                txtIdentificacion.Text = jugador.Identificacion;
                txtNombre.Text = jugador.Jugador_Nombre;             
             //   cmbNacionalidad.SelectedValue = jugador.Nacionalidad;
                cmbSexo.SelectedValue = jugador.CodigoSexo;
                txtTelefono.Text = jugador.Telefono;
                txtDireccion.Text = jugador.Direccion;
                txtCodigoEquipo.Text = jugador.CodigoEquipo.ToString();
                txtEmail.Text = jugador.CorreoElectronico;



                if (jugador.FotoCedula != null)
                {
                    pictureBoxCedula.SizeMode = PictureBoxSizeMode.Zoom;
                    pictureBoxCedula.Image = new Bitmap(new MemoryStream(jugador.FotoCedula));
                    pictureBoxCedula.Tag = jugador.FotoCedula;
                }
                else
                {
                    pictureBoxCedula.Image = Properties.Resources.download__1_;
                    pictureBoxCedula.Tag = null;
                }
            }
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
                   var jugador = new Jugador();

                   jugador.Jugador_Id = int.Parse(txtID.Text);
                   jugador.Identificacion = txtIdentificacion.Text;
                   jugador.FotoCedula = (byte[])pictureBoxCedula.Tag;
                   jugador.Jugador_Nombre = txtNombre.Text;
                 //  jugador.Nacionalidad = cmbNacionalidad.SelectedItem.ToString();                  
                   jugador.FechaNacimiento= (DateTime)dateTimePickerNac.Value;
                   jugador.Telefono = txtTelefono.Text;
                   jugador.CorreoElectronico= txtEmail.Text;
                   jugador.Direccion = txtDireccion.Text;
                   jugador.CodigoEquipo= int.Parse(txtCodigoEquipo.Text);
                   jugador.CodigoSexo = (Sexo)cmbSexo.SelectedItem;   
                   jugador.Estado = chkEstado.Enabled;

                var bll = new JugadorBLL();
                bll.Save(jugador);

                Refrescar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Oooops. " + ex.Message);
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
                if (dataGridView1.SelectedRows.Count == 0)
                {
                    throw new ApplicationException("Debe seleccionar el jugador");
                }
                // obtiene el objeto seleccionado en el grid
                var jugador = (Jugador)dataGridView1.SelectedRows[0].DataBoundItem;

                string msg = "Esta seguro?";
                var res = MessageBox.Show(msg, "Question",
                    MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (res == DialogResult.Yes)
                {
                    var bll = new JugadorBLL();
                    bll.Delete(jugador);
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
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            ExportarGrid exportar = new ExportarGrid();
            exportar.ExportarPDF2(dataGridView1, "Nuevo Jugador");
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            try
            {
                //Si txtCedula es diferente de vacio envia correo
                if (!txtID.Equals(""))
                {

                    //Construye los datos en una tabla por medio de HTML
                    String mensaje = "";
                    //Se crea una tabla algunos datos importantes para tomar en cuenta
                    //<tr>  definir una fila | <th> define un encabezado | <td> define una celda </tr> Cierre de fila | </th> Cierre de Encabezado  | </td>  Cierre de Celda  | <br>  Salto
                    mensaje += "<table width=100% border=1 cellpadding=0 cellspacing=0>";
                    //Se define una fila con una columna que dice UTN Ingreso
                    mensaje += "<tr><td bgcolor=#004080 style='color:white; padding:4px;' width=40%><strong><div align=center>Juegos Olimpicos</div></strong></td>";
                    //Se define una columna con estilo de color que indica mensaje
                    mensaje += "<td style='padding:4px;'>Bienvenido a los Juegos Olimpicos. </td></tr>";
                    mensaje += "</table><br>"; //Cierre de tabla y realiza un saldo

                    //Creación de otra tabla 
                    mensaje += "<table width=100% border=1 cellpadding=0 cellspacing=0>";
                    //Creacion de fila y se agrega un encabezado con los datos de ESTOS SON SUS DATOS
                    mensaje += "<tr><th colspan=6 style='padding:4px;'>Esta es tu informacion</th></tr>";
                    //CREACION DE FILA NUEVO
                    mensaje += "<tr>";
                    //CREACION DE CELDA CON EL TITULO ID   "ENCABEZADO"
                    mensaje += "<th bgcolor=#004080 style='color:white; padding:4px;'><div align=center>ID</div></th>";
                    //CREACION DE CELDA CON EL TITULO CEDULA    "ENCABEZADO"
                    mensaje += "<th bgcolor=#004080 style='color:white; padding:4px;'><div align=center>IDENTIFICACION</div></th>";
                    //CREACION DE CELDA CON EL TIUTLO DE NOMBRE    "ENCABEZADO"
                    mensaje += "<th bgcolor=#004080 style='color:white; padding:4px;'><div align=center>NAME</div></th>";
                    //CREACION DE CELDA CON EL TITULO NACIONALIDAD   "ENCABEZADO"
                  /*  mensaje += "<th bgcolor=#004080 style='color:white; padding:4px;'><div align=center>NACIONALIDAD</div></th>";*/
                    //CREACION DE CELDA CON TITULO DE FECHA DE NACIMIENTO   "ENCABEZADO"
                    mensaje += "<th bgcolor=#004080 style='color:white; padding:4px;'><div align=center>FECHANACIMIENTO</div></th>";             
                    //CREACION DE CELDA CON TITULO DE TELEFONO   "ENCABEZADO"
                    mensaje += "<th bgcolor=#004080 style='color:white; padding:4px;'><div align=center>TELEFONO </div></th>";
                    //CREACION DE CELDA CON TITULO DE DIRECCION   "ENCABEZADO"
                    mensaje += "<th bgcolor=#004080 style='color:white; padding:4px;'><div align=center>DIRECCION</div></th>";                   
                    //CREACION DE CELDA CON TITULO DE CORREO   "ENCABEZADO"
                    mensaje += "<th bgcolor=#004080 style='color:white; padding:4px;'><div align=center>CORREO</div></th>";                       
                    //CREACION DE CELDA CON TITULO DE CODIGOEQUIPO   "ENCABEZADO"
                    mensaje += "<th bgcolor=#004080 style='color:white; padding:4px;'><div align=center>CODIGOEQUIPO</div></th>";
                    //CREACION DE CELDA CON EL TITULO SEXO   "ENCABEZADO"
                    mensaje += "<th bgcolor=#004080 style='color:white; padding:4px;'><div align=center>SEXO</div></th>";

                    //fIN DE FILA CREADA
                    mensaje += "</tr>";
                    //CRAECION DE NUEVA FILA
                    mensaje += "<tr>";
                    //SE AGREGAN LOS VALORES EN CELDAS NUEVAS CONSTRUYENDO EL STRING
                    mensaje += String.Format("<td style='padding:4px;'><div align=center>{0}</div></td>", txtID.Text);
                    mensaje += String.Format("<td style='padding:4px;'><div align=center>{0}</div></td>", txtIdentificacion.Text);
                    //   mensaje += String.Format("<td style='padding:4px;'><div align=center>{0}</div></td>", pictureBoxCedula.Text);
                    mensaje += String.Format("<td style='padding:4px;'><div align=center>{0}</div></td>", txtNombre.Text);
                    mensaje += String.Format("<td style='padding:4px;'><div align=center>{0}</div></td>", cmbNacionalidad.Text);
                    mensaje += String.Format("<td style='padding:4px;'><div align=center>{0}</div></td>", dateTimePickerNac.Text);
                    mensaje += String.Format("<td style='padding:4px;'><div align=center>{0}</div></td>", txtTelefono.Text);
                    mensaje += String.Format("<td style='padding:4px;'><div align=center>{0}</div></td>", txtEmail.Text);
                    mensaje += String.Format("<td style='padding:4px;'><div align=center>{0}</div></td>", txtDireccion.Text);
                    mensaje += String.Format("<td style='padding:4px;'><div align=center>{0}</div></td>", txtCodigoEquipo.Text);
                    mensaje += String.Format("<td style='padding:4px;'><div align=center>{0}</div></td>", cmbSexo.Text);
                    
                    //  mensaje += String.Format("<td style='padding:4px;'><div align=center>{0}</div></td>", chkEstado.Text);


                    mensaje += "</tr>";
                    //FIN DE CREACION DE TABLA
                    mensaje += "</table>";


                    String asunto = "Jugador incluido";
                    //String ruta = Path.GetFullPath(@"..\..\Instrucciones\Practica_Leccion02.pdf");
                    String ruta = "";
                    String adjunto = ruta;
                    String receptor = txtEmail.Text;
                    EnviarCorreo envioCorreo = new EnviarCorreo();
                    envioCorreo.enviarCorreoGmail(mensaje.ToString(), receptor, asunto, adjunto);

                }
                else
                {
                    MessageBox.Show("Este correo no puede ser enviado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception er)
            {
                MessageBox.Show(utiles.mensajeCatch(er), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
  }
