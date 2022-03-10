using System;

class Accounts{
    #region variables
        int v_accNum;
        string v_accName = "";
        double v_accBalance;
        string v_accType = "";
        string v_accEmail = "";
        bool v_isAccountActive;
    #endregion

    #region properties
        public int accountNumber
        {
            get{ return v_accNum; }
            set{ v_accNum = value; }
        }

        public string accountName
        {
            get{ return v_accName; }
            set{ v_accName = value; }
        }

        public double accountBalance
        {
            get{ return v_accBalance; }
            set{ v_accBalance = value; }
        }

        public string accountType
        {
            get{ return v_accType; }
            set{ v_accType = value; }
        }

        public string accountEmail
        {
            get{ return v_accEmail; }
            set{ v_accEmail = value; }
        }

        public bool accountActive
        {
            get{ return v_isAccountActive; }
            set{ v_isAccountActive = value; }
        }
    #endregion

    #region methods
        public double Withdraw(double w_amount)
        {
            accountBalance = accountBalance - w_amount;
            return accountBalance;
        }

        public double Deposit(double d_amount)
        {
            accountBalance = accountBalance + d_amount;
            return accountBalance;
        }

        public double CheckBalance()
        {
            return accountBalance;
        }
    #endregion
}