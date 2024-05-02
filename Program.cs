using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Smartphone Nokia: ");
Smartphone nokia = new Nokia(numero: "999999999", modelo: "3310", imei: "123456789", memoria: 128);
nokia.Ligar();
nokia.InstalarAplicativo("Hill Climb Racer");

Console.WriteLine("\n");

Console.WriteLine("Smartphone iPhone: ");
Smartphone iPhone = new Iphone(numero: "988888888", modelo: "14", imei: "987654321", memoria: 256);
iPhone.ReceberLigacao();
iPhone.InstalarAplicativo("Instagram");