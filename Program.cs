using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
Smartphone nokia = new Nokia("981034505", "Nokia", "789879987987987", 128);
nokia.Ligar();
nokia.ReceberLigacao();
nokia.InstalarAplicativo("WhatsApp");

Console.WriteLine("\n");

Smartphone iphone = new Iphone("996906025", "Iphone", "12345678912345", 60);
iphone.Ligar();
iphone.ReceberLigacao();
iphone.InstalarAplicativo("ICloud");