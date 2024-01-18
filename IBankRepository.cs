using bank.Models;

namespace bank
{
    interface IBankRepository
    {
        void NewAccount(SanchitSbaccount acc);
        List<SanchitSbaccount> GetAllAccounts();
        SanchitSbaccount GetAccountDetails(int accno);
        void DepositAmount(int accno,int amt,int id);
        void WithdrawAmount(int accno,int amt,int id);
        List<SanchitSbtransaction>GetTransactions(int accno);

    }
}