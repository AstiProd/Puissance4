namespace Puissance4
{
    partial class ficPlayer
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
            this.lbJ1 = new System.Windows.Forms.Label();
            this.lbJ2 = new System.Windows.Forms.Label();
            this.tbPseudo1 = new System.Windows.Forms.TextBox();
            this.lbPseudo1 = new System.Windows.Forms.Label();
            this.lbPseudo2 = new System.Windows.Forms.Label();
            this.tbPseudo2 = new System.Windows.Forms.TextBox();
            this.rbRouge = new System.Windows.Forms.RadioButton();
            this.gbColor = new System.Windows.Forms.GroupBox();
            this.rbJaune = new System.Windows.Forms.RadioButton();
            this.btnPStart = new System.Windows.Forms.Button();
            this.gbColor.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbJ1
            // 
            this.lbJ1.AutoSize = true;
            this.lbJ1.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbJ1.Location = new System.Drawing.Point(126, 60);
            this.lbJ1.Name = "lbJ1";
            this.lbJ1.Size = new System.Drawing.Size(124, 29);
            this.lbJ1.TabIndex = 0;
            this.lbJ1.Text = "Joueur 1";
            // 
            // lbJ2
            // 
            this.lbJ2.AutoSize = true;
            this.lbJ2.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbJ2.Location = new System.Drawing.Point(524, 60);
            this.lbJ2.Name = "lbJ2";
            this.lbJ2.Size = new System.Drawing.Size(125, 29);
            this.lbJ2.TabIndex = 1;
            this.lbJ2.Text = "Joueur 2";
            // 
            // tbPseudo1
            // 
            this.tbPseudo1.Location = new System.Drawing.Point(131, 119);
            this.tbPseudo1.Name = "tbPseudo1";
            this.tbPseudo1.Size = new System.Drawing.Size(119, 22);
            this.tbPseudo1.TabIndex = 2;
            // 
            // lbPseudo1
            // 
            this.lbPseudo1.AutoSize = true;
            this.lbPseudo1.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPseudo1.Location = new System.Drawing.Point(29, 123);
            this.lbPseudo1.Name = "lbPseudo1";
            this.lbPseudo1.Size = new System.Drawing.Size(74, 18);
            this.lbPseudo1.TabIndex = 3;
            this.lbPseudo1.Text = "Pseudo";
            // 
            // lbPseudo2
            // 
            this.lbPseudo2.AutoSize = true;
            this.lbPseudo2.Font = new System.Drawing.Font("Showcard Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPseudo2.Location = new System.Drawing.Point(427, 120);
            this.lbPseudo2.Name = "lbPseudo2";
            this.lbPseudo2.Size = new System.Drawing.Size(74, 18);
            this.lbPseudo2.TabIndex = 5;
            this.lbPseudo2.Text = "Pseudo";
            // 
            // tbPseudo2
            // 
            this.tbPseudo2.Location = new System.Drawing.Point(529, 116);
            this.tbPseudo2.Name = "tbPseudo2";
            this.tbPseudo2.Size = new System.Drawing.Size(120, 22);
            this.tbPseudo2.TabIndex = 4;
            // 
            // rbRouge
            // 
            this.rbRouge.AutoSize = true;
            this.rbRouge.Location = new System.Drawing.Point(6, 38);
            this.rbRouge.Name = "rbRouge";
            this.rbRouge.Size = new System.Drawing.Size(93, 25);
            this.rbRouge.TabIndex = 6;
            this.rbRouge.TabStop = true;
            this.rbRouge.Text = "Rouge";
            this.rbRouge.UseVisualStyleBackColor = true;
            // 
            // gbColor
            // 
            this.gbColor.Controls.Add(this.rbJaune);
            this.gbColor.Controls.Add(this.rbRouge);
            this.gbColor.Font = new System.Drawing.Font("Showcard Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbColor.Location = new System.Drawing.Point(131, 186);
            this.gbColor.Name = "gbColor";
            this.gbColor.Size = new System.Drawing.Size(136, 151);
            this.gbColor.TabIndex = 7;
            this.gbColor.TabStop = false;
            this.gbColor.Text = "Couleur";
            // 
            // rbJaune
            // 
            this.rbJaune.AutoSize = true;
            this.rbJaune.Location = new System.Drawing.Point(6, 69);
            this.rbJaune.Name = "rbJaune";
            this.rbJaune.Size = new System.Drawing.Size(86, 25);
            this.rbJaune.TabIndex = 7;
            this.rbJaune.TabStop = true;
            this.rbJaune.Text = "Jaune";
            this.rbJaune.UseVisualStyleBackColor = true;
            // 
            // btnPStart
            // 
            this.btnPStart.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.btnPStart.Font = new System.Drawing.Font("Showcard Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPStart.ForeColor = System.Drawing.Color.Black;
            this.btnPStart.Location = new System.Drawing.Point(301, 360);
            this.btnPStart.Name = "btnPStart";
            this.btnPStart.Size = new System.Drawing.Size(225, 68);
            this.btnPStart.TabIndex = 8;
            this.btnPStart.Text = "JOUER";
            this.btnPStart.UseVisualStyleBackColor = false;
            this.btnPStart.Click += new System.EventHandler(this.btnPStart_Click);
            // 
            // ficPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnPStart);
            this.Controls.Add(this.gbColor);
            this.Controls.Add(this.lbPseudo2);
            this.Controls.Add(this.tbPseudo2);
            this.Controls.Add(this.lbPseudo1);
            this.Controls.Add(this.tbPseudo1);
            this.Controls.Add(this.lbJ2);
            this.Controls.Add(this.lbJ1);
            this.Name = "ficPlayer";
            this.Text = "Menu joueur ";
            this.gbColor.ResumeLayout(false);
            this.gbColor.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbJ1;
        private System.Windows.Forms.Label lbJ2;
        private System.Windows.Forms.TextBox tbPseudo1;
        private System.Windows.Forms.Label lbPseudo1;
        private System.Windows.Forms.Label lbPseudo2;
        private System.Windows.Forms.TextBox tbPseudo2;
        private System.Windows.Forms.RadioButton rbRouge;
        private System.Windows.Forms.GroupBox gbColor;
        private System.Windows.Forms.RadioButton rbJaune;
        private System.Windows.Forms.Button btnPStart;
    }
}