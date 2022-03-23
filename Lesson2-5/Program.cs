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

        public int PutBalance(int balanceUser)
        {
            _accountBalance += balanceUser;
            return _accountBalance;
        }

        public int WithdrawBalance(int balanceUser)
        {
            if (_accountBalance >= balanceUser)
            {
                _accountBalance -= balanceUser;
                return _accountBalance;
            }
            else
            {
                Console.WriteLine("Вы превысили лимит, введите другую сумму");
                return _accountBalance;
            }

        }



    }


    public class Program
    {
        static void Main(string[] args)
        {


            var ClientZarema = new BankAccount(BankAccount.AccountType.CreditAccount, 1300000);
            Console.WriteLine($"Банковский счет Заремы:  { ClientZarema.AccountNumber} {ClientZarema.AccountBalance} {ClientZarema.ClientAccountType}");

            ClientZarema.PutBalance(1400000);
            Console.WriteLine($"Баланс после пополнения:  {ClientZarema.AccountBalance}");

            ClientZarema.WithdrawBalance(2700000);
            Console.WriteLine($"Баланс после снятия: {ClientZarema.AccountBalance}");

            var ClientPromes = new BankAccount(BankAccount.AccountType.InvestmentAccount, 1200);
            Console.WriteLine($"Банковский счет Промеса:  {ClientPromes.AccountNumber} {ClientPromes.AccountBalance} {ClientPromes.ClientAccountType}");

            ClientPromes.PutBalance(1000);
            Console.WriteLine($"Баланс после пополнения:  { ClientPromes.AccountBalance}");

            ClientPromes.WithdrawBalance(2300);
            Console.WriteLine($"Баланс после снятия: {ClientPromes.AccountBalance}");

            Console.ReadLine();
        }
    }

}