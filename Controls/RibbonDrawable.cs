using Microsoft.Maui.Graphics;

namespace MauiApp1.Controls;

public class RibbonDrawable : IDrawable
{
    public Color RibbonColor { get; set; } = Colors.Blue;

    public void Draw(ICanvas canvas, RectF dirtyRect)
    {
        canvas.FillColor = RibbonColor;
        float size = dirtyRect.Width;

        var path = new PathF();

        if (RibbonColor.ToHex().Equals("#8BC34A", StringComparison.OrdinalIgnoreCase))
        {
            // Green → top-left corner
            path.MoveTo(0, 0);
            path.LineTo(size, 0);
            path.LineTo(0, size);
        }
        else
        {
            // Blue → top-right corner
            path.MoveTo(size, 0);
            path.LineTo(0, 0);
            path.LineTo(size, size);
        }

        path.Close();
        canvas.FillPath(path);
    }
}
