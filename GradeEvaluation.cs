using System;

class GradeEvaluation
{
  static void Main()
  {
    Console.WriteLine("What grade did you get in you last class? (A,B,C,D, or F)");
    string grade = Console.ReadLine();

    bool greatGrade = grade == "A";
    bool goodGrade = grade == "B";
    bool okGrade = grade == "C";
    bool badGrade = grade == "D";
    bool awefulGrade = grade == "F";

    if (greatGrade || goodGrade)
    {
      Console.WriteLine("Well done! Keep up the good work.");
    }
    else if (okGrade)
    {
      Console.WriteLine("Hmmmmm, you pass but need to study more.");
    }
    else if (badGrade || awefulGrade)
    {
      Console.WriteLine("What can I do to help you pass next time?");
    }
    else
    {
      Console.WriteLine("Wrong input!!!!");
    }
  }
}
