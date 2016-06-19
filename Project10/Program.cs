// File Prologue
// Name: Kyle Gray
// Project: Project 10
// Date: 6/18/2016

// I declare that the following source code was written by me, or provided
// by the instructor for this project.  I understand that copying
// source code from any other source constitutes cheating, and that I will
// receive a zero grade on this project if I am found in vaolation of 
// this policy.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Project10
{
    class Program
    {
        
        static void Main(string[] args)
        {
            Bowling bowlers = new Bowling();
            const int MAX = 10;
            string[] info = new string[MAX];
            int length = 0;
            

           
            WriteLine("Please enter the bowlers name and their score in the following format \"Mary 135\". You may enter up to 10 players per team. Simply hit enter when finished");

            for (int i = 0; i < MAX; i++)
            {
                string temp = ReadLine();
                if (temp != "")
                {
                    info[i] = temp;
                    length++;
                }
                else
                {
                    break;
                }
            }
                
            string[] names = new string[length];
            int[] scores = new int[length];

            for (int i = 0; i < length; i++)
            {
                string[] temporary = info[i].Split();
                names[i] = temporary[0];
                scores[i] = int.Parse(temporary[1]);
                   
            }

            string[] sortedNames = new string[length];
            

            bowlers.Sort(scores, names, ref sortedNames, length);
            foreach(string name in sortedNames)
            {
                WriteLine(name);
            }

            WriteLine($"The average score for the team was {bowlers.CalcAverage(scores):f2}.");

            ReadKey();
        }
    }
}
