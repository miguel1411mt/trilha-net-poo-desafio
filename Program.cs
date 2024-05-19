using DesafioPOO.Models;

Console.WriteLine("---------------NOKIA---------------");


Nokia nokia = new Nokia("41 93333-1111", "3200", "111111111111111", 2);

nokia.Call("43 92222-3456");

Console.WriteLine("");

nokia.ReceiveCall("43 92222-3456");

Console.WriteLine("");

nokia.InstallApp("Instagram");


Console.WriteLine("---------------IPHONE---------------");

Iphone iphone = new Iphone("41 93333-1111", "15 Pro Max", "111111111111111", 4);

iphone.Call("43 92222-3456");

Console.WriteLine("");

iphone.ReceiveCall("43 92222-3456");

Console.WriteLine("");

iphone.InstallApp("Instagram");