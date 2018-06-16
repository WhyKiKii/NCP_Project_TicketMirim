namespace NCP_Projectc_Ticket_Mirim
{
    partial class Payco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Payco));
            this.K_paycoSignup = new System.Windows.Forms.Button();
            this.K_paycoLogin = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // K_paycoSignup
            // 
            this.K_paycoSignup.BackColor = System.Drawing.Color.DimGray;
            this.K_paycoSignup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.K_paycoSignup.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.K_paycoSignup.ForeColor = System.Drawing.SystemColors.Control;
            this.K_paycoSignup.Location = new System.Drawing.Point(46, 274);
            this.K_paycoSignup.Name = "K_paycoSignup";
            this.K_paycoSignup.Size = new System.Drawing.Size(243, 47);
            this.K_paycoSignup.TabIndex = 17;
            this.K_paycoSignup.Text = "회원가입";
            this.K_paycoSignup.UseVisualStyleBackColor = false;
            // 
            // K_paycoLogin
            // 
            this.K_paycoLogin.BackColor = System.Drawing.Color.Red;
            this.K_paycoLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.K_paycoLogin.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.K_paycoLogin.ForeColor = System.Drawing.SystemColors.Control;
            this.K_paycoLogin.Location = new System.Drawing.Point(46, 222);
            this.K_paycoLogin.Name = "K_paycoLogin";
            this.K_paycoLogin.Size = new System.Drawing.Size(243, 47);
            this.K_paycoLogin.TabIndex = 16;
            this.K_paycoLogin.Text = "로그인";
            this.K_paycoLogin.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox2.Location = new System.Drawing.Point(46, 178);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(244, 25);
            this.textBox2.TabIndex = 15;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("나눔고딕", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.textBox1.Location = new System.Drawing.Point(46, 136);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(244, 25);
            this.textBox1.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(70, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "하나의 아이디로 쇼핑부터 혜택까지!\r\n";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(96, 49);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(152, 39);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Payco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 411);
            this.Controls.Add(this.K_paycoSignup);
            this.Controls.Add(this.K_paycoLogin);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Payco";
            this.Text = "Payco";
            this.Load += new System.EventHandler(this.Payco_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button K_paycoSignup;
        private System.Windows.Forms.Button K_paycoLogin;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}