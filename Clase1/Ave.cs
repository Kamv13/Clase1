

namespace Clase1
{
    public class Ave
    {
        public string? Nombre   { get; set; }

        public string? Especie  { get; set; }

        public string? Color    { get; set; }

        public double  Tamano   {  get; set; }

        public string? Habitat  {  get; set; }

        public FamiliaAve Familia { get; set; }

        public Ave() {
            Familia = new FamiliaAve();
        }
        
        public void Imprimir() {

            Console.WriteLine($"Nombre :  {Nombre}");
            Console.WriteLine($"Especie : {Especie}");
            Console.WriteLine($"Color :   {Color}");
            Console.WriteLine($"Tamano :  {Tamano} cm");
            Console.WriteLine($"Habitat : {Habitat}");
            Console.WriteLine($"Familia : {Familia.Nombre}");
            
        }
    }
}
