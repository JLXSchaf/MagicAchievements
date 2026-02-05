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

        public List<User> UserListParse(string userliststring)
        {
            List<User> newUserList = new List<User>();
            String[] userlistarray = userliststring.Split(';');
            foreach (String us in userlistarray)
            {
                newUserList.Add(UserParse(us));
            }
            return newUserList;
        }

        public User UserParse(string userstring)
        {
            String[] userarray = userstring.Split(",");
            User newAch = new User
            {
                Name = userarray[0],
                CreatedOn = DateOnly.Parse(userarray[1]),
                CollectedAchievements = AquiredAchievementsListParse(userarray[2]),
                Achievementpoints = int.Parse(userarray[3])
            };

            return newAch;
        }

        public List<AquiredAchievement> AquiredAchievementsListParse(String aqString)
        {
            List<AquiredAchievement> data = new List<AquiredAchievement>();
            String[] aqStringArray = aqString.Split("|");
            foreach(String cAString in aqStringArray)
            {
                data.Add(AquiredAchievementParse(cAString));
            }
            return data;
        }

        public AquiredAchievement AquiredAchievementParse(String aqString)
        {
            String[] aqStringArray = aqString.Split(",");

            return AquiredAchievementParse(aqStringArray);

        }

        public AquiredAchievement AquiredAchievementParse(String[] aqStringArray)
        {
            return new AquiredAchievement
            {
                Name = aqStringArray[0],
                AquiredWhen = DateOnly.Parse(aqStringArray[1]),
                AquiredWith = aqStringArray[2],
                Points = int.Parse(aqStringArray[3])
            };
        }


        public List<MagicAchievement> GetAchievementsData(String path)
        {
            // If none exist, create database 
            if (!System.IO.File.Exists(path))
            {
                System.IO.File.WriteAllText(path, "");
                return [];
            }
            return ReadAchievementsData(path);
        }

        public List<MagicAchievement> ReadAchievementsData(String path)
        {
            String rawData = System.IO.File.ReadAllText(path);
            List<MagicAchievement> mdata = MagicAchievementListParse(rawData);
            return mdata;
        }

        public List<MagicAchievement> MagicAchievementListParse(String achievmentsString)
        {
            List<MagicAchievement> newAchList = new List<MagicAchievement>();
            String[] achievementsStringArray = achievmentsString.Split('/');
            foreach (String magicAchievement in achievementsStringArray)
            {
                newAchList.Add(MagicAchievementParse(magicAchievement));
            }
            return newAchList;

        }

        public MagicAchievement MagicAchievementParse(string magicAchievementString)
        {
            String[] magicAchievementStringArray = magicAchievementString.Split("/");
            MagicAchievement newAch = new MagicAchievement
            {
                Name = magicAchievementStringArray[0],
                Bild = magicAchievementStringArray[1],
                Punktzahl = int.Parse(magicAchievementStringArray[2]),
                Anforderungen = magicAchievementStringArray[3]
            };

            return newAch;
        }






    }
}


