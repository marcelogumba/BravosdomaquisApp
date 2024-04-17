using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace BravosdomaquisApp.Controls
{
    [DefaultEvent("_TextChanged")]
    public partial class TextBoxUI : UserControl
    {
        private Color borderColor = Color.MediumSlateBlue;
        private int borderSize = 2;
        private bool underlinedStyle = false;
        private Color borderFocusColor = Color.HotPink;
        private bool isFocused = false;

        private int borderRadius = 0;
        private Color placeholderColor = Color.DarkGray;
        private string placeholderText = "";
        private bool isPlaceholder = false;
        private bool isPasswordChar = false;
        string hintText;
        public event EventHandler _TextChanged;
        public Color BorderColor
        {
            get { return borderColor; }
            set
            {
                borderColor = value;
                this.Invalidate();
            }
        }

        public int BorderSize
        {
            get { return borderSize; }
            set
            {
                borderSize = value;
                this.Invalidate();
            }
        }

        public bool UnderlinedStyle
        {
            get { return underlinedStyle; }
            set
            {
                underlinedStyle = value;
                this.Invalidate();
            }
        }

        public Color BorderFocusColor
        {
            get
            {
                return borderFocusColor;
            }

            set
            {
                borderFocusColor = value;
            }
        }

        public bool IsFocused
        {
            get
            {
                return isFocused;
            }

            set
            {
                isFocused = value;
            }
        }

        public bool PasswordChar
        {
            get { return textBox1.UseSystemPasswordChar; }
            set { textBox1.UseSystemPasswordChar = value; }
        }

        public bool Multiline
        {
            get { return textBox1.Multiline; }
            set { textBox1.Multiline = value; }
        }

        public string Texts
        {
            get
            {
                if (isPlaceholder) return "";
                else return textBox1.Text;
            }
            set
            {
                textBox1.Text = value;
                //SetPlaceholder();
            }
        }


        public TextBoxUI()
        {
            InitializeComponent();
        }

        public override Color BackColor
        {
            get
            {
                return base.BackColor;
            }

            set
            {
                base.BackColor = value;
                textBox1.BackColor = value;
            }
        }

        public override Color ForeColor
        {
            get
            {
                return base.ForeColor; 
            }

            set
            {
                base.ForeColor = value;
                textBox1.ForeColor = value;
            }
        }

        public override Font Font
        {
            get
            {
                return base.Font;
            }

            set
            {
                base.Font = value;
                textBox1.Font = value;
                if (this.DesignMode)
                    UpdateControlHeigth();
            }
        }

        public string Text
        {
            get
            {
                return textBox1.Text;
            }

            set
            {
                textBox1.Text = value;

            }
        }

        public int BorderRadius
        {
            get
            {
                return borderRadius;
            }

            set
            {
                if(value >= 0)
                {
                    borderRadius = value;
                    this.Invalidate();
                }
                
            }
        }

        public Color PlaceholderColor
        {
            get
            {
                return placeholderColor;
            }

            set
            {
                placeholderColor = value;
                if (isPlaceholder)
                    textBox1.ForeColor = value;
            }
        }

        public string PlaceholderText
        {
            get
            {
                return placeholderText;
            }

            set
            {
                placeholderText = value;
                textBox1.Text = "";
             //   SetPlaceholder();
            }
        }

        public bool IsPlaceholder
        {
            get
            {
                return isPlaceholder;
            }

            set
            {
                isPlaceholder = value;
            }
        }

        public bool IsPasswordChar
        {
            get
            {
                return isPasswordChar;
            }

            set
            {
                isPasswordChar = value;
            }
        }

        public string HintText
        {
            get
            {
                return hint.Text;
            }

            set
            {
                hint.Text = value;
            }
        }

        /* private void SetPlaceholder()
         {
             if (string.IsNullOrWhiteSpace(textBox1.Text) && placeholderText != "")
             {
                 isPlaceholder = true;
                 textBox1.Text = placeholderText;
                 textBox1.ForeColor = placeholderColor;
                 if (isPasswordChar)
                     textBox1.UseSystemPasswordChar = false;
             }
         }
         */

        private void RemovePlaceholder()
        {
            if (isPlaceholder && placeholderText != "")
            {
                isPlaceholder = false;
                textBox1.Text = "";
                textBox1.ForeColor = this.ForeColor;
                if (isPasswordChar)
                    textBox1.UseSystemPasswordChar = true;
            }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            Graphics graph = e.Graphics;
            if (borderRadius > 1)//Rounded TextBox
            {
                //-Fields
                var rectBorderSmooth = this.ClientRectangle;
                var rectBorder = Rectangle.Inflate(rectBorderSmooth, -borderSize, -borderSize);
                int smoothSize = borderSize > 0 ? borderSize : 1;
                using (GraphicsPath pathBorderSmooth = GetFigurePath(rectBorderSmooth, borderRadius))
                using (GraphicsPath pathBorder = GetFigurePath(rectBorder, borderRadius - borderSize))
                using (Pen penBorderSmooth = new Pen(this.Parent.BackColor, smoothSize))
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    //-Drawing
                    this.Region = new Region(pathBorderSmooth);//Set the rounded region of UserControl
                    if (borderRadius > 15) SetTextBoxRoundedRegion();//Set the rounded region of TextBox component
                    graph.SmoothingMode = SmoothingMode.AntiAlias;
                    penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;
                    if (isFocused) penBorder.Color = borderFocusColor;
                    if (underlinedStyle) //Line Style
                    {
                        //Draw border smoothing
                        graph.DrawPath(penBorderSmooth, pathBorderSmooth);
                        //Draw border
                        graph.SmoothingMode = SmoothingMode.None;
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    }
                    else //Normal Style
                    {
                        //Draw border smoothing
                        graph.DrawPath(penBorderSmooth, pathBorderSmooth);
                        //Draw border
                        graph.DrawPath(penBorder, pathBorder);
                    }
                }
            }
            else //Square/Normal TextBox
            {
                //Draw border
                using (Pen penBorder = new Pen(borderColor, borderSize))
                {
                    this.Region = new Region(this.ClientRectangle);
                    penBorder.Alignment = System.Drawing.Drawing2D.PenAlignment.Inset;
                    if (isFocused) penBorder.Color = borderFocusColor;
                    if (underlinedStyle) //Line Style
                        graph.DrawLine(penBorder, 0, this.Height - 1, this.Width, this.Height - 1);
                    else //Normal Style
                        graph.DrawRectangle(penBorder, 0, 0, this.Width - 0.5F, this.Height - 0.5F);
                }
            }
        }

        private void SetTextBoxRoundedRegion()
        {
            GraphicsPath pathTxt;
            if (Multiline)
            {
                pathTxt = GetFigurePath(textBox1.ClientRectangle, borderRadius - borderSize);
                textBox1.Region = new Region(pathTxt);
            }
            else
            {
                pathTxt = GetFigurePath(textBox1.ClientRectangle, borderSize * 2);
                textBox1.Region = new Region(pathTxt);
            }
            
        }

        protected override void OnResize(EventArgs e)
        {
            base.OnResize(e);
            if(this.DesignMode)
            UpdateControlHeigth();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            UpdateControlHeigth();

        }

        private void UpdateControlHeigth()
        {
             if(textBox1.Multiline == false)
            {
                int txtHeight = TextRenderer.MeasureText("Text", this.Font).Height + 1;
                textBox1.Multiline = true;
                textBox1.MinimumSize = new Size(0, txtHeight);
                textBox1.Multiline = false;

                this.Height = textBox1.Height + this.Padding.Top + this.Padding.Bottom;
            }
        }

        private GraphicsPath GetFigurePath(Rectangle rect, int radius) //Função para criação do retangulo arredondado
        {
            GraphicsPath path = new GraphicsPath();
            float curveSize = radius * 2F;
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, curveSize, curveSize, 180, 90);
            path.AddArc(rect.Right - curveSize, rect.Y, curveSize, curveSize, 270, 90);
            path.AddArc(rect.Right - curveSize, rect.Bottom - curveSize, curveSize, curveSize, 0, 90);
            path.AddArc(rect.X, rect.Bottom - curveSize, curveSize, curveSize, 90, 90);
            path.CloseFigure();
            return path;
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            if (_TextChanged != null)
                _TextChanged.Invoke(sender, e);
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            this.OnClick(e);
        }

        private void textBox1_MouseEnter(object sender, EventArgs e)
        {
            this.OnMouseEnter(e);
        }

        private void textBox1_MouseLeave(object sender, EventArgs e)
        {
            this.OnMouseLeave(e);
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            this.OnKeyPress(e);
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                timer1.Start();
            }
           // isFocused = true;
           // this.Invalidate();
            //RemovePlaceholder();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                timer1.Start();
            }
           // isFocused = false;
            //this.Invalidate();
           // SetPlaceholder();
        }

        private void timer1_Tick(object sender, EventArgs e) //Função timer usada para fazer a movimentação da label hint
        {
            int y = hint.Location.Y;
            if(isFocused == false)
            {
                y -= 2;
                hint.Location = new Point(hint.Location.X, y);
                if(y <=-2)
                {
                    isFocused = true;
                    timer1.Stop();
                    hint.ForeColor = Color.DimGray;
                    hint.BackColor = this.BackColor;
                    hint.Font = new Font("Montserrat", 7);
                    y = -2;
                }
            }
            else
            {
                y += 2;
                hint.Location = new Point(hint.Location.X, y);
                if (y >= 8)
                {
                    isFocused = false;
                    timer1.Stop();
                    y = 8;
                    hint.BackColor = this.BackColor;
                    hint.ForeColor = Color.DimGray;
                    hint.Font = new Font("Montserrat", 8);

                }
            }
        }

        private void label1_Click(object sender, EventArgs e) 
        {
            textBox1.Focus();
        }

        public void SetColor() //Reatribui as cores dos componentes!
        {
            hint.BackColor = this.BackColor;
        }
    }
}
