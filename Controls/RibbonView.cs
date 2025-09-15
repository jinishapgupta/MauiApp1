using Microsoft.Maui.Controls;
using Microsoft.Maui.Controls.Shapes;
using Microsoft.Maui.Graphics;

namespace MauiApp1.Controls;

public class RibbonView : GraphicsView
{
    private readonly RibbonDrawable _drawable;

    public static readonly BindableProperty RibbonColorProperty =
        BindableProperty.Create(
            nameof(RibbonColor),
            typeof(string),
            typeof(RibbonView),
            "#1976D2", // default = blue
            propertyChanged: OnRibbonColorChanged);

    public string RibbonColor
    {
        get => (string)GetValue(RibbonColorProperty);
        set => SetValue(RibbonColorProperty, value);
    }

    public RibbonView()
    {
        _drawable = new RibbonDrawable();
        Drawable = _drawable;

        HeightRequest = 75;
        WidthRequest = 85;
        Clip = new RoundRectangleGeometry
        {
            CornerRadius = new CornerRadius(0, 7, 10, 0),
            Rect = new Rect(0, 0, 60, 60)
        };
    }

    private static void OnRibbonColorChanged(BindableObject bindable, object oldValue, object newValue)
    {
        if (bindable is RibbonView view && newValue is string hex)
        {
            try
            {
                view._drawable.RibbonColor = Color.FromArgb(hex);
            if (hex.Equals("#8BC34A", StringComparison.OrdinalIgnoreCase))
                {
                    
                    view.HeightRequest = 50;
                    view.WidthRequest = 30;
                    view.Clip = new RoundRectangleGeometry
                    {
                        CornerRadius = new CornerRadius(7, 0, 0, 7),
                        Rect = new Rect(0, 0, view.HeightRequest, view.WidthRequest)
                    };
                }
                else
                {
                    view.Clip = new RoundRectangleGeometry
                    {
                        CornerRadius = new CornerRadius(0, 7, 0, 7),
                        Rect = new Rect(0, 0, view.WidthRequest, view.HeightRequest)
                    };
                }

                view.Invalidate();
            }
            catch
            {
                view._drawable.RibbonColor = Colors.Blue;
            }
        }
    }
}
