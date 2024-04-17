using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace BravosdomaquisApp.Controls
{
    public class ToogleButton : CheckBox
    {
        private Color onBackColor = Color.MediumSlateBlue;
        private Color onTooglekColor = Color.WhiteSmoke;
        private Color offBackColor = Color.Gray;
        private Color offToogleColor = Color.Gainsboro;

        public Color OnBackColor
        {
            get
            {
                return onBackColor;
            }

            set
            {
                onBackColor = value;
                this.Invalidate();
            }
        }

        public Color OnTooglekColor
        {
            get
            {
                return onTooglekColor;
            }

            set
            {
                onTooglekColor = value;
                this.Invalidate();

            }
        }

        public Color OffBackColor
        {
            get
            {
                return offBackColor;
            }

            set
            {
                offBackColor = value;
                this.Invalidate();
            }
        }

        public Color OffToogleColor
        {
            get
            {
                return offToogleColor;
            }

            set
            {
                offToogleColor = value;
                this.Invalidate();
            }
        }
        public override string Text
        {
            get
            {
                return base.Text;
            }

            set
            {
                
            }
        }

        public ToogleButton()
        {
            this.MinimumSize = new Size(45,30);
            this.BackColor = Color.Transparent;

        }

        private GraphicsPath GetFigurePath()
        {
            int arcSize = this.Height - 1;
            Rectangle leftArc = new Rectangle(0,0, arcSize, arcSize);
            Rectangle RightArc = new Rectangle(this.Width - arcSize - 2, 0, arcSize, arcSize);

            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(leftArc, 90, 180);
            path.AddArc(RightArc, 270, 180);
            path.CloseFigure();

            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            int toogleSize = this.Height - 5;
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            pevent.Graphics.Clear (this.Parent.BackColor);

            if (this.Checked)
            {
                pevent.Graphics.FillPath(new SolidBrush(onBackColor), GetFigurePath() );

                pevent.Graphics.FillEllipse(new SolidBrush(onTooglekColor), 
                    new Rectangle(this.Width - this.Height+1,2,toogleSize,toogleSize));

            }
            else
            {
                pevent.Graphics.FillPath(new SolidBrush(offBackColor), GetFigurePath());

                pevent.Graphics.FillEllipse(new SolidBrush(offToogleColor),
                    new Rectangle(2, 2, toogleSize, toogleSize));
            }
        }
    }
}
