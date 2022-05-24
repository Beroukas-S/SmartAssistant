using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace SmartAssistant.CustomControls
{
    public class ToggleButton : CheckBox
    {
        //Fields
        private Color onBGColor = Color.Green;
        private Color onSwitchColor = Color.GreenYellow;
        private Color offBGColor = Color.Red;
        private Color offSwitchColor = Color.Yellow;

        //Properties
        public Color OnBGColor { get => onBGColor; set => onBGColor = value; }
        public Color OnSwitchColor { get => onSwitchColor; set => onSwitchColor = value; }
        public Color OffBGColor { get => offBGColor; set => offBGColor = value; }
        public Color OffSwitchColor { get => offSwitchColor; set => offSwitchColor = value; }

        //Constructor 
        public ToggleButton()
        {
            this.MinimumSize = new Size(45, 25);
        }

        //Methods
        private GraphicsPath GetFigurePath()
        {
            int arcSize = this.Height - 1;
            Rectangle leftArc = new Rectangle(0, 0, arcSize, arcSize);
            Rectangle rightArc = new Rectangle(this.Width - arcSize - 2, 0, arcSize, arcSize);

            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(leftArc, 90, 180);
            path.AddArc(rightArc, 270, 180);
            path.CloseFigure();

            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            int toggleSize = this.Height - 5;
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            pevent.Graphics.Clear(this.Parent.BackColor);

            if (this.Checked) //ON
            {
                //Draw control
                pevent.Graphics.FillPath(new SolidBrush(onBGColor), GetFigurePath());
                //Draw switch
                pevent.Graphics.FillEllipse(new SolidBrush(onSwitchColor),
                    new Rectangle(this.Width - this.Height + 1, 2, toggleSize, toggleSize));
            }
            else //off
            {
                //Draw control
                pevent.Graphics.FillPath(new SolidBrush(offBGColor), GetFigurePath());
                //draw switch
                pevent.Graphics.FillEllipse(new SolidBrush(offSwitchColor),
                    new Rectangle(2, 2, toggleSize, toggleSize));
            }
        }

    }
}
