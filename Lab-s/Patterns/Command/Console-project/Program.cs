using Console_project;

CommandsController switchController = new();
CommandsWithParameterController<int> powerController = new();

// Specified object example
Drone specialOne = new("Special one");

switchController.CommandsDictionary.Add("Turn one on", new SimpleCommand(specialOne.TurnOn));
switchController.CommandsDictionary.Add("Turn one off", new SimpleCommand(specialOne.TurnOff));
powerController.CommandsDictionary.Add("Set one power", new SimpleCommandWithParameters<int>(specialOne.SetPower));

// Tests
specialOne.PrintState();
switchController.Execute("Turn one on");
specialOne.PrintState();
switchController.Execute("Turn one off");
specialOne.PrintState();
powerController.Execute("Set one power", 5);
specialOne.PrintState();
powerController.Execute("Set one power", 44);
specialOne.PrintState();
powerController.Execute("Set one power", 9);
specialOne.PrintState();

// Objects group example
var drones = new Drone[5];

for (int i = 0; i < drones.Length; i += 1)
    drones[i] = new($"NSO{i + 1}");

switchController.CommandsDictionary.Add("Turn NSO on", new SimpleCommand(
    () =>
    {
        foreach (Drone d in drones)
            d.TurnOn();
    }));
switchController.CommandsDictionary.Add("Turn NSO off", new SimpleCommand(
    () =>
    {
        foreach (Drone d in drones)
            d.TurnOff();
    }));
powerController.CommandsDictionary.Add("Set NSO power", new SimpleCommandWithParameters<int>(
    (int value) =>
    {
        foreach (Drone d in drones)
            d.Power = value;
    }));
Action printNSOState = () =>
{
    foreach (Drone d in drones)
        d.PrintState();
};

// Tests
printNSOState();
switchController.Execute("Turn NSO on");
printNSOState();
switchController.Execute("Turn NSO off");
printNSOState();
powerController.Execute("Set NSO power", 72);
printNSOState();
powerController.Execute("Set NSO power", 03);
printNSOState();
powerController.Execute("Set NSO power", 11);
printNSOState();