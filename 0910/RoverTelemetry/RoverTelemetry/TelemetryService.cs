using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoverTelemetry;

namespace RoverTelemetry
{
    class TelemetryService
    {
        //1.
        public int GetTotalMeasurementCount(List<TelemetryRecord> records)
        {
            if (records == null || records.Count == 0)
                return 0;
            return records.Count;
        }

        //2.
        public int GetTotalDistance(List<TelemetryRecord> records)
        {
            if (records == null || records.Count == 0)
                return 0;

            int osszTavolsag = 0;
            foreach (TelemetryRecord record in records) 
                osszTavolsag += record.Distance;
            
            return osszTavolsag;
        }

        //3.
        public TelemetryRecord? GetLongestDailyDistanceRecord(List<TelemetryRecord> records)
        {
            if (records == null || records.Count == 0)
                return null;

            TelemetryRecord leghosszabb = records[0];
            foreach (TelemetryRecord record in records)
            {
                if (record.Distance > leghosszabb.Distance)
                {
                    leghosszabb = record;
                }
            }
            return leghosszabb;
        }

        //4.
        public int GetSuccessfulMissionCountByRover(List<TelemetryRecord> records, string roverName)
        {
            bool roverLetezik = false;
            int sikeresKuldetesek = 0;

            if (records != null)
            {
                foreach (TelemetryRecord record in records)
                {
                    roverLetezik = true;
                    if (record.IsSuccessful == true)
                    {
                        sikeresKuldetesek++;
                    }
                }
            }
            if (roverLetezik == false)
            {
                throw new KeyNotFoundException("A rover nem található.");
            }
            return sikeresKuldetesek;
        }

        //5.
        public Dictionary<string, int> GetMeasurementCountPerRover(List<TelemetryRecord> records)
        {
            Dictionary<string, int> eredmeny = new Dictionary<string, int>();
            if (records == null || records.Count == 0)
                return eredmeny;

            foreach (TelemetryRecord record in records)
            {
                if (eredmeny.ContainsKey(record.RoverName))
                    eredmeny[record.RoverName]++;
                else
                    eredmeny.Add(record.RoverName, 1);
            }
            return eredmeny;
        }

        //6.
        public List<TelemetryRecord> GetSuccessfulRecords(List<TelemetryRecord> records)
        {
            List<TelemetryRecord> sikeres = new List<TelemetryRecord>();
            if (records == null || records.Count == 0)
                return sikeres;

            foreach (TelemetryRecord record in records)
            {
                if (record.IsSuccessful == true) 
                    sikeres.Add(record);
            }
            return sikeres;
        }
    }
}
