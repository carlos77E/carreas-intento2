using p1AC7.Clases;
Carro CarroA;
Carro CarroB;
Carro CarroC;
string marca;
int modelo;
int velocidad;
string propietario;


Console.WriteLine("Ingrese marca");
marca = Console.ReadLine();

Console.WriteLine("ingrese modelo");
modelo = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ingrese velocidad max");
velocidad = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Propietario:");
propietario = Console.ReadLine();

CarroA = new Carro(marca, modelo, velocidad, propietario);

Console.WriteLine("Ahora datos del B");

Console.WriteLine("Ingrese marca");
marca = Console.ReadLine();

Console.WriteLine("ingrese modelo");
modelo = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ingrese velocidad max");
velocidad = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Propietario:");
propietario = Console.ReadLine();

CarroB = new Carro(marca, modelo, velocidad, propietario);

Console.WriteLine("Ahora datos del C");

Console.WriteLine("Ingrese marca");
marca = Console.ReadLine();

Console.WriteLine("ingrese modelo");
modelo = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("ingrese velocidad max");
velocidad = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Propietario:");
propietario = Console.ReadLine();

CarroC = new Carro(marca, modelo, velocidad, propietario);





string msgCarroA, msgCarroB, msgCarroC;
Random velRandom = new Random();




msgCarroA = CarroA.EncenderMotor();
msgCarroB = CarroB.EncenderMotor();
msgCarroC = CarroC.EncenderMotor();
Console.WriteLine($"{CarroA.Marca} {msgCarroA}");
Console.WriteLine($"{CarroB.Marca} {msgCarroB}");
Console.WriteLine($"{CarroC.Marca} {msgCarroC}");


for (int i = 0; i < 10; i++)
{
    int acelera;
    acelera = velRandom.Next(1, 21);
    msgCarroA = CarroA.acelerar(acelera);
    acelera = velRandom.Next(1, 21);
    msgCarroB = CarroB.acelerar(acelera);
    msgCarroC = CarroC.acelerar(acelera);
    Console.WriteLine($"{i + 1}- {CarroA.owner}:{msgCarroA}  {CarroB.owner}:{msgCarroB} {CarroC.owner}:{msgCarroC}");

}

if (CarroA.GetVelocidadActual() > CarroB.GetVelocidadActual())
{
    Console.WriteLine($"{CarroA.owner} Wins!!!");
}
else
{
    Console.WriteLine($"{CarroB.owner} Wins!!!");
}

if (CarroC.GetVelocidadActual() > CarroA.GetVelocidadActual())
{
    Console.WriteLine($"{CarroC.owner} Wins!!!");
}
else
{
    Console.WriteLine($"{CarroA.owner} Wins!!");
}
if (CarroC.GetVelocidadActual() > CarroB.GetVelocidadActual())
{
    Console.WriteLine($"{CarroC.owner} Wins!!!");
}
else
{
    Console.WriteLine($"{CarroB.owner} Wins!!");
}




