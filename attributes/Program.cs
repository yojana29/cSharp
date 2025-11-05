using System;   // Importing the System namespace (needed for [Obsolete])

class Program
{
    // 👇 This is the ATTRIBUTE
    // [Obsolete] tells the compiler that this method is old or outdated.
    // The first string ("Use NewMethod instead") is a message shown when someone tries to use it.
    // The second argument 'true' means:
    //   → Make this an ERROR, not just a warning.
    // If 'true' is removed (or false), it only gives a warning, not an error.
    //[Obsolete("Use NewMethod instead", true)]
        [Obsolete("Use NewMethod instead")]

    static void OldMethod()   // 👈 The attribute applies to this method
    {
        Console.WriteLine("Old method called.");
    }

    // ✅ This is the new, preferred method
    static void NewMethod()
    {
        Console.WriteLine("New method called.");
    }

    static void Main()
    {
        OldMethod();   // ❌ This will cause a COMPILATION ERROR because of [Obsolete(..., true)]
                       // If 'true' was not there, this line would run but show a WARNING instead.

        NewMethod();   // ✅ This works fine (recommended to use)
    }
}
