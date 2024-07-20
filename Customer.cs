using System;

namespace MyApplication
{
  class Customer : Users  // Derived class
  {
        
    public void withdraw(long account_no, long amount, int pin){
     Console.WriteLine("Withdrawing Money...");
    }
    
    public void transfer(long account_no, long amount, int pin){
     Console.WriteLine("Transfering Money...");
    }
    
    public void checkBalance(long account_no, int pin){
     Console.WriteLine("Checking Balance...");
    }
  }
}