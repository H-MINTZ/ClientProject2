namespace clientShop.GUI
{
    partial class FrmAllGiftCards
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
            this.dgvAllGiftCards = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllGiftCards)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAllGiftCards
            // 
            this.dgvAllGiftCards.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllGiftCards.Location = new System.Drawing.Point(105, 47);
            this.dgvAllGiftCards.Name = "dgvAllGiftCards";
            this.dgvAllGiftCards.Size = new System.Drawing.Size(590, 356);
            this.dgvAllGiftCards.TabIndex = 2;
            // 
            // FrmAllGiftCards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvAllGiftCards);
            this.Name = "FrmAllGiftCards";
            this.Text = "FrmAllGiftCards";
            this.Load += new System.EventHandler(this.FrmAllGiftCards_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllGiftCards)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllGiftCards;
    }
}