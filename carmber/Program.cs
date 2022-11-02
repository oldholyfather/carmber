using System;
using carmber;
namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            Vector3 vector = new Vector3(1, 2, 3);
            Cars lada = new Cars("lada", vector, 0101);
            lada.KeyValid(0101);
            lada.Start();
            lada.Move(new Vector3(5, 2, 7));
            lada.Move(new Vector3(5, 2, 7));
            Console.WriteLine(lada.GetInfo());

        }
    }
}