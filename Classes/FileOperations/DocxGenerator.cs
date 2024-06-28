using System.Collections.Generic;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;
using JsonFileOperations;

namespace Generator_Spisu.Classes.FileOperations
{
    internal class DocxGenerator
    {
        public void GenerateDocument(string filePath, List<List<string>> data, string settingsPath)
        {
            JsonConfigLoader loader = new JsonConfigLoader();
            Config config = loader.LoadConfig(settingsPath);


            List<string> columnHeaders = config.settings.GetColumnHeaders();
            List<string> columnWidths = config.settings.ColumnWidths;


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

                AddTableHeader(table, columnHeaders, columnWidths);
                AddTableBorders(table);

                foreach (var rowData in data)
                {
                    AddTableRow(table, rowData, columnWidths);
                }

                body.Append(table);
            }
        }

        private void AddTableHeader(Table table, List<string> columnHeaders, List<string> columnWidths)
        {
            TableRow headerRow = new TableRow();

            for (int i = 0; i < columnHeaders.Count; i++)
            {
                TableCell headerCell = new TableCell();
                Paragraph headerParagraph = new Paragraph(new Run(new Text(columnHeaders[i])));
                headerCell.Append(new TableCellProperties(new TableCellWidth { Type = TableWidthUnitValues.Dxa, Width = columnWidths[i] }));
                headerCell.Append(headerParagraph);
                headerRow.Append(headerCell);
            }

            table.Append(headerRow);
        }

        private void AddTableRow(Table table, List<string> rowData, List<string> columnWidths)
        {
            TableRow row = new TableRow();

            for (int i = 0; i < rowData.Count; i++)
            {
                TableCell cell = new TableCell();
                Paragraph paragraph = new Paragraph(new Run(new Text(rowData[i])));
                cell.Append(new TableCellProperties(new TableCellWidth { Type = TableWidthUnitValues.Dxa, Width = columnWidths[i] }));
                cell.Append(paragraph);
                row.Append(cell);
            }

            table.Append(row);
        }

        private void AddTableBorders(Table table)
        {
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
