using System;

namespace Abstract_Siniflar
{
    public class Focus:IOtomobil
    {
        public Marka HangiMarkaninAraci()
        {
           return Marka.Ford;
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
