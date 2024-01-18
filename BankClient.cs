using bank.Models;

namespace bank
{
    class BankClient
    {
        public static void Main()
        {
            IBankRepository s=new BankRepository();
            int c=0;
            while(true)
            {
                int acc=1;
                Console.WriteLine("Press 1 to create account, 2 to Get account details, 3 to deposit, 4 to withdraw, 5 to transaction statement, 6 to exit");
                int x=Convert.ToInt32(Console.ReadLine());
                if(x==1)
                {
                    SanchitSbaccount sa=new SanchitSbaccount();
                    sa.AccountNumber=acc;
                    Console.WriteLine("Enter name");
                    sa.CustomerName=Console.ReadLine();
                    Console.WriteLine("Enter place");
                    sa.CustomerAddress=Console.ReadLine();
                    Console.WriteLine("Enter starting Balance");
                    sa.CurrentBalance=Convert.ToInt32(Console.ReadLine());
                    s.NewAccount(sa);
                    acc++;
                }
                if(x==2)
                {
                    try{
                    Console.WriteLine("Enter account number which you want to search");
                    int y=Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine(s.GetAccountDetails(y));}
                    catch(Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                if(x==3)
                {
                    try{
                    c++;
                    Console.WriteLine("Enter account number in which you want to deposit");
                    int d=Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Amount you want to deposit");
                    int d1=Convert.ToInt32(Console.ReadLine());
                    s.DepositAmount(d,d1,c);}
                    catch(Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                if(x==4)
                {
                    try{
                    c++;
                    Console.WriteLine("Enter account number in which you want to withdraw");
                    int d=Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Amount you want to withdraw");
                    int d1=Convert.ToInt32(Console.ReadLine());
                    s.WithdrawAmount(d,d1,c);}
                    catch(Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                }
                if(x==5)
                {
                    Console.WriteLine("Enter account number in which you want transactions");
                    int d=Convert.ToInt32(Console.ReadLine());
                    List<SanchitSbtransaction> l=s.GetTransactions(d);
                    foreach(SanchitSbtransaction v in l)
                    {
                        Console.WriteLine(v);
                    }
                }
                if(x==6)
                {
                    break;
                }
            }
        }
    }
}