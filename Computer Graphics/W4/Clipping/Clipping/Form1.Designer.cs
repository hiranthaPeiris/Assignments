namespace Clipping
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbCP = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.txtV = new System.Windows.Forms.TextBox();
            this.txtY = new System.Windows.Forms.TextBox();
            this.txtX = new System.Windows.Forms.TextBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbLS = new System.Windows.Forms.GroupBox();
            this.chbDisplay = new System.Windows.Forms.CheckBox();
            this.txtNumber = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gbAlg = new System.Windows.Forms.GroupBox();
            this.lbAg = new System.Windows.Forms.ListBox();
            this.gbTime = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTime = new System.Windows.Forms.TextBox();
            this.btnRun = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnDraw = new System.Windows.Forms.Button();
            this.gbCP.SuspendLayout();
            this.gbLS.SuspendLayout();
            this.gbAlg.SuspendLayout();
            this.gbTime.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Location = new System.Drawing.Point(8, 7);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(421, 486);
            this.panel1.TabIndex = 0;
            // 
            // gbCP
            // 
            this.gbCP.Controls.Add(this.label4);
            this.gbCP.Controls.Add(this.label3);
            this.gbCP.Controls.Add(this.label2);
            this.gbCP.Controls.Add(this.btnInsert);
            this.gbCP.Controls.Add(this.btnOk);
            this.gbCP.Controls.Add(this.txtV);
            this.gbCP.Controls.Add(this.txtY);
            this.gbCP.Controls.Add(this.txtX);
            this.gbCP.Controls.Add(this.txtNum);
            this.gbCP.Controls.Add(this.label1);
            this.gbCP.Location = new System.Drawing.Point(449, 12);
            this.gbCP.Name = "gbCP";
            this.gbCP.Size = new System.Drawing.Size(236, 126);
            this.gbCP.TabIndex = 1;
            this.gbCP.TabStop = false;
            this.gbCP.Text = "Convex Polygon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(162, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 63);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "V";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(101, 85);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(127, 23);
            this.btnInsert.TabIndex = 6;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(182, 24);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(47, 23);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // txtV
            // 
            this.txtV.Location = new System.Drawing.Point(26, 63);
            this.txtV.Name = "txtV";
            this.txtV.Size = new System.Drawing.Size(30, 20);
            this.txtV.TabIndex = 4;
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(182, 59);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(46, 20);
            this.txtY.TabIndex = 3;
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(102, 59);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(46, 20);
            this.txtX.TabIndex = 2;
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(102, 26);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(46, 20);
            this.txtNum.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vertices";
            // 
            // gbLS
            // 
            this.gbLS.Controls.Add(this.chbDisplay);
            this.gbLS.Controls.Add(this.txtNumber);
            this.gbLS.Controls.Add(this.label5);
            this.gbLS.Enabled = false;
            this.gbLS.Location = new System.Drawing.Point(449, 140);
            this.gbLS.Name = "gbLS";
            this.gbLS.Size = new System.Drawing.Size(236, 88);
            this.gbLS.TabIndex = 2;
            this.gbLS.TabStop = false;
            this.gbLS.Text = "Line Segments";
            // 
            // chbDisplay
            // 
            this.chbDisplay.AutoSize = true;
            this.chbDisplay.Location = new System.Drawing.Point(102, 49);
            this.chbDisplay.Name = "chbDisplay";
            this.chbDisplay.Size = new System.Drawing.Size(60, 17);
            this.chbDisplay.TabIndex = 2;
            this.chbDisplay.Text = "Display";
            this.chbDisplay.UseVisualStyleBackColor = true;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(102, 23);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(127, 20);
            this.txtNumber.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Number";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // gbAlg
            // 
            this.gbAlg.Controls.Add(this.lbAg);
            this.gbAlg.Enabled = false;
            this.gbAlg.Location = new System.Drawing.Point(450, 234);
            this.gbAlg.Name = "gbAlg";
            this.gbAlg.Size = new System.Drawing.Size(235, 111);
            this.gbAlg.TabIndex = 3;
            this.gbAlg.TabStop = false;
            this.gbAlg.Text = "Algorithm";
            // 
            // lbAg
            // 
            this.lbAg.FormattingEnabled = true;
            this.lbAg.Items.AddRange(new object[] {
            "Cyrus Beck",
            "Skala",
            "Proposed"});
            this.lbAg.Location = new System.Drawing.Point(16, 22);
            this.lbAg.Name = "lbAg";
            this.lbAg.Size = new System.Drawing.Size(203, 82);
            this.lbAg.TabIndex = 0;
            // 
            // gbTime
            // 
            this.gbTime.Controls.Add(this.label6);
            this.gbTime.Controls.Add(this.txtTime);
            this.gbTime.Controls.Add(this.btnRun);
            this.gbTime.Enabled = false;
            this.gbTime.Location = new System.Drawing.Point(449, 360);
            this.gbTime.Name = "gbTime";
            this.gbTime.Size = new System.Drawing.Size(236, 99);
            this.gbTime.TabIndex = 4;
            this.gbTime.TabStop = false;
            this.gbTime.Text = "Time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Execution Time";
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(18, 63);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(203, 20);
            this.txtTime.TabIndex = 1;
            // 
            // btnRun
            // 
            this.btnRun.Location = new System.Drawing.Point(18, 15);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(203, 23);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "RUN";
            this.btnRun.UseVisualStyleBackColor = true;
            this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(466, 465);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(100, 23);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(573, 465);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(97, 23);
            this.btnDraw.TabIndex = 6;
            this.btnDraw.Text = "Draw";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(697, 505);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.gbTime);
            this.Controls.Add(this.gbAlg);
            this.Controls.Add(this.gbLS);
            this.Controls.Add(this.gbCP);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.gbCP.ResumeLayout(false);
            this.gbCP.PerformLayout();
            this.gbLS.ResumeLayout(false);
            this.gbLS.PerformLayout();
            this.gbAlg.ResumeLayout(false);
            this.gbTime.ResumeLayout(false);
            this.gbTime.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbCP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.TextBox txtV;
        private System.Windows.Forms.TextBox txtY;
        private System.Windows.Forms.TextBox txtX;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbLS;
        private System.Windows.Forms.GroupBox gbAlg;
        private System.Windows.Forms.GroupBox gbTime;
        private System.Windows.Forms.CheckBox chbDisplay;
        private System.Windows.Forms.TextBox txtNumber;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox lbAg;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtTime;
        private System.Windows.Forms.Button btnRun;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnDraw;
    }
}

