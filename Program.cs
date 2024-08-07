using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Console.WriteLine("Celular Nokia");
Nokia nokia = new Nokia("1133442233", "GTW12","112334", 120);
nokia.Ligar();
nokia.InstalarAplicativo("Whatsapp");


Console.WriteLine("Celular Iphone");
Iphone iphone = new Iphone("119332442", "15 pro max", "222222", 500);
iphone.ReceberLigacao();
iphone.InstalarAplicativo("Instagram");