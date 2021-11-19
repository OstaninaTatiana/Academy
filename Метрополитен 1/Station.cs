using System;
using System.Collections.Generic;

public class Station
{
    string name;
    string color;
    Line line;
    bool isWheelchairAccassable;
    bool hasParkAndRide;
    bool hasNearbyCableCar;
    List<Station> transfers;

	public Station(string name, string color)
    {
        this.name = name;
        this.color = color;
        this.transfers = new List<Station>();
    }

    public Station(string name, string color, List<Station> transfer)
    {
        this.name = name;
        this.color = color;
        this.transfers = transfer;
    }

    public string GetName()
    {
        return name;
    }

    public void SetName(string name)
    {
        this.name = name;
    }

    public bool IsWheelchairAccassable()
    {
        return isWheelchairAccassable;
    }

    public bool HasParkAndRide()
    {
        return hasParkAndRide;
    }

    public bool HasNearbyCableCar()
    {
        return hasNearbyCableCar;
    }

    public string GetLineName()
    {
        return line.GetName();
    }

    public List<Station> GetTransferList()
    {
        return transfers;
    }
}
