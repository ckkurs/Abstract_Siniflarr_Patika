using System;

namespace Abstract_Siniflar
{

    public class Civic:IOtomobil
    {
          public Marka HangiMarkaninAraci()
        {
           return Marka.Honda;
        }

        public int KacTekerlekOlusur()
        {
           return 4;
        }

        public Renk StandartRengiNe()
        {
           return Renk.Gri;
        }
    }
      
}