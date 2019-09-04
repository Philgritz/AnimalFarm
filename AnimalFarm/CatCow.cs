using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalFarm {
    class CatCow : ISpeak {

        ISpeak speak;

        public void Speak() {
            speak.Speak();
        }

        public CatCow(ISpeak speak) {
            this.speak = speak;
        }

    }
}
