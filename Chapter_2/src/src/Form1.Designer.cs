namespace src
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnAlgorithm = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 22.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 44);
            this.label1.TabIndex = 0;
            this.label1.Text = "Điều độ và Luồng";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(84, 187);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(311, 63);
            this.button1.TabIndex = 1;
            this.button1.Text = "Điều độ";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(84, 276);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(311, 63);
            this.button2.TabIndex = 2;
            this.button2.Text = "Luồng";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnAlgorithm
            // 
            this.btnAlgorithm.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlgorithm.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnAlgorithm.Location = new System.Drawing.Point(84, 373);
            this.btnAlgorithm.Name = "btnAlgorithm";
            this.btnAlgorithm.Size = new System.Drawing.Size(311, 63);
            this.btnAlgorithm.TabIndex = 3;
            this.btnAlgorithm.Text = "Các thuật toán điều độ";
            this.btnAlgorithm.UseVisualStyleBackColor = true;
            this.btnAlgorithm.Click += new System.EventHandler(this.btnAlgorithm_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(142, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 34);
            this.label2.TabIndex = 4;
            this.label2.Text = "Menu hôm nay";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(500, 512);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnAlgorithm);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnAlgorithm;
        private System.Windows.Forms.Label label2;
    }
}

