namespace APIWin.ControlUser
{
    partial class Control
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
            this.btnProperties = new System.Windows.Forms.Button();
            this.deleteFileX = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnProperties
            // 
            this.btnProperties.Location = new System.Drawing.Point(12, 142);
            this.btnProperties.Name = "btnProperties";
            this.btnProperties.Size = new System.Drawing.Size(142, 23);
            this.btnProperties.TabIndex = 1;
            this.btnProperties.Text = "Properties";
            this.btnProperties.UseVisualStyleBackColor = true;
            this.btnProperties.Click += new System.EventHandler(this.btnProperties_Click);
            // 
            // deleteFileX
            // 
            this.deleteFileX.Location = new System.Drawing.Point(13, 113);
            this.deleteFileX.Name = "deleteFileX";
            this.deleteFileX.Size = new System.Drawing.Size(141, 23);
            this.deleteFileX.TabIndex = 2;
            this.deleteFileX.Text = "DeleteFile";
            this.deleteFileX.UseVisualStyleBackColor = true;
            this.deleteFileX.Click += new System.EventHandler(this.deleteFileX_Click);
            // 
            // Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(166, 177);
            this.Controls.Add(this.deleteFileX);
            this.Controls.Add(this.btnProperties);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.ImeMode = System.Windows.Forms.ImeMode.On;
            this.Name = "Control";
            this.Text = "Properti";
            this.Load += new System.EventHandler(this.Properti_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnProperties;
        private System.Windows.Forms.Button deleteFileX;
    }
}