namespace Laba2_1;

class Program
{
    static void Main(string[] argc)
    {
        Pupil pupil1 = new ExcelentPupil();
        Pupil pupil2 = new GoodPupil();
        Pupil pupil3 = new BadPupil();
        Pupil pupil4 = new ExcelentPupil();

        ClassRoom classroom1 = new ClassRoom(pupil1, pupil2, pupil3, pupil4);
        classroom1.DisplayPublicActivites();
    }
}
