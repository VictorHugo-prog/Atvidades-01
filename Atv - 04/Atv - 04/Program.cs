
Carro car2 = new Carro("Fiat", "stilo", 200, 10.6, 6.6);
Carro car3 = new Carro("Chevrolet", "Vectra", 205, 10.2, 8.9);
Carro car1 = new Carro("Peugeot", "206", 174, 12.1, 5.7);


Console.WriteLine("O carro é um " + car1.Marca + " do modelo " + car1.Modelo + " com a velocidade final de " + car1.Velocidade + "Km/h");
Console.WriteLine("O carro é um " + car2.Marca + " do modelo " + car2.Modelo + " com a velocidade final de " + car2.Velocidade + "Km/h");
Console.WriteLine("O carro é um " + car3.Marca + " do modelo " + car3.Modelo + " com a velocidade final de " + car3.Velocidade + "Km/h\n");



car1.acelerar();
car2.acelerar();
car3.acelerar();

car1.desacelerar();
car2.desacelerar();
car3.desacelerar();


Console.ReadKey();