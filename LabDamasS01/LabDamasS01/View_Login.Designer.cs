namespace LabDamasS01
{
    partial class View_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(View_Login));
            this.buttonRegisto = new System.Windows.Forms.Button();
            this.buttonEntrar = new System.Windows.Forms.Button();
            this.lb_Titulo = new System.Windows.Forms.Label();
            this.txb_Password = new System.Windows.Forms.TextBox();
            this.txb_Username = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_Username = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonSairApli = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonRegisto
            // 
            this.buttonRegisto.AutoSize = true;
            this.buttonRegisto.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonRegisto.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonRegisto.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRegisto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonRegisto.Location = new System.Drawing.Point(587, 331);
            this.buttonRegisto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonRegisto.Name = "buttonRegisto";
            this.buttonRegisto.Size = new System.Drawing.Size(95, 33);
            this.buttonRegisto.TabIndex = 13;
            this.buttonRegisto.Text = "Registar";
            this.buttonRegisto.UseVisualStyleBackColor = false;
            this.buttonRegisto.Click += new System.EventHandler(this.buttonRegisto_Click);
            // 
            // buttonEntrar
            // 
            this.buttonEntrar.AutoSize = true;
            this.buttonEntrar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonEntrar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonEntrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEntrar.Location = new System.Drawing.Point(379, 331);
            this.buttonEntrar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonEntrar.Name = "buttonEntrar";
            this.buttonEntrar.Size = new System.Drawing.Size(76, 33);
            this.buttonEntrar.TabIndex = 12;
            this.buttonEntrar.Text = "Entrar";
            this.buttonEntrar.UseVisualStyleBackColor = false;
            this.buttonEntrar.Click += new System.EventHandler(this.buttonEntrar_Click);
            // 
            // lb_Titulo
            // 
            this.lb_Titulo.AutoSize = true;
            this.lb_Titulo.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lb_Titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Titulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_Titulo.Location = new System.Drawing.Point(479, 175);
            this.lb_Titulo.Name = "lb_Titulo";
            this.lb_Titulo.Size = new System.Drawing.Size(99, 31);
            this.lb_Titulo.TabIndex = 13;
            this.lb_Titulo.Text = "LOGIN";
            // 
            // txb_Password
            // 
            this.txb_Password.Location = new System.Drawing.Point(473, 281);
            this.txb_Password.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_Password.Name = "txb_Password";
            this.txb_Password.Size = new System.Drawing.Size(207, 22);
            this.txb_Password.TabIndex = 10;
            this.txb_Password.UseSystemPasswordChar = true;
            // 
            // txb_Username
            // 
            this.txb_Username.Location = new System.Drawing.Point(473, 246);
            this.txb_Username.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_Username.Name = "txb_Username";
            this.txb_Username.Size = new System.Drawing.Size(207, 22);
            this.txb_Username.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(379, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Password:";
            // 
            // lb_Username
            // 
            this.lb_Username.AutoSize = true;
            this.lb_Username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_Username.Location = new System.Drawing.Point(375, 246);
            this.lb_Username.Name = "lb_Username";
            this.lb_Username.Size = new System.Drawing.Size(91, 20);
            this.lb_Username.TabIndex = 7;
            this.lb_Username.Text = "Username:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1052, 603);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // buttonSairApli
            // 
            this.buttonSairApli.AutoSize = true;
            this.buttonSairApli.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.buttonSairApli.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.buttonSairApli.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSairApli.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonSairApli.Location = new System.Drawing.Point(485, 331);
            this.buttonSairApli.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.buttonSairApli.Name = "buttonSairApli";
            this.buttonSairApli.Size = new System.Drawing.Size(76, 33);
            this.buttonSairApli.TabIndex = 15;
            this.buttonSairApli.Text = "Sair";
            this.buttonSairApli.UseVisualStyleBackColor = false;
            this.buttonSairApli.Click += new System.EventHandler(this.buttonSairApli_Click);
            // 
            // View_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 603);
            this.Controls.Add(this.buttonSairApli);
            this.Controls.Add(this.buttonRegisto);
            this.Controls.Add(this.buttonEntrar);
            this.Controls.Add(this.lb_Titulo);
            this.Controls.Add(this.txb_Password);
            this.Controls.Add(this.txb_Username);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_Username);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "View_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRegisto;
        private System.Windows.Forms.Button buttonEntrar;
        private System.Windows.Forms.Label lb_Titulo;
        private System.Windows.Forms.TextBox txb_Password;
        private System.Windows.Forms.TextBox txb_Username;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_Username;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button buttonSairApli;
    }
}

