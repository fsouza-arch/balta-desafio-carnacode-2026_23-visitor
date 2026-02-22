using Visitor.Domain.DocumentStructure.Visitors;

namespace Visitor.Domain.DocumentStructure.Elements;

public class Table : DocumentElement
{
    public List<List<string>> Cells { get; }

    public Table(int rows, int columns)
    {
        Cells = new List<List<string>>();

        for (int i = 0; i < rows; i++)
        {
            var row = new List<string>();
            for (int j = 0; j < columns; j++)
                row.Add($"Cell {i},{j}");

            Cells.Add(row);
        }
    }

    public override void Accept(IDocumentVisitor visitor)
    {
        visitor.VisitTable(this);
    }
}