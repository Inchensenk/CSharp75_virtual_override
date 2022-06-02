using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//https://www.youtube.com/watch?v=xH61vpBebjw

/*
 * Полиморфизм это интструмент в ООП, который может использоваться при наследовании
 * 
 * С помощью ключевых слов virtual и override можно переопределить работу метода
 * в классе наследнике и он будет вести себя по другому
 * 
 * Ссылка у которой тип базового класса может хранить объекты классов насследников.
 * (Таким образом, если мы обьявим переменную типа Car мы без проблем можем присвоить туда тип SportCar)
 * 
 * Метод Drive у класса SportCar может быть реализщован несколько иначе, нежели у класса Car
 * (Допустим спорткар не просто едет, а едет очень быстро)
 * 
 * Для того чтобы иметь возможность переопределить какой-то метод который находится в 
 * базовом классе, у этого метода должен быть модификатор доступа virtual.
 * 
 * Для того чтобы в классе наследнике сделать новую реализацию (переопределить метод
 * базового класса) нам нужно использовать ключевое слово override
 * 
 * Если в классе наследнике только начать печатать ключевое слово override
 * и поставить после него пробел, то VS подскажет какие методы базового класса 
 * в классе наследнике мы можем переопределить
 * 
 * Если не указывать ключевые слова virtual и override то переопределение метода 
 * не произойдет, а будет вызываться метод базового класса.
 */

namespace CSharp75_virtual_override
{

    class Car
    {
        protected virtual void StartEngine()
        {
            Console.WriteLine("Двигатель запущен!");
        }
        public virtual void Drive()
        {
            StartEngine();
            Console.WriteLine("Я машина, я еду!");
        }
    }

 
    class SportCar : Car
    {
        protected override void StartEngine()
        {
            Console.WriteLine("Рон Дон Дон!");
        }
        public override void Drive()
        {
            StartEngine();
            Console.WriteLine("Я еду очень быстро!");
        }
    }

    class Person
    {
        public void Drive(Car car)
        {
            car.Drive();
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {            
            Person person = new Person();

            person.Drive(new Car());
        }
    }
}
