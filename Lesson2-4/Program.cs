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
            _accountBalance = accountBalanceUser;


        }

        public BankAccount(AccountType clientAccountTypeUser)
        {
            AddAccountNumber();
            _clientAccountType = clientAccountTypeUser;

        }

        public BankAccount(AccountType clientAccountTypeUser, int accountBalanceUser)
        {
            AddAccountNumber();
            _accountBalance = accountBalanceUser;
            _clientAccountType = clientAccountTypeUser;
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

        private static uint _accountNumber = 10000000;
        public uint AccountNumber
        {
            get
            {
                return _accountNumber;
            }
            set
            {
                _accountNumber = value;
            }

        }

        private int _accountBalance = 100000;
        public int AccountBalance
        {
            get
            {
                return _accountBalance;
            }
            set
            {
                _accountBalance = value;
            }

        }

        private AccountType _clientAccountType;
        public AccountType ClientAccountType
        {
            get
            {
                return _clientAccountType;
            }
            set
            {
                _clientAccountType = value;
            }

        }


        public void AddAccountNumber()
        {
            _accountNumber += 1;

        }



    }


    public class Program
    {
        static void Main(string[] args)
        {


            var ClientZarema = new BankAccount(BankAccount.AccountType.CreditAccount, 1300000);
            Console.WriteLine($"Банковский счет Заремы:номер{ClientZarema.AccountNumber} сумма баланса: {ClientZarema.AccountBalance} тип счета: {ClientZarema.ClientAccountType}");


            var ClientPromes = new BankAccount(BankAccount.AccountType.InvestmentAccount, 1200);
            Console.WriteLine($"Банковский счет Промеса: номер {ClientPromes.AccountNumber} сумма баланса: {ClientPromes.AccountBalance} тип счета: {ClientPromes.ClientAccountType}");

        }
    }

}