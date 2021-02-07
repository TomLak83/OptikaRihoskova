using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OptikaRihoskova.Models
{
    public class Appointment
    {
        public int Id { get; set; }
        public string ClientEmail { get; set; }
        public string Optometrist { get; set; }
        public DateTime StartDateTime { get; set; }
        public int DurationMins { get; set; }
        public bool OptometristConfiremed { get; set; }
        public bool ClientConfirmed { get; set; }
    }
}