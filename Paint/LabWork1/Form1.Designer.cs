namespace LabWork1
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.canv = new System.Windows.Forms.PictureBox();
            this.Tools = new System.Windows.Forms.GroupBox();
            this.Clear = new System.Windows.Forms.Button();
            this.RightTriangle = new System.Windows.Forms.Button();
            this.Triangle = new System.Windows.Forms.Button();
            this.Line = new System.Windows.Forms.Button();
            this.Rhombus = new System.Windows.Forms.Button();
            this.Circle = new System.Windows.Forms.Button();
            this.Ellipse = new System.Windows.Forms.Button();
            this.Square = new System.Windows.Forms.Button();
            this.Rectangle = new System.Windows.Forms.Button();
            this.choseColor = new System.Windows.Forms.PictureBox();
            this.ChooseColor = new System.Windows.Forms.ColorDialog();
            ((System.ComponentModel.ISupportInitialize)(this.canv)).BeginInit();
            this.Tools.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.choseColor)).BeginInit();
            this.SuspendLayout();
            // 
            // canv
            // 
            this.canv.BackColor = System.Drawing.SystemColors.Window;
            this.canv.Location = new System.Drawing.Point(9, 10);
            this.canv.Margin = new System.Windows.Forms.Padding(2);
            this.canv.Name = "canv";
            this.canv.Size = new System.Drawing.Size(841, 501);
            this.canv.TabIndex = 0;
            this.canv.TabStop = false;
            this.canv.Paint += new System.Windows.Forms.PaintEventHandler(this.canv_Paint);
            this.canv.MouseDown += new System.Windows.Forms.MouseEventHandler(this.canv_MouseDown);
            this.canv.MouseMove += new System.Windows.Forms.MouseEventHandler(this.canv_MouseMove);
            this.canv.MouseUp += new System.Windows.Forms.MouseEventHandler(this.canv_MouseUp);
            // 
            // Tools
            // 
            this.Tools.Controls.Add(this.Clear);
            this.Tools.Controls.Add(this.RightTriangle);
            this.Tools.Controls.Add(this.Triangle);
            this.Tools.Controls.Add(this.Line);
            this.Tools.Controls.Add(this.Rhombus);
            this.Tools.Controls.Add(this.Circle);
            this.Tools.Controls.Add(this.Ellipse);
            this.Tools.Controls.Add(this.Square);
            this.Tools.Controls.Add(this.Rectangle);
            this.Tools.Location = new System.Drawing.Point(854, 10);
            this.Tools.Margin = new System.Windows.Forms.Padding(2);
            this.Tools.Name = "Tools";
            this.Tools.Padding = new System.Windows.Forms.Padding(2);
            this.Tools.Size = new System.Drawing.Size(112, 501);
            this.Tools.TabIndex = 2;
            this.Tools.TabStop = false;
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.White;
            this.Clear.Location = new System.Drawing.Point(11, 402);
            this.Clear.Margin = new System.Windows.Forms.Padding(2);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(88, 43);
            this.Clear.TabIndex = 12;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // RightTriangle
            // 
            this.RightTriangle.BackColor = System.Drawing.Color.White;
            this.RightTriangle.Location = new System.Drawing.Point(11, 307);
            this.RightTriangle.Margin = new System.Windows.Forms.Padding(2);
            this.RightTriangle.Name = "RightTriangle";
            this.RightTriangle.Size = new System.Drawing.Size(88, 44);
            this.RightTriangle.TabIndex = 11;
            this.RightTriangle.Text = "RightTriangle";
            this.RightTriangle.UseVisualStyleBackColor = false;
            this.RightTriangle.Click += new System.EventHandler(this.RightTriangle_Click);
            // 
            // Triangle
            // 
            this.Triangle.BackColor = System.Drawing.Color.White;
            this.Triangle.Location = new System.Drawing.Point(11, 260);
            this.Triangle.Margin = new System.Windows.Forms.Padding(2);
            this.Triangle.Name = "Triangle";
            this.Triangle.Size = new System.Drawing.Size(87, 43);
            this.Triangle.TabIndex = 9;
            this.Triangle.Text = "Triangle";
            this.Triangle.UseVisualStyleBackColor = false;
            this.Triangle.Click += new System.EventHandler(this.Triangle_Click);
            // 
            // Line
            // 
            this.Line.BackColor = System.Drawing.Color.White;
            this.Line.Location = new System.Drawing.Point(11, 24);
            this.Line.Margin = new System.Windows.Forms.Padding(2);
            this.Line.Name = "Line";
            this.Line.Size = new System.Drawing.Size(88, 43);
            this.Line.TabIndex = 5;
            this.Line.Text = "Line";
            this.Line.UseVisualStyleBackColor = false;
            this.Line.Click += new System.EventHandler(this.Line_Click);
            // 
            // Rhombus
            // 
            this.Rhombus.BackColor = System.Drawing.Color.White;
            this.Rhombus.Location = new System.Drawing.Point(11, 355);
            this.Rhombus.Margin = new System.Windows.Forms.Padding(2);
            this.Rhombus.Name = "Rhombus";
            this.Rhombus.Size = new System.Drawing.Size(88, 43);
            this.Rhombus.TabIndex = 4;
            this.Rhombus.Text = "Rhombus";
            this.Rhombus.UseVisualStyleBackColor = false;
            this.Rhombus.Click += new System.EventHandler(this.Rhombus_Click);
            // 
            // Circle
            // 
            this.Circle.BackColor = System.Drawing.Color.White;
            this.Circle.Location = new System.Drawing.Point(10, 166);
            this.Circle.Margin = new System.Windows.Forms.Padding(2);
            this.Circle.Name = "Circle";
            this.Circle.Size = new System.Drawing.Size(88, 43);
            this.Circle.TabIndex = 3;
            this.Circle.Text = "Circle";
            this.Circle.UseVisualStyleBackColor = false;
            this.Circle.Click += new System.EventHandler(this.Circle_Click);
            // 
            // Ellipse
            // 
            this.Ellipse.BackColor = System.Drawing.Color.White;
            this.Ellipse.Location = new System.Drawing.Point(11, 213);
            this.Ellipse.Margin = new System.Windows.Forms.Padding(2);
            this.Ellipse.Name = "Ellipse";
            this.Ellipse.Size = new System.Drawing.Size(88, 43);
            this.Ellipse.TabIndex = 2;
            this.Ellipse.Text = "Ellipse";
            this.Ellipse.UseVisualStyleBackColor = false;
            this.Ellipse.Click += new System.EventHandler(this.Ellipse_Click);
            // 
            // Square
            // 
            this.Square.BackColor = System.Drawing.Color.White;
            this.Square.Location = new System.Drawing.Point(10, 72);
            this.Square.Margin = new System.Windows.Forms.Padding(2);
            this.Square.Name = "Square";
            this.Square.Size = new System.Drawing.Size(88, 43);
            this.Square.TabIndex = 1;
            this.Square.Text = "Square";
            this.Square.UseVisualStyleBackColor = false;
            this.Square.Click += new System.EventHandler(this.Square_Click);
            // 
            // Rectangle
            // 
            this.Rectangle.BackColor = System.Drawing.Color.White;
            this.Rectangle.Location = new System.Drawing.Point(11, 119);
            this.Rectangle.Margin = new System.Windows.Forms.Padding(2);
            this.Rectangle.Name = "Rectangle";
            this.Rectangle.Size = new System.Drawing.Size(88, 43);
            this.Rectangle.TabIndex = 0;
            this.Rectangle.Text = "Rectangle";
            this.Rectangle.UseVisualStyleBackColor = false;
            this.Rectangle.Click += new System.EventHandler(this.Rectangle_Click);
            // 
            // choseColor
            // 
            this.choseColor.Location = new System.Drawing.Point(0, 0);
            this.choseColor.Name = "choseColor";
            this.choseColor.Size = new System.Drawing.Size(100, 50);
            this.choseColor.TabIndex = 3;
            this.choseColor.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(977, 517);
            this.Controls.Add(this.Tools);
            this.Controls.Add(this.canv);
            this.Controls.Add(this.choseColor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Paint";
            ((System.ComponentModel.ISupportInitialize)(this.canv)).EndInit();
            this.Tools.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.choseColor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox canv;
        private System.Windows.Forms.GroupBox Tools;
        private System.Windows.Forms.Button Line;
        private System.Windows.Forms.Button Rhombus;
        private System.Windows.Forms.Button Circle;
        private System.Windows.Forms.Button Ellipse;
        private System.Windows.Forms.Button Square;
        private System.Windows.Forms.Button Rectangle;
        private System.Windows.Forms.ColorDialog ChooseColor;
        private System.Windows.Forms.PictureBox choseColor;
        private System.Windows.Forms.Button RightTriangle;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button Triangle;
    }
}

