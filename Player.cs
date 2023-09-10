using System;

namespace LifeQuest
{
    class Player
    {
        // Player attributes
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string gender { get; set; }
        public string birthPlace { get; set; }
        public string stage { get; set; }
        public bool breastfeeding { get; set; }
        public bool balancedDiet { get; set; }
        public bool doDrugs { get; set; }
        public bool graduatedHighSchool { get; set; }
        public bool earlyGameFitness { get; set; }
        public bool socialLife { get; set; }
        public bool careerSuccess { get; set; }
        public bool happyFamily { get; set; }
        public bool goodFinance { get; set; }
        public bool endGameFitness { get; set; }
        public bool endGameNutrition { get; set; }

        // Player constructor

        public Player()
        {
            firstName = string.Empty;
            lastName = string.Empty;
            birthPlace = string.Empty;
            stage = "Infancy and Early Childhood";
        }


        public void createPlayer()
        {
            // Choose gender
            TextDisplayHelper.SlowlyDisplayText("Choose your gender (Male/Female): ");
            gender = Console.ReadLine();

            // Ask for first name
            TextDisplayHelper.SlowlyDisplayText("What is your first name?");
            firstName = Console.ReadLine();

            // Ask for last name
            TextDisplayHelper.SlowlyDisplayText("What is your last name?");
            lastName = Console.ReadLine();

            // Roll dice for birthplace
            TextDisplayHelper.SlowlyDisplayText("God starts rolling the dice for your birthplace...");
            TextDisplayHelper.SlowlyDisplayText("........");
            birthPlace = RollDiceForBirthPlace();
            Console.WriteLine("Player created! Press any key to continue.");
            // Display player information
            TextDisplayHelper.SlowlyDisplayText("Character created!");
            TextDisplayHelper.SlowlyDisplayText($@"Name: {firstName} {lastName}");
            TextDisplayHelper.SlowlyDisplayText($@"Gender:  {gender}");
            TextDisplayHelper.SlowlyDisplayText($"Birthplace: {birthPlace}");


        }


        // Player methods

        // Roll dice for birthplace
        private string RollDiceForBirthPlace()
        {
            Random random = new Random();
            int roll = random.Next(1, 6); // Generates a random number between 1 and 5 (inclusive).

            switch (roll)
            {
                case 1:
                    return "Africa";
                case 2:
                    return "Asia";
                case 3:
                    return "Europe";
                case 4:
                    return "North America";
                case 5:
                    return "South America";
                default:
                    return "Unknown"; // Handle any unexpected rolls.
            }
        }


        // }

        // public string TransitionToNextStage()
        // {

        // }

    }
}