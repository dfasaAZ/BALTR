using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grafik
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
//DrawGraph(pictureBox1);
        }
        private double f(double x)
        {
            return (Math.Pow(2, 3 * x) + Math.Pow(10, -x) * Math.Cos(x + Math.PI / 3)) / (x * Math.Sin(x));
           
        }
        private void DrawGraph(PictureBox pb)
        {
            Font font;
            SolidBrush brush;
            //шрифт берем установленный по умолчанию
            font = fontDialog1.Font;
            //создаем сплошную кисть черного цвета
            brush = new SolidBrush(Color.Black);
            //если выбор шрифта завершен нажатием кнопки OK
            //if (fontDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    //получить параметры шрифта из диалогового окна 
            //    font = fontDialog1.Font;
            //    //получить цвет шрифта из того же окна
            //    brush.Color = fontDialog1.Color;
            //}


            //Начало координат графика
            int x0 = 15;
            int y0 = (int)(pictureBox1.Height * 0.85);
            double ymin = (double)(this.ymin.Value); ;
            double ymax = (double)(this.ymax.Value);
            double xmin = (double)(this.xmin.Value);
            double xmax = (double)(this.xmax.Value);
            //Масштаб по оси Х
            int Mx = pictureBox1.Width - 2 * x0;
            //Масштаб по оси Y
            int My = -y0 + 10;
            //Число точек графика			
            int M = (int)pointsEdit.Value;

            //Создание графического объекта
            Graphics G = pictureBox1.CreateGraphics();
            //Очистка PictureBox1
            G.Clear(Color.White);

            //Описание и создание массива точек		 
            Point[] p = new Point[M];
            //Цикл по числу точек графика
            double[] xm = new double[M];
            int i=0;
            for (int n = 12; n < M+12; n++)
            {
                //Физические координаты
                double x = (double)n / 10;
                xm[i]=x;
                double y = f(x);
                //Экранные координаты
                int xi = (int)(getPlotX(x)+x0);
                int yi = (int)(pictureBox1.Height-((y - ymin) / (ymax - ymin)* pictureBox1.Height))-(pictureBox1.Height-y0);
                //заносим в массив вычисленные значения координат
                p[i++] = new Point(xi, yi);
            }
            //коэффициент упругости графика
            float tensition = (float)tensionEdit.Value;

            //рисование графика
            G.DrawCurve(Pens.Blue, p, tensition);
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
        double getPlotY(double y)
        {
            return (pictureBox1.Height - ((y - (double)ymin.Value) / (double)(ymax.Value - ymin.Value) * pictureBox1.Height));
        }
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void pictureBox1_Paint(object sender, EventArgs e)
        {
            DrawGraph(pictureBox1);
        }
        private void DrawGraph1(PictureBox pb)
        {
            Font font;
            SolidBrush brush;
            //шрифт берем установленный по умолчанию
            font = fontDialog1.Font;
            //создаем сплошную кисть черного цвета
            brush = new SolidBrush(Color.Black);
            //если выбор шрифта завершен нажатием кнопки OK
            //if (fontDialog1.ShowDialog() == DialogResult.OK)
            //{
            //    //получить параметры шрифта из диалогового окна 
            //    font = fontDialog1.Font;
            //    //получить цвет шрифта из того же окна
            //    brush.Color = fontDialog1.Color;
            //}


            //Начало координат графика
            int x0 = 15;
            int y0 = (int)(pictureBox1.Height * 0.85);
            //Масштаб по оси Х
            int Mx = pictureBox1.Width - 2 * x0;
            //Масштаб по оси Y
            int My = -y0 + 10;
            //Число точек графика			
            int M = (int)pointsEdit.Value;

            //Создание графического объекта
            Graphics G = pictureBox1.CreateGraphics();
            //Очистка PictureBox1
            G.Clear(Color.White);

            //Описание и создание массива точек		 
            Point[] p = new Point[M];
            double[] u = new double[M];
            int i = 0;
            //Цикл по числу точек графика
            for (double n = 1.2; n < 2.2; n += 0.1)
            {
                //Физические координаты
                double x = (double)n;
                double y = f(x);
                u[i] = y;
                //Экранные координаты
                int xi = (int)(x0 + Mx / 10 * i);
                int yi = (int)(y0 + My * y);
                //заносим в массив вычисленные значения координат
                p[i++] = new Point(xi, yi);

            }
            //коэффициент упругости графика
            float tensition = (float)tensionEdit.Value;

            //рисование графика
            G.DrawCurve(Pens.Blue, p, tensition);
            //Рисование оси Х
            G.DrawLine(Pens.Black, x0, y0, x0 + Mx, y0);
            //Рисование оси Y
            G.DrawLine(Pens.Black, x0, y0, x0, y0 + My);

            //Разметка оси Х
            for (int n = 0; n <= 10; n++)
            {
                //физическая координата штриха
                double x = n / 10.0;
                //экранная координата штриха
                int xi = (int)(x0 + Mx * x);
                //Наносим штрих
                G.DrawLine(Pens.Black, xi, y0, xi, y0 + 4);
                //Наносим число
                G.DrawString(x.ToString(), font, brush, xi - 9, y0 + 4);
            }


        }
    }
}
