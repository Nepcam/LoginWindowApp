namespace LoginWindowApp
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(135, 86);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(213, 22);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(135, 130);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(213, 22);
            this.textBox2.TabIndex = 1;
            this.textBox2.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "USER NAME:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 136);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(103, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "PASSWORD :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(155, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "LOGIN";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonExit
            // 
            this.buttonExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonExit.Location = new System.Drawing.Point(135, 170);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(101, 23);
            this.buttonExit.TabIndex = 5;
            this.buttonExit.Text = "E&XIT";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonLogin
            // 
            this.buttonLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonLogin.Location = new System.Drawing.Point(242, 170);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(106, 23);
            this.buttonLogin.TabIndex = 6;
            this.buttonLogin.Text = "LOGIN";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 234);
            this.Controls.Add(this.buttonLogin);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LOGIN APPLICATION";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonLogin;
    }
}

