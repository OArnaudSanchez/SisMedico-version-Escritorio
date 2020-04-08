namespace SisMedico
{
    partial class Altas
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
            this.label5 = new System.Windows.Forms.Label();
            this.tHabitacion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tIngreso = new System.Windows.Forms.TextBox();
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
            this.bSeleccionarIngreso = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.tFechaIngreso = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tID = new System.Windows.Forms.TextBox();
            this.tMonto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.lPrecio = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(290, 58);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 16);
            this.label5.TabIndex = 89;
            this.label5.Text = "Habitacion";
            // 
            // tHabitacion
            // 
            this.tHabitacion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tHabitacion.Location = new System.Drawing.Point(385, 58);
            this.tHabitacion.Multiline = true;
            this.tHabitacion.Name = "tHabitacion";
            this.tHabitacion.ReadOnly = true;
            this.tHabitacion.Size = new System.Drawing.Size(123, 23);
            this.tHabitacion.TabIndex = 88;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(37, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 16);
            this.label4.TabIndex = 87;
            this.label4.Text = "ID Ingreso";
            // 
            // tIngreso
            // 
            this.tIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tIngreso.Location = new System.Drawing.Point(121, 117);
            this.tIngreso.Multiline = true;
            this.tIngreso.Name = "tIngreso";
            this.tIngreso.Size = new System.Drawing.Size(123, 23);
            this.tIngreso.TabIndex = 86;
            // 
            // bLimpiar
            // 
            this.bLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bLimpiar.Location = new System.Drawing.Point(726, 245);
            this.bLimpiar.Name = "bLimpiar";
            this.bLimpiar.Size = new System.Drawing.Size(105, 36);
            this.bLimpiar.TabIndex = 82;
            this.bLimpiar.Text = "Limpiar";
            this.bLimpiar.UseVisualStyleBackColor = true;
            this.bLimpiar.Click += new System.EventHandler(this.bLimpiar_Click);
            // 
            // ID
            // 
            this.ID.AutoSize = true;
            this.ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ID.Location = new System.Drawing.Point(41, 162);
            this.ID.Name = "ID";
            this.ID.Size = new System.Drawing.Size(69, 16);
            this.ID.TabIndex = 81;
            this.ID.Text = "Paciente";
            // 
            // tPaciente
            // 
            this.tPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tPaciente.Location = new System.Drawing.Point(121, 159);
            this.tPaciente.Multiline = true;
            this.tPaciente.Name = "tPaciente";
            this.tPaciente.ReadOnly = true;
            this.tPaciente.Size = new System.Drawing.Size(123, 23);
            this.tPaciente.TabIndex = 80;
            // 
            // bEliminar
            // 
            this.bEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bEliminar.Location = new System.Drawing.Point(593, 245);
            this.bEliminar.Name = "bEliminar";
            this.bEliminar.Size = new System.Drawing.Size(105, 36);
            this.bEliminar.TabIndex = 79;
            this.bEliminar.Text = "Eliminar";
            this.bEliminar.UseVisualStyleBackColor = true;
            this.bEliminar.Click += new System.EventHandler(this.bEliminar_Click);
            // 
            // bBuscar
            // 
            this.bBuscar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBuscar.Location = new System.Drawing.Point(457, 245);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(105, 36);
            this.bBuscar.TabIndex = 78;
            this.bBuscar.Text = "Buscar";
            this.bBuscar.UseVisualStyleBackColor = true;
            this.bBuscar.Click += new System.EventHandler(this.bBuscar_Click);
            // 
            // bModificar
            // 
            this.bModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bModificar.Location = new System.Drawing.Point(325, 245);
            this.bModificar.Name = "bModificar";
            this.bModificar.Size = new System.Drawing.Size(99, 36);
            this.bModificar.TabIndex = 77;
            this.bModificar.Text = "Modificar";
            this.bModificar.UseVisualStyleBackColor = true;
            this.bModificar.Click += new System.EventHandler(this.bModificar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(568, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 16);
            this.label3.TabIndex = 76;
            this.label3.Text = "Fecha Ingreso";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(293, 166);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 16);
            this.label2.TabIndex = 75;
            this.label2.Text = "Medico";
            // 
            // tMedico
            // 
            this.tMedico.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tMedico.Location = new System.Drawing.Point(385, 165);
            this.tMedico.Multiline = true;
            this.tMedico.Name = "tMedico";
            this.tMedico.ReadOnly = true;
            this.tMedico.Size = new System.Drawing.Size(123, 23);
            this.tMedico.TabIndex = 74;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(346, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 24);
            this.label1.TabIndex = 73;
            this.label1.Text = "Crud Altas";
            // 
            // bAgregar
            // 
            this.bAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bAgregar.Location = new System.Drawing.Point(198, 245);
            this.bAgregar.Name = "bAgregar";
            this.bAgregar.Size = new System.Drawing.Size(99, 36);
            this.bAgregar.TabIndex = 72;
            this.bAgregar.Text = "Agregar";
            this.bAgregar.UseVisualStyleBackColor = true;
            this.bAgregar.Click += new System.EventHandler(this.bAgregar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 287);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(825, 186);
            this.dataGridView1.TabIndex = 71;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // bSeleccionarIngreso
            // 
            this.bSeleccionarIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSeleccionarIngreso.Location = new System.Drawing.Point(17, 230);
            this.bSeleccionarIngreso.Name = "bSeleccionarIngreso";
            this.bSeleccionarIngreso.Size = new System.Drawing.Size(149, 51);
            this.bSeleccionarIngreso.TabIndex = 91;
            this.bSeleccionarIngreso.Text = "Seleccionar Ingreso";
            this.bSeleccionarIngreso.UseVisualStyleBackColor = true;
            this.bSeleccionarIngreso.Click += new System.EventHandler(this.bSeleccionarIngreso_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(572, 124);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 16);
            this.label6.TabIndex = 92;
            this.label6.Text = "Fecha Salida";
            // 
            // tFechaIngreso
            // 
            this.tFechaIngreso.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tFechaIngreso.Location = new System.Drawing.Point(676, 62);
            this.tFechaIngreso.Multiline = true;
            this.tFechaIngreso.Name = "tFechaIngreso";
            this.tFechaIngreso.ReadOnly = true;
            this.tFechaIngreso.Size = new System.Drawing.Size(123, 23);
            this.tFechaIngreso.TabIndex = 94;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(52, 62);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 16);
            this.label7.TabIndex = 96;
            this.label7.Text = "ID ALta";
            // 
            // tID
            // 
            this.tID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tID.Location = new System.Drawing.Point(121, 57);
            this.tID.Multiline = true;
            this.tID.Name = "tID";
            this.tID.Size = new System.Drawing.Size(123, 23);
            this.tID.TabIndex = 95;
            // 
            // tMonto
            // 
            this.tMonto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tMonto.Location = new System.Drawing.Point(676, 169);
            this.tMonto.Multiline = true;
            this.tMonto.Name = "tMonto";
            this.tMonto.Size = new System.Drawing.Size(123, 23);
            this.tMonto.TabIndex = 97;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(589, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 16);
            this.label8.TabIndex = 98;
            this.label8.Text = "Monto";
            // 
            // fecha
            // 
            this.fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fecha.Location = new System.Drawing.Point(678, 122);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(121, 22);
            this.fecha.TabIndex = 99;
            this.fecha.ValueChanged += new System.EventHandler(this.fecha_ValueChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(286, 120);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(140, 16);
            this.label9.TabIndex = 101;
            this.label9.Text = "Precio Habitacion: ";
            // 
            // lPrecio
            // 
            this.lPrecio.AutoSize = true;
            this.lPrecio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lPrecio.Location = new System.Drawing.Point(432, 122);
            this.lPrecio.Name = "lPrecio";
            this.lPrecio.Size = new System.Drawing.Size(44, 16);
            this.lPrecio.TabIndex = 102;
            this.lPrecio.Text = "$0.00";
            // 
            // Altas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 483);
            this.Controls.Add(this.lPrecio);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.fecha);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tMonto);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.tID);
            this.Controls.Add(this.tFechaIngreso);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.bSeleccionarIngreso);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tHabitacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tIngreso);
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
            this.MaximumSize = new System.Drawing.Size(863, 522);
            this.MinimumSize = new System.Drawing.Size(863, 522);
            this.Name = "Altas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Altas";
            this.Load += new System.EventHandler(this.Altas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tHabitacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tIngreso;
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
        private System.Windows.Forms.Button bSeleccionarIngreso;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tFechaIngreso;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tID;
        private System.Windows.Forms.TextBox tMonto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lPrecio;
    }
}