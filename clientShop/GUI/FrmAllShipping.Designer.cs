namespace clientShop.GUI
{
    partial class FrmAllShipping
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
            this.dgvAllShipping = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllShipping)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAllShipping
            // 
            this.dgvAllShipping.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllShipping.Location = new System.Drawing.Point(84, 33);
            this.dgvAllShipping.Name = "dgvAllShipping";
            this.dgvAllShipping.Size = new System.Drawing.Size(598, 378);
            this.dgvAllShipping.TabIndex = 0;
            // 
            // FrmAllShipping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvAllShipping);
            this.Name = "FrmAllShipping";
            this.Text = "FrmAllShipping";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllShipping)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllShipping;
    }
}