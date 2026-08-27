/*
 * Student ID : 1690702301
 * Name       : Lab02
 * Section    : 129C
 * No.        : N/A
 * Course     : GI113 Computer Programming (GI)
 */

namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bossName = "Kirin";
            char rank = 'S';
            int level = 7;
            int maxHp = 240;
            int currentHp = 175;
            float attackPower = 42.5f;
            double critMultiplier = 1.75;
            bool isBoss = true;

            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"Name: {bossName}");
            Console.WriteLine($"Rank: {rank}");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            Console.WriteLine($"Attack power: {attackPower}");
            Console.WriteLine($"Crit Multiplier: {critMultiplier}");
            Console.WriteLine($"Is boss: {isBoss}");


            Console.WriteLine();


            int hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP Percent: {hpPercent}%");
            Console.WriteLine();
            Console.WriteLine("Kirin takes 60 damage!");
            Console.WriteLine();

            currentHp = currentHp - 60;
            Console.WriteLine();
            Console.WriteLine("===== BOSS STATUS: INITIAL =====");
            Console.WriteLine($"HP: {currentHp} / {maxHp}");
            hpPercent = currentHp * 100 / maxHp;
            Console.WriteLine($"HP percent: {hpPercent}%");

            Console.WriteLine("===== Umamusume TrainingToRace =====");
            // CharacterName
            String umas1Name = "AlmondEye";
            String umas2Name = "Daringtact";
            String umas3Name = "CurrenBouquet";
            String umas4Name = "GranAlegria";
            //CharacterRank
            char umas1Rank = 'S';
            char umas2Rank = 'A';
            char umas3Rank = 'B';
            char umas4Rank = 'G';
            //CharacterRunningStyle
            String umas1RunningStyle = "Pace Chaser";
            String umas2RunningStyle = "End Surger";
            String umas3RunningStyle = "Front Runner";
            String umas4RunningStyle = "Late Surger";
            //Characterlevel
            int umas1Level = 5;
            int umas2Level = 5;
            int umas3Level = 4;
            int umas4Level = 3;
            //CharacterSpeed
            float umas1Speed = 1.2f;
            float umas2Speed = 1.0f;
            float umas3Speed = 0.8f;
            float umas4Speed = 1.4f;
            //SpeedMultiplierSkill 
            double umas1SpeedMultiplierSkill = 1.5;
            double umas2SpeedMultiplierSkill = 1.3;
            double umas3SpeedMultiplierSkill = 1.1;
            double umas4SpeedMultiplierSkill = 1.7;
            //CharacterIsSpecialSkill
            bool umas1IsSpecialSkill = true;
            bool umas2IsSpecialSkill = false;
            bool umas3IsSpecialSkill = true;
            bool umas4IsSpecialSkill = false;

            Console.WriteLine("===== UMAMUSUME TRACEN ACADEMY STATUS: INITIAL =====");
            Console.WriteLine($"Name: {umas1Name}");
            Console.WriteLine($"Rank: {umas1Rank}");
            Console.WriteLine($"Running Style: {umas1RunningStyle}");
            Console.WriteLine($"Level: {umas1Level}");
            Console.WriteLine($"Speed: {umas1Speed}");
            Console.WriteLine($"Speed Multiplier: {umas1SpeedMultiplierSkill}");
            Console.WriteLine($"Is Special Skill: {umas1IsSpecialSkill}");
            Console.WriteLine();
            Console.WriteLine($"Name: {umas2Name}");
            Console.WriteLine($"Rank: {umas2Rank}");
            Console.WriteLine($"Running Style: {umas2RunningStyle}");
            Console.WriteLine($"Level: {umas2Level}");
            Console.WriteLine($"Speed: {umas2Speed}");
            Console.WriteLine($"Speed Multiplier: {umas2SpeedMultiplierSkill}");
            Console.WriteLine($"Is Special Skill: {umas2IsSpecialSkill}");
            Console.WriteLine();
            Console.WriteLine($"Name: {umas3Name}");
            Console.WriteLine($"Rank: {umas3Rank}");
            Console.WriteLine($"Running Style: {umas3RunningStyle}");
            Console.WriteLine($"Level: {umas3Level}");
            Console.WriteLine($"Speed: {umas3Speed}");
            Console.WriteLine($"Speed Multiplier: {umas3SpeedMultiplierSkill}");
            Console.WriteLine($"Is Special Skill: {umas3IsSpecialSkill}");
            Console.WriteLine();
            Console.WriteLine($"Name: {umas4Name}");
            Console.WriteLine($"Rank: {umas4Rank}");
            Console.WriteLine($"Running Style: {umas4RunningStyle}");
            Console.WriteLine($"Level: {umas4Level}");
            Console.WriteLine($"Speed: {umas4Speed}");
            Console.WriteLine($"Speed Multiplier: {umas4SpeedMultiplierSkill}");
            Console.WriteLine($"Is Special Skill: {umas4IsSpecialSkill}");
            Console.WriteLine();
        }
    }
}