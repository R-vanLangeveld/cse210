using System;
// Exceeding Requirements
// added a Leveling system that uses a new method named PlayerRank in GoalManager
// added a Rank And Level Information menu option that uses a new method named RankInfo in 
// GoalManager that tells the user about the ranks in the leveling system and what 
// thier overall level is
// The new methods can be found in GoalManager.cs between GoalManager() and Start()
// and each are proceeded by a comment that states what the method contains
// Made DisplayPlayerInfo display the level, rank, and score of the user
class Program
{
    static void Main(string[] args)
    {
        GoalManager goalManager = new GoalManager();
        goalManager.Start();
    }
}