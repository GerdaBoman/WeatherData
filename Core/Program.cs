// See https://aka.ms/new-console-template for more information

using Core;
using DataAccess.Models;

Console.WriteLine("Hello, World!");

RemovingLonelyData data = new RemovingLonelyData();

data.RemovingSingles();

Console.WriteLine("Done");
Console.ReadLine();




