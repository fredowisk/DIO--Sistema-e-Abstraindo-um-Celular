using DesafioPOO.Models;

// Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Testando o Smartphone Nokia:");
Smartphone nokia = new Nokia(numero: "9 1234-5678", modelo: "C12", imei: "123456789101112", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Telegram");

Console.WriteLine("\n--------\n");

Console.WriteLine("Testando o Smartphone iPhone:");
Smartphone iphone = new Iphone(numero: "9 8765-4321", modelo: "15", imei: "121110987654321", memoria: 512);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");