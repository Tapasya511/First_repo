using Banking;

class Program
{
        public static void Main(String[] args)      
        {
            Bankaccount b1= new Bankaccount();
            b1.GetInfo();
        
            System.Console.WriteLine("Enter your choice 1. Deposit, 2. Withdrawal , 3. Fund Transfer, 4. Loan Eligibility, 5. FD Enquiry");
            int c = int.Parse(System.Console.ReadLine());

            switch (c)
            {
            case 1:
             System.Console.WriteLine("Enter amount to deposit");
             int d= int.Parse(System.Console.ReadLine());
             b1.Deposit(d);
             break;

            case 2:
             System.Console.WriteLine("Enter amount to withdraw");
             int w= int.Parse(System.Console.ReadLine());
             b1.Withdrawal(w);
             break;

            case 3:
             System.Console.WriteLine("Enter amount to transfer");
             int a= int.Parse(System.Console.ReadLine());
             b1.Fundtransfer(a);
            break;

            case 4:
             System.Console.WriteLine("Enter monthly salary");
             int m= int.Parse(System.Console.ReadLine());
             System.Console.WriteLine("Enter requested loan amount");
             int L= int.Parse(System.Console.ReadLine());
             b1.LoanEligibility(m, L);
            break;

            case 5:
            System.Console.WriteLine("Enter amount you want to enquire for FD");
            double fd_amount= double.Parse(System.Console.ReadLine());
             System.Console.WriteLine("Enter duration of FD");
             int t= int.Parse(System.Console.ReadLine());
             b1.FD_enquiry(t, fd_amount);
             break;
             

            default: System.Console.WriteLine("Enter valid option");
             break;
        }
    }    
}



