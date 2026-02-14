namespace Tribonachi
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
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.lstTribonacci = new System.Windows.Forms.ListBox();
            this.btnGenerate1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Fibonacci = new System.Windows.Forms.Label();
            this.Tribinacci = new System.Windows.Forms.Label();
            this.lstTribonacci1 = new System.Windows.Forms.ListBox();
            this.lstFibonacci = new System.Windows.Forms.ListBox();
            this.btnCompare = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.picGraph = new System.Windows.Forms.PictureBox();
            this.btnPlot = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tabControl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGraph)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPage1);
            this.tabControl.Controls.Add(this.tabPage2);
            this.tabControl.Controls.Add(this.tabPage3);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(518, 375);
            this.tabControl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.lstTribonacci);
            this.tabPage1.Controls.Add(this.btnGenerate1);
            this.tabPage1.Controls.Add(this.textBox1);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(510, 349);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Трибоначчи";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // lstTribonacci
            // 
            this.lstTribonacci.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lstTribonacci.FormattingEnabled = true;
            this.lstTribonacci.ItemHeight = 15;
            this.lstTribonacci.Location = new System.Drawing.Point(0, 99);
            this.lstTribonacci.Name = "lstTribonacci";
            this.lstTribonacci.Size = new System.Drawing.Size(514, 244);
            this.lstTribonacci.TabIndex = 3;
            // 
            // btnGenerate1
            // 
            this.btnGenerate1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnGenerate1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGenerate1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnGenerate1.Location = new System.Drawing.Point(183, 52);
            this.btnGenerate1.Name = "btnGenerate1";
            this.btnGenerate1.Size = new System.Drawing.Size(152, 32);
            this.btnGenerate1.TabIndex = 2;
            this.btnGenerate1.Text = "Сгенерировать";
            this.btnGenerate1.UseVisualStyleBackColor = false;
            this.btnGenerate1.Click += new System.EventHandler(this.btnGenerate1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox1.Location = new System.Drawing.Point(292, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(43, 26);
            this.textBox1.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(179, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Введите N:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.Fibonacci);
            this.tabPage2.Controls.Add(this.Tribinacci);
            this.tabPage2.Controls.Add(this.lstTribonacci1);
            this.tabPage2.Controls.Add(this.lstFibonacci);
            this.tabPage2.Controls.Add(this.btnCompare);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(510, 349);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Сравнение";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Fibonacci
            // 
            this.Fibonacci.AutoSize = true;
            this.Fibonacci.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Fibonacci.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Fibonacci.Location = new System.Drawing.Point(346, 99);
            this.Fibonacci.Name = "Fibonacci";
            this.Fibonacci.Size = new System.Drawing.Size(105, 20);
            this.Fibonacci.TabIndex = 7;
            this.Fibonacci.Text = "Фибоначчи";
            // 
            // Tribinacci
            // 
            this.Tribinacci.AutoSize = true;
            this.Tribinacci.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Tribinacci.ForeColor = System.Drawing.SystemColors.Highlight;
            this.Tribinacci.Location = new System.Drawing.Point(37, 99);
            this.Tribinacci.Name = "Tribinacci";
            this.Tribinacci.Size = new System.Drawing.Size(114, 20);
            this.Tribinacci.TabIndex = 6;
            this.Tribinacci.Text = "Трибоначчи ";
            // 
            // lstTribonacci1
            // 
            this.lstTribonacci1.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lstTribonacci1.FormattingEnabled = true;
            this.lstTribonacci1.ItemHeight = 15;
            this.lstTribonacci1.Location = new System.Drawing.Point(0, 125);
            this.lstTribonacci1.Name = "lstTribonacci1";
            this.lstTribonacci1.Size = new System.Drawing.Size(249, 214);
            this.lstTribonacci1.TabIndex = 5;
            // 
            // lstFibonacci
            // 
            this.lstFibonacci.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lstFibonacci.FormattingEnabled = true;
            this.lstFibonacci.ItemHeight = 15;
            this.lstFibonacci.Location = new System.Drawing.Point(265, 125);
            this.lstFibonacci.Name = "lstFibonacci";
            this.lstFibonacci.Size = new System.Drawing.Size(249, 214);
            this.lstFibonacci.TabIndex = 4;
            // 
            // btnCompare
            // 
            this.btnCompare.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCompare.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompare.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCompare.Location = new System.Drawing.Point(183, 52);
            this.btnCompare.Name = "btnCompare";
            this.btnCompare.Size = new System.Drawing.Size(152, 32);
            this.btnCompare.TabIndex = 2;
            this.btnCompare.Text = "Сравнить";
            this.btnCompare.UseVisualStyleBackColor = false;
            this.btnCompare.Click += new System.EventHandler(this.btnCompare_Click);
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox2.Location = new System.Drawing.Point(292, 15);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(43, 26);
            this.textBox2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(179, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Введите N:";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.picGraph);
            this.tabPage3.Controls.Add(this.btnPlot);
            this.tabPage3.Controls.Add(this.textBox3);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(510, 349);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Графики";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // picGraph
            // 
            this.picGraph.BackColor = System.Drawing.Color.White;
            this.picGraph.Location = new System.Drawing.Point(0, 99);
            this.picGraph.Name = "picGraph";
            this.picGraph.Size = new System.Drawing.Size(514, 250);
            this.picGraph.TabIndex = 3;
            this.picGraph.TabStop = false;
            this.picGraph.Paint += new System.Windows.Forms.PaintEventHandler(this.picGraph_Paint_1);
            // 
            // btnPlot
            // 
            this.btnPlot.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnPlot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlot.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPlot.Location = new System.Drawing.Point(183, 52);
            this.btnPlot.Name = "btnPlot";
            this.btnPlot.Size = new System.Drawing.Size(152, 32);
            this.btnPlot.TabIndex = 2;
            this.btnPlot.Text = "Построить";
            this.btnPlot.UseVisualStyleBackColor = false;
            this.btnPlot.Click += new System.EventHandler(this.btnPlot_Click);
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.textBox3.Location = new System.Drawing.Point(292, 15);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(43, 26);
            this.textBox3.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(179, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Введите N:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(518, 375);
            this.Controls.Add(this.tabControl);
            this.Name = "Form1";
            this.Text = "Lab02";
            this.tabControl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picGraph)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnGenerate1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.ListBox lstTribonacci;
        private System.Windows.Forms.Button btnCompare;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picGraph;
        private System.Windows.Forms.Button btnPlot;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label Fibonacci;
        private System.Windows.Forms.Label Tribinacci;
        private System.Windows.Forms.ListBox lstTribonacci1;
        private System.Windows.Forms.ListBox lstFibonacci;
    }
}

