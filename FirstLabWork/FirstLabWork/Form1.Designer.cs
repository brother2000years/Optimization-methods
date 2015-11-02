namespace FirstLabWork
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.rbFuncTest = new System.Windows.Forms.RadioButton();
            this.rbFuncB = new System.Windows.Forms.RadioButton();
            this.rbFuncA = new System.Windows.Forms.RadioButton();
            this.btnCount = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.nudH = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.rbPowell = new System.Windows.Forms.RadioButton();
            this.rbDichotomy = new System.Windows.Forms.RadioButton();
            this.nudEpsilon = new System.Windows.Forms.NumericUpDown();
            this.nudX0 = new System.Windows.Forms.NumericUpDown();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rtbLogs = new System.Windows.Forms.RichTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbPowellAnswer = new System.Windows.Forms.TextBox();
            this.tbDichotomyAnswer = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudH)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEpsilon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudX0)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.nudH);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.rbPowell);
            this.groupBox1.Controls.Add(this.rbDichotomy);
            this.groupBox1.Controls.Add(this.nudEpsilon);
            this.groupBox1.Controls.Add(this.nudX0);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(221, 265);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Начальные условия";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.rbFuncTest);
            this.groupBox4.Controls.Add(this.rbFuncB);
            this.groupBox4.Controls.Add(this.rbFuncA);
            this.groupBox4.Controls.Add(this.btnCount);
            this.groupBox4.Location = new System.Drawing.Point(7, 153);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(200, 100);
            this.groupBox4.TabIndex = 10;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Выберите функцию";
            // 
            // rbFuncTest
            // 
            this.rbFuncTest.AutoSize = true;
            this.rbFuncTest.Location = new System.Drawing.Point(104, 20);
            this.rbFuncTest.Name = "rbFuncTest";
            this.rbFuncTest.Size = new System.Drawing.Size(49, 17);
            this.rbFuncTest.TabIndex = 3;
            this.rbFuncTest.TabStop = true;
            this.rbFuncTest.Text = "Тест";
            this.rbFuncTest.UseVisualStyleBackColor = true;
            // 
            // rbFuncB
            // 
            this.rbFuncB.AutoSize = true;
            this.rbFuncB.Location = new System.Drawing.Point(7, 43);
            this.rbFuncB.Name = "rbFuncB";
            this.rbFuncB.Size = new System.Drawing.Size(91, 17);
            this.rbFuncB.TabIndex = 1;
            this.rbFuncB.TabStop = true;
            this.rbFuncB.Text = "Функция \"Б\"";
            this.rbFuncB.UseVisualStyleBackColor = true;
            // 
            // rbFuncA
            // 
            this.rbFuncA.AutoSize = true;
            this.rbFuncA.Location = new System.Drawing.Point(7, 20);
            this.rbFuncA.Name = "rbFuncA";
            this.rbFuncA.Size = new System.Drawing.Size(91, 17);
            this.rbFuncA.TabIndex = 0;
            this.rbFuncA.TabStop = true;
            this.rbFuncA.Text = "Функция \"А\"";
            this.rbFuncA.UseVisualStyleBackColor = true;
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(7, 66);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(179, 28);
            this.btnCount.TabIndex = 2;
            this.btnCount.Text = "Рассчитать";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 52);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Шаг h";
            // 
            // nudH
            // 
            this.nudH.DecimalPlaces = 2;
            this.nudH.Location = new System.Drawing.Point(69, 50);
            this.nudH.Name = "nudH";
            this.nudH.Size = new System.Drawing.Size(120, 20);
            this.nudH.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Epsilon";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(20, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "X0";
            // 
            // rbPowell
            // 
            this.rbPowell.AutoSize = true;
            this.rbPowell.Location = new System.Drawing.Point(10, 129);
            this.rbPowell.Name = "rbPowell";
            this.rbPowell.Size = new System.Drawing.Size(103, 17);
            this.rbPowell.TabIndex = 4;
            this.rbPowell.TabStop = true;
            this.rbPowell.Text = "Метод Пауэлла";
            this.rbPowell.UseVisualStyleBackColor = true;
            // 
            // rbDichotomy
            // 
            this.rbDichotomy.AutoSize = true;
            this.rbDichotomy.Location = new System.Drawing.Point(10, 106);
            this.rbDichotomy.Name = "rbDichotomy";
            this.rbDichotomy.Size = new System.Drawing.Size(114, 17);
            this.rbDichotomy.TabIndex = 3;
            this.rbDichotomy.TabStop = true;
            this.rbDichotomy.Text = "Метод дихотомии";
            this.rbDichotomy.UseVisualStyleBackColor = true;
            // 
            // nudEpsilon
            // 
            this.nudEpsilon.DecimalPlaces = 3;
            this.nudEpsilon.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.nudEpsilon.Location = new System.Drawing.Point(69, 76);
            this.nudEpsilon.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudEpsilon.Name = "nudEpsilon";
            this.nudEpsilon.Size = new System.Drawing.Size(120, 20);
            this.nudEpsilon.TabIndex = 1;
            // 
            // nudX0
            // 
            this.nudX0.Location = new System.Drawing.Point(69, 22);
            this.nudX0.Name = "nudX0";
            this.nudX0.Size = new System.Drawing.Size(120, 20);
            this.nudX0.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rtbLogs);
            this.groupBox2.Location = new System.Drawing.Point(239, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(410, 265);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ход вычислений";
            // 
            // rtbLogs
            // 
            this.rtbLogs.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rtbLogs.Location = new System.Drawing.Point(6, 19);
            this.rtbLogs.Name = "rtbLogs";
            this.rtbLogs.ReadOnly = true;
            this.rtbLogs.Size = new System.Drawing.Size(395, 240);
            this.rtbLogs.TabIndex = 0;
            this.rtbLogs.Text = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbPowellAnswer);
            this.groupBox3.Controls.Add(this.tbDichotomyAnswer);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(12, 283);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(637, 54);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Результаты вычислений";
            // 
            // tbPowellAnswer
            // 
            this.tbPowellAnswer.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbPowellAnswer.Location = new System.Drawing.Point(411, 20);
            this.tbPowellAnswer.Name = "tbPowellAnswer";
            this.tbPowellAnswer.ReadOnly = true;
            this.tbPowellAnswer.Size = new System.Drawing.Size(217, 20);
            this.tbPowellAnswer.TabIndex = 3;
            // 
            // tbDichotomyAnswer
            // 
            this.tbDichotomyAnswer.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.tbDichotomyAnswer.Location = new System.Drawing.Point(130, 19);
            this.tbDichotomyAnswer.Name = "tbDichotomyAnswer";
            this.tbDichotomyAnswer.ReadOnly = true;
            this.tbDichotomyAnswer.Size = new System.Drawing.Size(164, 20);
            this.tbDichotomyAnswer.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Метод Пауэлла x = ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Метод дихотомии x = ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 350);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(676, 389);
            this.MinimumSize = new System.Drawing.Size(676, 389);
            this.Name = "Form1";
            this.Text = "Лабораторная работа №1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudH)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudEpsilon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudX0)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RichTextBox rtbLogs;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rbPowell;
        private System.Windows.Forms.RadioButton rbDichotomy;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.NumericUpDown nudEpsilon;
        private System.Windows.Forms.NumericUpDown nudX0;
        private System.Windows.Forms.TextBox tbPowellAnswer;
        private System.Windows.Forms.TextBox tbDichotomyAnswer;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown nudH;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton rbFuncB;
        private System.Windows.Forms.RadioButton rbFuncA;
        private System.Windows.Forms.RadioButton rbFuncTest;
    }
}

