namespace HostelApp
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
            this.lblWelcome = new System.Windows.Forms.Label();
            this.pcImage = new System.Windows.Forms.PictureBox();
            this.btRegister = new System.Windows.Forms.Button();
            this.btLogin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pcImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblWelcome
            // 
            this.lblWelcome.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWelcome.ForeColor = System.Drawing.Color.Tomato;
            this.lblWelcome.Location = new System.Drawing.Point(243, 36);
            this.lblWelcome.Name = "lblWelcome";
            this.lblWelcome.Size = new System.Drawing.Size(92, 31);
            this.lblWelcome.TabIndex = 0;
            this.lblWelcome.Text = "label1";
            // 
            // pcImage
            // 
            this.pcImage.Location = new System.Drawing.Point(202, 100);
            this.pcImage.Name = "pcImage";
            this.pcImage.Size = new System.Drawing.Size(416, 202);
            this.pcImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcImage.TabIndex = 2;
            this.pcImage.TabStop = false;
            // 
            // btRegister
            // 
            this.btRegister.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btRegister.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.btRegister.FlatAppearance.BorderColor = System.Drawing.Color.MediumSpringGreen;
            this.btRegister.FlatAppearance.BorderSize = 0;
            this.btRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MediumSpringGreen;
            this.btRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSpringGreen;
            this.btRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btRegister.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btRegister.Location = new System.Drawing.Point(72, 284);
            this.btRegister.Name = "btRegister";
            this.btRegister.Size = new System.Drawing.Size(95, 47);
            this.btRegister.TabIndex = 3;
            this.btRegister.Text = "Register";
            this.btRegister.UseVisualStyleBackColor = false;
            this.btRegister.Click += new System.EventHandler(this.BtRegister_Click);
            // 
            // btLogin
            // 
            this.btLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btLogin.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btLogin.FlatAppearance.BorderColor = System.Drawing.Color.MediumSpringGreen;
            this.btLogin.FlatAppearance.BorderSize = 0;
            this.btLogin.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkTurquoise;
            this.btLogin.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkTurquoise;
            this.btLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btLogin.Location = new System.Drawing.Point(650, 284);
            this.btLogin.Name = "btLogin";
            this.btLogin.Size = new System.Drawing.Size(95, 47);
            this.btLogin.TabIndex = 4;
            this.btLogin.Text = "Login";
            this.btLogin.UseVisualStyleBackColor = false;
            this.btLogin.Click += new System.EventHandler(this.BtLogin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btLogin);
            this.Controls.Add(this.btRegister);
            this.Controls.Add(this.pcImage);
            this.Controls.Add(this.lblWelcome);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.PictureBox pcImage;
        private System.Windows.Forms.Button btRegister;
        private System.Windows.Forms.Button btLogin;
    }
}

