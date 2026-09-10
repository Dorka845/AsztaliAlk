using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using RoverTelemetry;

namespace RoverTelemetry
{
    class TelemetryFileManager
    {
        public List<TelemetryRecord> ReadAllRecords(string filePath)
        {
            if (File.Exists(filePath))
            {
                throw new FileNotFoundException("A megadott fájl nem létezik.");
            }

            List<TelemetryRecord> records = new List<TelemetryRecord>();
            string[] lines = File.ReadAllLines(filePath);

            for (int i = 1; i < lines.Length; i++)
            {
                TelemetryRecord record = TelemetryParser.ParseLine(lines[i]);
                records.Add(record);
            }
            return records;
        }

        public void WriteSuccessfulRecords(string filePath, List<TelemetryRecord> records)
        {
            
        }
    }
}
