namespace T_Time_Zoubeidi
{
    partial class Form1
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
            this.btn_num = new System.Windows.Forms.Button();
            this.btn_Anal = new System.Windows.Forms.Button();
            this.lbl_Choix = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_modif = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_num
            // 
            this.btn_num.Location = new System.Drawing.Point(27, 188);
            this.btn_num.Name = "btn_num";
            this.btn_num.Size = new System.Drawing.Size(483, 79);
            this.btn_num.TabIndex = 0;
            this.btn_num.Text = "Horloge Numérique";
            this.btn_num.UseVisualStyleBackColor = true;
            // 
            // btn_Anal
            // 
            this.btn_Anal.Location = new System.Drawing.Point(27, 79);
            this.btn_Anal.Name = "btn_Anal";
            this.btn_Anal.Size = new System.Drawing.Size(483, 79);
            this.btn_Anal.TabIndex = 1;
            this.btn_Anal.Text = "Horloge Analogique";
            this.btn_Anal.UseVisualStyleBackColor = true;
            this.btn_Anal.Click += new System.EventHandler(this.btn_Anal_Click);
            // 
            // lbl_Choix
            // 
            this.lbl_Choix.AutoSize = true;
            this.lbl_Choix.Location = new System.Drawing.Point(206, 38);
            this.lbl_Choix.Name = "lbl_Choix";
            this.lbl_Choix.Size = new System.Drawing.Size(109, 13);
            this.lbl_Choix.TabIndex = 4;
            this.lbl_Choix.Text = "Choisissez une option";
            this.lbl_Choix.Click += new System.EventHandler(this.label2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(557, 391);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // btn_modif
            // 
            this.btn_modif.Location = new System.Drawing.Point(27, 300);
            this.btn_modif.Name = "btn_modif";
            this.btn_modif.Size = new System.Drawing.Size(483, 79);
            this.btn_modif.TabIndex = 6;
            this.btn_modif.Text = "Modifier l\'heure";
            this.btn_modif.UseVisualStyleBackColor = true;
            this.btn_modif.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 391);
            this.Controls.Add(this.btn_modif);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_Choix);
            this.Controls.Add(this.btn_Anal);
            this.Controls.Add(this.btn_num);
            this.Name = "Form1";
            this.Text = "T-Time";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_num;
        private System.Windows.Forms.Button btn_Anal;
        private System.Windows.Forms.Label lbl_Choix;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_modif;
    }
}

