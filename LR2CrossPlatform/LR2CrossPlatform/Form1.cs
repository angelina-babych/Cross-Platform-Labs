using System.Drawing;
using System.Runtime.ConstrainedExecution;
using System;
using Microsoft.VisualBasic;
using System.Collections;
using System.Windows.Forms;

namespace LR2CrossPlatform
{
    public partial class LR2Form : Form
    {
        public LR2Form()
        {
            InitializeComponent();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            int intervals_value = (int)intervals.Value;
            int step_value = (int)step.Value;
            int first = 1;
            int last = 1;
            RadioButton rb;

            intervalsPanel.Controls.Clear();
            allNumbers.Items.Clear();
            primeNumbers.Items.Clear();
            statusLabel.Text = "Сума обраних елементів: ";
            sumStatusLabel.Text = "0";

            RadioButton[] intervalsRb = new RadioButton[intervals_value];
            for (int i = 0; i < intervals_value; i++)
            {
                last = first + step_value;
                string s = $"{Convert.ToString(first)}-{Convert.ToString(last)}";
                first = last;

                rb = new RadioButton();
                rb.Text = s;
                rb.AutoSize = true;
                rb.Top = i * rb.Height;
                rb.Anchor = AnchorStyles.Top | AnchorStyles.Bottom
                   | AnchorStyles.Left | AnchorStyles.Right;
                intervalsRb[i] = rb;

                intervalsPanel.Controls.Add(intervalsRb[i]);
                intervalsPanel.Controls[i].Click += rbClick;
            }
        }

        private void rbClick(object? sender, EventArgs e)
        {
            string s = ((RadioButton)sender).Text;
            string[] nums = s.Split('-');
            int first = Convert.ToInt32(nums[0]);
            int last = Convert.ToInt32(nums[1]);

            allNumbers.Items.Clear();
            primeNumbers.Items.Clear();
            for (int i = first; i <= last; i++)
            {
                allNumbers.Items.Add(i);
            }
            int ctr;
            for (int i = first; i <= last; i++)
            {
                ctr = 0;

                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                    {
                        ctr++;
                        break;
                    }
                }

                if (ctr == 0 && i != 1)
                    primeNumbers.Items.Add(i);
            }
        }

        private void allNumbers_Click(object sender, EventArgs e)
        {
            int sum = 0;
            foreach (object item in ((CheckedListBox)sender).CheckedItems)
                sum = sum + Convert.ToInt32(item.ToString());
            sumStatusLabel.Text = sum.ToString();
            statusLabel.Text = "Сума обраних елементів: ";
        }

        private void allNumbers_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            allNumbers_Click(sender, e);
        }

        private void allNumbers_MouseDown(object sender, MouseEventArgs e)
        {
            allNumbers_Click(sender, e);
        }

        private void primeNumbers_MouseDown(object sender, MouseEventArgs e)
        {
            int sum = 0;
            foreach (object item in ((CheckedListBox)sender).CheckedItems)
                sum = sum + Convert.ToInt32(item.ToString());
            sumStatusLabel.Text = sum.ToString();
            statusLabel.Text = "Сума обраних простих чисел: ";
        }

        private void додатиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int res = 0;
            String? input = Interaction.InputBox("Введіть число:", "Введення");
            if (String.IsNullOrEmpty(input))
            {
                MessageBox.Show("Треба було щось ввести!", "Помилка вводу", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!Int32.TryParse(input, out res))
            {
                MessageBox.Show("Ви мали ввести число!", "Помилка вводу", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            allNumbers.Items.Add(res.ToString());
        }

        private void додатиNToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int res = 0;
            String? input = Interaction.InputBox("Введіть клька чисел через кому:", "Введення");
            if (String.IsNullOrEmpty(input))
            {
                MessageBox.Show("Треба було щось ввести!", "Помилка вводу", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string[] nums = input.Split(',');
            foreach (string s in nums)
            {
                if (!Int32.TryParse(s, out res))
                {
                    MessageBox.Show("Ви мали ввести числа через кому!", "Помилка вводу", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                allNumbers.Items.Add(res.ToString());
            }
        }

        private void видалитиFocusedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            for (int i = allNumbers.SelectedItems.Count - 1; i >= 0; i--)
                allNumbers.Items.Remove(allNumbers.SelectedItems[i]);

        }

        private void сумаВсіхЕлементівToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int sum = 0;
            foreach (object item in allNumbers.Items)
                sum = sum + Convert.ToInt32(item.ToString());
            MessageBox.Show($"Сума всіх чисел: {sum}", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void сумаCheckedЕлементівToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int sum = 0;
            foreach (object item in allNumbers.CheckedItems)
                sum = sum + Convert.ToInt32(item.ToString());
            MessageBox.Show($"Сума відмічених чисел: {sum}", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void сортуванняЗаЗростаннямToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<int> q = new List<int>();
            foreach (object o in allNumbers.Items)
                q.Add(Convert.ToInt32(o.ToString()));
            q.Sort();
            allNumbers.Items.Clear();
            foreach (int o in q)
            {
                allNumbers.Items.Add(o.ToString());
            }
        }

        private void сортуванняЗаСпаданнямToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<int> q = new List<int>();
            foreach (object o in allNumbers.Items)
                q.Add(Convert.ToInt32(o.ToString()));
            q = q.OrderByDescending(o => o).ToList();
            allNumbers.Items.Clear();
            foreach (int o in q)
            {
                allNumbers.Items.Add(o.ToString());
            }
        }

        private void максимальнеЗУсіхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<int> q = new List<int>();
            foreach (object o in allNumbers.Items)
                q.Add(Convert.ToInt32(o.ToString()));
            q.Sort();
            int max = q.Max();
            MessageBox.Show($"Найбільше з усіх чисел: {max}", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void мінімальнеЗУсіхToolStripMenuItem_Click(object sender, EventArgs e)
        {
            List<int> q = new List<int>();
            foreach (object o in allNumbers.Items)
                q.Add(Convert.ToInt32(o.ToString()));
            q.Sort();
            int max = q.Min();
            MessageBox.Show($"Найменше з усіх чисел: {max}", "Результат", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void простіЧислаЗіСвоїмиЗначеннямиCheckedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArrayList o = new ArrayList();
            foreach (object item in allNumbers.Items)
            {
                int num = Convert.ToInt32(item.ToString());
                foreach (object pitem in primeNumbers.Items)
                {                    
                    int pnum = Convert.ToInt32(pitem.ToString());
                    if (num == pnum)
                        o.Add(item);
                }
            }
            for (int i=0; i<primeNumbers.Items.Count;i++)
                primeNumbers.SetItemCheckState(i, CheckState.Checked);
            foreach (object item in o)
                allNumbers.SetItemCheckState(allNumbers.Items.IndexOf(item), CheckState.Checked);


        }
    }
}