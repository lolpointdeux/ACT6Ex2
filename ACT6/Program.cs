using System;

namespace ACT6
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Chien[] chiens = new Chien[] {
            new Chien ("Rex",new DateTime(2018, 1, 1),"123456",0.5,true),

            new Chien ("Fido",new DateTime(2019, 2, 2),"234567",1.0,false )};

            Chat[] chat = new Chat[] {
            new Chat ("Damien",new DateTime(2018, 1, 1),"123456",0.5,true),
            new Chat ("Arthur",new DateTime(2019, 2, 2),"234567",1.0,false ) };

            Lapin[] lapins = new Lapin[] {
            new Lapin ("Victotor",new DateTime(2018, 1, 1),"123456",0.5,4),
            new Lapin ("LeDam's",new DateTime(2019, 2, 2),"234567",1.0, 2 ) };

            
            Console.WriteLine(chiens);
            Console.WriteLine(chat);
            Console.WriteLine(lapins);

            Console.ReadLine();

            

        } 
    }
}




