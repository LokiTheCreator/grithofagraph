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
    public partial class Form1 : Form
    {
        DrawGrah G;
        List<Vertex> V;
        List<Edge> E;
        List<int> near;
        int check1;
        int check2;


        public Form1()
        {
            InitializeComponent();
            V = new List<Vertex>();
            E = new List<Edge>();
            G = new DrawGrah(pictureBox1.Width, pictureBox1.Height);
            near = new List<int>();
            pictureBox1.Image = G.GetBitmap();
        }


        private void Prohod(Vertex a, Vertex b, List<Vertex> c)//проход по предыдущим вершинам
        {
            //a — текущая вершина 
            //b — вершина, с которой начинается цикл 
            //с — список вершин цикла 

            c.Add(a);//добавили 
            if (a.number == b.number) 
                return;
            if (marks[a.number - 1] != 1)
                return;
            Prohod(a.previous, b, c);
        }

        List<Vertex> loop = new List<Vertex>();
        void dfs_find(Vertex prev, Vertex now)//поиск в глубину
        {
            if (marks[now.number - 1] == 2)
                return;

            now.previous = prev;
            marks[now.number - 1] = 1;
            List<int> near = new List<int>();
            near = now.findNear(now.number - 1, E, V, near);
            for (int i = 0; i < near.Count; i++)
            {
                if (prev != null && near[i] == prev.number - 1)
                    continue;
                if (marks[near[i]] == 1)//при попадании в пройденную вершину, проходим по предыдущим для неё, добавляя в loop
                {
                    loop.Add(V[near[i]]);
                    Prohod(now, V[near[i]], loop);

                    if (loop.Count > 0 && loop.Count < min_loop_count)//получаем цикл минимальной длины
                    {
                        min_loop = new List<Vertex>(loop);
                        min_loop_count = loop.Count;
                    }

                    loop.Clear();
                }
                else
                    dfs_find(now, V[near[i]]);
                

            }
            marks[now.number - 1] = 2;
        }

        int[] marks;
        List<Vertex> min_loop;
        int min_loop_count;

        private void ButVertex_Click(object sender, EventArgs e)
        {
            ButVertex.Enabled = false;

            ButEdge.Enabled = true;

            pictureBox1.Image = G.GetBitmap();
        }

        private void ButEdge_Click(object sender, EventArgs e)
        {
            ButEdge.Enabled = false;

            ButVertex.Enabled = true;

            pictureBox1.Image = G.GetBitmap();
            check1 = -1;
            check2 = -1;
        }

        private void ButClear_Click(object sender, EventArgs e)
        {

            ButVertex.Enabled = true;
            ButEdge.Enabled = true;
            V.Clear();
            E.Clear();
            G.clearSpace();
            listBox1.Items.Clear();
            pictureBox1.Refresh();
        }

        private void ButMethod_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();//сюда выводим порядок вершин 
            min_loop_count = V.Count + 2;
            min_loop = new List<Vertex>();

            marks = new int[V.Count];//пометки вершин 
            loop = new List<Vertex>();//цикл 
            for (int g = 0; g < V.Count; g++)//dfs для каждой вершины
            {
                marks = new int[V.Count];//пометки вершин 
                loop = new List<Vertex>();//цикл 

                if (marks[g] == 0)//если вершина не помечена 
                    dfs_find(null, V[g]);//то ищем из нее 
            }
            for (int i = 0; i < min_loop.Count; i++)
                listBox1.Items.Add(min_loop[i].number + "");
            listBox2.Items.Add(min_loop.Count() - 1);

        }

        private void pictureBox1_MouseClick(object sender, MouseEventArgs e)//отрисовка (3 лаба)
        {

            if (ButVertex.Enabled == false)
            {
                V.Add(new Vertex(e.X, e.Y, V.Count + 1));
                G.DrawVertex(e.X, e.Y, V.Count.ToString());
                pictureBox1.Refresh();
            }//рисуем грань
            if (ButEdge.Enabled == false)
            {
                if (e.Button == MouseButtons.Left)
                {
                    for (int i = 0; i < V.Count; i++)
                    {
                        if (Math.Pow((V[i].x - e.X), 2) + Math.Pow((V[i].y - e.Y), 2) <= G.R * G.R)
                        {
                            if (check1 == -1)
                            {
                                G.RedrawVertex(V[i].x, V[i].y);
                                check1 = i;
                                pictureBox1.Refresh();
                                break;
                            }
                            if (check2 == -1)
                            {
                                G.RedrawVertex(V[i].x, V[i].y);
                                check2 = i;
                                E.Add(new Edge(check1, check2));
                                G.DrawEdge(V[check1], V[check2], E[E.Count - 1], E.Count - 1);
                                check1 = -1;
                                check2 = -1;
                                pictureBox1.Refresh();
                                break;
                            }
                        }
                    }
                }
                if (e.Button == MouseButtons.Right)
                {
                    if ((check1 != -1) && (Math.Pow((V[check1].x - e.X), 2) + Math.Pow((V[check1].y - e.Y), 2) <= G.R * G.R))
                    {
                        G.DrawVertex(V[check1].x, V[check1].y, (check1 + 1).ToString());
                        check1 = -1;
                        pictureBox1.Refresh();
                    }
                }
            }
        }

 
    }
}
