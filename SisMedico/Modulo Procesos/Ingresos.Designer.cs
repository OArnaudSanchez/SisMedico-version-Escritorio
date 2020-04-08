namespace SisMedico
{
    partial class Ingresos
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
            this.label4 = new System.Windows.Forms.Label();
            this.tID = new System.Windows.Forms.TextBox();
            this.bSeleccionarMedico = new System.Windows.Forms.Button();
            this.bSeleccionarPaciente = new System.Windows.Forms.Button();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.bLimpiar = new System.Windows.Forms.Button();
            this.ID = new System.Windows.Forms.Label();
            this.tPaciente = new System.Windows.Forms.TextBox();
            this.bEliminar = new System.Windows.Forms.Button();
            this.bBuscar = new System.Windows.Forms.Button();
            this.bModificar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tMedico = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.bAgregar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.tHabitacion = new System.Windows.Forms.TextBox();
            this.bSeleccionarHabitacion = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.lIDPaciente = new System.Windows.Forms.Label();
            this.lIDMedico = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.lIDHabitacion = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(29, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(23, 16);
            this.label4.TabIndex = 67;
            this.label4.Text = "ID";
            // 
            // tID
            // 
            this.tID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tID.Location = new System.Drawing.Point(107, 51);
            this.tID.Multiline = true;
            this.tID.Name = "tID";
            this.tID.Size = new System.Drawing.Size(123, 23);
            this.tID.TabIndex = 66;
            // 
            // bSeleccionarMedico
            // 
            this.bSeleccionarMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSeleccionarMedico.Location = new System.Drawing.Point(520, 179);
            this.bSeleccionarMedico.Name = "bSeleccionarMedico";
            this.bSeleccionarMedico.Size = new System.Drawing.Size(168, 53);
            this.bSeleccionarMedico.TabIndex = 65;
            this.bSeleccionarMedico.Text = "Seleccionar Medico";
            this.bSeleccionarMedico.UseVisualStyleBackColor = true;
            this.bSeleccionarMedico.Click += new System.EventHandler(this.bSeleccionarMedico_Click);
            // 
            // bSeleccionarPaciente
            // 
            this.bSeleccionarPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSeleccionarPaciente.Location = new System.Drawing.Point(520, 32);
            this.bSeleccionarPaciente.Name = "bSeleccionarPaciente";
            this.bSeleccionarPaciente.Size = new System.Drawing.Size(168, 53);
            this.bSeleccionarPaciente.TabIndex = 64;
            this.bSeleccionarPaciente.Text = "Seleccionar Paciente";
            this.bSeleccionarPaciente.UseVisualStyleBackColor = true;
            this.bSeleccionarPaciente.Click += new System.EventHandler(this.bSeleccionarPaciente_Click);
            // 
            // fecha
            // 
            this.fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha.Location = new System.Drawing.Point(359, 52);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(121, 22);
            this.fecha.TabIndex = 63;
            // 
            // bLimpiar
            // 
            this.bLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLimpiar.Location = new System.Drawing.Point(539, 238);
            this.bLimpiar.Name = "bLimpiar";
            this.bLimpiar.Size = new System.Drawing.Size(109, 37);
            this.bLimpiar.TabIndex = 62;
            this.bLimpiar.Text = "Limpiar";
            this.bLimpiar.UseVisualStyleBackColor = true;
            this.bLimpiar.Click += new System.EventHandler(this.bLimpiar_Click);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(29, 108);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(69, 16);
            this.ID.TabIndex = 61;
            this.ID.Text = "Paciente";
            // 
            // tPaciente
            // 
            this.tPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tPaciente.Location = new System.Drawing.Point(107, 105);
            this.tPaciente.Multiline = true;
            this.tPaciente.Name = "tPaciente";
            this.tPaciente.ReadOnly = true;
            this.tPaciente.Size = new System.Drawing.Size(123, 23);
            this.tPaciente.TabIndex = 60;
            // 
            // bEliminar
            // 
            this.bEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEliminar.Location = new System.Drawing.Point(406, 238);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(109, 37);
            this.bEliminar.TabIndex = 59;
            this.bEliminar.Text = "Eliminar";
            this.bEliminar.UseVisualStyleBackColor = true;
            this.bEliminar.Click += new System.EventHandler(this.bEliminar_Click);
            // 
            // bBuscar
            // 
            this.bBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBuscar.Location = new System.Drawing.Point(274, 238);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(109, 37);
            this.bBuscar.TabIndex = 58;
            this.bBuscar.Text = "Buscar";
            this.bBuscar.UseVisualStyleBackColor = true;
            this.bBuscar.Click += new System.EventHandler(this.bBuscar_Click);
            // 
            // bModificar
            // 
            this.bModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bModificar.Location = new System.Drawing.Point(143, 238);
            this.bModificar.Name = "bModificar";
            this.bModificar.Size = new System.Drawing.Size(109, 37);
            this.bModificar.TabIndex = 57;
            this.bModificar.Text = "Modificar";
            this.bModificar.UseVisualStyleBackColor = true;
            this.bModificar.Click += new System.EventHandler(this.bModificar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(244, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 16);
            this.label3.TabIndex = 56;
            this.label3.Text = "Fecha Ingreso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(29, 154);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 55;
            this.label2.Text = "Medico";
            // 
            // tMedico
            // 
            this.tMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tMedico.Location = new System.Drawing.Point(107, 154);
            this.tMedico.Multiline = true;
            this.tMedico.Name = "tMedico";
            this.tMedico.ReadOnly = true;
            this.tMedico.Size = new System.Drawing.Size(123, 23);
            this.tMedico.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(219, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 24);
            this.label1.TabIndex = 53;
            this.label1.Text = "Crud Ingresos";
            // 
            // bAgregar
            // 
            this.bAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAgregar.Location = new System.Drawing.Point(12, 238);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(109, 37);
            this.bAgregar.TabIndex = 52;
            this.bAgregar.Text = "Agregar";
            this.bAgregar.UseVisualStyleBackColor = true;
            this.bAgregar.Click += new System.EventHandler(this.bAgregar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 281);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(676, 186);
            this.dataGridView1.TabIndex = 51;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 16);
            this.label5.TabIndex = 69;
            this.label5.Text = "Habitacion";
            // 
            // tHabitacion
            // 
            this.tHabitacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tHabitacion.Location = new System.Drawing.Point(107, 192);
            this.tHabitacion.Multiline = true;
            this.tHabitacion.Name = "tHabitacion";
            this.tHabitacion.ReadOnly = true;
            this.tHabitacion.Size = new System.Drawing.Size(123, 23);
            this.tHabitacion.TabIndex = 68;
            // 
            // bSeleccionarHabitacion
            // 
            this.bSeleccionarHabitacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSeleccionarHabitacion.Location = new System.Drawing.Point(520, 105);
            this.bSeleccionarHabitacion.Name = "bSeleccionarHabitacion";
            this.bSeleccionarHabitacion.Size = new System.Drawing.Size(168, 53);
            this.bSeleccionarHabitacion.TabIndex = 70;
            this.bSeleccionarHabitacion.Text = "Seleccionar Habitacion";
            this.bSeleccionarHabitacion.UseVisualStyleBackColor = true;
            this.bSeleccionarHabitacion.Click += new System.EventHandler(this.bSeleccionarHabitacion_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(256, 108);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 16);
            this.label6.TabIndex = 71;
            this.label6.Text = "ID Paciente";
            // 
            // lIDPaciente
            // 
            this.lIDPaciente.AutoSize = true;
            this.lIDPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lIDPaciente.Location = new System.Drawing.Point(342, 108);
            this.lIDPaciente.Name = "lIDPaciente";
            this.lIDPaciente.Size = new System.Drawing.Size(23, 16);
            this.lIDPaciente.TabIndex = 72;
            this.lIDPaciente.Text = "ID";
            // 
            // lIDMedico
            // 
            this.lIDMedico.AutoSize = true;
            this.lIDMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lIDMedico.Location = new System.Drawing.Point(347, 154);
            this.lIDMedico.Name = "lIDMedico";
            this.lIDMedico.Size = new System.Drawing.Size(23, 16);
            this.lIDMedico.TabIndex = 74;
            this.lIDMedico.Text = "ID";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(256, 154);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 16);
            this.label9.TabIndex = 73;
            this.label9.Text = "ID Medico";
            // 
            // lIDHabitacion
            // 
            this.lIDHabitacion.AutoSize = true;
            this.lIDHabitacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lIDHabitacion.Location = new System.Drawing.Point(362, 198);
            this.lIDHabitacion.Name = "lIDHabitacion";
            this.lIDHabitacion.Size = new System.Drawing.Size(23, 16);
            this.lIDHabitacion.TabIndex = 76;
            this.lIDHabitacion.Text = "ID";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(256, 198);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(102, 16);
            this.label11.TabIndex = 75;
            this.label11.Text = "ID Habitacion";
            // 
            // Ingresos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(701, 476);
            this.Controls.Add(this.lIDHabitacion);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lIDMedico);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.lIDPaciente);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bSeleccionarHabitacion);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tHabitacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tID);
            this.Controls.Add(this.bSeleccionarMedico);
            this.Controls.Add(this.bSeleccionarPaciente);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.bLimpiar);
            this.Controls.Add(this.ID);
            this.Controls.Add(this.tPaciente);
            this.Controls.Add(this.bEliminar);
            this.Controls.Add(this.bBuscar);
            this.Controls.Add(this.bModificar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tMedico);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bAgregar);
            this.Controls.Add(this.dataGridView1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(717, 515);
            this.MinimumSize = new System.Drawing.Size(717, 515);
            this.Name = "Ingresos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingresos";
            this.Load += new System.EventHandler(this.Ingresos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tID;
        private System.Windows.Forms.Button bSeleccionarMedico;
        private System.Windows.Forms.Button bSeleccionarPaciente;
        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.Button bLimpiar;
        private System.Windows.Forms.Label ID;
        private System.Windows.Forms.TextBox tPaciente;
        private System.Windows.Forms.Button bEliminar;
        private System.Windows.Forms.Button bBuscar;
        private System.Windows.Forms.Button bModificar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tMedico;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button bAgregar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tHabitacion;
        private System.Windows.Forms.Button bSeleccionarHabitacion;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lIDPaciente;
        private System.Windows.Forms.Label lIDMedico;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lIDHabitacion;
        private System.Windows.Forms.Label label11;
    }
}