using System.Linq;

namespace Lezione1.VariabiliCostrutti
{
    internal class Program
    {
        //costruttore di default
        //public Program()
        //{

        //}

        static void Main(string[] args)
        {
//Tour C#
//https://learn.microsoft.com/it-it/dotnet/csharp/tour-of-csharp/
            int numero = 3; //byte, short, long
            //tutte le variabili possono essere signed e unsigned
            //quelle unsigned hanno la u davanti e accettano
            //solo numeri positivi
            float numeroDecimaleFloat = 4.0f;
            decimal numeroDecimaleDecimal = 10.0m;
            double numeroDecimaleDouble = 6.7;
            var x = 4;
            int? interoNullable = null;
            Nullable<int> interoNullableInt = null;
            //interoNullable. primitiva
            //interoNullableInt. oggetto
            if (interoNullable!=null)
            {
                //interoNullable = interoNullable.Value;
            }
            var y = 5.0f;
            var z = 10.1m;
            var w = 8.5;
            var ws = "ciao"; //string->primitiva - String->classe entrambe sono un array di char
            var charWS = ws[0]; //ottengo il primo carattere
            var charA = 'n'; //char
            ws = ws + 5;
            int p = (int)numeroDecimaleDouble; //cast esplicito -> troncamento della parte decimale
            //passando con un cast da int a double realizzo un completamento
            w = 7;
            Console.WriteLine($"Hello World! Salvo {numero} {numeroDecimaleDecimal} {p} {ws} {w}");
            //Console.ReadLine(); //prendo una stringa da tastiera
            //Console.ReadKey().KeyChar; //prendo una carattere da tastiera
            var somma = 0;
            //costrutti

            if (p == 0)
            {
                //fai qualcosa
            }
            else if (p > 0)
            {
                //fai altro 1
            }
            else
            {
                // fai altro altrimenti
            }


            for (int i = 1; i <= 100; i++)
            {
                somma += i;
            }
            Console.WriteLine(somma);
            somma = 0;
            //var i = 0;
            //while (true)
            //{
            //    i++;
            //    somma += i;
            //    if (i == 100) 
            //        break;
            //}

            //do
            //{

            //} while (true);

            //il foreach non permette di cambiare la dimensione della collection
            //che stiamo navigando
            foreach (var carattere in ws)
            {
                Console.WriteLine(carattere);
            }

            var list = new List<int>() { 3, 6, 8, 0, 1 };
            //metodi che modificano la dimensione della lista
            list.Add(10); //3, 6, 8, 0, 1 ,new 10
            list.Insert(2, 23);  //3, 6, new 23, 8, 0, 1 ,10
            list.Remove(3); //6, new 23, 8, 0, 1 ,10
            //list.RemoveAll(t=>t>10);
            //list.RemoveAt(6); //darebbe errore, non c'è la posizione 6
            //list.Sort(); ordinare la lista con il metodo di List
            var list1 = list.OrderBy(t => t); //ordina la lista con System.Linq
            var sum = list1.Sum();
            foreach (var item in list)
            {
                Console.Write(item + "\t");

            }


        }


    }

}