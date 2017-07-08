namespace BombDefuser
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
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.lblPass = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblMorse = new System.Windows.Forms.Label();
            this.lblMHz = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 25);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Tag = "1";
            this.textBox1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(12, 51);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            this.textBox2.Tag = "2";
            this.textBox2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(12, 77);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 2;
            this.textBox3.Tag = "3";
            this.textBox3.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(12, 103);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 3;
            this.textBox4.Tag = "4";
            this.textBox4.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(12, 129);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 4;
            this.textBox5.Tag = "5";
            this.textBox5.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyDown);
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.Location = new System.Drawing.Point(12, 152);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(45, 13);
            this.lblPass.TabIndex = 5;
            this.lblPass.Text = "Answer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(118, 25);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 20);
            this.textBox6.TabIndex = 7;
            this.textBox6.TextChanged += new System.EventHandler(this.textBox6_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(115, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Morse (0- )";
            // 
            // lblMorse
            // 
            this.lblMorse.AutoSize = true;
            this.lblMorse.Location = new System.Drawing.Point(115, 48);
            this.lblMorse.Name = "lblMorse";
            this.lblMorse.Size = new System.Drawing.Size(45, 13);
            this.lblMorse.TabIndex = 9;
            this.lblMorse.Text = "Answer:";
            // 
            // lblMHz
            // 
            this.lblMHz.AutoSize = true;
            this.lblMHz.Location = new System.Drawing.Point(115, 61);
            this.lblMHz.Name = "lblMHz";
            this.lblMHz.Size = new System.Drawing.Size(32, 13);
            this.lblMHz.TabIndex = 10;
            this.lblMHz.Text = "MHz:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 381);
            this.Controls.Add(this.lblMHz);
            this.Controls.Add(this.lblMorse);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Bomb_Defuser.exe";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblMorse;
        private System.Windows.Forms.Label lblMHz;
    }
}

