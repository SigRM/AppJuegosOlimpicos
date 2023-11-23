
namespace AppJuegoOlimpico.UI.Procesos
{
    partial class FrmInscripciones
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmInscripciones));
            this.lblInicio = new System.Windows.Forms.Label();
            this.dtpInicio = new System.Windows.Forms.DateTimePicker();
            this.lblFin = new System.Windows.Forms.Label();
            this.dtpFin = new System.Windows.Forms.DateTimePicker();
            this.rdbCompra = new System.Windows.Forms.RadioButton();
            this.rdbVenta = new System.Windows.Forms.RadioButton();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.dgvTipoCambio = new System.Windows.Forms.DataGridView();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.btnCrear = new System.Windows.Forms.ToolStripButton();
            this.btnLimpiar = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.btnCorreo = new System.Windows.Forms.ToolStripButton();
            this.btnPDF = new System.Windows.Forms.ToolStripButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.gBxBCCR = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTipoCambio = new System.Windows.Forms.TextBox();
            this.txtMontoCRC = new System.Windows.Forms.TextBox();
            this.txtUSD = new System.Windows.Forms.TextBox();
            this.txtInscripcionId = new System.Windows.Forms.TextBox();
            this.txtTorneoId = new System.Windows.Forms.TextBox();
            this.txtJugadorId = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmbModalidadPago = new System.Windows.Forms.ComboBox();
            this.chkEstado = new System.Windows.Forms.CheckBox();
            this.dgvInscripcion = new System.Windows.Forms.DataGridView();
            this.colInscripcionId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFechaInscripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colModalidadPago = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCRC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.coUSD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTipoCambio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTorneoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colJugadorId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtCorreo = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoCambio)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.gBxBCCR.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscripcion)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInicio
            // 
            this.lblInicio.AutoSize = true;
            this.lblInicio.Location = new System.Drawing.Point(41, 41);
            this.lblInicio.Name = "lblInicio";
            this.lblInicio.Size = new System.Drawing.Size(32, 13);
            this.lblInicio.TabIndex = 0;
            this.lblInicio.Text = "Inicio";
            // 
            // dtpInicio
            // 
            this.dtpInicio.Location = new System.Drawing.Point(100, 33);
            this.dtpInicio.Name = "dtpInicio";
            this.dtpInicio.Size = new System.Drawing.Size(200, 20);
            this.dtpInicio.TabIndex = 1;
            // 
            // lblFin
            // 
            this.lblFin.AutoSize = true;
            this.lblFin.Location = new System.Drawing.Point(41, 85);
            this.lblFin.Name = "lblFin";
            this.lblFin.Size = new System.Drawing.Size(21, 13);
            this.lblFin.TabIndex = 2;
            this.lblFin.Text = "Fin";
            // 
            // dtpFin
            // 
            this.dtpFin.Location = new System.Drawing.Point(100, 77);
            this.dtpFin.Name = "dtpFin";
            this.dtpFin.Size = new System.Drawing.Size(200, 20);
            this.dtpFin.TabIndex = 4;
            // 
            // rdbCompra
            // 
            this.rdbCompra.AutoSize = true;
            this.rdbCompra.Location = new System.Drawing.Point(321, 37);
            this.rdbCompra.Name = "rdbCompra";
            this.rdbCompra.Size = new System.Drawing.Size(61, 17);
            this.rdbCompra.TabIndex = 5;
            this.rdbCompra.TabStop = true;
            this.rdbCompra.Text = "Compra";
            this.rdbCompra.UseVisualStyleBackColor = true;
            // 
            // rdbVenta
            // 
            this.rdbVenta.AutoSize = true;
            this.rdbVenta.Location = new System.Drawing.Point(321, 81);
            this.rdbVenta.Name = "rdbVenta";
            this.rdbVenta.Size = new System.Drawing.Size(53, 17);
            this.rdbVenta.TabIndex = 6;
            this.rdbVenta.TabStop = true;
            this.rdbVenta.Text = "Venta";
            this.rdbVenta.UseVisualStyleBackColor = true;
            // 
            // btnConsultar
            // 
            this.btnConsultar.Location = new System.Drawing.Point(396, 40);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(123, 38);
            this.btnConsultar.TabIndex = 7;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // dgvTipoCambio
            // 
            this.dgvTipoCambio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTipoCambio.Location = new System.Drawing.Point(541, 19);
            this.dgvTipoCambio.Name = "dgvTipoCambio";
            this.dgvTipoCambio.Size = new System.Drawing.Size(276, 87);
            this.dgvTipoCambio.TabIndex = 8;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSalir,
            this.btnCrear,
            this.btnLimpiar,
            this.btnEliminar,
            this.btnCorreo,
            this.btnPDF});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(887, 25);
            this.toolStrip1.TabIndex = 9;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSalir
            // 
            this.btnSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSalir.Image = ((System.Drawing.Image)(resources.GetObject("btnSalir.Image")));
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(23, 22);
            this.btnSalir.Text = "Salir";
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCrear.Image = ((System.Drawing.Image)(resources.GetObject("btnCrear.Image")));
            this.btnCrear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(23, 22);
            this.btnCrear.Text = "Crear";
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(23, 22);
            this.btnLimpiar.Text = "Actualizar";
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(23, 22);
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnCorreo
            // 
            this.btnCorreo.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCorreo.Image = ((System.Drawing.Image)(resources.GetObject("btnCorreo.Image")));
            this.btnCorreo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCorreo.Name = "btnCorreo";
            this.btnCorreo.Size = new System.Drawing.Size(23, 22);
            this.btnCorreo.Text = "Correo";
            this.btnCorreo.Click += new System.EventHandler(this.btnCorreo_Click);
            // 
            // btnPDF
            // 
            this.btnPDF.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPDF.Image = ((System.Drawing.Image)(resources.GetObject("btnPDF.Image")));
            this.btnPDF.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPDF.Name = "btnPDF";
            this.btnPDF.Size = new System.Drawing.Size(23, 22);
            this.btnPDF.Text = "Guardar en PDF";
            this.btnPDF.Click += new System.EventHandler(this.btnPDF_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 516);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(887, 22);
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // gBxBCCR
            // 
            this.gBxBCCR.Controls.Add(this.dgvTipoCambio);
            this.gBxBCCR.Controls.Add(this.btnConsultar);
            this.gBxBCCR.Controls.Add(this.rdbVenta);
            this.gBxBCCR.Controls.Add(this.lblFin);
            this.gBxBCCR.Controls.Add(this.dtpFin);
            this.gBxBCCR.Controls.Add(this.lblInicio);
            this.gBxBCCR.Controls.Add(this.dtpInicio);
            this.gBxBCCR.Controls.Add(this.rdbCompra);
            this.gBxBCCR.Location = new System.Drawing.Point(25, 39);
            this.gBxBCCR.Name = "gBxBCCR";
            this.gBxBCCR.Size = new System.Drawing.Size(833, 121);
            this.gBxBCCR.TabIndex = 11;
            this.gBxBCCR.TabStop = false;
            this.gBxBCCR.Text = "Consultar tipo de cambio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Modalidad de pago";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(372, 189);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "MontoCRC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 242);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Fecha Inscripcion";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(372, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "MontoUSD";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(372, 290);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Tipo Cambio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(693, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Estado";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 192);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "Inscripcion Id";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(693, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 13);
            this.label8.TabIndex = 20;
            this.label8.Text = "Torneo Id";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(693, 242);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 21;
            this.label9.Text = "Jugador Id";
            // 
            // txtTipoCambio
            // 
            this.txtTipoCambio.Location = new System.Drawing.Point(455, 282);
            this.txtTipoCambio.Name = "txtTipoCambio";
            this.txtTipoCambio.Size = new System.Drawing.Size(200, 20);
            this.txtTipoCambio.TabIndex = 22;
            // 
            // txtMontoCRC
            // 
            this.txtMontoCRC.Location = new System.Drawing.Point(455, 182);
            this.txtMontoCRC.Name = "txtMontoCRC";
            this.txtMontoCRC.Size = new System.Drawing.Size(200, 20);
            this.txtMontoCRC.TabIndex = 23;
            // 
            // txtUSD
            // 
            this.txtUSD.Location = new System.Drawing.Point(455, 231);
            this.txtUSD.Name = "txtUSD";
            this.txtUSD.Size = new System.Drawing.Size(200, 20);
            this.txtUSD.TabIndex = 24;
            // 
            // txtInscripcionId
            // 
            this.txtInscripcionId.Location = new System.Drawing.Point(133, 189);
            this.txtInscripcionId.Name = "txtInscripcionId";
            this.txtInscripcionId.Size = new System.Drawing.Size(200, 20);
            this.txtInscripcionId.TabIndex = 25;
            // 
            // txtTorneoId
            // 
            this.txtTorneoId.Location = new System.Drawing.Point(758, 185);
            this.txtTorneoId.Name = "txtTorneoId";
            this.txtTorneoId.Size = new System.Drawing.Size(100, 20);
            this.txtTorneoId.TabIndex = 26;
            // 
            // txtJugadorId
            // 
            this.txtJugadorId.Location = new System.Drawing.Point(758, 238);
            this.txtJugadorId.Name = "txtJugadorId";
            this.txtJugadorId.Size = new System.Drawing.Size(100, 20);
            this.txtJugadorId.TabIndex = 27;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(133, 235);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 28;
            // 
            // cmbModalidadPago
            // 
            this.cmbModalidadPago.FormattingEnabled = true;
            this.cmbModalidadPago.Location = new System.Drawing.Point(133, 281);
            this.cmbModalidadPago.Name = "cmbModalidadPago";
            this.cmbModalidadPago.Size = new System.Drawing.Size(200, 21);
            this.cmbModalidadPago.TabIndex = 29;
            // 
            // chkEstado
            // 
            this.chkEstado.AutoSize = true;
            this.chkEstado.Location = new System.Drawing.Point(758, 290);
            this.chkEstado.Name = "chkEstado";
            this.chkEstado.Size = new System.Drawing.Size(15, 14);
            this.chkEstado.TabIndex = 30;
            this.chkEstado.UseVisualStyleBackColor = true;
            // 
            // dgvInscripcion
            // 
            this.dgvInscripcion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvInscripcion.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colInscripcionId,
            this.colFechaInscripcion,
            this.colModalidadPago,
            this.colCRC,
            this.coUSD,
            this.colTipoCambio,
            this.colTorneoId,
            this.colJugadorId,
            this.colEstado});
            this.dgvInscripcion.Location = new System.Drawing.Point(31, 363);
            this.dgvInscripcion.Name = "dgvInscripcion";
            this.dgvInscripcion.Size = new System.Drawing.Size(827, 150);
            this.dgvInscripcion.TabIndex = 31;
            // 
            // colInscripcionId
            // 
            this.colInscripcionId.HeaderText = "InscripcionId";
            this.colInscripcionId.Name = "colInscripcionId";
            // 
            // colFechaInscripcion
            // 
            this.colFechaInscripcion.HeaderText = "FechaInscripcion";
            this.colFechaInscripcion.Name = "colFechaInscripcion";
            // 
            // colModalidadPago
            // 
            this.colModalidadPago.HeaderText = "ModalidadPago";
            this.colModalidadPago.Name = "colModalidadPago";
            // 
            // colCRC
            // 
            this.colCRC.HeaderText = "CRC";
            this.colCRC.Name = "colCRC";
            // 
            // coUSD
            // 
            this.coUSD.HeaderText = "USD";
            this.coUSD.Name = "coUSD";
            // 
            // colTipoCambio
            // 
            this.colTipoCambio.HeaderText = "TipoCambio";
            this.colTipoCambio.Name = "colTipoCambio";
            // 
            // colTorneoId
            // 
            this.colTorneoId.HeaderText = "TorneoId";
            this.colTorneoId.Name = "colTorneoId";
            // 
            // colJugadorId
            // 
            this.colJugadorId.HeaderText = "JugadorId";
            this.colJugadorId.Name = "colJugadorId";
            // 
            // colEstado
            // 
            this.colEstado.HeaderText = "Estado";
            this.colEstado.Name = "colEstado";
            // 
            // txtCorreo
            // 
            this.txtCorreo.Location = new System.Drawing.Point(133, 330);
            this.txtCorreo.Name = "txtCorreo";
            this.txtCorreo.Size = new System.Drawing.Size(200, 20);
            this.txtCorreo.TabIndex = 32;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 333);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(38, 13);
            this.label10.TabIndex = 33;
            this.label10.Text = "Correo";
            // 
            // FrmInscripciones
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(887, 538);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCorreo);
            this.Controls.Add(this.dgvInscripcion);
            this.Controls.Add(this.chkEstado);
            this.Controls.Add(this.cmbModalidadPago);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.txtJugadorId);
            this.Controls.Add(this.txtTorneoId);
            this.Controls.Add(this.txtInscripcionId);
            this.Controls.Add(this.txtUSD);
            this.Controls.Add(this.txtMontoCRC);
            this.Controls.Add(this.txtTipoCambio);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gBxBCCR);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip1);
            this.IsMdiContainer = true;
            this.Name = "FrmInscripciones";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmInscripciones";
            this.Load += new System.EventHandler(this.FrmInscripciones_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTipoCambio)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.gBxBCCR.ResumeLayout(false);
            this.gBxBCCR.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvInscripcion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInicio;
        private System.Windows.Forms.DateTimePicker dtpInicio;
        private System.Windows.Forms.Label lblFin;
        private System.Windows.Forms.DateTimePicker dtpFin;
        private System.Windows.Forms.RadioButton rdbCompra;
        private System.Windows.Forms.RadioButton rdbVenta;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.DataGridView dgvTipoCambio;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.ToolStripButton btnCrear;
        private System.Windows.Forms.ToolStripButton btnLimpiar;
        private System.Windows.Forms.GroupBox gBxBCCR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtTipoCambio;
        private System.Windows.Forms.TextBox txtMontoCRC;
        private System.Windows.Forms.TextBox txtUSD;
        private System.Windows.Forms.TextBox txtInscripcionId;
        private System.Windows.Forms.TextBox txtTorneoId;
        private System.Windows.Forms.TextBox txtJugadorId;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox cmbModalidadPago;
        private System.Windows.Forms.CheckBox chkEstado;
        private System.Windows.Forms.DataGridView dgvInscripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colInscripcionId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFechaInscripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn colModalidadPago;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCRC;
        private System.Windows.Forms.DataGridViewTextBoxColumn coUSD;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTipoCambio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTorneoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colJugadorId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.ToolStripButton btnCorreo;
        private System.Windows.Forms.ToolStripButton btnPDF;
        private System.Windows.Forms.TextBox txtCorreo;
        private System.Windows.Forms.Label label10;
    }
}