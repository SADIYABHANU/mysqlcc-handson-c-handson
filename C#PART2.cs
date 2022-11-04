Looping constructs, Arrays & Inheritance and Polymorphism

0) Additonal

using System;

public class Program      
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the number");
        int num = int.Parse(Console.ReadLine());
        
        for( int i=2; i <= num; i++)
        {
            for( int j=2; j<= 20; j++)
            {
                Console.Write((i*j) + " ");
            }
            Console.WriteLine();
        }
    }
}

1) H1

using System;

public class Program
{
    public static void Main(string[] args)
    {
        string first_name, last_name, fullName;
        
        Console.WriteLine("Enter first name");
        first_name = Console.ReadLine();
        
        Console.WriteLine("Enter last name");
        last_name = Console.ReadLine();
        
        fullName = first_name + " " + last_name;
        Console.WriteLine("Full name : {0}", fullName);
    }
}

2) H2

using System;

namespace JaggedArray
{
	public class Program
	{
		public static void Main(string[] args)
		{
			Console.WriteLine("Enter the number of teams:");
			int teams = Convert.ToInt32(Console.ReadLine());
			
			int[][] teamsArray = new int[teams][];
			
			for(int i=0; i<teams; i++)
			{
				Console.WriteLine("No.of attempts for team {0}", (i+1));
				int attempt = Convert.ToInt32(Console.ReadLine());
				teamsArray[i] = new int[attempt];
			}
			
			for(int i=0; i<teams; i++)
			{
				Console.WriteLine("Enter the score for team {0}", (i+1));
				for(int j=0; j<teamsArray[i].Length; j++)
					teamsArray[i][j] = Convert.ToInt32(Console.ReadLine());
			}
			
			Console.WriteLine(GetTotalScore(teamsArray));
		}
		
		public static String GetTotalScore(int[][] array)
		{
			String res = "";
			
			for(int i=0; i<array.Length; i++)
			{
				int sum=0;
				for(int j=0; j<array[i].Length; j++)
				{
					sum += array[i][j];
					res += "Team " + (i+1) + " Total Score is " + sum + ". ";
				}
			}
			return res;
		}
	}
}

3) H3

using System;

public class Program      //DO NOT change the class name
{
    //implement code here
    public static void Main(string[] args)
    {
        string sentence, reverse="";
        
        Console.WriteLine("Enter a string");
        sentence = Console.ReadLine();
        
        string[] temp = sentence.Split();
        
        for(int i = temp.Length-1; i >= 0; i--)
        {
            reverse += temp[i] + " ";
        }
        Console.WriteLine(reverse);
    }
}

4) H4

using System;
public class Account
{
    private int id;
    private string accountType;
    private double balance;
    
    public int Id
    {
        get{ return id;}
        set{ id = value;}
    }
    
    public string AccountType
    {
        get{ return accountType;}
        set{ accountType = value;}
    }
    public double Balance
    {
        get{ return balance;}
        set{ balance = value;}
    }
    public Account(){}
    public Account(int id, string accountType, double balance)
    {
        this.id = id;
        this.accountType = accountType;
        this.balance = balance;
    }
    
    public bool WithDraw(double amount)
    {
        if(balance>amount)
        {
            balance -= amount;
            return true;
        }
        return false;
    }
    public string GetDetails()
    {
        return ("Account Id: " + id + "\nAccount Type: " + accountType + "\nBalance: "+balance);
    }
}
public class Program
{
    static void Main(string[] args)
    {
		int id;
		String accountType;
		double balance, withdraw;
		
        Account ac = new Account();
        
        Console.WriteLine("Enter account id");
        id = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Enter account type");
        accountType = Console.ReadLine();
        
        Console.WriteLine("Enter account balance");
        balance = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine("Enter amount to withdraw");
        withdraw = Convert.ToDouble(Console.ReadLine());
        
        ac = new Account(id, accountType, balance);
        Console.WriteLine(ac.GetDetails());
       
        if(ac.WithDraw(withdraw))
        {
            Console.WriteLine("New Balance: " + ac.Balance);
        }
    }
}

5) H5

using System;

public interface IOpenable
{
    String OpenSesame();
}

public class TreasureBox : IOpenable
{
    public String OpenSesame()
    {
        return "Congratulations , Here is your lucky win";
    }
}

public class Parachute : IOpenable
{
    public String OpenSesame()
    {
        return "Have a thrilling experience flying in air";
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        TreasureBox t = new TreasureBox();
        Parachute p = new Parachute();
        
        Console.WriteLine("Enter the letter found in the paper");
        char ch = Console.ReadLine()[0];
        
        if(ch == 'T')
            Console.WriteLine(t.OpenSesame());
        else if(ch == 'P')
            Console.WriteLine(p.OpenSesame());
    }
}

6) H6

using System;

public class Game
{
    public string Name { get; set; }
    public int MaxNumPlayers { get; set; }
    
    public override string ToString()
    {
        return ("Maximum number of players for " + Name + " is " + MaxNumPlayers);
    }
}

public class GameWithTimeLimit : Game
{
    public int TimeLimit { get; set; }
    
    public override string ToString()
    {
        Console.WriteLine(base.ToString());
        return ("Time Limit for " + Name + " is " + TimeLimit + " minutes");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Game g = new Game();
        GameWithTimeLimit gt = new GameWithTimeLimit();
        
        Console.WriteLine("Enter a game");
        g.Name = Console.ReadLine();
        
        Console.WriteLine("Enter the maximum number of players");
        g.MaxNumPlayers = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter a game that has time limit");
        gt.Name = Console.ReadLine();
        
        Console.WriteLine("Enter the maximum number of players");
        gt.MaxNumPlayers = int.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter the time limit in minutes");
        gt.TimeLimit = int.Parse(Console.ReadLine());
        
        Console.WriteLine(g.ToString());
        Console.WriteLine(gt.ToString());
    }
}

7) H7

using System;

public class Person
{
    private String firstName;
    private String lastName;
    private DateTime dob;
    
    public String FirstName
    {
        get { return firstName; }
        set { firstName = value; }
    }
    
    public String LastName
    {
        get { return lastName; }
        set { lastName = value; }
    }
    
    public DateTime Dob
    {
        get { return dob; }
        set { dob = value; }
    }
    
    public string Adult
    {
        get
        {
            if(GetAge(dob) < 18)
                return "Child";
            else
                return "Adult";
        }
    }
    
    public void DisplayDetails()
    {
       Console.WriteLine("First Name: " + firstName);
       Console.WriteLine("Last Name: " + lastName);
       Console.WriteLine("Age: " + GetAge(dob));
       Console.WriteLine(Adult);
    }
    
    public int GetAge(DateTime dob)
    {
        DateTime Now = DateTime.Now; 
        int age = 0;
        age = DateTime.Now.Year - dob.Year;  
        if (DateTime.Now.DayOfYear < dob.DayOfYear)  //This is for leap year
            age = age - 1;  
        return age;  
    }
}

public class BirthdayProject      //DO NOT change the class name
{
    //implement code here
    public static void Main(string[] args)
    {
        Person person = new Person();
        Console.WriteLine("Enter first name");
        person.FirstName = Console.ReadLine();
    
        Console.WriteLine("Enter last name");
        person.LastName = Console.ReadLine();
        
        Console.WriteLine("Enter date of birth in yyyy/mm/dd/ format");
        person.Dob = Convert.ToDateTime(Console.ReadLine());

        person.DisplayDetails();
    }
}

8) H8

using System;

public class Calculator
{
    public int Addition(int a, int b)
    {
        return a + b;
    }
    
    public int Subtraction(int a, int b)
    {
        return a - b;
    }
    
    public int Multiplication(int a, int b)
    {
        return a * b;
    }
    
    public double Division(int a, int b, out double remainder)
    {
        remainder = a % b;
        return Convert.ToInt32(a / b);
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Calculator c = new Calculator();
        
        Console.WriteLine("Enter the operator");
        char op = Console.ReadLine()[0];
        
        Console.WriteLine("Enter the operands");
        int num1 = int.Parse(Console.ReadLine());
        int num2 = int.Parse(Console.ReadLine());
        
        switch(op)
        {
            case '+':
                Console.WriteLine("Result of {0} {1} {2} is {3}", num1, op, num2, c.Addition(num1, num2));
                break;
            case '-':
                Console.WriteLine("Result of {0} {1} {2} is {3}", num1, op, num2, c.Subtraction(num1, num2));
                break;
            case '*':
                Console.WriteLine("Result of {0} {1} {2} is {3}", num1, op, num2, c.Multiplication(num1, num2));
                break;
            case '/':
                double remainder;
                Console.WriteLine("Result of {0} {1} {2} is {3}\nRemainder = {4}", num1, op, num2, c.Division(num1, num2, out remainder), remainder);
                break;
            default:
                Console.WriteLine("Invalid Operator");
                break;
        }
    }
}

9) H9

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
Substring(Int32)	
Retrieves a substring from this instance. The substring starts at a specified character position and continues to the end of the string.

Substring(Int32, Int32)	
Retrieves a substring from this instance. The substring starts at a specified character position and has a specified length.

*/

namespace ExtractBookCode      //Do not change the namespace name
{
    public class Program      //Do not change the class name
    {
        public static void Main(String[] arg)         //Do not change the method signature
        {
            //Implement code here
            string bookCode;
            
            Console.WriteLine("Enter the book code of length 18");
            bookCode = Console.ReadLine();
            
            if (bookCode.Length == 18)
            {
                if(bookCode.Substring(0,3) == "101" || bookCode.Substring(0,3) == "102" || bookCode.Substring(0,3) == "103")
                    Console.WriteLine("Department Code : {0}", bookCode.Substring(0,3));
                else
                    Console.WriteLine(" Invalid Department Code");
                    
                int year = Convert.ToInt32(bookCode.Substring(3,4));
                if(year>=1900 && year<=2020)
                    Console.WriteLine("Year of Publication : {0}", year);
                else
                    Console.WriteLine("Invalid Year");
                    
                long pages = Int64.Parse(bookCode.Substring(7,5));
                if(pages >= 00001 && pages<=99999)
                    Console.WriteLine("Number of Pages : {0}", pages);
                else
                    Console.WriteLine("Invalid Page Numbers");
                    
                char ch = Convert.ToChar(bookCode.Substring(12,1));
                if(Char.IsLetter(ch))
                {
                    if(Char.IsNumber(Convert.ToChar(bookCode.Substring(13,1))) && Char.IsNumber(Convert.ToChar(bookCode.Substring(14,1))) && Char.IsNumber(Convert.ToChar(bookCode.Substring(15,1))) && Char.IsNumber(Convert.ToChar(bookCode.Substring(16,1))) && Char.IsNumber(Convert.ToChar(bookCode.Substring(17,1))))
                    {
                        Console.WriteLine("Book ID : " + bookCode.Substring(12,6));
                    }
                } else
                {
                    Console.WriteLine("Invalid Book ID");
                }
            }
            else
                Console.WriteLine("Invalid Book Code");
        }
    }
}