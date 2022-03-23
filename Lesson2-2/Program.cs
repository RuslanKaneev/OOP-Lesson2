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


        public static uint accountNumber = 12345678;
        private int accountBalance = 100000;
        private AccountType ClientAccountType = AccountType.MainAccount;

        public void AddAccountNumber()
        {
            accountNumber += 1;

        }

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
            Console.WriteLine($"Банковский счет Заремы: номер: { clientZaremaAccountNumber} баланс:{clientZaremaBalance} тип счета:{clienZaremaAccountType}");


            //заполняем клиента Зарема и потом опять считываем

            ClientZarema.WriteAccountBalance(9000);
            ClientZarema.WriteClientAccountType(BankAccount.AccountType.AccountInYuan);
            ClientZarema.AddAccountNumber();
            clienZaremaAccountType = ClientZarema.ReadClientAccountType();
            clientZaremaBalance = ClientZarema.ReadAccountBalance();



            //создаю объект клиента Промеса и считываю данные с приватных полей
            BankAccount ClientPromes = new BankAccount();
            uint clientPromesAccountNumber = ClientPromes.ReadAccountNumber();
            BankAccount.AccountType clienPromesAccountType = ClientPromes.ReadClientAccountType();
            int clientPromesBalance = ClientPromes.ReadAccountBalance();



            //заполняем клиента Промеса и потом опять считываем

            ClientPromes.WriteAccountBalance(8000);
            ClientPromes.WriteClientAccountType(BankAccount.AccountType.DollarAccount);
            ClientPromes.AddAccountNumber();
            clienPromesAccountType = ClientPromes.ReadClientAccountType();
            clientPromesBalance = ClientPromes.ReadAccountBalance();
            Console.WriteLine($"Банковский счет Промеса: номер: { clientPromesAccountNumber} баланс:{clientPromesBalance} тип счета:{clienPromesAccountType}");


        }
    }

}