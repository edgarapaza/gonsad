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
            this.btnGuardar = new System.Windows.Forms.Button();
            this.OpenDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnVercodigo = new System.Windows.Forms.Button();
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
            this.ssMensaje.Location = new System.Drawing.Point(0, 835);
            this.ssMensaje.Name = "ssMensaje";
            this.ssMensaje.Size = new System.Drawing.Size(1694, 22);
            this.ssMensaje.TabIndex = 71;
            this.ssMensaje.Text = "statusStrip1";
            // 
            // stlMensaje
            // 
            this.stlMensaje.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.stlMensaje.ForeColor = System.Drawing.Color.Red;
            this.stlMensaje.Name = "stlMensaje";
            this.stlMensaje.Size = new System.Drawing.Size(0, 17);
            // 
            // treeProyectos
            // 
            this.treeProyectos.ContextMenuStrip = this.contextMenuStrip1;
            this.treeProyectos.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.treeProyectos.FullRowSelect = true;
            this.treeProyectos.Location = new System.Drawing.Point(20, 43);
            this.treeProyectos.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.treeProyectos.Name = "treeProyectos";
            this.treeProyectos.Size = new System.Drawing.Size(556, 795);
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
            this.contextMenuStrip1.Size = new System.Drawing.Size(194, 192);
            // 
            // nuevoProyectoToolStripMenuItem
            // 
            this.nuevoProyectoToolStripMenuItem.Name = "nuevoProyectoToolStripMenuItem";
            this.nuevoProyectoToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.nuevoProyectoToolStripMenuItem.Text = "Nuevo Proyecto";
            this.nuevoProyectoToolStripMenuItem.Click += new System.EventHandler(this.nuevoProyectoToolStripMenuItem_Click);
            // 
            // duplicarToolStripMenuItem
            // 
            this.duplicarToolStripMenuItem.Name = "duplicarToolStripMenuItem";
            this.duplicarToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.duplicarToolStripMenuItem.Text = "Duplicar";
            this.duplicarToolStripMenuItem.Click += new System.EventHandler(this.duplicarToolStripMenuItem_Click);
            // 
            // sepToolStripMenuItem1
            // 
            this.sepToolStripMenuItem1.Name = "sepToolStripMenuItem1";
            this.sepToolStripMenuItem1.Size = new System.Drawing.Size(190, 6);
            // 
            // agregarCategoriaToolStripMenuItem
            // 
            this.agregarCategoriaToolStripMenuItem.Name = "agregarCategoriaToolStripMenuItem";
            this.agregarCategoriaToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.agregarCategoriaToolStripMenuItem.Text = "Agregar Categoria";
            this.agregarCategoriaToolStripMenuItem.Click += new System.EventHandler(this.agregarCategoriaToolStripMenuItem_Click);
            // 
            // agregarSubCategoriaToolStripMenuItem
            // 
            this.agregarSubCategoriaToolStripMenuItem.Name = "agregarSubCategoriaToolStripMenuItem";
            this.agregarSubCategoriaToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.agregarSubCategoriaToolStripMenuItem.Text = "Agregar Sub Categoria";
            // 
            // sepToolStripMenuItem2
            // 
            this.sepToolStripMenuItem2.Name = "sepToolStripMenuItem2";
            this.sepToolStripMenuItem2.Size = new System.Drawing.Size(190, 6);
            // 
            // eliminarProyectoToolStripMenuItem
            // 
            this.eliminarProyectoToolStripMenuItem.Name = "eliminarProyectoToolStripMenuItem";
            this.eliminarProyectoToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.eliminarProyectoToolStripMenuItem.Text = "Eliminar Proyecto";
            this.eliminarProyectoToolStripMenuItem.Click += new System.EventHandler(this.eliminarProyectoToolStripMenuItem_Click);
            // 
            // eliminarCategoriaToolStripMenuItem
            // 
            this.eliminarCategoriaToolStripMenuItem.Name = "eliminarCategoriaToolStripMenuItem";
            this.eliminarCategoriaToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.eliminarCategoriaToolStripMenuItem.Text = "Eliminar Categoria";
            // 
            // eliminarSubCategoriaToolStripMenuItem
            // 
            this.eliminarSubCategoriaToolStripMenuItem.Name = "eliminarSubCategoriaToolStripMenuItem";
            this.eliminarSubCategoriaToolStripMenuItem.Size = new System.Drawing.Size(193, 22);
            this.eliminarSubCategoriaToolStripMenuItem.Text = "Eliminar sub Categoria";
            // 
            // dgvFiles
            // 
            this.dgvFiles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFiles.Location = new System.Drawing.Point(590, 43);
            this.dgvFiles.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgvFiles.MultiSelect = false;
            this.dgvFiles.Name = "dgvFiles";
            this.dgvFiles.RowHeadersWidth = 51;
            this.dgvFiles.RowTemplate.Height = 24;
            this.dgvFiles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvFiles.Size = new System.Drawing.Size(1095, 794);
            this.dgvFiles.TabIndex = 74;
            this.dgvFiles.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvFiles_CellDoubleClick);
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(470, 13);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(109, 23);
            this.btnGuardar.TabIndex = 75;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // OpenDialog
            // 
            this.OpenDialog.FileName = "openFileDialog1";
            // 
            // btnVercodigo
            // 
            this.btnVercodigo.Location = new System.Drawing.Point(170, 13);
            this.btnVercodigo.Name = "btnVercodigo";
            this.btnVercodigo.Size = new System.Drawing.Size(165, 23);
            this.btnVercodigo.TabIndex = 76;
            this.btnVercodigo.Text = "Codigo";
            this.btnVercodigo.UseVisualStyleBackColor = true;
            this.btnVercodigo.Click += new System.EventHandler(this.btnVercodigo_Click);
            // 
            // ListadoProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1694, 857);
            this.Controls.Add(this.btnVercodigo);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.dgvFiles);
            this.Controls.Add(this.treeProyectos);
            this.Controls.Add(this.ssMensaje);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
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
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.OpenFileDialog OpenDialog;
        private System.Windows.Forms.Button btnVercodigo;
    }
}