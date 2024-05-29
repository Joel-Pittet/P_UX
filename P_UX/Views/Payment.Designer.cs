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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payment));
            this.lblTitlePayment = new System.Windows.Forms.Label();
            this.pnlPieces = new System.Windows.Forms.Panel();
            this.pnlCards = new System.Windows.Forms.Panel();
            this.lblAcceptedBills = new System.Windows.Forms.Label();
            this.lblAcceptedCoins = new System.Windows.Forms.Label();
            this.lblAcceptedCard = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnITA = new System.Windows.Forms.Button();
            this.btnDEU = new System.Windows.Forms.Button();
            this.btnESP = new System.Windows.Forms.Button();
            this.btnFRA = new System.Windows.Forms.Button();
            this.btnANG = new System.Windows.Forms.Button();
            this.lblTotalAmountToPay = new System.Windows.Forms.Label();
            this.lblEuro = new System.Windows.Forms.Label();
            this.lblAmountToPayInEuro = new System.Windows.Forms.Label();
            this.pnlBill = new System.Windows.Forms.Panel();
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
            // pnlPieces
            // 
            this.pnlPieces.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlPieces.BackgroundImage")));
            this.pnlPieces.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlPieces.Location = new System.Drawing.Point(358, 518);
            this.pnlPieces.Name = "pnlPieces";
            this.pnlPieces.Size = new System.Drawing.Size(600, 121);
            this.pnlPieces.TabIndex = 37;
            // 
            // pnlCards
            // 
            this.pnlCards.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlCards.BackgroundImage")));
            this.pnlCards.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlCards.Location = new System.Drawing.Point(32, 518);
            this.pnlCards.Margin = new System.Windows.Forms.Padding(4);
            this.pnlCards.Name = "pnlCards";
            this.pnlCards.Size = new System.Drawing.Size(287, 103);
            this.pnlCards.TabIndex = 36;
            // 
            // lblAcceptedBills
            // 
            this.lblAcceptedBills.AutoSize = true;
            this.lblAcceptedBills.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcceptedBills.Location = new System.Drawing.Point(1100, 472);
            this.lblAcceptedBills.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAcceptedBills.Name = "lblAcceptedBills";
            this.lblAcceptedBills.Size = new System.Drawing.Size(217, 32);
            this.lblAcceptedBills.TabIndex = 33;
            this.lblAcceptedBills.Text = "Billets acceptés";
            // 
            // lblAcceptedCoins
            // 
            this.lblAcceptedCoins.AutoSize = true;
            this.lblAcceptedCoins.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcceptedCoins.Location = new System.Drawing.Point(521, 472);
            this.lblAcceptedCoins.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAcceptedCoins.Name = "lblAcceptedCoins";
            this.lblAcceptedCoins.Size = new System.Drawing.Size(247, 32);
            this.lblAcceptedCoins.TabIndex = 34;
            this.lblAcceptedCoins.Text = "Pièces acceptées";
            // 
            // lblAcceptedCard
            // 
            this.lblAcceptedCard.AutoSize = true;
            this.lblAcceptedCard.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcceptedCard.Location = new System.Drawing.Point(44, 472);
            this.lblAcceptedCard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAcceptedCard.Name = "lblAcceptedCard";
            this.lblAcceptedCard.Size = new System.Drawing.Size(248, 32);
            this.lblAcceptedCard.TabIndex = 35;
            this.lblAcceptedCard.Text = "Cartes acceptées";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(32, 710);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(200, 91);
            this.btnCancel.TabIndex = 44;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReturn.Location = new System.Drawing.Point(240, 710);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(4);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(187, 91);
            this.btnReturn.TabIndex = 43;
            this.btnReturn.Text = "Retour";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // btnITA
            // 
            this.btnITA.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnITA.BackgroundImage")));
            this.btnITA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnITA.Location = new System.Drawing.Point(1247, 710);
            this.btnITA.Margin = new System.Windows.Forms.Padding(4);
            this.btnITA.Name = "btnITA";
            this.btnITA.Size = new System.Drawing.Size(161, 91);
            this.btnITA.TabIndex = 38;
            this.btnITA.UseVisualStyleBackColor = true;
            this.btnITA.Click += new System.EventHandler(this.btnITA_Click);
            // 
            // btnDEU
            // 
            this.btnDEU.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDEU.BackgroundImage")));
            this.btnDEU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDEU.Location = new System.Drawing.Point(1078, 710);
            this.btnDEU.Margin = new System.Windows.Forms.Padding(4);
            this.btnDEU.Name = "btnDEU";
            this.btnDEU.Size = new System.Drawing.Size(161, 91);
            this.btnDEU.TabIndex = 39;
            this.btnDEU.UseVisualStyleBackColor = true;
            this.btnDEU.Click += new System.EventHandler(this.btnDEU_Click);
            // 
            // btnESP
            // 
            this.btnESP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnESP.BackgroundImage")));
            this.btnESP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnESP.Location = new System.Drawing.Point(908, 710);
            this.btnESP.Margin = new System.Windows.Forms.Padding(4);
            this.btnESP.Name = "btnESP";
            this.btnESP.Size = new System.Drawing.Size(161, 91);
            this.btnESP.TabIndex = 40;
            this.btnESP.UseVisualStyleBackColor = true;
            this.btnESP.Click += new System.EventHandler(this.btnESP_Click);
            // 
            // btnFRA
            // 
            this.btnFRA.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFRA.BackgroundImage")));
            this.btnFRA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFRA.Location = new System.Drawing.Point(570, 710);
            this.btnFRA.Margin = new System.Windows.Forms.Padding(4);
            this.btnFRA.Name = "btnFRA";
            this.btnFRA.Size = new System.Drawing.Size(161, 91);
            this.btnFRA.TabIndex = 41;
            this.btnFRA.UseVisualStyleBackColor = true;
            this.btnFRA.Click += new System.EventHandler(this.btnFRA_Click);
            // 
            // btnANG
            // 
            this.btnANG.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnANG.BackgroundImage")));
            this.btnANG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnANG.Location = new System.Drawing.Point(739, 710);
            this.btnANG.Margin = new System.Windows.Forms.Padding(4);
            this.btnANG.Name = "btnANG";
            this.btnANG.Size = new System.Drawing.Size(161, 91);
            this.btnANG.TabIndex = 42;
            this.btnANG.UseVisualStyleBackColor = true;
            this.btnANG.Click += new System.EventHandler(this.btnANG_Click);
            // 
            // lblTotalAmountToPay
            // 
            this.lblTotalAmountToPay.AutoSize = true;
            this.lblTotalAmountToPay.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalAmountToPay.Location = new System.Drawing.Point(416, 200);
            this.lblTotalAmountToPay.Name = "lblTotalAmountToPay";
            this.lblTotalAmountToPay.Size = new System.Drawing.Size(276, 49);
            this.lblTotalAmountToPay.TabIndex = 45;
            this.lblTotalAmountToPay.Text = "Total à payer";
            // 
            // lblEuro
            // 
            this.lblEuro.AutoSize = true;
            this.lblEuro.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEuro.Location = new System.Drawing.Point(855, 202);
            this.lblEuro.Name = "lblEuro";
            this.lblEuro.Size = new System.Drawing.Size(42, 47);
            this.lblEuro.TabIndex = 46;
            this.lblEuro.Text = "€";
            // 
            // lblAmountToPayInEuro
            // 
            this.lblAmountToPayInEuro.AutoSize = true;
            this.lblAmountToPayInEuro.Font = new System.Drawing.Font("Century Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAmountToPayInEuro.Location = new System.Drawing.Point(731, 202);
            this.lblAmountToPayInEuro.Name = "lblAmountToPayInEuro";
            this.lblAmountToPayInEuro.Size = new System.Drawing.Size(0, 47);
            this.lblAmountToPayInEuro.TabIndex = 47;
            // 
            // pnlBill
            // 
            this.pnlBill.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pnlBill.BackgroundImage")));
            this.pnlBill.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pnlBill.Location = new System.Drawing.Point(1014, 518);
            this.pnlBill.Margin = new System.Windows.Forms.Padding(4);
            this.pnlBill.Name = "pnlBill";
            this.pnlBill.Size = new System.Drawing.Size(373, 103);
            this.pnlBill.TabIndex = 37;
            // 
            // Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1445, 814);
            this.Controls.Add(this.pnlBill);
            this.Controls.Add(this.lblAmountToPayInEuro);
            this.Controls.Add(this.lblEuro);
            this.Controls.Add(this.lblTotalAmountToPay);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnITA);
            this.Controls.Add(this.btnDEU);
            this.Controls.Add(this.btnESP);
            this.Controls.Add(this.btnFRA);
            this.Controls.Add(this.btnANG);
            this.Controls.Add(this.pnlPieces);
            this.Controls.Add(this.pnlCards);
            this.Controls.Add(this.lblAcceptedBills);
            this.Controls.Add(this.lblAcceptedCoins);
            this.Controls.Add(this.lblAcceptedCard);
            this.Controls.Add(this.lblTitlePayment);
            this.Name = "Payment";
            this.Text = "Payment";
            this.Activated += new System.EventHandler(this.Payment_Activated);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitlePayment;
        private System.Windows.Forms.Panel pnlPieces;
        private System.Windows.Forms.Panel pnlCards;
        private System.Windows.Forms.Label lblAcceptedBills;
        private System.Windows.Forms.Label lblAcceptedCoins;
        private System.Windows.Forms.Label lblAcceptedCard;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnITA;
        private System.Windows.Forms.Button btnDEU;
        private System.Windows.Forms.Button btnESP;
        private System.Windows.Forms.Button btnFRA;
        private System.Windows.Forms.Button btnANG;
        private System.Windows.Forms.Label lblTotalAmountToPay;
        private System.Windows.Forms.Label lblEuro;
        private System.Windows.Forms.Label lblAmountToPayInEuro;
        private System.Windows.Forms.Panel pnlBill;
    }
}