using System;
using System.Collections.Generic;
using System.Text;
using Loans.Domain;
using Loans.Domain.Applications;
using NUnit.Framework;

namespace Loans.Tests
{
    [TestFixture]
    public class LoanTermShould
    {
        [Test]
        public void ReturnTermInMonths()
        {
            var sut = new LoanTerm(1);// sut = system under test

            Assert.That(sut.ToMonths(), Is.EqualTo(12));
        }

        [Test]
        public void NotAllowZeroYears()
        {
            Assert.That(() => new LoanTerm(0), Throws.TypeOf<ArgumentOutOfRangeException>());
        }
        [Test]
        [Ignore("Need to complete update work")]
        public void StoreYears()
        {
            var sut = new LoanTerm(1);// sut = system under test
            Assert.That(sut.Years, Is.EqualTo(1));
        }
    }
}
