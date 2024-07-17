using System;

class Program
{
    static void Main(string[] args)
    {
        Menu menu = new Menu();
        Goals goals = new Goals();
        int input = 0;
        while (input != 6)
        {
            input = menu.DisplayMenu();
            if (input == 1)
            {
                int subinput = menu.CreateActivityMenu();
                if (subinput == 1)
                {
                    Simple simple = new Simple();
                    simple.RunActivity();
                    goals.AddGoal(simple);
                }
                else if (subinput == 2)
                {
                    Eternal eternal = new Eternal();
                    eternal.RunActivity();
                    goals.AddGoal(eternal);
                }
                else if (subinput == 3)
                {
                    CheckList check = new CheckList();
                    check.RunActivity();
                    goals.AddGoal(check);
                }
            }
            else if (input == 2)
            {
                goals.DisplayGoals();
            }
            else if (input == 3)
            {
                goals.SaveGoals();
            }
            else if (input == 4)
            {
                goals.LoadGoals();
            }
            else if(input == 5)
            {
                goals.RecordEvent();
            }
        }
    }
}