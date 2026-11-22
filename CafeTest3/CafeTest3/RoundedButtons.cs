using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CafeTest3
{

public class RoundedButton : Button
{
    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public int BorderRadius { get; set; } = 8;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public Color BorderColor { get; set; } = Color.Transparent;

    [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
    public int BorderSize { get; set; } = 0;

    public RoundedButton()
    {
        this.FlatStyle = FlatStyle.Flat;
        this.FlatAppearance.BorderSize = 0;
        this.Cursor = Cursors.Hand;
    }

    protected override void OnPaint(PaintEventArgs pevent)
    {
        base.OnPaint(pevent);
        pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

        Rectangle rectSurface = this.ClientRectangle;
        Rectangle rectBorder = Rectangle.Inflate(rectSurface, -BorderSize, -BorderSize);
        Color parentColor = this.Parent?.BackColor ?? Color.White;

        using (GraphicsPath pathSurface = GetFigurePath(rectSurface, BorderRadius))
        using (GraphicsPath pathBorder = GetFigurePath(rectBorder, BorderRadius - BorderSize))
        using (Pen penSurface = new Pen(parentColor, 2))
        using (Pen penBorder = new Pen(BorderColor, BorderSize))
        {
            this.Region = new Region(pathSurface);
            pevent.Graphics.DrawPath(penSurface, pathSurface);

            if (BorderSize >= 1)
                pevent.Graphics.DrawPath(penBorder, pathBorder);
        }
    }

        private GraphicsPath GetFigurePath(Rectangle rect, int radius)
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
    }
}