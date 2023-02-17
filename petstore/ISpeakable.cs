using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace petstore;
internal interface ISpeakable {


    public void Speak();

}


internal interface INameable {

    public string Name { get; set; }

}

internal interface IPet : INameable, ISpeakable {

}
