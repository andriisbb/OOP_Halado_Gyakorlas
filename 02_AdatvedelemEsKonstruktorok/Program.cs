using _02_AdatvedelemEsKonstruktorok;

Bankszamla Anna = new Bankszamla("100");
Bankszamla Bela = new Bankszamla("200", 100000, 50000);

Anna.Befizetes(100000);
Bela.Kivetel(20000);

Console.WriteLine($"Anna számlája: {Anna.Szamlaszam}, egyenleg: {Anna.Egyenleg}, hitelkeret: {Anna.HitelKeret}");
Console.WriteLine($"Béla számlája: {Bela.Szamlaszam}, egyenleg: {Bela.Egyenleg}, hitelkeret: {Bela.HitelKeret}");
