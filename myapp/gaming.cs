using System;

namespace myapp
{
    class rpggamer
    {
    //Stat Variables
        public static int BTC = 1;
        public static int HP = 100;
        public static int HPmax = 100;
        public static int Mana = 20;
        public static int Manamax = 20;
        public static int lvl = 1;
        public static int XP = 0;
        public static int STR = 1;
        public static int DEX = 1;
        public static int INT = 1;
    //Random Variables
        public static string shopresponsed1;
        public static string useresponse;
        public static string eventresponse;
        public static string fightaction;
        public static string ls;
        public static string randomstring;
        public static int randomint;
        public static int randomint2;
        public static int randomint3;
        public static int statusl1;
        public static int statusl2;
        public static int statusl3;
        public static string HPdisp;
        public static string Manadisp;
        public static bool fled;
        public static string turn = "Player";
        public static bool CombatWin = false;
        public static bool devSleep = false; //set to true to de-activate all of the delays, useful for when you want to test something quickly without waiting through the long intro.;
        public static string invalid = "\nInvalid response, please enter one of the provided options.\n";
    //Item value variables
        public static int Sfireballval = 10;
        public static int Sfireballval2 = 5;
        public static int Semptyval = 0;
        public static int Semptyval2 = 0;
        public static int Shealval = 20;
        public static int Shealval2 = 15;
        public static int Wfistval = 1;
        public static int Wwswordval = 4;
        public static int Wsclubval = 8;
        public static int Wsdaggerval = 7;
        public static int Ashirtval = 0;
        public static int Apvestval = 2;
        public static int Altunicval = 4;
        public static int Chpotval = 15;
        public static int Cmpotval = 10;
    //    Items     (.name, .price, .val, .val2, .val3, .desc, .save)
        //Spells (Name, Price, Effect Strength, Mana Cost, val3, Description, Save)
            public static shop Sempty = new shop("Empty Slot", 0, Semptyval, Semptyval2, 0, $"[Does nothing]", 10);
            public static shop Sfireball = new shop("Fireball", 35, Sfireballval, Sfireballval2, 0, $"[Throw ball of fire dealing {Sfireballval} damage - Costs {Sfireballval2} Mana]", 11);
            public static shop Sheal = new shop("Heal", 50, Shealval, Shealval2, 0, $"[Recovers {Shealval} Health - Costs {Shealval2} Mana]", 12);
        //Weapons (Name, Price, Damage, Crit Damage, Accuracy, Description, Save)
            public static shop Wfist = new shop("Fist", 0, Wfistval, 2, 1, $"[Your bare fists, does {Wfistval} damage]", 10);
            public static shop Wwsword = new shop("Wood Sword", 1, Wwswordval, 5, 3, $"[A flimsy wooden sword, does {Wwswordval} damage]", 11);
            public static shop Wsclub = new shop("Spiked Club", 25, Wsclubval, 10, 1, $"[A common spiked club, does {Wsclubval} damage]", 12);
            public static shop Wsdagger = new shop("Stone Dagger", 40, Wsdaggerval, 20, 10, $"[A stone dagger with very high crit damage, does {Wsdaggerval} damage]", 13);
        //Armor (Name, Price, Defense, Evasion, val3, Description, Save)
            public static shop Ashirt = new shop("Shirt", 0, Ashirtval, 8, 0, $"[A very light common shirt, provides {Ashirtval} defense]", 10);
            public static shop Apvest = new shop("Padded Vest", 30, Apvestval, 6, 0, $"[A light slightly padded vest, provides {Apvestval} defense]", 11);
            public static shop Altunic = new shop("Leather Tunic", 70, Altunicval, 3, 0, $"[A fairly flexible leather tunic, provides {Altunicval} defense]", 12);
        //Consumables (Name, Price, Effect Strength, Amount, val3, Description, Save)
            public static shop Chpot = new shop("Health Potion", 15, Chpotval, 3, 0, $"[Heals you for {Chpotval} Health]", 0);
            public static shop Cmpot = new shop("Mana Potion", 10, Cmpotval, 1, 0, $"[Restores {Cmpotval} of your Mana]", 0);
        //Misc (Name, Price, Effect Strength, Amount, val3, Description, Save)
            public static shop Mtknife = new shop("Throwing Knife", 5, 5, 5, 80, $"[A knife to throw at your enemies]", 0);
            public static shop Msbomb = new shop("Smoke Bomb", 15*lvl, 0, 1, 0, $"[Creates a cloud of smoke to escape from combat]", 0);
    //Equipment Slots (shop)
        public static shop spell1 = Sempty;
        public static shop spell2 = Sempty;
        public static shop spell3 = Sempty;
        public static shop spell4 = Sempty;
        public static shop weapon = Wfist;
        public static shop armor = Ashirt;
    //Common Enemies (enemyA) (.name, .intro, .health, .maxhealth, .defense, .basedefense, .damage, .basedamage, .btc, .xp, .evasion, .baseevasion, .accuracy)
        public static enemyA Slime = new enemyA("Slime", "You encountered a small green Slime kinda just vibing... nonetheless it must perish, prepare to attack!", 15, 15, 0, 0, 4, 4, 8, 10, 2, 2, 1);
        public static enemyA Zombie = new enemyA("Zombie", "From the dark brush you hear a deep groan... followed by a mindless Zombie, prepare to attack!", 30, 30, 0, 0, 5, 5, 15, 23, -5, -5, -3);
        public static enemyA SkeletonArcher = new enemyA("Skeleton Archer", "As you're walking along a dirt trail an arrow hits the tree next to you. You turn around and see a Skeleton Archer with another arrow knocked, prepare to attack!", 25, 25, 1, 1, 7, 7, 18, 20, 5, 5, -10);
        public static enemyA SkeletonWarrior = new enemyA("Skeleton Warrior", "A bulky skeletal warrior jumps out at you with their sword raised, prepare to attack!", 40, 40, 3, 3, 6, 6, 33, 25, 2, 2, 1);
    //Special Enemies (enemyA) (.name, .intro, .health, .maxhealth, .defense, .basedefense, .damage, .basedamage, .btc, .xp, .evasion, .accuracy)
        public static enemyA Mimic = new enemyA("Mimic", "Despite having no eyes, the Mimic turns towards you and jumps out at you mouth agape, prepare to attack!", 50, 50, 5, 5, 14, 14, 250, 70, -5, -5, 0);
    //Bosses (enemyA) (.name, .intro, .health, .maxhealth, .defense, .basedefense, .damage, .basedamage, .btc, .xp, .evasion, .accuracy)
        public static enemyA Father = new enemyA("Father", "You fool... there is no escape from this place!", 9999, 9999, 100, 100, 100, 100, 7777777, 8888888, 20, 20, 1000);
        public static enemyA ForestShade = new enemyA("Forest Shade", "As you journey past the Shady Meadow and arrive at the edge of the Dark Forest, a dark wispy mist appears before you... until it forms into an evil Forest Shade! prepare to attack!", 100, 100, 0, 0, 8, 8, 60, 85, 15, 15, 10);
    //Moves (move) (.name, .damage, .val, .val2, .val3, .desc, .accuracy)
        public static move LidBash = new move("Lid Bash", 10, 7, 0, 0, "The Mimic tightly closed their lid and leapt at you temporarily increasing their defense!", -5);
        public static move MimicChomp = new move("Chomp", 25, 3, 0, 0, "The Mimic leapt high into the air, then opened it's mouth wide while falling straight towards you!", -20);
        public static move ShadowOrb = new move("Shadow Orb", 10, 4, 0, 0, "Deals full true damage if hit, or reduced standard damage if dodged", -10);
        public static move Evasive = new move("Evasive", 20, 3, 0, 0, "Increases evasion for set number of turns", 0);
        public static move BuffDMG = new move("Damage Buff", 7, 3, 0, 0, "Increases damage for set number of turns", 0);
    //Spells (move) (name, damage, mana cost, .val2, .val3, description, accuracy)
        public static move Fireball = new move("Fireball", Sfireball.val, Sfireball.val2, 0, 0, "You hurl a ball of fire at the enemy!", 5);
        public static move Heal = new move("Heal", Sheal.val, Sheal.val2, 0, 0, "You healed yourself!", 0);
    //Areas (area) (.name, .rank, .lvl, .enemypct, .lootpct, .eventpct, .boss)
        public static area ShadyMeadow = new area("Shady Meadow", 1, 1, 65, 85, 100, Father, 2);
        public static area DarkForest = new area("Dark Forest", 2, 3, 65, 85, 100, ForestShade, 1);
        public static area currentarea = ShadyMeadow;
//Main
        static void Main(string[] args)
        {
    //Variables
        bool Victory = false;
    //Intro
        Delay(700, devSleep);
        Console.WriteLine("Would you like to skip the intro? Y/N ?\n");
        randomstring = Console.ReadLine();
        if (randomstring != "Y")
        {
            Delay(1500, devSleep);
            Console.WriteLine("\nYou started off as a young little poor urchin living off the streets...");
            Delay(8000, devSleep);
            Console.WriteLine("One day, fortune smiled upon you as a glimmer from a pile of trash caught your eye.");
            Delay(5000, devSleep);
            Console.WriteLine("To your shock, in that trash pile you discovered 1 solid Bitcoin. You knew this was a sign that you were destined for greatness.");
            Delay(7000, devSleep);
        }
        Console.WriteLine("\nWhat is your characters name? \n");
        string name = Console.ReadLine();
        Delay(1000, devSleep);
        Console.WriteLine($"\nWelcome, {name}, now go out and embark on your glorious conquest to wealth and fortune!\n");
        Delay(2000, devSleep);
    //Gameplay Loop
        while (Victory == false)
            {

                Delay(1000, devSleep);
                Cap();

            //Updating Variables
                Msbomb = new shop("Smoke Bomb", 15*lvl, 0, Msbomb.val2, 0, $"[Creates a cloud of smoke to escape from combat]", 0);
                HPdisp = $"{HP} / {HPmax}";
                Manadisp = $"{Mana} / {Manamax}";
                int XPreq = (((lvl-1)*25)+100);
                double XPprog = (XP/XPreq);
                string XPdisp = $"{XP} / {XPreq}";
                int HealCost = Convert.ToInt32((HPmax-HP)*(0.3+(0.2*lvl)));
                //int HealCost = Convert.ToInt32(((HPmax-HP)/2)+(((HPmax-HP)*lvl)/6));
                int RestCost = (10*lvl);

            //health check
                if (HP <= 0)
                {
                    HP = 0;
                    Console.WriteLine("\nYou are too injured to go on...");
                    Delay(3000, devSleep);
                    Console.WriteLine("You feel yourself being dragged away as you drift out of consciousness...");
                    Delay(7000, devSleep);
                    Console.WriteLine("You open your eyes to the interior of a sterile hospital. A nearby nurse sees you awake and comes over to you.");
                    Delay(5000, devSleep);
                    Console.WriteLine($"\"Hey there {name}, glad to see you awake, wasn't sure if we were ever going to.\"");
                    Delay(4000, devSleep); 
                    Console.WriteLine($"\"You're in pretty rough shape... we can patch you up... but it's going to cost you. {HealCost} BTC to be exact.\"");
                    Delay(5000, devSleep);
                    Console.WriteLine($"Would you like to pay {HealCost} BTC to be healed from your critical state?\nY/N ?\n");
                    Delay(1000, devSleep);
                    string notdying = Console.ReadLine();
                    Delay(1000, devSleep);
                    Console.WriteLine("");
                    if (notdying == "Y")
                    {
                        if (BTC >= HealCost)
                        {
                            Console.WriteLine($"\"You're very lucky to be alive {name}, we almost didn't manage to save you. Be more careful, you might not be so lucky next time...\"");
                            Delay(5500, devSleep);
                            Console.WriteLine($"You leave the hospital alive and {HealCost} BTC poorer.\n");
                            BTC = (BTC - HealCost);
                            HP = HPmax;
                            continue;
                        }
                        else
                        {
                            Console.WriteLine($"Well this is awkward... you're actually {HealCost-BTC} BTC short... sorry but maybe if you didn't wanna die you should'nt've been so poor.");
                            Delay(6000, devSleep);
                            Console.WriteLine("You soon succumbed to your injuries and died while cursing this lands healthcare system.\n");
                            Delay(5000, devSleep);
                            Victory = true;
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Well sucks to be you I guess");
                        Delay(2500, devSleep);
                        Console.WriteLine("You soon succumbed to your injuries and died due to your mistrust in the healtchare system and your refusal to recieve medical attention.\n");
                        Delay(5000, devSleep);
                        Victory = true;
                        break;
                    }
                }

            //Level up
                if (XPprog >= 1)
                {
                    Delay(600, devSleep);
                    Console.WriteLine($"\nLevel up available! You're now Level {lvl+1}!");
                    Delay(1000, devSleep);
                    Console.WriteLine("Please select what stat you would like to increase from the following:\nHealth\nMana\nStrength\nDexterity\nIntelligence\n");
                    string lupselect = Console.ReadLine();
                    Console.WriteLine("");
                    Delay(500, devSleep);
                    if (lupselect == "Health")
                    {
                        XP = (XP - XPreq);
                        HPmax = (HPmax + 50);
                        HP = HPmax;
                        Mana = Manamax;
                        lvl = (lvl + 1);
                        Console.WriteLine($"You increased your max health to {HPmax}!");
                        continue;
                    }
                    else if (lupselect == "Mana")
                    {
                        XP = (XP - XPreq);
                        Manamax = (Manamax + 10);
                        HP = HPmax;
                        Mana = Manamax;
                        lvl = (lvl + 1);
                        Console.WriteLine($"You increased your max mana to {Manamax}!");
                        continue;
                    }
                    else if (lupselect == "Strength")
                    {
                        XP = (XP - XPreq);
                        STR = (STR + 1);
                        HP = HPmax;
                        Mana = Manamax;
                        lvl = (lvl + 1);
                        Console.WriteLine($"You increased your strength to {STR}!");
                        continue;
                    }
                    else if (lupselect == "Dexterity")
                    {
                        XP = (XP - XPreq);
                        DEX = (DEX + 1);
                        HP = HPmax;
                        Mana = Manamax;
                        lvl = (lvl + 1);
                        Console.WriteLine($"You increased your dexterity to {DEX}!");
                        continue;
                    }
                    else if (lupselect == "Intelligence")
                    {
                        XP = (XP - XPreq);
                        INT = (INT + 1);
                        HP = HPmax;
                        Mana = Manamax;
                        lvl = (lvl + 1);
                        Console.WriteLine($"You increased your intelligence to {INT}!");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine(invalid);
                        continue;
                    }
                }

            //Start
                Console.WriteLine("\nWhat would you like to do? (Enter \"Commands\" for a list of options)\n");
                string response = Console.ReadLine();

            //Commands
                if (response == "Commands")
                {
                    Delay(400, devSleep);
                    Console.WriteLine($"\nList of Options: \n");
                    Console.WriteLine("Shop (Takes you to the local Traitor Joses' General Convenience Store)");
                    Console.WriteLine("Status (Checks your general status)");
                    Console.WriteLine("BTC (Checks how much Bitcoin you have)");
                    Console.WriteLine("Equipment (Checks your gear & equipment)");
                    Console.WriteLine("Inventory (Checks your Inventory)");
                    Console.WriteLine("Explore (You explore the vast open wilds)");
                    Console.WriteLine($"Heal (Heal to full health at the cost of {HealCost} BTC)");
                    Console.WriteLine($"Rest (Rest at a nearby hotel for {RestCost} BTC)");
                    Console.WriteLine("Use (Use a consumable item)");
                    Console.WriteLine($"Area (Travel to a new area, you are currently in: {currentarea.name})");
                    Console.WriteLine("Info (Get information on various game mechanics)");
                    Console.WriteLine("Save (Save the game data with a number string)");
                    Console.WriteLine("Load (Load the game data with a saved number string)");
                    Console.WriteLine("(Enter with nothing to back out of any menu)\n");
                    Delay(700, devSleep);
                }
                
            //Shop
                else if (response == "Shop" || response == "1")
                {
                    Delay(500, devSleep);
                    Console.WriteLine($"\nWelcome to Traitor Joses' {name}, where we have all the general adventuring goods you could need!");
                    Console.WriteLine("Please select a shopping category from the options provided: \n");
                    Console.WriteLine("Weapons");
                    Console.WriteLine("Armor");
                    Console.WriteLine("Consumables");
                    Console.WriteLine("Spells");
                    Console.WriteLine("Misc\n");
                    string shopresponse = Console.ReadLine();
                    string shopm1 = $"\nHere's a list of the {shopresponse} we have for sale, what would you like to purchase? You have {BTC} Bitcoin.\n";
                    Delay(600, devSleep);
                    if (shopresponse == "Weapons")
                    {
                        Console.WriteLine(shopm1);
                        Console.WriteLine($"Wood Sword {Wwsword.desc} ({Wwsword.price} BTC)\nSpiked Club {Wsclub.desc} ({Wsclub.price} BTC)\nStone Dagger {Wsdagger.desc} ({Wsdagger.price} BTC)\n");
                        string shopresponsea1 = Console.ReadLine();
                        Delay(500, devSleep);
                        if (shopresponsea1 == "Wood Sword")
                        {
                            WepShop(Wwsword);
                        }
                        else if (shopresponsea1 == "Spiked Club")
                        {
                            WepShop(Wsclub);
                        }
                        else if (shopresponsea1 == "Stone Dagger")
                        {
                            WepShop(Wsdagger);
                        }
                        else
                        {
                            Console.WriteLine(invalid);
                        }
                    }
                    else if (shopresponse == "Armor")
                    {
                        Console.WriteLine(shopm1);
                        Console.WriteLine($"Padded Vest {Apvest.desc} ({Apvest.price} BTC)\nLeather Tunic {Altunic.desc} ({Altunic.price} BTC)\n");
                        string shopresponseb1 = Console.ReadLine();
                        Delay(500, devSleep);
                        if (shopresponseb1 == "Padded Vest")
                        {
                            ArmShop(Apvest);
                        }
                        else if (shopresponseb1 == "Leather Tunic")
                        {
                            ArmShop(Altunic);
                        }
                        else
                        {
                            Console.WriteLine(invalid);
                        }
                    }
                    else if (shopresponse == "Consumables")
                    {
                        Console.WriteLine(shopm1);
                        Console.WriteLine($"Health Potion {Chpot.desc} ({Chpot.price} BTC)\nMana Potion {Cmpot.desc} ({Cmpot.price} BTC)\n");
                        string shopresponsec1 = Console.ReadLine();
                        Delay(500, devSleep);
                        if (shopresponsec1 == "Health Potion")
                        {
                            ConShop(Chpot);
                        }
                        else if (shopresponsec1 == "Mana Potion")
                        {
                            ConShop(Cmpot);
                        }
                        else
                        {
                            Console.WriteLine(invalid);
                        }
                    }
                    else if (shopresponse == "Spells")
                    {
                        Console.WriteLine(shopm1);
                        Console.WriteLine($"Fireball {Sfireball.desc} ({Sfireball.price} BTC)\nHeal {Sheal.desc} ({Sheal.price} BTC)\n");
                        shopresponsed1 = Console.ReadLine();
                        string shopmd2 = $"Slot 1 ({spell1.name})\nSlot 2 ({spell2.name})\nSlot 3 ({spell3.name})\nSlot 4 ({spell4.name})";
                        Delay(500, devSleep);
                        if (shopresponsed1 == "Fireball")
                        {
                            SpellShop(Sfireball);
                        }
                        else if (shopresponsed1 == "Heal")
                        {
                            SpellShop(Sheal);
                        }
                        else
                        {
                            Console.WriteLine(invalid);
                        }
                    }
                    else if (shopresponse == "Misc")
                    {
                        Console.WriteLine(shopm1);
                        Console.WriteLine($"Throwing Knife {Mtknife.desc} ({Mtknife.price} BTC)\nSmoke Bomb {Msbomb.desc} ({Msbomb.price} BTC)\n");
                        string shopresponsec1 = Console.ReadLine();
                        Delay(500, devSleep);
                        if (shopresponsec1 == "Throwing Knife")
                        {
                            ConShop(Mtknife);
                        }
                        else if (shopresponsec1 == "Smoke Bomb")
                        {
                            ConShop(Msbomb);
                        }
                        else
                        {
                            Console.WriteLine(invalid);
                        }
                    }
                    else
                    {
                        Console.WriteLine(invalid);
                    }
                }

            //BTC
                else if (response == "BTC")
                {
                    Delay(500, devSleep);
                    Console.WriteLine($"\nYou have {BTC} Bitcoin.");
                }

            //Explore
                else if (response == "Explore")
                {
                    Delay(500, devSleep);
                    Console.WriteLine($"\nYou begin exploring in the {currentarea.name}...\n");
                    Delay(2500, devSleep);
                    int randomEncounter = RNG(1, 100);
                    if(randomEncounter <= currentarea.enemypct) { findEnemy(currentarea); }
                    else if(randomEncounter <= currentarea.lootpct) { findLoot(currentarea); }
                    else if(randomEncounter <= currentarea.eventpct) { findEvent(currentarea); }
                    else
                    {
                        //shouldnt be possible to occur
                        Console.WriteLine("Something has gone very wrong in the Explore ai");
                    }
                    Delay(1000, devSleep);
                }

            //Status
                else if (response == "Status")
                {
                    Delay(500, devSleep);
                    Console.WriteLine($"\nName: {name}");
                    Console.WriteLine($"Level: {lvl}");
                    Console.WriteLine($"XP: {XPdisp}");
                    Console.WriteLine($"Health: {HPdisp}");
                    Console.WriteLine($"Mana: {Manadisp}");
                    Console.WriteLine($"Stength: {STR}");
                    Console.WriteLine($"Dexterity: {DEX}");
                    Console.WriteLine($"Intelligence: {INT}");     
                    Console.WriteLine($"BTC: {BTC}");              
                }

            //Equipment
                else if (response == "Equipment")
                {
                    Delay(500, devSleep);
                    Console.WriteLine($"\nWeapon: {weapon.name} {weapon.desc}\nArmor: {armor.name} {armor.desc}\nSpell 1: {spell1.name} {spell1.desc}\nSpell 2: {spell2.name} {spell2.desc}\nSpell 3: {spell3.name} {spell3.desc}\nSpell 4: {spell4.name} {spell4.desc}\n");
                }

            //Inventory
                else if (response == "Inventory")
                {
                    Delay(500, devSleep);
                    Console.WriteLine($"\nList of Items:\n\nHealth Potions: {Chpot.val2}\nMana Potions: {Cmpot.val2}\nThrowing Knives: {Mtknife.val2}\nSmoke Bombs: {Msbomb.val2}\n");
                }

            //Heal
                else if (response == "Heal")
                {
                    Delay(500, devSleep);
                    Console.WriteLine($"\nAre you sure you want to heal? It will cost you {HealCost} BTC. \n Y/N ?\n");
                    string healresponse = Console.ReadLine();
                    Console.WriteLine("");
                    Delay(700, devSleep);
                    if (healresponse == "Y")
                    {

                        if (BTC >= HealCost)
                        {
                            Console.WriteLine($"You've been healed from {HP} to {HPmax} health! Your medical bills will be {HealCost} BTC...");
                            BTC = (BTC-HealCost);
                            HP = HPmax;
                        }
                        else
                        {
                            Console.WriteLine("You can't afford healthcare! Where do you think this is? Sweden?");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Sorry, we don't do plastic surgery.");
                    }
                }

            //Rest
                else if (response == "Rest")
                {
                    int RestAmount = HPmax/10;
                    Delay(500, devSleep);
                    Console.WriteLine($"\nAre you sure you want to rest to restore all your Mana and {RestAmount} HP? It will cost you {RestCost} BTC. \n Y/N ?\n");
                    string restresponse = Console.ReadLine();
                    Console.WriteLine("");
                    Delay(700, devSleep);
                    if (restresponse == "Y")
                    {

                        if (BTC >= RestCost)
                        {
                            HP = (HP + RestAmount);
                            Mana = Manamax;
                            Cap();
                            Console.WriteLine($"You rested for the night and restored to {Mana} Mana and {HP} HP. You paid the front desk {RestCost} for your stay.");
                            BTC = (BTC-RestCost);
                        }
                        else
                        {
                            Console.WriteLine("Sorry but you're too poor to sleep here... come back when you're a little bit... mmmmmm- richer...");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Only make a reservation if you're willing to pay next time!");
                    }
                }

            //Use
                else if (response == "Use")
                {
                    Delay(500, devSleep);
                    Console.WriteLine($"\nWhat consumable item would you like to use? You have:\n{Chpot.val2} Health Potion(s) {Chpot.desc}\n{Cmpot.val2} Mana Potion(s) {Cmpot.desc}\n");
                    useresponse = Console.ReadLine();
                    Delay(500, devSleep);
                    if (useresponse == "Health Potion")
                    {
                        UseShop(Chpot);
                        Cap();
                    }
                    else if (useresponse == "Mana Potion")
                    {
                        UseShop(Cmpot);
                        Cap();
                    }
                    else
                    {
                        Console.WriteLine(invalid);
                    }
                }

            //Area
                else if (response == "Area")
                {
                    Delay(800, devSleep);
                    Console.WriteLine($"\nYou are currently in Area {currentarea.rank}: {currentarea.name}\nWhat area would you like to travel to?\n");
                    Delay(500, devSleep);
                    Console.WriteLine($"Shady Meadow [Starting Area]\nDark Forest [Level {DarkForest.lvl}]\n");
                    string randomstring = Console.ReadLine();
                    Delay(800, devSleep);
                    Console.WriteLine(" ");
                    if (randomstring == "Shady Meadow")
                    {
                        Console.WriteLine("Traveling to Shady Meadow...");
                        Delay(3000, devSleep);
                        Console.WriteLine("You have arrived at Shady Meadow!");
                        currentarea = ShadyMeadow;
                    }
                    else if (randomstring == "Dark Forest")
                    {
                        Travel(DarkForest);
                    }
                    else if (randomstring == "Escape")
                    {
                        FightCommon(Father);
                    }
                    else { Console.WriteLine(invalid); }
                }

            //Save
                else if (response == "Save")
                {
                    Delay(500, devSleep);
                    save s = new save(BTC, lvl, Chpot.val2, Cmpot.val2, HP, XP, Mana, Manamax, HPmax, STR, DEX, INT, Mtknife.val2, Msbomb.val2);
                    Console.WriteLine("\nSaving...");
                    Delay(2000, devSleep);
                    Console.WriteLine("\nCopy the following number string and save it somewhere to be pasted in upon Loading:\n");
                    Console.WriteLine($"{s.BTC}{s.lvl}{s.Chpot}{s.Cmpot}{s.HP}{weapon.save}{armor.save}{spell1.save}{spell2.save}{spell3.save}{spell4.save}{s.XP}{s.Mana}{s.Manamax}{s.HPmax}{s.STR}{s.DEX}{s.INT}{s.Mtknife}{s.Msbomb}{currentarea.rank}{DarkForest.unlocked}111111111111111");
                }

            //Load
                else if (response == "Load")
                {
                    Delay(500, devSleep);
                    Console.WriteLine("\nPaste in a save string to load\n");
                    ls = Console.ReadLine();
                    Console.WriteLine("\nLoading...");
                    Delay(3000, devSleep);
                    BTC = (Convert.ToInt32(ls.Substring(0, 9))-100000000);
                    lvl = (Convert.ToInt32(ls.Substring(9, 3))-100);
                    Chpot.val2 = (Convert.ToInt32(ls.Substring(12, 3))-100);
                    Cmpot.val2 = (Convert.ToInt32(ls.Substring(15, 3))-100);
                    HP = (Convert.ToInt32(ls.Substring(18, 4))-1000);
                    if ((Convert.ToInt32(ls.Substring(22, 2))) == 10) { weapon = Wfist; }
                    if ((Convert.ToInt32(ls.Substring(22, 2))) == 11) { weapon = Wwsword; }
                    if ((Convert.ToInt32(ls.Substring(22, 2))) == 12) { weapon = Wsclub; }
                    if ((Convert.ToInt32(ls.Substring(22, 2))) == 13) { weapon = Wsdagger; }
                    if ((Convert.ToInt32(ls.Substring(24, 2))) == 10) { armor = Ashirt; }
                    if ((Convert.ToInt32(ls.Substring(24, 2))) == 11) { armor = Apvest; }
                    if ((Convert.ToInt32(ls.Substring(24, 2))) == 12) { armor = Altunic; }
                    spell1 = LoadSpell(spell1, 26);
                    spell2 = LoadSpell(spell2, 28);
                    spell3 = LoadSpell(spell3, 30);
                    spell4 = LoadSpell(spell4, 32);
                    XP = (Convert.ToInt32(ls.Substring(34, 5))-10000);
                    Mana = (Convert.ToInt32(ls.Substring(39, 4))-1000);
                    Manamax = (Convert.ToInt32(ls.Substring(43, 4))-1000);
                    HPmax = (Convert.ToInt32(ls.Substring(47, 4))-1000);
                    STR = (Convert.ToInt32(ls.Substring(51, 3))-100);
                    DEX = (Convert.ToInt32(ls.Substring(54, 3))-100);
                    INT = (Convert.ToInt32(ls.Substring(57, 3))-100);
                    Mtknife.val2 = (Convert.ToInt32(ls.Substring(60, 2))-10);
                    Msbomb.val2 = (Convert.ToInt32(ls.Substring(62, 2))-10);
                    if ((Convert.ToInt32(ls.Substring(64, 1))) == 1) { currentarea = ShadyMeadow; }
                    if ((Convert.ToInt32(ls.Substring(64, 1))) == 2) { currentarea = DarkForest; }
                    if ((Convert.ToInt32(ls.Substring(65, 1))) == 2) { DarkForest.unlocked = 2; }
                    Console.WriteLine("\nLoaded Successfully!");
                }

            //Info
                else if (response == "Info")
                {
                    Delay(500, devSleep);
                    Console.WriteLine($"\nWhat subject would you like to learn about?\nHealth\nMana\nBitcoin\nExperience\nLevel\nStrength\nDexterity\nIntelligence\nShop\nWeapons\nArmor\nSpells\nExplore\nAreas\nCombat\nEnemies\nCrits\nEvading\nFlee\nSaving\nCredits\n");
                    randomstring = Console.ReadLine();
                    Delay(1000, devSleep);
                    Console.WriteLine(" ");
                    if (randomstring == "Health") { Console.WriteLine($"You can check your Health (HP) in the 'Status' menu. You lose Health when in combat and are hit by the enemy, and to replenish your health you typically need to either use the 'Heal' command to\nheal to full at a fee that is based on your Level and how much health you have missing. You could also use the 'Rest' command, which will heal 10% of your max HP and all of your mana for a fee.\nYou could also heal with Health Potions via the 'Use' command or while in combat. If you reach 0 HP you will have to be rushed to the hospital."); }
                    else if (randomstring == "Mana") { Console.WriteLine($"You can check your Mana in the 'Status' menu. You use your Mana to cast magic Spells in combat (see 'Spells'). You can check the mana cost of any spell in it's description, and you will be unable to cast the spell if you don't have the required mana."); }
                    else if (randomstring == "Bitcoin") { Console.WriteLine($"Bitcoin (BTC) is the official currency of this land, and what you use to purchase items from the shop using the 'Shop' command. The primary way to get more Bitcoin is by using the 'Explore' command and looting it in the wild or from slain foes."); }
                    else if (randomstring == "Experience") { Console.WriteLine($"Experience (XP) is what you use to 'Level Up', you can check your Experience progress in the 'Status' menu, which will show you both your current XP as well as the amount of XP needed for your next level.\nThe amount of XP needed to level up increases with each level, and the primary way of gaining XP is via the 'Explore' command and slaying enemies for it."); }
                    else if (randomstring == "Level") { Console.WriteLine($"You can check your Level (lvl) in the 'Status' menu. Your level determines many things, it'll impact some prices, what areas you can go to, your stats, and sometimes your odds of success.\nIn order to increase your level you need to 'Level Up' with enough XP (see 'Experience'), which will then allow you to increase one of your stats, impacting your abilities in various ways."); }
                    else if (randomstring == "Strength") { Console.WriteLine($"You can check your Strength (STR) in the 'Status' menu. Strength is how strong you are, and will occaisionally impact what you can do. However, primarily what your Strength does is increase how much damage you do with a normal Attack (see 'Combat')."); }
                    else if (randomstring == "Dexterity") { Console.WriteLine($"You can check your Dexterity (DEX) in the 'Status' menu. Dexterity impacts many things, and generally improves your odds of success with various actions in combat (see 'Combat')\nIt'll increase the effectiveness of Miscellaneous items, your chance of successfully fleeing from combat (see 'Flee'), your chance of dodging enemies attacks (see 'Evading'), and your chance of landing Critical Hits on enemies (see 'Crits')."); }
                    else if (randomstring == "Intelligence") { Console.WriteLine($"You can check your Intelligence (INT) in the 'Status' menu. Intelligence primarily impacts your ability with Spells (see 'Spells'), increasing their effectiveness in various ways."); }
                    else if (randomstring == "Shop") { Console.WriteLine($"Traitor Joses' General Adventuring Goods Store can be accessed using the 'Shop' command. This is where you'll purchase most items using Bitcoin (see 'Bitcoin') such as Weapons, Armor, Spells, Consumables, and Miscellaneous items."); }
                    else if (randomstring == "Weapons") { Console.WriteLine($"You can check your Weapon in the 'Equipment' menu. Your Weapon affects your standard Attack in various ways (see 'Combat'), such as their base damage, crit damage (see 'Crits'), and accuracy (see 'Evading').\nDifferent weapons will be better in different fields, some may have high damage but a low chance of hitting, or higher crit damage but is below average in other ways.\nWhile weapons will tell you their base Damage in their description, for their other stats you may have to make an inference based off the type of weapon or clues in their description."); }
                    else if (randomstring == "Armor") { Console.WriteLine($"You can check your Armor in the 'Equipment' menu. Your Armor helps protect you in battle (see 'Combat') in a few ways. Primarily your armor will increase your Defense which can be seen in the armors description and decreases how much damage you take.\nHowever your armor also has an 'Evasion Score' (see 'Evading') which will decrease the odds of you getting hit by enemies moves in battle.\nSome armors may specialize in different areas, like having very high defense but low evasion score and visa versa. Generally heavier armor will have more defense but less evasion, and lighter armor will be the opposite."); }
                    else if (randomstring == "Spells") { Console.WriteLine($"You can check your Spells in the 'Equipment' menu. Spells require Mana (see 'Mana') to use, and can have various effects in combat which you can see in the spells description."); }
                    else if (randomstring == "Explore") { Console.WriteLine($"You can Explore using the 'Explore' command, and it is the primary activity in this land. Exploring can have a multitude of outcomes such as coming across an enemy (see 'Enemies'), finding random loot, or engaging in an interactive scenario.\nWhile the odds of you coming across these outcomes are randomized, the possibilities are based off of what Area you're in (see 'Areas'). Exploring can bring you great rewards, as well as great challenges..."); }
                    else if (randomstring == "Areas") { Console.WriteLine($"You can move to a new area using the 'Area' command. To unlock a new area, you must first meet the level requirement for that area, and then defeat the guardian of that area.\nThe point of moving to new areas is that each area has different possible outcomes from using the 'Explore' command (see 'Explore'), with higher loot and more dangerous encounters in higher level areas."); }
                    else if (randomstring == "Combat") { Console.WriteLine($"When using the 'Explore' command (see 'Explore'), you have a chance of coming across enemies (see 'Enemies'). Once you come across an enemy you will enter combat with them, which only ends when either you or the enemy is dead, or if you flee (see 'Flee').\nWhen in combat you and the enemy take turns using different abilities to try to win the combat, where whichever combatant gets the other to 0 HP first wins.\nWhen in combat you have a few options, being a standard 'Attack' with your weapon, casting a 'Spell' (see 'Spells'), using a 'Consumable' or 'Misc' item, or trying to 'Flee'. If you defeat the enemy in combat you will get some rewards in the form of XP and Bitcoin."); }
                    else if (randomstring == "Enemies") { Console.WriteLine($"When using the 'Explore' command (see 'Explore'), you have a chance of coming across 'Enemies'. You must then enter combat (see 'Combat') with said enemy until one of you dies or you successfully run away (see 'Flee').\nThe enemies you can come across are picked at random from a list of possibilities based on the Area that you're in (see 'Areas').\nSome enemies will be considered 'Common' enemies that always just perform a standard attack but with varying stats, while others will be considered 'Special' enemies that have a list of unique moves they may perform in combat."); }
                    else if (randomstring == "Crits") { Console.WriteLine($"When in combat with an enemy (see 'Combat'), one of your options is to perform a standard Attack with your Weapon (see 'Weapons'). These weapons will have different stats, one of which being the amount of damage you do with a 'Crit' (Critical Attack).\nEvery time you perform an Attack, you have a chance based off your DEX level to perform a Crit. If you do perform a Crit, instead of doing the weapons standard damage value it applies it's Crit damage value, usually for a lot more damage."); }
                    else if (randomstring == "Evading") { Console.WriteLine($"When in combat (see 'Combat'), when either side performs an attack on the other (including with Spells and Misc items) the defender has a chance to dodge the attack causing them to take no damage (or just partial damage in some cases).\nYour chance of dodging an attack is based off of 3 things, your Armors 'Evasion Score' (see 'Armor'), the enemies weapons 'Accuracy' (see 'Weapons'), and your DEX (see 'Dexterity'), or for the enemy just your weapons accuracy and their evasion score."); }
                    else if (randomstring == "Flee") { Console.WriteLine($"When in combat (see 'Combat'), you can attempt to 'Flee' to try to escape from combat. If you do successfully flee from combat, you aren't penalized but you forfeit any potential loot the enemy may have dropped.\nYour chance of successfully fleeing is based off of your DEX, which increases your chance, and your level, which decreases it the higher level you are. This means if you want a higher chance of Fleeing you want to keep a good balance of DEX when you level up."); }
                    else if (randomstring == "Saving") { Console.WriteLine($"You can save your progress by using the 'Save' command, which will print out a long number string that you must copy and save somewhere to be used later. When you want to load your save use the 'Load' command and paste in the save string."); }
                    else if (randomstring == "Credits") { Console.WriteLine($"This small game was made by Owen Dellasega as a fun project to practice learning C# with, as well as helped by Alexander Marsh with some of the designs and portions of code."); }
                    else { Console.WriteLine(invalid); }
                    Delay(5000, devSleep);
                }

            //devcmds
                else if (response == "devcmds")
                {
                    Console.WriteLine("\nAvailable developer commands:\n");
                    Console.WriteLine("setlvl <int>\nsetXP <int>\nsetBTC <int>\nsetHP <int>\nsetHPmax <int>\nsetmana <int>\nsetmanamax <int>\nwin 1\n");
                    string devresponse = Console.ReadLine();
                    string devresponse2a = Console.ReadLine();
                    int devresponse2 = Convert.ToInt32(devresponse2a);
                    if (devresponse == "setlvl")
                    {
                        lvl = devresponse2;
                    }
                    else if (devresponse == "setXP")
                    {
                        XP = devresponse2;
                    }
                    else if (devresponse == "setBTC")
                    {
                        BTC = devresponse2;
                    }
                    else if (devresponse == "setHP")
                    {
                        HP = devresponse2;
                    }
                    else if (devresponse == "setHPmax")
                    {
                        HPmax = devresponse2;
                    }
                    else if (devresponse == "setmana")
                    {
                        Mana = devresponse2;
                    }
                    else if (devresponse == "setmanamax")
                    {
                        Manamax = devresponse2;
                    }
                    else if (devresponse == "win")
                    {
                        Victory = true;
                    }
                    else
                    {
                        Console.WriteLine(invalid);
                    }
                }
                else
                {
                    Delay(300, devSleep);
                    Console.WriteLine(invalid);
                }
            }
        //Game End
            Delay(3000, devSleep);
            Console.WriteLine("\nThe end.\n");
            Delay(2000, devSleep);

        }

    //RNG generator method (RNG{<min number>, <max number>})
        private static readonly Random _random = new Random();  
        public static int RNG(int min, int max)  
        {  
            return _random.Next(min, max);  
        } 
    //To pause use: System.Threading.Thread.Sleep(); (in milliseconds)
    //Delay(T, devSleep)
        static void Delay(int time, bool devSleep)
        {
            if(!devSleep)
            {
                System.Threading.Thread.Sleep(time);
            }
        }
    //Spell shop message
        static void shopmd1(string item, int price)
        {
            Console.WriteLine($"\nYou purchased {item} for {price} BTC. Please choose what slot to put it in. (will replace whatever is currently there)");
        }
    //Spell shop method
        static void SpellShop(shop shopSpell)
        {
            string shopmd2 = $"Slot 1 ({spell1.name})\nSlot 2 ({spell2.name})\nSlot 3 ({spell3.name})\nSlot 4 ({spell4.name})\n";

            if (BTC >= shopSpell.price)
                {
                    shopmd1(shopSpell.name, shopSpell.price);
                    Console.WriteLine(shopmd2);
                    string shopresponsed2 = Console.ReadLine();
                    Delay(500, devSleep);

                    if (shopresponsed2 == "Slot 1")
                        {
                            Console.WriteLine($"\nYou sold your {spell1.name} for {spell1.price/2} BTC and replaced it with {shopSpell.name}");
                            BTC = (BTC-(shopSpell.price - (spell1.price / 2)));
                            spell1 = shopSpell;
                        }
                    else if (shopresponsed2 == "Slot 2")
                        {
                            Console.WriteLine($"\nYou sold your {spell2.name} for {spell2.price/2} BTC and replaced it with {shopSpell.name}");
                            BTC = (BTC-(shopSpell.price - (spell2.price / 2)));
                            spell2 = shopSpell;
                        }
                    else if (shopresponsed2 == "Slot 3")
                        {
                            Console.WriteLine($"\nYou sold your {spell3.name} for {spell3.price/2} BTC and replaced it with {shopSpell.name}");
                            BTC = (BTC-(shopSpell.price - (spell3.price / 2)));
                            spell3 = shopSpell;
                        }
                    else if (shopresponsed2 == "Slot 4")
                        {
                            Console.WriteLine($"\nYou sold your {spell4.name} for {spell4.price/2} BTC and replaced it with {shopSpell.name}");
                            BTC = (BTC-(shopSpell.price - (spell4.price / 2)));
                            spell4 = shopSpell;
                        }
                    else
                        {

                        }
                }
            else
                {
                    Console.WriteLine("\nYou can't afford that item!");
                }
        }
    //Weapon shop method
        static void WepShop(shop shopWep)
        {
            if (BTC >= shopWep.price)
                {
                    Console.WriteLine($"\nYou purchased {shopWep.name} for {shopWep.price} BTC and sold your old {weapon.name} for {weapon.price/2} BTC");
                    BTC = (BTC-(shopWep.price - (weapon.price / 2)));
                    weapon = shopWep;
                }
            else
                {
                    Console.WriteLine("\nYou can't afford that item!");
                }
        }
    //Armor shop method
        static void ArmShop(shop shopArm)
        {
            if (BTC >= shopArm.price)
                {
                    Console.WriteLine($"\nYou purchased {shopArm.name} for {shopArm.price} BTC and sold your old {armor.name} for {armor.price/2} BTC");
                    BTC = (BTC-(shopArm.price - (armor.price / 2)));
                    armor = shopArm;
                }
            else
                {
                    Console.WriteLine("\nYou can't afford that item!");
                }
        }

    //Consumable shop method
        static void ConShop(shop shopCon)
        {
            Console.WriteLine($"\nHow many {shopCon.name}s would you like to buy?\n");
            string shopresponsec2a = Console.ReadLine();
            Delay(500, devSleep);
            int shopresponsec2;
            bool success = int.TryParse(shopresponsec2a, out shopresponsec2);
            if (success)
            { 
                if (BTC >= (shopCon.price * shopresponsec2))
                {
                    if (shopresponsec2 == 1)
                    {
                        Console.WriteLine($"\nYou purchased a {shopCon.name} for {shopCon.price} BTC.");
                        BTC-=(shopCon.price);
                        shopCon.val2++;
                    }   
                    else if (shopresponsec2 >= 2)
                    {
                        Console.WriteLine($"\nYou purchased {shopresponsec2} {shopCon.name}s for {shopCon.price * shopresponsec2} BTC.");
                        BTC-=(shopCon.price * shopresponsec2);
                        shopCon.val2+=shopresponsec2;
                    }
                    else
                    {
                        Console.WriteLine("\nInvalid response, make sure your response is a whole number.");
                    }
                }
                else
                {
                    Console.WriteLine("\nYou can't afford that item!");
                }
            }
            else
            {
            Console.WriteLine("\nThats not an integer!!!");
            }
            
        }
    
    //Use consumable method
        static void UseShop(shop ShopUsing)
        {
            if (ShopUsing.val2 >= 1)
            {
                if (useresponse == "Health Potion")
                {
                    Console.WriteLine($"\nYou drank a Health Potion and restored {Chpot.val} Health");
                    HP+=Chpot.val;
                    Chpot.val2--;
                    Cap();
                }
                else if (useresponse == "Mana Potion")
                {
                    Console.WriteLine($"\nYou drank a Mana Potion and restored {Cmpot.val} Mana");
                    Mana+=Cmpot.val;
                    Cmpot.val2--;
                    Cap();
                }
                else
                {
                    Console.WriteLine("\nSomething went wrong with the Use consumable method");
                }
                turn = "Enemy";
            }
            else
            {
                Console.WriteLine($"\nYou don't have any {ShopUsing.name}s!");
            }
        }

    //Cap method to ensure Health & Mana don't go above limit
        static void Cap()
        {
            if (HP > HPmax && Mana > Manamax)
            {
                HP = HPmax;
                Mana = Manamax;
            }
            else if (HP > HPmax)
            {
                HP = HPmax;
            }
            else if (Mana > Manamax)
            {
                Mana = Manamax;
            }
            if (Chpot.val2 > 899) { Chpot.val2 = 899; }
            if (Cmpot.val2 > 899) { Cmpot.val2 = 899; }
            if (Mtknife.val2 > 89) { Mtknife.val2 = 89; }
            if (Msbomb.val2 > 89) { Msbomb.val2 = 89; }
        }
    
    //Load spell slot method
        static shop LoadSpell(shop LoadSlot, int StartChar)
        {
            
            if ((Convert.ToInt32(ls.Substring(StartChar, 2))) == 10) { LoadSlot = Sempty; }
            if ((Convert.ToInt32(ls.Substring(StartChar, 2))) == 11) { LoadSlot = Sfireball; }
            if ((Convert.ToInt32(ls.Substring(StartChar, 2))) == 12) { LoadSlot = Sheal; }
            return LoadSlot;
        } 
    //Explore Find Enemy Method
        static void findEnemy(area Area)
        {
            int randomEnemy = RNG(1, 100);
            if (Area == ShadyMeadow)
            {
                if (randomEnemy <= 60) { FightCommon(Slime); }
                else if (randomEnemy <= 85) { FightCommon(Zombie); }
                else if (randomEnemy <= 100) { FightCommon(SkeletonArcher); }
            }
            else if (Area == DarkForest)
            {
                if (randomEnemy <= 70) { FightCommon(SkeletonArcher); }
                else if (randomEnemy <= 100) { FightCommon(SkeletonWarrior); }
            }
            else { Console.WriteLine("Something has gone horribly wrong with the area selection... try moving to a new area."); }
        }
    //Explore Find Loot Method
        static void findLoot(area Area)
        {
            int randomLoot = RNG(1, 100);
            if (randomLoot <= 40)
            {
                Console.WriteLine("You happened to find a Health Potion by the side of the road.");
                Chpot.val2++;
            }
            else if (randomLoot <= 80)
            {
                Console.WriteLine("You happened to find a Mana Potion by the side of the road.");
                Cmpot.val2++;
            }
            else if (randomLoot <= 100)
            {
                randomint = RNG(10, 35);
                Console.WriteLine($"You found a coin purse on your travels with {randomint} BTC in it.");
                BTC+=randomint;
            }
        }
    //Explore Find Event Method
        static void findEvent(area Area)
        {
            int randomEvent = RNG(1, 100);
            if (randomEvent <= 40)
            {
                Console.WriteLine("You stumble into a small clearing, with a mysterious fountain at the center.\nWould you like to take a drink from the fountain? Y/N ?\n");
                eventresponse = Console.ReadLine();
                Delay(500, devSleep);
                if (eventresponse == "Y")
                {
                    Console.WriteLine("\nYou take a long drink from the fountain, it tastes very refreshing...");
                    Delay(2000, devSleep);
                    Console.WriteLine($"The fountains magical restorative powers healed you for {HPmax/2} HP and fully replenished your mana!");
                    HP = (HP+(HPmax/2));
                    Mana = Manamax;
                }
                else { Console.WriteLine("You refuse to trust the contents of some random fountain... it's crystal clear water does look so tantalizing though..."); }
            }
            else if (randomEvent <= 55)
            {
                Console.WriteLine("You stumble into a small clearing, with a mysterious fountain at the center.\nWould you like to take a drink from the fountain? Y/N ?\n");
                eventresponse = Console.ReadLine();
                Delay(500, devSleep);
                if (eventresponse == "Y")
                {
                    Console.WriteLine("\nYou take a long drink from the fountain, it tastes fascinating...");
                    Delay(2000, devSleep);
                    Console.WriteLine($"The fountains waters have granted you great insight, you gained 50 XP.");
                    XP+=50;
                }
                else { Console.WriteLine("You refuse to trust the contents of some random fountain... you do wonder what secrets it holds though..."); }
            }
            else if (randomEvent <= 70)
            {
                Console.WriteLine("You stumble into a small clearing, with a mysterious fountain at the center.\nWould you like to take a drink from the fountain? Y/N ?\n");
                eventresponse = Console.ReadLine();
                Delay(500, devSleep);
                if (eventresponse == "Y")
                {
                    Console.WriteLine("\nYou take a long drink from the fountain, it tastes a little stale...");
                    Delay(2000, devSleep);
                    Console.WriteLine($"The fountains waters were poisonous! You lost {HP/2} HP!");
                    HP = (HP-(HP/2));
                }
                else { Console.WriteLine("You refuse to trust the contents of some random fountain... it might've been for the best..."); }
            }
            else if (randomEvent <= 100)
            {
                Console.WriteLine("You find a half-buried chest and attempt to pry it open...");
                Delay(2000, devSleep);
                if (STR >= RNG(2, 6))
                {
                    randomint = RNG(1, 100);
                    if (randomint <= 50)
                    {
                        randomint = RNG(40, 70);
                        randomint2 = RNG(1, 4);
                        randomint3 = RNG(1, 3);
                        Console.WriteLine($"You manage to bust the lid open and find {randomint} BTC, {randomint2} Health Potions, and {randomint3} Mana Potions!");
                        BTC+=randomint;
                        Chpot.val2+=randomint2;
                        Cmpot.val2+=randomint3;
                    }
                    else if (randomint <= 70)
                    {
                        randomint = RNG(60, 150);
                        Console.WriteLine($"You manage to bust the lid open and find the chest filled to the brim with Bitcoin! You scoop it all up and profit {randomint} BTC.");
                        BTC+=randomint;
                    }
                    else if (randomint <= 95)
                    {
                        CombatWin=false;
                        Console.WriteLine("Just as you pop the lid open you hear a strange groan... You step back in fright as the chest opens on it's own revealing two sets of jagged teeth inside! It's a Mimic!");
                        Delay(2500, devSleep);
                        FightCommon(Mimic);
                    }
                    else
                    {
                        Console.WriteLine("You manage to bust the chests' lid open excited to see what's inside... but as you open it farther you're distraught to see it's completely empty.");
                    }
                }
                else { Console.WriteLine("\nYou try with all your might but you aren't strong enough to get it open..."); }
            }
            else { Console.WriteLine("Something has gone very wrong with the Event ai"); }
        }

    //FightCommon method (common enemy)
        static void FightCommon(enemyA Enemy)
        {
            Console.WriteLine($"{Enemy.intro}\n");
            Delay(2000, devSleep);
            Enemy.health = Enemy.maxhealth;
            Enemy.defense = Enemy.basedefense;
            Enemy.damage = Enemy.basedamage;
            Enemy.evasion = Enemy.baseevasion;
            statusl1 = 0;
            statusl2 = 0;
            statusl3 = 0;
            turn = "Player";
            fled = false;
            CombatWin = false;
            while (HP > 0 && Enemy.health > 0 && fled == false)
            {   
                Cap();
                Delay(1500, devSleep);
                if (turn == "Player")
                {
                    fightmessage1();
                    if (fightaction == "Attack")
                    {
                        Delay(500, devSleep);
                        Attack(Enemy);
                        turn = "Enemy";
                    }
                    else if (fightaction == "Spell")
                    {
                        Delay(500, devSleep);
                        Console.WriteLine($"\nWhat spell would you like to cast? You have:\n{spell1.name} {spell1.desc}\n{spell2.name} {spell2.desc}\n{spell3.name} {spell3.desc}\n{spell4.name} {spell4.desc}\n");
                        useresponse = Console.ReadLine();
                        Delay(500, devSleep);
                        if (useresponse == "Fireball")
                        {
                            Cast(Fireball, Enemy);
                        }  
                        else if (useresponse == "Heal")
                        {
                            Cast(Heal, Enemy);
                        }  
                        else { Console.WriteLine(invalid); }
                    }
                    else if (fightaction == "Flee")
                    {
                        Delay(500, devSleep);
                        Flee();
                        turn = "Enemy";
                    }
                    else if (fightaction == "Consumable")
                    {
                        Delay(500, devSleep);
                        Console.WriteLine($"\nWhat consumable item would you like to use? You have:\n{Chpot.val2} Health Potion(s) {Chpot.desc}\n{Cmpot.val2} Mana Potion(s) {Cmpot.desc}\n");
                        useresponse = Console.ReadLine();
                        Delay(500, devSleep);
                        if (useresponse == "Health Potion")
                        {
                            UseShop(Chpot);
                            Cap();
                        }
                        else if (useresponse == "Mana Potion")
                        {
                            UseShop(Cmpot);
                            Cap();
                        }
                        else
                        {
                            Console.WriteLine(invalid);
                        }
                    }
                    else if (fightaction == "Misc")
                    {
                        Delay(500, devSleep);
                        Console.WriteLine($"\nWhat miscellaneous item would you like to use? You have:\n{Mtknife.val2} Throwing Knife(s) {Mtknife.desc}\n{Msbomb.val2} Smoke Bomb(s) {Msbomb.desc}\n");
                        useresponse = Console.ReadLine();
                        Delay(500, devSleep);
                        if (useresponse == "Throwing Knife")
                        {
                            UseMisc(Mtknife, Enemy);
                            Cap();
                        }
                        else if (useresponse == "Smoke Bomb")
                        {
                            UseMisc(Msbomb, Enemy);
                            Cap();
                        }
                        else
                        {
                            Console.WriteLine(invalid);
                        }
                    }
                    else
                    {
                        Console.WriteLine(invalid);
                    }
                }
                else if (turn == "Enemy")
                {
                    enemyAattack(Enemy);
                    turn = "Player";
                }
                else 
                { 
                Console.WriteLine("Something went wrong with the combat turn function..."); 
                turn = "Player";
                }
            }
            Delay(1500, devSleep);
            if (HP <= 0) { Console.WriteLine($"\nYou were defeated in battle by the {Enemy.name}..."); }
            else if (Enemy.health <= 0)
            {
                Console.WriteLine($"\nYou defeated the {Enemy.name}!");
                Delay(1000, devSleep);
                randomint = RNG(Convert.ToInt32(Enemy.btc-(Enemy.btc/5)), Convert.ToInt32(Enemy.btc+(Enemy.btc/5)));
                randomint2 = RNG(Convert.ToInt32(Enemy.xp-(Enemy.xp/5)), Convert.ToInt32(Enemy.xp+(Enemy.xp/5)));
                Console.WriteLine($"You earned {randomint} BTC and {randomint2} XP!");
                BTC+=randomint;
                XP+=randomint2;
                CombatWin=true;
            }
            else if (fled == true) 
            { 
            Console.WriteLine("\nYou got away successfully."); 
            fled = false;
            }
            else { Console.WriteLine("Something went wrong with Fight Common Enemy sequence..."); }
        }
    //Fight Actions Message
        static void fightmessage1()
        {
            HPdisp = $"{HP} / {HPmax}";
            Manadisp = $"{Mana} / {Manamax}";
            Console.WriteLine($"\nYou have {HPdisp} Health and {Manadisp} Mana. What action would you like to perform?\nAttack (Attack the enemy with your {weapon.name})\nSpell (Cast one of your spells)\nConsumable (Use a consumable item)\nMisc (Use a miscellaneous item)\nFlee (Attempt to run away)\n");
            fightaction = Console.ReadLine();
            Delay(500, devSleep);
        }
    //Combat Action Attack on Common Enemy
        static void Attack(enemyA target)
        {
            randomint = RNG(1, 100);
            if (randomint >= (50-weapon.val3) || randomint >= (target.evasion-weapon.val3))
            {
                randomint = RNG(1, 100);
                if (randomint <= (10+(2*DEX)))
                {
                    randomint2 = Convert.ToInt32(weapon.val2+(weapon.val2*(STR*0.1)));
                    randomint3=(randomint2-target.defense);
                    if (randomint3 <= 0) { randomint3 = 1; }
                    target.health-=randomint3;
                    Console.WriteLine($"\nYou performed a critical hit on the {target.name} dealing {randomint3} damage! They have {target.health} HP remaining!\n");
                }
                else
                {
                    randomint2 = Convert.ToInt32(weapon.val+(weapon.val*(STR*0.1)));
                    randomint3=(randomint2-target.defense);
                    if (randomint3 <= 0) { randomint3 = 1; }
                    target.health-=randomint3;
                    Console.WriteLine($"\nYou hit the {target.name} dealing {randomint3} damage! They have {target.health} HP remaining!\n");
                }
            }
            else { Console.WriteLine($"\nYour attack missed!\n"); }
        }
    //Combat Action Flee
        static void Flee()
        {
            Console.WriteLine("\nYou attempt to run away from the battle...");
            randomint = RNG(1, 100);
            if (randomint <= (30+((5*DEX)-lvl))) { fled = true; }
            else 
            {  
                Delay(1500, devSleep);
                Console.WriteLine("\nYou try to outmaneuver your enemy and slip away but they're too swift!");
            }
        }
    //Combat enemyAattack (Common enemy attack action)
        static void enemyAattack(enemyA attacker)
        {
            if (attacker == Mimic) { MimicAttack(Mimic); }
            else if (attacker == ForestShade) { FShadeAttack(ForestShade); }
            else
            {
                randomint = RNG(1, 100);
                if (randomint >= (50-attacker.accuracy) || randomint >= Convert.ToInt32((armor.val2+(armor.val2*DEX/2))-attacker.accuracy))
                {
                    randomint = RNG(Convert.ToInt32(attacker.damage-(attacker.damage/4)), Convert.ToInt32(attacker.damage+(attacker.damage/4)));
                    randomint2 = (randomint-armor.val);
                    if (randomint2 <= 0) { randomint2 = 1; }
                    HP-=randomint2;
                    Console.WriteLine($"\nThe {attacker.name} hit you dealing {randomint2} damage!\n");
                }
                else { Console.WriteLine($"\nThe {attacker.name}'s attack missed!\n"); }
            }
        }
    //Use Misc on common enemy method
        static void UseMisc(shop MiscUsing, enemyA target)
        {
            if (MiscUsing.val2 >= 1)
            {
                if (useresponse == "Throwing Knife")
                {
                    randomint = RNG(1, 100);
                    if (randomint <= (Mtknife.val3-(target.evasion*2)))
                    {
                        randomint = (Mtknife.val+(Mtknife.val*DEX));
                        randomint2 = (randomint-target.defense);
                        if (randomint2 <= 0) { randomint2 = 1; }
                        target.health-=randomint2;
                        Console.WriteLine($"\nYou hit the {target.name} dealing {randomint2} damage! They have {target.health} HP remaining!\n");
                    }
                    else { Console.WriteLine($"\nYour throwing knife flew past the {target.name}, leaving them untouched...\n"); }
                    Mtknife.val2--;
                }
                else if (useresponse == "Smoke Bomb")
                {
                    Console.WriteLine($"\nYou throw down the smoke bomb obscuring yourself while you run away from the {target.name}.\n");
                    fled = true;
                    Msbomb.val2--;
                }
                else
                {
                    Console.WriteLine("\nSomething went wrong with the Use Miscellaneous method");
                }
                turn = "Enemy";
            }
            else
            {
                Console.WriteLine($"\nYou don't have any {MiscUsing.name}s!");
            }
        }

    //Mimic Moves
        static void MimicAttack(enemyA attacker)
        {
            attacker.defense = attacker.basedefense;
            randomint = RNG(1, 100);
            if (randomint <= 50)
            {
                randomint = RNG(1, 100);
                if (randomint >= (50-attacker.accuracy) || randomint >= Convert.ToInt32((armor.val2+(armor.val2*DEX/2))-attacker.accuracy))
                {
                    randomint = RNG(Convert.ToInt32(attacker.damage-(attacker.damage/4)), Convert.ToInt32(attacker.damage+(attacker.damage/4)));
                    randomint2 = (randomint-armor.val);
                    if (randomint2 <= 0) { randomint2 = 1; }
                    HP-=randomint2;
                    Console.WriteLine($"\nThe {attacker.name} lunged at you and took a bite out of you dealing {randomint2} damage!\n");
                }
                else { Console.WriteLine($"\nThe {attacker.name} jumped at you mouth agape but you jumped to the side dodging it!\n"); }
            }
            else if (randomint <= 80)
            {
                Console.WriteLine($"\n{LidBash.desc}");
                Delay(1500, devSleep);
                attacker.defense+=LidBash.val;
                randomint = RNG(1, 100);
                if (randomint >= (50-LidBash.accuracy) || randomint >= Convert.ToInt32((armor.val2+(armor.val2*DEX/2))-LidBash.accuracy))
                {
                    randomint = RNG(Convert.ToInt32(LidBash.damage-(LidBash.damage/4)), Convert.ToInt32(LidBash.damage+(LidBash.damage/4)));
                    randomint2 = (randomint-armor.val);
                    if (randomint2 <= 0) { randomint2 = 1; }
                    HP-=randomint2;
                    Console.WriteLine($"The Mimic bashes into you dealing {randomint2} damage!\n");
                }
                else { Console.WriteLine($"You rolled out of the way of the flying Mimic just before it hit you!\n"); }
            }
            else if (randomint <= 100)
            {
                Console.WriteLine($"\n{MimicChomp.desc}");
                Delay(1500, devSleep);
                randomint = RNG(1, 100);
                if (randomint >= (50-MimicChomp.accuracy) || randomint >= Convert.ToInt32((armor.val2+(armor.val2*DEX/2))-MimicChomp.accuracy))
                {
                    HP-=MimicChomp.damage;
                    Console.WriteLine($"The Mimic lands directly on your head and chomps down dealing {MimicChomp.damage} damage!\n");
                }
                else 
                { 
                    Console.WriteLine($"You strafed to the side as the Mimic hits the ground taking {MimicChomp.val} damage!\n"); 
                    attacker.health-=MimicChomp.val;
                }
            }
        }

    //Forest Shade Moves
        static void FShadeAttack(enemyA attacker)
        {
            attacker.evasion = attacker.baseevasion;
            attacker.damage = attacker.basedamage;
            if (statusl1 > 0)
            {
                Console.WriteLine($"\nThe {attacker.name} has {statusl1} turns left of increased Evasion...");
                attacker.evasion+=Evasive.damage;
                statusl1--;
                Delay(500, devSleep);
            }
            if (statusl2 > 0)
            {
                Console.WriteLine($"\nThe {attacker.name} has {statusl2} turns left of increased Damage...");
                attacker.damage+=BuffDMG.damage;
                statusl2--;
                Delay(500, devSleep);
            }
            randomint = RNG(1, 100);
            if (randomint <= 50)
            {
                randomint = RNG(1, 50);
                if (randomint >= (50-attacker.accuracy) || randomint >= Convert.ToInt32((armor.val2+(armor.val2*DEX/2))-attacker.accuracy))
                {
                    randomint = RNG(Convert.ToInt32(attacker.damage-(attacker.damage/4)), Convert.ToInt32(attacker.damage+(attacker.damage/4)));
                    randomint2 = (randomint-armor.val);
                    if (randomint2 <= 0) { randomint2 = 1; }
                    HP-=randomint2;
                    Console.WriteLine($"\nThe {attacker.name} slashed you with a blade of pure darkness dealing {randomint2} damage!\n");
                }
                else { Console.WriteLine($"\nThe {attacker.name} swiped at you with a blade of pure darkness but you dodged out of the way!\n"); }
            }
            else if (randomint <= 75)
            {
                Console.WriteLine($"\nThe {attacker.name} cast an orb of shadow at you!");
                Delay(1000, devSleep);
                randomint = RNG(1, 100);
                if (randomint >= (50-ShadowOrb.accuracy) || randomint >= Convert.ToInt32((armor.val2+(armor.val2*DEX/2))-ShadowOrb.accuracy))
                {
                    HP-=ShadowOrb.damage;
                    Console.WriteLine($"The Shadow Orb hit you head on dealing {ShadowOrb.damage} damage!\n");
                }
                else 
                { 
                    randomint = RNG(Convert.ToInt32(ShadowOrb.val-(ShadowOrb.val/4)), Convert.ToInt32(ShadowOrb.val+(ShadowOrb.val/4)));
                    randomint2 = (randomint-armor.val);
                    if (randomint2 <= 0) { randomint2 = 1; }
                    HP-=randomint2;
                    Console.WriteLine($"\nYou skirted to the side causing the Shadow Orb to nick you for only {randomint2} damage!\n"); 
                }
            }
            else if (randomint <= 85)
            {
                Console.WriteLine($"The {attacker.name} vibrated for a few seconds and then became more ethereal... it's Evasion has been greatly increased for {Evasive.val} turns!");
                attacker.evasion+=Evasive.damage;
                statusl1 = (Evasive.val-1);
            }
            else if (randomint <= 100)
            {
                Console.WriteLine($"The {attacker.name} congealed and turned purple... it's Base Damage has been increased for {BuffDMG.val} turns!");
                attacker.damage+=BuffDMG.damage;
                statusl2 = (BuffDMG.val-1);
            }
        }
    //Combat Action Cast
        static void Cast(move Spell, enemyA target)
        {
            if (spell1.name == Spell.name || spell2.name == Spell.name || spell3.name == Spell.name || spell4.name == Spell.name)
            {
                if (Mana >= Spell.val)
                {
                    if (Spell == Fireball)
                    {
                        Console.WriteLine($"\n{Spell.desc}");
                        Mana-=Spell.val;
                        randomint = RNG(1, 100);
                        if (randomint >= (50-Spell.accuracy) || randomint >= (target.evasion-Spell.accuracy))
                        {
                            randomint = Convert.ToInt32(Spell.damage+(Spell.damage*INT*0.2));
                            randomint2 = (randomint-target.defense);
                            target.health-=randomint2;
                            Delay(1000, devSleep);
                            Console.WriteLine($"Your {Spell.name} hit the {target.name} dealing {randomint2} damage! They have {target.health} HP remaining!");
                        }
                        else { Console.WriteLine($"Your {Spell.name} flew past the {target.name} leaving it unscathed."); }
                    }
                    else if (Spell == Heal)
                    {
                        randomint = Convert.ToInt32(Spell.damage+(Spell.damage*INT*0.2));
                        HP+=randomint;
                        Mana-=Spell.val;
                        Cap();
                        Console.WriteLine($"\nYou cast {Spell.name} and healed {randomint} HP!");
                    }
                    else { Console.WriteLine("Something has gone horribly wrong with the cast spell method"); }
                    turn = "Enemy";
                }
                else { Console.WriteLine("\nYou don't have enough mana to cast that spell!"); }
            }
            else { Console.WriteLine("\nYou don't have that spell!"); }
        }
    //Area Traveling
        static void Travel(area Area)
        {
            if (lvl >= Area.lvl)
            {
                if (Area.unlocked == 2)
                {
                    Console.WriteLine($"Traveling to {Area.name}...");
                    Delay(3000, devSleep);
                    Console.WriteLine($"You have arrived at {Area.name}!");
                    currentarea = Area;
                }
                else
                {
                    Console.WriteLine($"To unlock the {Area.name} you must defeat the {Area.name}'s guardian, are you sure you want to continue? Y/N ?\n");
                    randomstring = Console.ReadLine();
                    Delay(750, devSleep);
                    if (randomstring == "Y")
                    {
                        Console.WriteLine($"\nYou press onwards, confident in your abilities...");
                        Delay(2500, devSleep);
                        FightCommon(Area.boss);
                        if (CombatWin == true)
                        {
                            Delay(2000, devSleep);
                            Console.WriteLine($"After defeating the {Area.boss.name}, you collect yourself and continue onwards into the {Area.name} undeterred...");
                            Area.unlocked = 2;
                            currentarea = Area;
                            Delay(2500, devSleep);
                            Console.WriteLine($"You unlocked {Area.name}!");
                        }
                    }
                    else { Console.WriteLine("\nYou turn back the way you came, afraid of what lies ahead..."); }
                }
            }
            else { Console.WriteLine($"You aren't a high enough level to travel to the {Area.name}! You must be level {Area.lvl}!"); }
        }
    }
}