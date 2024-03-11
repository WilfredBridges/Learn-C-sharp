// See https://aka.ms/new-console-template for more information
Console.WriteLine("Mad Libs is starting");

string title = "Appocolypse";

      Console.WriteLine(title);

     Console.WriteLine("Enter a name: ");
     string name = Console.ReadLine();

     Console.WriteLine("Enter a feeling: ");
     string feeling = Console.ReadLine();

     Console.WriteLine("Enter an adjective: ");
     string adjective = Console.ReadLine();

     Console.WriteLine("Enter another adjective: ");
     string adjective2 = Console.ReadLine();

     Console.WriteLine("Enter a noun: ");
     string noun1 = Console.ReadLine();

     Console.WriteLine("Enter a verb: ");
     string verb1 = Console.ReadLine();

     Console.WriteLine("Enter a noun: ");
     string noun2 = Console.ReadLine();

     Console.WriteLine("Enter an animal: ");
     string animal = Console.ReadLine();

     
    Console.WriteLine("Enter a year: ");
    string year = Console.ReadLine();

    Console.WriteLine("Enter a food:  ");
    string food = Console.ReadLine();

    Console.WriteLine("Enter a fruit: ");
    string fruit = Console.ReadLine();

    Console.WriteLine("Enter a superhero: ");
    string superhero = Console.ReadLine();

    Console.WriteLine("Enter a country: ");
    string country = Console.ReadLine();

    Console.WriteLine("Enter a dessert: ");
    string dessert = Console.ReadLine();

     // The template for the story:

      string story = $"This morning {name} woke up feeling {adjective}. 'It is going to be a {adjective2} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb1} to the rhythm of the {noun1}, which made all the {fruit}s very {noun2}. Concerned, {name} texted {superhero}, who flew {name} to {country} and dropped {name} in a puddle of frozen {dessert}. {name} woke up in the year {year}, in a world where {noun2}s ruled the world.";

    Console.WriteLine(story);
