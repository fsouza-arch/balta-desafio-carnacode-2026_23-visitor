using Visitor.Domain.Documents;
using Visitor.Domain.DocumentStructure.Elements;
using Visitor.Domain.DocumentStructure.Visitors;

var doc = new Document("Relatório Anual");

doc.AddElement(new Paragraph("Este é o relatório anual da empresa."));
doc.AddElement(new Image("grafico.png", 800, 600));
doc.AddElement(new Table(2, 3));

// Exportação HTML
var htmlVisitor = new HtmlExportVisitor();
doc.Accept(htmlVisitor);

Console.WriteLine(htmlVisitor.GetHtml(doc.Title));

// Contagem de palavras
var wordVisitor = new WordCountVisitor();
doc.Accept(wordVisitor);

Console.WriteLine($"\nTotal de palavras: {wordVisitor.TotalWords}");