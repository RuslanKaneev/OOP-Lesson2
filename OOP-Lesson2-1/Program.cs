

namespace Lesson2
{

    public class BankAccount
    {
        public enum AccountType
        {
            MainAccount = 1,
            DollarAccount = 2,
            EuroAccount = 3,
            AccountInYuan = 4,
            SavingsAccount = 5,
            InvestmentAccount = 6,
            CreditAccount = 7,
            MortgageAccount = 8
        }


        private uint accountNumber = 5;
        private int accountBalance = 12345678;
        private AccountType ClientAccountType = AccountType.MainAccount;
        public uint ReadAccountNumber()
        {
            return accountNumber;
        }
        public void WriteAccountNumber(uint numberAcc)
        {
            accountNumber = numberAcc;

        }
        public int ReadAccountBalance()
        {

            return accountBalance;
        }
        public void WriteAccountBalance(int balanceAcc)
        {
            accountBalance = balanceAcc;
        }
        public AccountType ReadClientAccountType()
        {
            return ClientAccountType;
        }
        public void WriteClientAccountType(AccountType accountType)
        {
            ClientAccountType = accountType;
        }



    }


    public class Program
    {
        static void Main(string[] args)
        {
            //создаю объект клиента Зарема и считываю данные с приватных полей
            BankAccount ClientZarema = new BankAccount();
            uint clientZaremaAccountNumber = ClientZarema.ReadAccountNumber();
            BankAccount.AccountType clienZaremaAccountType = ClientZarema.ReadClientAccountType();
            int clientZaremaBalance = ClientZarema.ReadAccountBalance();
            Console.WriteLine($"{clientZaremaAccountNumber} {clientZaremaBalance} {clienZaremaAccountType}");

            //заполняем и потом опять считываем
            ClientZarema.WriteAccountNumber(1000000);
            ClientZarema.WriteAccountBalance(9000);
            ClientZarema.WriteClientAccountType(BankAccount.AccountType.AccountInYuan);
            clientZaremaAccountNumber = ClientZarema.ReadAccountNumber();
            clienZaremaAccountType = ClientZarema.ReadClientAccountType();
            clientZaremaBalance = ClientZarema.ReadAccountBalance();
            Console.WriteLine($"{clientZaremaAccountNumber} {clientZaremaBalance} {clienZaremaAccountType}");

        }
    }

}    