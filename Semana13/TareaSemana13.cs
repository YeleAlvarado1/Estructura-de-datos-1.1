// Clase que gestiona el menu de la tarea de la semana 13
public class TareaSemana13
{
   // Método estatico para ejecutar la tarea
    public static void Run()
    {
        // Crear el catalogo con 10 revistas cargadas
        Catalogo catalogo = new Catalogo();

        string opcion = "";
        string entrada = "";

        // Bucle del menu principal
        while (opcion != "3")
        {
            System.Console.WriteLine("\n--- MENU PRINCIPAL ---");
            System.Console.WriteLine("1. Mostrar catalogo");
            System.Console.WriteLine("2. Buscar revista por titulo");
            System.Console.WriteLine("3. Salir");
            System.Console.Write("Seleccione una opcion: ");
            opcion = System.Console.ReadLine();

            if (opcion == "1")
            {
                catalogo.Mostrar(); // Llama al metodo que imprime las revistas
            }
            else if (opcion == "2")
            {
                System.Console.Write("Ingrese el título a buscar: ");
                entrada = System.Console.ReadLine();

                // Validar que la entrada no este vacia
                if (entrada != null && entrada != "")
                {
                    bool encontrado = catalogo.BuscarRecursivo(entrada, 0);

                    if (encontrado)
                    {
                        System.Console.WriteLine("Encontrado"); 
                        
                    }
                    else
                    {
                        System.Console.WriteLine("No encontrado");
                    }
                }
                else
                {
                    System.Console.WriteLine("Debe ingresar un título válido.");
                }
            }
            else if (opcion == "3")
            {
                System.Console.WriteLine("Saliendo del programa...");
            }
            else
            {
                System.Console.WriteLine("Opción no válida. Intente nuevamente.");// Mensaje de error para opcion invalida
            }
        }
    }
}
