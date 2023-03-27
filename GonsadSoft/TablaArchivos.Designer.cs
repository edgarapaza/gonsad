namespace GonsadSoft
{
    partial class TablaArchivos
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
            this.dgvArchivo = new System.Windows.Forms.DataGridView();
            this.mctabla = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.nuevoItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duplicarItemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.otroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSueldoDiario = new System.Windows.Forms.TextBox();
            this.txtAlojamientoDiario = new System.Windows.Forms.TextBox();
            this.txtbruto = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtalojamiento = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtLiquidoDiario = new System.Windows.Forms.TextBox();
            this.txtliquido = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblCodigoProyecto = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblNombreCompleto = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.lblNombreCorto = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.txtiditem = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txttotal = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtestadia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtparcial = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtitem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtdias = new System.Windows.Forms.TextBox();
            this.btnCalcular = new FontAwesome.Sharp.IconButton();
            this.btnGuardarCostos = new FontAwesome.Sharp.IconButton();
            this.btnCalcularCostos = new FontAwesome.Sharp.IconButton();
            this.bntGuardarCambios = new FontAwesome.Sharp.IconButton();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.btnNuevoItem = new FontAwesome.Sharp.IconButton();
            this.btnCancelar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArchivo)).BeginInit();
            this.mctabla.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvArchivo
            // 
            this.dgvArchivo.AllowUserToResizeColumns = false;
            this.dgvArchivo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvArchivo.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvArchivo.ColumnHeadersHeight = 30;
            this.dgvArchivo.ContextMenuStrip = this.mctabla;
            this.dgvArchivo.Location = new System.Drawing.Point(28, 468);
            this.dgvArchivo.Name = "dgvArchivo";
            this.dgvArchivo.ReadOnly = true;
            this.dgvArchivo.RowHeadersWidth = 51;
            this.dgvArchivo.RowTemplate.Height = 24;
            this.dgvArchivo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArchivo.Size = new System.Drawing.Size(1183, 370);
            this.dgvArchivo.TabIndex = 0;
            this.dgvArchivo.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArchivo_CellDoubleClick);
            // 
            // mctabla
            // 
            this.mctabla.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mctabla.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoItemToolStripMenuItem,
            this.duplicarItemToolStripMenuItem,
            this.otroToolStripMenuItem});
            this.mctabla.Name = "mctabla";
            this.mctabla.Size = new System.Drawing.Size(169, 76);
            // 
            // nuevoItemToolStripMenuItem
            // 
            this.nuevoItemToolStripMenuItem.Name = "nuevoItemToolStripMenuItem";
            this.nuevoItemToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.nuevoItemToolStripMenuItem.Text = "Nuevo Item";
            // 
            // duplicarItemToolStripMenuItem
            // 
            this.duplicarItemToolStripMenuItem.Name = "duplicarItemToolStripMenuItem";
            this.duplicarItemToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.duplicarItemToolStripMenuItem.Text = "Duplicar item";
            // 
            // otroToolStripMenuItem
            // 
            this.otroToolStripMenuItem.Name = "otroToolStripMenuItem";
            this.otroToolStripMenuItem.Size = new System.Drawing.Size(168, 24);
            this.otroToolStripMenuItem.Text = "Otro";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtSueldoDiario);
            this.panel1.Controls.Add(this.btnCalcular);
            this.panel1.Controls.Add(this.btnGuardarCostos);
            this.panel1.Controls.Add(this.txtAlojamientoDiario);
            this.panel1.Controls.Add(this.txtbruto);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtalojamiento);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtLiquidoDiario);
            this.panel1.Controls.Add(this.txtliquido);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Location = new System.Drawing.Point(236, 103);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(808, 141);
            this.panel1.TabIndex = 14;
            // 
            // txtSueldoDiario
            // 
            this.txtSueldoDiario.Location = new System.Drawing.Point(489, 97);
            this.txtSueldoDiario.Name = "txtSueldoDiario";
            this.txtSueldoDiario.Size = new System.Drawing.Size(100, 22);
            this.txtSueldoDiario.TabIndex = 26;
            // 
            // txtAlojamientoDiario
            // 
            this.txtAlojamientoDiario.Location = new System.Drawing.Point(489, 56);
            this.txtAlojamientoDiario.Name = "txtAlojamientoDiario";
            this.txtAlojamientoDiario.Size = new System.Drawing.Size(100, 22);
            this.txtAlojamientoDiario.TabIndex = 25;
            // 
            // txtbruto
            // 
            this.txtbruto.Location = new System.Drawing.Point(193, 97);
            this.txtbruto.Name = "txtbruto";
            this.txtbruto.Size = new System.Drawing.Size(100, 22);
            this.txtbruto.TabIndex = 24;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(103, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 16);
            this.label9.TabIndex = 23;
            this.label9.Text = "Sueldo Bruto";
            // 
            // txtalojamiento
            // 
            this.txtalojamiento.Location = new System.Drawing.Point(193, 56);
            this.txtalojamiento.Name = "txtalojamiento";
            this.txtalojamiento.Size = new System.Drawing.Size(100, 22);
            this.txtalojamiento.TabIndex = 22;
            this.txtalojamiento.Text = "1000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(49, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 16);
            this.label8.TabIndex = 21;
            this.label8.Text = "Comida y Alojamiento";
            // 
            // txtLiquidoDiario
            // 
            this.txtLiquidoDiario.Location = new System.Drawing.Point(489, 16);
            this.txtLiquidoDiario.Name = "txtLiquidoDiario";
            this.txtLiquidoDiario.Size = new System.Drawing.Size(100, 22);
            this.txtLiquidoDiario.TabIndex = 20;
            // 
            // txtliquido
            // 
            this.txtliquido.Location = new System.Drawing.Point(193, 16);
            this.txtliquido.Name = "txtliquido";
            this.txtliquido.Size = new System.Drawing.Size(100, 22);
            this.txtliquido.TabIndex = 19;
            this.txtliquido.Text = "2600";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(113, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 16);
            this.label7.TabIndex = 16;
            this.label7.Text = "Liquido";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(64, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 16);
            this.label10.TabIndex = 16;
            this.label10.Text = "Codigo del Proyecto:";
            // 
            // lblCodigoProyecto
            // 
            this.lblCodigoProyecto.AutoSize = true;
            this.lblCodigoProyecto.Location = new System.Drawing.Point(230, 26);
            this.lblCodigoProyecto.Name = "lblCodigoProyecto";
            this.lblCodigoProyecto.Size = new System.Drawing.Size(14, 16);
            this.lblCodigoProyecto.TabIndex = 17;
            this.lblCodigoProyecto.Text = "1";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label11.Location = new System.Drawing.Point(62, 55);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(137, 16);
            this.label11.TabIndex = 18;
            this.label11.Text = "Nombre del proyecto:";
            // 
            // lblNombreCompleto
            // 
            this.lblNombreCompleto.AutoSize = true;
            this.lblNombreCompleto.Location = new System.Drawing.Point(230, 55);
            this.lblNombreCompleto.Name = "lblNombreCompleto";
            this.lblNombreCompleto.Size = new System.Drawing.Size(56, 16);
            this.lblNombreCompleto.TabIndex = 19;
            this.lblNombreCompleto.Text = "Nombre";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(105, 84);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(94, 16);
            this.label13.TabIndex = 20;
            this.label13.Text = "Nombre Corto:";
            // 
            // lblNombreCorto
            // 
            this.lblNombreCorto.AutoSize = true;
            this.lblNombreCorto.Location = new System.Drawing.Point(233, 84);
            this.lblNombreCorto.Name = "lblNombreCorto";
            this.lblNombreCorto.Size = new System.Drawing.Size(39, 16);
            this.lblNombreCorto.TabIndex = 21;
            this.lblNombreCorto.Text = "Corto";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.btnGuardar);
            this.panel2.Controls.Add(this.btnCancelar);
            this.panel2.Controls.Add(this.bntGuardarCambios);
            this.panel2.Controls.Add(this.btnCalcularCostos);
            this.panel2.Controls.Add(this.btnNuevoItem);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtiditem);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txttotal);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.txtestadia);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtparcial);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtitem);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtdias);
            this.panel2.Location = new System.Drawing.Point(28, 250);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1183, 200);
            this.panel2.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(43, 116);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 16);
            this.label6.TabIndex = 28;
            this.label6.Text = "Codigo";
            // 
            // txtiditem
            // 
            this.txtiditem.Enabled = false;
            this.txtiditem.Location = new System.Drawing.Point(100, 113);
            this.txtiditem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtiditem.Name = "txtiditem";
            this.txtiditem.Size = new System.Drawing.Size(89, 22);
            this.txtiditem.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(663, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 16);
            this.label4.TabIndex = 26;
            this.label4.Text = "Costo Total";
            // 
            // txttotal
            // 
            this.txttotal.Enabled = false;
            this.txttotal.Location = new System.Drawing.Point(759, 75);
            this.txttotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txttotal.Name = "txttotal";
            this.txttotal.Size = new System.Drawing.Size(89, 22);
            this.txttotal.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(433, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Costo Estadia";
            // 
            // txtestadia
            // 
            this.txtestadia.Enabled = false;
            this.txtestadia.Location = new System.Drawing.Point(554, 75);
            this.txtestadia.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtestadia.Name = "txtestadia";
            this.txtestadia.Size = new System.Drawing.Size(89, 22);
            this.txtestadia.TabIndex = 22;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(4, 36);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 16);
            this.label5.TabIndex = 21;
            this.label5.Text = "Descripcion";
            // 
            // txtparcial
            // 
            this.txtparcial.Enabled = false;
            this.txtparcial.Location = new System.Drawing.Point(320, 75);
            this.txtparcial.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtparcial.Name = "txtparcial";
            this.txtparcial.Size = new System.Drawing.Size(89, 22);
            this.txtparcial.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(224, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 16);
            this.label2.TabIndex = 20;
            this.label2.Text = "Costo Parcial";
            // 
            // txtitem
            // 
            this.txtitem.Location = new System.Drawing.Point(100, 36);
            this.txtitem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtitem.Name = "txtitem";
            this.txtitem.Size = new System.Drawing.Size(748, 22);
            this.txtitem.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(58, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Dias";
            // 
            // txtdias
            // 
            this.txtdias.Location = new System.Drawing.Point(100, 75);
            this.txtdias.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtdias.Name = "txtdias";
            this.txtdias.Size = new System.Drawing.Size(89, 22);
            this.txtdias.TabIndex = 17;
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.Color.YellowGreen;
            this.btnCalcular.FlatAppearance.BorderSize = 0;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcular.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCalcular.IconChar = FontAwesome.Sharp.IconChar.LocationCrosshairs;
            this.btnCalcular.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCalcular.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCalcular.IconSize = 32;
            this.btnCalcular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalcular.Location = new System.Drawing.Point(321, 32);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCalcular.Size = new System.Drawing.Size(145, 46);
            this.btnCalcular.TabIndex = 56;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalcular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.iconButton1_Click);
            // 
            // btnGuardarCostos
            // 
            this.btnGuardarCostos.BackColor = System.Drawing.Color.Turquoise;
            this.btnGuardarCostos.FlatAppearance.BorderSize = 0;
            this.btnGuardarCostos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCostos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGuardarCostos.IconChar = FontAwesome.Sharp.IconChar.LocationArrow;
            this.btnGuardarCostos.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGuardarCostos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarCostos.IconSize = 32;
            this.btnGuardarCostos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarCostos.Location = new System.Drawing.Point(616, 32);
            this.btnGuardarCostos.Name = "btnGuardarCostos";
            this.btnGuardarCostos.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnGuardarCostos.Size = new System.Drawing.Size(187, 46);
            this.btnGuardarCostos.TabIndex = 57;
            this.btnGuardarCostos.Text = "Guardar Costos";
            this.btnGuardarCostos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardarCostos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardarCostos.UseVisualStyleBackColor = false;
            this.btnGuardarCostos.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // btnCalcularCostos
            // 
            this.btnCalcularCostos.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCalcularCostos.FlatAppearance.BorderSize = 0;
            this.btnCalcularCostos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCalcularCostos.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCalcularCostos.IconChar = FontAwesome.Sharp.IconChar.ArrowRightRotate;
            this.btnCalcularCostos.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCalcularCostos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCalcularCostos.IconSize = 32;
            this.btnCalcularCostos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalcularCostos.Location = new System.Drawing.Point(227, 102);
            this.btnCalcularCostos.Name = "btnCalcularCostos";
            this.btnCalcularCostos.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCalcularCostos.Size = new System.Drawing.Size(187, 46);
            this.btnCalcularCostos.TabIndex = 58;
            this.btnCalcularCostos.Text = "Calcular Costos";
            this.btnCalcularCostos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalcularCostos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCalcularCostos.UseVisualStyleBackColor = false;
            this.btnCalcularCostos.Click += new System.EventHandler(this.iconButton3_Click);
            // 
            // bntGuardarCambios
            // 
            this.bntGuardarCambios.BackColor = System.Drawing.Color.Salmon;
            this.bntGuardarCambios.FlatAppearance.BorderSize = 0;
            this.bntGuardarCambios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bntGuardarCambios.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bntGuardarCambios.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.bntGuardarCambios.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.bntGuardarCambios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bntGuardarCambios.IconSize = 32;
            this.bntGuardarCambios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntGuardarCambios.Location = new System.Drawing.Point(650, 118);
            this.bntGuardarCambios.Name = "bntGuardarCambios";
            this.bntGuardarCambios.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.bntGuardarCambios.Size = new System.Drawing.Size(208, 46);
            this.bntGuardarCambios.TabIndex = 59;
            this.bntGuardarCambios.Text = "Guardar Cambios";
            this.bntGuardarCambios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.bntGuardarCambios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.bntGuardarCambios.UseVisualStyleBackColor = false;
            this.bntGuardarCambios.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.PaleVioletRed;
            this.btnGuardar.FlatAppearance.BorderSize = 0;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.btnGuardar.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardar.IconSize = 32;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(900, 120);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnGuardar.Size = new System.Drawing.Size(216, 44);
            this.btnGuardar.TabIndex = 60;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.iconButton5_Click);
            // 
            // btnNuevoItem
            // 
            this.btnNuevoItem.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btnNuevoItem.FlatAppearance.BorderSize = 0;
            this.btnNuevoItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNuevoItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnNuevoItem.IconChar = FontAwesome.Sharp.IconChar.Sass;
            this.btnNuevoItem.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNuevoItem.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnNuevoItem.IconSize = 32;
            this.btnNuevoItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoItem.Location = new System.Drawing.Point(854, 32);
            this.btnNuevoItem.Name = "btnNuevoItem";
            this.btnNuevoItem.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnNuevoItem.Size = new System.Drawing.Size(186, 44);
            this.btnNuevoItem.TabIndex = 61;
            this.btnNuevoItem.Text = "Nuevo Item";
            this.btnNuevoItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNuevoItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNuevoItem.UseVisualStyleBackColor = false;
            this.btnNuevoItem.Click += new System.EventHandler(this.iconButton6_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.LightSlateGray;
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancelar.IconChar = FontAwesome.Sharp.IconChar.Xmark;
            this.btnCancelar.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCancelar.IconSize = 32;
            this.btnCancelar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.Location = new System.Drawing.Point(1036, 32);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btnCancelar.Size = new System.Drawing.Size(144, 44);
            this.btnCancelar.TabIndex = 62;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.iconButton7_Click);
            // 
            // TablaArchivos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 856);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lblNombreCorto);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lblNombreCompleto);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lblCodigoProyecto);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvArchivo);
            this.Name = "TablaArchivos";
            this.Text = "TablaArchivos";
            this.Load += new System.EventHandler(this.TablaArchivos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArchivo)).EndInit();
            this.mctabla.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArchivo;
        private System.Windows.Forms.ContextMenuStrip mctabla;
        private System.Windows.Forms.ToolStripMenuItem nuevoItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem duplicarItemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem otroToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtbruto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtalojamiento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtLiquidoDiario;
        private System.Windows.Forms.TextBox txtliquido;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSueldoDiario;
        private System.Windows.Forms.TextBox txtAlojamientoDiario;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblCodigoProyecto;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblNombreCompleto;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblNombreCorto;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtiditem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttotal;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtestadia;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtparcial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtitem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtdias;
        private FontAwesome.Sharp.IconButton btnCalcular;
        private FontAwesome.Sharp.IconButton btnGuardarCostos;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnCalcularCostos;
        private FontAwesome.Sharp.IconButton bntGuardarCambios;
        private FontAwesome.Sharp.IconButton btnNuevoItem;
        private FontAwesome.Sharp.IconButton btnCancelar;
    }
}