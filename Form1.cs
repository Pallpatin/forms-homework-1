namespace first_task
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ResumeButton_Click(object sender, EventArgs e)
        {
            /*
             Задание 1
Вывести на экран свое (краткое!!!) резюме с помощью последовательностиMessageBox’ов (числомнеменее трех).Причемна заголовке 
последнегодолжноотобразитьсясреднеечислосимволовна странице 
(общее количество символов в резюме / количество MessageBox’ов).
            */
            string firsttext = "Name - Pavel\nSurname - Lopatin";
            string secondtext = "I can write code on C#";
            string thirdtext = $"count of symbols on each massage boxes was {(firsttext.Length + secondtext.Length) / 2}";
            MessageBox.Show(firsttext);
            MessageBox.Show(secondtext);
            MessageBox.Show(thirdtext);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*Задание 2
Написать функцию, которая «угадывает» задуманное пользователем число от 1 до 2000. Для запроса к пользователю использовать 
MessageBox. После того, как число отгадано, необходимо вывести 
количество запросов, потребовавшихся для этого, и предоставить 
пользователю возможность сыграть еще раз, не выходя из программы 
(MessageBox’ы оформляются кнопками и значками соответственно 
ситуации).*/
            for (int i = 1; i < 2000; i++)
            {
                DialogResult result = MessageBox.Show($"вы загадали число ({i})?", "угадайка", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show($"Ура, для отгадывания хватило всего {i} попыток");
                    return;
                }
            }
            MessageBox.Show("я отгадываю числа только до 2000.\n На этом мои полномочия всё");
        }
    }
}