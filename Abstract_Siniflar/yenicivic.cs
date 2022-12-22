using System;

namespace Abstract_Siniflar
{
   public class yenicivic:Otomobil
   {
      public override Marka HangiMarkaninAraci()
      {
          return Marka.Honda;
      }

      public override Renk StandartRengiNe()
      {
         return Renk.Gri;
      }
   }

}
