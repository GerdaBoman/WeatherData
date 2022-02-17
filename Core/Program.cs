using DataAccess;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
DataSending dataSending = new DataSending();
double allTemp = 0;


List<double> data  = dataSending.Daily_Average("Inne", "2016","10","01");



Console.WriteLine(data.Average());