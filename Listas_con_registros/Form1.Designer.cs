namespace Listas_con_registros
{
    partial class frmAgenda
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAgenda));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblFechaHora = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblCantidad = new System.Windows.Forms.ToolStripStatusLabel();
            this.Timer = new System.Windows.Forms.Timer(this.components);
            this.btnAgInicio = new System.Windows.Forms.Button();
            this.dtgContactos = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.grpDatos = new System.Windows.Forms.GroupBox();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.btnAgFinal = new System.Windows.Forms.Button();
            this.btnAgDespues = new System.Windows.Forms.Button();
            this.btnAgAntes = new System.Windows.Forms.Button();
            this.grpInserciones = new System.Windows.Forms.GroupBox();
            this.txtRefAgregar = new System.Windows.Forms.TextBox();
            this.grpEliminaciones = new System.Windows.Forms.GroupBox();
            this.txtRefEliminar = new System.Windows.Forms.TextBox();
            this.btnDeDespuesX = new System.Windows.Forms.Button();
            this.btnDeX = new System.Windows.Forms.Button();
            this.btnDeAntesX = new System.Windows.Forms.Button();
            this.btnDeFinal = new System.Windows.Forms.Button();
            this.btnDeInicio = new System.Windows.Forms.Button();
            this.cboBuscar = new System.Windows.Forms.ComboBox();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgContactos)).BeginInit();
            this.grpDatos.SuspendLayout();
            this.grpInserciones.SuspendLayout();
            this.grpEliminaciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.White;
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblFechaHora,
            this.lblCantidad});
            this.statusStrip1.Location = new System.Drawing.Point(0, 355);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(872, 22);
            this.statusStrip1.TabIndex = 18;
            this.statusStrip1.Text = "statusStrip1";
            this.statusStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.statusStrip1_ItemClicked);
            // 
            // lblFechaHora
            // 
            this.lblFechaHora.Name = "lblFechaHora";
            this.lblFechaHora.Size = new System.Drawing.Size(0, 17);
            // 
            // lblCantidad
            // 
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(181, 17);
            this.lblCantidad.Text = "Cantidad de elementos de lista: 0";
            // 
            // Timer
            // 
            this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
            // 
            // btnAgInicio
            // 
            this.btnAgInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgInicio.Location = new System.Drawing.Point(17, 28);
            this.btnAgInicio.Name = "btnAgInicio";
            this.btnAgInicio.Size = new System.Drawing.Size(75, 23);
            this.btnAgInicio.TabIndex = 4;
            this.btnAgInicio.Text = "Inicio";
            this.btnAgInicio.UseVisualStyleBackColor = true;
            this.btnAgInicio.Click += new System.EventHandler(this.btnAgInicio_Click);
            // 
            // dtgContactos
            // 
            this.dtgContactos.BackgroundColor = System.Drawing.Color.DarkKhaki;
            this.dtgContactos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgContactos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dtgContactos.Location = new System.Drawing.Point(307, 12);
            this.dtgContactos.Name = "dtgContactos";
            this.dtgContactos.Size = new System.Drawing.Size(553, 187);
            this.dtgContactos.TabIndex = 17;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nombre y apellido";
            this.Column1.Name = "Column1";
            this.Column1.Width = 200;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Dirección";
            this.Column2.Name = "Column2";
            this.Column2.Width = 230;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Telefono";
            this.Column3.Name = "Column3";
            this.Column3.Width = 80;
            // 
            // txtNombre
            // 
            this.txtNombre.BackColor = System.Drawing.Color.DarkKhaki;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Location = new System.Drawing.Point(17, 49);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(181, 20);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Solo_Texto);
            // 
            // grpDatos
            // 
            this.grpDatos.Controls.Add(this.txtTel);
            this.grpDatos.Controls.Add(this.label3);
            this.grpDatos.Controls.Add(this.label2);
            this.grpDatos.Controls.Add(this.label1);
            this.grpDatos.Controls.Add(this.txtDireccion);
            this.grpDatos.Controls.Add(this.txtNombre);
            this.grpDatos.Location = new System.Drawing.Point(12, 12);
            this.grpDatos.Name = "grpDatos";
            this.grpDatos.Size = new System.Drawing.Size(279, 200);
            this.grpDatos.TabIndex = 6;
            this.grpDatos.TabStop = false;
            this.grpDatos.Text = "Ingreso de datos";
            // 
            // txtTel
            // 
            this.txtTel.BackColor = System.Drawing.Color.DarkKhaki;
            this.txtTel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTel.Location = new System.Drawing.Point(17, 167);
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(88, 20);
            this.txtTel.TabIndex = 2;
            this.txtTel.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Solo_Numeros);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Telefono";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Dirección";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nombre y apellido";
            // 
            // txtDireccion
            // 
            this.txtDireccion.BackColor = System.Drawing.Color.DarkKhaki;
            this.txtDireccion.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDireccion.Location = new System.Drawing.Point(17, 109);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(248, 20);
            this.txtDireccion.TabIndex = 1;
            this.txtDireccion.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAgFinal
            // 
            this.btnAgFinal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgFinal.Location = new System.Drawing.Point(17, 71);
            this.btnAgFinal.Name = "btnAgFinal";
            this.btnAgFinal.Size = new System.Drawing.Size(75, 23);
            this.btnAgFinal.TabIndex = 3;
            this.btnAgFinal.Text = "Final";
            this.btnAgFinal.UseVisualStyleBackColor = true;
            this.btnAgFinal.Click += new System.EventHandler(this.btnAgFinal_Click);
            // 
            // btnAgDespues
            // 
            this.btnAgDespues.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgDespues.Location = new System.Drawing.Point(188, 28);
            this.btnAgDespues.Name = "btnAgDespues";
            this.btnAgDespues.Size = new System.Drawing.Size(91, 23);
            this.btnAgDespues.TabIndex = 6;
            this.btnAgDespues.Text = "Depués de X";
            this.btnAgDespues.UseVisualStyleBackColor = true;
            this.btnAgDespues.Click += new System.EventHandler(this.btnAgDespues_Click);
            // 
            // btnAgAntes
            // 
            this.btnAgAntes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgAntes.Location = new System.Drawing.Point(107, 28);
            this.btnAgAntes.Name = "btnAgAntes";
            this.btnAgAntes.Size = new System.Drawing.Size(75, 23);
            this.btnAgAntes.TabIndex = 5;
            this.btnAgAntes.Text = "Antes de X";
            this.btnAgAntes.UseVisualStyleBackColor = true;
            this.btnAgAntes.Click += new System.EventHandler(this.btnAgAntes_Click);
            // 
            // grpInserciones
            // 
            this.grpInserciones.Controls.Add(this.txtRefAgregar);
            this.grpInserciones.Controls.Add(this.btnAgAntes);
            this.grpInserciones.Controls.Add(this.btnAgDespues);
            this.grpInserciones.Controls.Add(this.btnAgInicio);
            this.grpInserciones.Controls.Add(this.btnAgFinal);
            this.grpInserciones.Location = new System.Drawing.Point(12, 218);
            this.grpInserciones.Name = "grpInserciones";
            this.grpInserciones.Size = new System.Drawing.Size(291, 123);
            this.grpInserciones.TabIndex = 10;
            this.grpInserciones.TabStop = false;
            this.grpInserciones.Text = "Inserciones";
            // 
            // txtRefAgregar
            // 
            this.txtRefAgregar.BackColor = System.Drawing.Color.DarkKhaki;
            this.txtRefAgregar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRefAgregar.Location = new System.Drawing.Point(107, 74);
            this.txtRefAgregar.Name = "txtRefAgregar";
            this.txtRefAgregar.Size = new System.Drawing.Size(172, 20);
            this.txtRefAgregar.TabIndex = 7;
            this.txtRefAgregar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // grpEliminaciones
            // 
            this.grpEliminaciones.Controls.Add(this.txtRefEliminar);
            this.grpEliminaciones.Controls.Add(this.btnDeDespuesX);
            this.grpEliminaciones.Controls.Add(this.btnDeX);
            this.grpEliminaciones.Controls.Add(this.btnDeAntesX);
            this.grpEliminaciones.Controls.Add(this.btnDeFinal);
            this.grpEliminaciones.Controls.Add(this.btnDeInicio);
            this.grpEliminaciones.Location = new System.Drawing.Point(318, 218);
            this.grpEliminaciones.Name = "grpEliminaciones";
            this.grpEliminaciones.Size = new System.Drawing.Size(384, 123);
            this.grpEliminaciones.TabIndex = 11;
            this.grpEliminaciones.TabStop = false;
            this.grpEliminaciones.Text = "Eliminaciones";
            // 
            // txtRefEliminar
            // 
            this.txtRefEliminar.BackColor = System.Drawing.Color.DarkKhaki;
            this.txtRefEliminar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtRefEliminar.Location = new System.Drawing.Point(113, 74);
            this.txtRefEliminar.Name = "txtRefEliminar";
            this.txtRefEliminar.Size = new System.Drawing.Size(248, 20);
            this.txtRefEliminar.TabIndex = 13;
            this.txtRefEliminar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnDeDespuesX
            // 
            this.btnDeDespuesX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeDespuesX.Location = new System.Drawing.Point(275, 30);
            this.btnDeDespuesX.Name = "btnDeDespuesX";
            this.btnDeDespuesX.Size = new System.Drawing.Size(86, 23);
            this.btnDeDespuesX.TabIndex = 12;
            this.btnDeDespuesX.Text = "Depués de X";
            this.btnDeDespuesX.UseVisualStyleBackColor = true;
            this.btnDeDespuesX.Click += new System.EventHandler(this.btnDeDespuesX_Click);
            // 
            // btnDeX
            // 
            this.btnDeX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeX.Location = new System.Drawing.Point(113, 30);
            this.btnDeX.Name = "btnDeX";
            this.btnDeX.Size = new System.Drawing.Size(75, 23);
            this.btnDeX.TabIndex = 10;
            this.btnDeX.Text = "En X";
            this.btnDeX.UseVisualStyleBackColor = true;
            this.btnDeX.Click += new System.EventHandler(this.btnDeX_Click);
            // 
            // btnDeAntesX
            // 
            this.btnDeAntesX.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeAntesX.Location = new System.Drawing.Point(194, 30);
            this.btnDeAntesX.Name = "btnDeAntesX";
            this.btnDeAntesX.Size = new System.Drawing.Size(75, 23);
            this.btnDeAntesX.TabIndex = 11;
            this.btnDeAntesX.Text = "Antes de X";
            this.btnDeAntesX.UseVisualStyleBackColor = true;
            this.btnDeAntesX.Click += new System.EventHandler(this.btnDeAntesX_Click);
            // 
            // btnDeFinal
            // 
            this.btnDeFinal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeFinal.Location = new System.Drawing.Point(19, 71);
            this.btnDeFinal.Name = "btnDeFinal";
            this.btnDeFinal.Size = new System.Drawing.Size(75, 23);
            this.btnDeFinal.TabIndex = 9;
            this.btnDeFinal.Text = "Final";
            this.btnDeFinal.UseVisualStyleBackColor = true;
            this.btnDeFinal.Click += new System.EventHandler(this.btnDeFinal_Click);
            // 
            // btnDeInicio
            // 
            this.btnDeInicio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeInicio.Location = new System.Drawing.Point(19, 30);
            this.btnDeInicio.Name = "btnDeInicio";
            this.btnDeInicio.Size = new System.Drawing.Size(75, 23);
            this.btnDeInicio.TabIndex = 8;
            this.btnDeInicio.Text = "Inicio";
            this.btnDeInicio.UseVisualStyleBackColor = true;
            this.btnDeInicio.Click += new System.EventHandler(this.btnDeInicio_Click);
            // 
            // cboBuscar
            // 
            this.cboBuscar.BackColor = System.Drawing.Color.DarkKhaki;
            this.cboBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cboBuscar.FormattingEnabled = true;
            this.cboBuscar.Items.AddRange(new object[] {
            "Nombre y apellido",
            "Dirección",
            "Teléfono"});
            this.cboBuscar.Location = new System.Drawing.Point(728, 237);
            this.cboBuscar.Name = "cboBuscar";
            this.cboBuscar.Size = new System.Drawing.Size(121, 21);
            this.cboBuscar.TabIndex = 14;
            // 
            // txtBuscar
            // 
            this.txtBuscar.BackColor = System.Drawing.Color.DarkKhaki;
            this.txtBuscar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscar.Location = new System.Drawing.Point(728, 267);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(98, 20);
            this.txtBuscar.TabIndex = 15;
            this.txtBuscar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnBuscar
            // 
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Location = new System.Drawing.Point(728, 293);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 16;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(725, 221);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Buscar por:";
            // 
            // frmAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkKhaki;
            this.ClientSize = new System.Drawing.Size(872, 377);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.cboBuscar);
            this.Controls.Add(this.grpEliminaciones);
            this.Controls.Add(this.grpInserciones);
            this.Controls.Add(this.grpDatos);
            this.Controls.Add(this.dtgContactos);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmAgenda";
            this.Text = "Agenda telefónica";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgContactos)).EndInit();
            this.grpDatos.ResumeLayout(false);
            this.grpDatos.PerformLayout();
            this.grpInserciones.ResumeLayout(false);
            this.grpInserciones.PerformLayout();
            this.grpEliminaciones.ResumeLayout(false);
            this.grpEliminaciones.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Timer Timer;
        private System.Windows.Forms.ToolStripStatusLabel lblFechaHora;
        private System.Windows.Forms.Button btnAgInicio;
        private System.Windows.Forms.DataGridView dtgContactos;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.GroupBox grpDatos;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAgFinal;
        private System.Windows.Forms.Button btnAgDespues;
        private System.Windows.Forms.Button btnAgAntes;
        private System.Windows.Forms.GroupBox grpInserciones;
        private System.Windows.Forms.GroupBox grpEliminaciones;
        private System.Windows.Forms.Button btnDeX;
        private System.Windows.Forms.Button btnDeAntesX;
        private System.Windows.Forms.Button btnDeFinal;
        private System.Windows.Forms.Button btnDeInicio;
        private System.Windows.Forms.Button btnDeDespuesX;
        private System.Windows.Forms.ComboBox cboBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtRefAgregar;
        private System.Windows.Forms.TextBox txtRefEliminar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.ToolStripStatusLabel lblCantidad;


    }
}

