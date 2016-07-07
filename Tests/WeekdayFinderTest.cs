using System;
using System.Collections.Generic;
using Xunit;

namespace WeekdayFinder
{
  public class WeekdayFinderTest
  {
    // [Fact]
    // public void EnterOneThroughSeven_Return_DayOfWeek()
    // {
    //   FindWeekday day = new FindWeekday();
    //   Assert.Equal("Monday", day.EnterOneThroughSeven(1));
    // }
    // [Fact]
    // public void EnterOneThrough28_Return_DayOfWeek()
    // {
    //   FindWeekday day = new FindWeekday();
    //   Assert.Equal("Monday", day.EnterOneThrough28(15));
    // }
    // [Fact]
    // public void EnterOneThrough365_Return_DayOfWeek()
    // {
    //   FindWeekday day = new FindWeekday();
    //   Assert.Equal("Monday", day.EnterOneThrough365(29));
    // }
    [Fact]
    public void EnterAnyDate_Return_DayOfWeek()
    {
      FindWeekday day = new FindWeekday();
      Assert.Equal("Thursday", day.EnterAnyDate(7,7,2016));
    }
  }
}
