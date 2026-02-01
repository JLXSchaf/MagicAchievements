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
            List<User> data = [];

            String rawData = System.IO.File.ReadAllText(path);
            String[] arrayData = rawData.Split(";");
            foreach (String s in arrayData) {
                String[] userData = s.Split(",");
                data.Add(new User {
                    Name = userData[0],
                    CreatedOn = DateOnly.Parse(userData[1]),
                    Achievements = MagicAchievement.Parse(userData[2]),
                    Achievementpoints = int.Parse(userData[3]),
                });
            }
            return data;
        }


    }
}
