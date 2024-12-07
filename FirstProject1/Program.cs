using System.Runtime.ConstrainedExecution;

namespace FirstProject1
{
    internal class Program
    {
        public static void PrintObject(object item)
        {
            Console.WriteLine(item);
        }
        internal class ReferenceType
        {
            public int X { get; set; }

        }
        static void Main(string[] args)
        {
            /*1
             Console.WriteLine("Enter the Number");
             int num=int.Parse(Console.ReadLine());
             Console.WriteLine($"The Number : {num}");
             */

            /*2
            // if the sTring doesn't contain a numirec values the code won't run successfullay
            Console.WriteLine("Enter the String");
            int num =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(num);

            */

            /*3
            double x = Convert.ToDouble(Console.ReadLine());
            double y = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(x + y);
            Console.WriteLine(x*y);
            Console.WriteLine(x-y);
            Console.WriteLine(x/y);
            */
            /* 4
            Console.WriteLine("Enter the String");
            string txt=Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the the Start of Substring and its length");
            int StartIndex = Convert.ToInt32(Console.ReadLine());
            int LenOfSubstr=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("the sub string : ");
            Console.WriteLine(txt.Substring(StartIndex,LenOfSubstr));
            */

            /* 5
            int x = 5;   //Decleration and initilization
            int y;      //Decleration 
            y = 5;      // assign the value of x to y
            x++;        // increase the value of x by 1
            Console.WriteLine($" Y = {y} \n X ={x}");
            */

            /* 6
            ReferenceType R1 = new ReferenceType();
            R1.X = 1;
            ReferenceType R2 = new ReferenceType();
            R2 = R1;
            R1.X += 1;
            Console.WriteLine($"R1 content : {R1.X} \n R2 content {R2.X}");
            */

            /* 7
            Console.WriteLine("Enter 2 Strings ");
            string s1=Console.ReadLine();
            string s2=Console.ReadLine();
            string s3 = s1 + s2;
            Console.WriteLine($"The concatination of 2 strings : {s3}");
            */
            /* 8
            int d;
            d = Convert.ToInt32(!(30 < 20));
            //the Value 1 is assigned ti d
            */
            /* 9
            Console.WriteLine(13 / 2 + " " + 13 % 2);
            // the output : 6 1 because the divsion between integrs 
            */

            /* 10
            int num = 1, z = 5;


            if (!(num <= 0))
                Console.WriteLine(++num + z++ + " " + ++z);
            else
                Console.WriteLine(--num + z-- + " " + --z);

            // the if condition is true so the first condition will be run and the output : 7 7
            */






        }
    }
}
