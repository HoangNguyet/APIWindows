namespace APIWin.ControlUser
{
    partial class ControlFolder
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
            this.PasteX = new System.Windows.Forms.Button();
            this.CreateFileX = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PasteX
            // 
            this.PasteX.Enabled = false;
            this.PasteX.Location = new System.Drawing.Point(29, 63);
            this.PasteX.Name = "PasteX";
            this.PasteX.Size = new System.Drawing.Size(98, 25);
            this.PasteX.TabIndex = 0;
            this.PasteX.Text = "Paste";
            this.PasteX.UseVisualStyleBackColor = true;
            this.PasteX.Click += new System.EventHandler(this.PasteX_Click);
            // 
            // CreateFileX
            // 
            this.CreateFileX.Location = new System.Drawing.Point(29, 104);
            this.CreateFileX.Name = "CreateFileX";
            this.CreateFileX.Size = new System.Drawing.Size(98, 26);
            this.CreateFileX.TabIndex = 1;
            this.CreateFileX.Text = "CreateFile";
            this.CreateFileX.UseVisualStyleBackColor = true;
            this.CreateFileX.Click += new System.EventHandler(this.CreateFileX_Click);
            // 
            // ControlFolder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(153, 280);
            this.Controls.Add(this.CreateFileX);
            this.Controls.Add(this.PasteX);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "ControlFolder";
            this.Text = "ControlFolder";
            this.Load += new System.EventHandler(this.ControlFolder_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button PasteX;
        private System.Windows.Forms.Button CreateFileX;
    }
}