namespace DemoADONET2023
{
    partial class DeleteProduct
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
            this.lbCodigo = new System.Windows.Forms.Label();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.cbCodigo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbCodigo
            // 
            this.lbCodigo.AutoSize = true;
            this.lbCodigo.Location = new System.Drawing.Point(138, 92);
            this.lbCodigo.Name = "lbCodigo";
            this.lbCodigo.Size = new System.Drawing.Size(54, 16);
            this.lbCodigo.TabIndex = 0;
            this.lbCodigo.Text = "Codigo:";
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(169, 131);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(130, 61);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // cbCodigo
            // 
            this.cbCodigo.FormattingEnabled = true;
            this.cbCodigo.Location = new System.Drawing.Point(198, 84);
            this.cbCodigo.Name = "cbCodigo";
            this.cbCodigo.Size = new System.Drawing.Size(121, 24);
            this.cbCodigo.TabIndex = 3;
            this.cbCodigo.SelectedIndexChanged += new System.EventHandler(this.cbCodigo_SelectedIndexChanged);
            // 
            // DeleteProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(498, 306);
            this.Controls.Add(this.cbCodigo);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.lbCodigo);
            this.Name = "DeleteProduct";
            this.Text = "DeleteProduct";
            this.Load += new System.EventHandler(this.DeleteProduct_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbCodigo;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.ComboBox cbCodigo;
    }
}