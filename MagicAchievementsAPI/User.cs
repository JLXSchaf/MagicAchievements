namespace MagicAchievementsAPI
{
    public class User
    {
        public required String Name { get; set; }
        public required DateOnly CreatedOn { get; set; }
        public required List<AquiredAchievement> CollectedAchievements { get; set; }
        public required int Achievementpoints { get; set; }
    }
}
