using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoverTelemetry
{
    class TelemetryRecord
    {
        public string Id {  get; set; }
        public string RoverName { get; set; }
        public DateTime Date { get; set; }
        public int Distance { get; set; }
        public bool IsSuccessful { get; set; }
    }
}
