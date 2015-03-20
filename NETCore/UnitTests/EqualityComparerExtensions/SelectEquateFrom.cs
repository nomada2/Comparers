﻿using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Nito.Comparers;
using Nito.EqualityComparers;
using Nito.EqualityComparers.Util;

namespace EqualityComparerExtensions_
{
    [TestClass]
    public class _SelectEquateFrom
    {
#if NO
        [TestMethod]
        public void SubstitutesCompareDefaultForComparerDefault()
        {
            var comparer = EqualityComparer<int>.Default.SelectEquateFrom((Person p) => p.Priority);
            Assert.AreSame(EqualityComparerBuilder.For<int>().Default(), (comparer as SelectEqualityComparer<Person, int>).Source);
        }

        [TestMethod]
        public void SubstitutesCompareDefaultForNull()
        {
            IEqualityComparer<int> source = null;
            var comparer = source.SelectEquateFrom((Person p) => p.Priority);
            Assert.AreSame(EqualityComparerBuilder.For<int>().Default(), (comparer as SelectEqualityComparer<Person, int>).Source);
        }
#endif
    }
}