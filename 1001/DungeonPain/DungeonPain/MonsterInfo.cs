namespace DungeonPain;

// Szörnyekkel kapcsolatos "segédfüggvények": mindegyik a szörny fajtája szerint ágazik el.
static class MonsterInfo
{
    // A szörny jele a naplóban.
    public static char GetSymbol(Monster m)
    {
        switch (m.Type)
        {
            case MonsterType.Goblin: return 'g';
            case MonsterType.Orc: return 'O';
            case MonsterType.Skeleton: return 's';
            case MonsterType.Slime: return '~';
            case MonsterType.Dragon: return 'D';
            case MonsterType.Troll: return 'T';
            case MonsterType.Bat: return 'b';
            case MonsterType.Spider: return 'S';
            case MonsterType.Wyvern: return 'W';
            default: return '?';
        }
    }

    // Rövid leírás a szörnyről.
    public static string Describe(Monster m)
    {
        switch (m.Type)
        {
            case MonsterType.Goblin:
                return "A sneaky goblin. Steals gold when it hits.";
            case MonsterType.Orc:
                return "A brutal orc. Gets enraged when badly hurt.";
            case MonsterType.Skeleton:
                return "A rattling skeleton. Its bones shatter under blunt weapons.";
            case MonsterType.Slime:
                return "A gooey slime. Its acid corrodes armor.";
            case MonsterType.Dragon:
                return "An ancient dragon. Breathes fire every third turn.";
            case MonsterType.Troll:
                return "An ugly troll. Hits the player.";
            case MonsterType.Bat:
                return "A fluttering bat. Hard to hit in melee.";
            case MonsterType.Spider:
                return "A venomous spider. Its bite poisons.";
            case MonsterType.Wyvern:
                return "A flying wyvern with a poisonous sting.";
            default:
                return "";
        }
    }

    // Mennyi tapasztalati pontot ér a szörny legyőzése.
    public static int GetXp(Monster m)
    {
        switch (m.Type)
        {
            case MonsterType.Goblin: return 5;
            case MonsterType.Orc: return 10;
            case MonsterType.Skeleton: return 8;
            case MonsterType.Slime: return 4;
            case MonsterType.Dragon: return 40;
            case MonsterType.Troll: return 20;
            case MonsterType.Bat: return 6;
            case MonsterType.Spider: return 9;
            case MonsterType.Wyvern: return 30;
            default: return 0;
        }
    }

    // Mit dob a szörny, ha legyőzik. (null = semmit)
    public static Item GetLoot(Monster m)
    {
        switch (m.Type)
        {
            case MonsterType.Goblin: return new Item("potion");
            case MonsterType.Orc: return new Item("sword");
            case MonsterType.Skeleton: return new Item("shield");
            case MonsterType.Slime: return new Item("elixir");
            case MonsterType.Dragon: return new Item("potion");
            case MonsterType.Troll: return new Item("shield");
            case MonsterType.Bat: return null;
            case MonsterType.Spider: return new Item("potion");
            case MonsterType.Wyvern: return new Item("elixir");
            default: return null;
        }
    }
}
