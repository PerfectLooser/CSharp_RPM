using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

/*
 3 Вариант

Класс Ноутбук, имеющий поля модель, тактовая частота процессора, объем оперативной памяти, объем жесткого диска, масса и метод Info, выводящий информацию о ноутбуке в виде строки.
*/
namespace pr1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            NoteBooks NB = new NoteBooks();
            Console.WriteLine("Input Model Name");
            NB.model = Console.ReadLine();
            Console.WriteLine("Input Frequensy in GHz");
            NB.frequency = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input Active Memory Volume in MB");
            NB.opMemorySpace = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input Hard Drive Memory Volume in GB");
            NB.hardMemorySpace = Convert.ToDouble(Console.ReadLine());

            NB.Info();
            Console.ReadLine();
        
        }
        public class NoteBooks 
        {
            public string model = "Undef";
            public double frequency = 0.0;
            public int opMemorySpace = 0;
            public double hardMemorySpace = 0;
            public void Info ()
            {
                Console.WriteLine("Info of Note Book");
                Console.WriteLine(model+" Model");
                Console.WriteLine(frequency + " GHz");
                Console.WriteLine(opMemorySpace + " MB");
                Console.WriteLine(hardMemorySpace + " GB");
            }
        }
    }
}
