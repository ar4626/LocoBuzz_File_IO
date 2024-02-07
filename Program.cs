using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace File_IO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("File IO Operations.");

            string filePath = @"F:\LOCOBUZZ\File_IO\sample.txt";

            //Opening a file for Reading 
            using (FileStream fs = new FileStream(filePath, FileMode.Open, FileAccess.Read))
            {
                byte[] buffer = new byte[1024];
                int bytesRead = 0;

                //Reading multiple lines in the file 

                while ((bytesRead = fs.Read(buffer, 0, buffer.Length)) > 0)
                {
                    Console.WriteLine(Encoding.UTF8.GetString(buffer, 0, bytesRead));
                }

            }
            
        
        }
    }
}
