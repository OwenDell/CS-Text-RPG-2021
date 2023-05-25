using System;

namespace myapp
{
    class move
    {
      public string name;
      public int damage;
      public int val;
      public int val2;
      public int val3;
      public string desc;
      public int accuracy;
      
      public move(string iname, int idamage, int ival, int ival2, int ival3, string idesc, int iaccuracy)
      {
          name = iname;
          damage = idamage;
          val = ival;
          val2 = ival2;
          val3 = ival3;
          desc = idesc;
          accuracy = iaccuracy;
      }
    }
}
