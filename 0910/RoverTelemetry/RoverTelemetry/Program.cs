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
            string roverNev = "Perseverance";
            int sikeresKuldetesek = telemetryService.GetSuccessfulMissionCountByRover(records, roverNev);
            Console.WriteLine($"{roverNev} sikeres küldetéseinek száma: {sikeresKuldetesek}");

            //5.
            Dictionary<string, int> meresekRoverenkent = telemetryService.GetMeasurementCountPerRover(records);
            Console.WriteLine("Mérések száma roverenként:");
            foreach (KeyValuePair<string, int> par in meresekRoverenkent)
            {
                Console.WriteLine($" {par.Key}: {par.Value}");
            }

            //6.
            List<TelemetryRecord> sikeresRekordok = telemetryService.GetSuccessfulRecords(records);
            telemetryFileManager.WriteSuccessfulRecords("sikeres_telemetria.txt", sikeresRekordok);
            Console.WriteLine($"Sikeres rekordok száma: {sikeresRekordok.Count} (kiírva a sikeres_telemetria.txt fájlba)");
        }
    }
}
