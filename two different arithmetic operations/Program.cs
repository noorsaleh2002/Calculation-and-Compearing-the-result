using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace arithmetic_operations
{
    


     class Program
    {
        static double Mycalculatoer(double x, double y,string op)
        {
            if (op == "+") return x + y;
             if(op== "-") return x - y;
            if(op== "*") return x * y;
            else  return x / y;
        }
        static double setnumbers()
        {
            double num= Convert.ToDouble(Console.ReadLine());
            return num;

        }
        static void Main(string[] args)
        {
            double Num1, Num2,Num3,Num4;
            string op;
            Console.Write("Pleasr enter the first number:");
            Num1 = setnumbers();
            //Console.WriteLine();
            Console.Write("Please enter the second numbe:");
            Num2 = setnumbers();
            //Console.WriteLine();
            Console.WriteLine("Please choose the operation from the following (+,-,*,/): * ");
            op=Console.ReadLine();
            double re1=0,re2=0;
            switch (op)
            {
                case "+": re1 = Num1+Num2;break;
                case "-": re1 = Num1-Num2;break;
                case "*": re1 = Num1*Num2;break;
                case "/": re1= Num1/Num2;break;


            }
            Console.WriteLine("The result =" + re1);
            Console.Write("Please enter the third number");
            Num3 = setnumbers();
            Console.Write("Please enter the forth number:");
            Num4 = setnumbers();
            Console.WriteLine("Please choose the operation from the following (+,-,*,/): * ");
            op = Console.ReadLine();
            re2 = Mycalculatoer(Num3, Num4,op);
            Console.WriteLine("The result =" + re2);
            Console.Write("The result is the same for both operations?");
            if (re2 == re1)
                Console.WriteLine("True");
            else
                Console.WriteLine("False");

        }
    }
}
