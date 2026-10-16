using System;

public abstract class Hero
{

    public int hp { get; set; }
    public int dmg { get; set; }
    public string name { get; set; }
    public double crit { get; set; }
    public double critChance { get; set; }


    public Hero(int hp, int dmg, string name, double crit, double critChance)
    {
        this.hp = hp;
        this.dmg = dmg;
        this.name = name;
        this.crit = crit;
        this.critChance = critChance;
    }

    public void info()
        {
        Console.WriteLine($"Имя: {this.name}\nБазовый урон: {this.dmg}\nКрит.Шанс:{this.critChance} ");
    }

    public int TakeDamage(int edmg)
    {
        this.hp -= edmg;
        return this.hp;



    }



    public abstract void specialAbility();

}

public static class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Запуск Rpg - тестовая точка входа.");
        Console.WriteLine("Создайте классы-наследники Hero и добавьте логику игры.");
    }
}

public static class Battle
{
    static Random random = new Random();

    public static bool Fight(Hero hero, Enemy enemy)
    {
        WriteLine($"Fight with {enemy.Name}");

        while (hero.Hp > 0 && enemy.Hp > 0)
        {
            WriteLine($"\n{hero.Name}: {hero.Hp}/{hero.MaxHp} HP | {enemy.Name}: {enemy.Hp} HP");
            WriteLine("1 - Атака, 2 - Спецудар, 3 - Ухилитися, 4 - Зілля");
            string choice = ReadLine();
            bool dodge = false;

            if (choice == "1")
            {
                enemy.Hp -= hero.Damage;
                WriteLine($"Ви завдали {hero.Damage} урону");
            }
            else if (choice == "2")
            {
                if (random.Next(2) == 0)
                {
                    enemy.Hp -= hero.Damage * 2;
                    WriteLine($"Спецудар! {hero.Damage * 2} урону");
                }
                else WriteLine("Спецудар промахнувся!");
            }
            else if (choice == "3") dodge = true;
            else if (choice == "4")
            {
                if (hero.Potions > 0)
                {
                    hero.Potions--;
                    hero.Hp = Math.Min(hero.Hp + 30, hero.MaxHp);
                    WriteLine("Ви випили зілля (+30 HP)");
                }
                else
                {
                    WriteLine("Зілля немає!");
                    continue;
                }
            }
            else
            {
                WriteLine("Невірний вибір");
                continue;
            }
            if (enemy.Hp > 0)
            {
                if (dodge && random.Next(2) == 0)
                    WriteLine("Ви ухилились!");
                else
                {
                    hero.Hp -= enemy.Damage;
                    WriteLine($"{enemy.Name} б'є вас на {enemy.Damage}");
                }
            }
        }

        return hero.Hp > 0;
    }
}