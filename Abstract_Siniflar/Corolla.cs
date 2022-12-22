using System;

namespace Abstract_Siniflar
{
    public class Corolla:IOtomobil
    {
       public Marka HangiMarkaninAraci()
        {
           return Marka.Toyota;
        }

        public int KacTekerlekOlusur()
        {
           return 4;
        }

        public Renk StandartRengiNe()
        {
           return Renk.Beyaz;
        }
    }
        
}