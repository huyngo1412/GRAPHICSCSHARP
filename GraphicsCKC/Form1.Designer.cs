namespace GraphicsCKC
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.deleteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.exportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
            this.lblToaDo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.btnGoicodinh = new System.Windows.Forms.Button();
            this.btnGoiDidong = new System.Windows.Forms.Button();
            this.btnTTPhanbo = new System.Windows.Forms.Button();
            this.btnTTtaptrung = new System.Windows.Forms.Button();
            this.btnCircle = new System.Windows.Forms.Button();
            this.btnRectangle = new System.Windows.Forms.Button();
            this.btnLine = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.datatoado = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.cbColor = new System.Windows.Forms.ComboBox();
            this.btnGrid = new System.Windows.Forms.Button();
            this.btnSnap = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.picCKC = new System.Windows.Forms.PictureBox();
            this.ColorHatch = new System.Windows.Forms.ColorDialog();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datatoado)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCKC)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.toolStripMenuItem3,
            this.deleteToolStripMenuItem,
            this.toolStripMenuItem4,
            this.exportToolStripMenuItem,
            this.toolStripMenuItem6});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(109, 126);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(105, 6);
            // 
            // deleteToolStripMenuItem
            // 
            this.deleteToolStripMenuItem.Name = "deleteToolStripMenuItem";
            this.deleteToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.deleteToolStripMenuItem.Text = "Delete";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(105, 6);
            // 
            // exportToolStripMenuItem
            // 
            this.exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            this.exportToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.exportToolStripMenuItem.Text = "Export";
            this.exportToolStripMenuItem.Click += new System.EventHandler(this.exportToolStripMenuItem_Click);
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(108, 22);
            this.toolStripMenuItem6.Text = " ";
            // 
            // lblToaDo
            // 
            this.lblToaDo.AutoSize = true;
            this.lblToaDo.Location = new System.Drawing.Point(12, 675);
            this.lblToaDo.Name = "lblToaDo";
            this.lblToaDo.Size = new System.Drawing.Size(0, 15);
            this.lblToaDo.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Black;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btnGoicodinh);
            this.panel1.Controls.Add(this.btnGoiDidong);
            this.panel1.Controls.Add(this.btnTTPhanbo);
            this.panel1.Controls.Add(this.btnTTtaptrung);
            this.panel1.Controls.Add(this.btnCircle);
            this.panel1.Controls.Add(this.btnRectangle);
            this.panel1.Controls.Add(this.btnLine);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(885, 112);
            this.panel1.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(775, 7);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 82);
            this.button2.TabIndex = 0;
            this.button2.Text = "Dầm";
            this.button2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Location = new System.Drawing.Point(676, 8);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(93, 82);
            this.button3.TabIndex = 0;
            this.button3.Text = "Ngàm";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // btnGoicodinh
            // 
            this.btnGoicodinh.BackColor = System.Drawing.Color.White;
            this.btnGoicodinh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGoicodinh.Image = ((System.Drawing.Image)(resources.GetObject("btnGoicodinh.Image")));
            this.btnGoicodinh.Location = new System.Drawing.Point(577, 7);
            this.btnGoicodinh.Name = "btnGoicodinh";
            this.btnGoicodinh.Size = new System.Drawing.Size(93, 82);
            this.btnGoicodinh.TabIndex = 0;
            this.btnGoicodinh.Text = "Gối cố định";
            this.btnGoicodinh.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGoicodinh.UseVisualStyleBackColor = false;
            this.btnGoicodinh.Click += new System.EventHandler(this.btnGoicodinh_Click);
            // 
            // btnGoiDidong
            // 
            this.btnGoiDidong.BackColor = System.Drawing.Color.White;
            this.btnGoiDidong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGoiDidong.Image = ((System.Drawing.Image)(resources.GetObject("btnGoiDidong.Image")));
            this.btnGoiDidong.Location = new System.Drawing.Point(491, 8);
            this.btnGoiDidong.Name = "btnGoiDidong";
            this.btnGoiDidong.Size = new System.Drawing.Size(80, 82);
            this.btnGoiDidong.TabIndex = 0;
            this.btnGoiDidong.Text = "Gối di động";
            this.btnGoiDidong.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGoiDidong.UseVisualStyleBackColor = false;
            this.btnGoiDidong.Click += new System.EventHandler(this.btnGoiDidong_Click);
            // 
            // btnTTPhanbo
            // 
            this.btnTTPhanbo.BackColor = System.Drawing.Color.White;
            this.btnTTPhanbo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTTPhanbo.Image = ((System.Drawing.Image)(resources.GetObject("btnTTPhanbo.Image")));
            this.btnTTPhanbo.Location = new System.Drawing.Point(262, 8);
            this.btnTTPhanbo.Name = "btnTTPhanbo";
            this.btnTTPhanbo.Size = new System.Drawing.Size(124, 82);
            this.btnTTPhanbo.TabIndex = 0;
            this.btnTTPhanbo.Text = "TT.Phân bố";
            this.btnTTPhanbo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTTPhanbo.UseVisualStyleBackColor = false;
            this.btnTTPhanbo.Click += new System.EventHandler(this.btnTTPhanbo_Click);
            // 
            // btnTTtaptrung
            // 
            this.btnTTtaptrung.BackColor = System.Drawing.Color.White;
            this.btnTTtaptrung.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTTtaptrung.Image = ((System.Drawing.Image)(resources.GetObject("btnTTtaptrung.Image")));
            this.btnTTtaptrung.Location = new System.Drawing.Point(392, 8);
            this.btnTTtaptrung.Name = "btnTTtaptrung";
            this.btnTTtaptrung.Size = new System.Drawing.Size(93, 82);
            this.btnTTtaptrung.TabIndex = 0;
            this.btnTTtaptrung.Text = "TT. Tập trung";
            this.btnTTtaptrung.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTTtaptrung.UseVisualStyleBackColor = false;
            this.btnTTtaptrung.Click += new System.EventHandler(this.btnTTtaptrung_Click);
            // 
            // btnCircle
            // 
            this.btnCircle.BackColor = System.Drawing.Color.White;
            this.btnCircle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCircle.Image = ((System.Drawing.Image)(resources.GetObject("btnCircle.Image")));
            this.btnCircle.Location = new System.Drawing.Point(98, 7);
            this.btnCircle.Name = "btnCircle";
            this.btnCircle.Size = new System.Drawing.Size(76, 82);
            this.btnCircle.TabIndex = 0;
            this.btnCircle.Text = "Circle";
            this.btnCircle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCircle.UseVisualStyleBackColor = false;
            this.btnCircle.Click += new System.EventHandler(this.btnCircle_Click);
            // 
            // btnRectangle
            // 
            this.btnRectangle.BackColor = System.Drawing.Color.White;
            this.btnRectangle.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRectangle.Image = ((System.Drawing.Image)(resources.GetObject("btnRectangle.Image")));
            this.btnRectangle.Location = new System.Drawing.Point(180, 7);
            this.btnRectangle.Name = "btnRectangle";
            this.btnRectangle.Size = new System.Drawing.Size(76, 82);
            this.btnRectangle.TabIndex = 0;
            this.btnRectangle.Text = "Rectangle";
            this.btnRectangle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnRectangle.UseVisualStyleBackColor = false;
            this.btnRectangle.Click += new System.EventHandler(this.btnRectangle_Click);
            // 
            // btnLine
            // 
            this.btnLine.BackColor = System.Drawing.Color.White;
            this.btnLine.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLine.Image = ((System.Drawing.Image)(resources.GetObject("btnLine.Image")));
            this.btnLine.Location = new System.Drawing.Point(17, 7);
            this.btnLine.Name = "btnLine";
            this.btnLine.Size = new System.Drawing.Size(76, 82);
            this.btnLine.TabIndex = 0;
            this.btnLine.Text = "Line";
            this.btnLine.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLine.UseVisualStyleBackColor = false;
            this.btnLine.Click += new System.EventHandler(this.btnLine_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnNext.Enabled = false;
            this.btnNext.Image = global::GraphicsCKC.Properties.Resources.Screenshot_2022_11_30_135122;
            this.btnNext.Location = new System.Drawing.Point(852, 663);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(46, 27);
            this.btnNext.TabIndex = 3;
            this.btnNext.UseVisualStyleBackColor = false;
            this.btnNext.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnNext_MouseDown);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBack.Enabled = false;
            this.btnBack.Image = global::GraphicsCKC.Properties.Resources.Screenshot_2022_11_30_135111;
            this.btnBack.Location = new System.Drawing.Point(797, 663);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(49, 27);
            this.btnBack.TabIndex = 3;
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnBack_MouseDown);
            // 
            // datatoado
            // 
            this.datatoado.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.datatoado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datatoado.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.datatoado.GridColor = System.Drawing.Color.Black;
            this.datatoado.Location = new System.Drawing.Point(903, 131);
            this.datatoado.Name = "datatoado";
            this.datatoado.ReadOnly = true;
            this.datatoado.RowHeadersWidth = 51;
            this.datatoado.RowTemplate.Height = 25;
            this.datatoado.Size = new System.Drawing.Size(573, 555);
            this.datatoado.TabIndex = 7;
            this.datatoado.RowsAdded += new System.Windows.Forms.DataGridViewRowsAddedEventHandler(this.datatoado_RowsAdded);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 50;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "x1";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 50;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "y1";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 50;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "x2";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 50;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "y2";
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 50;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "radius";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 50;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "P(KN)";
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Width = 60;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Q(KN/m)";
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            this.Column9.Width = 60;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Gray;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lbl);
            this.groupBox1.Controls.Add(this.numericUpDown1);
            this.groupBox1.Controls.Add(this.cbColor);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.groupBox1.Location = new System.Drawing.Point(983, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 113);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Pen";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Line Width :";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(6, 20);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(67, 15);
            this.lbl.TabIndex = 10;
            this.lbl.Text = "Color Line :";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(101, 46);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(166, 23);
            this.numericUpDown1.TabIndex = 9;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // cbColor
            // 
            this.cbColor.FormattingEnabled = true;
            this.cbColor.Location = new System.Drawing.Point(101, 18);
            this.cbColor.Name = "cbColor";
            this.cbColor.Size = new System.Drawing.Size(166, 23);
            this.cbColor.TabIndex = 0;
            this.cbColor.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.cbColor_DrawItem);
            this.cbColor.SelectedIndexChanged += new System.EventHandler(this.cbColor_SelectedIndexChanged);
            // 
            // btnGrid
            // 
            this.btnGrid.BackColor = System.Drawing.Color.White;
            this.btnGrid.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGrid.Location = new System.Drawing.Point(903, 12);
            this.btnGrid.Name = "btnGrid";
            this.btnGrid.Size = new System.Drawing.Size(75, 34);
            this.btnGrid.TabIndex = 11;
            this.btnGrid.Text = "Grid  On";
            this.btnGrid.UseVisualStyleBackColor = false;
            this.btnGrid.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnGrid_MouseDown);
            // 
            // btnSnap
            // 
            this.btnSnap.BackColor = System.Drawing.Color.White;
            this.btnSnap.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSnap.Location = new System.Drawing.Point(903, 52);
            this.btnSnap.Name = "btnSnap";
            this.btnSnap.Size = new System.Drawing.Size(75, 34);
            this.btnSnap.TabIndex = 12;
            this.btnSnap.Text = "Snap  On";
            this.btnSnap.UseVisualStyleBackColor = false;
            this.btnSnap.MouseDown += new System.Windows.Forms.MouseEventHandler(this.btnSnap_MouseDown);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(903, 91);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 33);
            this.button1.TabIndex = 13;
            this.button1.Text = "Hatch";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            this.button1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.button1_MouseClick);
            // 
            // picCKC
            // 
            this.picCKC.BackColor = System.Drawing.Color.White;
            this.picCKC.ContextMenuStrip = this.contextMenuStrip1;
            this.picCKC.Cursor = System.Windows.Forms.Cursors.Cross;
            this.picCKC.Location = new System.Drawing.Point(12, 131);
            this.picCKC.Name = "picCKC";
            this.picCKC.Size = new System.Drawing.Size(885, 526);
            this.picCKC.TabIndex = 0;
            this.picCKC.TabStop = false;
            this.picCKC.Paint += new System.Windows.Forms.PaintEventHandler(this.picCKC_Paint);
            this.picCKC.MouseClick += new System.Windows.Forms.MouseEventHandler(this.picCKC_MouseClick);
            this.picCKC.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picCKC_MouseDown);
            this.picCKC.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picCKC_MouseMove);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.White;
            this.btnClear.Location = new System.Drawing.Point(1275, 9);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(96, 34);
            this.btnClear.TabIndex = 14;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.White;
            this.btnExport.Location = new System.Drawing.Point(1275, 49);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(96, 37);
            this.btnExport.TabIndex = 15;
            this.btnExport.Text = "Export Excel";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(1491, 904);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.picCKC);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnSnap);
            this.Controls.Add(this.btnGrid);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.datatoado);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblToaDo);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Phần mềm cơ kết cấu";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datatoado)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picCKC)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblToaDo;
        private Panel panel1;
        private Button btnGoicodinh;
        private Button btnGoiDidong;
        private Button btnTTPhanbo;
        private Button btnTTtaptrung;
        private Button btnCircle;
        private Button btnRectangle;
        private Button btnLine;
        private Button btnNext;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem copyToolStripMenuItem;
        private ToolStripMenuItem pasteToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripMenuItem deleteToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem4;
        private ToolStripMenuItem exportToolStripMenuItem;
        private ToolStripMenuItem toolStripMenuItem6;
        private DataGridView datatoado;
        private GroupBox groupBox1;
        private Label label3;
        private Label lbl;
        private NumericUpDown numericUpDown1;
        public ComboBox cbColor;
        private Button btnGrid;
        private Button btnSnap;
        private Button button1;
        public Button btnBack;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private DataGridViewTextBoxColumn Column6;
        private DataGridViewTextBoxColumn Column7;
        private DataGridViewTextBoxColumn Column8;
        private DataGridViewTextBoxColumn Column9;
        public PictureBox picCKC;
        private Button button3;
        private Button button2;
        private ColorDialog ColorHatch;
        private Button btnClear;
        private Button btnExport;
    }
}