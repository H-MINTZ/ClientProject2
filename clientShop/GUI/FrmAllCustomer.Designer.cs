namespace clientShop.GUI
{
    partial class FrmAllCustomer
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
            this.dgvAllCustomer = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAllCustomer
            // 
            this.dgvAllCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllCustomer.Location = new System.Drawing.Point(116, 38);
            this.dgvAllCustomer.Name = "dgvAllCustomer";
            this.dgvAllCustomer.Size = new System.Drawing.Size(590, 356);
            this.dgvAllCustomer.TabIndex = 1;
            // 
            // FrmAllCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvAllCustomer);
            this.Name = "FrmAllCustomer";
            this.Text = "הצגה של כל הלקוחות";
            this.Load += new System.EventHandler(this.FrmAllCustomer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllCustomer;
    }
}