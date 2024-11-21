using veterinaria;

int respS;
int resp, resp1, resp2;
int posicion = 0;
mascota masc = new mascota();
boleta boleta = new boleta();
servicio serv = new servicio();
/*
do
{
    Console.WriteLine("¿Cuantos datos deseas ingresar?: ");
    respS = int.Parse(Console.ReadLine());


} while (respS <= 0);
/*
//Mascota
string[] arregloNombre = new string[respS];
int[] arregloEdad = new int[respS];
string[] arregloEspecie = new string[respS];
//Boleta
int[] arregloCodigo = new int[respS];
string[] arregloMascota = new string[respS];
string[] arregloServicio1 = new string[respS];
string[] arregloServicio2 = new string[respS];
double[] arregloTotal = new double[respS];
//servicio
string[] arregloDescripcion =new string[respS];
double[] aregloPrecio = new double[respS];
*/


do
{
    Console.WriteLine("");
    Console.WriteLine("\n**MENU**");
    Console.WriteLine("OPCION 1 [1]: ");
    Console.WriteLine("OPCION 2 [2]: ");
    Console.WriteLine("OPCION 3 [3]: ");
    Console.WriteLine("FIN [0]: ");
    Console.Write("\n¿Que opcion quieres ingresar?: ");
    resp = int.Parse(Console.ReadLine());



    switch (resp)
    {
        case 1:
            do
            {
                Console.WriteLine("\n**MENU**");
                Console.WriteLine("CREAR 1 [1]: ");
                Console.WriteLine("ELIMINAR 2 [2]: ");
                Console.WriteLine("LISTAR SERVICIOS 3 [3]: ");
                Console.WriteLine("VOLVER [0]: ");
                Console.Write("\nElegir opcion: ");
                resp1 = int.Parse(Console.ReadLine());
                switch (resp1)
                {
                    
                    case 1: break;
                    case 2: break;
                    case 3: break;
                }
            }while (resp1 < 0);
            break;
        case 2:
            for (int i = 0; i < posicion; i++)
            {
                Console.WriteLine("\n**MENU**");
                Console.WriteLine("CREAR [1]: ");
                Console.WriteLine("ELIMINAR [2]: ");
                Console.WriteLine("LISTAR MASCOTAS [3]: ");
                Console.WriteLine("VOLVER [4]: ");
                Console.Write("\nElegir opcion: ");
                resp2 = int.Parse(Console.ReadLine());
            }
                break;
        case 3:
            {

            }
            break;
        case 4:
            {

            }
            break;

    }

} while (resp != 4);
Console.ForegroundColor = ConsoleColor.Blue;
