using System;

namespace ConsoleApp
{
    class Transport
    {
        public string Name{get;set;}
        public int Year{get;set;}
        public int Speed{get;set;}
         public Transport(string name,int year,int speed)
        {
            Name=name;
        }
        }
    
    class Train:Transport
    {
         public Train(string name,int  year,int speed):base(name,year,speed)
         {
             Name =name;
             Year=year;
             Speed=speed;
         }
       public void GetInfo()
       {
          System.Console.WriteLine($"Название поезд:{Name}: Cкорость {Speed} км/ч: Год выпуск: {Year}"); 
       } 
    }
    class Car:Transport
    {
            public Car(string name,int year,int speed):base(name,year,speed)
            {}
        
    class PassengerCar:Car
    {
            public PassengerCar(string name,int year,int speed):base(name,year,speed)
        {
            Name=name;
            Year=year;
            Speed=speed;
        }
        public void GetInfo()
         {
          System.Console.WriteLine($"Название легковой автомобиль:{Name}: Cкорость {Speed} км/ч: Год выпуск: {Year}");    
         }
     }
    class CargoCar:Car
    {
        public string Capacity{get;set;} 
            public CargoCar(string name,int year,int speed,string capacity):base(name,year,speed)
        {
            Name=name;
            Year=year;
            Speed=speed;
         Capacity=capacity;

        }
        public void GetInfo()
         {
          System.Console.WriteLine($"Название грузовой автомобиль:{Name}: Cкорость {Speed} км/ч: Год выпуск: {Year}: Вместимостью от {Capacity} человек");    
         }
    }
    class  Airplane:Transport
    {
            public Airplane(string name,int year,int speed):base(name,year,speed)
        {
           
        }
    }
    class CargoAirPlane:Airplane
    {
        
            public CargoAirPlane(string name,int year,int speed):base(name,year,speed)
        {
            Name=name;
            Year=year;
            Speed=speed;
        }
        public void GetInfo()
         {
          System.Console.WriteLine($"Название грузовой самолет:{Name}: Cкорость {Speed} км/ч: Год выпуск: {Year}");    
         }
    }
    class PassengerAirPlane:Airplane
    {
        
            public PassengerAirPlane(string name,int year,int speed):base(name,year,speed)
        {
            Name=name;
            Year=year;
            Speed=speed;
        }
        public void GetInfo()
         {
          System.Console.WriteLine($"Название пассажирский самолет:{Name}: Cкорость {Speed} км/ч: Год выпуск: {Year}");    
         }
    }
    class Program
    {
        static void Main(string[] args)
        {
             Train tr=new Train("Train a Grande Vitesse",2013,500);
            tr.GetInfo();
            CargoCar c=new CargoCar("Gazella",2009,130,"2 до 8");
                 c.GetInfo();
                 PassengerCar pc= new PassengerCar("Volvo",1927,95);
                 pc.GetInfo();
              CargoAirPlane cp=new  CargoAirPlane("Ан-225",2002,500);
              cp.GetInfo();
              PassengerAirPlane pp=new PassengerAirPlane("Airbus A380",2005,400);
              pp.GetInfo();
        }
    }
}
}