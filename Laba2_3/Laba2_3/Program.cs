using System;

namespace Laba2_3;

class Program
{
    static void Main(string[] argc)
    {
        Console.WriteLine("Enter the access key");
        string key = Console.ReadLine();

        DocumentWorker worker=null;

        if (key=="pro")
        {
            worker = new ProDocumentWorker();
        }
        if (key=="exp")
        {
            worker = new ExpertDocumenrtWorker();
        }
        if (key != "pro" || key!="exp")
        {
            worker = new DocumentWorker();
        }

        worker.OpenDocument();
        worker.EditDocument();
        worker.SaveDocument();
    }
}
