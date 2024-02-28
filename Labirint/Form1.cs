using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Labirint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            groupBox1.Visible = false;
        }
        private static int height = 9;
        private static int width = 9;
        private static int[,] labirint = new int[height, width]; 
        private static int[,] waveField = new int[height, width]; // Поле волн для алгоритма
        private static List<object> Way = new List<object>();
        // Метод для генерации лабиринта
        private void GenerateLabirint()
        {
            grid.RowCount = height;
            grid.ColumnCount = width;
            int cellSize = 35;
            grid.RowTemplate.Height = cellSize;
            foreach (DataGridViewColumn col in grid.Columns)
            {
                col.Width = cellSize;
            }
            Random random = new Random();
            for (int i = 0; i < height; i++)
            {
                for (int k = 0; k < 3; k++)
                {
                    int j = random.Next(0, width);
                    labirint[i, j] = 1;
                    
                }
            }
            labirint[0, 0] = 0;
            grid.Rows[0].Cells[0].Style.BackColor = Color.Red;
            labirint[8, 8] = 0;
            grid.Rows[8].Cells[8].Style.BackColor = Color.Blue;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {

                    grid.Rows[i].Cells[j].Value = labirint[i, j];
                    if (labirint[i, j] == 1)
                        grid.Rows[i].Cells[j].Style.BackColor = Color.Black;
                }
            }
        }
        private void SearchShortestPath()
        {
            Queue<Point> queue = new Queue<Point>();
            bool[,] visited = new bool[height, width];

            // Начальная точка пути
            Point start = new Point(0, 0);
            queue.Enqueue(start);
            visited[start.X, start.Y] = true;

            // BFS
            while (queue.Count > 0)
            {
                Point current = queue.Dequeue();

                if (current == new Point(8, 8)) // Если достигли конечной точки, выходим из цикла
                    break;

                int[] dx = { -1, 1, 0, 0 }; // Смещения по горизонтали
                int[] dy = { 0, 0, -1, 1 }; // Смещения по вертикали

                for (int i = 0; i < 4; i++)
                {
                    int newX = current.X + dx[i];
                    int newY = current.Y + dy[i];

                    // Проверка на выход за границы лабиринта и на посещенность
                    if (newX >= 0 && newX < height && newY >= 0 && newY < width &&
                        labirint[newX, newY] == 0 && !visited[newX, newY])
                    {
                        queue.Enqueue(new Point(newX, newY));
                        visited[newX, newY] = true;
                        waveField[newX, newY] = waveField[current.X, current.Y] + 1;
                    }
                }
            }
            if (!visited[8, 8])
            {
                MessageBox.Show("Невозможно выйти из лабиринта!", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Отмечаем кратчайший путь
            Point end = new Point(8, 8);
            int shortestPathLength = waveField[end.X, end.Y];
            while (shortestPathLength > 0)
            {
                grid.Rows[end.X].Cells[end.Y].Style.BackColor = Color.Green; // Помечаем ячейку кратчайшего пути
                lbox.Items.Add(end.X.ToString() + ", " + end.Y.ToString());
                int[] dx = { -1, 1, 0, 0 };
                int[] dy = { 0, 0, -1, 1 };

                for (int i = 0; i < 4; i++)
                {
                    int newX = end.X + dx[i];
                    int newY = end.Y + dy[i];
                    if (newX >= 0 && newX < height && newY >= 0 && newY < width &&
                        waveField[newX, newY] == shortestPathLength - 1)
                    {
                        end = new Point(newX, newY);
                        shortestPathLength--;
                        break;
                    }
                }
            }
            lbox.Items.Add("0, 0");
            foreach (var item in lbox.Items)
                Way.Add(item);
            lbox.Items.Clear();
            Way.Reverse();
            lbox.Items.AddRange(Way.ToArray());
            lbox.Items.Add($"Длина пути - {Way.Count}");
        }
        private void set_random_grid_Click_1(object sender, EventArgs e)
        {
            lbox.Items.Clear();
            groupBox1.Visible = true;
            labirint = new int[height, width];
            waveField = new int[height, width];
            grid.Rows.Clear();
            GenerateLabirint();
        }
        private void search_optimal_way_Click_1(object sender, EventArgs e)
        {
            Way.Clear();
            lbox.Items.Clear();
            SearchShortestPath();
        }
    }
}
