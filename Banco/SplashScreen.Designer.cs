namespace Banco
{
    partial class SplashScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SplashScreen));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.iden_log = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.senha_log = new System.Windows.Forms.TextBox();
            this.Log_Enviar = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label4 = new System.Windows.Forms.Label();
            this.Log_Sair = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(277, 248);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.UseWaitCursor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(327, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Digite seu identificador:";
            this.label1.UseWaitCursor = true;
            // 
            // iden_log
            // 
            this.iden_log.Location = new System.Drawing.Point(330, 96);
            this.iden_log.Name = "iden_log";
            this.iden_log.Size = new System.Drawing.Size(307, 20);
            this.iden_log.TabIndex = 2;
            this.iden_log.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(327, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Digite sua senha:";
            this.label2.UseWaitCursor = true;
            // 
            // senha_log
            // 
            this.senha_log.BackColor = System.Drawing.SystemColors.Window;
            this.senha_log.Location = new System.Drawing.Point(330, 135);
            this.senha_log.Name = "senha_log";
            this.senha_log.Size = new System.Drawing.Size(195, 20);
            this.senha_log.TabIndex = 4;
            this.senha_log.UseWaitCursor = true;
            this.senha_log.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // Log_Enviar
            // 
            this.Log_Enviar.BackColor = System.Drawing.Color.LimeGreen;
            this.Log_Enviar.Location = new System.Drawing.Point(348, 171);
            this.Log_Enviar.Name = "Log_Enviar";
            this.Log_Enviar.Size = new System.Drawing.Size(96, 23);
            this.Log_Enviar.TabIndex = 5;
            this.Log_Enviar.Text = "Entrar";
            this.Log_Enviar.UseVisualStyleBackColor = false;
            this.Log_Enviar.UseWaitCursor = true;
            this.Log_Enviar.Click += new System.EventHandler(this.Log_Enviar_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(330, 217);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(66, 13);
            this.linkLabel1.TabIndex = 6;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Cadastrar-se";
            this.linkLabel1.UseWaitCursor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Enabled = false;
            this.progressBar1.Location = new System.Drawing.Point(330, 248);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(307, 23);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 7;
            this.progressBar1.UseWaitCursor = true;
            this.progressBar1.Visible = false;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(526, 217);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(111, 13);
            this.linkLabel2.TabIndex = 8;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Esqueci minha senha:";
            this.linkLabel2.UseWaitCursor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Maiandra GD", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label4.Location = new System.Drawing.Point(326, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 39);
            this.label4.TabIndex = 10;
            this.label4.Text = "Royal Bank";
            this.label4.UseWaitCursor = true;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // Log_Sair
            // 
            this.Log_Sair.BackColor = System.Drawing.Color.Red;
            this.Log_Sair.Location = new System.Drawing.Point(469, 171);
            this.Log_Sair.Name = "Log_Sair";
            this.Log_Sair.Size = new System.Drawing.Size(96, 23);
            this.Log_Sair.TabIndex = 11;
            this.Log_Sair.Text = "Sair";
            this.Log_Sair.UseVisualStyleBackColor = false;
            this.Log_Sair.UseWaitCursor = true;
            this.Log_Sair.Click += new System.EventHandler(this.Log_Sair_Click);
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(664, 286);
            this.ControlBox = false;
            this.Controls.Add(this.Log_Sair);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.linkLabel2);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.Log_Enviar);
            this.Controls.Add(this.senha_log);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.iden_log);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "SplashScreen";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            this.UseWaitCursor = true;
            this.Load += new System.EventHandler(this.SplashScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox iden_log;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox senha_log;
        private System.Windows.Forms.Button Log_Enviar;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Log_Sair;
    }
}