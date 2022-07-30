using System;
using System.Collections.Generic;
using System.IO;

namespace DataLayer
{
	public class TextFileStream
	{
		internal static string fileName = @"C:\Users\ADMIN\Desktop\integprog\ticketInformation.txt";

        public static void CreateUpdateFile(bool isNewFile, List<string> ticketInfo)
        {
            if (isNewFile)
            {
                using (StreamWriter file = File.CreateText(fileName))
                {
                    WriteDataInFile(file, ticketInfo);
                }
            }
            else
            {
                using (StreamWriter file = File.AppendText(fileName))
                {
                    WriteDataInFile(file, ticketInfo);
                }
            }
        }
        private static void WriteDataInFile(TextWriter file, List<string> dataInput)
        {
            foreach (var data in dataInput)
            {
                file.WriteLine(data);
            }
        }
        
        public static List<string> ReadFile()
        {
        	List<string> dataContent = new List<string>();

            using (StreamReader sr = new StreamReader(fileName))
            {
                Console.WriteLine("TICKET INFORMATION");
                
                string line = sr.ReadToEnd();
                
                

                while (line != null)
                {
                    dataContent.Add(line);
                    line = sr.ReadLine();
                    
                }
                Console.ReadKey();
            }
            
			
            return dataContent;
            
        }
	}
}
	
