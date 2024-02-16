using System;
namespace BinarySearchAlgorithm
{
	class BSearch
	{
		public static void Main(string[] args)
		{
			int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25 };

			Console.WriteLine(Numbers[5]);
			int NumberToFind = 2;
			int middle = Numbers.Length / 2, Lower = 0,Higher=Numbers.Length-1;
			while(Lower <= Higher)
			{
				if(Numbers[Lower]==NumberToFind)
				{
					Console.WriteLine("Number Found");
					break;
				}
				else if(Numbers[Higher] ==NumberToFind)
				{
					Console.WriteLine("Number Found");
                    break;
                }
				else if(NumberToFind == Numbers[middle])
				{
					Console.WriteLine("Number found");
                    break;
                }
				else if(Numbers[middle] > NumberToFind)
				{
					Higher = middle - 1;
					middle = (Lower + Higher) / 2;
				}
                else if(Numbers[middle] < NumberToFind)
                {
                    Lower = middle + 1;
                    middle = (Lower + Higher) / 2;
                }
            }
		}
	}
}