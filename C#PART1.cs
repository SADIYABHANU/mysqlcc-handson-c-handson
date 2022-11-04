DataTypes And Variables Functions Methods, Decision Making

1) Addtional handson

using System;

public class Program    
{
    
    static void Main(string[] args)
    {
        string name, city;
        float age;
        char gender;
        long mobile, pincode;
        
        Console.WriteLine("Enter name");
        name = Console.ReadLine();
        
        Console.WriteLine("Enter age(completed years and months)");
        age = float.Parse(Console.ReadLine());
        
        Console.WriteLine("Enter gender('M' for Male and 'F' for Female)");
        gender = Convert.ToChar(Console.ReadLine());
        
        Console.WriteLine("Enter city");
        city = Console.ReadLine();
        
        Console.WriteLine("Enter mobile number");
        mobile = Convert.ToInt64(Console.ReadLine());
        
        Console.WriteLine("Enter pincode");
        pincode = Convert.ToInt64(Console.ReadLine());
        
        
        Console.WriteLine("Name : {0}", name);
        Console.WriteLine("Age : {0}", age);
        Console.WriteLine("Gender : {0}", gender);
        Console.WriteLine("City : {0}", city);
        Console.WriteLine("Mobile : {0}", mobile);
        Console.WriteLine("Pincode : {0}", pincode);
    }
}

2) H1

using System;

namespace Hands_on
{
    internal class Program
    {
        static void Main(string[] args)
        {             int age;
            Console.WriteLine("Enter the name :");
            string name=Console.ReadLine();
            Console.WriteLine("Enter your Age :");
            age=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter your country :");
            string country=Console.ReadLine();
            Console.WriteLine($"welcome {name}. Your age is {age} and you are from {country} ");
        }
    }
}

3) H2

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods2               
{
    public class Program                
    {
        public static void Main(string[] args)        
        {
         
            Console.WriteLine("Enter a Number");
            double num = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Square of " + x + " is " + FindSquare(num));
            Console.WriteLine("Cube of " + x + " is " + FindCube(num));
        }
        public static double FindSquare(double num){
            return (num*num);
        }
        public static double FindCube(double num){
            return (num*num*num);
        }
    }
}

4) H3

using System;

public class Program    
{
   
    static void Main(string[] args)
    {
        int x, y;
        bool result;
        
        Console.WriteLine("Enter the value for x");
        x = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("Enter the value for y");
        y = Convert.ToInt32(Console.ReadLine());
        
        result = x < y;
        
        Console.WriteLine("The result of whether {0} is less than {1} is {2}", x, y, result);
    }
}

5) H4

using System;

public class Program      
{
   
    static void Main(string[] args) 
    {
        sbyte number = 125;
        Console.WriteLine("Value of number: " + number);
        number = sbyte.MaxValue;
        Console.WriteLine("Largest value stored in a signed byte : " + number);
    }
}