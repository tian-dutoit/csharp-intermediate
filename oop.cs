using System;

namespace csharp_intermediate
{
  public class Person {
    private DateTime _birthdate;
    public void setBirthDate(DateTime birthdate) {
      _birthdate = birthdate;
    }
    public DateTime getBirthDate(){
      return _birthdate;
    }
  }
}