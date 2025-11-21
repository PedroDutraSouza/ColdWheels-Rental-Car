using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

public class PanelVidroArredondado : Panel
{
    public int Opacidade { get; set; } = 125;
    public Color CorDoVidro { get; set; } = Color.White;
    public int RaioBorda { get; set; } = 20;

    public PanelVidroArredondado()
    {
        // CORREÇÃO PRINCIPAL AQUI:
        // Habilita transparência real
        this.SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        this.SetStyle(ControlStyles.Opaque, false); // Isso garante que o fundo seja pintado
        this.SetStyle(ControlStyles.ResizeRedraw, true);
        this.SetStyle(ControlStyles.UserPaint, true);
        this.SetStyle(ControlStyles.AllPaintingInWmPaint, true);

        this.BackColor = Color.Transparent;
        this.DoubleBuffered = true;
    }

    protected override void OnPaint(PaintEventArgs e)
    {
        // Configura a qualidade gráfica para alta (anti-serrilhado)
        e.Graphics.SmoothingMode = SmoothingMode.HighQuality;
        e.Graphics.PixelOffsetMode = PixelOffsetMode.HighQuality;

        // Define o retângulo
        Rectangle rect = this.ClientRectangle;
        rect.Width--; rect.Height--;

        using (GraphicsPath path = GetRoundedPath(rect, RaioBorda))
        using (Brush brush = new SolidBrush(Color.FromArgb(Opacidade, CorDoVidro)))
        using (Pen pen = new Pen(Color.FromArgb(80, 255, 255, 255), 1))
        {
            // 1. Pinta o vidro (cor semitransparente)
            e.Graphics.FillPath(brush, path);

            // 2. Pinta a borda
            e.Graphics.DrawPath(pen, path);
        }

        // Não chamamos base.OnPaint(e) aqui para evitar bugs de pintura padrão
    }

    private GraphicsPath GetRoundedPath(Rectangle rect, int radius)
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