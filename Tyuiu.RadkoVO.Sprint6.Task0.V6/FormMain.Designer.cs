namespace Tyuiu.RadkoVO.Sprint6.Task0.V6
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBox1 = new GroupBox();
            pictureBox1 = new PictureBox();
            groupBox2 = new GroupBox();
            textBoxVarX_RVO = new TextBox();
            groupBox3 = new GroupBox();
            textBoxResult_RVO = new TextBox();
            buttonHelp_RVO = new Button();
            buttonCalc_RVO = new Button();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            groupBox2.SuspendLayout();
            groupBox3.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(pictureBox1);
            groupBox1.Location = new Point(12, 12);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 302);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Условие";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(531, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(239, 105);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(textBoxVarX_RVO);
            groupBox2.Location = new Point(12, 320);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(522, 118);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            groupBox2.Text = "Ввод данных";
            // 
            // textBoxVarX_RVO
            // 
            textBoxVarX_RVO.Location = new Point(6, 71);
            textBoxVarX_RVO.Name = "textBoxVarX_RVO";
            textBoxVarX_RVO.Size = new Size(150, 31);
            textBoxVarX_RVO.TabIndex = 0;
            textBoxVarX_RVO.KeyPress += textBoxVarX_RVO_KeyPress;
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(textBoxResult_RVO);
            groupBox3.Controls.Add(buttonHelp_RVO);
            groupBox3.Controls.Add(buttonCalc_RVO);
            groupBox3.Location = new Point(543, 320);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(245, 118);
            groupBox3.TabIndex = 2;
            groupBox3.TabStop = false;
            groupBox3.Text = "Вывод данных";
            // 
            // textBoxResult_RVO
            // 
            textBoxResult_RVO.Location = new Point(6, 30);
            textBoxResult_RVO.Name = "textBoxResult_RVO";
            textBoxResult_RVO.Size = new Size(198, 31);
            textBoxResult_RVO.TabIndex = 0;
            // 
            // buttonHelp_RVO
            // 
            buttonHelp_RVO.Location = new Point(127, 78);
            buttonHelp_RVO.Name = "buttonHelp_RVO";
            buttonHelp_RVO.Size = new Size(112, 34);
            buttonHelp_RVO.TabIndex = 2;
            buttonHelp_RVO.Text = "button2";
            buttonHelp_RVO.UseVisualStyleBackColor = true;
            buttonHelp_RVO.Click += buttonHelp_RVO_Click;
            // 
            // buttonCalc_RVO
            // 
            buttonCalc_RVO.Location = new Point(6, 78);
            buttonCalc_RVO.Name = "buttonCalc_RVO";
            buttonCalc_RVO.Size = new Size(112, 34);
            buttonCalc_RVO.TabIndex = 1;
            buttonCalc_RVO.Text = "button1";
            buttonCalc_RVO.UseVisualStyleBackColor = true;
            buttonCalc_RVO.Click += buttonCalc_RVO_Click;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBox3);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "FormMain";
            Text = "FormMain";
            groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox3.ResumeLayout(false);
            groupBox3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private PictureBox pictureBox1;
        private GroupBox groupBox2;
        private GroupBox groupBox3;
        private TextBox textBoxVarX_RVO;
        private TextBox textBoxResult_RVO;
        private Button buttonHelp_RVO;
        private Button buttonCalc_RVO;
    }
}
