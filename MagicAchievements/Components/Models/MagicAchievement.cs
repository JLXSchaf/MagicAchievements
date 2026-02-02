namespace MagicAchievements.Components.Models
{
    public class MagicAchievement
    {
        public required String Name { get; set; }
        public String? Bild { get; set; }
        public required int Punktzahl { get; set; }
        public required String Anforderungen { get; set; }

    }
}
