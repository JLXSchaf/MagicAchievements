namespace MagicAchievements.Components.Models
{
    public class User
    {
        public required String Name { get; set; }
        public required DateOnly CreatedOn { get; set; }
        public required List<AquiredAchievement> CollectedAchievements { get; set; }
        public int Achievementpoints { get; set; }
    }
}

