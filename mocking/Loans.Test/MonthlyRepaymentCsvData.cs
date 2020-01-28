using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Loans.Tests
{
    public class MonthlyRepaymentCsvData
    {
        public static IEnumerable GetTestCases(string csvFileName)
        {
            var csvLines = File.ReadAllLines(csvFileName);
            var testCases = new List<TestCaseData>();

            foreach (var line in csvLines)
            {
                var values = line.Split(",");
                decimal principal = decimal.Parse(values[0]);
                decimal interestRate = decimal.Parse(values[1]);
                int termInYears = int.Parse(values[2]);
                decimal expectedRepayment = decimal.Parse(values[3]);

                yield return new TestCaseData(principal, interestRate, termInYears, expectedRepayment);
                //testCases.Add(new TestCaseData(principal, interestRate, termInYears, expectedRepayment));
            }

            //return testCases;                
        }
    }
}
