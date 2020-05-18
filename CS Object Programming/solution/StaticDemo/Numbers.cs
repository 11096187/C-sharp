using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace StaticDemo
{
  public class Numbers
  {
    private static readonly int[] filenumbers;
    static Numbers()
    {
      Console.WriteLine("calling static constructor");
      filenumbers = new int[200];
      string s;
      StreamReader sr = null;
      try
      {
        sr = new StreamReader("..\\..\\test.txt");
        for (int i = 0; i < filenumbers.Length ; i++)
        {
          s = sr.ReadLine();
          filenumbers[i]= Convert.ToInt32(s);
        }
      }
      catch
      {
      }
      finally
      {
        if (sr != null)
          sr.Close();
      }
    }
    public int GetNumber(int index)
    {
      if (index >= 0 && index < filenumbers.Length )
        return filenumbers[index];
      else
        return 0;
    }
  }
}