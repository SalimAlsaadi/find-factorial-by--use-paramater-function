namespace functions_with_parametars
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("please enter number to find Factorial: ");

            int realCalculate = calculatFac(Console.ReadLine());//here we give value for variable by using paramater function.

            
            Console.WriteLine("the factorial of this number is : "+realCalculate);

            static int calculatFac(string num)   //if function declared by prototype, then must teturn a value as same prototype given.
            {                                   //this function is used for find factorial of any number that user entered.


                int integerNum = int.Parse(num);
                int fact = 1; 
                for(int i=integerNum; i>1; i--)
                {
                    fact = fact * i;

                }
                return fact;//return value because thuis function is delcared.
            }

        }
    }
}