using AdapterPattern.Adapter;
using System;
using System.Threading.Tasks;
using Xunit;
using Xunit.Abstractions;
using static AdapterPattern.Adapter.StarWarsCharacterDisplayService;

namespace Adapter.Test
{
    public class TestRunner
    {
        private readonly ITestOutputHelper _output;

        public TestRunner(ITestOutputHelper output)
        {
            _output = output;
        }
        [Fact]
        public async Task DisplayCharactersFromFile()
        {
            var filePath = @"../../../../AdapterPattern/Adapter/People.json";
            var client = new CharacterFileSource();
            var adapter = new CharacterFileSourceAdapter(filePath,client);
            var service = new StarWarsCharacterDisplayService(adapter);
            var result = await service.ListCharacters();
            _output.WriteLine(result);
        }

        [Fact]
        public async Task DisplayCharactersFromApi()
        {
            var client = new StarWarsApi();
            var adapter = new StarWarsApiCharacterSourceAdapter(client);
            var service = new StarWarsCharacterDisplayService(adapter);
            var result = await service.ListCharacters();
            _output.WriteLine(result);
        }
    }
}
