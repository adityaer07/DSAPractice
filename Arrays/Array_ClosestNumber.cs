using System;

public class Test
{
	public static void Main()
	{
		int[] arr1 = new[] {1, 4, 5, 7};

		int[] arr2 = new[] {10,20,30,40};
		int x = 32;

		PrintClosestNumbers(arr1, arr2, x);
	}

	private static void PrintClosestNumbers(int[] arr1, int[] arr2, int x){
		int firstnumber = 0;
		int secondnumber = 0;
		int diff = 0;
		int n = arr1.Length;
        int m = arr2.Length;
        int i = 0;
        int j = m-1;
		while (i < n && j >=0){
			if(j == m-1){
				diff = Math.Abs((arr1[i] + arr2[j]) - x);
			}


			if (Math.Abs((arr1[i] + arr2[j]) - x) < diff){
				diff = Math.Abs((arr1[i] + arr2[j]) - x);
                firstnumber = arr1[i];
                secondnumber = arr2[j];
			}
			if ((arr1[i] + arr2[j]) > x){
				j--;
			}else{
				i++;
			}
		}
		Console.WriteLine("closest pair is " + firstnumber + " and " + secondnumber);
	} 
}