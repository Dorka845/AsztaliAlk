using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RoverTelemetry;

namespace RoverTelemetry
{
    class Program
    {
        static void Main(string[] args)
        {
            TelemetryFileManager telemetryFileManager = new TelemetryFileManager();
            List<TelemetryRecord> records = telemetryFileManager.ReadAllRecords("telemetria.txt");

            TelemetryService telemetryService = new TelemetryService();

            //1.
            int meresekSzama = telemetryService.GetTotalMeasurementCount(records);
            Console.WriteLine("Mérések száma: " + meresekSzama);

            //2.
            int osszTavolsag = telemetryService.GetTotalDistance(records);
            Console.WriteLine("Összes megtett távolság: " + osszTavolsag + " méter");

            //3.
            TelemetryRecord leghosszabb = telemetryService.GetLongestDailyDistanceRecord(records);
            Console.WriteLine($"Leghosszabb napi távolság: \n Rover: {leghosszabb.RoverName}, Dátum: {leghosszabb.Date}, Távolság: {leghosszabb.Distance}");

            //4.


            //5.


            //6.


        }
    }
}
