// See https://aka.ms/new-console-template for more information

using Trafico;

Double costo, tiempo, distancia,costo_total, ResultadoMultiplicacion;
string destino, tipo_transporte,   compañia,corredor,linea ;

bus_interurbano bus_interurbano = new bus_interurbano();
Console.WriteLine("Ingrese datos del bus_interurbano:");
Console.Write("costo: ");
bus_interurbano.costo = Convert.ToDouble(Console.ReadLine());
Console.Write("destino: ");
bus_interurbano.destino = Console.ReadLine();
Console.Write("distancia: ");
bus_interurbano.compañia = Console.ReadLine();





Console.WriteLine();

taxi taxi = new taxi();
Console.WriteLine("Ingrese datos del taxi:");
Console.Write("distancia: ");
taxi.distancia = Convert.ToDouble(Console.ReadLine());
Console.Write("tiempo: ");
taxi.tiempo = Convert.ToDouble(Console.ReadLine());
costo_total = taxi.operar();
Console.Write("destino: ");
taxi.destino = Console.ReadLine();
ResultadoMultiplicacion = taxi.operar();


Console.WriteLine();

bus_urbano bus_urbano = new bus_urbano();
Console.WriteLine("Ingrese datos del bus_urbano:");
Console.Write("costo: ");
bus_urbano.costo = Convert.ToDouble(Console.ReadLine());
Console.Write("corredor: ");
bus_urbano.corredor = Console.ReadLine();





Console.WriteLine();

metro metro = new metro();
Console.WriteLine("Ingrese datos del metro:");
Console.Write("costo: ");
metro.costo = Convert.ToDouble(Console.ReadLine());
Console.Write("comapañia: ");
metro.compañia = Console.ReadLine();
Console.Write("linea: ");
metro.linea = Console.ReadLine();

Console.WriteLine("metro:");



Console.WriteLine();

teleferico teleferico = new teleferico();
Console.WriteLine("Ingrese datos del teleferico:");
Console.Write("costo: ");
teleferico.costo = Convert.ToDouble(Console.ReadLine());
Console.Write("compañia: ");
teleferico.compañia = Console.ReadLine();
Console.Write("distancia: ");
teleferico.linea = Console.ReadLine();



Console.WriteLine();


Console.WriteLine("Datos del taxi:");

Console.WriteLine("El destino es: " + taxi.destino);
Console.WriteLine($"la duracion del viaje es de:   {taxi.tiempo} horas");
Console.WriteLine($"La distancia son:   {taxi.distancia} kilometros");
Console.WriteLine($"El costo del boleto del taxi es :  {ResultadoMultiplicacion}");
Console.WriteLine();
Console.WriteLine();
Console.WriteLine("bus_interurbano:");

Console.WriteLine("El costo es: " + bus_interurbano.costo);
Console.WriteLine($"El destino: "+  bus_interurbano.destino);
Console.WriteLine($"La compañia es:" + bus_interurbano.compañia);
Console.WriteLine();

Console.WriteLine("bus_urbano:");
Console.WriteLine("El costo es: " + bus_urbano.costo);
Console.WriteLine($"El corredor es: "+  bus_urbano.corredor);
Console.WriteLine();
Console.WriteLine();

Console.WriteLine("metro:");

Console.WriteLine("El costo es: " + metro.costo);
Console.WriteLine($"La compañia es: "+  metro.compañia);
Console.WriteLine($"La linea es: "+  metro.linea);


Console.WriteLine();
Console.WriteLine("teleferico:");
Console.WriteLine("El costo es: " + teleferico.costo);
Console.WriteLine($"La compañia es: "+  teleferico.compañia);;
Console.WriteLine($"La linea es: "+  teleferico.linea);

