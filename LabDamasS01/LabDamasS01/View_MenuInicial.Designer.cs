namespace LabDamasS01
{
    partial class View_MenuInicial
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
            this.ButPlay = new System.Windows.Forms.Button();
            this.PicBoxFundo = new System.Windows.Forms.PictureBox();
            this.ButStat = new System.Windows.Forms.Button();
            this.ButRules = new System.Windows.Forms.Button();
            this.ButSair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxFundo)).BeginInit();
            this.SuspendLayout();
            // 
            // ButPlay
            // 
            this.ButPlay.Location = new System.Drawing.Point(360, 80);
            this.ButPlay.Margin = new System.Windows.Forms.Padding(4);
            this.ButPlay.Name = "ButPlay";
            this.ButPlay.Size = new System.Drawing.Size(351, 59);
            this.ButPlay.TabIndex = 0;
            this.ButPlay.Text = "JOGAR";
            this.ButPlay.UseVisualStyleBackColor = true;
            this.ButPlay.Click += new System.EventHandler(this.ButPlay_Click);
            // 
            // PicBoxFundo
            // 
            this.PicBoxFundo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PicBoxFundo.Image = global::LabDamasS01.Properties.Resources.wood11;
            this.PicBoxFundo.Location = new System.Drawing.Point(0, 0);
            this.PicBoxFundo.Margin = new System.Windows.Forms.Padding(4);
            this.PicBoxFundo.Name = "PicBoxFundo";
            this.PicBoxFundo.Size = new System.Drawing.Size(1052, 603);
            this.PicBoxFundo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicBoxFundo.TabIndex = 1;
            this.PicBoxFundo.TabStop = false;
            // 
            // ButStat
            // 
            this.ButStat.Location = new System.Drawing.Point(360, 182);
            this.ButStat.Margin = new System.Windows.Forms.Padding(4);
            this.ButStat.Name = "ButStat";
            this.ButStat.Size = new System.Drawing.Size(351, 59);
            this.ButStat.TabIndex = 2;
            this.ButStat.Text = "PERFIL";
            this.ButStat.UseVisualStyleBackColor = true;
            this.ButStat.Click += new System.EventHandler(this.ButStat_Click);
            // 
            // ButRules
            // 
            this.ButRules.Location = new System.Drawing.Point(360, 288);
            this.ButRules.Margin = new System.Windows.Forms.Padding(4);
            this.ButRules.Name = "ButRules";
            this.ButRules.Size = new System.Drawing.Size(351, 59);
            this.ButRules.TabIndex = 3;
            this.ButRules.Text = "REGRAS";
            this.ButRules.UseVisualStyleBackColor = true;
            this.ButRules.Click += new System.EventHandler(this.ButRules_Click);
            // 
            // ButSair
            // 
            this.ButSair.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ButSair.Location = new System.Drawing.Point(360, 390);
            this.ButSair.Margin = new System.Windows.Forms.Padding(4);
            this.ButSair.Name = "ButSair";
            this.ButSair.Size = new System.Drawing.Size(351, 59);
            this.ButSair.TabIndex = 4;
            this.ButSair.Text = "LOGOUT";
            this.ButSair.UseVisualStyleBackColor = true;
            // 
            // View_MenuInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1052, 603);
            this.Controls.Add(this.ButSair);
            this.Controls.Add(this.ButRules);
            this.Controls.Add(this.ButStat);
            this.Controls.Add(this.ButPlay);
            this.Controls.Add(this.PicBoxFundo);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "View_MenuInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DAMAS";
            this.Load += new System.EventHandler(this.View_MenuInicial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxFundo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButPlay;
        private System.Windows.Forms.PictureBox PicBoxFundo;
        private System.Windows.Forms.Button ButStat;
        private System.Windows.Forms.Button ButRules;
        private System.Windows.Forms.Button ButSair;
    }
}