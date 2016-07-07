using System;
using System.Collections.Generic;

namespace WeekdayFinder
{
  public class FindWeekday
  {
    string[] DaysOfWeek = {"Saturday", "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday"};
    public Dictionary<int, int> Months = new Dictionary<int, int>()
    {
      {1,0},
      {2,3},
      {3,3},
      {4,6},
      {5,1},
      {6,4},
      {7,6},
      {8,2},
      {9,5},
      {10,0},
      {11,3},
      {12,5},
      {13,6},
      {14,2}
    };
    public static List<int> Years = new List<int> {0,1,3,5};

    public string EnterOneThroughSeven(int number)
    {
      if (number == 0 || number > 7)
      {
        return "Please enter a number 1-7";
      }
      else
      {
        return DaysOfWeek[number-1];
      }
    }
    public string EnterOneThrough28(int number)
    {
      if (number == 0 || number > 28)
      {
        return "Please enter a number 1-28";
      }
      else
      {
        return DaysOfWeek[(number-1) % 7];
      }
    }
    public string EnterOneThrough365(int number)
    {
      if (number == 0 || number > 365)
      {
        return "Please enter a number 1-365";
      }
      else
      {
        return DaysOfWeek[(number-1) % 7];
      }
    }
    public bool IsLeapYear(int year)
    {
      if (year % 400 == 0)
      {
        return true;
      }
      else if (year % 100 == 0)
      {
        return false;
      }
      else if (year % 4 == 0)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
    public string EnterAnyDate(int day, int month, int year)
    {
      if (!IsLeapYear(year))
      {
        continue;
      }
      else if(IsLeapYear(year) && month == 1 || IsLeapYear(year) && month == 2)
      {
        month += 12;
      }
      var DayOfWeek = (day + Months[month] + (year%100) + ((year%100)/4) + Years[((year-1)/100)%4]) % 7;
      return DaysOfWeek[DayOfWeek];
    }

  }
}
