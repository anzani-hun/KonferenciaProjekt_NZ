namespace KonferenciaProjekt
{
    partial class Form1
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
            this.panelErtekeles = new System.Windows.Forms.Panel();
            this.buttonMentes = new System.Windows.Forms.Button();
            this.buttonBalNyil = new System.Windows.Forms.Button();
            this.buttonJobbNyil = new System.Windows.Forms.Button();
            this.pictureBoxKolto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKolto)).BeginInit();
            this.SuspendLayout();
            // 
            // panelErtekeles
            // 
            this.panelErtekeles.Location = new System.Drawing.Point(391, 12);
            this.panelErtekeles.Name = "panelErtekeles";
            this.panelErtekeles.Size = new System.Drawing.Size(563, 324);
            this.panelErtekeles.TabIndex = 1;
            // 
            // buttonMentes
            // 
            this.buttonMentes.AutoSize = true;
            this.buttonMentes.BackgroundImage = global::KonferenciaProjekt.Properties.Resources.ment;
            this.buttonMentes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonMentes.Location = new System.Drawing.Point(152, 268);
            this.buttonMentes.Name = "buttonMentes";
            this.buttonMentes.Size = new System.Drawing.Size(60, 60);
            this.buttonMentes.TabIndex = 4;
            this.buttonMentes.UseVisualStyleBackColor = true;
            // 
            // buttonBalNyil
            // 
            this.buttonBalNyil.BackgroundImage = global::KonferenciaProjekt.Properties.Resources.bal;
            this.buttonBalNyil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonBalNyil.Location = new System.Drawing.Point(12, 90);
            this.buttonBalNyil.Name = "buttonBalNyil";
            this.buttonBalNyil.Size = new System.Drawing.Size(70, 70);
            this.buttonBalNyil.TabIndex = 3;
            this.buttonBalNyil.UseVisualStyleBackColor = true;
            this.buttonBalNyil.Click += new System.EventHandler(this.buttonBalNyil_Click);
            // 
            // buttonJobbNyil
            // 
            this.buttonJobbNyil.BackgroundImage = global::KonferenciaProjekt.Properties.Resources.jobb;
            this.buttonJobbNyil.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonJobbNyil.Location = new System.Drawing.Point(294, 90);
            this.buttonJobbNyil.Name = "buttonJobbNyil";
            this.buttonJobbNyil.Size = new System.Drawing.Size(70, 70);
            this.buttonJobbNyil.TabIndex = 2;
            this.buttonJobbNyil.UseVisualStyleBackColor = true;
            this.buttonJobbNyil.Click += new System.EventHandler(this.buttonJobbNyil_Click);
            // 
            // pictureBoxKolto
            // 
            this.pictureBoxKolto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxKolto.Location = new System.Drawing.Point(88, 12);
            this.pictureBoxKolto.Name = "pictureBoxKolto";
            this.pictureBoxKolto.Size = new System.Drawing.Size(200, 250);
            this.pictureBoxKolto.TabIndex = 0;
            this.pictureBoxKolto.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 411);
            this.Controls.Add(this.buttonMentes);
            this.Controls.Add(this.buttonBalNyil);
            this.Controls.Add(this.buttonJobbNyil);
            this.Controls.Add(this.panelErtekeles);
            this.Controls.Add(this.pictureBoxKolto);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxKolto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxKolto;
        private System.Windows.Forms.Panel panelErtekeles;
        private System.Windows.Forms.Button buttonJobbNyil;
        private System.Windows.Forms.Button buttonBalNyil;
        private System.Windows.Forms.Button buttonMentes;
    }
}

