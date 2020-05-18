using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Events
{
  public class GlassOfWater
  {
    public delegate void TemperatureChangedHandler(
        object sender, TemperatureChangedEventArgs e);
    public event TemperatureChangedHandler TemperatureChanged;
    public event TemperatureChangedHandler Freeze, Melt, Boil, Condensate;
    public GlassOfWater(int temperature)
    {
      this.Temperature = temperature;
    }
    public GlassOfWater()
      : this(20)
    {
    }

    private int m_Temperature;
    public int Temperature
    {
      get { return m_Temperature; }
      private set
      {
        if (value < -273)
          throw new IllegalTemperatureException(value);
        int oldvalue = m_Temperature;
        m_Temperature = value;
        if (TemperatureChanged != null)
          TemperatureChanged(this, new TemperatureChangedEventArgs(value));
        if (oldvalue < 0 && value >= 0 )
          Melt?.Invoke(this, new TemperatureChangedEventArgs(value));
        if (oldvalue >= 0 && value < 0 )
          Freeze?.Invoke(this, new TemperatureChangedEventArgs(value));
        if (oldvalue < 100 && value >= 100 && Boil != null)
          Boil(this, new TemperatureChangedEventArgs(value));
        if (oldvalue >100 && value <= 100 && Condensate  != null)
          Condensate (this, new TemperatureChangedEventArgs(value));
      }
    }
    public void Heat()
    {
      this.Temperature++;
    }
    public void Heat(uint numberOfDegrees)
    {
      for (int i = 0; i < numberOfDegrees; i++)
      {
        this.Heat();
      }
    }
    public void Cool()
    {
      this.Temperature--;
    }
    public void Cool(uint numberOfDegrees)
    {
      for (int i = 0; i < numberOfDegrees; i++)
      {
        this.Cool();
      }
    }

  }
  [Serializable]
  public class IllegalTemperatureException : Exception
  {
    public IllegalTemperatureException(int temperature)
      : this("Illegal temperature: " + temperature.ToString())
    { }
    public IllegalTemperatureException(string message) : base(message) { }
    public IllegalTemperatureException(string message, Exception inner) : base(message, inner) { }
    protected IllegalTemperatureException(
    System.Runtime.Serialization.SerializationInfo info,
    System.Runtime.Serialization.StreamingContext context)
      : base(info, context) { }
  }
  public sealed class TemperatureChangedEventArgs
    : EventArgs
  {
    public readonly int Temperature;
    public TemperatureChangedEventArgs(int temperature)
    {
      this.Temperature = temperature;
    }
  }
}
