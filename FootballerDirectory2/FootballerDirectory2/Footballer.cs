using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballerDirectory2
{
    public class FootballPlayer
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public string Club { get; set; }
        public int GoalsForClub { get; set; }
        public int TotalGoals { get; set; }
        public string ImagePath { get; set; } // Путь к файлу изображения
        
        public string Country { get; set; }
        public string Description { get; set; }

        public FootballPlayer(string name, string position, string club, int goalsForClub, int totalGoals, string imagePath, string country, string description)
        {
            Name = name;
            Position = position;
            Club = club;
            GoalsForClub = goalsForClub;
            TotalGoals = totalGoals;
            ImagePath = imagePath;
            
            Country = country;
            Description = description;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}