using Visitor.Domain.DocumentStructure.Visitors;

namespace Visitor.Domain.DocumentStructure.Elements;

public class Image : DocumentElement
{
    public string Url { get; }
    public int Width { get; }
    public int Height { get; }
    public string Alt { get; }

    public Image(string url, int width, int height)
    {
        Url = url;
        Width = width;
        Height = height;
        Alt = "";
    }

    public override void Accept(IDocumentVisitor visitor)
    {
        visitor.VisitImage(this);
    }
}