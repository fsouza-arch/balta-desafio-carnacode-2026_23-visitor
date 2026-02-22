using Visitor.Domain.DocumentStructure.Visitors;

namespace Visitor.Domain.DocumentStructure.Elements;

public class Paragraph : DocumentElement
{
    public string Text { get; }
    public string FontFamily { get; }
    public int FontSize { get; }

    public Paragraph(string text)
    {
        Text = text;
        FontFamily = "Arial";
        FontSize = 12;
    }

    public override void Accept(IDocumentVisitor visitor)
    {
        visitor.VisitParagraph(this);
    }
}
