// See https://aka.ms/new-console-template for more information
using InterfacesTraining;

Console.WriteLine("Hello, World!");

PopulateData data = new PopulateData();
//data.browser();

data.Name = "changed name";
data.browser();