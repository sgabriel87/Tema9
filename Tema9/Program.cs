// See https://aka.ms/new-console-template for more information

using Tema9;

CurrentAccount currentAccount = new CurrentAccount("Gabriel");
currentAccount.AddMoney(100);
currentAccount.GetMoney(1000);
currentAccount.GetMoney(5100);
currentAccount.SeeBalance();

SavingsAccount savingsAccount = new SavingsAccount("Gabriel", 0.05m);
savingsAccount.AddMoney(120);
savingsAccount.SeeBalance();

InvestmentAccount investmentAccount = new InvestmentAccount("Gabriel", 24);
investmentAccount.AddMoney(300);
investmentAccount.AllowWithdrawal();
investmentAccount.GetMoney(2000);

