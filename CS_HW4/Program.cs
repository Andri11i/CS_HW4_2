using CS_HW4;
using System;

// math helper

Console.WriteLine($"Factorial of 5: {MathHelper.Factorial(5)}");
Console.WriteLine($"GCD of 54 and 24: {MathHelper.GCD(54, 24)}");
Console.WriteLine($"LCM of 54 and 24: {MathHelper.LCM(54, 24)}");

// applic settings

var appSettings = new ApplicationSettings
{
    ApplicationName = "MyApp",
    Version = "1.0.0",
    DbSettings = new ApplicationSettings.DatabaseSettings
    {
        ConnectionString = "Server=myServer;Database=myDB;User Id=myUser;Password=myPass;",
        Timeout = 30
    }
};

Console.WriteLine(appSettings.GetFullSettings());

// storage

Storage<int> intStorage = new Storage<int>();
intStorage.SetItem(42);
Console.WriteLine($"Stored int: {intStorage.GetItem()}");

// string save
Storage<string> stringStorage = new Storage<string>();
stringStorage.SetItem("Hello, world!");
Console.WriteLine($"Stored string: {stringStorage.GetItem()}");

// class save
Storage<Person> personStorage = new Storage<Person>();
personStorage.SetItem(new Person { Name = "John Doe", Age = 30 });
Console.WriteLine($"Stored person: {personStorage.GetItem()}");



// timer


SimpleTimer timerr = new SimpleTimer();

timerr.OnTimeElapsed += () =>
{
    Console.WriteLine("Time's up!");
};

Console.WriteLine("Timer started for 3 seconds...");
timerr.Start(3);


Console.ReadLine();



// test class person for storage
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }

    public override string ToString()
    {
        return $"Name: {Name}, Age: {Age}";
    }
}