using System;
using System.Collections.Generic;
using System.Linq;
using AdapterDemo.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AdapterDemo
{
    [TestClass]
    public class PatternRendererShould
    {
        [TestMethod]
        public void RenderTwoPatterns()
        {

            //var myRenderer = new PatternRenderer();
            var myRendererAdapter = new DataPatternRendererAdapter();
            var myList = new List<Pattern>
                                 {
                                     new Pattern {Id = 1, Name = "Pattern One", Description = "Pattern One Description"},
                                     new Pattern {Id = 2, Name = "Pattern Two", Description = "Pattern Two Description"}
                                 };
            
            string result = myRendererAdapter.ListPatterns(myList);

            Console.Write(result);
            int lineCount = result.Count(c => c == '\n');
            Assert.AreEqual(myList.Count + 2, lineCount);
            //Assert.AreEqual(1, 1);
        }
}
}