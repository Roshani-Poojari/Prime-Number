using System;

class PrimeNumber{
	public static void Main(String [] args){
		int myNumber, i, flag=0;
		Console.WriteLine("Enter a number:");
		myNumber = Convert.ToInt32(Console.ReadLine());
		if (myNumber <= 1){
			flag=1;
		}
	        for(i=2; i<Math.Sqrt(myNumber); i++){
			if(myNumber%i == 0){
				flag=1;
				break;
			}	
		}
		if(flag==0){
			Console.WriteLine(myNumber+" is a prime number");
		}
	        else{
	        	Console.Write(myNumber+" is not a prime number");
	        }
	}
}