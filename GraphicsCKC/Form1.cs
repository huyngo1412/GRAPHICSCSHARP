using Microsoft.VisualBasic.Devices;
using System.Collections;
using System.Reflection;
using static System.Windows.Forms.LinkLabel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Diagnostics.Contracts;
using System.Windows.Forms;
using System.Diagnostics;
using System.Windows.Forms.Design;
using System.IO;
using OfficeOpenXml;
using Excel = Microsoft.Office.Interop.Excel;
using System.DirectoryServices.ActiveDirectory;

namespace GraphicsCKC
{
    public partial class Form1 : Form
    {
        private List<Color> colordata = new List<Color>();
        private List<int> linweight = new List<int>();
        Bitmap bitmap;
        private Graphics g;
        Point px, py;
        int Grid;
        bool check, checksnap = false, checkgrid = false;
        Pen p;
        Pen grid = new Pen(Color.Black);
        int index;
        public static int back = 0;
        int x1, y1, x2, y2, x3, y3, x4, y4, x5, y5, x6, y6, temp1, temp2, temp3, temp4, endX, endY, click = 1,id,centerX,centerY,mousedown;
        Color new_color;
        private void Form1_Load(object sender, EventArgs e)
        {
            Grid = Data.GridSize;
           
            Type colorType = typeof(System.Drawing.Color);
            PropertyInfo[] propInfoList = colorType.GetProperties(BindingFlags.Static |
                                          BindingFlags.DeclaredOnly | BindingFlags.Public);
            foreach (PropertyInfo c in propInfoList)
            {
                this.cbColor.Items.Add(c.Name);
            }
            cbColor.DrawMode = DrawMode.OwnerDrawFixed;
            cbColor.SelectedIndex = 10;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ColorHatch.ShowDialog();
            new_color = ColorHatch.Color;
            Snap.color = ColorHatch.Color;
            index = 10;
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            g.Clear(Color.White);
            resetpicture();
        }

        private void btnNext_MouseDown(object sender, MouseEventArgs e)
        {
            mousedown -= 1;
            g.Clear(Color.White);
            Data.getdatagrid(g, colordata, linweight, datatoado, mousedown);
            if (mousedown == 0)
            {
                btnNext.Enabled = false;
            }
            resetpicture();
        }
        private void ExportExcel(string path)
        {
            Excel.Application application = new Excel.Application();
            application.Application.Workbooks.Add(Type.Missing);
            for (int i = 0; i < datatoado.Columns.Count; i++)
            {
                application.Cells[1, i + 1] = datatoado.Columns[i].HeaderText;

            }
            for (int i = 0; i < datatoado.Rows.Count; i++)
            {
                for (int j = 0; j < datatoado.Columns.Count; j++)
                {
                    application.Cells[i + 2, j + 1] = datatoado.Rows[i].Cells[j].Value;

                }
            }
            application.Columns.AutoFit();
            application.ActiveWorkbook.SaveCopyAs(path);
            application.ActiveWorkbook.Saved = true;
        }
        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Export Excel";
            saveFileDialog.Filter = "Excel (*.xlsx)|*.xlsx";
            if(saveFileDialog.ShowDialog()==DialogResult.OK)
            {
                try
                {
                    ExportExcel(saveFileDialog.FileName);
                    MessageBox.Show("OK");
                    
                }
                catch(Exception ex) { }
                string s = saveFileDialog.FileName;
                Process process = new Process();
                process.StartInfo.FileName = s;
                process.StartInfo.UseShellExecute = true;
                process.Start(); ;
            }

        }

        private void datatoado_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            btnBack.Enabled = true;
        }

        private void picCKC_MouseClick(object sender, MouseEventArgs e)
        {
           
            if (index == 10)
            {
                Point point = set_Point(picCKC, e.Location);
                Fill(bitmap, point.X, point.Y, new_color);
            }
        }

        private void btnGoicodinh_Click(object sender, EventArgs e)
        {
            index = 7;
        }

        static Point set_Point(PictureBox picCKC, Point pt)
        {
            float px = 1f * picCKC.Image.Width / picCKC.Width;
            float py = 1f * picCKC.Image.Height / picCKC.Height;
            return new Point((int)(pt.X * px), (int)(pt.Y * py));
        }
        private void validate(Bitmap bitmap, Stack<Point> sp, int x, int y, Color old_color, Color new_color)
        {
            Color cx = bitmap.GetPixel(x, y);
            if (cx == old_color)
            {
                sp.Push(new Point(x, y));
                bitmap.SetPixel(x, y, new_color);
            }
        }
        public void Fill(Bitmap bitmap, int x, int y, Color new_clr)
        {
            Color old_color = bitmap.GetPixel(x, y);
            Stack<Point> pixel = new Stack<Point>();
            pixel.Push(new Point(x, y));
            bitmap.SetPixel(x, y, new_clr);
            if (old_color == new_clr) return;
            while (pixel.Count > 0)
            {
                Point pt = (Point)pixel.Pop();
                if (pt.X > 0 && pt.Y > 0 && pt.X < bitmap.Width - 1 && pt.Y < bitmap.Height - 1)
                {
                    validate(bitmap, pixel, pt.X - 1, pt.Y, old_color, new_clr);
                    validate(bitmap, pixel, pt.X, pt.Y - 1, old_color, new_clr);
                    validate(bitmap, pixel, pt.X + 1, pt.Y, old_color, new_clr);
                    validate(bitmap, pixel, pt.X, pt.Y + 1, old_color, new_clr);
                }
            }
        }
        private void btnBack_MouseDown(object sender, MouseEventArgs e)
        {
            mousedown += 1;
            g.Clear(Color.White);
            Data.getdatagrid(g, colordata,linweight, datatoado,mousedown);
            if(mousedown >0)
            {
                btnNext.Enabled = true;
            }    
            if(mousedown == datatoado.Rows.Count - 1)
            {
                btnBack.Enabled  = false;
            }    
            resetpicture();
        }
        private void resetpicture()
        {
            picCKC.Refresh();
        }

        private void picCKC_Paint(object sender, PaintEventArgs e)
        {
            
            Pen dashed_pen = new Pen(Color.Gainsboro);
            if (check == true)
            {
                switch (index)
                {
                    case 1:
                        e.Graphics.DrawLine(dashed_pen, x1, y1, endX, endY);
                        break;
                    case 2:
                        try
                        {
                            double radius = Math.Sqrt(Math.Pow(endX - x1, 2) + Math.Pow(endY - y1, 2));
                            e.Graphics.DrawArc(dashed_pen, (float)x1 - (float)radius, (float)y1 - (float)radius, (float)radius * 2, (float)radius * 2, 0, 360);
                        }
                        catch { Exception ex; }                        
                        break;
                    case 3:
                        e.Graphics.DrawRectangle(dashed_pen, x1, y1, endX - x1, endY - y1);
                        break;
                    case 4:
                        int L1 = endX - x1;
                        int L2 = y1 - endY;
                        for (int i = 0; i <= 4; i++)
                        {
                            temp1 = x1;
                            temp2 = y1 - 40;
                            x4 = x1 + L1 * i / 4;
                            y4 = y1 - L2 * i / 4;
                            x3 = x4;
                            y3 = y4;
                            temp3 = y3 - 20;
                            y3 -= 40;
                            temp3 = x3;
                            temp4 = y3;
                            dashed_pen.CustomEndCap = new AdjustableArrowCap(5, 5);
                            e.Graphics.DrawLine(dashed_pen, x3, y3, x4, y4);

                        }
                        p = new Pen(Color.Gainsboro);
                        e.Graphics.DrawLine(p, temp1, temp2, temp3, temp4);
                        break;
                    case 5:
                        dashed_pen.CustomEndCap = new AdjustableArrowCap(5, 5);
                        e.Graphics.DrawLine(dashed_pen, x1, y1, endX, endY);
                        break;                   
                }
            }
           if(index == 6)
            {
                e.Graphics.DrawArc(dashed_pen, centerX - 10, centerY, 20, 20, 0, 360);
                centerY += 40;
                e.Graphics.DrawArc(dashed_pen, centerX - 10, centerY, 20, 20, 0, 360);
                x2 = centerX - 10 + (20 / 2);
                y2 = centerY - 20;
                e.Graphics.DrawLine(dashed_pen, x2, centerY, x2, y2);
                Pen f = new Pen(Color.Gainsboro, 10);
                e.Graphics.DrawLine(f, centerX - 20, centerY + 25, 20 + centerX, centerY + 25);
            }   
           if(index == 7)
            {
                e.Graphics.DrawArc(dashed_pen, centerX - 10, centerY, 20, 20, 0, 360);
                e.Graphics.DrawLine(dashed_pen, centerX - 10, centerY + 10, centerX - 20, centerY + 30);
                e.Graphics.DrawLine(dashed_pen, centerX + 10, centerY + 10, centerX + 20, centerY + 30);
                Pen h = new Pen(Color.Gainsboro, 10);
                e.Graphics.DrawLine(h, centerX - 20, centerY + 30, centerX + 20, centerY + 30);
            }    
       }    
        private void btnSnap_MouseDown(object sender, MouseEventArgs e)
        {
            if (checksnap == false)
            {
                checksnap = true;
                click += 1;
                btnSnap.Text = "Snap Off";
            }
            else
            {
                checksnap = false;
                click -= 1;
                btnSnap.Text = "Snap On";
            }
        }
        #region index
        private void btnLine_Click(object sender, EventArgs e)
        {
            index = 1;
        }

        private void btnCircle_Click(object sender, EventArgs e)
        {
            index = 2;
        }

        private void btnRectangle_Click(object sender, EventArgs e)
        {
            index = 3;
        }

        private void btnTTPhanbo_Click(object sender, EventArgs e)
        {
            index = 4;
        }
        private void btnTTtaptrung_Click(object sender, EventArgs e)
        {
            index = 5;
        }
        private void btnGoiDidong_Click(object sender, EventArgs e)
        {
            index = 6;
        }
        #endregion
        #region mousedown
        private void btnGrid_MouseDown(object sender, MouseEventArgs e)
        {
            
            Grid = Data.GridSize;
           x3 = 0; x4 = 0; y3 = 0; y4 = picCKC.Size.Height; x5 = 0; y5 = 0; x6 = picCKC.Size.Width; y6 = 0;
            if (checkgrid == false)
            {
                for (int i = 0; i <= picCKC.Size.Width; i++)
                {
                    x3 += Grid;
                    x4 += Grid;
                    y5 += Grid;
                    y6 += Grid;
                    g.DrawLine(grid, x3, y3, x4, y4);
                    g.DrawLine(grid, x5, y5, x6, y6);
                }
                btnGrid.Text = "Grid Off";
                checkgrid = true;
                resetpicture();
            }
            else
            {
                Data.getdatagrid(g, colordata, linweight, datatoado, 0);
                btnGrid.Text = "Grid On";
                checkgrid = false;
                resetpicture();
            }
        }
        #endregion

       
        #region cbColor
        private void cbColor_DrawItem(object sender, DrawItemEventArgs e)
        {
            e.DrawBackground();
            Rectangle rect = e.Bounds;
            if (e.Index<0) return;
            else
            {
                string txt = cbColor.GetItemText(cbColor.Items[e.Index]);
                Color color = Color.FromName(txt);
                Rectangle rec1 = new Rectangle(e.Bounds.Left + 1, e.Bounds.Top + 1,
                    2 * (e.Bounds.Height - 2), e.Bounds.Height - 2);
                Rectangle rec2 = Rectangle.FromLTRB(rec1.Right + 2, e.Bounds.Top,
                    e.Bounds.Right, e.Bounds.Bottom);
                using (Brush b = new SolidBrush(color))
                    e.Graphics.FillRectangle(b, rec1);
                e.Graphics.DrawRectangle(Pens.Black, rec1);
                TextRenderer.DrawText(e.Graphics, txt, cbColor.Font,rec2,
                    cbColor.ForeColor, TextFormatFlags.Left | TextFormatFlags.VerticalCenter);
            }      
        }

        private void cbColor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbColor.SelectedIndex < 0) return;
            else
            {
                string s = cbColor.Text;
                Data.firstcolor = Color.FromName(s);
                new_color = Color.FromName(s);
            }
        }
        #endregion
        private void exportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Process notePad = new Process();
            var spf = new SaveFileDialog();
            spf.Filter = "Image(*.jpg)|*.jpg|(*.*|*.*";
            if (spf.ShowDialog() == DialogResult.OK )
            {               
                Bitmap btm = bitmap.Clone(new Rectangle(0, 0, picCKC.Width, picCKC.Height), bitmap.PixelFormat);               
                btm.Save(spf.FileName);
                string s = spf.FileName;
                Process process = new Process();
                process.StartInfo.FileName = s;
                process.StartInfo.UseShellExecute = true;
                process.Start(); ;
            }
        }
        public Form1()
        {
            InitializeComponent();
            bitmap = new Bitmap(picCKC.Width,picCKC.Height);
            g = Graphics.FromImage(bitmap);
            g.Clear(Color.White);
            picCKC.Image= bitmap;
        }
        private void picCKC_MouseDown(object sender, MouseEventArgs e)
        {
            Data.LineWeight = (int)numericUpDown1.Value;
            p = new Pen(Data.firstcolor, Data.LineWeight);
            if (e.Button == MouseButtons.Left)
            {
                switch (index)
                {
                    case 1:

                        if (check == false)
                        {
                            x1 = e.X; y1 = e.Y; check = true;
                            
                        }
                        else
                        {
                            id += 1;
                            check = false;
                            x2 = e.X; y2 = e.Y;
                            if (click %2 ==0)
                            {
                                x1 = Snap.Toadodiemx1(x1,Data.GridSize);y1 = Snap.Toadodiemy1(y1,Data.GridSize);
                                x2 = Snap.Toadodiemx2(x2,Data.GridSize);y2 = Snap.Toadodiemy2(y2, Data.GridSize);
                            }    
                            g.DrawLine(p, x1,y1, x2,y2);
                            linweight.Add(Data.LineWeight);
                            colordata.Add(Data.firstcolor);
                            datatoado.Rows.Add(id, "Line", x1,y1,x2,y2);
                        }
                        break;
                    case 2:
                        if (check == false) { x1 = e.X; y1 = e.Y; check = true;  }
                        else
                        {
                            id += 1;
                            x2 = e.X; y2 = e.Y; check = false;
                            double radius = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
                            g.DrawArc(p, (float)x1 - (float)radius, (float)y1 - (float)radius, (float)radius * 2, (float)radius * 2, 0, 360);
                            colordata.Add(Data.firstcolor);
                            linweight.Add(Data.LineWeight);
                            datatoado.Rows.Add(id, "Circle", x1,y1,0,0,radius);
                        }
                        break;
                    case 3:
                        if (check == false) { x1 = e.X; y1 = e.Y; check = true; }
                        else
                        {
                            check = false;
                            if (click % 2 == 0)
                            {
                                x1 = Snap.Toadodiemx1(x1, Data.GridSize); y1 = Snap.Toadodiemy1(y1, Data.GridSize);
                                x2 = Snap.Toadodiemx2(x2, Data.GridSize); y2 = Snap.Toadodiemy2(y2, Data.GridSize);
                            }
                            x2 = e.X; y2 = e.Y;id += 1;
                            colordata.Add(Data.firstcolor);
                            linweight.Add(Data.LineWeight);
                            g.DrawRectangle(p,x1,y1,x2-x1,y2-y1);
                            datatoado.Rows.Add(id, "Rectangle",x1, y1, x2 - x1, y2 - y1);
                        }
                        break;
                    case 4:
                        TextBox txtTTphanbo = new TextBox();
                        if (check == false) { x1 = e.X; y1 = e.Y; check = true; }
                        else
                        {
                            check = false;
                            x2 = e.X; y2 = e.Y;
                            if (click % 2 == 0)
                            {
                                x1 = Snap.Toadodiemx1(x1, Data.GridSize); y1 = Snap.Toadodiemy1(y1, Data.GridSize);
                                x2 = Snap.Toadodiemx2(x2, Data.GridSize); y2 = Snap.Toadodiemy2(y2, Data.GridSize);
                            }
                            int L1 = x2 - x1;
                            int L2 = y1 - y2;
                            for (int i = 0; i <= 4; i++)
                            {
                                temp1 = x1;
                                temp2 = y1 - 40;
                                x4 = x1 + L1 * i / 4;
                                y4 = y1 - L2 * i / 4;
                                x3 = x4;
                                y3 = y4;
                               // temp3 = y3 - 20;
                                y3 -= 40;
                                temp3 = x3;
                                temp4 = y3;
                                Pen pen = new Pen(Data.firstcolor, 3);
                                pen.CustomEndCap = new AdjustableArrowCap(5, 5);
                                g.DrawLine(pen, x3, y3, x4, y4);

                            }
                            txtTTphanbo .Width = 50;
                            txtTTphanbo.Height = 30;
                            txtTTphanbo.Location = new Point(e.X, e.Y - 10);
                            picCKC.Controls.Add(txtTTphanbo);
                            colordata.Add(Data.firstcolor);
                            linweight.Add(Data.LineWeight);
                            txtTTphanbo.KeyDown += txtTTphanbo_KeyDown;
                            g.DrawLine(p, temp1, temp2, temp3, temp4);
                        }
                            break;
                    case 5:
                        TextBox txtTTtaptrung = new TextBox();
                        if (check == false) { x1 = e.X; y1 = e.Y; check = true;}
                        else
                        {
                            check = false;
                            x2 = e.X; y2 = e.Y;
                            if (click % 2 == 0)
                            {
                                x1 = Snap.Toadodiemx1(x1, Data.GridSize); y1 = Snap.Toadodiemy1(y1, Data.GridSize);
                                x2 = Snap.Toadodiemx2(x2, Data.GridSize); y2 = Snap.Toadodiemy2(y2, Data.GridSize);
                            }
                            Pen pen = new Pen(Data.firstcolor, 4);
                            pen.CustomEndCap = new AdjustableArrowCap(5, 5);
                            g.DrawLine(pen, x1, y1, x2, y2);
                            colordata.Add(Data.firstcolor);
                            txtTTtaptrung.Width = 50;
                            txtTTtaptrung.Height = 30;
                            txtTTtaptrung.Location = new Point(e.X, e.Y-10);
                            picCKC.Controls.Add(txtTTtaptrung);
                            txtTTtaptrung.KeyDown += txtTTtaptrung_KeyDown;
                        }
                        break;
                    case 6:
                        x1 = e.X;y1 = e.Y;
                        if (click % 2 == 0)
                        {
                            x1 = Snap.Toadodiemx1(x1, Data.GridSize); y1 = Snap.Toadodiemy1(y1, Data.GridSize);
                        }
                        g.DrawArc(p, x1-10, y1, 20, 20, 0, 360);
                        y1 += 40;
                        g.DrawArc(p, x1-10, y1, 20, 20, 0, 360);
                        x2 = x1 - 10 + (20 / 2);
                        y2 = y1 - 20;
                        g.DrawLine(p, x2, y1, x2, y2);
                        Pen f = new Pen(Data.firstcolor, 10);
                        colordata.Add(Data.firstcolor);
                        g.DrawLine(f, x1 - 20, y1 + 25, 20 + x1, y1 + 25);
                        break;
                    case 7:
                        x1 = e.X;y1 = e.Y;
                        colordata.Add(Data.firstcolor);
                        g.DrawArc(p, x1 - 10, y1, 20, 20, 0, 360);
                        g.DrawLine(p, x1-10, y1 + 10, x1 -20, y1+30);
                        g.DrawLine(p, x1 + 10, y1 + 10, x1 + 20, y1 + 30);
                        Pen h = new Pen(Data.firstcolor, 10);
                        g.DrawLine(h, x1 - 20, y1 + 30, x1 + 20, y1 + 30);
                        break;
                }
            }
        }
        private void txtTTphanbo_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox txtTTphanbo = sender as TextBox;
            if (e.KeyCode == Keys.Enter)
            {
                datatoado.Rows.Add(id, "TT.phanbo", x1, y1, x2, y2, 0,0, txtTTphanbo.Text);
                picCKC.Controls.Remove(txtTTphanbo);
            }
        }
        private void txtTTtaptrung_KeyDown(object sender, KeyEventArgs e)
        {
            TextBox txtTTtaptrung = sender as TextBox;
            if(e.KeyCode  == Keys.Enter)
            {
                datatoado.Rows.Add(id, "TT.Taptrung", x2, y2, 0, 0, 0, txtTTtaptrung.Text,0);
                picCKC.Controls.Remove(txtTTtaptrung);
            }
        }
        private void picCKC_MouseMove(object sender, MouseEventArgs e)
        {
            string s = "X:" + e.X.ToString()  + "/Y:" + e.Y.ToString() + " Grid Size:" + Grid;
            lblToaDo.Text = s;
            if(check == true)
            {
                endX = e.X;
                endY = e.Y;
            }
            centerX= e.X;
            centerY = e.Y;
            resetpicture();
        }
    }
}