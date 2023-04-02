using System;
using System.Collections.Generic;
using System.IO;

public class Auto
{
    public string Modelo;
    public string Marca;
    public int Año;
    public List<string> HistoriaDeReparaciones = new List<string>();

    public virtual void Reparar()
    {
        Console.WriteLine("Reparando el vehículo");
    }

    public void MostrarHistoriaDeReparaciones()
    {
        foreach (var reparacion in HistoriaDeReparaciones)
        {
            Console.WriteLine(reparacion);
        }
    }
}

public class BMW : Auto
{
    public override void Reparar()
    {
        base.Reparar();

        HistoriaDeReparaciones.Add("Reparación realizada el " + DateTime.Now);
        File.AppendAllText("log.txt", "Reparación realizada el " + DateTime.Now + Environment.NewLine);
    }
}

public class Program
{
    static void Main(string[] args)
    {
        BMW bmw = new BMW();
        bmw.Modelo = "Serie 3";
        bmw.Marca = "BMW";
        bmw.Año = 2021;

        bmw.Reparar();

        Console.WriteLine("Historial de reparaciones:");
        bmw.MostrarHistoriaDeReparaciones();
    }
}