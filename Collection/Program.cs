using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Queue<string> family = new Queue<string>();
        family.Enqueue("Nick");
        family.Enqueue("McKenzie");
        family.Enqueue("Myles");
        family.Enqueue("Franklin");
        family.Enqueue("Charlie");
        Console.WriteLine($"Queue contains family member Myles: {family.Contains("Myles")}");

        string removedMember = family.Dequeue();

        Console.WriteLine($"family count: {family.Count}");
        Console.WriteLine("family items:");
        foreach (var member in family)
        {
            Console.WriteLine(member);
        }

        PriorityQueue<string> favoriteShow = new PriorityQueue<string>();
        favoriteShow.Enqueue("House");
        favoriteShow.Enqueue("Suits");
        favoriteShow.Enqueue("Dexter");
        favoriteShow.Enqueue("Castlevania");
        favoriteShow.Enqueue("The Boys");
        while (favoriteShow.Count > 0)
        {
            Console.WriteLine($"Highest priority item: {favoriteShow.Peek()}");
            favoriteShow.Dequeue();
        }

        Stack<string> employee = new Stack<string>();
        employee.Push("Jax");
        employee.Push("Lila");
        employee.Push("Jakiah");
        employee.Push("Nate");
        employee.Push("Kelly");
        Console.WriteLine($"Employee stack contains the name Jax: {employee.Contains("Jax")}");

        string poppedItem = employee.Pop();

        Console.WriteLine($"Employee count: {employee.Count}");
        Console.WriteLine("Employees:");
        foreach (var emp in employee)
        {
            Console.WriteLine(emp);
        }

        LinkedList<string> favoriteCharacter = new LinkedList<string>();
        favoriteCharacter.AddLast("Sasuke");
        favoriteCharacter.AddLast("Itachi");
        favoriteCharacter.AddLast("Luffy");
        favoriteCharacter.AddLast("Mereoleona");
        favoriteCharacter.AddLast("Yami");

        Console.WriteLine($"First character: {favoriteCharacter.First.Value}");
        Console.WriteLine($"Last character: {favoriteCharacter.Last.Value}");

        LinkedListNode<string> newCharacter = favoriteCharacter.Find("Luffy");
        favoriteCharacter.AddAfter(newCharacter, "Thorfinn");

        favoriteCharacter.RemoveFirst();

        Console.WriteLine($"Character count: {favoriteCharacter.Count}");
        Console.WriteLine("Character names:");
        foreach (var character in favoriteCharacter)
        {
            Console.WriteLine(character);
        }

        Dictionary<int, string> tieredCharacters = new Dictionary<int, string>();
        tieredCharacters.Add(1, "Sasuke");
        tieredCharacters.Add(2, "Itachi");
        tieredCharacters.Add(3, "Yami");
        tieredCharacters.Add(4, "Luffy");
        tieredCharacters.Add(5, "Mereoleona");

        Console.WriteLine("Rankings:");
        foreach (var key in tieredCharacters.Keys)
        {
            Console.WriteLine(key);
        }

        Console.WriteLine("Character names:");
        foreach (var value in tieredCharacters.Values)
        {
            Console.WriteLine(value);
        }

        Console.WriteLine("Rank and name pairs:");
        foreach (var pair in tieredCharacters)
        {
            Console.WriteLine($"{pair.Key}: {pair.Value}");
        }

        tieredCharacters.Remove(5);

        Console.WriteLine($"New character count: {tieredCharacters.Count}");

        SortedList<int, string> birdFrequency = new SortedList<int, string>();
        birdFrequency.Add(3, "Kestrel");
        birdFrequency.Add(1, "Snowy Owl");
        birdFrequency.Add(5, "Red-Tail Hawk");
        birdFrequency.Add(2, "Osprey");
        birdFrequency.Add(4, "Bald Eagle");

        Console.Write("Enter a key: ");
        int userKey = int.Parse(Console.ReadLine());
        Console.Write("Enter a value: ");
        string userValue = Console.ReadLine();

        if (birdFrequency.ContainsKey(userKey))
        {
            Console.WriteLine("Key already exists.");
        }
        else
        {
            birdFrequency.Add(userKey, userValue);
        }

        birdFrequency.Remove(5);

        Console.WriteLine("Ranking in how often birds are sighted by me:");
        foreach (var bird in birdFrequency)
        {
            Console.WriteLine($"{bird.Key}: {bird.Value}");
        }

        HashSet<int> hashSet1 = new HashSet<int>() { 1, 2, 3, 4, 5 };
        HashSet<int> hashSet2 = new HashSet<int>() { 4, 5, 6, 7, 8 };
        HashSet<int> hashSet3 = new HashSet<int>() { 5, 6, 9, 10, 11 };

        hashSet1.UnionWith(hashSet2);
        foreach (var num in hashSet1)
        {
            Console.WriteLine(num);
        }

        HashSet<int> duplicates = new HashSet<int>(hashSet1);
        duplicates.IntersectWith(hashSet3);
        Console.WriteLine("Duplicates between the first and third hashset:");
        foreach (var duplicate in duplicates)
        {
            Console.WriteLine(duplicate);
        }

        List<string> favoriteGames = new List<string>() { "Final Fantasy 7", "Ghost of Tsushima", "The Last of Us", "The Last of Us Part 2", "OSRS" };
        favoriteGames.AddRange(new string[] { "Overcooked 2", "Diablo 2", "Apex" });

        favoriteGames.Sort();
        Console.WriteLine("Sorted games list:");
        foreach (var game in favoriteGames)
        {
            Console.WriteLine(game);
        }

        favoriteGames.Remove("Apex");

        favoriteGames.Reverse();
        Console.WriteLine("Reversed sorted games list:");
        foreach (var game in favoriteGames)
        {
            Console.WriteLine(game);
        }
    }
}