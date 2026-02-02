namespace MagicAchievementsAPI.Library
{
    public class DataMethods
    {

        public List<User> GetPlayerData(String path)
        {
            // If none exist, create database 
            if (!System.IO.File.Exists(path))
            {
                System.IO.File.WriteAllText(path, "");
                return [];
            }
            return ReadPlayerData(path);
        }

        public List<User> ReadPlayerData(String path)
        {

            String rawData = System.IO.File.ReadAllText(path);
            List<User> data = UserListParse(rawData);
            return data;
        }

        public List<User> UserListParse(string s)
        {
            List<User> newUserList = new List<User>();
            String[] sa = s.Split(';');
            foreach (String us in sa)
            {
                newUserList.Add(UserParse(us));
            }
            return newUserList;
        }

        public User UserParse(string s)
        {
            String[] sa = s.Split(",");
            User newAch = new User
            {
                Name = sa[0],
                CreatedOn = DateOnly.Parse(sa[1]),
                Achievements = MagicAchievementListParse(sa[2]),
                Achievementpoints = int.Parse(sa[3])
            };

            return newAch;
        }


        public List<MagicAchievement> MagicAchievementListParse(String s)
        {
            List<MagicAchievement> newAchList = new List<MagicAchievement>();
            String[] sa = s.Split('/');
            foreach (String ma in sa)
            {
                newAchList.Add(MagicAchievementParse(ma));
            }
            return newAchList;

        }

        public MagicAchievement MagicAchievementParse(string s)
        {
            String[] sa = s.Split("/");
            MagicAchievement newAch = new MagicAchievement
            {
                Name = sa[0],
                Bild = sa[1],
                Punktzahl = int.Parse(sa[2]),
                Anforderungen = sa[3]
            };

            return newAch;
        }






    }
}


