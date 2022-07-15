using System;

public class Test
{
	public static void Main()
	{
		int[] arr = new[] {1,2,3,4,6,7,8,9,10};
		int result = FindMissingElement(arr);
        Console.WriteLine("Missing number is " + result);
	}
	private static int FindMissingElement(int[] arr){
		int n = arr.Length;
		int i = 0;
		int j = n-1;
		int missingfield = 0;
		
		while (i < j){
			
			bool flag = false;

			if (Math.Abs(arr[i] - arr[i+1]) == 1){
				
				flag = true;
			}
			else{
				missingfield = arr[i] + 1;	
				break;
			}
			if (Math.Abs(arr[j] - arr[j-1]) == 1){
				
				flag = true;
			}
			else{
				missingfield = arr[j] - 1;	
				break;
			}
			if (flag == true){
				i++;
				j--;
			}
			

		}
        return missingfield;

	}
}//Ideone ID UUjyTd