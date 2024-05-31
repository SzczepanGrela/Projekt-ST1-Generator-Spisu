using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace WindowsFormsApp1.interfaces
{
    internal interface IBasicFileOperations
    {


        void CreateFile(string filePath);

        void DeleteFile();

        void MoveFile(string newPath);

        void CopyFrom(string srcPath);

        void CopyTo(string destPath);


        void ConnectToFile(string filePath);

        void DisconnectFromFile();

        string FixExtension(string filePath);

        bool FileExists();

        bool IsConnected();






    }
}
