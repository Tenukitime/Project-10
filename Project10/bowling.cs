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

namespace Project10
{
    class Bowling
    {

        // The Sort Method
        // Purpose:  Sorts scores from highest to lowest, fills an empty array with their scores
        // Parameters: int[] scores, string[] names, ref string[] sortedNames, int length
        // Returns: void, but returns sorted names by reference.
        public void Sort(int[] scores, string[] names, ref string[] sortedNames, int length)
        {
            int counter = 0;
            for (int i = 300; i >= 0; i--)
            {
                for (int j = 0; j < length; j++)
                {
                    if ( i == scores[j])
                    {
                        sortedNames[counter] = names[j] + "\t" + scores[j];
                        if(i == 300)
                        {
                            sortedNames[counter] += "*";
                        }                       
                        counter++;

                    }

                }
            }
        }

        // The CalcAverage Method
        // Purpose: Calculates and returns the average score of the team
        // Parameters: int[] scores
        // Returns: double average
        public double CalcAverage(int[] scores)
        {
            int sum = 0;
            foreach (int score in scores)
            {
                sum += score;
            }

            double average = (double)sum / scores.Length;
            return average;
        }
    }
}
