namespace labCompGraf4
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rGBToBWToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iTPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contrastMaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageOFD = new System.Windows.Forms.OpenFileDialog();
            this.sourcePB = new System.Windows.Forms.PictureBox();
            this.itpPB = new System.Windows.Forms.PictureBox();
            this.greyPB = new System.Windows.Forms.PictureBox();
            this.resultSFD = new System.Windows.Forms.SaveFileDialog();
            this.itpNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.tb00 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb01 = new System.Windows.Forms.TextBox();
            this.tb02 = new System.Windows.Forms.TextBox();
            this.tb10 = new System.Windows.Forms.TextBox();
            this.tb20 = new System.Windows.Forms.TextBox();
            this.tb21 = new System.Windows.Forms.TextBox();
            this.tb11 = new System.Windows.Forms.TextBox();
            this.tb22 = new System.Windows.Forms.TextBox();
            this.tb12 = new System.Windows.Forms.TextBox();
            this.bTB = new System.Windows.Forms.TextBox();
            this.aTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.contrastPB = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sourcePB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itpPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.greyPB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itpNumericUpDown)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrastPB)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.rGBToBWToolStripMenuItem,
            this.iTPToolStripMenuItem,
            this.contrastMaskToolStripMenuItem,
            this.saveFileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(584, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.openToolStripMenuItem.Text = "Open File";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenToolStripMenuItem_Click);
            // 
            // rGBToBWToolStripMenuItem
            // 
            this.rGBToBWToolStripMenuItem.Name = "rGBToBWToolStripMenuItem";
            this.rGBToBWToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.rGBToBWToolStripMenuItem.Text = "RGB to BW";
            this.rGBToBWToolStripMenuItem.Click += new System.EventHandler(this.RGBToBWToolStripMenuItem_Click);
            // 
            // iTPToolStripMenuItem
            // 
            this.iTPToolStripMenuItem.Name = "iTPToolStripMenuItem";
            this.iTPToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.iTPToolStripMenuItem.Text = "ITP";
            this.iTPToolStripMenuItem.Click += new System.EventHandler(this.ITPToolStripMenuItem_Click);
            // 
            // contrastMaskToolStripMenuItem
            // 
            this.contrastMaskToolStripMenuItem.Name = "contrastMaskToolStripMenuItem";
            this.contrastMaskToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.contrastMaskToolStripMenuItem.Text = "Contrast Mask";
            this.contrastMaskToolStripMenuItem.Click += new System.EventHandler(this.ContrastMaskToolStripMenuItem_Click);
            // 
            // saveFileToolStripMenuItem
            // 
            this.saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            this.saveFileToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.saveFileToolStripMenuItem.Text = "Save File";
            this.saveFileToolStripMenuItem.Click += new System.EventHandler(this.SaveFileToolStripMenuItem_Click_1);
            // 
            // imageOFD
            // 
            this.imageOFD.FileName = "openFileDialog1";
            // 
            // sourcePB
            // 
            this.sourcePB.Location = new System.Drawing.Point(44, 74);
            this.sourcePB.Name = "sourcePB";
            this.sourcePB.Size = new System.Drawing.Size(200, 200);
            this.sourcePB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.sourcePB.TabIndex = 1;
            this.sourcePB.TabStop = false;
            // 
            // itpPB
            // 
            this.itpPB.Location = new System.Drawing.Point(294, 74);
            this.itpPB.Name = "itpPB";
            this.itpPB.Size = new System.Drawing.Size(200, 200);
            this.itpPB.TabIndex = 2;
            this.itpPB.TabStop = false;
            // 
            // greyPB
            // 
            this.greyPB.Location = new System.Drawing.Point(44, 324);
            this.greyPB.Name = "greyPB";
            this.greyPB.Size = new System.Drawing.Size(200, 200);
            this.greyPB.TabIndex = 4;
            this.greyPB.TabStop = false;
            // 
            // itpNumericUpDown
            // 
            this.itpNumericUpDown.Location = new System.Drawing.Point(390, 285);
            this.itpNumericUpDown.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.itpNumericUpDown.Name = "itpNumericUpDown";
            this.itpNumericUpDown.Size = new System.Drawing.Size(65, 20);
            this.itpNumericUpDown.TabIndex = 5;
            this.itpNumericUpDown.ValueChanged += new System.EventHandler(this.ItpNumericUpDown_ValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(291, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Значение порога";
            // 
            // tb00
            // 
            this.tb00.Location = new System.Drawing.Point(306, 377);
            this.tb00.Name = "tb00";
            this.tb00.Size = new System.Drawing.Size(30, 20);
            this.tb00.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(302, 354);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Матрица";
            // 
            // tb01
            // 
            this.tb01.Location = new System.Drawing.Point(342, 377);
            this.tb01.Name = "tb01";
            this.tb01.Size = new System.Drawing.Size(30, 20);
            this.tb01.TabIndex = 9;
            // 
            // tb02
            // 
            this.tb02.Location = new System.Drawing.Point(378, 377);
            this.tb02.Name = "tb02";
            this.tb02.Size = new System.Drawing.Size(30, 20);
            this.tb02.TabIndex = 10;
            // 
            // tb10
            // 
            this.tb10.Location = new System.Drawing.Point(306, 403);
            this.tb10.Name = "tb10";
            this.tb10.Size = new System.Drawing.Size(30, 20);
            this.tb10.TabIndex = 11;
            // 
            // tb20
            // 
            this.tb20.Location = new System.Drawing.Point(306, 429);
            this.tb20.Name = "tb20";
            this.tb20.Size = new System.Drawing.Size(30, 20);
            this.tb20.TabIndex = 12;
            // 
            // tb21
            // 
            this.tb21.Location = new System.Drawing.Point(342, 429);
            this.tb21.Name = "tb21";
            this.tb21.Size = new System.Drawing.Size(30, 20);
            this.tb21.TabIndex = 14;
            // 
            // tb11
            // 
            this.tb11.Location = new System.Drawing.Point(342, 403);
            this.tb11.Name = "tb11";
            this.tb11.Size = new System.Drawing.Size(30, 20);
            this.tb11.TabIndex = 13;
            // 
            // tb22
            // 
            this.tb22.Location = new System.Drawing.Point(378, 429);
            this.tb22.Name = "tb22";
            this.tb22.Size = new System.Drawing.Size(30, 20);
            this.tb22.TabIndex = 16;
            // 
            // tb12
            // 
            this.tb12.Location = new System.Drawing.Point(378, 403);
            this.tb12.Name = "tb12";
            this.tb12.Size = new System.Drawing.Size(30, 20);
            this.tb12.TabIndex = 15;
            // 
            // bTB
            // 
            this.bTB.Location = new System.Drawing.Point(436, 416);
            this.bTB.Name = "bTB";
            this.bTB.Size = new System.Drawing.Size(58, 20);
            this.bTB.TabIndex = 18;
            // 
            // aTB
            // 
            this.aTB.Location = new System.Drawing.Point(436, 377);
            this.aTB.Name = "aTB";
            this.aTB.Size = new System.Drawing.Size(58, 20);
            this.aTB.TabIndex = 17;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(433, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 19;
            this.label3.Text = "A";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(433, 400);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(14, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "B";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(378, 463);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(64, 24);
            this.button1.TabIndex = 21;
            this.button1.Text = "Do it!";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // contrastPB
            // 
            this.contrastPB.Location = new System.Drawing.Point(294, 324);
            this.contrastPB.Name = "contrastPB";
            this.contrastPB.Size = new System.Drawing.Size(200, 200);
            this.contrastPB.TabIndex = 22;
            this.contrastPB.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 561);
            this.Controls.Add(this.contrastPB);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bTB);
            this.Controls.Add(this.aTB);
            this.Controls.Add(this.tb22);
            this.Controls.Add(this.tb12);
            this.Controls.Add(this.tb21);
            this.Controls.Add(this.tb11);
            this.Controls.Add(this.tb20);
            this.Controls.Add(this.tb10);
            this.Controls.Add(this.tb02);
            this.Controls.Add(this.tb01);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb00);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.itpNumericUpDown);
            this.Controls.Add(this.greyPB);
            this.Controls.Add(this.itpPB);
            this.Controls.Add(this.sourcePB);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sourcePB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itpPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.greyPB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itpNumericUpDown)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contrastPB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rGBToBWToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iTPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contrastMaskToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog imageOFD;
        private System.Windows.Forms.PictureBox sourcePB;
        private System.Windows.Forms.PictureBox itpPB;
        private System.Windows.Forms.PictureBox greyPB;
        private System.Windows.Forms.SaveFileDialog resultSFD;
        private System.Windows.Forms.NumericUpDown itpNumericUpDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb00;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem saveFileToolStripMenuItem;
        private System.Windows.Forms.TextBox tb01;
        private System.Windows.Forms.TextBox tb02;
        private System.Windows.Forms.TextBox tb10;
        private System.Windows.Forms.TextBox tb20;
        private System.Windows.Forms.TextBox tb21;
        private System.Windows.Forms.TextBox tb11;
        private System.Windows.Forms.TextBox tb22;
        private System.Windows.Forms.TextBox tb12;
        private System.Windows.Forms.TextBox bTB;
        private System.Windows.Forms.TextBox aTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox contrastPB;
    }
}

