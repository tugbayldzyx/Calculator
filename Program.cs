namespace HesapMakinası_SwitchCase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*******CALCULATOR**********");

            back: Console.WriteLine("1.Number:");
            double num1=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("2.Number:");
            double num2=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Please select the action you want to perform, [ + | - | * | / ] Leave blank to exit:");
            string process=Console.ReadLine();

            if (process!=string.Empty)
            {
                switch(process)
                {
                    case " + ":
                         Console.WriteLine("Total = " + (num1+num2));
                         break;

                    case "-":
                        Console.WriteLine("Difference = " + (num1 - num2));
                        break;

                    case "*":
                        Console.WriteLine("Product= " + (num1) * (num2));
                        break;


                    case "/":
                        Console.WriteLine("Divided = " + (num1) / (num2));
                        goto back;
                        break;
                    default:
                        break;
                }
            }
            else
            {
                Console.WriteLine("Transaction failed!");
            }
            Console.ReadLine();

        }
    }
}