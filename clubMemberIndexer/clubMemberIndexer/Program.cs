using System;
using System.Security.Cryptography.X509Certificates;
using static System.Console;

namespace clubMemberIndexer
{
    class Program
    {
        static void Main(string[] args)
        { 
            ClubMembers gameClub = new ClubMembers();
            gameClub[0] = "Luxxana Crownguard";
            gameClub[1] = "Garen Crownguard";
            gameClub[2] = "Jarvan Lightshield";
            gameClub[3] = "Fiora Laurent";
            gameClub[4] = "Sylas Dregbourne";
            gameClub.ClubType = "Gaming Club";
            gameClub.ClubLocation = "Computer Room";
            gameClub.MeetingDate = "Tuesdays";
            for (int x = 0; x < Size; x++)
            {
                if (gameClub[x] == "")
                {
                    break;
                }
                else
                {
                    WriteLine($"Member: {gameClub[x]}");
                    WriteLine($"Club: {gameClub.ClubType}");
                    WriteLine($"Location: {gameClub.ClubLocation}");
                    WriteLine($"Meeting Days: {gameClub.MeetingDate}");
                    WriteLine();
                }
            }
        }
        public const int Size = 15;
        class ClubMembers
        {
            private string[] Members = new string[Size];
            public string ClubType { get; set; }
            public string ClubLocation { get; set; }
            public string MeetingDate { get; set; }

            public ClubMembers()
            {
                for(int x=0; x< Members.Length; x++)
                {
                    Members[x] = string.Empty;
                }
            }
            public string this[int x]
            {
                get
                {
                    string tmp;
                    if(x >=0 && x <= Size -1 ){
                        tmp= Members[x];
                    }
                    else
                    {
                        tmp = "";
                    }
                    return tmp;
                }
                set
                {
                    if(x >= 0 && x <= Size - 1)
                    {
                        Members[x] = value;
                    }
                }
            }
        }
    }
    
}