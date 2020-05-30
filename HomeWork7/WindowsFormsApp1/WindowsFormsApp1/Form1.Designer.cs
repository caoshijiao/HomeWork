namespace WindowsFormsApp1
{
    partial class draw
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.pnlDraw = new System.Windows.Forms.Panel();
            this.btnDraw = new System.Windows.Forms.Button();
            this.RecursionDepth = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TruckLeng = new System.Windows.Forms.TextBox();
            this.LeftLeng = new System.Windows.Forms.TextBox();
            this.RightLeng = new System.Windows.Forms.TextBox();
            this.LeftAngle = new System.Windows.Forms.TextBox();
            this.RightAngle = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BrushColor = new System.Windows.Forms.ComboBox();
            this.Clear = new System.Windows.Forms.Button();
            this.result = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pnlDraw
            // 
            this.pnlDraw.Location = new System.Drawing.Point(320, 20);
            this.pnlDraw.Name = "pnlDraw";
            this.pnlDraw.Size = new System.Drawing.Size(400, 361);
            this.pnlDraw.TabIndex = 0;
            this.pnlDraw.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlDraw_Paint);
            // 
            // btnDraw
            // 
            this.btnDraw.Location = new System.Drawing.Point(15, 389);
            this.btnDraw.Name = "btnDraw";
            this.btnDraw.Size = new System.Drawing.Size(99, 31);
            this.btnDraw.TabIndex = 1;
            this.btnDraw.Text = "draw";
            this.btnDraw.UseVisualStyleBackColor = true;
            this.btnDraw.Click += new System.EventHandler(this.btnDraw_Click);
            // 
            // RecursionDepth
            // 
            this.RecursionDepth.Location = new System.Drawing.Point(147, 53);
            this.RecursionDepth.Name = "RecursionDepth";
            this.RecursionDepth.Size = new System.Drawing.Size(100, 28);
            this.RecursionDepth.TabIndex = 2;
            this.RecursionDepth.TextChanged += new System.EventHandler(this.tbRecursionDepth_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 18);
            this.label1.TabIndex = 3;
            this.label1.Text = "递归深度";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // TruckLeng
            // 
            this.TruckLeng.Location = new System.Drawing.Point(147, 96);
            this.TruckLeng.Name = "TruckLeng";
            this.TruckLeng.Size = new System.Drawing.Size(100, 28);
            this.TruckLeng.TabIndex = 4;
            this.TruckLeng.TextChanged += new System.EventHandler(this.tbTruckLeng_TextChanged);
            // 
            // LeftLeng
            // 
            this.LeftLeng.Location = new System.Drawing.Point(147, 141);
            this.LeftLeng.Name = "LeftLeng";
            this.LeftLeng.Size = new System.Drawing.Size(100, 28);
            this.LeftLeng.TabIndex = 5;
            this.LeftLeng.TextChanged += new System.EventHandler(this.tbLeftLeng_TextChanged);
            // 
            // RightLeng
            // 
            this.RightLeng.Location = new System.Drawing.Point(147, 181);
            this.RightLeng.Name = "RightLeng";
            this.RightLeng.Size = new System.Drawing.Size(100, 28);
            this.RightLeng.TabIndex = 6;
            this.RightLeng.TextChanged += new System.EventHandler(this.tbRightLeng_TextChanged);
            // 
            // LeftAngle
            // 
            this.LeftAngle.Location = new System.Drawing.Point(147, 231);
            this.LeftAngle.Name = "LeftAngle";
            this.LeftAngle.Size = new System.Drawing.Size(100, 28);
            this.LeftAngle.TabIndex = 7;
            this.LeftAngle.TextChanged += new System.EventHandler(this.tbLeftAngle_TextChanged);
            // 
            // RightAngle
            // 
            this.RightAngle.Location = new System.Drawing.Point(147, 271);
            this.RightAngle.Name = "RightAngle";
            this.RightAngle.Size = new System.Drawing.Size(100, 28);
            this.RightAngle.TabIndex = 8;
            this.RightAngle.TextChanged += new System.EventHandler(this.tbRightAngle_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 18);
            this.label2.TabIndex = 9;
            this.label2.Text = "主干长度";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 18);
            this.label3.TabIndex = 10;
            this.label3.Text = "左分支长度比";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 184);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "右分支长度比";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "左分支角度";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 274);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(98, 18);
            this.label6.TabIndex = 13;
            this.label6.Text = "右分支角度";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "参数";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 327);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(80, 18);
            this.label8.TabIndex = 15;
            this.label8.Text = "画笔颜色";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // BrushColor
            // 
            this.BrushColor.FormattingEnabled = true;
            this.BrushColor.Items.AddRange(new object[] {
            "blue",
            "red",
            "black",
            "yellow",
            "green"});
            this.BrushColor.Location = new System.Drawing.Point(147, 319);
            this.BrushColor.Name = "BrushColor";
            this.BrushColor.Size = new System.Drawing.Size(121, 26);
            this.BrushColor.TabIndex = 16;
            this.BrushColor.SelectedIndexChanged += new System.EventHandler(this.cbxBrushColor_SelectedIndexChanged);
            // 
            // Clear
            // 
            this.Clear.Location = new System.Drawing.Point(156, 386);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(103, 31);
            this.Clear.TabIndex = 17;
            this.Clear.Text = "clear";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.Location = new System.Drawing.Point(452, 402);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(44, 18);
            this.result.TabIndex = 18;
            this.result.Text = "结果";
            // 
            // draw
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.result);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.BrushColor);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.RightAngle);
            this.Controls.Add(this.LeftAngle);
            this.Controls.Add(this.RightLeng);
            this.Controls.Add(this.LeftLeng);
            this.Controls.Add(this.TruckLeng);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.RecursionDepth);
            this.Controls.Add(this.btnDraw);
            this.Controls.Add(this.pnlDraw);
            this.Name = "draw";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDraw;
        private System.Windows.Forms.Button btnDraw;
        private System.Windows.Forms.TextBox RecursionDepth;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TruckLeng;
        private System.Windows.Forms.TextBox LeftLeng;
        private System.Windows.Forms.TextBox RightLeng;
        private System.Windows.Forms.TextBox LeftAngle;
        private System.Windows.Forms.TextBox RightAngle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox BrushColor;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Label result;
    }
}

