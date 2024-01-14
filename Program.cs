using DesafioPOO.Models;

// TODO: Realizar os testes com as classes Nokia e Iphone
//implementado

Console.WriteLine("Smartphone: Iphone");
Iphone cel1 = new Iphone("967153045", "IphoneS", "45fert", 16);
cel1.InstalarAplicativo("Waze");
cel1.Ligar();

Console.WriteLine("-----------------------");

Console.WriteLine("Smartphone: Nokia");
Nokia cel2 = new Nokia("922153044", "Nokia-9", "88bart", 16);
cel2.InstalarAplicativo("Facebook");
cel2.ReceberLigacao();