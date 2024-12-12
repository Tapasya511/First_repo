using System;

namespace Banking;

interface ICICI
{
     public void Fundtransfer(int A);
}

interface SBI
{
    public void LoanEligibility(int Mon, int Loan_amt);
}

interface PNB
{
    public void FD_enquiry(int time, int f_amount);
}


