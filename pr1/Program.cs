using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace pr1
{
    internal class Program
    {
        static void Main(string[] args)
        {
          /* Firma a = new Firma();
            
            Console.WriteLine("Введите название фирмы");
            a.Name = Console.ReadLine();

            Otdel otd = new Otdel();

            Console.WriteLine("Введите название отдела");
            otd.OtdelName = Console.ReadLine();
            Console.WriteLine("Введите количество сотрудников");
            otd.Workercount = Convert.ToInt32(Console.ReadLine());*/

            StateWorker worker = new StateWorker();

            Console.WriteLine("Введите ФИО сотрудника");
            worker.FIO = Console.ReadLine();
            Console.WriteLine("Введите оклад сотрудника за месяц");
            worker.Paygrade = Convert.ToInt32(Console.ReadLine());
            worker.Paycount();


           /* OuterWorker outerWorker = new OuterWorker();

            Console.WriteLine("Введите ФИО сотрудника");
            outerWorker.FIO = Console.ReadLine();
            Console.WriteLine("Введите оклад сотрудника за месяц");
            outerWorker.Paygrade = Convert.ToInt32(Console.ReadLine());
            outerWorker.Paycount();*/
            Console.ReadLine();

        }
    }
        class Firma
        {
        private string _name;
        public string Name
            {
             
            set
            {
               _name = value;
            }
            get
            {
               return _name;
            }
        }
        public Firma() { }
        public Firma(string name)
        {
            _name = name;
        }
        }
        class Otdel
        {
        private string _otdelname;
        private int _workercount;
            public string OtdelName
            {
                get { return _otdelname; }
                set { _otdelname = value; }
            }
            public int Workercount
            {
                get { return _workercount; }
                set { _workercount = value; }
            }
        }
        class Worker
        {
        private string _fio;
        private string _position;
        private int _paygrade;
            public string FIO
            {
                get { return _fio; }
                set { _fio = value; }
            }
            public string Position
            {
                get { return _position; }
                set { _position = value; }
            }
            public int Paygrade
            {
                get { return _paygrade; }
                set { _paygrade = value; }
            }
            public void Paycount()
            {
                int mounthcount;
                Console.WriteLine("Введите количество  месяцев для расчета выплаты");
                mounthcount = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"Выплата сотруднику {_fio} составит {_paygrade * mounthcount}");
            }
            public Worker() {}

            public Worker (string fio, string position, int paygrade)
            {

                this.FIO = fio;
                this.Position = position;
                this.Paygrade = paygrade;
            }
        }
        class StateWorker : Worker
        {
            private string _fio;
            private string _position;
            private int _paygrade;
        private int _premy;
            public int Premy
            {
                get { return _premy; }
                set { _premy = value; }
            }
            new private void Paycount()
            {

            int mounthcount;
            int pay;
            try
            {
                Console.WriteLine("Введите количество  месяцев для расчета выплаты");
                mounthcount = Math.Abs(Convert.ToInt32(Console.ReadLine()));
                pay = mounthcount * _paygrade;
                Console.WriteLine(pay);
                if (pay > 0) { throw new PremiyaException("Выплата получилась отрицательной, проверь оклад и количество месяцев"); }
                else Console.WriteLine($"Выплата сотруднику {_fio} составит {pay}");
                
            }
            catch (PremiyaException ex) 
                {
                    Console.WriteLine(ex.ToString());
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.ToString());
                }
            }
        }
        class OuterWorker : Worker
        {
            private string _fio;
            private string _position;
            private int _paygrade;
        new private void Paycount()
        {

            int mounthcount;
            int pay;
            try
            {
                Console.WriteLine("Введите количество  месяцев для расчета выплаты");
                mounthcount = Math.Abs(Convert.ToInt32(Console.ReadLine()));
                pay = mounthcount* _paygrade;
                if (pay < 0) throw new PremiyaException("Выплата получилась отрицательной, проверь оклад и количество месяцев");
                Console.WriteLine($"Выплата сотруднику {_fio} составит {pay}");
            }
            catch (PremiyaException ex)
            {
                Console.WriteLine(ex.ToString());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
        class PremiyaException : Exception 
        {
            public PremiyaException(string message) : base(message)
            {
                
            }
        }
 }
