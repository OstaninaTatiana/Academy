using System;
using System.Collections.Generic;

public class Station
{
    protected string name;
    protected string color;
    protected Line line;
    protected bool isWheelchairAccassable;
    protected bool hasParkAndRide;
    protected bool hasNearbyCableCar;
    protected List<Station> transfers;

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
        foreach (Station t in transfer)
        { this.transfers.Add(t); }
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
