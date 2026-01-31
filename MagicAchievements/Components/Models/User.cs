namespace MagicAchievements.Components.Models
{
    public class User
    {
        public required String Name { get; set; }
        public DateOnly CreatedOn { get; set; }
        public MagicAchievement[]? Achievements { get; set; }
        public int Achievementpoints { get; set; }
    }
}

