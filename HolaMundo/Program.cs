using ConsoleTables;
using HolaMundo;

List<Mascota> mascotas = new List<Mascota>()
{
    new Mascota { Id = 1, Nombre = "Perro", Edad = 5 },
    new Mascota { Id = 2, Nombre = "Gato", Edad = 3 },
    new Mascota { Id = 3, Nombre = "Loro", Edad = 2 }
};

var table = new ConsoleTable("ID", "NOMBRE", "EDAD");

foreach (var mascota in mascotas)
{
    table.AddRow(mascota.Id, mascota.Nombre, mascota.Edad);
}

// table.AddRow(1, 2, 3)
//      .AddRow("this line should be longer", "yes it is", "oh");


table.Write(Format.Alternative);
Console.WriteLine();