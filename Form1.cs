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
             ������� 1
������� �� ����� ���� (�������!!!) ������ � ������� ������������������MessageBox��� (������������� ����).�������� ��������� 
�������������������������������������������������� �������� 
(����� ���������� �������� � ������ / ���������� MessageBox���).
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
            /*������� 2
�������� �������, ������� ���������� ���������� ������������� ����� �� 1 �� 2000. ��� ������� � ������������ ������������ 
MessageBox. ����� ����, ��� ����� ��������, ���������� ������� 
���������� ��������, ��������������� ��� �����, � ������������ 
������������ ����������� ������� ��� ���, �� ������ �� ��������� 
(MessageBox�� ����������� �������� � �������� �������������� 
��������).*/
            for (int i = 1; i < 2000; i++)
            {
                DialogResult result = MessageBox.Show($"�� �������� ����� ({i})?", "��������", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    MessageBox.Show($"���, ��� ����������� ������� ����� {i} �������");
                    return;
                }
            }
            MessageBox.Show("� ��������� ����� ������ �� 2000.\n �� ���� ��� ���������� ��");
        }
    }
}