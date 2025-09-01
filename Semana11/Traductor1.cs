public class TraductorBasico
{
    public static void Main()
    {
        //Diccionario inicial de español ----> Ingles
        Dictionary<string, string> diccionario = new Dictionary<string, string>()
        {
            { "tiempo", "time" },
            { "persona", "person" },
            { "ano", "year" },
            { "camino", "way" },
            { "dia", "day" },
            { "cosa", "thing" },
            { "hombre", "man" },
            { "mundo", "world" },
            { "vida", "life" },
            { "mano", "hand" },
            { "parte", "part" },
            { "nino", "child" },
            { "ojo", "eye" },
            { "mujer", "woman" },
            { "lugar", "place" },
            { "trabajo", "work" },
            { "semana", "week" },
            { "caso", "case" },
            { "punto", "point" },
            { "gobierno", "government" },
            { "empresa", "company" }
        };
        int opcion = -1;
        // creacion menu principal
        while (opcion != 0)
        {
            System.Console.WriteLine("\n==================== MENU ====================");
            System.Console.WriteLine("1. Traducir una frase (Espanol → Ingles)");
            System.Console.WriteLine("2. Agregar palabras al diccionario");
            System.Console.WriteLine("0. Salir");
            System.Console.Write("Seleccione una opcion: ");

            // Se captura la opcion del usuario
            string entrada = System.Console.ReadLine();
            if (!int.TryParse(entrada, out opcion))
            {
                opcion = -1; // Si no es un numero valido se asigna -1
            }
            // Se valida la opcion ingresada
            // Opcion 1: traducir una frase
            if (opcion == 1)
            {
                System.Console.WriteLine("\nIngrese una frase en espanol:");
                string frase = System.Console.ReadLine();
                if (frase == null) frase = "";   // Evita errores de null
                frase = frase.ToLower();
                // Se separa la frase en palabras
                string[] palabras = frase.Split(' ');

                // Se recorre cada palabra para verificar si existe en el diccionario
                System.Console.WriteLine("\nTraduccion :");
                foreach (string p in palabras)
                {
                    // Se limpia la palabra de signos de puntuacion
                    string limpia = p.Trim('.', ',', ';', '!', '?');

                    // Si la palabra existe en el diccionario, se imprime la traduccion
                    if (diccionario.ContainsKey(limpia))
                    {
                        System.Console.Write(diccionario[limpia] + " ");
                    }
                    else
                    {
                        // Caso contrario, se deja igual
                        System.Console.Write(p + " ");
                    }
                }
                System.Console.WriteLine();
            }
            // Opcion 2: agregar nuevas palabras al diccionario
            else if (opcion == 2)
            {
                System.Console.Write("Ingrese la palabra en espanol: ");
                string espanol = System.Console.ReadLine();
                if (espanol == null) espanol = "";
                espanol = espanol.ToLower();

                System.Console.Write("Ingrese la traduccion en ingles: ");
                string ingles = System.Console.ReadLine();
                if (ingles == null) ingles = "";
                ingles = ingles.ToLower();

                // Se valida si la palabra ya existe en el diccionario
                if (!diccionario.ContainsKey(espanol))
                {
                    diccionario.Add(espanol, ingles);
                    System.Console.WriteLine("Palabra agregada correctamente.");
                }
                else
                {
                    System.Console.WriteLine("La palabra ya existe en el diccionario.");
                }
            }
            // Opcion 0: salir del programa
            else if (opcion == 0)
            {
                System.Console.WriteLine("Saliendo del traductor...");
            }
            // Cualquier otro valor es invalido
            else
            {
                System.Console.WriteLine("Opcion no valida.");
            }

        }
    }
}
