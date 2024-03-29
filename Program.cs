﻿using System;
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
            Console.WriteLine("File IO Operations. \n FileInfo Class.");

            string filePath = @"F:\LOCOBUZZ\File_IO\File.txt";

            //Opening a file for Reading 
            string single_line_string = "Hi Myself Ankit Raj.";

            string multiple_line_string = "My name is Ankit Raj. \nI am a MERN Stack. \nI am at SRM IST";

            File.WriteAllText(filePath, multiple_line_string);

            File.AppendAllText(filePath, multiple_line_string);

            File.Delete(@"F:\LOCOBUZZ\File_IO\copy.txt");
            File.Copy(filePath, @"F:\LOCOBUZZ\File_IO\copy.txt");

            string[] text = File.ReadAllLines(filePath);
            
            string atext = File.ReadAllText(filePath);

            Console.WriteLine("this is for readAllLines" + text);

            Console.WriteLine("this is for readAllLines \n" + atext);

        }
    }
}
