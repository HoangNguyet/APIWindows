namespace src.scheduling_algorithms
{
    partial class form_scheduling_algorithm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.boxArivealTime = new System.Windows.Forms.NumericUpDown();
            this.boxBurstTime = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnRun = new System.Windows.Forms.Button();
            this.nameProcess = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arivealTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.burstTime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxArivealTime)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxBurstTime)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nameProcess,
            this.arivealTime,
            this.burstTime});
            this.dataGridView1.Location = new System.Drawing.Point(290, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(620, 389);
            this.dataGridView1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 24);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ariveal Time";
            // 
            // boxArivealTime
            // 
            this.boxArivealTime.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxArivealTime.Location = new System.Drawing.Point(35, 59);
            this.boxArivealTime.Name = "boxArivealTime";
            this.boxArivealTime.Size = new System.Drawing.Size(192, 32);
            this.boxArivealTime.TabIndex = 2;
            // 
            // boxBurstTime
            // 
            this.boxBurstTime.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxBurstTime.Location = new System.Drawing.Point(35, 162);
            this.boxBurstTime.Name = "boxBurstTime";
            this.boxBurstTime.Size = new System.Drawing.Size(192, 32);
            this.boxBurstTime.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Roboto", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "Burst Time";
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(36, 223);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(190, 43);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Roboto", 10.2F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(290, 437);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 43);
            this.button1.TabIndex = 7;
            this.button1.Text = "Delete";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(394, 437);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(95, 43);
            this.button3.TabIndex = 8;
            this.button3.Text = "Delete All";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnRun
            // 
            this.btnRun.Font = new System.Drawing.Font("Roboto", 13.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRun.Location = new System.Drawing.Point(716, 437);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(190, 43);
            this.btnRun.TabIndex = 9;
            this.btnRun.Text = "Run";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // nameProcess
            // 
            this.nameProcess.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameProcess.HeaderText = "Tên";
            this.nameProcess.MinimumWidth = 6;
            this.nameProcess.Name = "nameProcess";
            this.nameProcess.ReadOnly = true;
            // 
            // arivealTime
            // 
            this.arivealTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.arivealTime.HeaderText = "Thời gian đến";
            this.arivealTime.MinimumWidth = 6;
            this.arivealTime.Name = "arivealTime";
            this.arivealTime.ReadOnly = true;
            // 
            // burstTime
            // 
            this.burstTime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.burstTime.HeaderText = "Thời gian  thực thi";
            this.burstTime.MinimumWidth = 6;
            this.burstTime.Name = "burstTime";
            this.burstTime.ReadOnly = true;
            // 
            // form_scheduling_algorithm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(918, 502);
            this.Controls.Add(this.btnRun);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.boxBurstTime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.boxArivealTime);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "form_scheduling_algorithm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_scheduling_algorithm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxArivealTime)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.boxBurstTime)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown boxArivealTime;
        private System.Windows.Forms.NumericUpDown boxBurstTime;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameProcess;
        private System.Windows.Forms.DataGridViewTextBoxColumn arivealTime;
        private System.Windows.Forms.DataGridViewTextBoxColumn burstTime;
    }
}