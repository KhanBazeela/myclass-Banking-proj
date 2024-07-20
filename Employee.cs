using System;

namespace MyApplication
{
  class Employee : Users  // Derived class
  {
        
    public void login(string name, int empID, int password){
     Console.WriteLine("Logging in...");
    }
    
    public void transactions(long account_no, long amount){
     Console.WriteLine("Processing Transactions...");
    }
    
    public void mailServices(string name, string address){
     Console.WriteLine("Sending mail...");
    }
    }
  }