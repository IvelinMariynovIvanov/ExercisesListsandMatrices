using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercisesListsandMatrices
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> nums = Console.ReadLine().Split(' ').Select(int.Parse).ToList();

            int lenght = 1;
            int maxlenght = 1;
            int numb = 0;

            for (int i = 0; i < nums.Count-1; i++)
            {
                

                if (nums[i] == nums[i+1])
                {
                    lenght++;
                }
                else
                {
                    if(lenght > maxlenght)
                    {
                        maxlenght = lenght;
                        numb = nums[i];
                    }
                    lenght = 1;
                    
                }
            }
            for (int i = 0; i < maxlenght; i++)
            {
                Console.Write(numb + " ");
            }
            Console.WriteLine();
        }
    }
}
