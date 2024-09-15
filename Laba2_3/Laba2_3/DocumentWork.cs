using System;

public class DocumentWorker
{
    public virtual void OpenDocument()
    {
        Console.WriteLine("Document is open");
    }

    public virtual void EditDocument()
    {
        Console.WriteLine("Document editing is available in the Pro version");
    }

    public virtual void SaveDocument() 
    {
        Console.WriteLine("Document saving is available in the Pro version");
    }
}

public class ProDocumentWorker : DocumentWorker
{
    public override void OpenDocument()
    {
        Console.WriteLine("The document has been edited");
    }

    public override void SaveDocument()
    {
        Console.WriteLine("The document has been saved in the old format, saving in other formats is available in the Expert version");
    }
}

public class ExpertDocumenrtWorker : ProDocumentWorker
{
    public override void  EditDocument()
    {
        Console.WriteLine("Dodcument has been saved in a new format");
    }
}

