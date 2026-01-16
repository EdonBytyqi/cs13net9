using static System.Console;

partial class Program
{
    static void WhatsMyNamespace() //Defining a top-level function
    {
        WriteLine("Namespace of Program class: {0}",
            arg0: typeof(Program).Namespace ?? "null");
    }
}