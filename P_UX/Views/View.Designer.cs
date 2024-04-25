namespace P_UX
{
    partial class View
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View));
            this.button2 = new System.Windows.Forms.Button();
            this.btnBuyTickets = new System.Windows.Forms.Button();
            this.btnPassNavigo = new System.Windows.Forms.Button();
            this.btnITA = new System.Windows.Forms.Button();
            this.btnDEU = new System.Windows.Forms.Button();
            this.btnESP = new System.Windows.Forms.Button();
            this.btnANG = new System.Windows.Forms.Button();
            this.btnFRA = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 337);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(0, 0);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnBuyTickets
            // 
            this.btnBuyTickets.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnBuyTickets.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuyTickets.Image = ((System.Drawing.Image)(resources.GetObject("btnBuyTickets.Image")));
            this.btnBuyTickets.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuyTickets.Location = new System.Drawing.Point(12, 270);
            this.btnBuyTickets.Name = "btnBuyTickets";
            this.btnBuyTickets.Size = new System.Drawing.Size(1060, 252);
            this.btnBuyTickets.TabIndex = 0;
            this.btnBuyTickets.Text = "Acheter des billets";
            this.btnBuyTickets.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBuyTickets.UseVisualStyleBackColor = true;
            // 
            // btnPassNavigo
            // 
            this.btnPassNavigo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPassNavigo.BackgroundImage")));
            this.btnPassNavigo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnPassNavigo.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPassNavigo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPassNavigo.Location = new System.Drawing.Point(12, 12);
            this.btnPassNavigo.Name = "btnPassNavigo";
            this.btnPassNavigo.Size = new System.Drawing.Size(1060, 252);
            this.btnPassNavigo.TabIndex = 0;
            this.btnPassNavigo.Text = "Recharger Pass Navigo";
            this.btnPassNavigo.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPassNavigo.UseVisualStyleBackColor = true;
            // 
            // btnITA
            // 
            this.btnITA.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnITA.BackgroundImage")));
            this.btnITA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnITA.Location = new System.Drawing.Point(807, 549);
            this.btnITA.Name = "btnITA";
            this.btnITA.Size = new System.Drawing.Size(150, 88);
            this.btnITA.TabIndex = 10;
            this.btnITA.UseVisualStyleBackColor = true;
            // 
            // btnDEU
            // 
            this.btnDEU.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnDEU.BackgroundImage")));
            this.btnDEU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDEU.Location = new System.Drawing.Point(640, 549);
            this.btnDEU.Name = "btnDEU";
            this.btnDEU.Size = new System.Drawing.Size(150, 88);
            this.btnDEU.TabIndex = 11;
            this.btnDEU.UseVisualStyleBackColor = true;
            // 
            // btnESP
            // 
            this.btnESP.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnESP.BackgroundImage")));
            this.btnESP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnESP.Location = new System.Drawing.Point(467, 549);
            this.btnESP.Name = "btnESP";
            this.btnESP.Size = new System.Drawing.Size(150, 88);
            this.btnESP.TabIndex = 12;
            this.btnESP.UseVisualStyleBackColor = true;
            // 
            // btnANG
            // 
            this.btnANG.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnANG.BackgroundImage")));
            this.btnANG.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnANG.Location = new System.Drawing.Point(294, 549);
            this.btnANG.Name = "btnANG";
            this.btnANG.Size = new System.Drawing.Size(150, 88);
            this.btnANG.TabIndex = 13;
            this.btnANG.UseVisualStyleBackColor = true;
            this.btnANG.Click += new System.EventHandler(this.btnANG_Click);
            // 
            // btnFRA
            // 
            this.btnFRA.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFRA.BackgroundImage")));
            this.btnFRA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFRA.Location = new System.Drawing.Point(119, 549);
            this.btnFRA.Name = "btnFRA";
            this.btnFRA.Size = new System.Drawing.Size(150, 88);
            this.btnFRA.TabIndex = 14;
            this.btnFRA.UseVisualStyleBackColor = true;
            this.btnFRA.Click += new System.EventHandler(this.btnFRA_Click);
            // 
            // View
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.btnFRA);
            this.Controls.Add(this.btnITA);
            this.Controls.Add(this.btnDEU);
            this.Controls.Add(this.btnESP);
            this.Controls.Add(this.btnANG);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnBuyTickets);
            this.Controls.Add(this.btnPassNavigo);
            this.Name = "View";
            this.Text = "ChoixNavigo/Billet";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPassNavigo;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnBuyTickets;
        private System.Windows.Forms.Button btnITA;
        private System.Windows.Forms.Button btnDEU;
        private System.Windows.Forms.Button btnESP;
        private System.Windows.Forms.Button btnANG;
        private System.Windows.Forms.Button btnFRA;
    }
}

