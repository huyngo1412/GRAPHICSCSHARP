using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace GraphicsCKC
{
    public class Data
    {
        public static int GridSize = 40;
        public static Color firstcolor;
        public static int LineWeight;
        public static Form1 frm = new Form1();
        public static void getdatagrid(Graphics g,List<Color> color,List<int> lineweight,DataGridView datatoado,int mousedown)
        {
            g.Clear(Color.White);
            for(int i =0;i<datatoado.Rows.Count- mousedown-1;i++) {
                
                DataGridViewRow row = datatoado.Rows[i];
                
                switch (row.Cells[1].Value)
                {

                    case "Line":
                        Pen p1 = new Pen(color[i], lineweight[i]);
                        g.DrawLine(p1, (int)row.Cells[2].Value, (int)row.Cells[3].Value, (int)row.Cells[4].Value, (int)row.Cells[5].Value);
                        break;
                    case "Circle":
                        Pen p2 = new Pen(color[i], lineweight[i]);
                        int x1 = (int)row.Cells[2].Value - (int)(double)row.Cells[6].Value;
                        int x2 = (int)row.Cells[3].Value - (int)(double)row.Cells[6].Value;
                        int radius = (int)(double)row.Cells[6].Value;
                        g.DrawArc(p2, x1, x2, radius * 2, radius * 2, 0, 360);
                        break;
                    case "Rectangle":
                        Pen p3 = new Pen(color[i], lineweight[i]);
                        g.DrawRectangle(p3, (int)row.Cells[2].Value, (int)row.Cells[3].Value, (int)row.Cells[4].Value, (int)row.Cells[5].Value);
                        break;
                    case "TT.phanbo":
                        Pen p4 = new Pen(color[i], lineweight[i]);
                        Pen pen = new Pen(color[i], 3);
                        pen.CustomEndCap = new AdjustableArrowCap(5, 5);
                        int L1 = (int)row.Cells[4].Value - (int)row.Cells[2].Value;
                        int L2 = (int)row.Cells[3].Value - (int)row.Cells[5].Value;
                        int temp1,temp2,temp3,temp4,x3,y3,x4,y4;
                        for (int j = 0; j <= 4; j++)
                        {
                            temp1 = (int)row.Cells[2].Value;
                            temp2 = (int)row.Cells[3].Value - 40;
                             x4 = (int)row.Cells[2].Value + L1 * j / 4;
                             y4 = (int)row.Cells[3].Value - L2 * j / 4;
                             x3 = x4;
                             y3 = y4;
                            temp3 = y3 - 20;
                             y3 -= 40;
                            temp3 = x3;
                            temp4 = y3;                                                 
                            g.DrawLine(pen, x3, y3, x4, y4);
                        }
                       // g.DrawLine(p4, temp1, temp2, temp3, temp4);
                        break;
                    case "TT.Taptrung":
                        Pen p5 = new Pen(color[i], lineweight[i]);

                        break;
                }
            }
        }
    }
}
