namespace Vista
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
            this.btnVaca = new System.Windows.Forms.Button();
            this.btnPerro = new System.Windows.Forms.Button();
            this.btnCaballo = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lblSaludo = new System.Windows.Forms.Label();
            this.lblPregunta = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnVaca
            // 
            this.btnVaca.BackgroundImage = global::Vista.Properties.Resources.imgVaca;
            this.btnVaca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnVaca.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVaca.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnVaca.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnVaca.Location = new System.Drawing.Point(44, 386);
            this.btnVaca.Name = "btnVaca";
            this.btnVaca.Size = new System.Drawing.Size(208, 185);
            this.btnVaca.TabIndex = 0;
            this.btnVaca.UseVisualStyleBackColor = true;
            this.btnVaca.Click += new System.EventHandler(this.btnVaca_Click);
            // 
            // btnPerro
            // 
            this.btnPerro.BackgroundImage = global::Vista.Properties.Resources.imgPerro;
            this.btnPerro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPerro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPerro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPerro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnPerro.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnPerro.Location = new System.Drawing.Point(338, 386);
            this.btnPerro.Name = "btnPerro";
            this.btnPerro.Size = new System.Drawing.Size(208, 185);
            this.btnPerro.TabIndex = 1;
            this.btnPerro.Text = "PERRO";
            this.btnPerro.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPerro.UseVisualStyleBackColor = true;
            this.btnPerro.Click += new System.EventHandler(this.btnPerro_Click);
            // 
            // btnCaballo
            // 
            this.btnCaballo.BackgroundImage = global::Vista.Properties.Resources.imgCaballo;
            this.btnCaballo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCaballo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCaballo.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCaballo.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnCaballo.Location = new System.Drawing.Point(658, 386);
            this.btnCaballo.Name = "btnCaballo";
            this.btnCaballo.Size = new System.Drawing.Size(208, 185);
            this.btnCaballo.TabIndex = 2;
            this.btnCaballo.UseVisualStyleBackColor = true;
            this.btnCaballo.Click += new System.EventHandler(this.btnCaballo_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.BackgroundImage = global::Vista.Properties.Resources.iconoCerrar;
            this.btnSalir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSalir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalir.Location = new System.Drawing.Point(871, 12);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(46, 46);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPlay.BackgroundImage = global::Vista.Properties.Resources.play;
            this.btnPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPlay.Location = new System.Drawing.Point(417, 147);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(72, 64);
            this.btnPlay.TabIndex = 4;
            this.btnPlay.UseVisualStyleBackColor = false;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(519, 171);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(305, 40);
            this.label1.TabIndex = 5;
            this.label1.Text = "ESCUCHA EL SONIDO ";
            // 
            // lblSaludo
            // 
            this.lblSaludo.AutoSize = true;
            this.lblSaludo.BackColor = System.Drawing.Color.Transparent;
            this.lblSaludo.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblSaludo.Location = new System.Drawing.Point(12, 12);
            this.lblSaludo.Name = "lblSaludo";
            this.lblSaludo.Size = new System.Drawing.Size(64, 25);
            this.lblSaludo.TabIndex = 6;
            this.lblSaludo.Text = "label2";
            // 
            // lblPregunta
            // 
            this.lblPregunta.AutoSize = true;
            this.lblPregunta.BackColor = System.Drawing.Color.Transparent;
            this.lblPregunta.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPregunta.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblPregunta.Location = new System.Drawing.Point(479, 298);
            this.lblPregunta.Name = "lblPregunta";
            this.lblPregunta.Size = new System.Drawing.Size(185, 30);
            this.lblPregunta.TabIndex = 7;
            this.lblPregunta.Text = "¿QUÉ ANIMAL ES?";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.InitialDirectory = "C:\\Users\\gpnic\\Desktop\\JuegoAnimales\\Vista\\Sonidos\\";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Vista.Properties.Resources.granja;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(929, 583);
            this.ControlBox = false;
            this.Controls.Add(this.lblPregunta);
            this.Controls.Add(this.lblSaludo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnCaballo);
            this.Controls.Add(this.btnPerro);
            this.Controls.Add(this.btnVaca);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnVaca;
        private Button btnPerro;
        private Button btnCaballo;
        private Button btnSalir;
        private Button btnPlay;
        private Label label1;
        private Label lblSaludo;
        private Label lblPregunta;
        private OpenFileDialog openFileDialog1;
    }
}