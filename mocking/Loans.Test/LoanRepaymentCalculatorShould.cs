using System;
using NUnit.Framework;
using Loans.Domain.Applications;

namespace Loans.Tests
{
    [TestFixture]
    public class LoanRepaymentCalculatorShould
    {
        [Test]
        [TestCase(200_000, 6.5, 30, 1264.14)]
        [TestCase(200_000, 10, 30, 1755.14)]
        [TestCase(500_000, 10, 10, 6607.54)]
        public void CalculateCorrectlyMonthlyRepayment(decimal principal,
                                                       decimal interestRate,
                                                       int termInYears,
                                                       decimal expectedMonthlyPayment)
        {
            var sut = new LoanRepaymentCalculator();
            var monthlyPayment = sut.CalculateMonthlyRepayment(new LoanAmount("USD", principal), interestRate, new LoanTerm(termInYears));

            Assert.That(monthlyPayment, Is.EqualTo(expectedMonthlyPayment));

        }

        [Test]
        [TestCase(200_000, 6.5, 30, ExpectedResult = 1264.14)]
        [TestCase(200_000, 10, 30, ExpectedResult = 1755.14)]
        [TestCase(500_000, 10, 10, ExpectedResult = 6607.54)]
        public decimal CalculateCorrectlyMonthlyRepayment_SimplifiedTestCase(decimal principal,
                                               decimal interestRate,
                                               int termInYears)
        {
            var sut = new LoanRepaymentCalculator();
            return sut.CalculateMonthlyRepayment(new LoanAmount("USD", principal), interestRate, new LoanTerm(termInYears));
        }

        [Test]
        [TestCaseSource(typeof(MonthlyRepaymentTestData),"TestCases")]
        public void CalculateCorrectlyMonthlyRepayment_Centralized(decimal principal,
                                                       decimal interestRate,
                                                       int termInYears,
                                                       decimal expectedMonthlyPayment)
        {
            var sut = new LoanRepaymentCalculator();
            var monthlyPayment = sut.CalculateMonthlyRepayment(new LoanAmount("USD", principal), interestRate, new LoanTerm(termInYears));

            Assert.That(monthlyPayment, Is.EqualTo(expectedMonthlyPayment));

        }
        [Test]
        [TestCaseSource(typeof(MonthlyRepaymentTestDataWithReturn), "TestCases")]
        public decimal CalculateCorrectlyMonthlyRepayment_CentralizedWithReturn(decimal principal,
                                       decimal interestRate,
                                       int termInYears)
        {
            var sut = new LoanRepaymentCalculator();
            return sut.CalculateMonthlyRepayment(new LoanAmount("USD", principal), interestRate, new LoanTerm(termInYears));
        }


        [Test]
        [TestCaseSource(typeof(MonthlyRepaymentCsvData), "GetTestCases", new object[] { "Data.csv" })]
        public void CalculateCorrectlyMonthlyRepayment_Csv(decimal principal,
                                       decimal interestRate,
                                       int termInYears,
                                       decimal expectedMonthlyPayment)
        {
            var sut = new LoanRepaymentCalculator();
            var monthlyPayment = sut.CalculateMonthlyRepayment(new LoanAmount("USD", principal), interestRate, new LoanTerm(termInYears));
            Assert.That(monthlyPayment, Is.EqualTo(expectedMonthlyPayment));
        }

        [Test]
        [Combinatorial]
        public void CalculateCorrectlyMonthlyRepayment_Combinational([Values(100_000, 200_000, 500_000)] decimal principal,
                                                                     [Values(6.5, 10, 20)] decimal interestRate,
                                                                     [Values(10, 20, 30)] int termInYears)
        {
            var sut = new LoanRepaymentCalculator();
            var monthlyPayment = sut.CalculateMonthlyRepayment(new LoanAmount("USD", principal), interestRate, new LoanTerm(termInYears));

        }


        [Test]
        [Sequential]
        public void CalculateCorrectlyMonthlyRepayment_Sequential([Values(100_000, 200_000, 500_000)] decimal principal,
                                                                     [Values(6.5, 10, 20)] decimal interestRate,
                                                                     [Values(10, 20, 30)] int termInYears,
                                                                     [Values(1135.48, 1930.04, 8355.09)] decimal expectedMonthlyPayment)
        {
            var sut = new LoanRepaymentCalculator();
            var monthlyPayment = sut.CalculateMonthlyRepayment(new LoanAmount("USD", principal), interestRate, new LoanTerm(termInYears));
            Assert.That(monthlyPayment, Is.EqualTo(expectedMonthlyPayment));
            
        }
    }
}
