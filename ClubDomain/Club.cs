using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubDomain
{
    public  class Club
    {

        private Socio[] socios;

        public Club(Socio socio1, Socio socio2, Socio socio3)
        {
            socios = [socio1, socio2, socio3];
        }

        public void ImprimirSocioConMayorAntiguedad()
        {
            Socio socioConMayorAntiguedad = socios[0];

            foreach (Socio socio in socios)
            {
                if (socio.Antiguedad > socioConMayorAntiguedad.Antiguedad)
                {
                    socioConMayorAntiguedad = socio;
                }
            }

            Console.WriteLine("  El socio con mayor antigüedad en el club es: " + socioConMayorAntiguedad.Nombre);
        }
    }


}

