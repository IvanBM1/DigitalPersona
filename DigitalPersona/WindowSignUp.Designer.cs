namespace DigitalPersona
{
    partial class WindowSignUp
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.imagePawprint = new System.Windows.Forms.PictureBox();
            this.labelCount = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.labelName = new System.Windows.Forms.Label();
            this.inputName = new System.Windows.Forms.TextBox();
            this.labelMessage = new System.Windows.Forms.Label();
            this.buttonReset = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
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
            // 
            // labelCount
            // 
            this.labelCount.AutoSize = true;
            this.labelCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCount.Location = new System.Drawing.Point(89, 86);
            this.labelCount.Name = "labelCount";
            this.labelCount.Size = new System.Drawing.Size(206, 16);
            this.labelCount.TabIndex = 1;
            this.labelCount.Text = "Necesitas pasar el dedo 4 veces";
            // 
            // buttonSave
            // 
            this.buttonSave.Enabled = false;
            this.buttonSave.Location = new System.Drawing.Point(111, 321);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(163, 23);
            this.buttonSave.TabIndex = 2;
            this.buttonSave.Text = "Guardar";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(111, 279);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(44, 13);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Nombre";
            // 
            // inputName
            // 
            this.inputName.Location = new System.Drawing.Point(111, 295);
            this.inputName.Name = "inputName";
            this.inputName.Size = new System.Drawing.Size(163, 20);
            this.inputName.TabIndex = 1;
            // 
            // labelMessage
            // 
            this.labelMessage.AutoSize = true;
            this.labelMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMessage.Location = new System.Drawing.Point(60, 30);
            this.labelMessage.Name = "labelMessage";
            this.labelMessage.Size = new System.Drawing.Size(273, 33);
            this.labelMessage.TabIndex = 5;
            this.labelMessage.Text = "Registro de Usuario";
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(285, 426);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(87, 23);
            this.buttonReset.TabIndex = 3;
            this.buttonReset.Text = "Agregar Otro";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.buttonReset_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(12, 426);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(88, 23);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Iniciar Sesion";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // WindowSignUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.buttonReset);
            this.Controls.Add(this.labelMessage);
            this.Controls.Add(this.inputName);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.labelCount);
            this.Controls.Add(this.imagePawprint);
            this.Name = "WindowSignUp";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.WindowSignUp_Activated);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.WindowSignUp_FormClosing);
            this.Load += new System.EventHandler(this.WindowSignUp_Load);
            this.Leave += new System.EventHandler(this.WindowSignUp_Leave);
            ((System.ComponentModel.ISupportInitialize)(this.imagePawprint)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imagePawprint;
        private System.Windows.Forms.Label labelCount;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox inputName;
        private System.Windows.Forms.Label labelMessage;
        private System.Windows.Forms.Button buttonReset;
        private System.Windows.Forms.Button buttonLogin;
    }
}

