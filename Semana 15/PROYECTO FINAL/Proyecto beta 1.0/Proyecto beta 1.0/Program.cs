// See https://aka.ms/new-console-template for more information
using Proyecto_beta_1._0;

Console.WriteLine("beta 1");


ID id = new();
mazos xc = new mazos();

int c = 1;
do
{
    Console.WriteLine("Ingrese 1 para jugador 1 y 2 para jugar 2, cualquier otro para continuar");

    int v = int.TryParse(Console.ReadLine(), out v) ? v : 0;

    switch (v)
    {
        case 1:
            Console.WriteLine("Ingrese su nombre");
            id.Jugador1 = Console.ReadLine();
            Console.WriteLine("Ingrese su equipo");
            id.Equipo1 = Console.ReadLine();

            // Mostrar las iniciales
            Console.WriteLine("Las iniciales del equipo son: " + id.crearID1());
            break;

        case 2:
            Console.WriteLine("Ingrese su nombre");
            id.Jugador2 = Console.ReadLine();
            Console.WriteLine("Ingrese su equipo");
            id.Equipo2 = Console.ReadLine();


            // Mostrar las iniciales
            Console.WriteLine("Las iniciales del equipo son: " + id.crearID2());



            break;
        default:
            c = 2;
            break; 

    }
} while (c == 1);

Console.Clear();
Console.WriteLine("Jugador 1 " + id.crearID1());
Console.WriteLine("Jugador 2 " + id.crearID2());

Console.WriteLine("Los mazos a elegir son: ");
Console.WriteLine();
xc.ImprimirMazo1();
Console.WriteLine();
xc.ImprimirMazo2();
Console.WriteLine();
xc.ImprimirMazo3();
Console.WriteLine();
xc.ImprimirMazo4(); 
Console.WriteLine();

Console.ReadKey();
Console.Clear();

Console.WriteLine("Jugador 1 " + id.crearID1());
Console.WriteLine("Jugador 2 " + id.crearID2());
int zz, zzz;
int p = 1;
do
{
    Console.WriteLine("Ingrese 1 para jugador 1 y 2 para jugar 2, cualquier otro para continuar");
    int v = int.TryParse(Console.ReadLine(), out v) ? v : 0;
    switch (v)
    {
        case 1:
            Console.WriteLine("Ingrese el numero del 1 - 4 para elegir un mazo");

           
            int j = 1, o;
            do
            {
                int l = int.TryParse(Console.ReadLine(), out l) ? l : 0;
                switch (l)
                {
                    case 1:
                        Console.WriteLine("Mazos 1 ");
                        xc.mazo1();
                        xc.ImprimirMazo1();
                        zz= 1;
                        id.Mazoelejido1 = zz;
                        break;
                    case 2:
                        Console.WriteLine("Mazos 2 ");
                        xc.mazo2();
                        xc.ImprimirMazo2();
                        zz= 2;
                        id.Mazoelejido1 = zz;
                        break;

                    case 3:
                        Console.WriteLine("Mazos 3");
                        xc.mazo3();
                        xc.ImprimirMazo3();
                        zz= 3;
                        id.Mazoelejido1 = zz;
                        break;

                    case 4:
                        Console.WriteLine("Mazos 4");
                        xc.mazo4();
                        xc.ImprimirMazo4();
                        zz= 4;
                        id.Mazoelejido1 = zz;
                        break;

                    default:
                        Console.WriteLine("Para volver ingrese 1");
                        o = int.TryParse(Console.ReadLine(), out o) ? o : 0;
                        if (o == 1)
                        {
                            Console.WriteLine("Volviendo");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Volvera a elejir a seleccionar que jugar elejira mazo");
                            j = 0;
                        }
                        break;
                }
            } while (j == 1);
            

            break;

         case 2:
            Console.WriteLine("Ingrese el numero del 1 - 4 para elegir un mazo");

            
            int y = 1, u;
            do
            {
                int z = int.TryParse(Console.ReadLine(), out z) ? z : 0;
                switch (z)
                {
                    case 1:
                        Console.WriteLine("Mazos 1 ");
                        xc.mazo1();
                        xc.ImprimirMazo1();
                        zzz= 1;
                        id.Mazoelejido2 = zzz;
                        break;
                    case 2:
                        Console.WriteLine("Mazos 2 ");
                        xc.mazo2();
                        xc.ImprimirMazo2();
                        zzz= 2;
                        id.Mazoelejido2 = zzz;
                        break;

                    case 3:
                        Console.WriteLine("Mazos 3");
                        xc.mazo3();
                        xc.ImprimirMazo3();
                        zzz= 3;
                        id.Mazoelejido2 = zzz;
                        break;

                    case 4:
                        Console.WriteLine("Mazos 4");
                        xc.mazo4();
                        xc.ImprimirMazo4();
                        zzz= 4;
                        id.Mazoelejido2 = zzz;
                        break;

                    default:
                        Console.WriteLine("Para volver ingrese 1");
                        u = int.TryParse(Console.ReadLine(), out u) ? u : 0;
                        if (u == 1)
                        {
                            Console.WriteLine("Volviendo");
                            Console.ReadKey();
                        }
                        else
                        {
                            Console.WriteLine("Volvera a elejir a seleccionar que jugar elejira mazo");
                            y = 0;
                        }
                        break;
                } 
            } while (y == 1);
            break;

         default:
            Console.WriteLine("Para volver ingrese 1  para seleccionar que jugar elejira mazo");
            o = int.TryParse(Console.ReadLine(), out o) ? o : 0;
            if (o == 1)
            {
                Console.WriteLine("Volviendo");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Pasara a la siguiente parte");
                p = 0;
            }
            
            break;

    }
} while (p== 1);


int melejido1, melejido2;


Random rnd = new Random();
int cpr = rnd.Next(1, 3);


if (id.Mazoelejido1 == 1 && id.Mazoelejido2 == 2 )
{
    switch (cpr)
    {
        case 1:
            if (xc.Vida1 > xc.Vida3)
            {
                Console.WriteLine("Gana Mazo 1 \n" + "Gana " + id.crearID1());
                Console.ReadKey();
            }
            else 
            {
                Console.WriteLine("Gana mazo 2 \n" + "Gana " + id.crearID2());
            }
            break;
            case 2:
            if (xc.Ataque1 > xc.Ataque2)
            {
                Console.WriteLine("Gana Mazo 1 \n" + "Gana " + id.crearID1());

                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Gana mazo 2\n" + "Gana " + id.crearID2());
            }
            break;
            default:
            if (xc.Elexir2 > xc.Elexir1)
            {
                Console.WriteLine("Gana Mazo 1 \n" + "Gana " + id.crearID1());
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Gana mazo 2\n" + "Gana " + id.crearID2());
            }
            break;


    }
}
else if (id.Mazoelejido1 == 1 && id.Mazoelejido2 == 3)
{
    switch (cpr)
    {
        case 1:
            if (xc.Vida1 > xc.Vida3)
            {
                Console.WriteLine("Gana Mazo 1 \n" + "Gana " + id.crearID1());
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Gana mazo 3 \n" + "Gana " + id.crearID2());
            }
            break;
        case 2:
            if (xc.Ataque1 > xc.Ataque3)
            {
                Console.WriteLine("Gana Mazo 1 \n" + "Gana " + id.crearID1());

                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Gana mazo 3 \n" + "Gana " + id.crearID2());
            }
            break;
        default:
            if (xc.Elexir3 > xc.Elexir1)
            {
                Console.WriteLine("Gana Mazo 1 \n" + "Gana " + id.crearID1());
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Gana mazo 3 \n" + "Gana " + id.crearID2());
            }
            break;
    }

}
else if (id.Mazoelejido1 == 1 && id.Mazoelejido2 == 4)
{
    switch (cpr)
    {
        case 1:
            if (xc.Vida1 > xc.Vida4)
            {
                Console.WriteLine("Gana Mazo 1 \n" + "Gana " + id.crearID1());
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Gana mazo 4 \n" + "Gana " + id.crearID2());
            }
            break;
        case 2:
            if (xc.Ataque1 > xc.Ataque4)
            {
                Console.WriteLine("Gana Mazo 1 \n" + "Gana " + id.crearID1());

                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Gana mazo 4 \n" + "Gana " + id.crearID2());
            }
            break;
        default:
            if (xc.Elexir4 > xc.Elexir1)
            {
                Console.WriteLine("Gana Mazo 1 \n" + "Gana " + id.crearID1());
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Gana mazo 4 \n" + "Gana " + id.crearID2());
            }
            break;
    }

}
else if (id.Mazoelejido1 == 2 && id.Mazoelejido2 == 1)
{
    switch (cpr)
    {
        case 1:
            if (xc.Vida2 > xc.Vida1)
            {
                Console.WriteLine("Gana Mazo 2 \n" + "Gana " + id.crearID1());
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Gana mazo 1 \n" + "Gana " + id.crearID2());
            }
            break;
        case 2:
            if (xc.Ataque2 > xc.Ataque1)
            {
                Console.WriteLine("Gana Mazo 2 \n" + "Gana " + id.crearID1());

                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Gana mazo 1 \n" + "Gana " + id.crearID2());
            }
            break;
        default:
            if (xc.Elexir1 > xc.Elexir2)
            {
                Console.WriteLine("Gana Mazo 2 \n" + "Gana " + id.crearID1());
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Gana mazo 1 \n" + "Gana " + id.crearID2());
            }
            break;
    }

}
else if (id.Mazoelejido1 == 2 && id.Mazoelejido2 == 3)
{
    switch (cpr)
    {
        case 1:
            if (xc.Vida2 > xc.Vida3)
            {
                Console.WriteLine("Gana Mazo 2 \n" + "Gana " + id.crearID1());
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Gana mazo 3 \n" + "Gana " + id.crearID2());
            }
            break;
        case 2:
            if (xc.Ataque2 > xc.Ataque3)
            {
                Console.WriteLine("Gana Mazo 2 \n" + "Gana " + id.crearID1());

                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Gana mazo 3 \n" + "Gana " + id.crearID2());
            }
            break;
        default:
            if (xc.Elexir3 > xc.Elexir2)
            {
                Console.WriteLine("Gana Mazo 2 \n" + "Gana " + id.crearID1());
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Gana mazo 3 \n" + "Gana " + id.crearID2());
            }
            break;
    }

}
else if (id.Mazoelejido1 == 2 && id.Mazoelejido2 == 4)
{
    switch (cpr)
    {
        case 1:
            if (xc.Vida2 > xc.Vida4)
            {
                Console.WriteLine("Gana Mazo 2 \n" + "Gana " + id.crearID1());
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Gana mazo 4 \n" + "Gana " + id.crearID2());
            }
            break;
        case 2:
            if (xc.Ataque1 > xc.Ataque3)
            {
                Console.WriteLine("Gana Mazo 2 \n" + "Gana " + id.crearID1());

                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Gana mazo 4 \n" + "Gana " + id.crearID2());
            }
            break;
        default:
            if (xc.Elexir3 > xc.Elexir1)
            {
                Console.WriteLine("Gana Mazo 2 \n" + "Gana " + id.crearID1());
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Gana mazo 4 \n" + "Gana " + id.crearID2());
            }
            break;
    }

}
else if (id.Mazoelejido1 == 3 && id.Mazoelejido2 == 1)
{
    switch (cpr)
    {
        case 1:
            if (xc.Vida3 > xc.Vida1)
            {
                Console.WriteLine("Gana Mazo 3 \n" + "Gana " + id.crearID1());
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Gana mazo 1 \n" + "Gana " + id.crearID2());
            }
            break;
        case 2:
            if (xc.Ataque3 > xc.Ataque1)
            {
                Console.WriteLine("Gana Mazo 3 \n" + "Gana " + id.crearID1());

                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Gana mazo 1 \n" + "Gana " + id.crearID2());
            }
            break;
        default:
            if (xc.Elexir1 > xc.Elexir3)
            {
                Console.WriteLine("Gana Mazo 3 \n" + "Gana " + id.crearID1());
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Gana mazo 1 \n" + "Gana " + id.crearID2());
            }
            break;
    }
}
else if (id.Mazoelejido1 == 3 && id.Mazoelejido2 == 2)
{
    switch (cpr)
    {
        case 1:
            if (xc.Vida3 > xc.Vida2)
            {
                Console.WriteLine("Gana Mazo 3 \n" + "Gana " + id.crearID1());
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Gana mazo 2 \n" + "Gana " + id.crearID2());
            }
            break;
        case 2:
            if (xc.Ataque3 > xc.Ataque2)
            {
                Console.WriteLine("Gana Mazo 3 \n" + "Gana " + id.crearID1());

                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Gana mazo 2 \n" + "Gana " + id.crearID2());
            }
            break;
        default:
            if (xc.Elexir2 > xc.Elexir3)
            {
                Console.WriteLine("Gana Mazo 3 \n" + "Gana " + id.crearID1());
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Gana mazo 2 \n" + "Gana " + id.crearID2());
            }
            break;
    }
}
else if (id.Mazoelejido1 == 3 && id.Mazoelejido2 == 4)
{
    switch (cpr)
    {
        case 1:
            if (xc.Vida3 > xc.Vida3)
            {
                Console.WriteLine("Gana Mazo 3 \n" + "Gana " + id.crearID1());
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Gana mazo 4 \n" + "Gana " + id.crearID2());
            }
            break;
        case 2:
            if (xc.Ataque3 > xc.Ataque4)
            {
                Console.WriteLine("Gana Mazo 3 \n" + "Gana " + id.crearID1());

                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Gana mazo 4 \n" + "Gana " + id.crearID2());
            }
            break;
        default:
            if (xc.Elexir4 > xc.Elexir3)
            {
                Console.WriteLine("Gana Mazo 3 \n" + "Gana " + id.crearID1());
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Gana mazo 4 \n" + "Gana " + id.crearID2());
            }
            break;
    }
}
else if (id.Mazoelejido1 == 4 && id.Mazoelejido2 == 1)
{
    switch (cpr)
    {
        case 1:
            if (xc.Vida4 > xc.Vida1)
            {
                Console.WriteLine("Gana Mazo 4 \n" + "Gana " + id.crearID1());
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Gana mazo 1 \n" + "Gana " + id.crearID2());
            }
            break;
        case 2:
            if (xc.Ataque4 > xc.Ataque1)
            {
                Console.WriteLine("Gana Mazo 4 \n" + "Gana " + id.crearID1());

                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Gana mazo 1 \n" + "Gana " + id.crearID2());
            }
            break;
        default:
            if (xc.Elexir1 > xc.Elexir4)
            {
                Console.WriteLine("Gana Mazo 4 \n" + "Gana " + id.crearID1());
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Gana mazo 1 \n" + "Gana " + id.crearID2());
            }
            break;
    }
}
else if (id.Mazoelejido1 == 4 && id.Mazoelejido2 == 2)
{
    switch (cpr)
    {
        case 1:
            if (xc.Vida4 > xc.Vida2)
            {
                Console.WriteLine("Gana Mazo 4 \n" + "Gana " + id.crearID1());
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Gana mazo 2 \n" + "Gana " + id.crearID2());
            }
            break;
        case 2:
            if (xc.Ataque4 > xc.Ataque2)
            {
                Console.WriteLine("Gana Mazo 4 \n" + "Gana " + id.crearID1());

                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Gana mazo 2 \n" + "Gana " + id.crearID2());
            }
            break;
        default:
            if (xc.Elexir2 > xc.Elexir4)
            {
                Console.WriteLine("Gana Mazo 4 \n" + "Gana " + id.crearID1());
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Gana mazo 2 \n" + "Gana " + id.crearID2());
            }
            break;
    }
}
else if (id.Mazoelejido1 == 4 && id.Mazoelejido2 == 3)
{
    switch (cpr)
    {
        case 1:
            if (xc.Vida4 > xc.Vida3)
            {
                Console.WriteLine("Gana Mazo 4 \n" + "Gana " + id.crearID1());
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Gana mazo 3 \n" + "Gana " + id.crearID2());
            }
            break;
        case 2:
            if (xc.Ataque4 > xc.Ataque3)
            {
                Console.WriteLine("Gana Mazo 4 \n" + "Gana " + id.crearID1());

                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Gana mazo 3 \n" + "Gana " + id.crearID2());
            }
            break;
        default:
            if (xc.Elexir3 > xc.Elexir4)
            {
                Console.WriteLine("Gana Mazo 4 \n" + "Gana " + id.crearID1());
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Gana mazo 3 \n" + "Gana " + id.crearID2());
            }
            break;
    }
}



Console.WriteLine("Fin");
