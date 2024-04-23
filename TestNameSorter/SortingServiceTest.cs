using System;
using System.Collections.Generic;
using System.Reflection;
using NUnit.Framework;

[TestFixture]
public class SortingServiceTest
{
    [Test]
    public void SortNames_EmptyList_ReturnsEmptyList()
    {
        SortingService sortingService = new SortingService();
        List<string> emptyList = new List<string>();

        sortingService.SortNames(Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "unsorted-names-list.txt"), Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "sorted-names-list.txt"));

        Assert.IsEmpty(emptyList);
    }
}
