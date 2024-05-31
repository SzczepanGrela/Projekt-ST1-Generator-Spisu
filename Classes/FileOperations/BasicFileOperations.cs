using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.interfaces;

namespace WindowsFormsApp1.classes.FileOperations
{
    internal abstract class BasicFileOperations : IBasicFileOperations
    {
        protected FileStream fs;
        protected StreamReader sr;
        protected StreamWriter sw;
        protected string filePath = null;
        protected string correctExtension = null;
        protected HashSet<string> knownExtensions = new HashSet<string>
        { "txt", "doc", "docx", "pdf", "rtf", "jpg", "png", "xls", "csv", "sql", "json", "html" };
        // set of file types that could be used in this application, and mistakenly typed by user in wrong class



        public BasicFileOperations(string filePath, string correctExtension)
        {
            this.correctExtension = correctExtension;
            this.filePath = FixExtension(filePath);

            if (!FileExists()) 

            CreateFile(filePath);
        }

        public BasicFileOperations(string correctExtension)
        {
            this.correctExtension = correctExtension;
        }


        public void CreateFile(string filePath)  // doesn't overwrite the file if it already exists
        {
            
            
                this.filePath = FixExtension(filePath);  // connecting to the new path
           
            

            if (FileExists())
            {
                throw new IOException("File already exists");
            }

            fs = new FileStream(this.filePath, FileMode.Create);

            fs.Close();
        }

        public void DeleteFile()
        {
            if (IsConnected())
            {
                File.Delete(this.filePath);
                this.filePath = null;   // deleting file also disconnects from it, thus (connect!=null) -> file exists
            }
            else
            {
                throw new FileNotFoundException("Tried to delete, when not connected to a file");
            }

        }


        public bool FileExists() // checks if the connnected file exists
        {
            if (!IsConnected())
            {
                return false; // if we are not connected to a file, we don't even know what file we are looking for
            }
            return File.Exists(filePath);
        }

        public void CopyFrom(string srcPath)  // this method overwrites the file if it already exists
        {
            if (!IsConnected())
            {
                throw new Exception("Not connected to a file");
            }

            if (!File.Exists(srcPath))
            {
                throw new FileNotFoundException("File not found");
            }
            else
            {
                File.Copy(srcPath, filePath, true);
            }

        }

        public void CopyTo(string destPath) // doesn't overwrite in designated path 
        {
            if (File.Exists(destPath))
            {
                throw new IOException("File already exists");
            }
            else if (!FileExists())
            {
                throw new FileNotFoundException("File not found");
            }
            else
            {
                File.Copy(filePath, destPath);
            }

        }

        public void MoveFile(string destPath)
        {
            if (FileExists())
            {
                File.Move(filePath, destPath);
                filePath = destPath;
            }
            else
            {
                throw new FileNotFoundException("File not found");
            }

        }

        public void ConnectToFile(string filePath)
        {
                
            if (IsConnected())
            {
                throw new IOException("Already connected to a file");
            }

            this.filePath = FixExtension(filePath);   //connecting to the new path

            if(!FileExists()) CreateFile(this.filePath);  //  creating file if it doesn't exist


        }

        public void DisconnectFromFile()
        {
            if (IsConnected())
            {
                filePath = null;
            }
            else
            {
                throw new IOException("Not connected to a file");
            }
        }

        public bool IsConnected()
        {

            if(filePath == null)    //  if filePath is null, we are not connected to a file
            {
                return false;
            }
           
            else
            {
                return true;
            }
            
        }

        public string FixExtension(string filePath)
        {

            if (correctExtension == null)
            {
                throw new ArgumentNullException("correctFormat", "correctFormat not found");
            }

            for (int i = filePath.Length - 1; i > 0; i--)
            {
                if (filePath[i] == '.')
                {
                    string extension = filePath.Substring(i + 1);

                    if (extension == correctExtension)    //  expected extension, no need to change anything
                    {
                        return filePath;
                    }
                    else if (knownExtensions.Contains(extension))     // wrong extension, possible user mistake
                    {
                        throw new FormatException("Wrong file Format " + extension);

                    }
                    else   //  wrong extension, that's not used in this program. Most likely misspelled
                    {
                        return  filePath.Substring(0, i+1) + correctExtension;

                    }
                }
                else if (filePath[i] == '\\')  //  there is no dot in the path
                {
                    return filePath + "." + correctExtension;

                }



            }

            return filePath + "." + correctExtension;  // no dot nor backslash in the path
        }



       
          


        
        
    }
}


