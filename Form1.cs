﻿using System;
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
        {
            public int x;
            public int y;
            public int rad;
        }

        Circle[] koortoch = new Circle[50]; //массив точек
        int n = 0; //счетчик текущей вершины
        int versh = -1; //понадобиться нам для обработки различных ситуаций при нажатии мыши
        bool check = false;
    private void Canvas_Panel_MouseDown(object sender, MouseEventArgs e)
        {
            Pen pen_default = new Pen(Color.Azure, 2);
            Pen pen_selected = new Pen(Color.Red, 2);
            Pen pen_for_line = new Pen(Color.Azure, 2);
            pen_for_line.CustomEndCap = new AdjustableArrowCap(4.0F, 8.0F);
            pen_for_line.StartCap = LineCap.ArrowAnchor;
            if (e.Button == MouseButtons.Right) // Если нажата правая кнопка мыши
            {
                koortoch[n].rad = 15;
                koortoch[n].x = e.X - koortoch[n].rad;
                koortoch[n].y = e.Y - koortoch[n].rad;
                Canvas_Panel.CreateGraphics().DrawEllipse(pen_default, koortoch[n].x, koortoch[n].y, 
                    koortoch[n].rad * 2, koortoch[n].rad * 2);
                String drawString = (n+1).ToString();
                Font drawFont = new Font("Arial", 14);
                SolidBrush drawBrush = new SolidBrush(Color.Black);
                PointF drawPoint = new PointF(koortoch[n].x + koortoch[n].rad/2, koortoch[n].y + koortoch[n].rad/2);
                Canvas_Panel.CreateGraphics().DrawString(drawString, drawFont, drawBrush, drawPoint);
                n++;

                if (check == false)
                {
                    var column1 = new DataGridViewColumn();
                    for (int i = 0; i < 2; ++i)
                    {
                        if (i == 0)
                        {
                            column1.HeaderText = "0"; //текст в шапке
                            column1.ReadOnly = true; //значение в этой колонке нельзя править
                            column1.Name = "0"; //текстовое имя колонки, его можно использовать вместо обращений по индексу
                            column1.CellTemplate = new DataGridViewTextBoxCell();
                            column1.DefaultCellStyle.BackColor = Color.White;
                            column1.DefaultCellStyle.ForeColor = Color.Black;
                            Matrica_DataGridView.Columns.Add(column1);
                        }
                        else
                        {
                            Matrica_DataGridView.Columns.Add(i.ToString(), i.ToString());
                            Matrica_DataGridView[0, i - 1].Value = i;
                        }
                    }
                    check = true;
                }
                else
                {
                    for (int i = n; i < n + 1; ++i)
                    {
                        Matrica_DataGridView.Columns.Add(i.ToString(), i.ToString());
                        Matrica_DataGridView.Rows.Add();
                    }
                    for (int i = 0; i < n; ++i)
                        Matrica_DataGridView[0, i].Value = i + 1;
                }
            }
            if (e.Button == MouseButtons.Left) // Если нажата левая кнопка мыши
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
                    koortoch[i].rad * 2, koortoch[i].rad * 2);
                            break;
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
                            Canvas_Panel.CreateGraphics().DrawEllipse(pen_selected, koortoch[i].x, koortoch[i].y,
                    koortoch[i].rad * 2, koortoch[i].rad * 2);
                            break;
                        }
                    if ((toversh != -1) && (versh != toversh))//если щелкнули сначала по одной, а потом по другой вершине
                    {
                        Point p1 = new Point(koortoch[versh].x + koortoch[versh].rad , koortoch[versh].y + koortoch[versh].rad );
                        Point p2 = new Point(koortoch[toversh].x + koortoch[toversh].rad , koortoch[toversh].y + koortoch[toversh].rad );
                        Canvas_Panel.CreateGraphics().DrawLine(pen_for_line, p1, p2);
                        Matrica_DataGridView[versh + 1 , toversh ].Value = 1;
                        Matrica_DataGridView[toversh + 1, versh ].Value = 1;
                        Canvas_Panel.CreateGraphics().DrawEllipse(pen_default, koortoch[versh].x, koortoch[versh].y,
                    koortoch[versh].rad * 2, koortoch[versh].rad * 2);
                        Canvas_Panel.CreateGraphics().DrawEllipse(pen_default, koortoch[toversh].x, koortoch[toversh].y,
                    koortoch[toversh].rad * 2, koortoch[toversh].rad * 2);
                        versh = -1;
                    }
                }
            }
            Result_TextBox.Text = versh.ToString();
        }

        private void Search_Button_Click(object sender, EventArgs e)
        {
            int[][] g = new int[n][];
            for (int i = 0; i < n; i++)
            {
                g[i] = new int[n];
                for (int j = 0; j < n; j++)
                    g[i][j] = Convert.ToInt32(Matrica_DataGridView[j + 1, i].Value);
                g[i][i] = 0;
            }

            string result = "";
            bool[] used = new bool[n];
            Queue<int> Och = new Queue<int>();
            int u = Convert.ToInt32(Numb_TextBox.Text);
            used[u] = true;
            Och.Enqueue(u);
            result += u + " ";
            while (Och.Count != 0)
            {
                u = Och.Peek();
                //result += u + 1 + " ";
                Och.Dequeue();

                for (int i = 0; i < g.Length; i++)
                {
                    if (Convert.ToBoolean(g[u][i]))
                    {
                        if (!used[i])
                        {
                            used[i] = true;
                            Och.Enqueue(i);
                            result += i + " ";
                        }
                    }
                }
            }
            Result_TextBox.Text = result;
        }

        private void Clear_Button_Click(object sender, EventArgs e)
        {
            Canvas_Panel.Refresh();
            n = 0;
            check = false;
            Matrica_DataGridView.Rows.Clear();  // удаление всех строк
            int count = Matrica_DataGridView.Columns.Count;
            for (int i = 0; i < count; i++)     // цикл удаления всех столбцов
            {
                Matrica_DataGridView.Columns.RemoveAt(0);
            }
            versh = -1;
        }
    }
}