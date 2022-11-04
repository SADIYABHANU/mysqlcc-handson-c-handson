Lambda Expressions, Access Modifiers, Lists, Arraylists vs Lists vs Arrays, 
Structs, Enums, Math Class, Random Class, Regular Expressions, DateTime, Linq, Threads

1) Additional

using System;

public class Program    
{
    
    static void Main(string[] args)
    {
       
        
        Console.WriteLine("Enter account no ");
        name = Console.ReadLine();
        Console.WriteLine("Enter account holder name");
        age = float.Parse(Console.ReadLine());
        Console.WriteLine("Enter bank name");
        gender = Convert.ToChar(Console.ReadLine());
        Console.WriteLine("Enter bank balance");
        city = Console.ReadLine();
        Console.WriteLine("Name : {0}", name);
        Console.WriteLine("Account NO : {0}", account no);
        Console.WriteLine(" Bank name: {0}", bank name);
        Console.WriteLine("Bank balance : {0}", bank balance);
    }
}


2) H1

using System;
using System.Collection.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateEx2		//DO NOT CHANGE namespace name
{
	public class Program	//DO NOT CHANGE the class name
	{
		/*** Dictionary values are hard-coded. DO NOT change ***/
		static Dictionary<string, DateTime> flightSchedule = new Dictionary<string, DateTime>(){
														{"ZW346", Convert.ToDateTime("13:54:10")},
														{"AT489", Convert.ToDateTime("16:30:00")},
														{"BR267", Convert.ToDateTime("21:15:30")}};
		
		public class void Main(string[] args)	//DO NOT CHANGE the 'Main' method signature
		{
			//Implement your code here
			string flightNumber;
			string timeLeft;
			
			Console.WriteLine("Enter the Flight Number :");
			flightNumber = Console.ReadLine();
			
			timeLeft = flightStatus(flightNumber);
			Console.WriteLine(timeLeft);
		}
		
		public static string flightStatus(string flightNo)	//DO NOT CHANGE the 'flightStatus' method signature
		{
			//Implement your code here
			if(flightSchedule.ContainsKey(flightNo))
			{
				DateTime departureTime = flightSchedule[flightNo];
				if(DateTime.UtcNow < departureTime)
				{
					TimeSpan ts = departureTime.Subtract(DateTime.UtcNow);
					return "Time to flight " + ts.ToString();
				}
				else
					return "Flight Already Left";
			}
			else
				return "Invalid Flight Number";
		}
	}
}
	
3) H2

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateEx1              //DO NOT CHANGE the namespace name
{
    public class Program       //DO NOT CHANGE the class name
    {
        public static void Main(string[] args)    //DO NOT CHANGE the 'Main' method signature
        {
            Console.WriteLine("Enter the date of birth (dd-mm-yyyy): ");
            //Implement code here
            DateTime dob=DateTime.ParseExact(Console.ReadLine(),"dd-mm-yyyy",null);
            string dt=dob.ToString("dd-mm-yyyy");
            Console.WriteLine(calculateAge(dt));
        }

        public static int calculateAge(string dateOfBirth)
        {
            //Implement code here
            
            int birthyear=Int32.Parse(dateOfBirth.Substring(6,4));
            int birthmonth=Int32.Parse(dateOfBirth.Substring(3,2));
            int birthdate=Int32.Parse(dateOfBirth.Substring(0,2));
            var t=DateTime.Today;
            var a=(t.Year*100+t.Month)*100+t.Day;
            var b=(birthyear*100+birthmonth)*100+birthdate;
            return (a-b-400)/10000;
        }
    }
}

4) H3

5) H4

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;


namespace LinqApp1                //DO NOT CHANGE the namespace name
{
    
    public class Program         //DO NOT CHANGE the class name
    {
        /** DO NOT CHANGE this 'List' declaration with initialized values  **/
        public static List<Vehicle> vehicleList = new List<Vehicle>()
                                {
                                    new Vehicle("HO345","CRV","Honda",2015),
                                    new Vehicle("HY562","Creta","Hyundai",2017),
                                    new Vehicle("RE198","Duster","Reanult",2014),
                                    new Vehicle("MA623","Spacio","Suzuki",2014),
                                    new Vehicle("TR498","Nexon","Tata",2015),
                                    new Vehicle("TR981","Zest","Tata",2016),
                                    new Vehicle("HO245","WRV","Honda",2018)

                                };

        static void Main(string[] args)   //DO NOT Change this 'Main' signature
        {
            //Implement your code here
            Console.WriteLine("Enter From Year:");
            int fromYear=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter To Year:");
            int toYear=Convert.ToInt32(Console.ReadLine());
            getVehicleName(fromYear,toYear);
        }

        //Implement the method 'getVehicleName' here
        public static void getVehicleName(int fromYear,int toYear){
            IEnumerable<Vehicle> vehicles=from vehicle in vehicleList where vehicle.ReleaseYear>=fromYear && vehicle.ReleaseYear<=toYear select vehicle ;
            foreach(Vehicle vehicle in vehicles)
            Console.WriteLine(vehicle.VehicleName);
        } 
        

         /** DO NOT CHANGE this ParameterExpression **/  
        public static ParameterExpression variableExpr = Expression.Variable(typeof(IEnumerable<Vehicle>), "sampleVar");
        
        public static Expression getMyExpression(int fromYear, int toYear)
        {  
            Expression assignExpr = Expression.Assign(variableExpr, Expression.Constant(from vehicle in vehicleList where vehicle.ReleaseYear>=fromYear && vehicle.ReleaseYear<=toYear select vehicle));
            return assignExpr;
        }

    }
}

6) H5


using System;
using System.Collections.Generic;

namespace BallsBowled        //DO NOT change the namespace name
{
    public class Program    //DO NOT change the class name
    {
        static void Main(string[] args)
        {
            //Implement code here
            
            Console.WriteLine("Enter the number of overs");
            int overs = int.Parse(Console.ReadLine());
            
            PlayerBO pb = new PlayerBO();
            pb.AddOversDetails(overs);
            
        }
   }

    public class PlayerBO      //DO NOT change the class name
    {
        public List<int> PlayerList { get; set; } = new List<int>();
        int balls;
        
        public void AddOversDetails(int oversBowled)       //DO NOT change the method signature
        {
            //Implement code here
            PlayerList.Add(oversBowled);
            Console.WriteLine(PlayerList);
            foreach(int i in PlayerList)
            {
              balls = i;
            }
            Console.WriteLine("Balls Bowled : " + GetNoOfBallsBowled());
        }

        public int GetNoOfBallsBowled()              //DO NOT change the method signature
        {
            //Implement code here
            return balls*6;
        }
    }
}

7) H6

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddNewMember              //Do not change the namespace name
{
    public class Club          //Do not change the class name
    {
        
        static Dictionary<int, string> groupInfo = new Dictionary<int, string>() { { 1, "Gold" }, { 2, "Silver" }, { 3, "Platinum" } };
        static Dictionary<int, List<String>> memberInfo = new Dictionary<int, List<String>>() {
                                    { 1, new List<string>(){ "Tom","Harry"} },
                                    { 2,new List<string>(){ "Sam","Peter"} },
                                    { 3,new List<string>(){ "Kim","Robert"} } };

        public static void Main(string[] args)        //Do not change the method signature
        {
            List<string> gold = memberInfo[1];
            List<string> silver = memberInfo[2];
            List<string> platinum = memberInfo[3];
            
            Console.WriteLine("Group Name :");
            string groupName = Console.ReadLine();
            
            Console.WriteLine("Member Name :");
            string memberName = Console.ReadLine();
            
            if(groupName == "Gold" || groupName == "gold")
            {
                gold.Add(memberName);
                
                foreach(string goldGroup in gold)
                    Console.WriteLine(goldGroup);
            }
            
            if(groupName == "Silver" || groupName == "silver")
            {
                silver.Add(memberName);
                
                foreach(string silverGroup in silver)
                    Console.WriteLine(silverGroup);
            }
            
            if(groupName == "Platinum" || groupName == "platinum")
            {
                platinum.Add(memberName);
                
                foreach(string platinumGroup in platinum)
                    Console.WriteLine(platinumGroup);
            }
        }
    }
}