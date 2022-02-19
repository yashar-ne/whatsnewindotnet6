



// C#10 allows namespaces for the whole file by not putting it in curly braces like:

namespace SomeNormalNamespace
{
    class WhatsNewInDotnet
    {
        static void Main()
        {
        }
    }
}


// Now you can do for the whole file:
//
// namespace SomeFileScopedNamespace;
//
// class WhatsNewInDotnet
// {
//     static void Main()
//     {
//     }
// }