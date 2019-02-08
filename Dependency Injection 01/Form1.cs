using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dependency_Injection_01
{

    public interface IAccount
    {
        void PrintData();
    }
    //Implemented the IAccount interface in SavingAccount class  
    public class SavingAccount : IAccount
    {
        public void PrintData()
        {
            Console.WriteLine("Saving account data.");
        }
    }

    public class CurrentAccount : IAccount
    {
        public void PrintData()
        {
            Console.WriteLine("Current account data.");
        }
    }

    //Account class is not depended on any other classes.  
    //So now it is loosely coupled.  
    public class Account
    {
        //Passing "IAccount" as parameter to PrintAccounts() method  
        public void PrintAccounts(IAccount account)
        {
            account.PrintData();
        }
    }



    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //If you want to calls the SavingAccount class PrintAccounts() method,   
            //just created the object of SavingAccount() and directly pass as parameter   
            //to Account class method (i.e PrintAccounts(new SavingAccount())).  
            Account savingAccount = new Account();
            savingAccount.PrintAccounts(new SavingAccount());

            //If you want to calls the CurrentAccount class PrintAccounts() method,   
            //just created the object of CurrentAccount() and directly pass as parameter   
            //to Account class method (i.e PrintAccounts(new SavingAccount())).  
            Account currentAccount = new Account();
            currentAccount.PrintAccounts(new CurrentAccount());

            Console.ReadLine();
        }
    }
}
