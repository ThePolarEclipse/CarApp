using System;

namespace CarApp
{
    public class Car
    {
        // Fields to store the car's data
        private string make;
        private string model;
        private string registration;
        private int year;
        private decimal currentValue;
        private string color; // I added this just for fun

        // Constructor that initializes the Car object
        public Car(string make, string model, string registration, int year, decimal currentValue, string color)
        {
            this.make = make;
            this.model = model;
            this.registration = registration;
            this.year = year;
            this.currentValue = currentValue;
            this.color = color;
        }

        // Methods to return the car's details
        public decimal GetCurrentValue()
        {
            return this.currentValue;
        }
        public int GetYear()
        {
            return this.year;
        }
        public string GetColor()
        {
            return this.color;
        }
        public string GetMake()
        {
            return this.make;
        }
        public string GetModel()
        {
            return this.model;
        }
        public string GetRegistration()
        {
            return this.registration;
        }

        // Method to return a string with all details about the car
        public override string ToString()
        {
            return $"Make: {this.make}, Model: {this.model}, Registration: {this.registration}, Year: {this.year}, Current Value: ${this.currentValue}, Color: {this.color}";
        }
    }
}
