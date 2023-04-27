namespace DemoADONET2023
{
    partial class Form1
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
            this.dgvDemo = new System.Windows.Forms.DataGridView();
            this.btnListar = new System.Windows.Forms.Button();
            this.txtDescription = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDemo)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDemo
            // 
            this.dgvDemo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDemo.Location = new System.Drawing.Point(25, 152);
            this.dgvDemo.Name = "dgvDemo";
            this.dgvDemo.RowHeadersWidth = 51;
            this.dgvDemo.RowTemplate.Height = 24;
            this.dgvDemo.Size = new System.Drawing.Size(708, 340);
            this.dgvDemo.TabIndex = 0;
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(305, 76);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(141, 52);
            this.btnListar.TabIndex = 1;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(561, 106);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(138, 22);
            this.txtDescription.TabIndex = 4;
            this.txtDescription.TextChanged += new System.EventHandler(this.txtDescription_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 527);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.dgvDemo);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvDemo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDemo;
        private System.Windows.Forms.Button btnListar;
        private System.Windows.Forms.TextBox txtDescription;
    }
}

