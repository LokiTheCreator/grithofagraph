using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace siakodrgr
{
    class Edge
    {
        public int v1, v2;

        public Edge(int v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }
    }

    class Vertex
    {
        public Vertex previous = null;
        public int x, y, number;
        public bool Checked = false;

        public Vertex(int x, int y, int number)
        {
            this.x = x;
            this.y = y;
            this.number = number;
        }

        public List<int> findNear(int q, List<Edge> E, List<Vertex> V, List<int> near)
        {
            for (int i = 0; i < E.Count(); i++)
            {
                if ((E[i].v1 == q) && ((V[E[i].v2].Checked == false)||(V[E[i].v2].Checked == true)))
                {
                    
                    near.Add(E[i].v2);                    
                    continue;
                }
                if ((E[i].v2 == q) && ((V[E[i].v1].Checked == false)||(V[E[i].v1].Checked == true)))
                {
                    near.Add(E[i].v1);
                }
            }
            near.Sort();
            return near;
        }
    }
        class DrawGrah
        {
            Bitmap bitmap;

            Pen penBlack;
            Pen penRed;
            Pen penGreen;

            Graphics gr;

            Font font;
            Brush brush;
            PointF point;

            public int R = 20;

            public DrawGrah(int width, int height)
            {
                bitmap = new Bitmap(width, height);
                gr = Graphics.FromImage(bitmap);
                penBlack = new Pen(Color.Black);
                penGreen = new Pen(Color.Green);
                penRed = new Pen(Color.Red);
                penGreen.Width = 2;
                font = new Font("Arials", 10);
                brush = Brushes.Black;
                clearSpace();
            }

            public Bitmap GetBitmap()
            {
                return bitmap;
            }

            public void clearSpace()
            {
                gr.Clear(SystemColors.Control);
            }

            public void DrawVertex(int x, int y, string number)
            {
                gr.FillEllipse(Brushes.White, (x - R), (y - R), 2 * R, 2 * R);
                gr.DrawEllipse(penBlack, (x - R), (y - R), 2 * R, 2 * R);
                point = new PointF(x - 9, y - 9);
                gr.DrawString(number, font, brush, point);
            }

            public void RedrawVertex(int x, int y)
            {
                gr.DrawEllipse(penRed, (x - R), (y - R), 2 * R, 2 * R);
            }

            public void DrawEdge(Vertex V1, Vertex V2, Edge E, int numberE)
            {
                gr.DrawLine(penGreen, V1.x, V1.y, V2.x, V2.y);
                DrawVertex(V1.x, V1.y, (E.v1 + 1).ToString());
                DrawVertex(V2.x, V2.y, (E.v2 + 1).ToString());
            }
        }
    

    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
