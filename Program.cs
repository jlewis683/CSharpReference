using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;//needed for file I/O

namespace CSharpTutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate objects, write to and read from console
            bool canVote = true;
            char grade = 'A';
            Console.WriteLine("Hello world.");
            Console.Write("Input the text to echo: ");
            string name = Console.ReadLine();
            Console.WriteLine(name);
            Console.WriteLine("Max double: " + double.MaxValue);
            double pi = 3.14159;
            Console.WriteLine((int)pi);
            double num1 = 10.5;
            double num2 = 15;
            Console.WriteLine(Math.Ceiling(num1));
            Random rand = new Random();
            Console.WriteLine(rand.Next(1, 11));
            Console.WriteLine(rand.Next(1, 11));
            Console.WriteLine(rand.Next(1, 11));
            Console.WriteLine(rand.Next(1, 11));
            Console.WriteLine(rand.Next(1, 11));
            int a = 19;
            //a = Console.ReadLine();//can't be an int, apparently
            if((a > 3) && (a < 10))
            {
                Console.WriteLine("a > 3, a < 10");
            }
            bool canDrive = a > 16 ? true : false;
            Console.WriteLine(canDrive);
        //logic
            int i = 0;
            while (i < 10)
            {
                if (i == 7)
                {
                    i++;
                    continue;
                }
                else if (i == 9)
                {
                    break;
                }
                Console.WriteLine(i);
                i++;
            }
            
            string guess;
            do
            {
                Console.WriteLine("Input Guess (answer is 15):");
                guess = Console.ReadLine();
            } while (!guess.Equals("15"));

            for(i = 0; i < 10; i++)
            {
                if (i % 2 > 0)
                    Console.WriteLine(i);
            }
        //working with strings
            string asdf = "fadfsdagasdg";
            foreach(char c in asdf)
            {
                Console.Write(c);
            }
            Console.WriteLine("");
            Console.WriteLine("empty: " + String.IsNullOrEmpty(""));
            
            string exampleString = "0";
            Console.WriteLine(String.IsNullOrEmpty(exampleString));
            
            string string1 = "String 1 text            ", string2 = "Here is text for the second string.";

            Console.WriteLine("Starts with \"String 1\": " + string1.StartsWith("String 1"));
            Console.WriteLine("Ends with \".\": " + string2.EndsWith("."));
            Console.WriteLine("Strings are equal: " + string1.Equals(string2));
            Console.WriteLine(string1 + "X");
            Console.WriteLine(string1.Trim() + "X");//Trim() removes white space before or after a string, also TrimEnd() and TrimStart()
            string1 = string1.Replace("text", "characters");
            Console.WriteLine(string1);

            string[] names = new string[3] { "matt", "joe", "bob" };
            Console.WriteLine("Name list: " + String.Join(", ", names));
            
            //{index:format} c is currency, 
            //00.00 is decimal places, minimum 2 digits before decimal (01.23, 23.45, 345.56, 98.00)
            //#.00 means no leading zero
            //0,0 puts commas for numbers like 10,000
            string formatString = String.Format("{0:c} {1:00.00} {2:#.00} {3:0,0}", 1.56, 123.456, 0.5555, 10000000);
            Console.WriteLine(formatString);
            
            StringBuilder sb = new StringBuilder();
            sb.Append(">>>");
            sb.AppendFormat("Name: {0}, ", "testuser");
            sb.Replace(">", ">>");
            sb.Remove(6, 2);//first parameter is index, second is number of chars to remove
            Console.WriteLine(sb);
        //arrays
            int[] randArray = new int[5];//filled with zeros.
            int[] randArray2 = { 0, 1, 2, 3, 4 };

            Console.WriteLine("Length: " + randArray.Length);
            Console.WriteLine("Item 0: " + randArray[0]);

            for (int ind = 0; ind < randArray.Length; ind ++)
            {
                Console.WriteLine("{0} : {1}", ind, randArray[ind]);
            }
            foreach(int num in randArray2)
            {
                Console.WriteLine(num);
            }
            Console.WriteLine("Where is 1? " + Array.IndexOf(randArray2, 1));//Array.IndexOf(array, value whose index we find)
            string[] names2 = new string[3] { "matt", "joe", "bob" };
            string nameList = String.Join(", ", names2);
            Console.WriteLine(nameList);
            Console.WriteLine(nameList.Split(','));//outputs "System.String[]" probably error in tutorial, results not shown.
            int[,] multiArray = new int[5, 2];
            int[,] multiArray2 = { { 0, 1 }, { 2, 3 }, { 4, 5 } };

            for(int x = 0; x < multiArray2.GetLength(0); x++)
            {
                for(int y = 0; y < multiArray2.GetLength(1); y++)
                {
                    Console.WriteLine("({0}, {1}) : {2}", x, y, multiArray2[x,y]);
                }
            }
        //lists
            List<int> intList = new List<int>();
            int[] intArray = { 3, 564, 234, 234, 56 };
            List<int> listOfInts = new List<int>(new int[] { 0, 1, 2, 4, 4, 4, 4, 4, 8, 9 });
            List <string> strList = new List<string>(new string[]{ "Tom", "Dick", "Harry", "Sally" });
            intList.Add(5);
            intList.Add(10);
            intList.Add(5);
            intList.Add(20);
            intList.Add(67);
            intList.AddRange(intArray);//adds each item in the array to the list
            listOfInts.Insert(0, 100);//inserts the value 100 at index 0
            listOfInts.Remove(4);//removes the first instance of 4
            listOfInts.RemoveAt(2);//removes the item at index 2
            for (int listIndex = 0; listIndex < listOfInts.Count; listIndex++)
            {
                Console.WriteLine("{0} : {1}", listIndex, listOfInts[listIndex]);
            }
            listOfInts.Remove(100);
            for (int listIndex = 0; listIndex < listOfInts.Count; listIndex++)
            {
                Console.WriteLine("{0} : {1}", listIndex, listOfInts[listIndex]);
            }
            Console.WriteLine("list contains 8: " + listOfInts.Contains(8));//Contains returns a bool True if the value is in the list.
            Console.WriteLine("index of 4 is: " + listOfInts.IndexOf(4) + " " + listOfInts.IndexOf(4));//IndexOf() only gives index of first instance.
            Console.WriteLine("List contains \"Sally\": " + strList.Contains("sally", StringComparer.OrdinalIgnoreCase));//StringComparer.OrdinalIgnoreCase to ignore case
            for (int listIndex = 0; listIndex < strList.Count; listIndex++)
            {
                Console.WriteLine("{0} : {1}", listIndex, strList[listIndex]);
            }
            Console.WriteLine("\nSorted:");
            strList.Sort();
            for (int listIndex = 0; listIndex < strList.Count; listIndex++)
            {
                Console.WriteLine("{0} : {1}", listIndex, strList[listIndex]);
            }
        //exception handling
            try
            {
                Console.Write("Divide 10 by: ");
                int num = int.Parse(Console.ReadLine());
                Console.WriteLine("10/{0} = {1}", num, (10 / num));
            }
            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Can't divide by 0.");
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
                //throw new InvalidOperationException("Operation Failed.", ex);
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.GetType().Name);
                Console.WriteLine(ex.Message);
            }
        //classes
            Animal spot = new Animal(10, 5, "Arf!", "Spot");
            Animal grover = new Animal
            {
                height = 150,
                weight = 30,
                name = "Grover",
                sound = "No new taxes!"
            };
            Console.WriteLine(spot.toString());
            Console.WriteLine("Number of animals: " + Animal.getNumOfAnimals());
            Console.WriteLine(spot.getSum(secondNum: 1.7, firstNum: 3.8));//switches the parameters around by explicitly defining which value is which instead of using their order
            Dog helperDog = new Dog(height: 10, weight: 100, name: "Helper Dog", sound: "Growl", favoriteFood: "Other dogs");
            Console.WriteLine("Number of animals: " + Animal.getNumOfAnimals());
            Console.WriteLine(helperDog.toString());
        //abstract classes
            Shape rect = new Rectangle(5, 6);
            Shape tri = new Triangle(3, 4);
            Rectangle sumRect = new Rectangle(5, 4) + new Rectangle(5, 6);//+ is overloaded in the class to make it use our definition of "sum."
            Console.WriteLine("tri area = " + tri.area());
            Console.WriteLine("rect area = " + rect.area());
            Console.WriteLine("Area of rectangle sum = " + sumRect.area());
        //generic classes
            KeyValue<string, string> superman = new KeyValue<string, string>("", "");
            superman.key = "Superman";
            superman.value = "Clark Kent";
            superman.showData();
            KeyValue<int, string> codes = new KeyValue<int, string>(5, "hello");
            codes.showData();
            
        //enumerated types (datatype that can have several different named values)
            Temperature micTemp = Temperature.Low;
            switch(micTemp)
            {
                case Temperature.Freeze:
                    Console.WriteLine("Freeze");
                    break;
                case Temperature.Low:
                    Console.WriteLine("Low");
                    break;
                case Temperature.Warm:
                    Console.WriteLine("Warm");
                    break;
                case Temperature.Boil:
                    Console.WriteLine("Boil");
                    break;
            }
            
        //struct
            Customer bob = new Customer();
            bob.createCustomer("Bob", 12.05, 100);
            bob.displayInfo();
            
        //delegates (pass methods as arguments for other methods)
            GetSum sum = delegate (double val1, double val2)
            {
                return val1 + val2;
            };
            Console.WriteLine("5 + 10 = " + sum(5,10));
        //lambda function
            Func<int, int, int> getSum = (x, y) => x+y;
            Console.WriteLine("5 + 3 = " + getSum.Invoke(5, 3));
            List <int> numList = new List <int> { 5, 10, 15, 20, 25 };
            List<int> oddNums = numList.Where(n => n % 2 == 1).ToList();
            foreach(int num in oddNums)
            {
                Console.Write(num + ", ");
            }
            Console.WriteLine("");
            //file I/O, don't forget to add "using System.IO;" at the top.
            string[] customers = new string[] { "Harry", "Dick", "Tom", "Sally" };
            string custName = "";
            using (StreamWriter fileOut = new StreamWriter("Customers.txt"))
            {
                foreach (string theCust in customers)
                {
                    fileOut.WriteLine(theCust);
                }
            }
            
            using (StreamReader fileIn = new StreamReader("Customers.txt"))
            {
                while((custName = fileIn.ReadLine()) != null)
                {
                    Console.WriteLine(custName);
                }
            }
        }/*end Main()*/
    }//end Program
    class Animal
    {
        public double height { get; set; }
        public double weight { get; set; }
        public string sound { get; set; }
        public string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public Animal()
        {
            this.height = 0;
            this.weight = 0;
            this.sound = "No Sound";
            this.name = "No Name";
            numOfAnimals++;
        }
        public Animal(double height, double weight, string sound, string name)
        {
            this.height = height;
            this.weight = weight;
            this.sound = sound;
            this.name = name;
            numOfAnimals++;
        }

        static int numOfAnimals = 0;//static means shared across whole program. Animal.numOfAnimals, rather than spot.numOfAnimals.

        public static int getNumOfAnimals()//static function only uses static members. Call Animal.getNumOfAnimals() to use.
        {
            return numOfAnimals;
        }
        public string toString()
        {
            return String.Format("Name: {0}\nSound: {1}\nHeight: {2}\nWeight: {3}", name, sound, height, weight);
        }
        public int getSum(int firstNum = 1, int secondNum = 1)//getSum returns an int if args are ints.
        {
            return firstNum + secondNum;
        }
        public double getSum(double firstNum = 1, double secondNum = 1)//getSum returns a double if args are doubles.
        {
            return firstNum + secondNum;
        }
    }//end Animal
    class Dog : Animal
    {
        public string favoriteFood { get; set; }
        public Dog() : base()
        {
            this.favoriteFood = "No favorite food";
        }
        public Dog(double height, double weight, string sound, string name, string favoriteFood) : base(height, weight, sound, name)
        {
            this.favoriteFood = favoriteFood;
        }
        new public string toString()//to override the method in the base class, use new.
        {
            return String.Format("Name: {0}\nSound: {1}\nHeight: {2}\nWeight: {3}\nFavorite food: {4}", name, sound, height, weight, favoriteFood);
        }

    }//end Dog
    abstract class Shape //abstract is an actual class, unlike an interface. Allows methods to have definitions, allows members.
    {
        public abstract double area();//abstract method must be defined inside the class
        public void sayHi()
        {
            Console.WriteLine("Hi");
        }
    }
    public interface ShapeItem //methods in an interface default to abstract. Declarations only, no definitions. No members.
    {
        double area();
    } 
    class Rectangle : Shape
    {
        private double length;
        private double width;
        public Rectangle(double num1, double num2)
        {
            this.length = num1;
            this.width = num2;
        }
        public override double area()
        {
            return length * width;
        }
        public static Rectangle operator +(Rectangle rect1, Rectangle rect2)//overload + operator to return the "sum" of two rectangles, as I define "sum."
        {
            double newWidth = rect1.width + rect2.width;
            double newLength = rect1.length + rect2.length;
            return new Rectangle(newWidth, newLength);
        }
    }
    class Triangle : Shape
    {
        private double theBase;
        private double height;
        public Triangle(double num1, double num2)
        {
            this.theBase = num1;
            this.height = num2;
        }
        public override double area()
        {
            return theBase * height * 0.5;
        }
    }
    class KeyValue <TKey, TValue>//generic class
    {
        public TKey key { get; set; }
        public TValue value { get; set; }
        public KeyValue(TKey k, TValue v)
        {
            key = k;
            value = v;
        }
        public void showData()
        {
            Console.WriteLine("Key: {0}\nValue: {1}", this.key, this.value);
        }
    }
    public enum Temperature
    {
        Freeze,
        Low,
        Warm,
        Boil
    }
    struct Customer
    {
        private string name;
        private double balance;
        private int id;

        public void createCustomer(string n, double b, int i)
        {
            name = n;
            balance = b;
            id = i;
        }
        public void displayInfo()
        {
            Console.WriteLine("ID: {0}\nName: {1}\nBalance: {2:c}", this.id, this.name, this.balance);
        }
    }
    delegate double GetSum(double val1, double val2);
}
