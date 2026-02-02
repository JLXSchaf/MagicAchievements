using MagicAchievementsAPI;
using System.Reflection.Metadata.Ecma335;

namespace MagicAchievementsAPI
{
    public class MagicAchievement
    {
        public required String Name { get; set; }
        public String? Bild { get; set; }
        public required int Punktzahl { get; set; }
        public required String Anforderungen { get; set; }

    }
}
