using System;
using System.Dynamic;
using System.IO;

namespace File_Handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string filePath = "C:\\Users\\Raj\\source\\repos\\Datatypes and Variables\\File Handling\\Test Files\\a.txt";
            //string destinationFilePath = "C:\\Users\\Raj\\source\\repos\\Datatypes and Variables\\File Handling\\Test Files\\desitinationFile.txt";

            string filePath = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\Test Files\a.txt");
            string destinationPath = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\Test Files\");

            Console.WriteLine(filePath);
            //Writing to Files -> Stream Writer
            StreamWriter streamWriter = null;
            try
            {
                streamWriter = new StreamWriter(filePath);
                streamWriter.WriteLine("Hello This is a demo text File");
                streamWriter.WriteLine("This is line number 2");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                streamWriter.Close();
            }

            //Reading from Files -> Stream Reader
            try
            {
                using (StreamReader streamReader = new StreamReader(filePath))
                {
                    string content = streamReader.ReadToEnd();
                    Console.WriteLine(content);
                    //Closing not required as stream reader is used inside a using directive
                }
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"{ex.FileName} not found");
            }

            //Copy one file to another.
            //File.Copy(filePath, destinationFilePath);

            //Delete a file
            //File.Delete(destinationFilePath);

            //FileInfo Class

            string newFilePath = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\Test Files\newFile.txt");
            FileInfo fileInfo = new FileInfo(newFilePath);

            //Create a File
            //FileStream fileStream = fileInfo.Create();

            //Write in a file
            StreamWriter sw = fileInfo.CreateText();
            sw.WriteLine("This is a newFile for FileInfo class");
            sw.Close();

            //Delete the file
            //fileInfo.Delete();

            //Copy a File
            //string copiedFilePath = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\Copy\copiedFile.txt");
            //fileInfo.CopyTo(copiedFilePath);

            //Read a file
            StreamReader streamReader1 = fileInfo.OpenText();
            Console.WriteLine(streamReader1?.ReadLine());

            //File details
            Console.WriteLine($"Filename: {fileInfo.Name}\nFile Creation Time: {fileInfo.CreationTime}");

            Console.ReadKey();
        }
    }
}
