/*
cree una aplicativo de veterinaria
clases con propiedades: 
    Mascota: nombre, edad, especie
    Servicio: descripcion, precio
    Boleta: codigo, mascota, servicio1, servicio2, total

Use arreglos estáticos de las clases
Debe tener un menu con estas opciones:
- crear, eliminar, listar Servicios
- crear, eliminar, listar Mascotas
- crear, listar Boletas

Para crear boletas debe seleccionar la Mascota y el Servicio de 
sus respectivos arreglos

Divida entre sus integrantes, el lider consolida y los integrantes uno hace lo de servicios y el otro el de mascotas
Debe tener una rama por integrante, el lider debe tener por lo menos 2 ramas: main y dev. debe trabajar y consolidar en dev
*/



namespace veterinaria
{
    using veterinaria;
    public class Program
    {
        
        public static servicios[] ListaSer = new servicios[100];
        public static mascotas[] ListaMas = new mascotas[100];
        public static boleta[] ListaBol = new boleta[100];

        public static void Main(string[] args)
        {
            byte opcion;
            string regresar;

            do
            {
                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine("            VETERINARIA APLICATIVO \n");

                Console.WriteLine("********************* MENÚ **********************");

                Console.WriteLine("* 1. Crear, Eliminar, Listar Servicios          *");

                Console.WriteLine("* 2. Crear, Eliminar, listar Mascotas           *");

                Console.WriteLine("* 3. Crear, Listar Boleta                       *");

                Console.WriteLine("* 0. Salir                                      *");

                Console.WriteLine("**********************\n");



                Console.Write("Ingrese opcion: ");


                Console.ForegroundColor = ConsoleColor.Red;
                while (!byte.TryParse(Console.ReadLine(), out opcion) || opcion > 3)
                {

                    Console.Write("Error: Ingrese opcion: ");

                }

                Console.ForegroundColor = ConsoleColor.DarkCyan;

                switch (opcion)
                {

                    case 0: Environment.Exit(0); break;


                    case 1:; break;

                    case 2:; break;

                    case 3:; break;




                }

                Console.WriteLine("Desea regresar al menú? [si]: ");

                regresar = Console.ReadLine();


                Console.Clear();

            } while (regresar == "si");



        }
    }
}













