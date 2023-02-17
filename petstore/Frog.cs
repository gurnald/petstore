using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petstore;
internal class Frog : ISpeakable {

    public string Name { get; set; }
    public void Speak() {
        Console.WriteLine($" {Name} Says Croak!");

    }
    public void EatYourOwnFly() {

    }

    public void JumpToYourLilyPad() {

    }
}


