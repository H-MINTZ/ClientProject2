namespace clientShop.GUI
{
    partial class FrmAllOrders
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
            this.dgvAllOrders = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllOrders)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAllOrders
            // 
            this.dgvAllOrders.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllOrders.Location = new System.Drawing.Point(103, 40);
            this.dgvAllOrders.Name = "dgvAllOrders";
            this.dgvAllOrders.Size = new System.Drawing.Size(579, 344);
            this.dgvAllOrders.TabIndex = 0;
            // 
            // FrmAllOrders
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvAllOrders);
            this.Name = "FrmAllOrders";
            this.Text = "fmrOrders";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllOrders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllOrders;
    }
}