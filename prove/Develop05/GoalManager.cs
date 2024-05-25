class GoalManager
{
    private List<Goal> _goals = new List<Goal>();
    private int _score;
    private int _playerLevel;
    private string _playerRank;
    private int _overallLevel;
    public GoalManager()
    {
        _score = 0;
        _playerLevel = 1;
        _playerRank = "Newbie Newt";
        _overallLevel = 1;
    }

    // Leveling system :Exceeds Requirements
    public void PlayerRank()
    {
        if (_score <= 1000)
        {
            _playerRank = "Newbie Newt";
            if (_score <= 200)
            {
                _playerLevel = 1;
                _overallLevel = 1;
            }
            else if (_score <= 400)
            {
                _playerLevel = 2;
                _overallLevel = 2;
            }
            else if (_score <= 600)
            {
                _playerLevel = 3;
                _overallLevel = 3;
            }
            else if (_score <= 800)
            {
                _playerLevel = 4;
                _overallLevel = 4;
            }
            else if (_score <= 1000)
            {
                _playerLevel = 5;
                _overallLevel = 5;
            }
        }
        else if (_score <= 2000)
        {
            _playerRank = "Novice Narwhal";
            if (_score <= 1200)
            {
                _playerLevel = 1;
                _overallLevel = 6;
            }
            else if (_score <= 1400)
            {
                _playerLevel = 2;
                _overallLevel = 7;
            }
            else if (_score <= 1600)
            {
                _playerLevel = 3;
                _overallLevel = 8;
            }
            else if (_score <= 1800)
            {
                _playerLevel = 4;
                _overallLevel = 9;
            }
            else if (_score <= 2000)
            {
                _playerLevel = 5;
                _overallLevel = 10;
            }
        }
        else if (_score <= 3000)
        {
            _playerRank = "Competent Chameleon";
            if (_score <= 2200)
            {
                _playerLevel = 1;
                _overallLevel = 11;
            }
            else if (_score <= 2400)
            {
                _playerLevel = 2;
                _overallLevel = 12;
            }
            else if (_score <= 2600)
            {
                _playerLevel = 3;
                _overallLevel = 13;
            }
            else if (_score <= 2800)
            {
                _playerLevel = 4;
                _overallLevel = 14;
            }
            else if (_score <= 3000)
            {
                _playerLevel = 5;
                _overallLevel = 15;
            }
        }
        else if (_score <= 4000)
        {
            _playerRank = "Adept Aardvark";
            if (_score <= 3200)
            {
                _playerLevel = 1;
                _overallLevel = 16;
            }
            else if (_score <= 3400)
            {
                _playerLevel = 2;
                _overallLevel = 17;
            }
            else if (_score <= 3600)
            {
                _playerLevel = 3;
                _overallLevel = 18;
            }
            else if (_score <= 3800)
            {
                _playerLevel = 4;
                _overallLevel = 19;
            }
            else if (_score <= 4000)
            {
                _playerLevel = 5;
                _overallLevel = 20;
            }
        }
        else if (_score <= 5000)
        {
            _playerRank = "Advanced Ant";
            if (_score <= 4200)
            {
                _playerLevel = 1;
                _overallLevel = 21;
            }
            else if (_score <= 4400)
            {
                _playerLevel = 2;
                _overallLevel = 22;
            }
            else if (_score <= 4600)
            {
                _playerLevel = 3;
                _overallLevel = 23;
            }
            else if (_score <= 4800)
            {
                _playerLevel = 4;
                _overallLevel = 24;
            }
            else if (_score <= 5000)
            {
                _playerLevel = 5;
                _overallLevel = 25;
            }
        }
        else if (_score <= 6000)
        {
            _playerRank = "Experienced Eel";
            if (_score <= 5200)
            {
                _playerLevel = 1;
                _overallLevel = 26;
            }
            else if (_score <= 5400)
            {
                _playerLevel = 2;
                _overallLevel = 27;
            }
            else if (_score <= 5600)
            {
                _playerLevel = 3;
                _overallLevel = 28;
            }
            else if (_score <= 5800)
            {
                _playerLevel = 4;
                _overallLevel = 29;
            }
            else if (_score <= 6000)
            {
                _playerLevel = 5;
                _overallLevel = 30;
            }
        }
        else if (_score <= 7000)
        {
            _playerRank = "Expert Elephant";
            if (_score <= 6200)
            {
                _playerLevel = 1;
                _overallLevel = 31;
            }
            else if (_score <= 6400)
            {
                _playerLevel = 2;
                _overallLevel = 32;
            }
            else if (_score <= 6600)
            {
                _playerLevel = 3;
                _overallLevel = 33;
            }
            else if (_score <= 6800)
            {
                _playerLevel = 4;
                _overallLevel = 34;
            }
            else if (_score <= 7000)
            {
                _playerLevel = 5;
                _overallLevel = 35;
            }
        }
        else if (_score <= 8000)
        {
            _playerRank = "Master Mammoth";
            if (_score <= 7200)
            {
                _playerLevel = 1;
                _overallLevel = 36;
            }
            else if (_score <= 7400)
            {
                _playerLevel = 2;
                _overallLevel = 37;
            }
            else if (_score <= 7600)
            {
                _playerLevel = 3;
                _overallLevel = 38;
            }
            else if (_score <= 7800)
            {
                _playerLevel = 4;
                _overallLevel = 39;
            }
            else if (_score <= 8000)
            {
                _playerLevel = 5;
                _overallLevel = 40;
            }
        }
        else if (_score <= 9000)
        {
            _playerRank = "Champion Cobra";
            if (_score <= 8200)
            {
                _playerLevel = 1;
                _overallLevel = 41;
            }
            else if (_score <= 8400)
            {
                _playerLevel = 2;
                _overallLevel = 42;
            }
            else if (_score <= 8600)
            {
                _playerLevel = 3;
                _overallLevel = 43;
            }
            else if (_score <= 8800)
            {
                _playerLevel = 4;
                _overallLevel = 44;
            }
            else if (_score <= 9000)
            {
                _playerLevel = 5;
                _overallLevel = 45;
            }
        }
        else if (_score <= 10000)
        {
            _playerRank = "Veteran Velociraptor";
            if (_score <= 9200)
            {
                _playerLevel = 1;
                _overallLevel = 46;
            }
            else if (_score <= 9400)
            {
                _playerLevel = 2;
                _overallLevel = 47;
            }
            else if (_score <= 9600)
            {
                _playerLevel = 3;
                _overallLevel = 48;
            }
            else if (_score <= 9800)
            {
                _playerLevel = 4;
                _overallLevel = 49;
            }
            else if (_score <= 10000)
            {
                _playerLevel = 5;
                _overallLevel = 50;
            }
        }
        else if (_score <= 11000)
        {
            _playerRank = "Sage Snake";
            if (_score <= 10200)
            {
                _playerLevel = 1;
                _overallLevel = 51;
            }
            else if (_score <= 10400)
            {
                _playerLevel = 2;
                _overallLevel = 52;
            }
            else if (_score <= 10600)
            {
                _playerLevel = 3;
                _overallLevel = 53;
            }
            else if (_score <= 10800)
            {
                _playerLevel = 4;
                _overallLevel = 54;
            }
            else if (_score <= 11000)
            {
                _playerLevel = 5;
                _overallLevel = 55;
            }
        }
        else if (_score <= 12000)
        {
            _playerRank = "Legendary Leopard";
            if (_score <= 11200)
            {
                _playerLevel = 1;
                _overallLevel = 56;
            }
            else if (_score <= 11400)
            {
                _playerLevel = 2;
                _overallLevel = 57;
            }
            else if (_score <= 11600)
            {
                _playerLevel = 3;
                _overallLevel = 58;
            }
            else if (_score <= 11800)
            {
                _playerLevel = 4;
                _overallLevel = 59;
            }
            else if (_score <= 12000)
            {
                _playerLevel = 5;
                _overallLevel = 60;
            }
        }
    }
    // Rank And Level Information :Exceeds Requirements
    public void RankInfo()
    {
        Console.WriteLine($"\nYou gain a level every 200 points. Each rank has 5 levels. \nYour overall level is {_overallLevel}");
    }
    public void Start()
    {
        bool quit = false;
        do
        {
            PlayerRank();
            DisplayPlayerInfo();
            Thread.Sleep(1000);
            Console.Write("\nMenu Options: \n1. Create New Goal \n2. List Goals \n3. Save Goals \n4. Load Goals \n5. Record Event \n6. Rank And Level Information \n7. Quit \nSelect an option from the menu: ");
            int option = int.Parse(Console.ReadLine());

            if (option == 1)
            {
                CreateGoal();
                Thread.Sleep(1000);
            }
            else if (option == 2)
            {
                ListGoalDetails();
                Thread.Sleep(3000);
            }
            else if (option == 3)
            {
                SaveGoals();
                Thread.Sleep(1000);
            }
            else if (option == 4)
            {
                LoadGoals();
                Thread.Sleep(1000);
            }
            else if (option == 5)
            {
                RecordEvent();
                Thread.Sleep(1000);
            }
            else if (option == 6)
            {
                RankInfo();
                Thread.Sleep(1000);
            }
            else
            {
                quit = true;
            }
        } while (quit != true);
    }
    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nYou are a level {_playerLevel} {_playerRank}. \nYou have {_score} points.");
    }
    public void ListGoalNames()
    {
        int index = 1;

        foreach (Goal goal in _goals)
        {
            string[] split1;
            string[] split2;
            string goalName;
            string toSplit = goal.GetStringRepresentation();
            split1 = toSplit.Split(":");
            split2 = split1[1].Split(",");
            goalName = split2[0];
            Console.WriteLine($"{index}. {goalName}");
            index += 1;
        }
    }
    public void ListGoalDetails()
    {
        if (_goals.Count > 0)
        {
            Console.WriteLine("\nYour goals are:");
            foreach (Goal goal in _goals)
            {
                Console.WriteLine($"{goal.GetDetailsString()}");
            }
        }
        else
        {
            Console.WriteLine("\nYou have not set any goals.");
        }
    }
    public void CreateGoal()
    {
        string name;
        string description;
        string points;
        string stringTarget;
        string stringBonus;
        Console.Write("\nThe types of Goals are: \n1. Simple Goal \n2. Eternal Goal \n3. Checklist Goal" + 
        "\nType the number of the goal you want to create: ");
        string respond = Console.ReadLine();

        if (int.Parse(respond) == 1)
        {
            Console.Write("Type the name of your goal: ");
            name = Console.ReadLine();
            Console.Write("Type a short description of your goal: ");
            description = Console.ReadLine();
            Console.Write("Type the amount of points you think the goal is worth: ");
            points = Console.ReadLine();
            SimpleGoal goal = new SimpleGoal(name, description, points, "false");
            _goals.Add(goal);
        }
        else if (int.Parse(respond) == 2)
        {
            Console.Write("Type the name of your goal: ");
            name = Console.ReadLine();
            Console.Write("Type a short description of your goal: ");
            description = Console.ReadLine();
            Console.Write("Type the amount of points you think the goal is worth: ");
            points = Console.ReadLine();
            EternalGoal goal = new EternalGoal(name, description, points);
            _goals.Add(goal);
        }
        else if (int.Parse(respond) == 3)
        {
            Console.Write("Type the name of your goal: ");
            name = Console.ReadLine();
            Console.Write("Type a short description of your goal: ");
            description = Console.ReadLine();
            Console.Write("Type the number of steps to complete this goal: ");
            stringTarget = Console.ReadLine();
            Console.Write("Type the amount of points for completing each step of this goal: ");
            points = Console.ReadLine();
            Console.Write($"Type the amount of bonus points you will get for completing the entire goal: ");
            stringBonus = Console.ReadLine();
            ChecklistGoal goal = new ChecklistGoal(name, description, points, int.Parse(stringBonus), 0, int.Parse(stringTarget));
            _goals.Add(goal);
        }
        Console.WriteLine("Task created");
        Thread.Sleep(500);
    }
    public void RecordEvent()
    {
        if (_goals.Count > 0)
        {
            Console.WriteLine("\nThese are your goals:");
            ListGoalNames();
            Console.Write("Which goal have you done: ");
            int completed = int.Parse(Console.ReadLine()) - 1;
            string[] split1;
            string[] split2;
            string goalType;
            string toSplit = _goals[completed].GetStringRepresentation();
            split1 = toSplit.Split(":");
            goalType = split1[0];

            if (goalType == "SimpleGoal")
            {
                split2 = split1[1].Split(",");

                if (split2[3] == "False")
                {
                    int points = int.Parse(split2[2]);
                    _score += points;
                    Console.WriteLine($"Task Complete: added {points} points.");
                    _goals[completed].RecordEvent();
                }
                else if (split2[3] != "False")
                {
                    Console.WriteLine("\nYou cannot complete this task again.\n");
                }
            }
            else if (goalType == "EternalGoal")
            {
                split2 = split1[1].Split(",");
                int points = int.Parse(split2[2]);
                _score += points;
                Console.WriteLine($"Task Complete: added {points} points.");
            }
            else if (goalType == "ChecklistGoal")
            {
                toSplit = _goals[completed].GetStringRepresentation();
                split1 = toSplit.Split(":");
                split2 = split1[1].Split(",");
                int points = int.Parse(split2[2]);

                if (_goals[completed].IsComplete() == false)
                {
                    _goals[completed].RecordEvent();
                    toSplit = _goals[completed].GetStringRepresentation();
                    split1 = toSplit.Split(":");
                    split2 = split1[1].Split(",");
                    if (int.Parse(split2[4]) == int.Parse(split2[5]))
                    {
                        int bonus = int.Parse(split2[3]);
                        _score += points;
                        Console.WriteLine($"Task Complete: added {points} points.");
                        _score += bonus;
                        Console.WriteLine($"Task Complete: added {bonus} bonus points.");
                    }
                    else if (int.Parse(split2[4]) < int.Parse(split2[5]))
                    {
                        _score += points;
                        Console.WriteLine($"Task Complete: added {points} points.");
                    }
                }
                else 
                {
                    Console.WriteLine("You cannot complete this task again.");
                }
            }
            else
            {
                Console.WriteLine("\nYou have not set any goals.");
            }
        }
    }
    public void SaveGoals()
    {

        Console.WriteLine("\nEnter the full file name (example C:\\filename.txt)");
        string file = Console.ReadLine();
        string separatorLine = "|";
        string save = $"{_score}|\n";
        File.WriteAllText(file,save);

        foreach (Goal goal in _goals)
        {
            save = goal.GetStringRepresentation() + separatorLine + "\n";
            File.AppendAllText(file,save);
        }
        Console.WriteLine($"Saved to file: {file}");
    }
    public void LoadGoals()
    {
        _goals.Clear();
        Console.WriteLine("\nEnter the full file name (example C:\\filename.txt)");
        string file = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(file);
        string[] split1;
        string[] split2;
        string[] split3;
        string goalType;
        var one = new List<string>();
        
        foreach (string line in lines)
        {
            split1 = line.Split("|");
            one.Add(split1[0]);
        }
        _score = int.Parse(one[0]);
        one.RemoveAt(0);

        foreach (string line in one)
        {
            split2 = line.Split(":");
            goalType = split2[0];
            split3 = split2[1].Split(",");

            if (goalType == "SimpleGoal")
            {
                SimpleGoal goal = new SimpleGoal(split3[0], split3[1], split3[2], split3[3]);
                _goals.Add(goal); 
            }
            else if (goalType == "EternalGoal")
            {
                EternalGoal goal = new EternalGoal(split3[0], split3[1], split3[2]);
                _goals.Add(goal); 
            }
            else if (goalType == "ChecklistGoal")
            {
                ChecklistGoal goal = new ChecklistGoal(split3[0], split3[1], split3[2], int.Parse(split3[3]), int.Parse(split3[4]), int.Parse(split3[5]));
                _goals.Add(goal); 
            }
        }
        Console.WriteLine($"Loaded from file: {file}");
    }
}