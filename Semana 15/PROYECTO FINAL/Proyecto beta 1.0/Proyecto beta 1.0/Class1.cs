using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_beta_1._0
{

    class ID
    {
        string equipo1;
        string jugador1;
        string equipo2;
        string jugador2;
        string nick1;
        string nick2;
        int mazoelejido1, mazoelejido2;

        public string Equipo1 { get => equipo1; set => equipo1 = value; }
        public string Jugador1 { get => jugador1; set => jugador1 = value; }
        public string Jugador2 { get => jugador2; set => jugador2 = value; }
        public string Equipo2 { get => equipo2; set => equipo2 = value; }
        public int Mazoelejido1 { get => mazoelejido1; set => mazoelejido1 = value; }
        public int Mazoelejido2 { get => mazoelejido2; set => mazoelejido2 = value; }

        public string crearID1()
        {
            // Obtiene las iniciales del equipo 1
            string inicial1 = Equipo1.Substring(0, 1);
            string inicial2 = Equipo1.Substring(Equipo1.IndexOf(' ') + 1, 1);

            // Genera el identificador para el jugador 1
            nick1 = inicial1 + inicial2 + "-" + Jugador1 + (Jugador1.Length - 1).ToString() + Jugador1.IndexOf(Jugador1[0]).ToString();

            // Devuelve el identificador generado
            return nick1;
        }

        public string crearID2()
        {
            // Obtener las iniciales del equipo 2
            string inicial12 = Equipo2.Substring(0, 1);
            string inicial22 = Equipo2.Substring(Equipo2.IndexOf(' ') + 1, 1);

            nick2 = inicial12 + inicial22 + "-" + Jugador2 + (Jugador2.Length - 1).ToString() + Jugador2.IndexOf(Jugador2[0]).ToString();

            return nick2;
        }

    }
    internal class mazos
    {
        private string carta1, carta2, carta3, carta4, carta5, carta6, carta7, carta8;
        private int vida1, ataque1;
        private double elexir1;

        public string Carta1 { get => carta1; set => carta1 = value; }
        public string Carta2 { get => carta2; set => carta2 = value; }
        public string Carta3 { get => carta3; set => carta3 = value; }
        public string Carta4 { get => carta4; set => carta4 = value; }
        public string Carta5 { get => carta5; set => carta5 = value; }
        public string Carta6 { get => carta6; set => carta6 = value; }
        public string Carta7 { get => carta7; set => carta7 = value; }
        public string Carta8 { get => carta8; set => carta8 = value; }

        public void mazo1()
        {
            Carta1 = "Esqueletos";
            Carta2 = "Mosquetera";
            Carta3 = "Monta Puercos";
            Carta4 = "Espiritu de hielo";
            Carta5 = "Golem de hielo";
            Carta6 = "Cañon";
            Carta7 = "Bola de fuego";
            Carta8 = "Tronco";

            Ataque1 = 2164;
            Vida1 = 4919;
            Elexir1 = 2.6;



        }
        public void ImprimirMazo1()
        {
            for (int i = 0; i < 8; i++)
            {
                switch (i)
                {
                    case 0:
                        Console.WriteLine("Carta " + (i + 1) + ": " + Carta1);
                        break;
                    case 1:
                        Console.WriteLine("Carta " + (i + 1) + ": " + Carta2);
                        break;
                    case 2:
                        Console.WriteLine("Carta " + (i + 1) + ": " + Carta3);
                        break;
                    case 3:
                        Console.WriteLine("Carta " + (i + 1) + ": " + Carta4);
                        break;
                    case 4:
                        Console.WriteLine("Carta " + (i + 1) + ": " + Carta5);
                        break;
                    case 5:
                        Console.WriteLine("Carta " + (i + 1) + ": " + Carta6);
                        break;
                    case 6:
                        Console.WriteLine("Carta " + (i + 1) + ": " + Carta7);
                        break;
                    case 7:
                        Console.WriteLine("Carta " + (i + 1) + ": " + Carta8);
                        break;
                }
            }
        }
        private string carta12, carta22, carta32, carta42, carta52, carta62, carta72, carta82;
        private int vida2, ataque2;
        private double elexir2;
        public string Carta12 { get => carta12; set => carta12 = value; }
        public string Carta22 { get => carta22; set => carta22 = value; }
        public string Carta32 { get => carta32; set => carta32 = value; }
        public string Carta42 { get => carta42; set => carta42 = value; }
        public string Carta52 { get => carta52; set => carta52 = value; }
        public string Carta62 { get => carta62; set => carta62 = value; }
        public string Carta72 { get => carta72; set => carta72 = value; }
        public string Carta82 { get => carta82; set => carta82 = value; }

        public void mazo2()
        {
            Carta12 = "Arqueras";
            Carta22 = "Gigante";
            Carta32 = "Ejercito de esqueletos";
            Carta42 = "bebé dragon";
            Carta52 = "principe";
            Carta62 = "mini pekka";
            Carta72 = "Duendes con lanza";
            Carta82 = "Mortero";


            Ataque2 = 3302;
            Vida2 = 11849;
            Elexir2 = 2.64;

        }
        public void ImprimirMazo2()
        {
            for (int i = 0; i < 8; i++)
            {
                switch (i)
                {
                    case 0:
                        Console.WriteLine("Carta " + (i + 1) + ": " + Carta12);
                        break;
                    case 1:
                        Console.WriteLine("Carta " + (i + 1) + ": " + Carta22);
                        break;
                    case 2:
                        Console.WriteLine("Carta " + (i + 1) + ": " + Carta32);
                        break;
                    case 3:
                        Console.WriteLine("Carta " + (i + 1) + ": " + Carta42);
                        break;
                    case 4:
                        Console.WriteLine("Carta " + (i + 1) + ": " + Carta52);
                        break;
                    case 5:
                        Console.WriteLine("Carta " + (i + 1) + ": " + Carta62);
                        break;
                    case 6:
                        Console.WriteLine("Carta " + (i + 1) + ": " + Carta72);
                        break;
                    case 7:
                        Console.WriteLine("Carta " + (i + 1) + ": " + Carta82);
                        break;
                }
            }
        }

        private string carta13, carta23, carta33, carta43, carta53, carta63, carta73, carta83;
        private int vida3, ataque3;
        private double elexir3;

        public string Carta13 { get => carta13; set => carta13 = value; }
        public string Carta23 { get => carta23; set => carta23 = value; }
        public string Carta33 { get => carta33; set => carta33 = value; }
        public string Carta43 { get => carta43; set => carta43 = value; }
        public string Carta53 { get => carta53; set => carta53 = value; }
        public string Carta63 { get => carta63; set => carta63 = value; }
        public string Carta73 { get => carta73; set => carta73 = value; }
        public string Carta83 { get => carta83; set => carta83 = value; }

        public void mazo3()
        {
            Carta13 = " Arqueras";
            Carta23 = " Esqueletos";
            Carta33 = "Espiritu de hielo";
            Carta43 = " Golem de hielo";
            Carta53 = " Torre Tesla";
            Carta63 = " Ballesta";
            Carta73 = " Bola de fuego";
            Carta83 = "Tronco";


            Ataque3 = 1901;
            Vida3 = 5039;
            Elexir3 = 2.8;

        }
        public void ImprimirMazo3()
        {
            for (int i = 0; i < 8; i++)
            {
                switch (i)
                {
                    case 0:
                        Console.WriteLine("Carta " + (i + 1) + ": " + Carta13);
                        break;
                    case 1:
                        Console.WriteLine("Carta " + (i + 1) + ": " + Carta23);
                        break;
                    case 2:
                        Console.WriteLine("Carta " + (i + 1) + ": " + Carta33);
                        break;
                    case 3:
                        Console.WriteLine("Carta " + (i + 1) + ": " + Carta43);
                        break;
                    case 4:
                        Console.WriteLine("Carta " + (i + 1) + ": " + Carta53);
                        break;
                    case 5:
                        Console.WriteLine("Carta " + (i + 1) + ": " + Carta63);
                        break;
                    case 6:
                        Console.WriteLine("Carta " + (i + 1) + ": " + Carta73);
                        break;
                    case 7:
                        Console.WriteLine("Carta " + (i + 1) + ": " + Carta83);
                        break;
                }
            }
        }
        private string carta14, carta24, carta34, carta44, carta54, carta64, carta74, carta84;
        private int vida4, ataque4;
        private double elexir4;


        public string Carta14 { get => carta14; set => carta14 = value; }
        public string Carta24 { get => carta24; set => carta24 = value; }
        public string Carta34 { get => carta34; set => carta34 = value; }
        public string Carta44 { get => carta44; set => carta44 = value; }
        public string Carta54 { get => carta54; set => carta54 = value; }
        public string Carta64 { get => carta64; set => carta64 = value; }
        public string Carta74 { get => carta74; set => carta74 = value; }
        public string Carta84 { get => carta84; set => carta84 = value; }
        public int Vida1 { get => vida1; set => vida1 = value; }
        public int Ataque1 { get => ataque1; set => ataque1 = value; }
        public double Elexir1 { get => elexir1; set => elexir1 = value; }
        public int Vida2 { get => vida2; set => vida2 = value; }
        public int Ataque2 { get => ataque2; set => ataque2 = value; }
        public double Elexir2 { get => elexir2; set => elexir2 = value; }
        public int Vida3 { get => vida3; set => vida3 = value; }
        public int Ataque3 { get => ataque3; set => ataque3 = value; }
        public double Elexir3 { get => elexir3; set => elexir3 = value; }
        public int Vida4 { get => vida4; set => vida4 = value; }
        public int Ataque4 { get => ataque4; set => ataque4 = value; }
        public double Elexir4 { get => elexir4; set => elexir4 = value; }

        public void mazo4()
        {


            Carta14 = "Caballero";
            Carta24 = "Princesa";
            Carta34 = "Espiritu de hielo";
            Carta44 = "Pandilla";
            Carta54 = "Torre infernal";
            Carta64 = "Cohete";
            Carta74 = "Barril de duendes";
            Carta84 = "Tronco";

            Ataque4 = 3663;
            Vida4 = 5617;
            Elexir4 = 3.3;

        }
        public void ImprimirMazo4()
        {
            for (int i = 0; i < 8; i++)
            {
                switch (i)
                {
                    case 0:
                        Console.WriteLine("Carta " + (i + 1) + ": " + Carta14);
                        break;
                    case 1:
                        Console.WriteLine("Carta " + (i + 1) + ": " + Carta24);
                        break;
                    case 2:
                        Console.WriteLine("Carta " + (i + 1) + ": " + Carta34);
                        break;
                    case 3:
                        Console.WriteLine("Carta " + (i + 1) + ": " + Carta44);
                        break;
                    case 4:
                        Console.WriteLine("Carta " + (i + 1) + ": " + Carta54);
                        break;
                    case 5:
                        Console.WriteLine("Carta " + (i + 1) + ": " + Carta64);
                        break;
                    case 6:
                        Console.WriteLine("Carta " + (i + 1) + ": " + Carta74);
                        break;
                    case 7:
                        Console.WriteLine("Carta " + (i + 1) + ": " + Carta84);
                        break;
                }
            }
        } 
    }
}

