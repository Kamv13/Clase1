using System.Drawing;
using Clase1;
using static System.Runtime.InteropServices.JavaScript.JSType;

Ave ave = new Ave();
Ave ave2 = new Ave();
Ave ave3 = new Ave();


ave.Nombre = "Loro";
ave.Especie = "Amazona Aestiva";
ave.Color = "Verde";
ave.Tamano = 30.5;
ave.Habitat = "bosques tropicales";
ave.Familia.Nombre = "Psittacidae";
ave.Imprimir();