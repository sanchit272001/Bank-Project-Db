using Azure.Core;
using bank.Models;

namespace bank
{
    class BankRepository : IBankRepository
    {
        public static Ace52024Context db=new Ace52024Context();
        class NotFound:ApplicationException
        {
            public NotFound(string message):base(message){}
        }
        
        public void DepositAmount(int accno, int amt,int c)
        {
            if(amt<0)
            {
                throw new NotFound("Deposit amount is less than 0");
            }
            SanchitSbaccount s=db.SanchitSbaccounts.Find(accno);
            if(s==null)
            {
                throw new NotFound("Account not found");
            }
            s.CurrentBalance+=amt;
            db.SanchitSbaccounts.Update(s);
            db.SaveChanges();
            SanchitSbtransaction ss=new SanchitSbtransaction();
            ss.TransactionId=c;
            ss.TransactionDate=DateTime.Now;
            ss.TransactionType="Deposit";
            ss.AccountNumber=accno;
            ss.Amount=amt;
            db.SanchitSbtransactions.Add(ss);
            db.SaveChanges();
        }

        public SanchitSbaccount GetAccountDetails(int accno)
        {
            SanchitSbaccount s=db.SanchitSbaccounts.Find(accno);
            if(s==null)
            {
                throw new NotFound("Account not found");
            }
            else{
                Console.WriteLine(s.AccountNumber);
                Console.WriteLine(s.CustomerName);
                Console.WriteLine(s.CustomerAddress);
                Console.WriteLine(s.CurrentBalance);
            }
            return new SanchitSbaccount();
        }

        public List<SanchitSbaccount> GetAllAccounts()
        {
            return db.SanchitSbaccounts.ToList();
        }

        public List<SanchitSbtransaction> GetTransactions(int accno)
        {            
            return db.SanchitSbtransactions.ToList();
        }

        public void NewAccount(SanchitSbaccount acc)
        {            
            db.SanchitSbaccounts.Add(acc);
            db.SaveChanges();
        }

        public void WithdrawAmount(int accno, int amt,int c)
        {
            SanchitSbaccount s=db.SanchitSbaccounts.Find(accno);
            if(s==null)
            {
                throw new NotFound("Account not found");
            }            
            if(s.CurrentBalance<amt)
            {
                throw new NotFound("Deposit amount is less than 0");
            }
            s.CurrentBalance-=amt;
            db.SanchitSbaccounts.Update(s);
            db.SaveChanges();
            SanchitSbtransaction ss=new SanchitSbtransaction();
            ss.TransactionId=c;
            ss.TransactionDate=DateTime.Now;
            ss.TransactionType="Withdraw";
            ss.AccountNumber=accno;
            ss.Amount=amt;
            db.SanchitSbtransactions.Add(ss);
            db.SaveChanges();            
        }      

    }
}