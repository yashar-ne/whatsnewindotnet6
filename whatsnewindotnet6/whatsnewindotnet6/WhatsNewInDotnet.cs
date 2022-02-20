using System;

class WhatsNewInDotnet
{

    static void Main()
    {
        // Before C#10 automatic inference of the datatype in lambda expressions was not possible
        Func<string, bool> isItTrue = someInput => someInput == "foo";
        
        //Now it is!
        var isItReallyTrue = (string someInput) => someInput == "foo";

        
        
        
        
        
        
        
        //Also the return type of a lambda can be set explicitly
        var someValue = () => 1;        
        var someOtherValue = () => (long) 1;

    }
}