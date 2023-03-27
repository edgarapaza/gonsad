namespace GonsadSoft
{
    partial class ListadoProyectos
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
            this.ssMensaje = new System.Windows.Forms.StatusStrip();
            this.stlMensaje = new System.Windows.Forms.ToolStripStatusLabel();
            this.treeProyectos = new System.Windows.Forms.TreeView();
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
            this.dgvFiles = new System.Windows.Forms.DataGridView();
            this.ssMensaje.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).BeginInit();
            this.SuspendLayout();
            // 
            // ssMensaje
            // 
            this.ssMensaje.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ssMensaje.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.stlMensaje});
            this.ssMensaje.Location = new System.Drawing.Point(0, 1033);
            this.ssMensaje.Name = "ssMensaje";
            this.ssMensaje.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.ssMensaje.Size = new System.Drawing.Size(2258, 22);
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
            // treeProyectos
            // 
            this.treeProyectos.ContextMenuStrip = this.contextMenuStrip1;
            this.treeProyectos.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.treeProyectos.FullRowSelect = true;
            this.treeProyectos.Location = new System.Drawing.Point(26, 53);
            this.treeProyectos.Name = "treeProyectos";
            this.treeProyectos.Size = new System.Drawing.Size(740, 977);
            this.treeProyectos.TabIndex = 72;
            this.treeProyectos.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeProyectos_AfterSelect);
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
            this.nuevoProyectoToolStripMenuItem.Click += new System.EventHandler(this.nuevoProyectoToolStripMenuItem_Click);
            // 
            // duplicarToolStripMenuItem
            // 
            this.duplicarToolStripMenuItem.Name = "duplicarToolStripMenuItem";
            this.duplicarToolStripMenuItem.Size = new System.Drawing.Size(230, 24);
            this.duplicarToolStripMenuItem.Text = "Duplicar";
            this.duplicarToolStripMenuItem.Click += new System.EventHandler(this.duplicarToolStripMenuItem_Click);
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
            this.eliminarProyectoToolStripMenuItem.Click += new System.EventHandler(this.eliminarProyectoToolStripMenuItem_Click);
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
            // dgvFiles
            // 
            this.dgvFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFiles.Location = new System.Drawing.Point(786, 53);
            this.dgvFiles.MultiSelect = false;
            this.dgvFiles.Name = "dgvFiles";
            this.dgvFiles.RowHeadersWidth = 51;
            this.dgvFiles.RowTemplate.Height = 24;
            this.dgvFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFiles.Size = new System.Drawing.Size(1460, 977);
            this.dgvFiles.TabIndex = 74;
            this.dgvFiles.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFiles_CellDoubleClick);
            // 
            // ListadoProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2258, 1055);
            this.Controls.Add(this.dgvFiles);
            this.Controls.Add(this.treeProyectos);
            this.Controls.Add(this.ssMensaje);
            this.Name = "ListadoProyectos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Listado de Proyectos";
            this.ssMensaje.ResumeLayout(false);
            this.ssMensaje.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip ssMensaje;
        private System.Windows.Forms.ToolStripStatusLabel stlMensaje;
        private System.Windows.Forms.TreeView treeProyectos;
        private System.Windows.Forms.DataGridView dgvFiles;
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
    }
}