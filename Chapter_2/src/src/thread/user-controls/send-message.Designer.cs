namespace src.thread.user_controls
{
    partial class send_message
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(send_message));
            this.guna2GradientPanel1 = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.ten = new System.Windows.Forms.Label();
            this.avatar = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.txtMessage = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.flowMessage = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2GradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2GradientPanel1
            // 
            this.guna2GradientPanel1.BorderRadius = 20;
            this.guna2GradientPanel1.Controls.Add(this.ten);
            this.guna2GradientPanel1.Controls.Add(this.avatar);
            this.guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(144)))), ((int)(((byte)(226)))));
            this.guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(144)))), ((int)(((byte)(226)))));
            this.guna2GradientPanel1.Location = new System.Drawing.Point(9, 7);
            this.guna2GradientPanel1.Name = "guna2GradientPanel1";
            this.guna2GradientPanel1.Size = new System.Drawing.Size(488, 147);
            this.guna2GradientPanel1.TabIndex = 0;
            // 
            // ten
            // 
            this.ten.AutoSize = true;
            this.ten.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(144)))), ((int)(((byte)(226)))));
            this.ten.Font = new System.Drawing.Font("Roboto", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ten.ForeColor = System.Drawing.Color.White;
            this.ten.Location = new System.Drawing.Point(163, 41);
            this.ten.Name = "ten";
            this.ten.Size = new System.Drawing.Size(123, 39);
            this.ten.TabIndex = 1;
            this.ten.Text = "Client1";
            // 
            // avatar
            // 
            this.avatar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(144)))), ((int)(((byte)(226)))));
            this.avatar.Image = ((System.Drawing.Image)(resources.GetObject("avatar.Image")));
            this.avatar.ImageRotate = 0F;
            this.avatar.Location = new System.Drawing.Point(10, 10);
            this.avatar.Name = "avatar";
            this.avatar.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.avatar.Size = new System.Drawing.Size(136, 130);
            this.avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.avatar.TabIndex = 0;
            this.avatar.TabStop = false;
            // 
            // txtMessage
            // 
            this.txtMessage.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(73)))), ((int)(((byte)(144)))), ((int)(((byte)(226)))));
            this.txtMessage.BorderRadius = 15;
            this.txtMessage.BorderThickness = 4;
            this.txtMessage.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMessage.DefaultText = "";
            this.txtMessage.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtMessage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtMessage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMessage.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtMessage.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMessage.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Italic);
            this.txtMessage.ForeColor = System.Drawing.Color.Black;
            this.txtMessage.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtMessage.IconRightOffset = new System.Drawing.Point(20, 0);
            this.txtMessage.IconRightSize = new System.Drawing.Size(50, 50);
            this.txtMessage.Location = new System.Drawing.Point(19, 631);
            this.txtMessage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.PasswordChar = '\0';
            this.txtMessage.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.txtMessage.PlaceholderText = "Type message here";
            this.txtMessage.SelectedText = "";
            this.txtMessage.Size = new System.Drawing.Size(462, 75);
            this.txtMessage.TabIndex = 1;
            this.txtMessage.TextOffset = new System.Drawing.Point(20, 0);
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(50, 50);
            this.guna2ImageButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(50, 50);
            this.guna2ImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("guna2ImageButton1.Image")));
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(50, 50);
            this.guna2ImageButton1.Location = new System.Drawing.Point(395, 640);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(50, 50);
            this.guna2ImageButton1.Size = new System.Drawing.Size(64, 54);
            this.guna2ImageButton1.TabIndex = 2;
            this.guna2ImageButton1.Click += new System.EventHandler(this.send_Click);
            // 
            // flowMessage
            // 
            this.flowMessage.AutoScroll = true;
            this.flowMessage.Location = new System.Drawing.Point(9, 169);
            this.flowMessage.Name = "flowMessage";
            this.flowMessage.Size = new System.Drawing.Size(488, 441);
            this.flowMessage.TabIndex = 3;
            // 
            // send_message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(504, 719);
            this.Controls.Add(this.flowMessage);
            this.Controls.Add(this.guna2ImageButton1);
            this.Controls.Add(this.txtMessage);
            this.Controls.Add(this.guna2GradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "send_message";
            this.Text = "send_message";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.send_message_FormClosed);
            this.Load += new System.EventHandler(this.send_message_Load);
            this.guna2GradientPanel1.ResumeLayout(false);
            this.guna2GradientPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.avatar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientPanel guna2GradientPanel1;
        private System.Windows.Forms.Label ten;
        private Guna.UI2.WinForms.Guna2CirclePictureBox avatar;
        private Guna.UI2.WinForms.Guna2TextBox txtMessage;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private System.Windows.Forms.FlowLayoutPanel flowMessage;
    }
}