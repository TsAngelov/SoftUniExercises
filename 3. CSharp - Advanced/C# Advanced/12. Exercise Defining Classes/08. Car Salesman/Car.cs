using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarSalesman;

public class Car
{
    public string Model { get; set; }
    public Engine Engine { get; set; }
    public int Weight { get; set; }
    public string Color { get; set; }
    
    public Car()
    {
        Model = default;
        Engine = default;
        Weight = default;
        Color = default;
    }
    public Car(string model, Engine engine) : this()
    {
        Model = model;
        Engine = engine;
    }
    public Car(string model, Engine engine, int weigth) : this(model, engine)
    {
        Weight = weigth;
    }
    public Car(string model, Engine engine, string color) : this(model, engine)
    {
        Color = color;
    }
    public Car(string model, Engine engine, int weigth, string color) : this(model, engine)
    {
        Weight = weigth;
        Color = color;
    }

    public override string ToString()
    {
        StringBuilder sb = new();
        sb.AppendLine($"{Model}:");
        sb.AppendLine($"  {Engine.Model}:");
        sb.AppendLine($"    Power: {Engine.Power}");
        //Engine displacement check
        if (Engine.Displacement == default)
            sb.AppendLine($"    Displacement: n/a");
        else
            sb.AppendLine($"    Displacement: {Engine.Displacement}");

        //Engine efficiency check
        if (Engine.Efficiency == default)
            sb.AppendLine($"    Efficiency: n/a");
        else
            sb.AppendLine($"    Efficiency: {Engine.Efficiency}");

        //Weight weight check
        if (Weight == default)
            sb.AppendLine($"  Weight: n/a");
        else
            sb.AppendLine($"  Weight: {Weight}");

        //Color check
        if (Color == default)
            sb.Append($"  Color: n/a");
        else
            sb.Append($"  Color: {Color}");

        return sb.ToString();
    }
}
