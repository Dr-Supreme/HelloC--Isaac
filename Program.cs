// See https://aka.ms/new-console-template for more information
using HellofromC_;
using System.Runtime.InteropServices;

Console.WriteLine("Hello everybody!");

Console.WriteLine("Please enter your name: ");

string name = Console.ReadLine(); // how to accept from the user who types

Console.WriteLine("Hello " + name + " you are beautiful asf, i hope your studying going well, love and kisses babygirl ");

// dotnet new will create a new project
// dotnet build will compile my application
// dotnet run will execte the app


Console.WriteLine("Welcome to isaacs C# learning Shop");
Console.WriteLine("Please enter your name: ");

string name2 = Console.ReadLine();
string Name2 = Console.ReadLine();//these are different identifiers so itll work

int monthlyWage = 0;
//byte number = 256; // this wont work because bytes only store 0-255;

int amount = 1234;
int months = 12;
int yearlyWage = Utilities.CalculateYearlyWage(amount, months);

Console.ReadLine();