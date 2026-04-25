using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using NAudio.Wave;
using System.Threading;



class Program
{
   static void Main(string[] args)
   {
       string filePath = "song.wav";
       using (var audioFile = new AudioFileReader(filePath))
       using (var outputDevice = new WaveOutEvent())
       {
           outputDevice.Init(audioFile);
           outputDevice.Play();

            string rawdata = File.ReadAllText("data.txt");
            string[] lines = rawdata.Split(';');
            foreach(string line in lines)
            {
                string[] meta = line.Split(':', count: 4);
                // Console.WriteLine(meta[0] + meta[1] + meta[2]);
                bool col = meta[0].Contains("r");
                if (col == true)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                }
                col = meta[0].Contains("b");
                if (col == true)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                }
                col = meta[0].Contains("g");
                if (col == true)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                }
                col = meta[0].Contains("y");
                if (col == true)
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
                col = meta[0].Contains("c");
                if (col == true)
                {
                    Console.ForegroundColor = ConsoleColor.Cyan;
                }
                col = meta[0].Contains("w");
                if (col == true)
                {
                    Console.ForegroundColor = ConsoleColor.White;
                }
                col = meta[0].Contains("m");
                if (col == true)
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                }

                col = meta[0].Contains("dm");
                if (col == true)
                {
                    Console.ForegroundColor = ConsoleColor.DarkMagenta;
                }

                col = meta[0].Contains("gr");
                if (col == true)
                {
                    Console.ForegroundColor = ConsoleColor.Gray;
                }
                col = meta[0].Contains("bl");
                if (col == true)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                }
                col = meta[0].Contains("db");
                if (col == true)
                {
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                }
                col = meta[0].Contains("dc");
                if (col == true)
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                }
                col = meta[0].Contains("dr");
                if (col == true)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                }
                col = meta[0].Contains("dy");
                if (col == true)
                {
                    Console.ForegroundColor = ConsoleColor.DarkYellow;
                }
                col = meta[0].Contains("dg");
                if (col == true)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                }
                col = meta[0].Contains("dgr");
                if (col == true)
                {
                    Console.ForegroundColor = ConsoleColor.DarkGray;
                }


                try
                {
                    int tim = Convert.ToInt32(meta[1]);
                    Thread.Sleep(tim);
                    bool lin = meta[2].Contains("n");
                    if (lin == true)
                    {
                        Console.WriteLine(meta[3]);
                    }  
                    else
                    {
                        Console.Write(meta[3]);
                    }
                }
                catch(Exception e)
                {
                    Console.WriteLine("delay fail");
                }
            }
            Console.ReadKey();
       }
   }
}