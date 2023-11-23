
namespace AppJuegoOlimpico.UI.Mantenimientos
{
    partial class FrmMtnCompetencias
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
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnSAlir = new System.Windows.Forms.ToolStripButton();
            this.btnCrear = new System.Windows.Forms.ToolStripButton();
            this.btnLimpiar = new System.Windows.Forms.ToolStripButton();
            this.btnEliminar = new System.Windows.Forms.ToolStripButton();
            this.txtPartidoId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.txtEquipo1Id = new System.Windows.Forms.Label();
            this.txtEquipo2Id = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEquipo1Puntos = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvCompetencias = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEquipo1Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEquipo2Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSetnumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEquipo1Puntos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEquipo2Puntos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEstado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtEquipo2Puntos = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.txtsetnumber = new System.Windows.Forms.TextBox();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompetencias)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSAlir,
            this.btnCrear,
            this.btnLimpiar,
            this.btnEliminar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(757, 25);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnSAlir
            // 
            this.btnSAlir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSAlir.Image = global::AppJuegoOlimpico.Properties.Resources.cancel_48;
            this.btnSAlir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSAlir.Name = "btnSAlir";
            this.btnSAlir.Size = new System.Drawing.Size(23, 22);
            this.btnSAlir.Text = "toolStripButton1";
            this.btnSAlir.Click += new System.EventHandler(this.btnSAlir_Click);
            // 
            // btnCrear
            // 
            this.btnCrear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCrear.Image = global::AppJuegoOlimpico.Properties.Resources.insert;
            this.btnCrear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(23, 22);
            this.btnCrear.Text = "toolStripButton3";
            this.btnCrear.Click += new System.EventHandler(this.btnCrear_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnLimpiar.Image = global::AppJuegoOlimpico.Properties.Resources.save_as_48;
            this.btnLimpiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(23, 22);
            this.btnLimpiar.Text = "toolStripButton2";
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEliminar.Image = global::AppJuegoOlimpico.Properties.Resources.waste;
            this.btnEliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(23, 22);
            this.btnEliminar.Text = "toolStripButton4";
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // txtPartidoId
            // 
            this.txtPartidoId.Location = new System.Drawing.Point(115, 40);
            this.txtPartidoId.Name = "txtPartidoId";
            this.txtPartidoId.Size = new System.Drawing.Size(200, 20);
            this.txtPartidoId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Partidos_Id";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(115, 212);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // txtEquipo1Id
            // 
            this.txtEquipo1Id.AutoSize = true;
            this.txtEquipo1Id.Location = new System.Drawing.Point(45, 104);
            this.txtEquipo1Id.Name = "txtEquipo1Id";
            this.txtEquipo1Id.Size = new System.Drawing.Size(61, 13);
            this.txtEquipo1Id.TabIndex = 4;
            this.txtEquipo1Id.Text = "Equipo1_Id";
            // 
            // txtEquipo2Id
            // 
            this.txtEquipo2Id.AutoSize = true;
            this.txtEquipo2Id.Location = new System.Drawing.Point(45, 157);
            this.txtEquipo2Id.Name = "txtEquipo2Id";
            this.txtEquipo2Id.Size = new System.Drawing.Size(61, 13);
            this.txtEquipo2Id.TabIndex = 5;
            this.txtEquipo2Id.Text = "Equipo2_Id";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Fecha";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(405, 47);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Set _Number";
            // 
            // txtEquipo1Puntos
            // 
            this.txtEquipo1Puntos.AutoSize = true;
            this.txtEquipo1Puntos.Location = new System.Drawing.Point(405, 104);
            this.txtEquipo1Puntos.Name = "txtEquipo1Puntos";
            this.txtEquipo1Puntos.Size = new System.Drawing.Size(85, 13);
            this.txtEquipo1Puntos.TabIndex = 8;
            this.txtEquipo1Puntos.Text = "Equipo1_Puntos";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(405, 157);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(85, 13);
            this.label7.TabIndex = 9;
            this.label7.Text = "Equipo2_Puntos";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(405, 218);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Estado";
            // 
            // dgvCompetencias
            // 
            this.dgvCompetencias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCompetencias.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colEquipo1Id,
            this.colEquipo2Id,
            this.colFecha,
            this.colSetnumber,
            this.colEquipo1Puntos,
            this.colEquipo2Puntos,
            this.colEstado});
            this.dgvCompetencias.Location = new System.Drawing.Point(25, 269);
            this.dgvCompetencias.Name = "dgvCompetencias";
            this.dgvCompetencias.Size = new System.Drawing.Size(700, 150);
            this.dgvCompetencias.TabIndex = 11;
            // 
            // colId
            // 
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            // 
            // colEquipo1Id
            // 
            this.colEquipo1Id.HeaderText = "E1 Id";
            this.colEquipo1Id.Name = "colEquipo1Id";
            // 
            // colEquipo2Id
            // 
            this.colEquipo2Id.HeaderText = "E2 Id";
            this.colEquipo2Id.Name = "colEquipo2Id";
            // 
            // colFecha
            // 
            this.colFecha.HeaderText = "Fecha";
            this.colFecha.Name = "colFecha";
            // 
            // colSetnumber
            // 
            this.colSetnumber.HeaderText = "# Set";
            this.colSetnumber.Name = "colSetnumber";
            // 
            // colEquipo1Puntos
            // 
            this.colEquipo1Puntos.HeaderText = "E1 Puntos";
            this.colEquipo1Puntos.Name = "colEquipo1Puntos";
            // 
            // colEquipo2Puntos
            // 
            this.colEquipo2Puntos.HeaderText = "E2 Puntos";
            this.colEquipo2Puntos.Name = "colEquipo2Puntos";
            // 
            // colEstado
            // 
            this.colEstado.HeaderText = "Estado";
            this.colEstado.Name = "colEstado";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(499, 212);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(200, 20);
            this.txtEstado.TabIndex = 13;
            // 
            // txtEquipo2Puntos
            // 
            this.txtEquipo2Puntos.Location = new System.Drawing.Point(499, 150);
            this.txtEquipo2Puntos.Name = "txtEquipo2Puntos";
            this.txtEquipo2Puntos.Size = new System.Drawing.Size(200, 20);
            this.txtEquipo2Puntos.TabIndex = 14;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(499, 97);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(200, 20);
            this.textBox5.TabIndex = 15;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(115, 150);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(200, 20);
            this.textBox6.TabIndex = 16;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(115, 97);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(200, 20);
            this.textBox7.TabIndex = 17;
            // 
            // txtsetnumber
            // 
            this.txtsetnumber.Location = new System.Drawing.Point(499, 40);
            this.txtsetnumber.Name = "txtsetnumber";
            this.txtsetnumber.Size = new System.Drawing.Size(200, 20);
            this.txtsetnumber.TabIndex = 18;
            // 
            // FrmMtnCompetencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(757, 450);
            this.Controls.Add(this.txtsetnumber);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.txtEquipo2Puntos);
            this.Controls.Add(this.txtEstado);
            this.Controls.Add(this.dgvCompetencias);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtEquipo1Puntos);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEquipo2Id);
            this.Controls.Add(this.txtEquipo1Id);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtPartidoId);
            this.Controls.Add(this.toolStrip1);
            this.Name = "FrmMtnCompetencias";
            this.Text = "FrmCompetencias";
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCompetencias)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnSAlir;
        private System.Windows.Forms.ToolStripButton btnLimpiar;
        private System.Windows.Forms.ToolStripButton btnCrear;
        private System.Windows.Forms.ToolStripButton btnEliminar;
        private System.Windows.Forms.TextBox txtPartidoId;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label txtEquipo1Id;
        private System.Windows.Forms.Label txtEquipo2Id;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtEquipo1Puntos;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvCompetencias;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtEquipo2Puntos;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox txtsetnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEquipo1Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEquipo2Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSetnumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEquipo1Puntos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEquipo2Puntos;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEstado;
    }
}