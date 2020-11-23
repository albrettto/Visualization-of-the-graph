using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Visualization_of_the_graph
{
    public partial class Main_Form : Form
    {
        public Main_Form()
        {
            InitializeComponent();
        }
        struct Circle
        { //структура Круг (координаты центра круга и радиус)
            public int x;
            public int y;
            public int rad;
        }

        Circle[] koortoch = new Circle[50]; //массив точек
        int n = 0; //счетчик текущей вершины
        int versh = -1; //понадобиться нам для обработки различных ситуаций при нажатии мыши
        bool check = false;//проверка для заполнения первых 2 столбцов
        private void Canvas_Panel_MouseDown(object sender, MouseEventArgs e)
        {
            Pen pen_default = new Pen(Color.MediumBlue, 3); //карандаш для круга по умолчанию
            Pen pen_selected = new Pen(Color.Red, 3); //карандаш для выбранного круга
            Pen pen_for_line = new Pen(Color.GhostWhite, 2); //карандаш для соединительных линий
            if (e.Button == MouseButtons.Right) //если нажата правая кнопка мыши
            {
                koortoch[n].rad = 15;
                koortoch[n].x = e.X - koortoch[n].rad;
                koortoch[n].y = e.Y - koortoch[n].rad;
                Canvas_Panel.CreateGraphics().DrawEllipse(pen_default, koortoch[n].x, koortoch[n].y, 
                    koortoch[n].rad * 2, koortoch[n].rad * 2); //рисуем круг
                {
                    //данные необходимые для рисования соединительных линий
                    String drawString = (n + 1).ToString();
                    Font drawFont = new Font("Arial", 14);
                    SolidBrush drawBrush = new SolidBrush(Color.DarkBlue);
                    PointF drawPoint = new PointF(koortoch[n].x + koortoch[n].rad / 2, koortoch[n].y + koortoch[n].rad / 2);
                    //выводим цифру внутри вершины
                    Canvas_Panel.CreateGraphics().DrawString(drawString, drawFont, drawBrush, drawPoint); 
                }
                n++; //увеличиваем счётчик вершины

                if (check == false)
                {
                    var column1 = new DataGridViewColumn();//"специальный" певрый столбец
                    column1.HeaderText = "0"; //текст в шапке
                    column1.ReadOnly = true; //значение в этой колонке нельзя править
                    column1.Name = "0"; //текстовое имя колонки, его можно использовать вместо обращений по индексу
                    column1.CellTemplate = new DataGridViewTextBoxCell();
                    column1.DefaultCellStyle.BackColor = Color.White;//цвет фона
                    column1.DefaultCellStyle.ForeColor = Color.Black;//цвет текста
                    Matrica_DataGridView.Columns.Add(column1);//добавляем стобец
                    //добавляем следующий столбец
                    Matrica_DataGridView.Columns.Add("1", "1");
                    Matrica_DataGridView[0, 0].Value = 1;
                    check = true;
                }
                else
                {
                    //добавляем строку и столбец
                    for (int i = n; i < n + 1; ++i)
                    {
                        Matrica_DataGridView.Columns.Add(i.ToString(), i.ToString());
                        Matrica_DataGridView.Rows.Add();
                    }
                    //заполняем самый первый столбец порядковыми чсилами
                    for (int i = 0; i < n; ++i)
                        Matrica_DataGridView[0, i].Value = i + 1;
                }
            }
            if (e.Button == MouseButtons.Left) //если нажата левая кнопка мыши
            {
                if (versh == -1)//если пока не запомнили ни одну из вершин
                {
                    for (int i = 0; i < n; i++) //проверяем попал ли щелчок мыши на какую-то из вершин
                        if (e.X - koortoch[i].rad <= koortoch[i].x + koortoch[i].rad &&
                            e.X - koortoch[i].rad >= koortoch[i].x - koortoch[i].rad &&
                            e.Y - koortoch[i].rad <= koortoch[i].y + koortoch[i].rad &&
                            e.Y - koortoch[i].rad >= koortoch[i].y - koortoch[i].rad)
                        {
                            versh = i;//если попали, то запоминаем вершину по которой щелкнули
                            Canvas_Panel.CreateGraphics().DrawEllipse(pen_selected, koortoch[i].x, koortoch[i].y,
                    koortoch[i].rad * 2, koortoch[i].rad * 2); //выделяем круг
                            break;//выходим из цикла
                        }
                }
                else //если по одной из вершин уже раннее щелкнули(запомнили), то
                {
                    int toversh = -1;
                    for (int i = 0; i < n; i++) //проверяем попал ли щелчок мыши на какую-то из вершин
                        if (e.X - koortoch[i].rad <= koortoch[i].x + koortoch[i].rad &&
                            e.X - koortoch[i].rad >= koortoch[i].x - koortoch[i].rad &&
                            e.Y - koortoch[i].rad <= koortoch[i].y + koortoch[i].rad &&
                            e.Y - koortoch[i].rad >= koortoch[i].y - koortoch[i].rad)
                        {
                            toversh = i;//если попали, то запоминаем вершину по которой щелкнули
                            //выделяем круг
                            Canvas_Panel.CreateGraphics().DrawEllipse(pen_selected, koortoch[i].x, koortoch[i].y,
                    koortoch[i].rad * 2, koortoch[i].rad * 2);
                            break;//выходим из цикла
                        }
                    if ((toversh != -1) && (versh != toversh))//если щелкнули сначала по одной, а потом по другой вершине
                    {
                        //центр первой выделенной вершины
                        Point p1 = new Point(koortoch[versh].x + koortoch[versh].rad , 
                            koortoch[versh].y + koortoch[versh].rad );
                        //центр второй выделенной вершины
                        Point p2 = new Point(koortoch[toversh].x + koortoch[toversh].rad , 
                            koortoch[toversh].y + koortoch[toversh].rad );
                        //рисуем соединительную линию
                        Canvas_Panel.CreateGraphics().DrawLine(pen_for_line, p1, p2);
                        //отмечаем в мартрице смежностей пути
                        Matrica_DataGridView[versh + 1 , toversh ].Value = 1;
                        Matrica_DataGridView[toversh + 1, versh ].Value = 1;
                        //возвращаем круги в состояние по умолчанию
                        Canvas_Panel.CreateGraphics().DrawEllipse(pen_default, koortoch[versh].x, koortoch[versh].y,
                    koortoch[versh].rad * 2, koortoch[versh].rad * 2);
                        Canvas_Panel.CreateGraphics().DrawEllipse(pen_default, koortoch[toversh].x, koortoch[toversh].y,
                    koortoch[toversh].rad * 2, koortoch[toversh].rad * 2);
                        versh = -1;//сбрасываем значение для дальнейшей работы
                    }
                }
            }
        }

        public void BFS(int start)
        {//Поиск в ширину(Breadth first search)
            List<int> list = new List<int>();//marks
            Queue<int> q = new Queue<int>();//path 
            list.Add(start);//добавляем в список стартовую позицию
            for (int i = 0; i < n; ++i)//добавляем в очередь все смежные пути
                if (Matrica_DataGridView[start, i].Value != null)
                    q.Enqueue(i+1);
        repeat:
            while (q.Count != 0)//пока очередь не пуста
            {
                int v = q.Peek();//считываем первое число из очереди
                q.Dequeue();//убираем из очереди первое число
                foreach (int i in list)//если элемент уже есть в списке, то идем к следующему
                    if (i == v)
                        goto repeat;
                list.Add(v);//иначе добавляем это число в список
                for (int i = 0; i < n; ++i)
                    if (Matrica_DataGridView[v, i].Value != null)
                        q.Enqueue(i+1);
            }
            //Result_TextBox.Text = "";//обнуляем текстбокс
            foreach (int i in list)//вывод результата
                Result_TextBox.Text += i.ToString() + " ";
        }

        private void Search_Button_Click(object sender, EventArgs e)
        {
            //считываем из ТекстБокса начальную вершину
            int start = Convert.ToInt32(Numb_TextBox.Text);
            BFS(start);
        }

        private void Clear_Button_Click(object sender, EventArgs e)
        {
            Canvas_Panel.Refresh();//обновляем панель
            n = 0;
            check = false;
            Matrica_DataGridView.Rows.Clear();//удаление всех строк
            Matrica_DataGridView.Columns.Clear();//удаление всех столбцов
            versh = -1;
            Result_TextBox.Text = "";
        }
    }
}
