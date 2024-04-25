namespace P_UX
{
    partial class TicketsSelection
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnITA = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnDEU = new System.Windows.Forms.Button();
            this.btnESP = new System.Windows.Forms.Button();
            this.btnUK = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(320, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 58);
            this.label1.TabIndex = 0;
            this.label1.Text = "Faites votre choix";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1032, 52);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btnITA
            // 
            this.btnITA.BackgroundImage = global::P_UX.Properties.Resources.flag_Italy;
            this.btnITA.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnITA.Location = new System.Drawing.Point(906, 561);
            this.btnITA.Name = "btnITA";
            this.btnITA.Size = new System.Drawing.Size(150, 88);
            this.btnITA.TabIndex = 6;
            this.btnITA.UseVisualStyleBackColor = true;
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(180, 561);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(150, 88);
            this.btnReturn.TabIndex = 10;
            this.btnReturn.Text = "Retour";
            this.btnReturn.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(24, 561);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(150, 88);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Annuler";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnDEU
            // 
            this.btnDEU.BackgroundImage = global::P_UX.Properties.Resources.flag_Germany;
            this.btnDEU.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDEU.Location = new System.Drawing.Point(750, 561);
            this.btnDEU.Name = "btnDEU";
            this.btnDEU.Size = new System.Drawing.Size(150, 88);
            this.btnDEU.TabIndex = 7;
            this.btnDEU.UseVisualStyleBackColor = true;
            // 
            // btnESP
            // 
            this.btnESP.BackgroundImage = global::P_UX.Properties.Resources.flag_Spain;
            this.btnESP.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnESP.Location = new System.Drawing.Point(593, 561);
            this.btnESP.Name = "btnESP";
            this.btnESP.Size = new System.Drawing.Size(150, 88);
            this.btnESP.TabIndex = 8;
            this.btnESP.UseVisualStyleBackColor = true;
            // 
            // btnUK
            // 
            this.btnUK.BackgroundImage = global::P_UX.Properties.Resources.flag_UK;
            this.btnUK.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUK.Location = new System.Drawing.Point(437, 561);
            this.btnUK.Name = "btnUK";
            this.btnUK.Size = new System.Drawing.Size(150, 88);
            this.btnUK.TabIndex = 9;
            this.btnUK.UseVisualStyleBackColor = true;
            // 
            // TicketsSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1084, 661);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnITA);
            this.Controls.Add(this.btnDEU);
            this.Controls.Add(this.btnESP);
            this.Controls.Add(this.btnUK);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "TicketsSelection";
            this.Text = "TicketsSelection";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnITA;
        private System.Windows.Forms.Button btnDEU;
        private System.Windows.Forms.Button btnESP;
        private System.Windows.Forms.Button btnUK;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Button btnCancel;
    }
}