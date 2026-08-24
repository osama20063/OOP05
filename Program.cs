
using Microsoft.VisualBasic;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics.Contracts;
using System.Diagnostics.Metrics;
using System.Net;
using System.Numerics;
using System.Reflection;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Threading.Channels;
using System.Xml;
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











            #region Q2 Shallow Copy vs Deep Copy

            //            //            a) What is a Shallow Copy?
            //            A Shallow Copy creates a new object instance and copies all fields of the original object to the new one.

            //            Value- type fields(like int, double, bool) are copied by value, creating independent copies.

            //Reference - type fields(like objects or arrays) copy only their memory addresses(references), meaning both the original and copied objects end up sharing and pointing to the exact same underlying reference objects in memory.



            ////b) What is a Deep Copy?
            //A Deep Copy creates a completely new object instance along with duplicate copies of all referenced objects nested inside it.

            //Value - type fields are copied directly by value.

            //Reference - type fields are also fully duplicated, meaning new object instances are created in memory for each referenced object.

            //As a result, the original object and the copied object are 100 % independent; changing any data or nested objects in one will never affect the other.





            //            //c) What happens to reference-type members when a Shallow Copy is created?


            //When a Shallow Copy is created, the memory addresses(references) of reference - type members are copied to the new object, rather than creating new object instances.

            //Both the original object and the copied object end up sharing and pointing to the exact same reference - type objects in memory.Modifying the internal state of a reference-type member through one object will directly change it for the other.










            //            //d) What happens to reference-type members when a Deep Copy is created?


            //            When a Deep Copy is created, brand new instances of all reference-type members are instantiated in memory, and their internal values are duplicated.

            //Instead of sharing references, the new object gets its own separate reference-type objects.Modifying a reference - type member in the copied object will have zero effect on the original object.



            //        //e) Give one situation where Deep Copy would be safer than Shallow Copy.

            //            A Deep Copy is safer when an object contains a mutable reference - type member(like a List, Array, or custom class object) that should be modified independently without accidentally altering or corrupting the original object's state.

            //Example:
            //In a Smart Delivery Management System, if an order contains an OrderHistory or PackageItems list, using a Shallow Copy means modifying the items in a duplicated order will also alter the original customer's order. A Deep Copy ensures the cloned order maintains its own separate items list.

            #endregion





            #region Q3 Static Members



            //            a) What is a static field, and how is it different from an instance field ?


            //            A static field belongs to the class itself rather than to any specific object instance.

            //Static Field: A single copy of the variable is shared across all instances of the class. Modifying it in one place changes it for all objects.

            //Instance Field: Each object created from the class receives its own separate copy of the field, holding data unique to that specific instance.




            //            //b) What is a static method? Can a static method directly access instance members?


            //            A static method is a method that belongs to the class itself rather than any specific object instance.It can be called directly using the class name without instantiating an object.

            //Accessing Instance Members: No, a static method cannot directly access instance members(fields or methods). Static methods execute without a this pointer or reference to a specific object instance. To access instance members, an instance of the class must be passed explicitly into the static method.

            //        //c) What is a static constructor, and when is it executed ?


            //        A static constructor is a special constructor used to initialize any static data or perform a specific action that needs to be executed only once for a class.

            //Execution Timing: It is executed automatically by the runtime before the first instance of the class is created or before any static members are accessed.It cannot be called directly and runs at most once per application domain.




            //    //d) What is a static class? Can you create an object from a static class?


            //        A static class is a class marked with the static keyword that can only contain static members(such as static methods, properties, and fields) and cannot be inherited.

            //Creating Objects: No, you cannot create an object from a static class using the new keyword.It is automatically loaded by the.NET runtime and accessed directly by its class name.






            #endregion









            #region Q4 Extension Methods


            //            a) What is an Extension Method?

            //            An extension method allows you to add new methods to an existing type without modifying its original source code, creating a derived type, or recompiling it.They are static methods that can be called as if they were instance methods on the extended type using dot notation.

            ////b) What keyword must be used in the first parameter of an extension method?


            //                The this keyword must be used before the first parameter of an extension method to specify which type the method extends.


            //            //c) Where must an extension method be declared?

            //                An extension method must be declared inside a static class that is non-nested(top-level). Both the class and the extension method itself must be marked as static.


            //            //d) Can an extension method access private members of the class it extends?

            //            No, an extension method cannot access private (or protected) members of the class it extends.

            //Extension methods operate outside the target class's scope, so they only have access to its public and internal members.






            #endregion













            #region  Q5 Partial Classes and Partial Methods


            //            a) What is a Partial Class?



            //            A partial class allows the definition of a single class to be split across multiple.cs source files using the partial keyword.All parts are combined into a single class when the code is compiled.




            ////b) Why would a developer split one class into multiple files?
            //Developers split a class into multiple files to:

            //Separate auto-generated code from custom code: Prevents tool-generated code(like EF Core models or UI designers) from overwriting custom logic during updates.

            //Enable parallel teamwork: Allows multiple developers to work on different parts of the same class simultaneously without source control merge conflicts.

            //Improve code organization: Keeps large classes clean, readable, and organized by feature or layer.



            //    //c) What is a Partial Method?


            //        A partial method is a method declared within a partial class that has its signature defined in one file and its optional implementation written in another file.

            //It must return void and cannot have access modifiers (it is implicitly private).

            //It allows generated code to provide method hooks that developers can optionally implement without causing compiler errors.



            //    //d) What happens if a declared partial method has no implementation?

            //        If a declared partial method has no implementation, the compiler completely removes its call and declaration from the compiled assembly(.dll or .exe).

            //No Performance Cost: It generates zero IL(Intermediate Language) code, meaning there is no execution overhead at runtime.

            //No Compiler Error: The project builds normally without throwing an unhandled exception or missing method error.

            #endregion












            #region Part 02 — Practical

            //1 Object Copying
            //Add object-copying functionality to the Shipment class.
            //• Create a method: Shipment CopyShipment().
            //• The method should create a copy of the current shipment.
            //• Demonstrate the difference between assigning one object variable to another and creating an actual copy.
            //Shipment shipment2 = shipment1;



            //public class Shipment
            //        {
            //            public int ShipmentId { get; set; }
            //            public string TrackingNumber { get; set; }
            //            public string Destination { get; set; }

            //            public Shipment CopyShipment()
            //            {
            //                return new Shipment
            //                {
            //                    ShipmentId = this.ShipmentId,
            //                    TrackingNumber = this.TrackingNumber,
            //                    Destination = this.Destination
            //                };
            //            }
            //        }

            //class Program
            //{
            //    static void Main()
            //    {
            //        Shipment shipment1 = new Shipment
            //        {
            //            ShipmentId = 101,
            //            TrackingNumber = "TRK123",
            //            Destination = "Cairo"
            //        };

            //        Shipment referenceCopy = shipment1;
            //        Shipment actualCopy = shipment1.CopyShipment();

            //        shipment1.Destination = "Alexandria";

            //        Console.WriteLine(referenceCopy.Destination);
            //        Console.WriteLine(actualCopy.Destination);
            //    }




            #endregion








            #region 2 Shallow Copy


            //• Create Shipment ShallowCopy().
            //• Use MemberwiseClone() to create the copy.
            //• The original and copied Shipment objects must be different objects.
            //• Their DeliveryAddress objects must still reference the same object.
            //• Change the address through the copied shipment and demonstrate that the original shipment's address is also
            //affected.



            //    public class Address
            //{
            //    public string City { get; set; }
            //}

            //public class Shipment
            //{
            //    public int ShipmentId { get; set; }
            //    public Address DeliveryAddress { get; set; }

            //    public Shipment ShallowCopy()
            //    {
            //        return (Shipment)this.MemberwiseClone();
            //    }
            //}

            //class Program
            //{
            //    static void Main()
            //    {
            //        Shipment originalShipment = new Shipment
            //        {
            //            ShipmentId = 1,
            //            DeliveryAddress = new Address { City = "Cairo" }
            //        };

            //        Shipment copiedShipment = originalShipment.ShallowCopy();

            //        copiedShipment.DeliveryAddress.City = "Alexandria";

            //        Console.WriteLine(originalShipment.DeliveryAddress.City);
            //        Console.WriteLine(copiedShipment.DeliveryAddress.City);

            //        Console.WriteLine(object.ReferenceEquals(originalShipment, copiedShipment));
            //        Console.WriteLine(object.ReferenceEquals(originalShipment.DeliveryAddress, copiedShipment.DeliveryAddress));
            //    }
            //}

            #endregion



            #region 3 Deep Copy









            //    public class Address
            //{
            //    public string City { get; set; }
            //}

            //public class Shipment
            //{
            //    public int ShipmentId { get; set; }
            //    public Address DeliveryAddress { get; set; }

            //    public Shipment DeepCopy()
            //    {
            //        return new Shipment
            //        {
            //            ShipmentId = this.ShipmentId,
            //            DeliveryAddress = new Address
            //            {
            //                City = this.DeliveryAddress?.City
            //            }
            //        };
            //    }
            //}

            //class Program
            //{
            //    static void Main()
            //    {
            //        Shipment originalShipment = new Shipment
            //        {
            //            ShipmentId = 1,
            //            DeliveryAddress = new Address { City = "Cairo" }
            //        };

            //        Shipment copiedShipment = originalShipment.DeepCopy();

            //        Console.WriteLine($"Before change:\t\tOriginal: {originalShipment.DeliveryAddress.City}\tCopied: {copiedShipment.DeliveryAddress.City}");

            //        copiedShipment.DeliveryAddress.City = "Giza";

            //        Console.WriteLine($"After changing copied:\tOriginal: {originalShipment.DeliveryAddress.City}\tCopied: {copiedShipment.DeliveryAddress.City}");

            //        bool isSameAddress = object.ReferenceEquals(originalShipment.DeliveryAddress, copiedShipment.DeliveryAddress);
            //        Console.WriteLine($"Same DeliveryAddress object?\t{isSameAddress}");
            //    }








            #endregion









            #region  4 Static Field


            //    public class Address
            //{
            //    public string City { get; set; }
            //}

            //public class Shipment
            //{
            //    public static int TotalShipmentsCreated = 0;

            //    public int ShipmentId { get; set; }
            //    public Address DeliveryAddress { get; set; }

            //    public Shipment()
            //    {
            //        TotalShipmentsCreated++;
            //    }
            //}

            //class Program
            //{
            //    static void Main()
            //    {
            //        Shipment shipment1 = new Shipment();
            //        Shipment shipment2 = new Shipment();
            //        Shipment shipment3 = new Shipment();

            //        Console.WriteLine($"Total Shipments Created: {Shipment.TotalShipmentsCreated}");
            //    }





            #endregion








            #region 5 Static Constructor



            //    public class Address
            //{
            //    public string City { get; set; }
            //}

            //public class Shipment
            //{
            //    public static int TotalShipmentsCreated;

            //    public int ShipmentId { get; set; }
            //    public Address DeliveryAddress { get; set; }

            //    static Shipment()
            //    {
            //        TotalShipmentsCreated = 0;
            //        Console.WriteLine("Shipment System Initialized");
            //    }

            //    public Shipment()
            //    {
            //        TotalShipmentsCreated++;
            //    }
            //}

            //class Program
            //{
            //    static void Main()
            //    {
            //        Shipment shipment1 = new Shipment();
            //        Shipment shipment2 = new Shipment();

            //        Console.WriteLine($"Total Shipments: {Shipment.TotalShipmentsCreated}");
            //    }






            #endregion







            #region 6 Static Method


            //    public class Address
            //{
            //    public string City { get; set; }
            //}

            //public class Shipment
            //{
            //    private static int TotalShipmentsCreated = 0;

            //    public int ShipmentId { get; set; }
            //    public Address DeliveryAddress { get; set; }

            //    static Shipment()
            //    {
            //        Console.WriteLine("Shipment System Initialized");
            //    }

            //    public Shipment()
            //    {
            //        TotalShipmentsCreated++;
            //    }

            //    public static int GetTotalShipmentsCreated()
            //    {
            //        return TotalShipmentsCreated;
            //    }
            //}

            //class Program
            //{
            //    static void Main()
            //    {
            //        Shipment shipment1 = new Shipment();
            //        Shipment shipment2 = new Shipment();
            //        Shipment shipment3 = new Shipment();

            //        Console.WriteLine($"Total Shipments Created : {Shipment.GetTotalShipmentsCreated()}");
            //    }




            #endregion







            #region 7 Static Class





            //    public static class DeliveryUtilities
            //{
            //    public static void PrintSystemTitle()
            //    {
            //        Console.WriteLine("=================================");
            //        Console.WriteLine("     SHIPMENT MANAGEMENT SYSTEM  ");
            //        Console.WriteLine("=================================");
            //    }

            //    public static void PrintSeparator()
            //    {
            //        Console.WriteLine("---------------------------------");
            //    }
            //}

            //public class Shipment
            //{
            //    private static int TotalShipmentsCreated = 0;

            //    public int ShipmentId { get; set; }

            //    public Shipment()
            //    {
            //        TotalShipmentsCreated++;
            //    }

            //    public static int GetTotalShipmentsCreated()
            //    {
            //        return TotalShipmentsCreated;
            //    }
            //}

            //class Program
            //{
            //    static void Main()
            //    {
            //        DeliveryUtilities.PrintSystemTitle();

            //        Shipment shipment1 = new Shipment();
            //        Shipment shipment2 = new Shipment();

            //        DeliveryUtilities.PrintSeparator();

            //        Console.WriteLine($"Total Shipments: {Shipment.GetTotalShipmentsCreated()}");

            //        DeliveryUtilities.PrintSeparator();
            //    }

            #endregion












            #region  

        //    public class Shipment
        //{
        //    public string TrackingCode { get; set; }
        //    public string Type { get; set; }
        //    public double WeightInKg { get; set; }
        //    public string TrackingStatus { get; set; }
        //}

        //public static class ShipmentExtensions
        //{
        //    public static string GetSummary(this Shipment shipment)
        //    {
        //        return $"{shipment.TrackingCode} | {shipment.Type} | {shipment.WeightInKg} KG | {shipment.TrackingStatus}";
        //    }

        //    public static bool IsDelivered(this Shipment shipment)
        //    {
        //        return shipment.TrackingStatus?.Equals("Delivered", StringComparison.OrdinalIgnoreCase) ?? false;
        //    }
        //}

        //class Program
        //{
        //    static void Main()
        //    {
        //        Shipment shipment1 = new Shipment
        //        {
        //            TrackingCode = "SH001",
        //            Type = "Standard",
        //            WeightInKg = 3,
        //            TrackingStatus = "In Transit"
        //        };

        //        Shipment shipment2 = new Shipment
        //        {
        //            TrackingCode = "SH002",
        //            Type = "Express",
        //            WeightInKg = 1.5,
        //            TrackingStatus = "Delivered"
        //        };

        //        Console.WriteLine(shipment1.GetSummary());
        //        Console.WriteLine($"Is Delivered? {shipment1.IsDelivered()}");

        //        Console.WriteLine(shipment2.GetSummary());
        //        Console.WriteLine($"Is Delivered? {shipment2.IsDelivered()}");
        //    }
        //}



            #endregion
    }
    }
}
