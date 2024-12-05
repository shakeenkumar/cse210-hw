using System.Collections.Generic;

public class House
{
    private List<Room> Rooms { get; set; }

    public House()
    {
        Rooms = new List<Room>();
    }

    public void AddRoom(Room room)
    {
        Rooms.Add(room);
        Console.WriteLine($"Room {room.Name} added to the house.");
    }

    public void TurnOnAllDevices()
    {
        Rooms.ForEach(room => room.TurnOnAllDevices());
    }

    public void TurnOffAllDevices()
    {
        Rooms.ForEach(room => room.TurnOffAllDevices());
    }

    public void ReportHouseStatus()
    {
        Console.WriteLine("House Status:");
        Rooms.ForEach(room => room.ReportDevices());
    }
}
