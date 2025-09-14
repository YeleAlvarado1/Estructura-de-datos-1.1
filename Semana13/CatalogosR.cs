// Definición de la clase Revista
public class Catalogo
{
    Revista[] revistas = new Revista[10];

    // Constructor
    public Catalogo()
    {
        revistas[0] = new Revista("National Geographic"); // Inicialización del arreglo de revistas
        revistas[1] = new Revista("Generación 21");
        revistas[2] = new Revista("Ciencia Hoy");
        revistas[3] = new Revista("Acelerando");
        revistas[4] = new Revista("Historia y Vida");
        revistas[5] = new Revista("Cosas");
        revistas[6] = new Revista("Revista Hogar");
        revistas[7] = new Revista("Revista vistazo");
        revistas[8] = new Revista("Discover Magazine");
        revistas[9] = new Revista("Revista estadio");
    }
// Método para mostrar las revistas
    public void Mostrar()
    {
        int i = 0;
        while (i < 10)
        {
            Escribir("[" + (i + 1) + "] " + revistas[i].titulo);
            i = i + 1;
        }
    }
// Método para buscar una revista de forma recursivas
    public bool BuscarRecursivo(string buscado, int indice)
    {
        if (indice >= 10)
        {
            return false;
        }

        if (revistas[indice].titulo.ToLower() == buscado.ToLower())
        {
            return true;
        }

        return BuscarRecursivo(buscado, indice + 1);
    }
//  Método para escribir en la consola 
    public void Escribir(string texto)
    {
        System.Console.WriteLine(texto);
    }
}
