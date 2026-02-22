using Visitor.Domain.DocumentStructure.Elements;

namespace Visitor.Domain.DocumentStructure.Visitors;

public class WordCountVisitor : IDocumentVisitor
{
    public int TotalWords { get; private set; }

    public void VisitParagraph(Paragraph paragraph)
    {
        TotalWords += paragraph.Text
            .Split(' ', StringSplitOptions.RemoveEmptyEntries)
            .Length;
    }

    public void VisitImage(Image image)
    {
        // imagens não contam
    }

    public void VisitTable(Table table)
    {
        foreach (var row in table.Cells)
            foreach (var cell in row)
                TotalWords += cell
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .Length;
    }
}
