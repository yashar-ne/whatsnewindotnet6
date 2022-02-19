using System;

class WhatsNewInDotnet
{




    // Record types are useful syntactic sugar for normal classes with some
    // extras. Consider following class:
    class CompanyClass
    {
        //some props
        public string Name { get; init; }
        public string Address { get; init; }

        public CompanyClass(string name, string address)
        {
            Name = name;
            Address = address;
        }

        //prettier toString
        public override string ToString()
        {
            return $"{GetType().Name} {{ Name = {Name}, Address = {Address} }}";
        }
    }















    // With a Record function this is achieved in much less code
    public record CompanyRecord(string Name, string Address);

















    /*
    * That's nice... but is that it? What else can we do with Records?
    * - References OOTB are immutable (hence init props in class) -> Thread Safe!
    * - Override OOTB the compare method
    * - Override OOTB the copy method --> Is nondestructive! (creates a new object instance) 
    * - allow inheritance
    * - allow deconstruction
    * - and more stuff...
    *
    * Lets test it out!
    */
















    static void Main()
    {
        // 1. Instantiation
        CompanyClass cc = new("foo", "bar");
        CompanyRecord cr = new("foo", "bar");

        Console.WriteLine(cc);
        Console.WriteLine(cr);




        // -----------------




        // 2. Comparison
        // 2.1 Classes:
        CompanyClass cc2 = new("foo", "bar");
        CompanyClass cc3 = new("foo", "barista");

        Console.WriteLine(cc == cc2);
        Console.WriteLine(cc2 == cc3);


        // 2.2 Records:
        CompanyRecord cr2 = new("foo", "bar");
        CompanyRecord cr3 = new("foo", "barista");

        Console.WriteLine(cr == cr2);
        Console.WriteLine(cr2 == cr3);




        // -----------------




        // 3. Copy
        CompanyRecord crCopy = cr with
        {
            Name = "Something Else"
        };




        // -----------------





        // 4. Deconstruction
        var (name, address) = cr;
        Console.WriteLine(name);
        Console.WriteLine(address);
    }
    
    
    
    
    
    
    
    
    
    
    
    /*
     * Records have been around since C#9. So why are you talking about it?
     * Introducing: RECORD STRUCTS
     *  - new in C#10
     *  - allow to create value-typed Records --> Stack instead of Heap --> more efficient
     *  - regular struct restrictions apply
     */


    
    public record struct RecordStructCompany(string Name, string Address);

}






















 


