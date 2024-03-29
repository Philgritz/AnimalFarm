﻿using System;
using AnimalFarm.Sounds;
using System.Collections.Generic;

namespace AnimalFarm {

    class Program { 
        static void Main(string[] args) {

            var cow = new Cow(new Moo());
            cow.Speak();
            var cat = new Cat(new Meow());
            cat.Speak();
            var catcow = new CatCow(new MeowMoo());
            catcow.Speak();

            var animals = new List<ISpeak>();                  //define collection, use interface as type
            animals.Add(cat);
            animals.Add(cow);
            animals.Add(catcow);

            foreach(var animal in animals) {
                animal.Speak();
            }

        }
    }
}
