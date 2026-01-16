namespace Tyuiu.RadkoVO.Sprint6.Task1.V22
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            groupBox1 = new GroupBox();
            labelCond_RVO = new Label();
            groupBox2 = new GroupBox();
            label3 = new Label();
            label2 = new Label();
            textBoxStartStep_RVO = new TextBox();
            textBoxStopStep_RVO = new TextBox();
            groupBox3 = new GroupBox();
            label4 = new Label();
            textBoxResult_RVO = new TextBox();
            buttonHelp_RVO = new Button();
            buttonDone_RVO = new Button();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(labelCond_RVO);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(789, 370);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // labelCond_RVO
            // 
            labelCond_RVO.AutoSize = true;
            labelCond_RVO.Location = new Point(6, 27);
            labelCond_RVO.Name = "labelCond_RVO";
            labelCond_RVO.Size = new Size(717, 25);
            labelCond_RVO.TabIndex = 2;
            labelCond_RVO.Text = "Протабулировать функцию в заданом диапозоне. Результат вывести в виде таблицы.";
            labelCond_RVO.Click += labelCond_RVO_Click;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(textBoxStartStep_RVO);
            groupBox2.Controls.Add(textBoxStopStep_RVO);
            groupBox2.Location = new Point(12, 388);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(420, 150);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "ввод данных";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(207, 43);
            label3.Name = "label3";
            label3.Size = new Size(111, 25);
            label3.TabIndex = 2;
            label3.Text = "Конец шага:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 43);
            label2.Name = "label2";
            label2.Size = new Size(105, 25);
            label2.TabIndex = 0;
            label2.Text = "Старт шага:";
            // 
            // textBoxStartStep_RVO
            // 
            textBoxStartStep_RVO.Location = new Point(6, 95);
            textBoxStartStep_RVO.Name = "textBoxStartStep_RVO";
            textBoxStartStep_RVO.Size = new Size(176, 31);
            textBoxStartStep_RVO.TabIndex = 1;
            // 
            // textBoxStopStep_RVO
            // 
            textBoxStopStep_RVO.Location = new Point(207, 95);
            textBoxStopStep_RVO.Name = "textBoxStopStep_RVO";
            textBoxStopStep_RVO.Size = new Size(183, 31);
            textBoxStopStep_RVO.TabIndex = 0;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(label4);
            groupBox3.Controls.Add(textBoxResult_RVO);
            groupBox3.Location = new Point(807, 12);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(318, 526);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "вывод данных";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 27);
            label4.Name = "label4";
            label4.Size = new Size(89, 25);
            label4.TabIndex = 1;
            label4.Text = "Результат";
            // 
            // textBoxResult_RVO
            // 
            textBoxResult_RVO.Font = new Font("Courier New", 8.25F);
            textBoxResult_RVO.Location = new Point(6, 68);
            textBoxResult_RVO.Multiline = true;
            textBoxResult_RVO.Name = "textBoxResult_RVO";
            textBoxResult_RVO.ScrollBars = ScrollBars.Vertical;
            textBoxResult_RVO.Size = new Size(306, 434);
            textBoxResult_RVO.TabIndex = 0;
            // 
            // buttonHelp_RVO
            // 
            buttonHelp_RVO.BackColor = SystemColors.ActiveCaption;
            buttonHelp_RVO.Location = new Point(438, 400);
            buttonHelp_RVO.Name = "buttonHelp_RVO";
            buttonHelp_RVO.Size = new Size(223, 138);
            buttonHelp_RVO.TabIndex = 3;
            buttonHelp_RVO.Text = "Справка";
            buttonHelp_RVO.UseVisualStyleBackColor = false;
            buttonHelp_RVO.Click += buttonHelp_RVO_Click;
            // 
            // buttonDone_RVO
            // 
            buttonDone_RVO.BackColor = Color.DarkGreen;
            buttonDone_RVO.Location = new Point(667, 400);
            buttonDone_RVO.Name = "buttonDone_RVO";
            buttonDone_RVO.Size = new Size(134, 138);
            buttonDone_RVO.TabIndex = 4;
            buttonDone_RVO.Text = "Выполнить";
            buttonDone_RVO.UseVisualStyleBackColor = false;
            buttonDone_RVO.Click += buttonDone_RVO_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1137, 550);
            Controls.Add(buttonDone_RVO);
            Controls.Add(buttonHelp_RVO);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 1 | Вариант 22 | Радько В. О.";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox textBoxStartStep_RVO;
        private TextBox textBoxStopStep_RVO;
        private TextBox textBoxResult_RVO;
        private Button buttonHelp_RVO;
        private Button buttonDone_RVO;
        private Label labelCond_RVO;
        private Label label3;
        private Label label2;
        private Label label4;
    }
}
