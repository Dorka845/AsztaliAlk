namespace DungeonPain;

// Szörnyek létrehozása: fajtánként más-más kezdőértékekkel.
static class MonsterFactory
{
    public static Monster Create(MonsterType type)
    {
        Monster m = new Monster();
        m.Type = type;

        switch (type)
        {
            case MonsterType.Goblin:
                m.Name = "Goblin";
                m.MaxHp = 12;
                m.Attack = 4;
                m.Defense = 1;
                break;
            case MonsterType.Orc:
                m.Name = "Orc";
                m.MaxHp = 25;
                m.Attack = 6;
                m.Defense = 2;
                break;
            case MonsterType.Skeleton:
                m.Name = "Skeleton";
                m.MaxHp = 18;
                m.Attack = 5;
                m.Defense = 1;
                break;
            case MonsterType.Slime:
                m.Name = "Slime";
                m.MaxHp = 15;
                m.Attack = 3;
                m.Defense = 0;
                break;
            case MonsterType.Dragon:
                m.Name = "Dragon";
                m.MaxHp = 40;
                m.Attack = 11;
                m.Defense = 4;
                break;
            case MonsterType.Troll:
                m.Name = "Troll";
                m.MaxHp = 24;
                m.Attack = 5;
                m.Defense = 2;
                break;
            case MonsterType.Bat:
                m.Name = "Bat";
                m.MaxHp = 10;
                m.Attack = 3;
                m.Defense = 0;
                m.IsFlying = true;
                break;
            case MonsterType.Spider:
                m.Name = "Spider";
                m.MaxHp = 16;
                m.Attack = 4;
                m.Defense = 1;
                m.IsPoisonous = true;
                break;
            case MonsterType.Wyvern:
                m.Name = "Wyvern";
                m.MaxHp = 30;
                m.Attack = 9;
                m.Defense = 3;
                m.IsFlying = true;
                m.IsPoisonous = true;
                break;
        }

        m.Hp = m.MaxHp;
        return m;
    }
}
