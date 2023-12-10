namespace src.scheduling_algorithms
{
    partial class scheduling_algorithm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtThoiGianDen = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.txtThoiGianThucThi = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.add = new Guna.UI2.WinForms.Guna2Button();
            this.deleteAll = new Guna.UI2.WinForms.Guna2Button();
            this.data = new Guna.UI2.WinForms.Guna2DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.opption = new Guna.UI2.WinForms.Guna2ComboBox();
            this.run = new Guna.UI2.WinForms.Guna2Button();
            this.delete = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.txtThoiGianDen)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThoiGianThucThi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.data)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(59, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(194, 37);
            this.label1.TabIndex = 1;
            this.label1.Text = "Thời gian đến";
            // 
            // txtThoiGianDen
            // 
            this.txtThoiGianDen.BackColor = System.Drawing.Color.Transparent;
            this.txtThoiGianDen.BorderRadius = 15;
            this.txtThoiGianDen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtThoiGianDen.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Italic);
            this.txtThoiGianDen.Location = new System.Drawing.Point(66, 97);
            this.txtThoiGianDen.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtThoiGianDen.Name = "txtThoiGianDen";
            this.txtThoiGianDen.Size = new System.Drawing.Size(324, 60);
            this.txtThoiGianDen.TabIndex = 2;
            // 
            // txtThoiGianThucThi
            // 
            this.txtThoiGianThucThi.BackColor = System.Drawing.Color.Transparent;
            this.txtThoiGianThucThi.BorderRadius = 15;
            this.txtThoiGianThucThi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtThoiGianThucThi.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Italic);
            this.txtThoiGianThucThi.Location = new System.Drawing.Point(66, 251);
            this.txtThoiGianThucThi.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtThoiGianThucThi.Name = "txtThoiGianThucThi";
            this.txtThoiGianThucThi.Size = new System.Drawing.Size(324, 60);
            this.txtThoiGianThucThi.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(59, 206);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 37);
            this.label2.TabIndex = 3;
            this.label2.Text = "Thời gian thưc thi";
            // 
            // add
            // 
            this.add.Animated = true;
            this.add.BorderRadius = 15;
            this.add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.add.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.add.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.add.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.add.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.add.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Italic);
            this.add.ForeColor = System.Drawing.Color.White;
            this.add.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(250)))));
            this.add.Location = new System.Drawing.Point(66, 362);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(324, 62);
            this.add.TabIndex = 5;
            this.add.Text = "Thêm";
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // deleteAll
            // 
            this.deleteAll.Animated = true;
            this.deleteAll.BorderRadius = 10;
            this.deleteAll.Cursor = System.Windows.Forms.Cursors.Hand;
            this.deleteAll.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.deleteAll.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.deleteAll.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.deleteAll.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.deleteAll.FillColor = System.Drawing.Color.Firebrick;
            this.deleteAll.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Italic);
            this.deleteAll.ForeColor = System.Drawing.Color.White;
            this.deleteAll.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(250)))));
            this.deleteAll.Location = new System.Drawing.Point(66, 617);
            this.deleteAll.Name = "deleteAll";
            this.deleteAll.Size = new System.Drawing.Size(324, 62);
            this.deleteAll.TabIndex = 7;
            this.deleteAll.Text = "Xóa tất cả";
            this.deleteAll.Click += new System.EventHandler(this.deleteAll_Click);
            // 
            // data
            // 
            this.data.AllowUserToDeleteRows = false;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle5;
            this.data.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.data.ColumnHeadersHeight = 40;
            this.data.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.data.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.data.DefaultCellStyle = dataGridViewCellStyle7;
            this.data.GridColor = System.Drawing.Color.Gainsboro;
            this.data.Location = new System.Drawing.Point(538, 97);
            this.data.Margin = new System.Windows.Forms.Padding(7);
            this.data.Name = "data";
            this.data.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.data.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.data.RowHeadersVisible = false;
            this.data.RowHeadersWidth = 51;
            this.data.RowTemplate.DefaultCellStyle.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.data.RowTemplate.DefaultCellStyle.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data.RowTemplate.DefaultCellStyle.Padding = new System.Windows.Forms.Padding(10);
            this.data.RowTemplate.DividerHeight = 2;
            this.data.RowTemplate.Height = 45;
            this.data.ShowEditingIcon = false;
            this.data.Size = new System.Drawing.Size(851, 504);
            this.data.TabIndex = 8;
            this.data.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.data.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.data.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.data.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.data.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.data.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.data.ThemeStyle.GridColor = System.Drawing.Color.Gainsboro;
            this.data.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.data.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.data.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.data.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.data.ThemeStyle.HeaderStyle.Height = 40;
            this.data.ThemeStyle.ReadOnly = true;
            this.data.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.data.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.data.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.data.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.data.ThemeStyle.RowsStyle.Height = 45;
            this.data.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.data.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Tên tiến trình";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Thời gian đến";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Thời gian thực thi";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // opption
            // 
            this.opption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.opption.BackColor = System.Drawing.Color.Transparent;
            this.opption.BorderRadius = 10;
            this.opption.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.opption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.opption.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.opption.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.opption.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Italic);
            this.opption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.opption.ItemHeight = 40;
            this.opption.Items.AddRange(new object[] {
            "FCFS",
            "RR",
            "SJF",
            "SRTN"});
            this.opption.Location = new System.Drawing.Point(1190, 628);
            this.opption.Name = "opption";
            this.opption.Size = new System.Drawing.Size(199, 46);
            this.opption.TabIndex = 9;
            // 
            // run
            // 
            this.run.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.run.Animated = true;
            this.run.BorderRadius = 20;
            this.run.Cursor = System.Windows.Forms.Cursors.Hand;
            this.run.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.run.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.run.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.run.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.run.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Italic);
            this.run.ForeColor = System.Drawing.Color.White;
            this.run.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(250)))));
            this.run.Location = new System.Drawing.Point(983, 624);
            this.run.Name = "run";
            this.run.Size = new System.Drawing.Size(201, 58);
            this.run.TabIndex = 10;
            this.run.Text = "Chạy";
            this.run.Click += new System.EventHandler(this.run_Click);
            // 
            // delete
            // 
            this.delete.Animated = true;
            this.delete.BorderRadius = 10;
            this.delete.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.delete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.delete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.delete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.delete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.delete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.delete.FillColor = System.Drawing.Color.Firebrick;
            this.delete.Font = new System.Drawing.Font("Roboto", 16.2F, System.Drawing.FontStyle.Italic);
            this.delete.ForeColor = System.Drawing.Color.White;
            this.delete.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(250)))));
            this.delete.Location = new System.Drawing.Point(66, 548);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(324, 62);
            this.delete.TabIndex = 6;
            this.delete.Text = "Xóa";
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // scheduling_algorithm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.run);
            this.Controls.Add(this.opption);
            this.Controls.Add(this.data);
            this.Controls.Add(this.deleteAll);
            this.Controls.Add(this.delete);
            this.Controls.Add(this.add);
            this.Controls.Add(this.txtThoiGianThucThi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtThoiGianDen);
            this.Controls.Add(this.label1);
            this.Name = "scheduling_algorithm";
            this.Size = new System.Drawing.Size(1422, 729);
            this.Load += new System.EventHandler(this.scheduling_algorithm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.txtThoiGianDen)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThoiGianThucThi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.data)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2NumericUpDown txtThoiGianDen;
        private Guna.UI2.WinForms.Guna2NumericUpDown txtThoiGianThucThi;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Button add;
        private Guna.UI2.WinForms.Guna2Button deleteAll;
        private Guna.UI2.WinForms.Guna2DataGridView data;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private Guna.UI2.WinForms.Guna2ComboBox opption;
        private Guna.UI2.WinForms.Guna2Button run;
        private Guna.UI2.WinForms.Guna2Button delete;
    }
}
