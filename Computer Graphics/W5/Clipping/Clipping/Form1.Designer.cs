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
            this.txtVertices = new System.Windows.Forms.TextBox();
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
            this.panel1.Location = new System.Drawing.Point(11, 9);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(561, 598);
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
            this.gbCP.Controls.Add(this.txtVertices);
            this.gbCP.Controls.Add(this.label1);
            this.gbCP.Location = new System.Drawing.Point(599, 15);
            this.gbCP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbCP.Name = "gbCP";
            this.gbCP.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbCP.Size = new System.Drawing.Size(315, 155);
            this.gbCP.TabIndex = 1;
            this.gbCP.TabStop = false;
            this.gbCP.Text = "Convex Polygon";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(216, 76);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(17, 17);
            this.label4.TabIndex = 9;
            this.label4.Text = "Y";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(109, 78);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 17);
            this.label3.TabIndex = 8;
            this.label3.Text = "X";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 81);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "V";
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(135, 105);
            this.btnInsert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(169, 28);
            this.btnInsert.TabIndex = 6;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(243, 30);
            this.btnOk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(63, 28);
            this.btnOk.TabIndex = 5;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            // 
            // txtV
            // 
            this.txtV.Location = new System.Drawing.Point(35, 78);
            this.txtV.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtV.Name = "txtV";
            this.txtV.Size = new System.Drawing.Size(39, 22);
            this.txtV.TabIndex = 4;
            // 
            // txtY
            // 
            this.txtY.Location = new System.Drawing.Point(243, 73);
            this.txtY.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(60, 22);
            this.txtY.TabIndex = 3;
            // 
            // txtX
            // 
            this.txtX.Location = new System.Drawing.Point(136, 73);
            this.txtX.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(60, 22);
            this.txtX.TabIndex = 2;
            // 
            // txtVertices
            // 
            this.txtVertices.Location = new System.Drawing.Point(136, 32);
            this.txtVertices.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtVertices.Name = "txtVertices";
            this.txtVertices.Size = new System.Drawing.Size(60, 22);
            this.txtVertices.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vertices";
            // 
            // gbLS
            // 
            this.gbLS.Controls.Add(this.chbDisplay);
            this.gbLS.Controls.Add(this.txtNumber);
            this.gbLS.Controls.Add(this.label5);
            this.gbLS.Location = new System.Drawing.Point(599, 172);
            this.gbLS.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbLS.Name = "gbLS";
            this.gbLS.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbLS.Size = new System.Drawing.Size(315, 108);
            this.gbLS.TabIndex = 2;
            this.gbLS.TabStop = false;
            this.gbLS.Text = "Line Segments";
            // 
            // chbDisplay
            // 
            this.chbDisplay.AutoSize = true;
            this.chbDisplay.Location = new System.Drawing.Point(136, 60);
            this.chbDisplay.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.chbDisplay.Name = "chbDisplay";
            this.chbDisplay.Size = new System.Drawing.Size(76, 21);
            this.chbDisplay.TabIndex = 2;
            this.chbDisplay.Text = "Display";
            this.chbDisplay.UseVisualStyleBackColor = true;
            // 
            // txtNumber
            // 
            this.txtNumber.Location = new System.Drawing.Point(136, 28);
            this.txtNumber.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNumber.Name = "txtNumber";
            this.txtNumber.Size = new System.Drawing.Size(168, 22);
            this.txtNumber.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 32);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 17);
            this.label5.TabIndex = 0;
            this.label5.Text = "Number";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // gbAlg
            // 
            this.gbAlg.Controls.Add(this.lbAg);
            this.gbAlg.Location = new System.Drawing.Point(600, 288);
            this.gbAlg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbAlg.Name = "gbAlg";
            this.gbAlg.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbAlg.Size = new System.Drawing.Size(313, 137);
            this.gbAlg.TabIndex = 3;
            this.gbAlg.TabStop = false;
            this.gbAlg.Text = "Algorithm";
            // 
            // lbAg
            // 
            this.lbAg.FormattingEnabled = true;
            this.lbAg.ItemHeight = 16;
            this.lbAg.Items.AddRange(new object[] {
            "Cyrus Beck",
            "Skala",
            "Proposed"});
            this.lbAg.Location = new System.Drawing.Point(21, 27);
            this.lbAg.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbAg.Name = "lbAg";
            this.lbAg.Size = new System.Drawing.Size(269, 100);
            this.lbAg.TabIndex = 0;
            // 
            // gbTime
            // 
            this.gbTime.Controls.Add(this.label6);
            this.gbTime.Controls.Add(this.txtTime);
            this.gbTime.Controls.Add(this.btnRun);
            this.gbTime.Location = new System.Drawing.Point(599, 443);
            this.gbTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbTime.Name = "gbTime";
            this.gbTime.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.gbTime.Size = new System.Drawing.Size(315, 122);
            this.gbTime.TabIndex = 4;
            this.gbTime.TabStop = false;
            this.gbTime.Text = "Time";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 55);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Execution Time";
            // 
            // txtTime
            // 
            this.txtTime.Location = new System.Drawing.Point(24, 78);
            this.txtTime.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtTime.Name = "txtTime";
            this.txtTime.Size = new System.Drawing.Size(269, 22);
            this.txtTime.TabIndex = 1;
            // 
            // btnRun
            // 
            this.btnRun.Enabled = false;
            this.btnRun.Location = new System.Drawing.Point(24, 18);
            this.btnRun.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRun.Name = "btnRun";
            this.btnRun.Size = new System.Drawing.Size(271, 28);
            this.btnRun.TabIndex = 0;
            this.btnRun.Text = "RUN";
            this.btnRun.UseVisualStyleBackColor = true;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(621, 572);
            this.btnClear.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(133, 28);
            this.btnClear.TabIndex = 5;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(764, 572);
            this.btnDraw.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(129, 28);
            this.btnDraw.TabIndex = 6;
            this.btnDraw.Text = "Draw";
            this.btnDraw.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(929, 622);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.gbTime);
            this.Controls.Add(this.gbAlg);
            this.Controls.Add(this.gbLS);
            this.Controls.Add(this.gbCP);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
        private System.Windows.Forms.TextBox txtVertices;
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

