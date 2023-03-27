namespace GonsadSoft
{
    partial class Clientes
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.dgvClientes = new System.Windows.Forms.DataGridView();
            this.txtIdCliente1 = new System.Windows.Forms.TextBox();
            this.txtCliente1 = new System.Windows.Forms.TextBox();
            this.txtRazonSocial1 = new System.Windows.Forms.TextBox();
            this.txtRuc1 = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnBuscar);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(107, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(883, 79);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(108, 22);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(499, 30);
            this.textBox1.TabIndex = 1;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(633, 22);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(192, 36);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "BUSCAR";
            this.btnBuscar.UseVisualStyleBackColor = true;
            // 
            // dgvClientes
            // 
            this.dgvClientes.ColumnHeadersHeight = 30;
            this.dgvClientes.Location = new System.Drawing.Point(107, 141);
            this.dgvClientes.MultiSelect = false;
            this.dgvClientes.Name = "dgvClientes";
            this.dgvClientes.ReadOnly = true;
            this.dgvClientes.RowHeadersWidth = 51;
            this.dgvClientes.RowTemplate.Height = 24;
            this.dgvClientes.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientes.Size = new System.Drawing.Size(1877, 472);
            this.dgvClientes.TabIndex = 1;
            this.dgvClientes.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClientes_CellDoubleClick);
            // 
            // txtIdCliente1
            // 
            this.txtIdCliente1.Location = new System.Drawing.Point(1078, 29);
            this.txtIdCliente1.Name = "txtIdCliente1";
            this.txtIdCliente1.Size = new System.Drawing.Size(139, 22);
            this.txtIdCliente1.TabIndex = 2;
            // 
            // txtCliente1
            // 
            this.txtCliente1.Location = new System.Drawing.Point(1250, 29);
            this.txtCliente1.Name = "txtCliente1";
            this.txtCliente1.Size = new System.Drawing.Size(262, 22);
            this.txtCliente1.TabIndex = 3;
            // 
            // txtRazonSocial1
            // 
            this.txtRazonSocial1.Location = new System.Drawing.Point(1250, 64);
            this.txtRazonSocial1.Name = "txtRazonSocial1";
            this.txtRazonSocial1.Size = new System.Drawing.Size(262, 22);
            this.txtRazonSocial1.TabIndex = 4;
            // 
            // txtRuc1
            // 
            this.txtRuc1.Location = new System.Drawing.Point(1078, 61);
            this.txtRuc1.Name = "txtRuc1";
            this.txtRuc1.Size = new System.Drawing.Size(139, 22);
            this.txtRuc1.TabIndex = 5;
            // 
            // btnEnviar
            // 
            this.btnEnviar.Location = new System.Drawing.Point(1569, 29);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(164, 54);
            this.btnEnviar.TabIndex = 6;
            this.btnEnviar.Text = "Enviar Datos";
            this.btnEnviar.UseVisualStyleBackColor = true;
            this.btnEnviar.Click += new System.EventHandler(this.btnEnviar_Click);
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2009, 758);
            this.Controls.Add(this.btnEnviar);
            this.Controls.Add(this.txtRuc1);
            this.Controls.Add(this.txtRazonSocial1);
            this.Controls.Add(this.txtCliente1);
            this.Controls.Add(this.txtIdCliente1);
            this.Controls.Add(this.dgvClientes);
            this.Controls.Add(this.panel1);
            this.Name = "Clientes";
            this.Text = "Clientes";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvClientes;
        private System.Windows.Forms.TextBox txtIdCliente1;
        private System.Windows.Forms.TextBox txtCliente1;
        private System.Windows.Forms.TextBox txtRazonSocial1;
        private System.Windows.Forms.TextBox txtRuc1;
        private System.Windows.Forms.Button btnEnviar;
    }
}