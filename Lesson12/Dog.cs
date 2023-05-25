﻿using System;

public class Dog : Animal
{
    public Dog(string name, string color, decimal weight) : base(name, color, weight)
    {

    }

    public new void SaySmth()
    {
        Console.WriteLine("Bark!");
    }

    public override string ToString()
    {
        return $"I'm a dog! My name is {Name}";
    }
}