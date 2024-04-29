using System;
using ClubDomain;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\n");
        Console.WriteLine("   ======SOCIOS:=======");
        Socio socio1 = new Socio(" Baljeet", 4);
        Socio socio2 = new Socio(" Princesa", 8);
        Socio socio3 = new Socio(" Antony", 6);

        Club club = new Club(socio1, socio2, socio3);
        club.ImprimirSocioConMayorAntiguedad();
    }
}

