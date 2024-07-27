using System;

namespace MyApplication
{
  class Users()
{
  public string name;
  public long phone_no;
  public string address;

    public Users(string CustomerName, long PhoneNo,string Add)
    {
        name = CustomerName;
        phone_no = PhoneNo;
        address = Add;
    }
  }
}