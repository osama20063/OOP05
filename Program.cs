
using Microsoft.VisualBasic;
using System.ComponentModel;
using System.Diagnostics.Contracts;
using System.Net;
using System.Numerics;
using System.Runtime.InteropServices;
using System.Threading.Channels;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Assignment_5_oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1  Abstraction



            //            a)  What is Abstraction in Object - Oriented Programming?


            //            Abstraction is considered one of the four core pillars of Object - Oriented Programming(OOP) for the following reasons:

            //Reduces Complexity: It allows developers to break down large, complex systems into smaller, manageable components by hiding intricate background logic.

            //Enhances Maintainability and Code Reusability: Changes to internal implementation details can be made without affecting other parts of the application that interact with the simplified interface.

            //Improves Code Security: By exposing only necessary methods and hiding internal data structures, sensitive logic is protected from unintended modification or misuse.

            //Increases Flexibility and Scalability: It establishes a clear contract for classes through abstract interfaces, allowing new features or subclasses to be introduced seamlessly.





            //b)  Why is abstraction considered one of the four pillars of OOP ?

            //            Abstraction is considered one of the four pillars of Object-Oriented Programming(OOP) because:

            //Reduces System Complexity: It allows developers to break down large systems into manageable components by hiding complex implementation details behind clean interfaces.

            //Enhances Code Reusability and Maintainability: Internal code logic can be updated, optimized, or refactored without breaking other parts of the application that depend on the interface.

            //Improves Security: It protects sensitive internal state and logic by exposing only the necessary methods for interacting with the object.

            //Increases Flexibility: It enforces a standard design contract(via Abstract Classes or Interfaces), allowing new classes to be added or swapped easily without changing existing code.





            #endregion








            #region Part 01 — Theoretical Questions


            //            a) What happens when you assign one object variable to another object variable?



            //When you assign one object variable to another reference - type variable(e.g., obj2 = obj1), the assignment copies only the memory address(reference) from the Stack, not the actual object in the Heap. Both variables end up pointing to the exact same object in memory, so any modification made through one variable will be reflected in the other.


//b) Does assigning one object to another create a new object? Explain.



//When you assign one object variable to another, a new object is not created.

//Only the reference(memory address) in the Stack is copied, so both variables end up pointing to the same existing object in the Heap. Any modification made through one variable will directly affect the other.


            //c) What is the difference between copying an object and copying its reference ?




//                Copying a reference: Copies only the memory address stored in the Stack without creating a new object.Both variables point to the same object in the Heap, so changing one affects the other.

//Copying an object(Shallow / Deep Copy): Creates a brand new object in the Heap with its own separate memory address.

//Shallow Copy: Copies value-type fields directly, but duplicates references for reference - type fields.

//Deep Copy: Creates a completely independent clone, including new instances for all referenced objects inside it.


            #endregion


        }
    }
}
