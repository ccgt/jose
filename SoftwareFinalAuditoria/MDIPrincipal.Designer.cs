﻿namespace SoftwareFinalAuditoria
{
    partial class MDIPrincipal
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
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.planificaciónCOBITToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.administraciónDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.seguridadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignaciónDeObjetivosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem,
            this.planificaciónCOBITToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.administraciónDeUsuariosToolStripMenuItem,
            this.seguridadToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(832, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.aToolStripMenuItem.Text = "Proyectos";
            // 
            // planificaciónCOBITToolStripMenuItem
            // 
            this.planificaciónCOBITToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.asignaciónDeObjetivosToolStripMenuItem});
            this.planificaciónCOBITToolStripMenuItem.Name = "planificaciónCOBITToolStripMenuItem";
            this.planificaciónCOBITToolStripMenuItem.Size = new System.Drawing.Size(124, 20);
            this.planificaciónCOBITToolStripMenuItem.Text = "Planificación COBIT";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // administraciónDeUsuariosToolStripMenuItem
            // 
            this.administraciónDeUsuariosToolStripMenuItem.Name = "administraciónDeUsuariosToolStripMenuItem";
            this.administraciónDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(164, 20);
            this.administraciónDeUsuariosToolStripMenuItem.Text = "Administración de Usuarios";
            // 
            // seguridadToolStripMenuItem
            // 
            this.seguridadToolStripMenuItem.Name = "seguridadToolStripMenuItem";
            this.seguridadToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.seguridadToolStripMenuItem.Text = "Seguridad";
            this.seguridadToolStripMenuItem.Click += new System.EventHandler(this.seguridadToolStripMenuItem_Click);
            // 
            // asignaciónDeObjetivosToolStripMenuItem
            // 
            this.asignaciónDeObjetivosToolStripMenuItem.Name = "asignaciónDeObjetivosToolStripMenuItem";
            this.asignaciónDeObjetivosToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.asignaciónDeObjetivosToolStripMenuItem.Text = "Asignación de objetivos";
            this.asignaciónDeObjetivosToolStripMenuItem.Click += new System.EventHandler(this.asignaciónDeObjetivosToolStripMenuItem_Click);
            // 
            // MDIPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 491);
            this.Controls.Add(this.menuStrip1);
            this.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MDIPrincipal";
            this.Text = "Software Auditoria";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MDIPrincipal_FormClosed);
            this.Load += new System.EventHandler(this.MDIPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem planificaciónCOBITToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem administraciónDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem seguridadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignaciónDeObjetivosToolStripMenuItem;
    }
}

