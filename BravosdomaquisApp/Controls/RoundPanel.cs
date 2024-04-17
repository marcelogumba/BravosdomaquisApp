using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class RoundPanel : Panel
{
    int cornerRadius = 30;

    public int CornerRadius
    {
        get
        {
            return cornerRadius;
        }

        set
        {
            cornerRadius = value;
        }
    }
    public void ResetPanel()
    {
        base.Refresh();
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        GraphicsPath graphicsPath = new GraphicsPath();
        // Ajuste este valor para alterar o raio das bordas arredondadas
        graphicsPath.AddArc(0, 0, CornerRadius, CornerRadius, 180, 90);
        graphicsPath.AddArc(Width - CornerRadius, 0, CornerRadius, CornerRadius, 270, 90);
        graphicsPath.AddArc(Width - CornerRadius, Height - CornerRadius, CornerRadius, CornerRadius, 0, 90);
        graphicsPath.AddArc(0, Height - CornerRadius, CornerRadius, CornerRadius, 90, 90);
        this.Region = new Region(graphicsPath);
        base.OnPaint(e);
       
    }
}
