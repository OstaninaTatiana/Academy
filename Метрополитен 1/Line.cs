using System;
using System.Collections.Generic;


public class Line
{
	List<Station> stations;
	string name;
	string color;

	public Line(string name, string color)
    {
		this.name = name;
		this.color = color;
		this.stations = new List<Station>();
    }

	public Station GetStation(string name)
    {
		foreach (Station station in stations)
		{
			if (station.GetName() == name)
			{ return station; }
        }
		return null;
	}

	public string GetName()
    {
		return name;
    }

	public string GetColor()
    {
		return color;
    }

	public void SetColor(string color)
    {
		this.color = color;
    }

	public void AddStation(string name, string color)
    {
		stations.Add(new Station(name, color));
    }

	public void AddStation(string name, string color, List<Station> transfers)
    {
		stations.Add(new Station(name, color, transfers));
	}

	public void RemoveStation(string name)
	{
		foreach (Station station in stations)
		{
			if (station.GetName() == name)
			{
				stations.Remove(station);
			}
		}
	}

	public Station FindStationByName(string name)
	{
		foreach (Station station in stations)
		{
			if (station.GetName() == name)
			{ return station; }
		}
		return null;
	}

	public List<Station> GetStationList()
    {
		return stations;
    }
}
