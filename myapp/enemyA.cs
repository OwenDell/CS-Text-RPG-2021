using System;

namespace myapp
{
    class enemyA
    {
      public string name;
      public string intro;
      public int health;
      public int maxhealth;
      public int defense;
      public int basedefense;
      public int damage;
      public int basedamage;
      public int btc;
      public int xp;
      public int evasion;
      public int baseevasion;
      public int accuracy;
      
      public enemyA(string iname, string iintro, int ihealth, int imaxhealth, int idefense, int ibasedefense, int idamage, int ibasedamage, int ibtc, int ixp, int ievasion, int ibaseevasion, int iaccuracy)
      {
          name = iname;
          intro = iintro;
          health = ihealth;
          maxhealth = imaxhealth;
          defense = idefense;
          basedefense = ibasedefense;
          damage = idamage;
          basedamage = ibasedamage;
          btc = ibtc;
          xp = ixp;
          evasion = ievasion;
          baseevasion = ibaseevasion;
          accuracy = iaccuracy;
      }
    }
}
