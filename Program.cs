using System;

namespace GitPull_Merge
{
	internal class Program
	{
		static void Main(string[] args)
		{
			#region Task1
			//Task - 1 
			//Verilmiş array-də tək ədədlərin sayını tapmaq və çap etmək.

			int[] arr1 = { 12, 23, 34, 54, 56, 76, 78, 11, 15 };
			int count = 0;

			for (int i = 0; i < arr1.Length; i++)
			{
				if (arr1[i] % 2 != 0)
				{
					count++;
				}
			}
			Console.WriteLine(count);
			#endregion
			#region Task2
			//Task - 2 
			//Verilmiş array-də ən kiçik və ən böyük ədədlərin cəmini tapmaq. 
			int[] arr2 = { 12, 23, 34, 54, 56, 76, 78, 11, 15 };
			int min = arr2[0];
			int max = arr2[0];

			for (int i = 0; i < arr2.Length; i++)
			{
				if (arr2[i]<min)
				{
					min = arr2[i];
				}
				if (arr2[i] > max) 
				{ 
					max = arr2[i];
				}
			}
			int sum = min + max;
            Console.Write("En kicik eded: ");
            Console.WriteLine(min);
            Console.Write("En boyuk eded: ");
            Console.WriteLine(max);
            Console.Write("Ededlerin cemi: ");
            Console.WriteLine(sum);
			#endregion
			#region Task3
			//Task - 3
			//Verilmiş array-dəki ədədlərin ən böyük və ən kiçik fərqlərini tapmaq. 
			int[] arr3 = { 12, 23, 34, 54, 56, 76, 78, 11, 15 };
			int minNum = arr3[0];
			int maxNum = arr3[0];

			for (int i = 0; i < arr3.Length; i++)
			{
				if (arr3[i] < minNum)
				{
					minNum = arr3[i];
				}
				if (arr3[i] > maxNum)
				{
					maxNum = arr3[i];
				}
			}
			int difference= max-min;
			Console.Write("En boyuk eded: ");
			Console.WriteLine(max);
			Console.Write("En kicik eded: ");
			Console.WriteLine(min);
			Console.Write("Ededlerin ferqi: ");
			Console.WriteLine(difference);
			#endregion
			#region Task4
			//Task - 4
           //Verilmiş array-dəki ədədlərin sırasını artan sıraya salmaq.
			int[] arr4 = { 12, 23, 34, 54, 56, 76, 78, 11, 15 };
			int temp=0;

			for (int i = 0; i < arr4.Length; i++)
			{
				for (int j= i+1; j < arr4.Length; j++)
				{
					if (arr4[i] > arr4[j])
					{
						temp = arr4[i];
						arr4[i] = arr4[j];
						arr4[j] = temp;
					}
				}
			}
            Console.WriteLine("Artan sira ile array:");
            foreach (int num in arr4)
			{
                Console.WriteLine(num);
            }


			#endregion
			#region Task5
			//Task - 5
			//Verilmiş array-dəki tək və cüt ədədlərin cəmini ayrı-ayrı tapmaq.
			int[] arr5 = { 12, 23, 34, 54, 56, 76, 78, 11, 15 };
			int sum1 = 0;
			int sum2 = 0;

			for (int i = 0;i < arr4.Length;i++)
			{
				if (arr4[i] % 2 == 0)
				{
					sum1 += arr4[i];
                    
                }
				if (arr4[i] % 2 != 0)
				{
					
					sum2 += arr4[i];
				}
			}
			Console.WriteLine("Cut ededlerin cemi: " + sum1);
			Console.WriteLine("Tek ededlerin cemi: " + sum2);


			#endregion
		}
	}
}