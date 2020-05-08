using System.Collections.Generic;
using System;

public class AlertService
{
  private readonly AlertDAO storage = new AlertDAO();

  public Guid RaiseAlert()
  {
    return this.storage.AddAlert(DateTime.Now);
  }

  public DateTime GetAlertTime(Guid id)
  {
    return this.storage.GetAlert(id);
  }
}

public class AlertDAO
{
  private readonly Dictionary<Guid, DateTime> alerts = new Dictionary<Guid, DateTime>();

  public Guid AddAlert(DateTime time)
  {
    Guid id = Guid.NewGuid();
    this.alerts.Add(id, time);
    return id;
  }

  public DateTime GetAlert(Guid id)
  {
    return this.alerts[id];
  }

  public static void Main(string[] args)
  {
    try
    {
      /* 
      Problem #1
      Implement the UniqueNames method. When passed two arrays of names, 
      it will return an array containing the names that appear in either or both arrays. 
      The returned array should have no duplicates.

      For example, calling MergeNames.UniqueNames(new string[]{'Ava', 'Emma', 'Olivia'}, new string[]{'Olivia', 'Sophia', 'Emma'}) 
      should return an array containing Ava, Emma, Olivia, and Sophia in any order.
      */
      string[] names1 = new string[] { "Ava", "Emma", "Olivia" };
      string[] names2 = new string[] { "Olivia", "Sophia", "Emma" };
    }
    catch (Exception ex)
    {
      Console.WriteLine("Problem #1: " + ex.Message);
    }
  }
}