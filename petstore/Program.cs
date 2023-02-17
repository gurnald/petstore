
using petstore;

ISpeakable[] pets = new ISpeakable[] {
    new Dog()  {Name = "Fideo" }, 
    new Cat() {Name = "Felix" },
    new Duck() { Name = "Daffy" },  
    new Cow() { Name = "Coward" },
    new Frog() {Name = "Cricket" },
};

foreach(var pet in pets) {
    pet.Speak();
    
}