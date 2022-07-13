
using System;

public class Test
{
	public static void Main()
	{
		int [] arr1 = new []{4, 3, 7, 8, 6, 2, 1};
		var arr2 = ConvertToZigZag(arr1); 
        Array.ForEach(arr2, Console.WriteLine); 
	}
	
	private static int[] ConvertToZigZag(int[] arr1){
		bool flag = false;
			int n = arr1.Length;
			int temp = 0;
			for (int i = 0; i < n - 1; i++)
			{
				if (!flag)
				{
					if (arr1[i] > arr1[i + 1])
					{
						temp = arr1[i];
						arr1[i] = arr1[i + 1];
						arr1[i + 1] = temp;
					}
					flag = true;
				}
				else
				{
					if (arr1[i] < arr1[i + 1])
					{
						temp = arr1[i];
						arr1[i] = arr1[i + 1];
						arr1[i + 1] = temp;
					}
					flag = false;
				}
			}
			return arr1;
	}
}//IdeoneID - GUL4Xk
