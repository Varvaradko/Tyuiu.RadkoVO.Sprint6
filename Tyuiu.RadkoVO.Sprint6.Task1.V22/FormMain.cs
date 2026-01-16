using Tyuiu.RadkoVO.Sprint6.Task1.V22.Lib;

namespace Tyuiu.RadkoVO.Sprint6.Task1.V22
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        DataService ds = new DataService();

        private void buttonDone_RVO_Click(object sender, EventArgs e)
        {
            try
            {
                int start = Convert.ToInt32(textBoxStartStep_RVO.Text);
                int stop = Convert.ToInt32(textBoxStopStep_RVO.Text);

                double[] arr = ds.GetMassFunction(start, stop);

                textBoxResult_RVO.Text = "";

                textBoxResult_RVO.AppendText("+-------+----------+" + Environment.NewLine);
                textBoxResult_RVO.AppendText("|   X   |   F(x)   |" + Environment.NewLine);
                textBoxResult_RVO.AppendText("+-------+----------+" + Environment.NewLine);

                int x = start;

                for (int i = 0; i < arr.Length; i++)
                {
                    string line = String.Format("|{0,7:D}|{1,10:F2}|", x, arr[i]);
                    textBoxResult_RVO.AppendText(line + Environment.NewLine);
                    x++;
                }

                textBoxResult_RVO.AppendText("+-------+----------+" + Environment.NewLine);
            }
            catch
            {
                MessageBox.Show("Ошибка: неверно введены данные!",
                                "Ошибка",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }

        // Кнопка "Справка"
        private void buttonHelp_RVO_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 1 выполнил студент группы СМАРТб-25-1 Радько Варвара Олеговна",
                            "Справка",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
        }

        private void labelCond_RVO_Click(object sender, EventArgs e)
        {
            // Ваш код обработки клика по метке
        }
    }
}
