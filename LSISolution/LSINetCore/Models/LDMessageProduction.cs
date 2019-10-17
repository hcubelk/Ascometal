using System;
using System.Collections.Generic;

namespace LSINetCore.Models
{
    public partial class LDMessageProduction
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string NomUtilisateur { get; set; }
        public string NomTerminal { get; set; }
        public string Message { get; set; }
        public int TypeMessage { get; set; }
        public string Of { get; set; }
    }
}
