namespace P_UX.Controller
{
    partial class PaymentOptions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PaymentOptions));
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnITA = new System.Windows.Forms.Button();
            this.btnDEU = new System.Windows.Forms.Button();
            this.btnESP = new System.Windows.Forms.Button();
            this.btnFRA = new System.Windows.Forms.Button();
            this.btnANG = new System.Windows.Forms.Button();
            this.lblTitlePayment = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(28, 575);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 74);
            this.btnCancel.TabIndex = 25;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(184, 575);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(140, 74);
            this.btnReturn.TabIndex = 24;
            this.btnReturn.Text = "Retour";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // btnITA
            // 
            this.btnITA.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnITA.BackgroundImage")));
            this.btnITA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnITA.Location = new System.Drawing.Point(939, 575);
            this.btnITA.Name = "btnITA";
            this.btnITA.Size = new System.Drawing.Size(121, 74);
            this.btnITA.TabIndex = 19;
            this.btnITA.UseVisualStyleBackColor = true;
            // 
            // btnDEU
            // 
            this.btnDEU.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDEU.BackgroundImage")));
            this.btnDEU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDEU.Location = new System.Drawing.Point(812, 575);
            this.btnDEU.Name = "btnDEU";
            this.btnDEU.Size = new System.Drawing.Size(121, 74);
            this.btnDEU.TabIndex = 20;
            this.btnDEU.UseVisualStyleBackColor = true;
            // 
            // btnESP
            // 
            this.btnESP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnESP.BackgroundImage")));
            this.btnESP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnESP.Location = new System.Drawing.Point(685, 575);
            this.btnESP.Name = "btnESP";
            this.btnESP.Size = new System.Drawing.Size(121, 74);
            this.btnESP.TabIndex = 21;
            this.btnESP.UseVisualStyleBackColor = true;
            // 
            // btnFRA
            // 
            this.btnFRA.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFRA.BackgroundImage")));
            this.btnFRA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFRA.Location = new System.Drawing.Point(431, 575);
            this.btnFRA.Name = "btnFRA";
            this.btnFRA.Size = new System.Drawing.Size(121, 74);
            this.btnFRA.TabIndex = 22;
            this.btnFRA.UseVisualStyleBackColor = true;
            // 
            // btnANG
            // 
            this.btnANG.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnANG.BackgroundImage")));
            this.btnANG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnANG.Location = new System.Drawing.Point(558, 575);
            this.btnANG.Name = "btnANG";
            this.btnANG.Size = new System.Drawing.Size(121, 74);
            this.btnANG.TabIndex = 23;
            this.btnANG.UseVisualStyleBackColor = true;
            // 
            // lblTitlePayment
            // 
            this.lblTitlePayment.AutoSize = true;
            this.lblTitlePayment.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitlePayment.Location = new System.Drawing.Point(145, 9);
            this.lblTitlePayment.Name = "lblTitlePayment";
            this.lblTitlePayment.Size = new System.Drawing.Size(811, 58);
            this.lblTitlePayment.TabIndex = 26;
            this.lblTitlePayment.Text = "Choissisez un moyen de paiement";
            // 
            // PaymentOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.lblTitlePayment);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnITA);
            this.Controls.Add(this.btnDEU);
            this.Controls.Add(this.btnESP);
            this.Controls.Add(this.btnFRA);
            this.Controls.Add(this.btnANG);
            this.Name = "PaymentOptions";
            this.Text = "PaymentOptions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnITA;
        private System.Windows.Forms.Button btnDEU;
        private System.Windows.Forms.Button btnESP;
        private System.Windows.Forms.Button btnFRA;
        private System.Windows.Forms.Button btnANG;
        private System.Windows.Forms.Label lblTitlePayment;
    }
}