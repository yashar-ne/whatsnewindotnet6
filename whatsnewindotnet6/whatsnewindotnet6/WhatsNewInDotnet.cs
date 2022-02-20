using System;

class WhatsNewInDotnet
{
    public class Shape
    {
        public const float PI = 3.14f;
    }
    public class Circle : Shape
    {
        public double Radius { get; init; }
    }
    public class Rectangle : Shape
    {
        public double Length { get; }
        public double Height { get; }
    }
    
    class ShapeShifter
    {
        public Circle MyCircle { get; set; }
    }
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    static void Main()
    {
        //Declaration of some Shape
        Shape s = new Circle();


        //Pattern matching with is
        if (s is Circle c)
            Console.WriteLine("s is a circle");
        else if (s is Rectangle r)
            Console.WriteLine("s is a rectangle");
        
        
        
        //Pattern matching with switch
        switch (s)
        {
            case Circle ci:
                Console.WriteLine("s is a circle");
                break;
            case Rectangle re:
                Console.WriteLine("s is a rectangle");
                break;
        }



        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        


        Circle newCirlce = new Circle
        {
            Radius = 10
        };

        ShapeShifter newShapeShifter = new ShapeShifter
        {
            MyCircle = newCirlce
        };
        
        
        // Pattern matching on singular properties before C#10:
        var isPropACircle = newShapeShifter switch
        {
            {MyCircle : {Radius: 5}} => true,
            _ => false
        };
        
        
        // now it can be done shorter:
        var isPropReallyACircle = newShapeShifter switch
        {
            {MyCircle.Radius: 10} => true,
            _ => false
        };


    }
}