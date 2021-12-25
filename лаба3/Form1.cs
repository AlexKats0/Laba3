using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace лаба3
{
    public partial class Form1 : Form
    { 
        //объявление листа
        List<MyShape> shapes;
        public Form1()
        {
            InitializeComponent();
            shapes = new List<MyShape>();
        }
        //очистка полей и пикчер бокса
        private void Clear()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            pictureBox1.Image = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Color color1 = Color.Green;
            int x, y, l;
            x = Convert.ToInt32(textBox1.Text);
            y = Convert.ToInt32(textBox2.Text);
            l = Convert.ToInt32(textBox3.Text);
            MyShape triangle;
            MyShape angl;

            //обработка ошибок
            if (!int.TryParse(textBox1.Text, out x) || x <0 || x - l < 0 || x >500)//опрацьовуємо помилки
{
                MessageBox.Show("Проверьте данные!Ошибка ввода");
                Clear();
                return;
            }
            if (!int.TryParse(textBox2.Text, out y) || y <0 || y - l < 0 || y > 300)
{
                MessageBox.Show("Проверьте данные! Ошибка ввода");
                Clear();
                return;
            }
            if (!int.TryParse(textBox3.Text, out l) || l <0)
{
                MessageBox.Show("Проверьте данные! Ошибка ввода");
                Clear();
                return;
            }
            
            switch (comboBox1.Text)
            {
                case "Треугольник":
                    triangle = new MyTriangle(x, y, l);
                    triangle.Draw(pictureBox1);
                    shapes.Add(new MyTriangle ( x, y ,l ));
                    break;
                case "Шестиугольник":
                    angl = new MyAngles(x, y, l);
                    angl.Draw(pictureBox1);
                    shapes.Add(new MyAngles ( x, y, l));
                    break;
                default:
                    break;
            }

            listBox1.Items.Clear();

            foreach (var shape in shapes)
            {
                listBox1.Items.Add(shape.ToString());
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //удаление одного елемента из лист бокса
            /* if (listBox1.SelectedIndex >= 0)
             {
                 shapes.RemoveAt(listBox1.SelectedIndex);
                 listBox1.Items.RemoveAt(listBox1.SelectedIndex);
                 pictureBox1.Image = null;
             }*/
            // удаление всех найденых елементов

            pictureBox1.Image = null;

            for (int i = listBox1.SelectedIndices.Count - 1; i >= 0; i--)
            {
                shapes.RemoveAt(listBox1.SelectedIndices[i]);
                listBox1.Items.RemoveAt(listBox1.SelectedIndices[i]);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox1.SelectedItems.Clear();
            //поиск
            for(int i = listBox1.Items.Count - 1;i>=0;i--) 
            {
                if (listBox1.Items[i].ToString().ToLower().Contains(textBox4.Text))
                {
                    listBox1.SetSelected(i,true);
                }
            }

            label5.Text = listBox1.SelectedItem.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Color color1 = Color.Green;
            //перерисовка фигур из листа
            for (int index = 0; index < shapes.Count; index++)
            {
                shapes[index].Draw(pictureBox1);
            }
        }
    }
    }
