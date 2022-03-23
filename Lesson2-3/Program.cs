namespace Lesson2
{

    public class BankAccount
    {
        public BankAccount()
        {
            AddAccountNumber();

        }

        public BankAccount(int accountBalanceUser)
        {
            AddAccountNumber();
            accountBalance = accountBalanceUser;


        }

        public BankAccount(AccountType clientAccountTypeUser)
        {
            AddAccountNumber();
            clientAccountType = clientAccountTypeUser;

        }

        public BankAccount(AccountType clientAccountTypeUser, int accountBalanceUser)
        {
            AddAccountNumber();
            accountBalance = accountBalanceUser;
            clientAccountType = clientAccountTypeUser;
        }

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

        public static uint accountNumber = 12345678;
        private int accountBalance = 100000;
        private AccountType clientAccountType = AccountType.MainAccount;

        public void AddAccountNumber()
        {
            accountNumber += 1;

        }

        public uint ReadAccountNumber()
        {
            return accountNumber;
        }

        public int ReadAccountBalance()
        {

            return accountBalance;
        }

        public AccountType ReadClientAccountType()
        {
            return clientAccountType;
        }



    }

    public class Program
    {
        static void Main(string[] args)
        {

            //создаю объект клиента Зарема и считываю данные с приватных полей
            var ClientZarema = new BankAccount(BankAccount.AccountType.CreditAccount, 1300000);
            uint clientZaremaAccountNumber = ClientZarema.ReadAccountNumber();
            BankAccount.AccountType clienZaremaAccountType = ClientZarema.ReadClientAccountType();
            int clientZaremaBalance = ClientZarema.ReadAccountBalance();

            Console.WriteLine($"Банковский счет Заремы: номер: { clientZaremaAccountNumber} баланс:{clientZaremaBalance} тип счета:{clienZaremaAccountType}");


            //создаю объект клиента Промеса и считываю данные с приватных полей
            var ClientPromes = new BankAccount(BankAccount.AccountType.InvestmentAccount, 1200);
            uint clientPromesAccountNumber = ClientPromes.ReadAccountNumber();
            BankAccount.AccountType clienPromesAccountType = ClientPromes.ReadClientAccountType();
            int clientPromesBalance = ClientPromes.ReadAccountBalance();
            Console.WriteLine($"Банковский счет Промеса: номер: { clientPromesAccountNumber} баланс:{clientPromesBalance} тип счета:{clienPromesAccountType}");

        }
    }

}