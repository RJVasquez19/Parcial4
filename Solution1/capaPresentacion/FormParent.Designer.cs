namespace capaPresentacion
{
    partial class FormParent
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
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
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mantenimientosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mantenimientoHospitalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.doctorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enfermoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plantillaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departamentoHospitalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientosToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(632, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "Mantenimientos";
            // 
            // mantenimientosToolStripMenuItem
            // 
            this.mantenimientosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoHospitalToolStripMenuItem,
            this.doctorToolStripMenuItem,
            this.enfermoToolStripMenuItem,
            this.empleadoToolStripMenuItem,
            this.plantillaToolStripMenuItem,
            this.departamentoHospitalToolStripMenuItem,
            this.salaToolStripMenuItem});
            this.mantenimientosToolStripMenuItem.Name = "mantenimientosToolStripMenuItem";
            this.mantenimientosToolStripMenuItem.Size = new System.Drawing.Size(106, 20);
            this.mantenimientosToolStripMenuItem.Text = "Mantenimientos";
            // 
            // mantenimientoHospitalToolStripMenuItem
            // 
            this.mantenimientoHospitalToolStripMenuItem.Name = "mantenimientoHospitalToolStripMenuItem";
            this.mantenimientoHospitalToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.mantenimientoHospitalToolStripMenuItem.Text = "Hospital";
            this.mantenimientoHospitalToolStripMenuItem.Click += new System.EventHandler(this.mantenimientoHospitalToolStripMenuItem_Click);
            // 
            // doctorToolStripMenuItem
            // 
            this.doctorToolStripMenuItem.Name = "doctorToolStripMenuItem";
            this.doctorToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.doctorToolStripMenuItem.Text = "Doctor";
            // 
            // enfermoToolStripMenuItem
            // 
            this.enfermoToolStripMenuItem.Name = "enfermoToolStripMenuItem";
            this.enfermoToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.enfermoToolStripMenuItem.Text = "Enfermo";
            // 
            // empleadoToolStripMenuItem
            // 
            this.empleadoToolStripMenuItem.Name = "empleadoToolStripMenuItem";
            this.empleadoToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.empleadoToolStripMenuItem.Text = "Empleado";
            // 
            // plantillaToolStripMenuItem
            // 
            this.plantillaToolStripMenuItem.Name = "plantillaToolStripMenuItem";
            this.plantillaToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.plantillaToolStripMenuItem.Text = "Plantilla";
            // 
            // departamentoHospitalToolStripMenuItem
            // 
            this.departamentoHospitalToolStripMenuItem.Name = "departamentoHospitalToolStripMenuItem";
            this.departamentoHospitalToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.departamentoHospitalToolStripMenuItem.Text = "Departamento Hospital";
            // 
            // salaToolStripMenuItem
            // 
            this.salaToolStripMenuItem.Name = "salaToolStripMenuItem";
            this.salaToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.salaToolStripMenuItem.Text = "Sala";
            this.salaToolStripMenuItem.Click += new System.EventHandler(this.salaToolStripMenuItem_Click);
            // 
            // FormParent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(632, 453);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.Name = "FormParent";
            this.Text = "FormParent";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mantenimientosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoHospitalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem doctorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enfermoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem plantillaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departamentoHospitalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salaToolStripMenuItem;

    }
}



