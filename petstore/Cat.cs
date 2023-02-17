using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petstore;
internal class Cat : ISpeakable {

    public string Name { get; set; }
    public void Speak() {
        Console.WriteLine($" {Name} Says Meow!");

    }
    public void DontPeeOnTheRug() {

    }

    public void DontScratchTheFurniture() {

    }
    public void CleanYourOwnLiterBox() {

    }
    
}
