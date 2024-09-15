namespace Laba2_1;
public class Pupil
{
    public virtual void Study()
    {
        Console.WriteLine("Pupil study ");
    }
    public virtual void Read()
    {
        Console.WriteLine("Pupil read ");
    }
    public virtual void Write()
    {
        Console.WriteLine("Pupil write ");
    }
    public virtual void Relax()
    {
        Console.WriteLine("Pupil relax "); 
    }
}

public class ExcelentPupil : Pupil
{
    public override void Study()
    {
        Console.WriteLine("Excelent pupil study excelent");
    }

    public override void Read() {
        Console.WriteLine("Excelent pupil read a lot");
    }
    public override void Write()
    {
        Console.WriteLine("Excelent pupil write beautiful summury");
    }

    public override void Relax()
    {
        Console.WriteLine("Excelent pupil relax a little");
    }
}

public class GoodPupil : Pupil
{
    public override void Study()
    {
        Console.WriteLine("Goodpupil study good");
    }

    public override void Read()
    {
        Console.WriteLine("Goodpupil read a midium");
    }
    public override void Write()
    {
        Console.WriteLine("Excelent pupil write a good summary");
    }

    public override void Relax()
    {
        Console.WriteLine("Goodpupil relax a midium");
    }
}

public class BadPupil : Pupil
{
    public override void Study()
    {
        Console.WriteLine("Badpupil study bad");
    }

    public override void Read()
    {
        Console.WriteLine("Badpupil read a little");
    }
    public override void Write()
    {
        Console.WriteLine("Badpupil write a little summary");
    }

    public override void Relax()
    {
        Console.WriteLine("Badpupil relax a lot");
    }
}

public class ClassRoom {
    private Pupil[] pupils;

    public ClassRoom(params Pupil[] pupils)
    {
     
        if (pupils.Length<2 || pupils.Length>4)
        {
            throw new ArgumentException("Enter right number of pupil");
        }

        this.pupils = pupils;
    }

    public void DisplayPublicActivites()
    {
        foreach (var pupil in pupils)
        {
            Console.WriteLine($"Information about pupil: {pupil.GetType().Name}:");
            pupil.Study();
            pupil.Write();
            pupil.Read();
            pupil.Relax();
            Console.WriteLine();
        }
    }

}
