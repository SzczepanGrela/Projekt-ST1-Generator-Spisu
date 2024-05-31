using System.Collections.Generic;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

namespace Generator_Spisu.Classes.FileOperations
{
    internal class DocxGenerator
    {
        public void GenerateDocument(string filePath, List<List<object>> data, List<string> columnHeaders)
        {
            using (WordprocessingDocument wordDocument = WordprocessingDocument.Create(filePath, WordprocessingDocumentType.Document))
            {
                MainDocumentPart mainPart = wordDocument.AddMainDocumentPart();
                mainPart.Document = new Document();
                Body body = mainPart.Document.AppendChild(new Body());

                Table table = new Table();

                
                TableProperties tableProperties = new TableProperties(
                    new TableWidth { Width = "5000", Type = TableWidthUnitValues.Pct },
                    new TableIndentation { Width = 0, Type = TableWidthUnitValues.Dxa },
                    new TableLayout { Type = TableLayoutValues.Fixed },
                    new TableJustification { Val = TableRowAlignmentValues.Left }
                );

                table.AppendChild(tableProperties);

                
                AddTableHeader(table, columnHeaders);

                AddTableBorders(table);

                // Add rows to the table
                foreach (var rowData in data)
                {
                    AddTableRow(table, rowData);
                }

                body.Append(table);
            }
        }

        private void AddTableHeader(Table table, List<string> columnHeaders)
        {
            TableRow headerRow = new TableRow();

            foreach (string headerText in columnHeaders)
            {
                TableCell headerCell = new TableCell();
                Paragraph headerParagraph = new Paragraph(new Run(new Text(headerText)));
                headerCell.Append(new TableCellProperties(new TableCellWidth { Type = TableWidthUnitValues.Auto }));
                headerCell.Append(headerParagraph);
                headerRow.Append(headerCell);
            }

            table.Append(headerRow);
        }

        private void AddTableRow(Table table, List<object> rowData)
        {
            TableRow row = new TableRow();

            foreach (var cellData in rowData)
            {
                TableCell cell = new TableCell();
                Paragraph paragraph = new Paragraph(new Run(new Text(cellData.ToString())));
                cell.Append(new TableCellProperties(new TableCellWidth { Type = TableWidthUnitValues.Auto }));
                cell.Append(paragraph);
                row.Append(cell);
            }

            table.Append(row);
        }


        private void AddTableBorders(Table table)
        {
            // Add table borders
            TableBorders tableBorders = new TableBorders(
                new TopBorder { Val = new EnumValue<BorderValues>(BorderValues.Single), Size = 12 },
                new BottomBorder { Val = new EnumValue<BorderValues>(BorderValues.Single), Size = 12 },
                new LeftBorder { Val = new EnumValue<BorderValues>(BorderValues.Single), Size = 12 },
                new RightBorder { Val = new EnumValue<BorderValues>(BorderValues.Single), Size = 12 },
                new InsideHorizontalBorder { Val = new EnumValue<BorderValues>(BorderValues.Single), Size = 12 },
                new InsideVerticalBorder { Val = new EnumValue<BorderValues>(BorderValues.Single), Size = 12 }
            );

            table.GetFirstChild<TableProperties>().Append(tableBorders);
        }

    }
}
