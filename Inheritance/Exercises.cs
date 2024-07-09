namespace Inheritance;

public class Exercises
{
    public Exercises()
    {
        /*
           Explanation:

           Inheritance is the concept that a class can "inherit" traits from another.
           In real life you could see it as: a Monkey is an Animal.
           The Monkey inherits all traits of a generic Animal.
           The generic Animal however knows nothing of the Monkey.
           For classes this works the same.
           Classes that inherit from other classes take up all of its traits. These traits
           are accessible to the inheritor as long as they're marked 'protected' or 'public'.
           Traits can be marked with 'virtual' if you want to override them.
        */

        /*
           Exercise 1:

           Make a Monkey and an Animal class, both in new files in the "Structures" directory.
           Make the Monkey class inherit from the Animal class.
           When done uncomment the next line:
        */
        
        // Animal monkey = new Monkey();

        /*
           Exercise 2:

           Give every Animal a Vector2 (from shared) 'position' variable that only Animal classes can access.
           Give the Animal a Move function that takes no arguments. This function should add [1,1] onto the position.
           Also give the Animal a GetPosition function that returns the position.
           The code below
           When done uncomment the next three lines it should then print [0,0] -> [1,1]:
        */
        
        // Console.WriteLine($"Initial Position: {monkey.GetPosition()}");
        // monkey.Move();
        // Console.WriteLine($"End Position: {monkey.GetPosition()}");

        /*
           Exercise 3:

           Make the Move function overridable. Then override the function in the Monkey class to instead add [2,2]
           onto the position. The code above should now print [0,0] -> [2,2] instead.
        */

        /*
           Exercise 4:

           Add a constructor to your Animal class, in this constructor provide the animal with a name.
           Store this name as a variable that can be accessed throughout all animals.
           Give the monkey by default the name "Monkey" in its constructor.
           Then make a GetName function in Animal that returns the name.
           When done uncomment the next line:
        */
        
        // Console.WriteLine($"Animal has name: {monkey.GetName()}");

        /*
           Explanation:

           There are also different forms of inheritance to force classes to implement certain functions.
           For example: you could have a generic Ability. This Ability does not contain any actual functionality
           just the declarations of the functions. Then you could make different abilities based on the Ability.
           You could have a FireAbility or a ShootAbility. All abilities would implement the functions from Ability
           which would make them easy to call. There are multiple ways to go about this in C#:
           1. Make a normal Ability class and make the functions virtual.
           2. Make an interface, an interface should hold no definitions, only declarations.
              You should implement all the functions in a class that inherits from it.
           3. Make an abstract class, an abstract class allows you to do a mix of functionality and forced implementation.

           For now, we'll focus on number 2: Interfaces.
        */

        /*
           Exercise 5:

           Make an ability interface with a function to cast it.
           Note that it is customary to put start interface names with an 'I' to indicate that it's an interface.
           Also note that nowadays you can put definitions inside the interface but don't. :)
           Then make a FireAbility that inherits from Ability and just logs that it fires.
           When done uncomment the next two lines:
        */
        
        // IAbility fireAbility = new FireAbility();
        // fireAbility.Cast();

        /*
           Exercise 6:

           Another useful thing about interfaces is that you can inherit from both classes and interfaces at the same time.
           You can inherit only from one class but from as many interfaces as you like.
           Take your Animal class and make it inherit from two new structures:
           A class called "Being" and an interface called "IMortal".
           Add a "Kill" function to IMortal, add a health variable to Being and default it to something that isn't 0.
           Give Being a function to return that health.
           Implement the Kill function in Animal, so it sets its health to 0.

           When done uncomment the next three lines:
        */

        // Console.WriteLine($"Monkey Health: {monkey.GetHealth()}");
        // monkey.Kill();
        // Console.WriteLine($"Monkey Health: {monkey.GetHealth()}");

        /*
           Explanation:

           Abstract classes are a bit more complicated.
           They don't have a separate type like interfaces. Instead, 'abstract' is a keyword you can put
           in front of things. Do note that if you want to do this with anything you have to mark the
           class as 'abstract' first.
           The abstract keyword makes it so defining what you mark as abstract on the spot is prohibited.
           Make an abstract "Gun" class that has an abstract protected function that determines the firePower.
           Make an abstract "Shoot" function Also give it a non-abstract "GetFirePower" function that returns the
           determined firePower. At last make a "HeavyGun" that inherits from the Gun.
           When done uncomment the next three lines:
         */

        // Gun gun = new HeavyGun();
        // Console.WriteLine($"Gun has {gun.GetFirePower()} firePower");
        // gun.Shoot();
    }
}