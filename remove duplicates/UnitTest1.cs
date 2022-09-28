using System;
using System.Collections.Generic;
using System.Linq;
using NUnit.Framework;
using ConsoleApp1;


[TestFixture]
public class Test
{
    [Test]
    public void BasicTest()
    {
        Assert.AreEqual(new List<int>() { }, Kata.Unique(new List<int>() { }));
        Assert.AreEqual(new List<int>() { 5, 2, 1, 3 }, Kata.Unique(new List<int>() { 5, 2, 1, 3 }));
        Assert.AreEqual(new List<int>() { 1, 5, 2, 0, -3, 10 }, Kata.Unique(new List<int>() { 1, 5, 2, 0, 2, -3, 1, 10 }));
    }
}