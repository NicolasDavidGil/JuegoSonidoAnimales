namespace Vista
{
    partial class FormExito
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
            this.ptbExito = new System.Windows.Forms.PictureBox();
            this.ptbCargando = new System.Windows.Forms.PictureBox();
            this.lblCargando = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.ptbExito)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCargando)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ptbExito
            // 
            this.ptbExito.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbExito.Location = new System.Drawing.Point(170, 61);
            this.ptbExito.Name = "ptbExito";
            this.ptbExito.Size = new System.Drawing.Size(343, 141);
            this.ptbExito.TabIndex = 0;
            this.ptbExito.TabStop = false;
            // 
            // ptbCargando
            // 
            this.ptbCargando.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ptbCargando.Location = new System.Drawing.Point(122, 285);
            this.ptbCargando.Name = "ptbCargando";
            this.ptbCargando.Size = new System.Drawing.Size(391, 235);
            this.ptbCargando.TabIndex = 1;
            this.ptbCargando.TabStop = false;
            // 
            // lblCargando
            // 
            this.lblCargando.AutoSize = true;
            this.lblCargando.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCargando.Location = new System.Drawing.Point(12, 222);
            this.lblCargando.Name = "lblCargando";
            this.lblCargando.Size = new System.Drawing.Size(0, 30);
            this.lblCargando.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ptbExito);
            this.panel1.Controls.Add(this.lblCargando);
            this.panel1.Controls.Add(this.ptbCargando);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(659, 559);
            this.panel1.TabIndex = 3;
            // 
            // FormExito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(659, 559);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormExito";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.FormExito_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ptbExito)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCargando)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private PictureBox ptbExito;
        private PictureBox ptbCargando;
        private Label lblCargando;
        private Panel panel1;
    }
}