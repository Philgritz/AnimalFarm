using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalFarm.Sounds {
    class MeowMoo : ISpeak {

        public void Speak() {
            Console.WriteLine("MeowMoo!");
        }
    }
}
