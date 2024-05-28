namespace P_UX.Views
{
    partial class Payment
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
            this.lblTitlePayment = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitlePayment
            // 
            this.lblTitlePayment.AutoSize = true;
            this.lblTitlePayment.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlePayment.Location = new System.Drawing.Point(308, 9);
            this.lblTitlePayment.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitlePayment.Name = "lblTitlePayment";
            this.lblTitlePayment.Size = new System.Drawing.Size(852, 74);
            this.lblTitlePayment.TabIndex = 27;
            this.lblTitlePayment.Text = "Paiement de la commande";
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 814);
            this.Controls.Add(this.lblTitlePayment);
            this.Name = "Payment";
            this.Text = "Payment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitlePayment;
    }
}