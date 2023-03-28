namespace GonsadSoft
{
    partial class Dashboard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Dashboard));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.proyectosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoProyectoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeProyectosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ocultarProyectoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sepToolStripMenuItem = new System.Windows.Forms.ToolStripSeparator();
            this.calculoProyectoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.personalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoPersonalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDePersonalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.asignacionDeTareasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.especialistasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnListadoProyectos = new FontAwesome.Sharp.IconButton();
            this.btnNuevoPersonal = new FontAwesome.Sharp.IconButton();
            this.btnProyectosCategorias = new FontAwesome.Sharp.IconButton();
            this.btnProyectosArchivos = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.customInstaller1 = new MySql.Data.MySqlClient.CustomInstaller();
            this.panelEscritorio = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.editarToolStripMenuItem,
            this.proyectosToolStripMenuItem,
            this.personalToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1663, 28);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.guardarToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // guardarToolStripMenuItem
            // 
            this.guardarToolStripMenuItem.Name = "guardarToolStripMenuItem";
            this.guardarToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.guardarToolStripMenuItem.Text = "Guardar";
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(145, 26);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // editarToolStripMenuItem
            // 
            this.editarToolStripMenuItem.Name = "editarToolStripMenuItem";
            this.editarToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.editarToolStripMenuItem.Text = "Editar";
            // 
            // proyectosToolStripMenuItem
            // 
            this.proyectosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoProyectoToolStripMenuItem,
            this.listadoDeProyectosToolStripMenuItem,
            this.ocultarProyectoToolStripMenuItem,
            this.sepToolStripMenuItem,
            this.calculoProyectoToolStripMenuItem});
            this.proyectosToolStripMenuItem.Name = "proyectosToolStripMenuItem";
            this.proyectosToolStripMenuItem.Size = new System.Drawing.Size(87, 24);
            this.proyectosToolStripMenuItem.Text = "Proyectos";
            // 
            // nuevoProyectoToolStripMenuItem
            // 
            this.nuevoProyectoToolStripMenuItem.Name = "nuevoProyectoToolStripMenuItem";
            this.nuevoProyectoToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.nuevoProyectoToolStripMenuItem.Text = "Nuevo Proyecto";
            this.nuevoProyectoToolStripMenuItem.Click += new System.EventHandler(this.nuevoProyectoToolStripMenuItem_Click);
            // 
            // listadoDeProyectosToolStripMenuItem
            // 
            this.listadoDeProyectosToolStripMenuItem.Name = "listadoDeProyectosToolStripMenuItem";
            this.listadoDeProyectosToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.listadoDeProyectosToolStripMenuItem.Text = "Listado de Proyectos";
            // 
            // ocultarProyectoToolStripMenuItem
            // 
            this.ocultarProyectoToolStripMenuItem.Name = "ocultarProyectoToolStripMenuItem";
            this.ocultarProyectoToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.ocultarProyectoToolStripMenuItem.Text = "Ocultar Proyecto";
            // 
            // sepToolStripMenuItem
            // 
            this.sepToolStripMenuItem.Name = "sepToolStripMenuItem";
            this.sepToolStripMenuItem.Size = new System.Drawing.Size(226, 6);
            // 
            // calculoProyectoToolStripMenuItem
            // 
            this.calculoProyectoToolStripMenuItem.Name = "calculoProyectoToolStripMenuItem";
            this.calculoProyectoToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.calculoProyectoToolStripMenuItem.Text = "Calculo Proyecto";
            this.calculoProyectoToolStripMenuItem.Click += new System.EventHandler(this.calculoProyectoToolStripMenuItem_Click);
            // 
            // personalToolStripMenuItem
            // 
            this.personalToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoPersonalToolStripMenuItem,
            this.listadoDePersonalToolStripMenuItem,
            this.asignacionDeTareasToolStripMenuItem,
            this.especialistasToolStripMenuItem});
            this.personalToolStripMenuItem.Name = "personalToolStripMenuItem";
            this.personalToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.personalToolStripMenuItem.Text = "Personal";
            // 
            // nuevoPersonalToolStripMenuItem
            // 
            this.nuevoPersonalToolStripMenuItem.Name = "nuevoPersonalToolStripMenuItem";
            this.nuevoPersonalToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.nuevoPersonalToolStripMenuItem.Text = "Nuevo personal";
            // 
            // listadoDePersonalToolStripMenuItem
            // 
            this.listadoDePersonalToolStripMenuItem.Name = "listadoDePersonalToolStripMenuItem";
            this.listadoDePersonalToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.listadoDePersonalToolStripMenuItem.Text = "Listado de Personal";
            // 
            // asignacionDeTareasToolStripMenuItem
            // 
            this.asignacionDeTareasToolStripMenuItem.Name = "asignacionDeTareasToolStripMenuItem";
            this.asignacionDeTareasToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.asignacionDeTareasToolStripMenuItem.Text = "Asignacion de tareas";
            // 
            // especialistasToolStripMenuItem
            // 
            this.especialistasToolStripMenuItem.Name = "especialistasToolStripMenuItem";
            this.especialistasToolStripMenuItem.Size = new System.Drawing.Size(230, 26);
            this.especialistasToolStripMenuItem.Text = "Especialistas";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(65, 24);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(158, 26);
            this.acercaDeToolStripMenuItem.Text = "Acerca de";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.panel1.Controls.Add(this.iconButton1);
            this.panel1.Controls.Add(this.btnListadoProyectos);
            this.panel1.Controls.Add(this.btnNuevoPersonal);
            this.panel1.Controls.Add(this.btnProyectosCategorias);
            this.panel1.Controls.Add(this.btnProyectosArchivos);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(355, 895);
            this.panel1.TabIndex = 28;
            // 
            // btnListadoProyectos
            // 
            this.btnListadoProyectos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnListadoProyectos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnListadoProyectos.FlatAppearance.BorderSize = 0;
            this.btnListadoProyectos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnListadoProyectos.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.btnListadoProyectos.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnListadoProyectos.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.btnListadoProyectos.IconColor = System.Drawing.Color.Gainsboro;
            this.btnListadoProyectos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnListadoProyectos.IconSize = 32;
            this.btnListadoProyectos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListadoProyectos.Location = new System.Drawing.Point(0, 335);
            this.btnListadoProyectos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnListadoProyectos.Name = "btnListadoProyectos";
            this.btnListadoProyectos.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.btnListadoProyectos.Size = new System.Drawing.Size(355, 62);
            this.btnListadoProyectos.TabIndex = 4;
            this.btnListadoProyectos.Text = "Listado de Proyectos";
            this.btnListadoProyectos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnListadoProyectos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnListadoProyectos.UseVisualStyleBackColor = false;
            this.btnListadoProyectos.Click += new System.EventHandler(this.btnListadoProyectos_Click);
            // 
            // btnNuevoPersonal
            // 
            this.btnNuevoPersonal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnNuevoPersonal.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNuevoPersonal.FlatAppearance.BorderSize = 0;
            this.btnNuevoPersonal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoPersonal.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.btnNuevoPersonal.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnNuevoPersonal.IconChar = FontAwesome.Sharp.IconChar.UserAlt;
            this.btnNuevoPersonal.IconColor = System.Drawing.Color.Gainsboro;
            this.btnNuevoPersonal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNuevoPersonal.IconSize = 32;
            this.btnNuevoPersonal.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoPersonal.Location = new System.Drawing.Point(0, 273);
            this.btnNuevoPersonal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNuevoPersonal.Name = "btnNuevoPersonal";
            this.btnNuevoPersonal.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.btnNuevoPersonal.Size = new System.Drawing.Size(355, 62);
            this.btnNuevoPersonal.TabIndex = 3;
            this.btnNuevoPersonal.Text = "Nuevo Personal";
            this.btnNuevoPersonal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoPersonal.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevoPersonal.UseVisualStyleBackColor = false;
            this.btnNuevoPersonal.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // btnProyectosCategorias
            // 
            this.btnProyectosCategorias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnProyectosCategorias.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProyectosCategorias.FlatAppearance.BorderSize = 0;
            this.btnProyectosCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProyectosCategorias.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.btnProyectosCategorias.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnProyectosCategorias.IconChar = FontAwesome.Sharp.IconChar.BarChart;
            this.btnProyectosCategorias.IconColor = System.Drawing.Color.Gainsboro;
            this.btnProyectosCategorias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProyectosCategorias.IconSize = 32;
            this.btnProyectosCategorias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProyectosCategorias.Location = new System.Drawing.Point(0, 211);
            this.btnProyectosCategorias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProyectosCategorias.Name = "btnProyectosCategorias";
            this.btnProyectosCategorias.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.btnProyectosCategorias.Size = new System.Drawing.Size(355, 62);
            this.btnProyectosCategorias.TabIndex = 2;
            this.btnProyectosCategorias.Text = "Proyectos por Categorias";
            this.btnProyectosCategorias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProyectosCategorias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProyectosCategorias.UseVisualStyleBackColor = false;
            // 
            // btnProyectosArchivos
            // 
            this.btnProyectosArchivos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.btnProyectosArchivos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProyectosArchivos.FlatAppearance.BorderSize = 0;
            this.btnProyectosArchivos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProyectosArchivos.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.btnProyectosArchivos.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnProyectosArchivos.IconChar = FontAwesome.Sharp.IconChar.File;
            this.btnProyectosArchivos.IconColor = System.Drawing.Color.Gainsboro;
            this.btnProyectosArchivos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnProyectosArchivos.IconSize = 32;
            this.btnProyectosArchivos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProyectosArchivos.Location = new System.Drawing.Point(0, 149);
            this.btnProyectosArchivos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnProyectosArchivos.Name = "btnProyectosArchivos";
            this.btnProyectosArchivos.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.btnProyectosArchivos.Size = new System.Drawing.Size(355, 62);
            this.btnProyectosArchivos.TabIndex = 1;
            this.btnProyectosArchivos.Text = "Proyectos por Indice";
            this.btnProyectosArchivos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnProyectosArchivos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnProyectosArchivos.UseVisualStyleBackColor = false;
            this.btnProyectosArchivos.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Window;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(355, 149);
            this.panel2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.label1.Location = new System.Drawing.Point(124, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 21);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gonsad Software";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::GonsadSoft.Properties.Resources.g2;
            this.pictureBox1.Location = new System.Drawing.Point(19, 27);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 97);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelEscritorio
            // 
            this.panelEscritorio.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelEscritorio.Location = new System.Drawing.Point(355, 28);
            this.panelEscritorio.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelEscritorio.Name = "panelEscritorio";
            this.panelEscritorio.Size = new System.Drawing.Size(1308, 895);
            this.panelEscritorio.TabIndex = 29;
            this.panelEscritorio.TabStop = true;
            this.panelEscritorio.Paint += new System.Windows.Forms.PaintEventHandler(this.panelEscritorio_Paint);
            // 
            // iconButton1
            // 
            this.iconButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(152)))), ((int)(((byte)(219)))));
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Century Gothic", 10.8F);
            this.iconButton1.ForeColor = System.Drawing.Color.Gainsboro;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Upload;
            this.iconButton1.IconColor = System.Drawing.Color.Gainsboro;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 32;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 397);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(11, 0, 20, 0);
            this.iconButton1.Size = new System.Drawing.Size(355, 62);
            this.iconButton1.TabIndex = 5;
            this.iconButton1.Text = "Listado de Proyectos";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = false;
            this.iconButton1.Click += new System.EventHandler(this.iconButton1_Click_1);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1663, 923);
            this.Controls.Add(this.panelEscritorio);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem proyectosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoProyectoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeProyectosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ocultarProyectoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem personalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoPersonalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDePersonalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem asignacionDeTareasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem especialistasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FontAwesome.Sharp.IconButton btnNuevoPersonal;
        private FontAwesome.Sharp.IconButton btnProyectosCategorias;
        private FontAwesome.Sharp.IconButton btnProyectosArchivos;
        private MySql.Data.MySqlClient.CustomInstaller customInstaller1;
        private System.Windows.Forms.Panel panelEscritorio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripSeparator sepToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calculoProyectoToolStripMenuItem;
        private FontAwesome.Sharp.IconButton btnListadoProyectos;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}