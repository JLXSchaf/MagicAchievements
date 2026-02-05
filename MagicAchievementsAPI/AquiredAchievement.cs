namespace MagicAchievementsAPI
{
    public class AquiredAchievement
    {
        public required String Name { get; set; }
        public required DateOnly AquiredWhen { get; set; }
        public String? AquiredWith { get; set; }
        public int Points { get; set; }
    }

}
