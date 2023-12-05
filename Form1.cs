using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class Form1 : Form
    {
        Font font;
        SolidBrush brush;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //шрифт берем установленный по умолчанию
            font = fontDialog1.Font;
            //создаем сплошную кисть черного цвета
            brush = new SolidBrush(Color.Black);
            DrawGraph(pictureBox1);
            pictureBox1.Invalidate();
        }
        private double f(double x)
        {
            
            return (Math.Pow(Math.Sin(x), 2) * ((x - (2 / (x - 2))) / (1 + Math.Pow(1 + x, 2))));

        }
        private void DrawGraph(PictureBox pb)
        {
          
            //Отступы от краёв
            int x0 = 15;
            int y0 = (int)(pictureBox1.Height * 0.85);

            double ymin = (double)(this.ymin.Value); 
            double ymax = (double)(this.ymax.Value);
            double xmin = (double)(this.xmin.Value);
            double xmax = (double)(this.xmax.Value);
            //Длина оси X
            int Mx = pictureBox1.Width - 2 * x0;
            //Длина оси Y
            int My = -y0 + 10;

            //Число точек графика			
            int M = (int)pointsEdit.Value;

            //Создание графического объекта
            Graphics G = pictureBox1.CreateGraphics();
            //Очистка PictureBox1
            G.Clear(Color.White);

            //Описание и создание массива точек		 
            PointF[] p = new PointF[M];
            
            //Шаг построения графика
            double step = 0.1;
            int i=0;
            //Цикл: от минимального икса до шага*количесво точек
            for (double n = (double)this.xmin.Value; n < (double)this.xmin.Value+M*step; n+=step)
            {
                //Физические координаты
                double x = n ;
                double y = f(x);

                //Экранные координаты
                float xi = (float)(getPlotX(x)+x0);
                float yi = (float)(y0-((y - ymin) / (ymax - ymin)* y0));

                //заносим в массив вычисленные значения координат
                p[i++] = new PointF(xi, yi);
            }
            //коэффициент упругости графика
            float tension = (float)tensionEdit.Value;
            
                //рисование графика
                G.DrawCurve(Pens.Green, p, tension);
            
            
            
            //Рисование оси Х
            G.DrawLine(Pens.Black, x0, y0, x0 + Mx, y0);
            //Рисование оси Y
            G.DrawLine(Pens.Black, x0, y0, x0, y0 + My);

            //Разметка оси Х
            for (double n = 0; n < (xmax-xmin)/0.1; n++)
            {
                //физическая координата штриха
                double x = n / ((xmax - xmin) / 0.1);
                //экранная координата штриха
                int xi = (int)(x0 + Mx * x);
                //Наносим штрих
                G.DrawLine(Pens.Black, xi, y0, xi, y0 + 4);
                //Наносим число
                G.DrawString((xmin+n*0.1).ToString(), font, brush, xi - 9, y0 + 4);
            }
            //Разметка оси Y
            for (double n = 0; n < (ymax - ymin) ; n++)
            {
                //порядковый номер палочки
                double y = n / (ymax-ymin);
                //экранная координата, y0 - высота окна с графиком за вычетом отступа
                int yi = y0-(int)(y*y0);
                //Палочка, размером в 4 пикселя
                G.DrawLine(Pens.Black, x0, yi, x0+4, yi);
                //Пишем число справа от палочки на 4 пикселя, немного поднимаем на высоту шрифта,чтобы выровнять с палочками
                G.DrawString((ymin + n).ToString(), font, brush, x0+4 , yi-font.Height );
            }


        }
        double getPlotX(double x) 
        {//возвращаем координату икса для picturebox
            return ((x - ((double)xmin.Value)) / (double)(xmax.Value - xmin.Value) * pictureBox1.Width); 
                }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            DrawGraph(pictureBox1);
        }

        private void pictureBox1_Paint(object sender, EventArgs e)
        {
            DrawGraph(pictureBox1);
        }
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                //получить параметры шрифта из диалогового окна 
                font = fontDialog1.Font;
                //получить цвет шрифта из того же окна
                brush.Color = fontDialog1.Color;
            }
        }
    }
}
