using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petstore;
internal class Dog : ISpeakable, INameable {

    public string Name { get; set; }

    public void Speak() {
        Console.WriteLine($" {Name} Says Bark!");
    }

    public void Sit() {

    }

    public void Fetch() {


    }
}
