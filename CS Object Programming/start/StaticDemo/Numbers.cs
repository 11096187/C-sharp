using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace StaticDemo
{
  class Numbers
  {
    public int GetNumber(int index)
    {
      string s;
      StreamReader sr = null;
      try
      {
        sr = new StreamReader("..\\..\\test.txt");
        for (int i = 1; i < index; i++)
        {
          s = sr.ReadLine();
          if (s == null) return 0;
        }
        s = sr.ReadLine();
        return Convert.ToInt32(s);
      }
      catch
      {
        return 0;
      }
      finally
      {
        if (sr != null)
          sr.Close();
      }
    }
  }
}