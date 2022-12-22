using System;

namespace Abstract_Siniflar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*****Focus******");
            Focus focus = new Focus();
            Console.WriteLine(focus.HangiMarkaninAraci().ToString());
            Console.WriteLine(focus.KacTekerlekOlusur().ToString());
            Console.WriteLine(focus.StandartRengiNe().ToString());

            Console.WriteLine("*****Civic*****");
            Civic civic = new Civic();
            Console.WriteLine(civic.HangiMarkaninAraci().ToString());
            Console.WriteLine(civic.KacTekerlekOlusur().ToString());
            Console.WriteLine(civic.StandartRengiNe().ToString());

            Console.WriteLine("*****Corolla*****");
            Corolla corolla=new Corolla();
            Console.WriteLine(corolla.HangiMarkaninAraci().ToString());
            Console.WriteLine(corolla.KacTekerlekOlusur().ToString());
            Console.WriteLine(corolla.StandartRengiNe().ToString());

            Console.WriteLine("*****YeniFocus******");
            yenifocus focus1 = new yenifocus();
            Console.WriteLine(focus1.HangiMarkaninAraci().ToString());
            Console.WriteLine(focus1.KacTekerlekOlusur().ToString());
            Console.WriteLine(focus1.StandartRengiNe().ToString());

            
            Console.WriteLine("*****YeniCivic*****");
            yenicivic civic1 = new yenicivic();
            Console.WriteLine(civic1.HangiMarkaninAraci().ToString());
            Console.WriteLine(civic1.KacTekerlekOlusur().ToString());
            Console.WriteLine(civic1.StandartRengiNe().ToString());

            Console.WriteLine("*****YeniCorolla*****");
            yenicorolla corolla1=new yenicorolla();
            Console.WriteLine(corolla1.HangiMarkaninAraci().ToString());
            Console.WriteLine(corolla1.KacTekerlekOlusur().ToString());
            Console.WriteLine(corolla1.StandartRengiNe().ToString());

        }
    }
}
