public class Hero
{

    public int hp { get; set; };
    public int dmg { get; set; };
    public string name { get; set; };
    public double crit { get; set; };
    public double critChance { get; set};


    public class Hero(int hp, int dmg, string name, double crit, double critChance)
    {

        Hp = hp;
		Dmg = dmg;
		Name = name;
		Crit = crit;
		CritChance = critChance;

	}


    public void info() { Console.WriteLine($"Имя: {this.name}\nБазовый урон: {this.dmg}\nКрит.Шанс:{this.critChance} "); }


    public int TakeDamage(int edmg)
    {
        this.hp -= edmg;
        return this.hp;



    }



    public abstract void specialAbility();

}