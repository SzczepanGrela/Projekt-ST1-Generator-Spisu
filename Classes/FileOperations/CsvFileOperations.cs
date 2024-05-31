using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.interfaces;
using System.IO;
using System.Windows.Forms;
using System.Linq.Expressions;


namespace WindowsFormsApp1.classes.FileOperations
{
    internal class CsvFileOperations : BasicFileOperations, ITextFileOperations
    {


        public CsvFileOperations() : base("csv")
        {

        }

        public CsvFileOperations(string filePath) : base(filePath, "csv")
        // calling constructor of the base class, setting this instance's correctExtension to "txt" and filePath to the value passed as argument

        {

        }




        public void WriteFile(params string[] content)      // single string or array thankns to params
        {
            if (IsConnected())
            {
                using (sw = new StreamWriter(this.filePath, false)) // will overwrite
                {
                    foreach (string line in content)
                    {
                        sw.WriteLine(line);
                    }
                }
            }
            else
            {
                throw new FileNotFoundException("Tried to write, when not connected to a file");
            }

        }



        public void UpdateFile(int[] lineIndex, params string[] content)
        {
            if (!IsConnected())
            {
                throw new FileNotFoundException("Tried to update, when not connected to a file");
            }
            else if (lineIndex.Length != content.Length)
            {
                throw new ArgumentException("Number of lines to update and number of new lines must be equal");
            }

            string[] copiedFile = ReadFile();

            for (int i = 0; i < content.Length - 1; i++)
            {
                if (lineIndex[i] < 0)
                {
                    throw new ArgumentOutOfRangeException("Line number cannot be negative");
                }
                else if (lineIndex[i] > copiedFile.Length)
                {
                    throw new ArgumentOutOfRangeException("Line number cannot be greater than number of lines in the file");
                }
                else
                {
                    copiedFile[lineIndex[i]] = content[i];

                }
            }
            WriteFile(copiedFile);
        }


        public void AppendToFile(params string[] content)
        {
            if (!IsConnected())
            {
                throw new FileNotFoundException("Tried to append, when not connected to a file");
            }

            using (sw = new StreamWriter(this.filePath, true))
            {
                foreach (string line in content)
                {
                    sw.WriteLine(line);
                }
            }
        }
        public string[] ReadFile()
        {

            if (!IsConnected())
            {
                throw new FileNotFoundException("Tried to read, when not connected to a file");
            }
            List<string> lines = new List<string>();
            using (sr = new StreamReader(this.filePath))
            {
                while (!sr.EndOfStream)
                {
                    lines.Add(sr.ReadLine());
                }

            }
            return lines.ToArray();
        }

        public string[] FindMatchingRecords(string key, int column, bool expectSingle = false) // column is the index of column in which we are looking for the key
        {

            string[] lines = ReadFile();

            List<string> matchingRows = new List<string>();  // rows that match the key

            foreach (string line in lines)
            {
                string[] columns = line.Split(';');
                if (columns[column] == key)
                {
                    matchingRows.Add(line);

                }
            }
            if (expectSingle && matchingRows.Count > 1)
            {
                throw new InvalidOperationException("Expected single record, found multiple");
            }
            else if (matchingRows.Count == 0)
            {
                return null;
            }
            else return matchingRows.ToArray();

        }






    }
}
