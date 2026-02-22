using System.Text;
using Visitor.Domain.DocumentStructure.Elements;

namespace Visitor.Domain.DocumentStructure.Visitors;

public class HtmlExportVisitor : IDocumentVisitor
{
    private StringBuilder _builder = new();

    public string GetHtml(string title)
    {
        return $"<html><head><title>{title}</title></head><body>{_builder}</body></html>";
    }

    public void VisitParagraph(Paragraph paragraph)
    {
        _builder.Append(
            $"<p style='font-family:{paragraph.FontFamily};font-size:{paragraph.FontSize}px'>" +
            $"{paragraph.Text}</p>");
    }

    public void VisitImage(Image image)
    {
        _builder.Append(
            $"<img src='{image.Url}' width='{image.Width}' height='{image.Height}' alt='{image.Alt}' />");
    }

    public void VisitTable(Table table)
    {
        _builder.Append("<table>");

        foreach (var row in table.Cells)
        {
            _builder.Append("<tr>");
            foreach (var cell in row)
                _builder.Append($"<td>{cell}</td>");
            _builder.Append("</tr>");
        }

        _builder.Append("</table>");
    }
}