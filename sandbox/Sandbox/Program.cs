using System;

class Program
{
    static void Main(string[] args)
    {
        // Create Devices
        var light = new SmartLight("Living Room Light");
        var heater = new SmartHeater("Bedroom Heater");
        var tv = new SmartTV("Kitchen TV");

        // Create Rooms
        var livingRoom = new Room("Living Room");
        var bedroom = new Room("Bedroom");

        // Add Devices to Rooms
        livingRoom.AddDevice(light);
        bedroom.AddDevice(heater);
        bedroom.AddDevice(tv);

        // Create House
        var house = new House();
        house.AddRoom(livingRoom);
        house.AddRoom(bedroom);

        // Test Commands
        livingRoom.TurnOnAllDevices();
        bedroom.TurnOnAllDevices();
        bedroom.ReportDevicesOn();
        bedroom.ReportLongestOn();

        house.ReportHouseStatus();
        house.TurnOffAllDevices();
        house.ReportHouseStatus();
    }
}
