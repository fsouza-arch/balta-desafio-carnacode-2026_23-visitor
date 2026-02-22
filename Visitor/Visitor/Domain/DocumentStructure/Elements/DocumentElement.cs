using Visitor.Domain.DocumentStructure.Visitors;

namespace Visitor.Domain.DocumentStructure.Elements;

public abstract class DocumentElement
{
    public abstract void Accept(IDocumentVisitor visitor);
}
