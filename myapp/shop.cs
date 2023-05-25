using System;

namespace myapp
{
    class shop
    {
      public string name;
      public int price;
      public int val;
      public int val2;
      public int val3;
      public string desc;
      public int save;
      
      public shop(string iname, int iprice, int ival, int ival2, int ival3, string idesc, int isave)
      {
          name = iname;
          price = iprice;
          val = ival;
          val2 = ival2;
          val3 = ival3;
          desc = idesc;
          save = isave;
      }
    }
}
