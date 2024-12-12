using System;
using System.IO;
using System.Dynamic;
using System.Transactions;
using System.Security.Cryptography.X509Certificates;
using System.Runtime.Intrinsics.X86;
namespace Banking;

public class Bankaccount : ICICI, SBI
{
    public int current_amt;
    private string name= "", city ="";
    private int num=0;
    public string Name
    {
        get => name;
        set => name= value;
    }
    public string City
    {
        get => city;
        set => city= value;
    }
    public int Number
    {
        get => num;
        set => num= value;
    }
        public void GetInfo()
        {
        System.Console.WriteLine("Enter customer name");
        Name= System.Console.ReadLine();
        System.Console.WriteLine("Enter customer City");
        City= System.Console.ReadLine();
        System.Console.WriteLine("Enter customer Account Number");
        int v = int.Parse(System.Console.ReadLine());
        Number= v;

        System.Console.WriteLine("Enter current amount");
        current_amt = int.Parse(System.Console.ReadLine());
        }
        public void Deposit(int dep)
        {
           int D= dep;
            current_amt += D;
            System.Console.WriteLine("Balance after deposit:");
            System.Console.WriteLine(current_amt);
            System.Console.WriteLine(Name);
            System.Console.WriteLine(City);
            System.Console.WriteLine(Number);
        }

        public void Withdrawal(int wth)
        {
            int W= wth;   
            current_amt -= W;
            System.Console.WriteLine("Balance after withdrawal:");
            System.Console.WriteLine(current_amt);
        }

        public void Fundtransfer(int amount)
        {
           if(amount<0 && amount>current_amt)
            System.Console.WriteLine("Insufficient funds");
           else
            System.Console.WriteLine("Enter sender account number");
            int sender= int.Parse(System.Console.ReadLine());
            current_amt-=amount;
            System.Console.WriteLine("Remaining balance:");
            System.Console.WriteLine(current_amt);
        } 

        public void LoanEligibility(int Monthly, int req_amt)
        {
            if(Monthly< req_amt/15)
             System.Console.WriteLine("Not Eligible for loan");

            else
             System.Console.WriteLine("Eligible for loan, Please contact customer executive for further steps");
        }

        public void FD_enquiry(int time, double f_amt)
        {
            double A= f_amt; int t= time;
            A = A+ ((t * A * 6.25)/100);
            System.Console.WriteLine("Maturity amount for requested FD is:");
            System.Console.WriteLine(A);
        }
}