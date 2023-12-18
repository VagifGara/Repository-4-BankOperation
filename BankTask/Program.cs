namespace BankTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Operation();
        }

        public static void Operation()
        {
            ChooseİnOperation();

            int choose = int.Parse(Console.ReadLine());
            int balance = 2000;

            if (choose == 1 || choose == 2 || choose == 3)
            {
                if (choose == 1)
                {
                    SeeInBalance(balance);
                }
                else if (choose == 2)
                {
                    SeeInBalance(balance);
                    Console.WriteLine("Cixaracaginiz meblegi yazin : ");
                    int value = int.Parse(Console.ReadLine());
                    CashOut(value,balance);
                }
                else if (choose == 3)
                {
                    SeeInBalance(balance);
                    Console.WriteLine("Elave edeceyiniz meblegi yazin : ");
                    int value = int.Parse(Console.ReadLine());
                    CashIn(value, balance);
                }

                Operation();
            }
            else if (choose == 0)
            {
                Console.WriteLine("Bizi secdiyiniz ucun tewekkurler :) ");
            }
            else
            {
                Console.WriteLine("Melumati duzgun daxil edin !");
                Operation();
            }

        }

        public static void SeeInBalance(int balance)
        {

            Console.WriteLine("Balance : ");
            Console.WriteLine($"{balance} AZN ");

        }
        public static int CashOut(int value, int balance)
        {


            int newbalance;
            newbalance = balance - value;

            if (balance >= value)
            {
                Console.WriteLine(newbalance);
            }
            else
            {
                Console.WriteLine("Emeliyyat duzgun deyil !!");
            }

            return newbalance;
        }

        public static int CashIn(int value, int balance)
        {
            balance = CashOut(value, balance) + value;
            return balance;
        }

        public static void ChooseİnOperation()
        {
            Console.WriteLine("[1] yazanda balansi ekrana cap ele");
            Console.WriteLine("[2] Pul cixar");
            Console.WriteLine("[3] Cash in");
            Console.WriteLine("[0] Cix");
        }


    }
}