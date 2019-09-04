using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalFarm {
    class Cow : ISpeak {          //impliments interface, must also impliment method

        ISpeak speak;

        public void Speak() {
            speak.Speak();              //speak variable calls speak
        }

        public Cow(ISpeak speak) {
            this.speak = speak;             //saves parameter into property
        }
    }
}
