using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petstore;
internal class Duck : ISpeakable {

    public string Name { get; set; }
    public void Speak() {
        Console.WriteLine($" {Name} Says Quack!");
        
    }
    
    public void GetOutOfTheRoad() {

    }

    public void DontPoopOnYourOwner() {

    }

}
