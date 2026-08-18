using projeto_smartphone.Models;

Nokia android = new Nokia("11 91234-5678", "Lumia", "12285869475838494", 128);
Iphone ios = new Iphone("11 99876-4321", "17 Pro Max", "8564827492031647", 256);

Console.WriteLine("Smartphone Nokia");
android.Ligar();
android.InstalarAplicativo("Whatsapp");

Console.WriteLine("\n");

Console.WriteLine("Smartphone Iphone");
ios.ReceberLigacao();
ios.InstalarAplicativo("Telegram");