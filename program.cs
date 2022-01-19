using System;

namespace ExquisiteCorpse
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Welcome to the Random Creature Generator. Let's build together!");
      Console.WriteLine("Our options today are ghost, monster, and bug.");
      Console.Write("What kind of head would you like? ");
      string headChoice = Console.ReadLine();
      Console.Write("What kind of body would you like? ");
      string bodyChoice = Console.ReadLine();
      Console.Write("What kind of feet would you like? ");
      string feetChoice = Console.ReadLine();
      Console.WriteLine("Here is your creature. Spooky!");
      BuildACreature(headChoice, bodyChoice, feetChoice);
    }

    static void BuildACreature(string head, string body, string feet)
    {
      int headNum = TranslateToNumber(head);
      int bodyNum = TranslateToNumber(body);
      int feetNum = TranslateToNumber(feet);
      SwitchCase(headNum, bodyNum, feetNum);
    }

    static void RandomMode()
    {
      Random randomNumber = new Random();
      int headInt = randomNumber.Next(1, 4);
      int bodyInt = randomNumber.Next(1,4);
      int feetInt = randomNumber.Next(1,4);
      SwitchCase(headInt, bodyInt, feetInt);
    }

    static void SwitchCase(int head, int body, int feet)
    {
      switch (head)
      {
        case 1: GhostHead(); break;
        case 2: MonsterHead(); break;
        case 3: BugHead(); break;
      }
        switch (body)
      {
        case 1: GhostBody(); break;
        case 2: MonsterBody(); break;
        case 3: BugBody(); break;
      }
      switch (feet)
      {
        case 1: GhostFeet(); break;
        case 2: MonsterFeet(); break;
        case 3: BugFeet(); break;
      }
    }

    static int TranslateToNumber(string creature)
    {
      switch (creature)
      {
        case "ghost": return 1;
        case "monster": return 2;
        case "bug": return 3;
        default: return 1;
      }
    }

    static void GhostHead()
    {
      Console.WriteLine("     ..-..");
      Console.WriteLine("    ( o o )");
      Console.WriteLine("    |  O  |");
    }

    static void GhostBody()
    {
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
    }

    static void GhostFeet()
    {
      Console.WriteLine("    |     |");
      Console.WriteLine("    |     |");
      Console.WriteLine("    '~~~~~'");
    }

    static void BugHead()
    {
      Console.WriteLine("     /   \\");
      Console.WriteLine("     \\. ./");
      Console.WriteLine("    (o + o)");
    }

    static void BugBody()
    {
      Console.WriteLine("  --|  |  |--");
      Console.WriteLine("  --|  |  |--");
      Console.WriteLine("  --|  |  |--");
    }

    static void BugFeet()
    {
      Console.WriteLine("     v   v");
      Console.WriteLine("     *****");
    }

    static void MonsterHead()
    {
      Console.WriteLine("     _____");
      Console.WriteLine(" .-,;='';_),-.");
      Console.WriteLine("  \\_\\(),()/_/");
      Console.WriteLine("　  (,___,)");
    }

    static void MonsterBody()
    {
      Console.WriteLine("   ,-/`~`\\-,___");
      Console.WriteLine("  / /).:.('--._)");
      Console.WriteLine(" {_[ (_,_)");
    }

    static void MonsterFeet()
    {
      Console.WriteLine("    |  Y  |");
      Console.WriteLine("   /   |   \\");
      Console.WriteLine("   \"\"\"\" \"\"\"\"");
    }
  }
}
