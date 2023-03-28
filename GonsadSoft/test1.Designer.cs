namespace GonsadSoft
{
    partial class test1
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
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.btnCargarCarpeta = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(51, 69);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(471, 547);
            this.treeView1.TabIndex = 0;
            // 
            // btnCargarCarpeta
            // 
            this.btnCargarCarpeta.Location = new System.Drawing.Point(630, 137);
            this.btnCargarCarpeta.Name = "btnCargarCarpeta";
            this.btnCargarCarpeta.Size = new System.Drawing.Size(179, 40);
            this.btnCargarCarpeta.TabIndex = 1;
            this.btnCargarCarpeta.Text = "Cargar Carpeta";
            this.btnCargarCarpeta.UseVisualStyleBackColor = true;
            this.btnCargarCarpeta.Click += new System.EventHandler(this.btnCargarCarpeta_Click);
            // 
            // test1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(926, 705);
            this.Controls.Add(this.btnCargarCarpeta);
            this.Controls.Add(this.treeView1);
            this.Name = "test1";
            this.Text = "test1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button btnCargarCarpeta;
    }
}