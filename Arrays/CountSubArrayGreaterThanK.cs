using System;

public class Test
{
	public static void Main()
	{
		// your code goes here
		int[] arr1 = new[] {1,2,3,4};
		int k = 2;
		var x = FindCountOfSubArraysMaxThanK(arr1, k);
		Console.WriteLine("The count is " + x);
	}
	
	private static int FindCountOfSubArraysMaxThanK(int[] arr1, int k){
		//Remove Elements from array which are greater than k
		int n = arr1.Length;
		
		int leftcount = 0;
		int leftsubarrays = 0;
		int result = 0;
		int totalcount = (n * (n + 1))/2; //6
		
		for(int i = 0; i < n ; i++){
			if(arr1[i] <= k){
				leftcount++;
			}
		}
		
		leftsubarrays = (leftcount * (leftcount + 1)) / 2;
		result = totalcount - leftsubarrays;
		
		return result;
	}
}// IDEOne ID rLF19F