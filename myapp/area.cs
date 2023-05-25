using System;

namespace myapp
{
    class area
    {
      public string name;
      public int rank;
      public int lvl;
      public int enemypct;
      public int lootpct;
      public int eventpct;
      public enemyA boss;
      public int unlocked;
      
      public area(string iname, int irank, int ilvl, int ienemypct, int ilootpct, int ieventpct, enemyA iboss, int iunlocked)
      {
          name = iname;
          rank = irank;
          lvl = ilvl;
          enemypct = ienemypct;
          lootpct = ilootpct;
          eventpct = ieventpct;
          boss = iboss;
          unlocked = iunlocked;
      }
    }
}
