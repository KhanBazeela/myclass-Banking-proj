using System;
namespace MyApplication
{
  class Program
{
    static void Main(string[] args)
  {
      Customer myCustomer = new Customer();
      myCustomer.withdraw(367825679726, 12000, 1231);
      myCustomer.transfer(123439754268, 42000, 3865);
      myCustomer.checkBalance(52296534569, 7654);

      Employee emp = new Employee();
      emp.login("Ibrahim", 3427329, 9847);
      emp.transactions(93467326587, 63000);
      emp.mailServices("Parveen","Hawal,Srinagar");    
  }
}
}