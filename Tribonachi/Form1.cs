using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassLibrary;


namespace Tribonachi
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        // === ЗАДАНИЕ 1 ===
        private void btnGenerate1_Click(object sender, EventArgs e)
        {
            // Читаем число
            int n;
            if (!int.TryParse(textBox1.Text, out n))
            {
                MessageBox.Show("Введите целое число", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Вызываем метод библиотеки
            List<string> tribLines = Sequences.GenerateTribonacciStrings(n);

            // Выводим список
            lstTribonacci.Items.Clear();
            foreach (string s in tribLines)
                lstTribonacci.Items.Add(s);
        }

        // === ЗАДАНИЕ 2 ===
        private void btnCompare_Click(object sender, EventArgs e)
        {
            // Читаем число
            int n;
            if (!int.TryParse(textBox2.Text, out n))
            {
                MessageBox.Show("Введите целое число", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Вызываем два метода библиотеки
            List<string> fibLines = Sequences.GenerateFibonacciStrings(n);
            List<string> tribLines = Sequences.GenerateTribonacciStrings(n);

            // Выводим в два списка
            lstTribonacci1.Items.Clear();  
            foreach (string s in tribLines)
                lstTribonacci1.Items.Add(s);

            lstFibonacci.Items.Clear();
            foreach (string s in fibLines)
                lstFibonacci.Items.Add(s);
        }

        // === ЗАДАНИЕ 3 ===
        // Данные для графика
        private List<long> fibDataForGraph;
        private List<long> tribDataForGraph;

        private void btnPlot_Click(object sender, EventArgs e)
        {
            // Читаем число
            int n;
            if (!int.TryParse(textBox3.Text, out n))
            {
                MessageBox.Show("Введите целое число", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (n < 2)
            {
                MessageBox.Show("Для графика нужно как минимум 2 точки", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Генерируем последовательности (ЧИСЛА для графика)
            List<long> fib = Sequences.GenerateFibonacciNumbers(n);
            List<long> trib = Sequences.GenerateTribonacciNumbers(n);

            // Проверка на переполнение
            if (fib == null || trib == null)
            {
                MessageBox.Show("Слишком большое N — переполнение типа long.\nМаксимум ~70 элементов.\nРекомендуем около 10-15 элементов.",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            fibDataForGraph = fib;
            tribDataForGraph = trib;
            picGraph.Invalidate();

            // Сохраняем данные для перерисовки
            fibDataForGraph = fib;
            tribDataForGraph = trib;

            // Перерисовываем график
            picGraph.Invalidate();
        }

        private void picGraph_Paint_1(object sender, PaintEventArgs e)
        {
            // если ничего нет - ничего не рисует
            if (fibDataForGraph == null || tribDataForGraph == null)
                return;

            Graphics g = e.Graphics;
            Pen fibPen = new Pen(Color.Blue, 2f);
            Pen tribPen = new Pen(Color.Red, 2f);
            Pen linePen = new Pen(Color.Black, 2f);
            Brush brush = new SolidBrush(Color.Black);
            Brush fibBrush = new SolidBrush(Color.Blue);
            Brush tribBrush = new SolidBrush(Color.Red);
            int width = picGraph.Width;
            int height = picGraph.Height;
            int padding = 50;

            // Очищаем фон
            g.Clear(Color.White);

            // Рисуем оси
            g.DrawLine(linePen, padding, height - padding, width - padding, height - padding); // X
            g.DrawLine(linePen, padding, padding, padding, height - padding); // Y

            // Подписи осей
            g.DrawString("Член", new Font("Arial", 10), brush, width - 45, height - 40);
            g.DrawString("Значение", new Font("Arial", 10), brush, 10, 20);

            // Находим максимальное значение для масштаба
            long maxY = Math.Max(fibDataForGraph[fibDataForGraph.Count - 1],
                                tribDataForGraph[tribDataForGraph.Count - 1]);

            // Масштаб
            double scaleX = (width - 2 * padding) / (double)(fibDataForGraph.Count - 1);
            double scaleY = (height - 2 * padding) / (double)maxY;

            // Подпись "0" внизу оси Y
            g.DrawString("0", new Font("Arial", 9, FontStyle.Bold), brush, padding - 25, height - padding - 10);

            // Подпись середины оси Y
            long midY = maxY / 2;
            int yMidPos = height - padding - (int)((height - 2 * padding) * 0.5);
            g.DrawString(midY.ToString(), new Font("Arial", 9, FontStyle.Bold), brush, padding - 25, yMidPos - 10);

            // Подпись максимума вверху оси Y
            g.DrawString(maxY.ToString(), new Font("Arial", 9, FontStyle.Bold), brush, padding - 25, padding - 10);

            // Точки графиков
            PointF[] fibPoints = new PointF[fibDataForGraph.Count];
            PointF[] tribPoints = new PointF[tribDataForGraph.Count];

            // Рисуем точки
            for (int i = 0; i < fibDataForGraph.Count; i++)
            {
                // Координаты X (номер элемента)
                float x = (float)(padding + i * scaleX);

                // Координаты Y (значение элемента)
                float yFib = (float)(height - padding - fibDataForGraph[i] * scaleY);
                float yTrib = (float)(height - padding - tribDataForGraph[i] * scaleY);

                // Сохраняем точки
                fibPoints[i] = new PointF(x, yFib);
                tribPoints[i] = new PointF(x, yTrib);

                // Рисуем точки (кружки)
                g.FillEllipse(fibBrush, x - 3, yFib - 3, 6, 6); // Фибоначчи
                g.FillEllipse(tribBrush, x - 3, yTrib - 3, 6, 6); // Трибоначчи

                g.DrawString((i + 1).ToString(), new Font("Arial", 9, FontStyle.Bold), brush, x - 8, height - padding + 8);
            }

            // Рисуем линии
            if (fibPoints.Length > 1)
            {
                g.DrawLines(fibPen, fibPoints);
                g.DrawLines(tribPen, tribPoints);
            }

            // Легенда
            g.FillRectangle(Brushes.Blue, width - 120, 20, 15, 15);
            g.DrawString("Фибоначчи", new Font("Arial", 9), brush, width - 100, 22);

            g.FillRectangle(Brushes.Red, width - 120, 45, 15, 15);
            g.DrawString("Трибоначчи", new Font("Arial", 9), brush, width - 100, 47);
        }
    }
}
