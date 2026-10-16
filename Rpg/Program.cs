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
