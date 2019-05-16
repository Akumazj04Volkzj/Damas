namespace LabDamasS01
{
    partial class View_Registo
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
            this.ButCanc = new System.Windows.Forms.Button();
            this.ButRegistar = new System.Windows.Forms.Button();
            this.ButAdd = new System.Windows.Forms.Button();
            this.cmbox_pais = new System.Windows.Forms.ComboBox();
            this.txb_pw = new System.Windows.Forms.TextBox();
            this.txb_nome = new System.Windows.Forms.TextBox();
            this.txb_email = new System.Windows.Forms.TextBox();
            this.LABpass = new System.Windows.Forms.Label();
            this.LAbnome = new System.Windows.Forms.Label();
            this.LABmail = new System.Windows.Forms.Label();
            this.LABcountry = new System.Windows.Forms.Label();
            this.txb_User = new System.Windows.Forms.TextBox();
            this.LABuser = new System.Windows.Forms.Label();
            this.PicBoxFoto = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxFoto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // ButCanc
            // 
            this.ButCanc.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButCanc.Location = new System.Drawing.Point(661, 503);
            this.ButCanc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButCanc.Name = "ButCanc";
            this.ButCanc.Size = new System.Drawing.Size(188, 50);
            this.ButCanc.TabIndex = 28;
            this.ButCanc.Text = "Cancelar";
            this.ButCanc.UseVisualStyleBackColor = true;
            this.ButCanc.Click += new System.EventHandler(this.ButCanc_Click);
            // 
            // ButRegistar
            // 
            this.ButRegistar.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.ButRegistar.Location = new System.Drawing.Point(241, 503);
            this.ButRegistar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButRegistar.Name = "ButRegistar";
            this.ButRegistar.Size = new System.Drawing.Size(188, 50);
            this.ButRegistar.TabIndex = 27;
            this.ButRegistar.Text = "Registar";
            this.ButRegistar.UseVisualStyleBackColor = true;
            this.ButRegistar.Click += new System.EventHandler(this.ButRegistar_Click);
            // 
            // ButAdd
            // 
            this.ButAdd.Location = new System.Drawing.Point(61, 335);
            this.ButAdd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ButAdd.Name = "ButAdd";
            this.ButAdd.Size = new System.Drawing.Size(208, 39);
            this.ButAdd.TabIndex = 26;
            this.ButAdd.Text = "Inserir Foto";
            this.ButAdd.UseVisualStyleBackColor = true;
            // 
            // cmbox_pais
            // 
            this.cmbox_pais.FormattingEnabled = true;
            this.cmbox_pais.Location = new System.Drawing.Point(359, 351);
            this.cmbox_pais.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbox_pais.Name = "cmbox_pais";
            this.cmbox_pais.Size = new System.Drawing.Size(165, 24);
            this.cmbox_pais.TabIndex = 25;
            // 
            // txb_pw
            // 
            this.txb_pw.Location = new System.Drawing.Point(359, 126);
            this.txb_pw.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_pw.Name = "txb_pw";
            this.txb_pw.Size = new System.Drawing.Size(167, 22);
            this.txb_pw.TabIndex = 24;
            // 
            // txb_nome
            // 
            this.txb_nome.Location = new System.Drawing.Point(359, 194);
            this.txb_nome.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_nome.Name = "txb_nome";
            this.txb_nome.Size = new System.Drawing.Size(167, 22);
            this.txb_nome.TabIndex = 23;
            // 
            // txb_email
            // 
            this.txb_email.Location = new System.Drawing.Point(359, 270);
            this.txb_email.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_email.Name = "txb_email";
            this.txb_email.Size = new System.Drawing.Size(167, 22);
            this.txb_email.TabIndex = 22;
            // 
            // LABpass
            // 
            this.LABpass.AutoSize = true;
            this.LABpass.Location = new System.Drawing.Point(356, 96);
            this.LABpass.Name = "LABpass";
            this.LABpass.Size = new System.Drawing.Size(73, 17);
            this.LABpass.TabIndex = 21;
            this.LABpass.Text = "Password:";
            // 
            // LAbnome
            // 
            this.LAbnome.AutoSize = true;
            this.LAbnome.Location = new System.Drawing.Point(356, 162);
            this.LAbnome.Name = "LAbnome";
            this.LAbnome.Size = new System.Drawing.Size(49, 17);
            this.LAbnome.TabIndex = 20;
            this.LAbnome.Text = "Nome:";
            // 
            // LABmail
            // 
            this.LABmail.AutoSize = true;
            this.LABmail.Location = new System.Drawing.Point(356, 233);
            this.LABmail.Name = "LABmail";
            this.LABmail.Size = new System.Drawing.Size(46, 17);
            this.LABmail.TabIndex = 19;
            this.LABmail.Text = "Email:";
            // 
            // LABcountry
            // 
            this.LABcountry.AutoSize = true;
            this.LABcountry.Location = new System.Drawing.Point(356, 313);
            this.LABcountry.Name = "LABcountry";
            this.LABcountry.Size = new System.Drawing.Size(39, 17);
            this.LABcountry.TabIndex = 18;
            this.LABcountry.Text = "País:";
            // 
            // txb_User
            // 
            this.txb_User.Location = new System.Drawing.Point(359, 58);
            this.txb_User.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txb_User.Name = "txb_User";
            this.txb_User.Size = new System.Drawing.Size(167, 22);
            this.txb_User.TabIndex = 17;
            // 
            // LABuser
            // 
            this.LABuser.AutoSize = true;
            this.LABuser.BackColor = System.Drawing.Color.Transparent;
            this.LABuser.Location = new System.Drawing.Point(356, 26);
            this.LABuser.Name = "LABuser";
            this.LABuser.Size = new System.Drawing.Size(77, 17);
            this.LABuser.TabIndex = 16;
            this.LABuser.Text = "Username:";
            // 
            // PicBoxFoto
            // 
            this.PicBoxFoto.Location = new System.Drawing.Point(60, 26);
            this.PicBoxFoto.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.PicBoxFoto.Name = "PicBoxFoto";
            this.PicBoxFoto.Size = new System.Drawing.Size(209, 266);
            this.PicBoxFoto.TabIndex = 15;
            this.PicBoxFoto.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::LabDamasS01.Properties.Resources.wood11;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1052, 603);
            this.pictureBox1.TabIndex = 29;
            this.pictureBox1.TabStop = false;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(542, 126);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(142, 21);
            this.checkBox1.TabIndex = 30;
            this.checkBox1.Text = "Mostrar/Esconder";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // View_Registo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 603);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.ButCanc);
            this.Controls.Add(this.ButRegistar);
            this.Controls.Add(this.ButAdd);
            this.Controls.Add(this.cmbox_pais);
            this.Controls.Add(this.txb_pw);
            this.Controls.Add(this.txb_nome);
            this.Controls.Add(this.txb_email);
            this.Controls.Add(this.LABpass);
            this.Controls.Add(this.LAbnome);
            this.Controls.Add(this.LABmail);
            this.Controls.Add(this.LABcountry);
            this.Controls.Add(this.txb_User);
            this.Controls.Add(this.LABuser);
            this.Controls.Add(this.PicBoxFoto);
            this.Controls.Add(this.pictureBox1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "View_Registo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Criar Conta";
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxFoto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButCanc;
        private System.Windows.Forms.Button ButRegistar;
        private System.Windows.Forms.Button ButAdd;
        private System.Windows.Forms.ComboBox cmbox_pais;
        private System.Windows.Forms.TextBox txb_pw;
        private System.Windows.Forms.TextBox txb_nome;
        private System.Windows.Forms.TextBox txb_email;
        private System.Windows.Forms.Label LABpass;
        private System.Windows.Forms.Label LAbnome;
        private System.Windows.Forms.Label LABmail;
        private System.Windows.Forms.Label LABcountry;
        private System.Windows.Forms.TextBox txb_User;
        private System.Windows.Forms.Label LABuser;
        private System.Windows.Forms.PictureBox PicBoxFoto;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}