using System;

public class Test
{
	public static void Main()
	{
		// your code goes here
		// Replace Every element by multiplication of previous and next
		int[] arr1 = new[] {2,4,5,7,8} ;
		var arr2 = FindSolvedArray(arr1);
		Array.ForEach(arr2, Console.WriteLine); 
	}
	
	private static int[] FindSolvedArray(int[] arr1){
		
		int n = arr1.Length;
		int previousvalue = 0;
		int currentvalue = 0;
		for(int i = 0; i < n; i++){
			
			if (i == 0){
				previousvalue = arr1[i];
				arr1[i] = arr1[i] * arr1[i+1];
			}
			else if (i == (n-1)){
				arr1[i] = arr1[i] * previousvalue;
			}
			else{
				currentvalue = arr1[i];
			    arr1[i] = previousvalue * arr1[i+1];
			    previousvalue = currentvalue;
			}
			
			    
			    
		}
		
		return arr1;
			
	}
}//ideone_cFdDla