using System;
class atm{
	int opt,amount=10000,temp,ano;
	public static void Main(String []args){
		int atype;
		string pin;
		Console.ForegroundColor = ConsoleColor.Cyan;
		Console.WriteLine("*****Welcome To XYZ Bank ATM*****");
		Console.ResetColor();
		Console.WriteLine("Enter your 6 digit PIN to continue...");
		pin = Console.ReadLine();
		if(pin.Length == 6){
		Console.WriteLine("Enter type of account: \n 1.Current Account \n 2.Saving Account");
		atype = int.Parse(Console.ReadLine());
		switch(atype){
			case 1:
				Console.WriteLine("Current Account Selected!");
				break;
			case 2:
				Console.WriteLine("Saving Account Selected!");
				break;
			default:
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("Enter the Correct Option!!!");
				Console.ResetColor();
				break;
		}
		atm a = new atm();
		a.account_process();
		}
		else{
			Console.ForegroundColor = ConsoleColor.Red;
			Console.WriteLine("Incorrect PIN Length!");
			Console.ResetColor();
		}
	}
	public void account_process(){
		Console.WriteLine("Select an Option: \n 1.Withdraw \n 2.Deposit \n 3.Check Balance \n 4.Transfer Money");
		opt = int.Parse(Console.ReadLine());
		switch(opt){
			case 1:
				if(amount >= 1000){
					Console.WriteLine("Enter Amount to Withdraw:");
					temp = int.Parse(Console.ReadLine());
					amount = amount - temp;
					Console.ForegroundColor = ConsoleColor.Green;
					Console.WriteLine("Amount Successfully Withdrawn.");
					Console.WriteLine("Balance: "+amount);
					Console.ResetColor();
				}
				else{
					Console.ForegroundColor = ConsoleColor.Red;
					Console.WriteLine("Account Balance is Too Low!");
					Console.ResetColor();
				}
				break;
			case 2:
				Console.WriteLine("Enter Amount to Deposit:");
				temp = int.Parse(Console.ReadLine());
				amount = amount + temp;
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("Amount Successfully Deposited.");
				Console.WriteLine("Balance: "+amount);
				Console.ResetColor();
				break;
			case 3:
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("Your Balance is: "+amount);
				Console.ResetColor();
				break;
			case 4:
				Console.WriteLine("Enter the Account Number to Transfer");
				ano = int.Parse(Console.ReadLine());
				Console.WriteLine("Enter the Amount:");
				temp = int.Parse(Console.ReadLine());
				amount = amount - temp;
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("Amount "+temp+" has been Transferred to "+ano);
				Console.ResetColor();
				break;
			default:
				Console.ForegroundColor = ConsoleColor.Red;
				Console.WriteLine("Enter the Correct Option!!!");
				Console.ResetColor();
				break;
		}
	}
}