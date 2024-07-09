using Inheritance.Classes;

namespace Inheritance;

public class Exercises
{
    public Exercises()
    {
        // Explanation:
        // Inheritance is the concept that a class can "inherit" traits from another.
        // In real life you could see it as: a Monkey is an Animal.
        // The Monkey inherits all traits of a generic Animal.
        // The generic Animal however knows nothing of the Monkey.
        // For classes this works the same. 
        // Classes that inherit from other classes take up all of its traits. These traits 
        // are accessible to the inheritor as long as they're marked 'protected' or 'public'.
        // Traits can be marked with 'virtual' if you want to override them.
        
        
        // Exercise 1:
        // Make a Monkey and an Animal class, both in new files in the "Classes" directory.
        // Make the Monkey class inherit from the Animal class.
        // When done uncomment the next line:
        Animal monkey = new Monkey();
        
        
        // Exercise 2:
        // Give every Animal a Vector2 'position' variable that only Animal classes can access.
        // Give the Animal a Move function that takes no arguments. This function should add [1,1] onto the position.
        // Also give the Animal a GetPosition function that returns the position.
        // The code below should then print [0,0] -> [1,1].
        // When done uncomment the next three lines:
        Console.WriteLine($"[Exercise 2]: Initial Position: {monkey.GetPosition()}");
        monkey.Move();
        Console.WriteLine($"[Exercise 2]: End Position: {monkey.GetPosition()}");
        
        // Exercise 3:
        // Make the Move function overridable. Then override the function in the Monkey class to instead add [2,2]
        // onto the position. The code above should now print [0,0] -> [2,2] instead.
    }
}