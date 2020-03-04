using System;

namespace FavoriteThings
{
    class Pets
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }

        public void Bark()
        {
            if (Type == "dog")
            {
                Console.WriteLine("I'm a doggo");
            }
        }

        public void Run()
        {
            if (Name == "Peanut Butter")
            {
                Console.WriteLine($"Hi I'm {Name} and I am {Age} years old and I like to run!!!");
            }
            else
            {
                Console.WriteLine("I want to be named Peanut Butter.");
            }
        }
    }

    class Eating
    {
        public string Type { get; set; }
        public bool IsExpensive { get; set; }

        public void Munch()
        {
            if (IsExpensive)
            {
                Console.WriteLine("I am a fancy person.");
            }
        }

        public void EatOut()
        {
            if (Type == "food")
            {
                Console.WriteLine("I like eating out at restaurants");
            }
        }
    }

    class Baking
    {
        public string Type { get; set; }
        public string DifficultyLevel { get; set; }
        public void Fold()
        {
            if (Type == "dessert")
            {
                Console.WriteLine("I have to fold the batter");
            }
            else
            {
                Console.WriteLine("Why would you bake anything else?");
            }
        }

        public void Beat()
        {
            if (DifficultyLevel == "medium")
            {
                Console.WriteLine("Have to keep watch over the batter so that it's not overworked");
            }
            else
            {
                Console.WriteLine("You need to step up your baking level.");
            }
        }
    }

    class Photography
    {
        public string Type { get; set; }
        public string ProficiencyLevel { get; set; }
        public void Click()
        {
            if (Type == "food")
            {
                Console.WriteLine("I like to take pictures of food");
            }
            else
            {
                Console.WriteLine("Why take pictures of anything else?");
            }
        }
        public void Publish()
        {
            if (ProficiencyLevel == "beginner")
            {
                Console.WriteLine("I post to Instagram.");
            }
            else
            {
                Console.WriteLine("Do you even want to be instafamous?");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var dog = new Pets();
            dog.Type = "dog";
            dog.Name = "Peanut";
            dog.Age = "2";

            dog.Bark();
            dog.Run();

            var pood = new Eating();
            pood.Type = "food";
            pood.IsExpensive = true;

            pood.EatOut();
            pood.Munch();

            var hobby = new Baking();
            hobby.Type = "dessert";
            hobby.DifficultyLevel = "beginner";

            hobby.Beat();
            hobby.Fold();

            var pics = new Photography();
            pics.Type = "nature";
            pics.ProficiencyLevel = "beginner";

            pics.Click();
            pics.Publish();

            Console.ReadLine();
        }
    }
}
