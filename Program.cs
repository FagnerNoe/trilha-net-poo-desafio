using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Ipho
Console.WriteLine("Nokia");
Smartphone nokia = new Nokia(numero: "14253678", modelo: "Modelo C-90", imei: "34567876", memoria: 128);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Console.WriteLine("Iphone");
Smartphone iphone = new Iphone(numero: "456789", modelo: "Iphone 12", imei: "5678473", memoria: 512);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");