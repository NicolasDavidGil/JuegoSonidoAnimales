namespace Vista
{
    partial class Form2
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
            this.lblPregunta = new System.Windows.Forms.Label();
            this.lblSaludo = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnCaballo = new System.Windows.Forms.Button();
            this.btnLeon = new System.Windows.Forms.Button();
            this.btnGato = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPregunta
            // 
            this.lblPregunta.AutoSize = true;
            this.lblPregunta.BackColor = System.Drawing.Color.Transparent;
            this.lblPregunta.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPregunta.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblPregunta.Location = new System.Drawing.Point(386, 304);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(185, 30);
            this.lblPregunta.TabIndex = 15;
            this.lblPregunta.Text = "¿QUÉ ANIMAL ES?";
            // 
            // lblSaludo
            // 
            this.lblSaludo.AutoSize = true;
            this.lblSaludo.BackColor = System.Drawing.Color.Transparent;
            this.lblSaludo.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSaludo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lblSaludo.Location = new System.Drawing.Point(12, 9);
            this.lblSaludo.Name = "lblSaludo";
            this.lblSaludo.Size = new System.Drawing.Size(64, 25);
            this.lblSaludo.TabIndex = 14;
            this.lblSaludo.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(541, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 40);
            this.label1.TabIndex = 13;
            this.label1.Text = "ESCUCHA EL SONIDO ";
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPlay.BackgroundImage = global::Vista.Properties.Resources.play;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlay.Location = new System.Drawing.Point(442, 159);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(72, 64);
            this.btnPlay.TabIndex = 12;
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = global::Vista.Properties.Resources.iconoCerrar;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Location = new System.Drawing.Point(871, 24);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(46, 46);
            this.btnSalir.TabIndex = 11;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnCaballo
            // 
            this.btnCaballo.BackgroundImage = global::Vista.Properties.Resources.imgCaballo;
            this.btnCaballo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCaballo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCaballo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCaballo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCaballo.Location = new System.Drawing.Point(683, 366);
            this.btnCaballo.Name = "btnCaballo";
            this.btnCaballo.Size = new System.Drawing.Size(208, 185);
            this.btnCaballo.TabIndex = 10;
            this.btnCaballo.UseVisualStyleBackColor = true;
            this.btnCaballo.Click += new System.EventHandler(this.btnCaballo_Click);
            // 
            // btnLeon
            // 
            this.btnLeon.BackgroundImage = global::Vista.Properties.Resources.imgLeon;
            this.btnLeon.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnLeon.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLeon.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLeon.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnLeon.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLeon.Location = new System.Drawing.Point(363, 366);
            this.btnLeon.Name = "btnLeon";
            this.btnLeon.Size = new System.Drawing.Size(208, 185);
            this.btnLeon.TabIndex = 9;
            this.btnLeon.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLeon.UseVisualStyleBackColor = true;
            this.btnLeon.Click += new System.EventHandler(this.btnLeon_Click);
            // 
            // btnGato
            // 
            this.btnGato.BackgroundImage = global::Vista.Properties.Resources.imgGato;
            this.btnGato.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnGato.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGato.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGato.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnGato.Location = new System.Drawing.Point(69, 366);
            this.btnGato.Name = "btnGato";
            this.btnGato.Size = new System.Drawing.Size(208, 185);
            this.btnGato.TabIndex = 8;
            this.btnGato.UseVisualStyleBackColor = true;
            this.btnGato.Click += new System.EventHandler(this.btnGato_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vista.Properties.Resources.fondo_selva;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(929, 583);
            this.ControlBox = false;
            this.Controls.Add(this.lblPregunta);
            this.Controls.Add(this.lblSaludo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCaballo);
            this.Controls.Add(this.btnLeon);
            this.Controls.Add(this.btnGato);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblPregunta;
        private Label lblSaludo;
        private Label label1;
        private Button btnPlay;
        private Button btnSalir;
        private Button btnCaballo;
        private Button btnLeon;
        private Button btnGato;
    }
}