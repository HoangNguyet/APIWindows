namespace src.thread.user_controls
{
    partial class client
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.richTextBox1 = new Guna.UI2.WinForms.Guna2TextBox();
            this.send = new Guna.UI2.WinForms.Guna2Button();
            this.txtMessage = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.BorderRadius = 45;
            this.richTextBox1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.richTextBox1.DefaultText = "";
            this.richTextBox1.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.richTextBox1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.richTextBox1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.richTextBox1.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.richTextBox1.FillColor = System.Drawing.Color.LightGray;
            this.richTextBox1.FocusedState.BorderColor = System.Drawing.Color.White;
            this.richTextBox1.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox1.ForeColor = System.Drawing.Color.Black;
            this.richTextBox1.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.richTextBox1.Location = new System.Drawing.Point(45, 210);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.richTextBox1.Multiline = true;
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.PasswordChar = '\0';
            this.richTextBox1.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.richTextBox1.PlaceholderText = "";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.SelectedText = "";
            this.richTextBox1.Size = new System.Drawing.Size(849, 463);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.TextOffset = new System.Drawing.Point(15, 15);
            // 
            // send
            // 
            this.send.BorderRadius = 10;
            this.send.Cursor = System.Windows.Forms.Cursors.Hand;
            this.send.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.send.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.send.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.send.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.send.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(135)))), ((int)(((byte)(84)))));
            this.send.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Bold);
            this.send.ForeColor = System.Drawing.Color.White;
            this.send.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(130)))), ((int)(((byte)(84)))));
            this.send.Location = new System.Drawing.Point(707, 107);
            this.send.Name = "send";
            this.send.Size = new System.Drawing.Size(187, 58);
            this.send.TabIndex = 8;
            this.send.Text = "Gửi";
            this.send.Click += new System.EventHandler(this.send_Click);
            // 
            // txtMessage
            // 
            this.txtMessage.Animated = true;
            this.txtMessage.BorderRadius = 10;
            this.txtMessage.BorderThickness = 0;
            this.txtMessage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMessage.DefaultText = "";
            this.txtMessage.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMessage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMessage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMessage.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMessage.FillColor = System.Drawing.Color.Gainsboro;
            this.txtMessage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMessage.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Italic);
            this.txtMessage.ForeColor = System.Drawing.Color.Black;
            this.txtMessage.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMessage.Location = new System.Drawing.Point(46, 107);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.PasswordChar = '\0';
            this.txtMessage.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.txtMessage.PlaceholderText = "Client Message";
            this.txtMessage.SelectedText = "";
            this.txtMessage.Size = new System.Drawing.Size(637, 58);
            this.txtMessage.TabIndex = 7;
            this.txtMessage.TextOffset = new System.Drawing.Point(10, 0);
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(408, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 37);
            this.label1.TabIndex = 6;
            this.label1.Text = "Client";
            // 
            // client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.send);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.label1);
            this.Name = "client";
            this.Size = new System.Drawing.Size(946, 688);
            this.Load += new System.EventHandler(this.client_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2TextBox richTextBox1;
        private Guna.UI2.WinForms.Guna2Button send;
        private Guna.UI2.WinForms.Guna2TextBox txtMessage;
        private System.Windows.Forms.Label label1;
    }
}
