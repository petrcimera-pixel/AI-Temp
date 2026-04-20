using System;
using System.Collections.Generic;

namespace Models
{
    public class ComputerInfo
    {
        public string ComputerName { get; set; }
        public string User { get; set; }
        public List<TemperatureReading> TemperatureReadings { get; set; }

        public ComputerInfo()
        {
            TemperatureReadings = new List<TemperatureReading>();
        }
    }

    public class TemperatureReading
    {
        public DateTime Timestamp { get; set; }
        public float Temperature { get; set; }

        public TemperatureReading(DateTime timestamp, float temperature)
        {
            Timestamp = timestamp;
            Temperature = temperature;
        }
    }
}