namespace GonsadSoft
{
    partial class ProyectosResumen
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProyectosResumen));
            this.ssMensaje = new System.Windows.Forms.StatusStrip();
            this.stlMensaje = new System.Windows.Forms.ToolStripStatusLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nuevoProyectoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duplicarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sepToolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.agregarCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarSubCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sepToolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.eliminarProyectoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminarSubCategoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvListadoProyectos = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.ssMensaje.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoProyectos)).BeginInit();
            this.SuspendLayout();
            // 
            // ssMensaje
            // 
            this.ssMensaje.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ssMensaje.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stlMensaje});
            this.ssMensaje.Location = new System.Drawing.Point(0, 871);
            this.ssMensaje.Name = "ssMensaje";
            this.ssMensaje.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.ssMensaje.Size = new System.Drawing.Size(1791, 22);
            this.ssMensaje.TabIndex = 71;
            this.ssMensaje.Text = "statusStrip1";
            // 
            // stlMensaje
            // 
            this.stlMensaje.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.stlMensaje.ForeColor = System.Drawing.Color.Red;
            this.stlMensaje.Name = "stlMensaje";
            this.stlMensaje.Size = new System.Drawing.Size(0, 16);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoProyectoToolStripMenuItem,
            this.duplicarToolStripMenuItem,
            this.sepToolStripMenuItem1,
            this.agregarCategoriaToolStripMenuItem,
            this.agregarSubCategoriaToolStripMenuItem,
            this.sepToolStripMenuItem2,
            this.eliminarProyectoToolStripMenuItem,
            this.eliminarCategoriaToolStripMenuItem,
            this.eliminarSubCategoriaToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(231, 184);
            // 
            // nuevoProyectoToolStripMenuItem
            // 
            this.nuevoProyectoToolStripMenuItem.Name = "nuevoProyectoToolStripMenuItem";
            this.nuevoProyectoToolStripMenuItem.Size = new System.Drawing.Size(230, 24);
            this.nuevoProyectoToolStripMenuItem.Text = "Nuevo Proyecto";
            // 
            // duplicarToolStripMenuItem
            // 
            this.duplicarToolStripMenuItem.Name = "duplicarToolStripMenuItem";
            this.duplicarToolStripMenuItem.Size = new System.Drawing.Size(230, 24);
            this.duplicarToolStripMenuItem.Text = "Duplicar";
            // 
            // sepToolStripMenuItem1
            // 
            this.sepToolStripMenuItem1.Name = "sepToolStripMenuItem1";
            this.sepToolStripMenuItem1.Size = new System.Drawing.Size(227, 6);
            // 
            // agregarCategoriaToolStripMenuItem
            // 
            this.agregarCategoriaToolStripMenuItem.Name = "agregarCategoriaToolStripMenuItem";
            this.agregarCategoriaToolStripMenuItem.Size = new System.Drawing.Size(230, 24);
            this.agregarCategoriaToolStripMenuItem.Text = "Agregar Categoria";
            // 
            // agregarSubCategoriaToolStripMenuItem
            // 
            this.agregarSubCategoriaToolStripMenuItem.Name = "agregarSubCategoriaToolStripMenuItem";
            this.agregarSubCategoriaToolStripMenuItem.Size = new System.Drawing.Size(230, 24);
            this.agregarSubCategoriaToolStripMenuItem.Text = "Agregar Sub Categoria";
            // 
            // sepToolStripMenuItem2
            // 
            this.sepToolStripMenuItem2.Name = "sepToolStripMenuItem2";
            this.sepToolStripMenuItem2.Size = new System.Drawing.Size(227, 6);
            // 
            // eliminarProyectoToolStripMenuItem
            // 
            this.eliminarProyectoToolStripMenuItem.Name = "eliminarProyectoToolStripMenuItem";
            this.eliminarProyectoToolStripMenuItem.Size = new System.Drawing.Size(230, 24);
            this.eliminarProyectoToolStripMenuItem.Text = "Eliminar Proyecto";
            // 
            // eliminarCategoriaToolStripMenuItem
            // 
            this.eliminarCategoriaToolStripMenuItem.Name = "eliminarCategoriaToolStripMenuItem";
            this.eliminarCategoriaToolStripMenuItem.Size = new System.Drawing.Size(230, 24);
            this.eliminarCategoriaToolStripMenuItem.Text = "Eliminar Categoria";
            // 
            // eliminarSubCategoriaToolStripMenuItem
            // 
            this.eliminarSubCategoriaToolStripMenuItem.Name = "eliminarSubCategoriaToolStripMenuItem";
            this.eliminarSubCategoriaToolStripMenuItem.Size = new System.Drawing.Size(230, 24);
            this.eliminarSubCategoriaToolStripMenuItem.Text = "Eliminar sub Categoria";
            // 
            // dgvListadoProyectos
            // 
            this.dgvListadoProyectos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListadoProyectos.ColumnHeadersHeight = 40;
            this.dgvListadoProyectos.Location = new System.Drawing.Point(58, 125);
            this.dgvListadoProyectos.Name = "dgvListadoProyectos";
            this.dgvListadoProyectos.ReadOnly = true;
            this.dgvListadoProyectos.RowHeadersWidth = 51;
            this.dgvListadoProyectos.RowTemplate.Height = 24;
            this.dgvListadoProyectos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListadoProyectos.Size = new System.Drawing.Size(1700, 539);
            this.dgvListadoProyectos.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 16);
            this.label1.TabIndex = 73;
            this.label1.Text = "Buscador";
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(150, 37);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(420, 22);
            this.txtBuscar.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(611, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(126, 41);
            this.button1.TabIndex = 75;
            this.button1.Text = "Buscar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // ListadoProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1791, 893);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtBuscar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvListadoProyectos);
            this.Controls.Add(this.ssMensaje);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ListadoProyectos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Listado de Proyectos";
            this.ssMensaje.ResumeLayout(false);
            this.ssMensaje.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListadoProyectos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip ssMensaje;
        private System.Windows.Forms.ToolStripStatusLabel stlMensaje;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nuevoProyectoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem duplicarToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator sepToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem agregarCategoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarSubCategoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator sepToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem eliminarProyectoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarCategoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminarSubCategoriaToolStripMenuItem;
        private System.Windows.Forms.DataGridView dgvListadoProyectos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Button button1;
    }
}