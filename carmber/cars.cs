using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace carmber
{
    internal class Cars
    {
        public string Model;
        public int YearBuild;
        public const float MaxSpeed = 320;
        public int Run;
        public bool StartEngine;
        public Vector3 Position;
        public int Key;
        public int Rkey;
        public bool Rabit;
        public Cars()
        {
            Position = new Vector3();
            Model = "Неизвестно";
            YearBuild = 0000;
            Run = 0;
            StartEngine = false;
            Key = 0000;
            Rkey = 0000;
            Rabit = false;
        }
        public Cars(string model, Vector3 pos, int rkey)
        {
            Position = pos;
            Model = model;
            YearBuild = DateTime.Today.Year;
            Run = 0;
            StartEngine = false;
            Rkey = rkey;
        }
        public void KeyValid(int key)
        {
            if (key == Rkey)
            {
                Rabit = true;
                Console.WriteLine("ключ подошел:)");
            }
            else
            {
                Console.WriteLine("ключ не подошел:(");
            }

        }
        public void Start()
        {
            if (Rabit == true)
            {
                if (StartEngine == true)
                {
                    Console.WriteLine("Машина уже заведена");
                    return;
                }
                else
                {
                    Console.WriteLine($"Машина {Model} завелась");
                    StartEngine = true;
                }
            }
            else
            {
                Console.WriteLine("ключ не подходит:(");
            }
        }

        public void Off()
        {
            if (StartEngine == false)
            {
                return;
            }
            else if (StartEngine == false)
            {
                Console.WriteLine("Машина уже выключена");
            }
            else
            {
                Console.WriteLine($"Машина {Model} выключилась");
                StartEngine = false;
            }
        }

        public void Move(Vector3 vector)
        {
            if (!StartEngine) 
                return;
            Position.X += vector.X;
            Position.Y += vector.Y;
            Position.Z += vector.Z;
            Run++;
            Console.WriteLine($"Машина {Model} передвинулась на X: {Position.X}, Y: {Position.Y}, Z: {Position.Z}");
        }

        public string GetInfo() => $"Тачка {Model}. {YearBuild} - год производства. Двигатель {StartEngine}. Позиция = X: {Position.X}, Y: {Position.Y}, Z: {Position.Z}. Пробег = {Run}";
    }
}