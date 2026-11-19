using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class SmoothPanel : Panel
{
    private int _borderRadius = 20;
    private Color _borderColor = Color.LightGray;
    private int _borderSize = 1;

    [Category("Appearance")]
    public int BorderRadius
    {
        get => _borderRadius;
        set { _borderRadius = Math.Max(0, value); Invalidate(); }
    }

    [Category("Appearance")]
    public Color BorderColor
    {
        get => _borderColor;
        set { _borderColor = value; Invalidate(); }
    }

    [Category("Appearance")]
    public int BorderSize
    {
        get => _borderSize;
        set { _borderSize = Math.Max(0, value); Invalidate(); }
    }

    public SmoothPanel()
    {
        this.DoubleBuffered = true; // Prevents flickering
        this.BackColor = Color.White;
        this.ResizeRedraw = true;   // Redraws cleanly when resized
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);
        e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

        RectangleF rectSurface = this.ClientRectangle;
        RectangleF rectBorder = RectangleF.Inflate(rectSurface, -_borderSize, -_borderSize);
        int smoothSize = _borderSize > 0 ? _borderSize : 2;

        if (_borderRadius > 2) // Rounded panel
        {
            using (GraphicsPath pathSurface = GetFigurePath(rectSurface, _borderRadius))
            using (GraphicsPath pathBorder = GetFigurePath(rectBorder, _borderRadius - _borderSize))
            using (Pen penSurface = new Pen(this.Parent?.BackColor ?? Color.Transparent, smoothSize))
            using (Pen penBorder = new Pen(_borderColor, _borderSize))
            {
                penBorder.Alignment = PenAlignment.Inset;
                this.Region = new Region(pathSurface);

                // Draw surface border for HD result (blends jagged edges)
                e.Graphics.DrawPath(penSurface, pathSurface);

                // Draw control border
                if (_borderSize >= 1)
                    e.Graphics.DrawPath(penBorder, pathBorder);
            }
        }
        else // Normal rectangular panel
        {
            this.Region = new Region(rectSurface);
            if (_borderSize >= 1)
            {
                using (Pen penBorder = new Pen(_borderColor, _borderSize))
                {
                    penBorder.Alignment = PenAlignment.Inset;
                    e.Graphics.DrawRectangle(penBorder, 0, 0, this.Width - 1, this.Height - 1);
                }
            }
        }
    }

    private GraphicsPath GetFigurePath(RectangleF rect, float radius)
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
