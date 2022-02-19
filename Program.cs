// See https://aka.ms/new-console-template for more information

//string marca = "Toyota";
//string modelo = "Modelo";
//string cor = "Cor";
//int ano = 2020;

using Localiza_Poo.Src;
using Localiza_Poo.Src.Entities;

Veiculo carro = new Veiculo("Honda", "Civic", 2020, "Preto", + 60000.00);
Veiculo carro2 = new Veiculo("Toyota", "Corolla", 2010, "Prata", + 20000.00);
Veiculo carro3 = new Veiculo("Jeep", "Renegade", 2009, "Branco", + 70000.00);
Veiculo moto = new Moto("Honda", "CG 160", 2020, "Branca", + 20000.00, 160);




Console.WriteLine (carro);
Console.WriteLine ("-------------");
Console.WriteLine (carro2);
Console.WriteLine ("-------------");
Console.WriteLine (moto);
Console.WriteLine ("-------------");
Console.WriteLine (carro3);


