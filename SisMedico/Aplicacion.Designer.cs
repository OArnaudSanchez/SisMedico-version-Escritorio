namespace SisMedico
{
    partial class Aplicacion
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
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
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.moduloMantenimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.medicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.habitacionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moduloProcesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.citasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.altasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moduloConsultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacientesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.medicosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.habitacionesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.citasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.ingresosToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.altasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moduloMantenimientosToolStripMenuItem,
            this.moduloProcesosToolStripMenuItem,
            this.moduloConsultasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1067, 29);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // moduloMantenimientosToolStripMenuItem
            // 
            this.moduloMantenimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.medicosToolStripMenuItem,
            this.pacientesToolStripMenuItem,
            this.habitacionesToolStripMenuItem});
            this.moduloMantenimientosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moduloMantenimientosToolStripMenuItem.Name = "moduloMantenimientosToolStripMenuItem";
            this.moduloMantenimientosToolStripMenuItem.Size = new System.Drawing.Size(212, 25);
            this.moduloMantenimientosToolStripMenuItem.Text = "Modulo Mantenimientos";
            // 
            // medicosToolStripMenuItem
            // 
            this.medicosToolStripMenuItem.Name = "medicosToolStripMenuItem";
            this.medicosToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.medicosToolStripMenuItem.Text = "Medicos";
            this.medicosToolStripMenuItem.Click += new System.EventHandler(this.medicosToolStripMenuItem_Click);
            // 
            // pacientesToolStripMenuItem
            // 
            this.pacientesToolStripMenuItem.Name = "pacientesToolStripMenuItem";
            this.pacientesToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.pacientesToolStripMenuItem.Text = "Pacientes";
            this.pacientesToolStripMenuItem.Click += new System.EventHandler(this.pacientesToolStripMenuItem_Click);
            // 
            // habitacionesToolStripMenuItem
            // 
            this.habitacionesToolStripMenuItem.Name = "habitacionesToolStripMenuItem";
            this.habitacionesToolStripMenuItem.Size = new System.Drawing.Size(180, 26);
            this.habitacionesToolStripMenuItem.Text = "Habitaciones";
            this.habitacionesToolStripMenuItem.Click += new System.EventHandler(this.habitacionesToolStripMenuItem_Click);
            // 
            // moduloProcesosToolStripMenuItem
            // 
            this.moduloProcesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.citasToolStripMenuItem,
            this.ingresosToolStripMenuItem,
            this.altasToolStripMenuItem});
            this.moduloProcesosToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moduloProcesosToolStripMenuItem.Name = "moduloProcesosToolStripMenuItem";
            this.moduloProcesosToolStripMenuItem.Size = new System.Drawing.Size(153, 25);
            this.moduloProcesosToolStripMenuItem.Text = "Modulo Procesos";
            // 
            // citasToolStripMenuItem
            // 
            this.citasToolStripMenuItem.Name = "citasToolStripMenuItem";
            this.citasToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.citasToolStripMenuItem.Text = "Citas";
            this.citasToolStripMenuItem.Click += new System.EventHandler(this.citasToolStripMenuItem_Click);
            // 
            // ingresosToolStripMenuItem
            // 
            this.ingresosToolStripMenuItem.Name = "ingresosToolStripMenuItem";
            this.ingresosToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.ingresosToolStripMenuItem.Text = "Ingresos";
            this.ingresosToolStripMenuItem.Click += new System.EventHandler(this.ingresosToolStripMenuItem_Click);
            // 
            // altasToolStripMenuItem
            // 
            this.altasToolStripMenuItem.Name = "altasToolStripMenuItem";
            this.altasToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.altasToolStripMenuItem.Text = "Altas";
            this.altasToolStripMenuItem.Click += new System.EventHandler(this.altasToolStripMenuItem_Click);
            // 
            // moduloConsultasToolStripMenuItem
            // 
            this.moduloConsultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pacientesToolStripMenuItem1,
            this.medicosToolStripMenuItem1,
            this.habitacionesToolStripMenuItem1,
            this.citasToolStripMenuItem1,
            this.ingresosToolStripMenuItem1,
            this.altasToolStripMenuItem1});
            this.moduloConsultasToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.moduloConsultasToolStripMenuItem.Name = "moduloConsultasToolStripMenuItem";
            this.moduloConsultasToolStripMenuItem.Size = new System.Drawing.Size(160, 25);
            this.moduloConsultasToolStripMenuItem.Text = "Modulo Consultas";
            // 
            // pacientesToolStripMenuItem1
            // 
            this.pacientesToolStripMenuItem1.Name = "pacientesToolStripMenuItem1";
            this.pacientesToolStripMenuItem1.Size = new System.Drawing.Size(180, 26);
            this.pacientesToolStripMenuItem1.Text = "Pacientes";
            this.pacientesToolStripMenuItem1.Click += new System.EventHandler(this.pacientesToolStripMenuItem1_Click);
            // 
            // medicosToolStripMenuItem1
            // 
            this.medicosToolStripMenuItem1.Name = "medicosToolStripMenuItem1";
            this.medicosToolStripMenuItem1.Size = new System.Drawing.Size(180, 26);
            this.medicosToolStripMenuItem1.Text = "Medicos";
            this.medicosToolStripMenuItem1.Click += new System.EventHandler(this.medicosToolStripMenuItem1_Click);
            // 
            // habitacionesToolStripMenuItem1
            // 
            this.habitacionesToolStripMenuItem1.Name = "habitacionesToolStripMenuItem1";
            this.habitacionesToolStripMenuItem1.Size = new System.Drawing.Size(180, 26);
            this.habitacionesToolStripMenuItem1.Text = "Habitaciones";
            this.habitacionesToolStripMenuItem1.Click += new System.EventHandler(this.habitacionesToolStripMenuItem1_Click);
            // 
            // citasToolStripMenuItem1
            // 
            this.citasToolStripMenuItem1.Name = "citasToolStripMenuItem1";
            this.citasToolStripMenuItem1.Size = new System.Drawing.Size(180, 26);
            this.citasToolStripMenuItem1.Text = "Citas";
            this.citasToolStripMenuItem1.Click += new System.EventHandler(this.citasToolStripMenuItem1_Click);
            // 
            // ingresosToolStripMenuItem1
            // 
            this.ingresosToolStripMenuItem1.Name = "ingresosToolStripMenuItem1";
            this.ingresosToolStripMenuItem1.Size = new System.Drawing.Size(180, 26);
            this.ingresosToolStripMenuItem1.Text = "Ingresos";
            this.ingresosToolStripMenuItem1.Click += new System.EventHandler(this.ingresosToolStripMenuItem1_Click);
            // 
            // altasToolStripMenuItem1
            // 
            this.altasToolStripMenuItem1.Name = "altasToolStripMenuItem1";
            this.altasToolStripMenuItem1.Size = new System.Drawing.Size(180, 26);
            this.altasToolStripMenuItem1.Text = "Altas";
            this.altasToolStripMenuItem1.Click += new System.EventHandler(this.altasToolStripMenuItem1_Click);
            // 
            // Aplicacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 604);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1083, 643);
            this.MinimumSize = new System.Drawing.Size(1083, 643);
            this.Name = "Aplicacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Medico";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem moduloMantenimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem medicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem habitacionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moduloProcesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem citasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ingresosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem altasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem moduloConsultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacientesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem medicosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem habitacionesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem citasToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem ingresosToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem altasToolStripMenuItem1;
    }
}

