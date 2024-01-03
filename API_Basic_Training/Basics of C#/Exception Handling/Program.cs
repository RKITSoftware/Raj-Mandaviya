using System;
using System.IO;

namespace Exception_Handling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Exceptions

            StreamReader streamReader = null;
            try
            {
                string filePath = "C:\\Users\\Raj\\source\\repos\\Datatypes and Variables\\Exception Handling\\Extra Files\\tex.txt";
                //Reading a file
                streamReader = new StreamReader(filePath);

                string fileContent = streamReader.ReadToEnd();
                Console.WriteLine(fileContent);

            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine($"Please check if the file {ex.FileName} exists!");
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine($"The folder doesnot exist");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                streamReader?.Close(); //null conditional Operator
                Console.WriteLine("Stream Reader closed");
            }

            //Inner Exceptions
            try
            {
                StreamWriter streamWriter = null;
                try
                {
                    Console.Write("Enter first number: ");
                    int numberOne = Convert.ToInt32(Console.ReadLine());


                    Console.Write("Enter second number: ");
                    int numberTwo = Convert.ToInt32(Console.ReadLine());

                    Console.WriteLine("Result: " + (numberOne / numberTwo));
                }
                catch (Exception ex)
                {
                    string filePath = "C:\\Users\\Raj\\source\\repos\\Datatypes and Variables\\Exception Handling\\Extra Files\\logs.txt";
                    if (File.Exists(filePath))
                    {
                        streamWriter = new StreamWriter(filePath);
                        streamWriter.Write(ex.GetType().Name);
                        Console.WriteLine("There is a Problem");
                    }
                    else
                    {
                        throw new FileNotFoundException(filePath + " is not present", ex);
                    }
                }
                finally
                {
                    streamWriter?.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Current Exception " + ex.GetType().Name);
                Console.WriteLine("Inner Exception " + ex.InnerException?.GetType().Name);
            }

        }
    }
}
