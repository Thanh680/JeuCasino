
namespace JeuCasino
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblnb1 = new System.Windows.Forms.Label();
            this.lblnb2 = new System.Windows.Forms.Label();
            this.lblnb3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblgg = new System.Windows.Forms.Label();
            this.lblessais = new System.Windows.Forms.Label();
            this.lbltaux = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(24, 32);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Jouer";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(24, 88);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Fin";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblnb1
            // 
            this.lblnb1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblnb1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnb1.Location = new System.Drawing.Point(132, 32);
            this.lblnb1.Name = "lblnb1";
            this.lblnb1.Size = new System.Drawing.Size(91, 79);
            this.lblnb1.TabIndex = 2;
            this.lblnb1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblnb2
            // 
            this.lblnb2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblnb2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnb2.Location = new System.Drawing.Point(266, 32);
            this.lblnb2.Name = "lblnb2";
            this.lblnb2.Size = new System.Drawing.Size(91, 79);
            this.lblnb2.TabIndex = 3;
            this.lblnb2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblnb3
            // 
            this.lblnb3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblnb3.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblnb3.Location = new System.Drawing.Point(396, 32);
            this.lblnb3.Name = "lblnb3";
            this.lblnb3.Size = new System.Drawing.Size(91, 79);
            this.lblnb3.TabIndex = 4;
            this.lblnb3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Indigo;
            this.label4.Location = new System.Drawing.Point(21, 129);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label4.Size = new System.Drawing.Size(96, 67);
            this.label4.TabIndex = 5;
            this.label4.Text = "Lucky Seven";
            // 
            // lblgg
            // 
            this.lblgg.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblgg.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblgg.Location = new System.Drawing.Point(15, 196);
            this.lblgg.Name = "lblgg";
            this.lblgg.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblgg.Size = new System.Drawing.Size(120, 44);
            this.lblgg.TabIndex = 6;
            this.lblgg.Text = "Jeux gagnés: 0";
            this.lblgg.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblessais
            // 
            this.lblessais.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblessais.ForeColor = System.Drawing.Color.ForestGreen;
            this.lblessais.Location = new System.Drawing.Point(12, 240);
            this.lblessais.Name = "lblessais";
            this.lblessais.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lblessais.Size = new System.Drawing.Size(135, 44);
            this.lblessais.TabIndex = 7;
            this.lblessais.Text = "Nombre d\'essais: 0";
            this.lblessais.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lbltaux
            // 
            this.lbltaux.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltaux.ForeColor = System.Drawing.Color.Crimson;
            this.lbltaux.Location = new System.Drawing.Point(23, 284);
            this.lbltaux.Name = "lbltaux";
            this.lbltaux.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.lbltaux.Size = new System.Drawing.Size(96, 24);
            this.lbltaux.TabIndex = 8;
            this.lbltaux.Text = "0,00 %";
            this.lbltaux.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(214, 146);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(522, 387);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbltaux);
            this.Controls.Add(this.lblessais);
            this.Controls.Add(this.lblgg);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblnb3);
            this.Controls.Add(this.lblnb2);
            this.Controls.Add(this.lblnb1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblnb1;
        private System.Windows.Forms.Label lblnb2;
        private System.Windows.Forms.Label lblnb3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblgg;
        private System.Windows.Forms.Label lblessais;
        private System.Windows.Forms.Label lbltaux;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

