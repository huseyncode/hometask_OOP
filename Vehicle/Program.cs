using System;
using System.Collections.Generic;
using Vehicle;

class Program
{
    static void Main(string[] args)
    {
        Car car = new Car
        {
            Name = "Car",
            Model = "Model1",
            Color = "Red",
            MaxSpeed = 200,
            EngineVolume = 2.0,
            FuelCapacity = 50.0,
            PassengerCapacity = 5
        };

        Truck truck = new Truck
        {
            Name = "Truck",
            Model = "Model2",
            Color = "Blue",
            MaxSpeed = 100,
            EngineVolume = 5.0,
            FuelCapacity = 100.0,
            LoadCapacity = 1000.0
        };

        Console.WriteLine($"Car Details: \nName: {car.Name}, Model: {car.Model}, Color: {car.Color}, MaxSpeed: {car.MaxSpeed}, EngineVolume: {car.EngineVolume}, FuelCapacity: {car.FuelCapacity}, PassengerCapacity: {car.PassengerCapacity}");
        Console.WriteLine($"Truck Details: \nName: {truck.Name}, Model: {truck.Model}, Color: {truck.Color}, MaxSpeed: {truck.MaxSpeed}, EngineVolume: {truck.EngineVolume}, FuelCapacity: {truck.FuelCapacity}, LoadCapacity: {truck.LoadCapacity}");
    }
}
