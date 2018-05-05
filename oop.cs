using System;
using System.Collections.Generic;

namespace csharp_intermediate
{
  public class HttpCookie {
    private readonly Dictionary<string, string> _dictionary;
    public HttpCookie(){
      _dictionary = new Dictionary<string, string>();
    }
    public string this[string key] {
      get{ return _dictionary[key];}
      set{ _dictionary[key] = value;}
    }
  }
  public class Person {
    private DateTime _birthdate;
    public void setBirthDate(DateTime birthdate) {
      _birthdate = birthdate;
    }
    public DateTime getBirthDate(){
      return _birthdate;
    }

    public string Name { get; set; }
    public class Other {
      public DateTime Birthdate {get; set;} //auto implemented property
   
    }
  }
}