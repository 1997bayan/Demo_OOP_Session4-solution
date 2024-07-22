using Demo_OOP_Session4.Interfaces;
using Microsoft.VisualBasic;

namespace Demo_OOP_Session4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            MyType myTypeObject1= new MyType();
            myTypeObject1.Id = 1;
            myTypeObject1.MyFun(2);
            //myTypeObject1.print(); //Invalid

            IMyType myTypeObject2= new MyType();
            // Ref From Interface -> Object From Class Implement Interface
            myTypeObject2.Id = 2;
            myTypeObject2.MyFun(3);
            myTypeObject2.Print(); //VALID

        }
    }
}
