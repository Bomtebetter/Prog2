using System;

namespace OOPIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            Animal Bengt = new Animal();
            Bengt._name = "Bengt";
            Bengt._species = "Parrot";
            Bengt._color = "red";

            Person Byotr = new Person("Byotr", 17, Bengt);
          
            

            Byotr.Eat();
            Byotr.Sleep();
            Byotr.ActivatePet();
            
        }
    }
}
