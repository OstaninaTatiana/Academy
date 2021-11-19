using System;
using System.Collections.Generic;


public class Metro
{
    List<Line> lines;
    string city;

    public Metro(string city)
    { 
        this.city = city;
        lines = new List<Line>();
    }

    public string GetCity()
    {
        return this.city;
    }

    public void AddLine(string name, string color)
    {
        lines.Add(new Line(name, color));
    }

    public void RemoveLine(string name)
    {
        foreach (Line line in lines)
        {
            if (line.GetName() == name)
            {
                lines.Remove(line);
            }
        }
    }

    public List<Station> FindStation(string name)
    {
        return null;
    }

    public Station FindStation(string name, string lineName)
    {
        return null;
    }

    public List<Station> GetStationList(string name)
    {
        return null;
    }

    public void LoadStationFromFile(string filename)
    {
        
    }

}