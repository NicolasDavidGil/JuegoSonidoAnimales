namespace Vista
{
    partial class Form5
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
            this.btnOveja = new System.Windows.Forms.Button();
            this.btnPerro = new System.Windows.Forms.Button();
            this.btnVaca = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblPregunta
            // 
            this.lblPregunta.AutoSize = true;
            this.lblPregunta.BackColor = System.Drawing.Color.Transparent;
            this.lblPregunta.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPregunta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPregunta.Location = new System.Drawing.Point(348, 275);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(185, 30);
            this.lblPregunta.TabIndex = 31;
            this.lblPregunta.Text = "¿QUÉ ANIMAL ES?";
            // 
            // lblSaludo
            // 
            this.lblSaludo.AutoSize = true;
            this.lblSaludo.BackColor = System.Drawing.Color.Transparent;
            this.lblSaludo.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSaludo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblSaludo.Location = new System.Drawing.Point(12, 9);
            this.lblSaludo.Name = "lblSaludo";
            this.lblSaludo.Size = new System.Drawing.Size(64, 25);
            this.lblSaludo.TabIndex = 30;
            this.lblSaludo.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(514, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 40);
            this.label1.TabIndex = 29;
            this.label1.Text = "ESCUCHA EL SONIDO ";
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPlay.BackgroundImage = global::Vista.Properties.Resources.play;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlay.Location = new System.Drawing.Point(409, 128);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(72, 64);
            this.btnPlay.TabIndex = 28;
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = global::Vista.Properties.Resources.iconoCerrar;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Location = new System.Drawing.Point(855, 10);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(46, 46);
            this.btnSalir.TabIndex = 27;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnOveja
            // 
            this.btnOveja.BackgroundImage = global::Vista.Properties.Resources.imgOveja;
            this.btnOveja.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnOveja.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOveja.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnOveja.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnOveja.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnOveja.Location = new System.Drawing.Point(656, 347);
            this.btnOveja.Name = "btnOveja";
            this.btnOveja.Size = new System.Drawing.Size(208, 185);
            this.btnOveja.TabIndex = 26;
            this.btnOveja.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnOveja.UseVisualStyleBackColor = true;
            this.btnOveja.Click += new System.EventHandler(this.btnOveja_Click);
            // 
            // btnPerro
            // 
            this.btnPerro.BackgroundImage = global::Vista.Properties.Resources.imgPerro;
            this.btnPerro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPerro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPerro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPerro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPerro.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPerro.Location = new System.Drawing.Point(335, 347);
            this.btnPerro.Name = "btnPerro";
            this.btnPerro.Size = new System.Drawing.Size(208, 185);
            this.btnPerro.TabIndex = 25;
            this.btnPerro.Text = "PERRO";
            this.btnPerro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPerro.UseVisualStyleBackColor = true;
            this.btnPerro.Click += new System.EventHandler(this.btnPerro_Click);
            // 
            // btnVaca
            // 
            this.btnVaca.BackgroundImage = global::Vista.Properties.Resources.imgVaca;
            this.btnVaca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVaca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVaca.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnVaca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnVaca.Location = new System.Drawing.Point(51, 347);
            this.btnVaca.Name = "btnVaca";
            this.btnVaca.Size = new System.Drawing.Size(208, 185);
            this.btnVaca.TabIndex = 24;
            this.btnVaca.UseVisualStyleBackColor = true;
            this.btnVaca.Click += new System.EventHandler(this.btnVaca_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vista.Properties.Resources.granja;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(913, 544);
            this.ControlBox = false;
            this.Controls.Add(this.lblPregunta);
            this.Controls.Add(this.lblSaludo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnOveja);
            this.Controls.Add(this.btnPerro);
            this.Controls.Add(this.btnVaca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form5_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblPregunta;
        private Label lblSaludo;
        private Label label1;
        private Button btnPlay;
        private Button btnSalir;
        private Button btnOveja;
        private Button btnPerro;
        private Button btnVaca;
    }
}