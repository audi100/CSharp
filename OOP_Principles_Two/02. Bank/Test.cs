using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Globalization;


class Test
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        DepositAccount depAccountInd = new DepositAccount(new Individual("Boyko Draganov", "9090909090"), 230m, 0.003m);
        DepositAccount depAccountComp = new DepositAccount(new Company("Barista", "999999999"), 13000m, 0.006m);

        MortgageAccount mortAccountInd = new MortgageAccount(new Individual("Georgi Dimitrov", "9090909190"), 2300m, 0.005m);
        MortgageAccount mortAccountComp = new MortgageAccount(new Company("Sky", "999999999"), 35000m, 0.008m);

        LoanAccount loanAccountInd = new LoanAccount(new Individual("Hani Kovachev", "9090909190"), 2300m, 0.005m);
        LoanAccount loanAccountComp = new LoanAccount(new Company("Scraper BG", "999999999"), 5000m, 0.002m);

        List<Account> accounts=new List<Account>(){depAccountInd, depAccountComp, mortAccountInd, mortAccountComp,
        loanAccountInd, loanAccountComp};

       // Random randGenerator = new Random();

        foreach (var acc in accounts)
        {
            Console.WriteLine("I am {0}, I am owned by {1}, my current balance is \n{2} and the interest rate for {3} months is: {4:F2}", acc.GetType(), 
                acc.Customer.GetType(), acc.Balance, 3, acc.CalculateInterest(3));
            Console.WriteLine(new string('-',50));
        }
        depAccountInd.DepositMoney(1000);
        depAccountInd.WithdrawMoney(130);
        
        Console.WriteLine("Deposit Account owned by Individual:\nMy current balance is:{0}, and my interest for 2 months is: {1:F2}",
        depAccountInd.Balance, depAccountInd.CalculateInterest(2));
    }
}

