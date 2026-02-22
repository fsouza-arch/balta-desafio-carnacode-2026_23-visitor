using Visitor.Domain.DocumentStructure.Elements;

namespace Visitor.Domain.DocumentStructure.Visitors;

public interface IDocumentVisitor
{
    void VisitParagraph(Paragraph paragraph);
    void VisitImage(Image image);
    void VisitTable(Table table);
}
