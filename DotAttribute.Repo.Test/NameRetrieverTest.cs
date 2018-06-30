using System;
using Xunit;

namespace DotAttribute.Repo.Test
{
    public class NameRetrieverTest
    {
        [Fact]
        public void HeroNamePage_Retrieval_IsNotNull()
        {
            var retriever = new NameRetriever();

            var result = retriever.GetHeroesNamePage();

            Assert.NotEqual($"hero name page is broken", result);
        }

        [Fact]
        public void AllHeroes_Retrieval_IsNotEmpty()
        {
            var retriever = new NameRetriever();

            var result = retriever.GetAllHeroes();

            Assert.NotEmpty(result);
        }

        [Fact]
        public void AllHeroes_Retrieval_HeroCountIs115()
        {
            var retriever = new NameRetriever();

            var result = retriever.GetAllHeroes();

            Assert.Equal(115, result.Count);
        }
    }
}
