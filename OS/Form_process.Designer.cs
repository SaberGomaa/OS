namespace OS
{
    partial class Form_process
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_ok_number_of_process = new System.Windows.Forms.Button();
            this.groupbox_algorithm = new System.Windows.Forms.GroupBox();
            this.radioButton5 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.lbl_Priority_N = new System.Windows.Forms.Label();
            this.lbl_FCFS = new System.Windows.Forms.Label();
            this.groupBox_numberProcess = new System.Windows.Forms.GroupBox();
            this.numeric_numProcess = new System.Windows.Forms.NumericUpDown();
            this.panel1.SuspendLayout();
            this.groupbox_algorithm.SuspendLayout();
            this.groupBox_numberProcess.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numeric_numProcess)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btn_ok_number_of_process);
            this.panel1.Controls.Add(this.groupbox_algorithm);
            this.panel1.Controls.Add(this.groupBox_numberProcess);
            this.panel1.Location = new System.Drawing.Point(58, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(630, 427);
            this.panel1.TabIndex = 50;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(64, 327);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 46);
            this.button1.TabIndex = 25;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_ok_number_of_process
            // 
            this.btn_ok_number_of_process.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn_ok_number_of_process.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ok_number_of_process.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ok_number_of_process.ForeColor = System.Drawing.Color.Azure;
            this.btn_ok_number_of_process.Location = new System.Drawing.Point(467, 327);
            this.btn_ok_number_of_process.Name = "btn_ok_number_of_process";
            this.btn_ok_number_of_process.Size = new System.Drawing.Size(99, 46);
            this.btn_ok_number_of_process.TabIndex = 5;
            this.btn_ok_number_of_process.Text = "Next";
            this.btn_ok_number_of_process.UseVisualStyleBackColor = false;
            this.btn_ok_number_of_process.Click += new System.EventHandler(this.btn_ok_number_of_process_Click);
            // 
            // groupbox_algorithm
            // 
            this.groupbox_algorithm.Controls.Add(this.radioButton5);
            this.groupbox_algorithm.Controls.Add(this.radioButton1);
            this.groupbox_algorithm.Controls.Add(this.lbl_Priority_N);
            this.groupbox_algorithm.Controls.Add(this.lbl_FCFS);
            this.groupbox_algorithm.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupbox_algorithm.ForeColor = System.Drawing.Color.Black;
            this.groupbox_algorithm.Location = new System.Drawing.Point(64, 123);
            this.groupbox_algorithm.Name = "groupbox_algorithm";
            this.groupbox_algorithm.Size = new System.Drawing.Size(502, 168);
            this.groupbox_algorithm.TabIndex = 24;
            this.groupbox_algorithm.TabStop = false;
            this.groupbox_algorithm.Text = "Choose ALgorthim";
            this.groupbox_algorithm.Enter += new System.EventHandler(this.groupbox_algorithm_Enter);
            // 
            // radioButton5
            // 
            this.radioButton5.BackColor = System.Drawing.Color.Transparent;
            this.radioButton5.Cursor = System.Windows.Forms.Cursors.Default;
            this.radioButton5.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.radioButton5.Location = new System.Drawing.Point(116, 114);
            this.radioButton5.Name = "radioButton5";
            this.radioButton5.Size = new System.Drawing.Size(102, 34);
            this.radioButton5.TabIndex = 34;
            this.radioButton5.TabStop = true;
            this.radioButton5.Text = "Priority nonpreemptive";
            this.radioButton5.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButton5.UseVisualStyleBackColor = false;
            this.radioButton5.CheckedChanged += new System.EventHandler(this.radioButton5_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.BackColor = System.Drawing.Color.Transparent;
            this.radioButton1.Font = new System.Drawing.Font("Segoe UI", 15.75F);
            this.radioButton1.Location = new System.Drawing.Point(116, 42);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(90, 34);
            this.radioButton1.TabIndex = 19;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "FCFS";
            this.radioButton1.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.radioButton1.UseVisualStyleBackColor = false;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // lbl_Priority_N
            // 
            this.lbl_Priority_N.AutoSize = true;
            this.lbl_Priority_N.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Priority_N.ForeColor = System.Drawing.Color.Black;
            this.lbl_Priority_N.Location = new System.Drawing.Point(241, 129);
            this.lbl_Priority_N.Name = "lbl_Priority_N";
            this.lbl_Priority_N.Size = new System.Drawing.Size(211, 17);
            this.lbl_Priority_N.TabIndex = 30;
            this.lbl_Priority_N.Text = "Priority Scheduling Nonpreemptive";
            this.lbl_Priority_N.Click += new System.EventHandler(this.lbl_Priority_N_Click);
            // 
            // lbl_FCFS
            // 
            this.lbl_FCFS.AutoSize = true;
            this.lbl_FCFS.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_FCFS.ForeColor = System.Drawing.Color.Black;
            this.lbl_FCFS.Location = new System.Drawing.Point(241, 51);
            this.lbl_FCFS.Name = "lbl_FCFS";
            this.lbl_FCFS.Size = new System.Drawing.Size(131, 17);
            this.lbl_FCFS.TabIndex = 22;
            this.lbl_FCFS.Text = "First come First serve";
            // 
            // groupBox_numberProcess
            // 
            this.groupBox_numberProcess.Controls.Add(this.numeric_numProcess);
            this.groupBox_numberProcess.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox_numberProcess.ForeColor = System.Drawing.Color.Black;
            this.groupBox_numberProcess.Location = new System.Drawing.Point(64, 14);
            this.groupBox_numberProcess.Name = "groupBox_numberProcess";
            this.groupBox_numberProcess.Size = new System.Drawing.Size(502, 103);
            this.groupBox_numberProcess.TabIndex = 6;
            this.groupBox_numberProcess.TabStop = false;
            this.groupBox_numberProcess.Text = "Process Numbers";
            this.groupBox_numberProcess.Enter += new System.EventHandler(this.groupBox_numberProcess_Enter);
            // 
            // numeric_numProcess
            // 
            this.numeric_numProcess.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.numeric_numProcess.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numeric_numProcess.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numeric_numProcess.ForeColor = System.Drawing.Color.Black;
            this.numeric_numProcess.Location = new System.Drawing.Point(181, 42);
            this.numeric_numProcess.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
            this.numeric_numProcess.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_numProcess.Name = "numeric_numProcess";
            this.numeric_numProcess.ReadOnly = true;
            this.numeric_numProcess.Size = new System.Drawing.Size(112, 50);
            this.numeric_numProcess.TabIndex = 4;
            this.numeric_numProcess.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.numeric_numProcess.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numeric_numProcess.ValueChanged += new System.EventHandler(this.numeric_numProcess_ValueChanged_1);
            // 
            // Form_process
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(748, 504);
            this.Controls.Add(this.panel1);
            this.Name = "Form_process";
            this.Text = "choose your algorithm";
            this.Load += new System.EventHandler(this.Form_process_Load);
            this.panel1.ResumeLayout(false);
            this.groupbox_algorithm.ResumeLayout(false);
            this.groupbox_algorithm.PerformLayout();
            this.groupBox_numberProcess.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numeric_numProcess)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_ok_number_of_process;
        private System.Windows.Forms.GroupBox groupbox_algorithm;
        private System.Windows.Forms.Label lbl_Priority_N;
        private System.Windows.Forms.Label lbl_FCFS;
        private System.Windows.Forms.GroupBox groupBox_numberProcess;
        private System.Windows.Forms.NumericUpDown numeric_numProcess;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton5;
        private System.Windows.Forms.Button button1;
    }
}