namespace Console_project;

public class Drone
{
    private int _power;
    private bool _isEnabled;
    public int Power
    {
        get => _power;
        set => SetPower(value);
    }
    public bool IsEnabled => _isEnabled;
    public string Name { get; set; }

    public Drone(string name)
    {
        Name = name;
        _isEnabled = false;
        _power = 0;
    }

    public void TurnOn()
    {
        _isEnabled = true;
        Console.WriteLine(ToString() + " turned on");
    }

    public void TurnOff()
    {
        _isEnabled = false;
        Console.WriteLine(ToString() + " turned off");
    }

    public void SetPower(int value)
    {
        if (value > 0)
        {
            Console.WriteLine($"{ToString()} setted power: {value}");
            _power = value;
        }
    }

    public void PrintState()
    {
        Console.WriteLine($"{ToString()} is {(_isEnabled ? "on" : "off")}; Power: {_power}");
    }

    public override string ToString()
    {
        return $"Drone '{Name}'";
    }
}
