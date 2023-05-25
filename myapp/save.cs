using System;

namespace myapp
{
    class save
    {
      public int BTC;
      public int lvl;
      public int Chpot;
      public int Cmpot;
      public int HP;
      public int XP;
      public int Mana;
      public int Manamax;
      public int HPmax;
      public int STR;
      public int DEX;
      public int INT;
      public int Mtknife;
      public int Msbomb;
      
      public save(int iBTC, int ilvl, int iChpot, int iCmpot, int iHP, int iXP, int iMana, int iManamax, int iHPmax, int iSTR, int iDEX, int iINT, int iMtknife, int iMsbomb)
      {
          BTC = iBTC+100000000;
          lvl = ilvl+100;
          Chpot = iChpot+100;
          Cmpot = iCmpot+100;
          HP = iHP+1000;
          XP = iXP+10000;
          Mana = iMana+1000;
          Manamax = iManamax+1000;
          HPmax = iHPmax+1000;
          STR = iSTR+100;
          DEX = iDEX+100;
          INT = iINT+100;
          Mtknife = iMtknife+10;
          Msbomb = iMsbomb+10;
      }
    }
}
