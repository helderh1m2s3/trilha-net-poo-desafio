using DesafioPOO.Models;

Console.WriteLine("Smartphone Nokia:");
Smartphone nokia = new Nokia (numero: "83 988888888", modelo: "C30", imei: "000000000000001", memoria: 64);
nokia.Ligar();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("Smartphone Iphone:");
Smartphone iphone = new Nokia (numero: "83 989898989", modelo: "8 Plus", imei: "000000000000002", memoria: 128);
iphone.Ligar();
iphone.InstalarAplicativo("Telegram");