using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
// Realizado: 20/05/2024

Console.WriteLine("------- Smartphone Nokia -------");
Smartphone nokia = new Nokia(numero: "15412", modelo: "Lúmia 12", imei: "1211AB20", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");

Console.WriteLine("------- Smartphone Iphone -------");
Smartphone iphone =  new Iphone(numero: "55421", modelo: "11", imei: "ABOE5421", memoria: 126);
iphone.ReceberLigacao();
nokia.InstalarAplicativo("Telegram");