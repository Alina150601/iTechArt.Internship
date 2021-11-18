using System;
using System.Collections.Generic;
using System.IO;

//task: randomly to choose one record from file
namespace RandomFromFile
{
    public static class Program
    {
        public static void Main(string[] args)
        {
            try
            {
                //Pass the file path and file name to the StreamReader constructor
                StreamReader sr = new StreamReader("../../../whoWashTheDish.txt");
                //Read the first line of text
                var line = sr.ReadLine();
                //Continue to read until you reach end of file
                var participants = new List<string>();
                Console.WriteLine("Hi! Today we will choose lucky one!\n");
                Console.WriteLine("Our participants:");
                while (line != null)
                {
                    participants.Add(line);
                    //write the line to console window
                    Console.WriteLine(line);
                    //Read the next line
                    line = sr.ReadLine();
                }
                Console.WriteLine("\nAnd our winner today is: ...");
                var winner = participants[new Random().Next(0, participants.Count)];
                Console.WriteLine(winner);
                Console.WriteLine("Congratulations, " + winner + "!!!");



                //close the file
                sr.Close();
                Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }
    }
}
