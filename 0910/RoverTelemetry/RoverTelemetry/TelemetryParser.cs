using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoverTelemetry;

namespace RoverTelemetry
{
    class TelemetryParser
    {
        public static TelemetryRecord ParseLine(string line)
        {
            if (string.IsNullOrWhiteSpace(line))
            {
                throw new ArgumentNullException("A sor hibás/üres.");
            }
            string[] adatok = line.Split(';');
            TelemetryRecord record = new TelemetryRecord();
            record.Id = adatok[0];
            record.RoverName = adatok[1];
            record.Date = DateTime.Parse(adatok[2]);
            record.Distance = int.Parse(adatok[3]);

            if (adatok[4] == "Igaz")
            {
                record.IsSuccessful = true;
            } else if (adatok[4] == "Hamis")
            {
                record.IsSuccessful = false;
            }

            return record;
        }
    }
}
