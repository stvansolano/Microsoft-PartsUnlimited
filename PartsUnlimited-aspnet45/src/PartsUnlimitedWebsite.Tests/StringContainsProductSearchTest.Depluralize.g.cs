using Microsoft.Pex.Framework.Generated;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PartsUnlimited.Models;
using PartsUnlimited.ProductSearch;
// <copyright file="StringContainsProductSearchTest.Depluralize.g.cs">Copyright © Microsoft 2015</copyright>
// <auto-generated>
// This file contains automatically generated tests.
// Do not modify this file manually.
// 
// If the contents of this file becomes outdated, you can delete it.
// For example, if it no longer compiles.
// </auto-generated>
using System;

namespace PartsUnlimited.ProductSearch.Tests
{
	public partial class StringContainsProductSearchTest
	{

[TestMethod]
[PexGeneratedBy(typeof(StringContainsProductSearchTest))]
[PexRaisedException(typeof(NullReferenceException))]
public void DepluralizeThrowsNullReferenceException437()
{
    StringContainsProductSearch stringContainsProductSearch;
    string s;
    stringContainsProductSearch =
      new StringContainsProductSearch((IPartsUnlimitedContext)null);
    s = this.Depluralize(stringContainsProductSearch, (string)null);
}

[TestMethod]
[PexGeneratedBy(typeof(StringContainsProductSearchTest))]
public void Depluralize20()
{
    StringContainsProductSearch stringContainsProductSearch;
    string s;
    stringContainsProductSearch =
      new StringContainsProductSearch((IPartsUnlimitedContext)null);
    s = this.Depluralize(stringContainsProductSearch, "\0\0\0");
    Assert.AreEqual<string>("\0\0\0", s);
    Assert.IsNotNull((object)stringContainsProductSearch);
}

[TestMethod]
[PexGeneratedBy(typeof(StringContainsProductSearchTest))]
[PexRaisedException(typeof(ArgumentOutOfRangeException))]
public void DepluralizeThrowsArgumentOutOfRangeException834()
{
    StringContainsProductSearch stringContainsProductSearch;
    string s;
    stringContainsProductSearch =
      new StringContainsProductSearch((IPartsUnlimitedContext)null);
    s = this.Depluralize(stringContainsProductSearch, "\0\0s");
}

[TestMethod]
[PexGeneratedBy(typeof(StringContainsProductSearchTest))]
public void Depluralize285()
{
    StringContainsProductSearch stringContainsProductSearch;
    string s;
    stringContainsProductSearch =
      new StringContainsProductSearch((IPartsUnlimitedContext)null);
    s = this.Depluralize(stringContainsProductSearch, "\0H\b");
    Assert.AreEqual<string>("\0h\b", s);
    Assert.IsNotNull((object)stringContainsProductSearch);
}

[TestMethod]
[PexGeneratedBy(typeof(StringContainsProductSearchTest))]
public void Depluralize291()
{
    StringContainsProductSearch stringContainsProductSearch;
    string s;
    stringContainsProductSearch =
      new StringContainsProductSearch((IPartsUnlimitedContext)null);
    s = this.Depluralize(stringContainsProductSearch, "\0es");
    Assert.AreEqual<string>("\0e", s);
    Assert.IsNotNull((object)stringContainsProductSearch);
}

[TestMethod]
[PexGeneratedBy(typeof(StringContainsProductSearchTest))]
public void Depluralize246()
{
    StringContainsProductSearch stringContainsProductSearch;
    string s;
    stringContainsProductSearch =
      new StringContainsProductSearch((IPartsUnlimitedContext)null);
    s = this.Depluralize(stringContainsProductSearch, "ies");
    Assert.AreEqual<string>("y", s);
    Assert.IsNotNull((object)stringContainsProductSearch);
}

[TestMethod]
[PexGeneratedBy(typeof(StringContainsProductSearchTest))]
public void Depluralize52()
{
    StringContainsProductSearch stringContainsProductSearch;
    string s;
    stringContainsProductSearch =
      new StringContainsProductSearch((IPartsUnlimitedContext)null);
    s = this.Depluralize(stringContainsProductSearch, "");
    Assert.AreEqual<string>("", s);
    Assert.IsNotNull((object)stringContainsProductSearch);
}

[TestMethod]
[PexGeneratedBy(typeof(StringContainsProductSearchTest))]
public void Depluralize698()
{
    StringContainsProductSearch stringContainsProductSearch;
    string s;
    stringContainsProductSearch =
      new StringContainsProductSearch((IPartsUnlimitedContext)null);
    s = this.Depluralize(stringContainsProductSearch, "sies");
    Assert.AreEqual<string>("sy", s);
    Assert.IsNotNull((object)stringContainsProductSearch);
}
	}
}
