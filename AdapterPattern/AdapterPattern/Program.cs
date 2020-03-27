using AdapterPattern.Adapter;
using System;
using static AdapterPattern.Adapter.StarWarsCharacterDisplayService;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var result = GetListCharacters();
            Console.WriteLine(result);
        }

        static string GetListCharacters() {
            var filePath = @"../../../../AdapterPattern/Adapter/People.json";
            var fileSource = new CharacterFileSource();
            var fileSourceAdapter = new CharacterFileSourceAdapter(filePath,fileSource);
            var service = new StarWarsCharacterDisplayService(fileSourceAdapter);
            var result = service.ListCharacters();
            return result.Result;
        }
    }
}
