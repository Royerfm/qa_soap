using System;
using qa_soap.ServiceReference;

class Program
{
    static void Main()
    {
        var client = new ServiceClient();
        string resultado = client.HolaMundo();
        Console.WriteLine(resultado);
        client.Close();
    }
}
