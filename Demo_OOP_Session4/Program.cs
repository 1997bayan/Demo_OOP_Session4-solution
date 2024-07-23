using Demo_OOP_Session4.Interfaces;
using Microsoft.VisualBasic;

namespace Demo_OOP_Session4
{
    internal class Program
    {

        public static void Print10NumbersFromSeries(Iseries series)
        {
            if (series is not null)
            {
                for (int i = 0; i < 10; i++)
                {
                    Console.Write($"{series.current } ");
                    series.GetNext();
                }
                series.Reset();
            }
        }


        static void Main(string[] args)
            {

                #region Interface
                MyType myTypeObject1 = new MyType();
                myTypeObject1.Id = 1;
                myTypeObject1.MyFun(2);
                //myTypeObject1.print(); //Invalid

                IMyType myTypeObject2 = new MyType();
                // Ref From Interface -> Object From Class Implement Interface
                myTypeObject2.Id = 2;
                myTypeObject2.MyFun(3);
                myTypeObject2.Print(); //VALID 
                #endregion
                 Console.WriteLine("\n ============");

                #region Interface [Example 01]
                Iseries seriesBytwo = new SeriesByTwo();
                 Print10NumbersFromSeries(seriesBytwo);
                 Console.WriteLine("\n ============");

                 Iseries seriesBythree = new SeriesByThree();
                 Print10NumbersFromSeries(seriesBythree);

                Console.WriteLine("\n ============");


                Iseries seriesByFour = new SeriesByFour();
                Print10NumbersFromSeries(seriesByFour);




                 #endregion

            }

       
        
    }
}
