using Tyuiu.RadkoVO.Sprint6.Task0.V6.Lib;

namespace Tyuiu.RadkoVO.Sprint6.Task0.V6
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonCalc_RVO_Click(object sender, EventArgs e)
        {
            // Ваш DataService должен быть доступен
            DataService ds = new DataService();

            try
            {
                int x = Convert.ToInt32(textBoxVarX_RVO.Text);
                textBoxResult_RVO.Text = Convert.ToString(ds.Calculate(x));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные!", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void textBoxVarX_RVO_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Разрешаем: цифры, Backspace (8), минус
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != '-')
            {
                e.Handled = true;
            }
        }

        private void buttonHelp_RVO_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполняла студентка группы СМАРТ6-25-1 Радько Варвара Олеговна",
                "Сообщения", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            // Пустой обработчик - можно оставить или удалить
        }
    }
}
