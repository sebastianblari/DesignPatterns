using System;
using System.Collections.Generic;
using System.Text;
using Loans.Domain;
using Loans.Domain.Applications;
using NUnit.Framework;


namespace Loans.Tests
{
    [ProductComparison]
    [Category("Product Comparison")]
    //[TestFixture]
    public class ProductComparerShould
    {
        private List<LoanProduct> products;
        private ProductComparer sut;

        [OneTimeSetUp]
        public void OneTimeSetup()
        {

        }

        [SetUp]
        public void Setup() //Runs before every test
        {
            products = new List<LoanProduct>()
            {
                new LoanProduct(1,"a",1),
                new LoanProduct(2,"b",2),
                new LoanProduct(3,"c",3)
            };
            sut = new ProductComparer(new LoanAmount("USD", 200_000m), products);
        }
        [TearDown]
        public void TearDown() //Runs after every test
        {
            //Console.WriteLine("Running Tear Down");
        }

        [Test]
        public void ReturnCorrectNumberOfComparisons()
        {

            List<MonthlyRepaymentComparison> comparisons = sut.CompareMonthlyRepayments(new LoanTerm(30));

            Assert.That(comparisons, Has.Exactly(3).Items);
        }

        [Test]
        public void NotReturnDuplicateComparisons()
        {

            List<MonthlyRepaymentComparison> comparisons = sut.CompareMonthlyRepayments(new LoanTerm(30));

            Assert.That(comparisons, Is.Unique);
        }

        [Test]
        public void ReturnComparisonForFirstProduct()
        {

            var expectedProduct = new MonthlyRepaymentComparison("a", 1, 643.28m);
            List<MonthlyRepaymentComparison> comparisons = sut.CompareMonthlyRepayments(new LoanTerm(30));

            Assert.That(comparisons, Does.Contain(expectedProduct));
        }

        [Test]
        public void ReturnComparisonForFirstProduct_WithPartialKnownExpectedValues()
        {


            

            List<MonthlyRepaymentComparison> comparisons = sut.CompareMonthlyRepayments(new LoanTerm(30));



            //Assert.That(comparisons, Has.Exactly(1)
            //                            .Matches<MonthlyRepaymentComparison>(i => i.ProductName == "a")
            //                            .And
            //                            .Matches<MonthlyRepaymentComparison>(i => i.InterestRate == 1)
            //                            .And
            //                            .Matches<MonthlyRepaymentComparison>(i => i.MonthlyRepayment > 0));
            Assert.That(comparisons, Has.Exactly(1).
                                     Matches(new MonthlyRepaymentGreaterThanZeroConstraint("a", 1)));
        }

        [OneTimeTearDown]
        public void OneTimeTearDown()
        {

        }
    }
}
