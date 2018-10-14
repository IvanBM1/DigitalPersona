namespace DigitalPersona
{
    partial class WindowLogin
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
            this.imagePawprint = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSignup = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.imagePawprint)).BeginInit();
            this.SuspendLayout();
            // 
            // imagePawprint
            // 
            this.imagePawprint.Image = global::DigitalPersona.Properties.Resources.pawprint;
            this.imagePawprint.Location = new System.Drawing.Point(115, 115);
            this.imagePawprint.Name = "imagePawprint";
            this.imagePawprint.Size = new System.Drawing.Size(160, 160);
            this.imagePawprint.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.imagePawprint.TabIndex = 0;
            this.imagePawprint.TabStop = false;
            this.imagePawprint.Click += new System.EventHandler(this.imagePawprint_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(100, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(191, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Iniciar Sesión";
            // 
            // buttonSignup
            // 
            this.buttonSignup.Location = new System.Drawing.Point(262, 426);
            this.buttonSignup.Name = "buttonSignup";
            this.buttonSignup.Size = new System.Drawing.Size(110, 23);
            this.buttonSignup.TabIndex = 2;
            this.buttonSignup.Text = "Registrar usuario";
            this.buttonSignup.UseVisualStyleBackColor = true;
            this.buttonSignup.Click += new System.EventHandler(this.buttonSignup_Click);
            // 
            // WindowLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.buttonSignup);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.imagePawprint);
            this.Name = "WindowLogin";
            this.Text = "Search";
            this.Activated += new System.EventHandler(this.WindowLogin_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WindowLogin_FormClosing);
            this.Load += new System.EventHandler(this.WindowLogin_Load);
            this.Leave += new System.EventHandler(this.WindowLogin_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.imagePawprint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imagePawprint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSignup;
    }
}