﻿using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DDS2Tool
{
    public class Validation
    {
        public static string Path(string[] args)
        {
            string suppliedPath = "";
            bool validPath = false;

            do
            {
                if (args.Length != 0)
                {
                    suppliedPath = args[0];
                }
                else
                {
                    Console.Write("Please enter a path: ");
                    suppliedPath = Console.ReadLine();
                }

                if (suppliedPath.Length > 0)
                {
                    validPath = true;
                }
                else
                {
                    Console.Clear();
                    Console.Write("Please enter a path: ");
                    suppliedPath = Console.ReadLine();
                }
            } while (validPath == false);
            return suppliedPath;
        }

        public static string Type(string validPath)
        {
            // get the file attributes for file or directory
            FileAttributes pathAttributes = File.GetAttributes(@validPath);

            //detect whether its a directory or file
            if ((pathAttributes & FileAttributes.Directory) == FileAttributes.Directory)
                return "Directory";
            else
                return "File";
        }
    }
}