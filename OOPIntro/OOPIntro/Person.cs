
using System;

namespace OOPIntro
{
    class Person
    {
        string _name;

        int _age;

        Animal _pet;

        public Person(String name, int age, Animal pet)
        {
            _name = name;
            _age = age;
            _pet = pet;
        }
        public void ActivatePet()
        {
            _pet.Dance();
        }

        public void Eat()
        {
            Console.WriteLine(_name + " goes nom nom nom");

        }
        public void Sleep()
        {
            Console.WriteLine(_name + " goes Zzz zzz");
        }
    }
}
