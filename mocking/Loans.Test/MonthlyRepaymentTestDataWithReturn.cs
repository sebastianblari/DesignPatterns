﻿using NUnit.Framework;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Loans.Tests
{
    public class MonthlyRepaymentTestDataWithReturn
    {
        public static IEnumerable TestCases
        {
            get
            {
                yield return new TestCaseData(200_000m, 6.5m, 30).Returns(1264.14m);
                yield return new TestCaseData(200_000m, 10m, 30).Returns(1755.14m);
                yield return new TestCaseData(500_000m, 10m, 10).Returns(6607.54m);
            }
        }
    }
}
