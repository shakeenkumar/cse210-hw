using System.Collections.Generic;
using System.Linq;

public class Room
{
    public string Name { get; set; }
    private List<SmartDevice> Devices { get; set; }

    public Room(string name)
    {
        Name = name;
        Devices = new List<SmartDevice>();
    }

    public void AddDevice(SmartDevice device)
    {
        Devices.Add(device);
        Console.WriteLine($"{device.Name} added to {Name}.");
    }

    public void TurnOnAllDevices()
    {
        Devices.ForEach(device => device.TurnOn());
    }

    public void TurnOffAllDevices()
    {
        Devices.ForEach(device => device.TurnOff());
    }

    public void ReportDevices()
    {
        Console.WriteLine($"Devices in {Name}:");
        Devices.ForEach(device => Console.WriteLine(device.GetStatus()));
    }

    public void ReportDevicesOn()
    {
        Console.WriteLine($"Devices ON in {Name}:");
        Devices.Where(device => device.IsOn)
               .ToList()
               .ForEach(device => Console.WriteLine(device.Name));
    }

    public void ReportLongestOn()
    {
        var longestOnDevice = Devices.Where(device => device.IsOn)
                                     .OrderByDescending(device => device.GetTimeOn())
                                     .FirstOrDefault();
        if (longestOnDevice != null)
        {
            Console.WriteLine($"Device ON the longest in {Name}: {longestOnDevice.Name}");
        }
        else
        {
            Console.WriteLine($"No devices are ON in {Name}.");
        }
    }
}
