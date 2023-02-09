using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ex14.src
{
    public class BadStudent : ex14.src.Student, ex15.service.IDataShowing
    {
        public float EnglishScore { get; private set; }

        public float EntryScore { get; private set; }

        public void SetEnglishscore(float englishscore)
        {
            this.EnglishScore = englishscore;
        }

        public void SetEntryScore(float entry)
        {
            this.EntryScore = entry;
        }

        public void ShowInfo()
        {
            Console.WriteLine(" ID: {0}\n Full name: {1}\n  Birthday: {2}\n Gender: {3}\n  Phone number {4}\n  University: {5}\n Level: {6}\n"
                             + "English score: {7}\n Entry score: {8}\n", StudentId, FullName, DateOfBirth, Genders, PhoneNumber, University, Level, EnglishScore, EntryScore);
        }
    }
}