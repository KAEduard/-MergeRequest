namespace GunStore;

public class Weapon
{
    private int WeaponLength { get; set; }
    private double CartridgeType { get; set; }
    private int NumberOfCartridges { get; set; }
    private string Name { get; set; }
    public Weapon(int weaponLength, double cartridgeType, int numberOfCartridges, string name)
    {
        WeaponLength = weaponLength;
        CartridgeType = cartridgeType;
        NumberOfCartridges = numberOfCartridges;
        Name = name;
    }

    public  void ShowingWeapons()
    {
        Console.WriteLine($"{WeaponLength}{NumberOfCartridges}{Name}{CartridgeType}");
    }
}