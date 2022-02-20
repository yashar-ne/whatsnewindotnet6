using System;

class WhatsNewInDotnet
{
    
    /*
     * Lets assume we have a class with a deconstruct method --> necessary if you
     * are not using a Tuple, DictionaryEntry or Record 
     */
    //
    public class Person
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public void Deconstruct(out string firstName, out string lastName) =>
            (firstName, lastName) = (this.FirstName, this.LastName);
    }
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    static void Main()
    {
        var person = new Person
        {
            FirstName = "Some",
            LastName = "Person"
        };
        
        // Until now there are two ways of using the deconstruct:
        
        // 1. declaration, initialization and assignment

        string firstName;
        string lastName;
        (firstName, lastName) = person;
        
        // 2. declaration and assignment

        (string newFirstName, string newLastName) = person;
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        //C#10 introduces a third way. You are now allowed to mix the both methods:

        string veryNewFirstName;
        (veryNewFirstName, string veryNewLastName) = person;

    }
}