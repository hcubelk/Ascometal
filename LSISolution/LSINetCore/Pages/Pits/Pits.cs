using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LSINetCore.Models;

namespace LSINetCore.Pages.Pits
{
    public class Pits
    {
        public LDOrdreFabrication OrdreFabrication;
        public LDConsignes ConsignesScarfing;
        public LDConsignes ConsignesPrelevement;
        public Pits(LDOrdreFabrication ordreFabrication, LDConsignes consignesScarfing, LDConsignes consignesPrelevement)
        {
            OrdreFabrication = ordreFabrication;
            ConsignesScarfing = consignesScarfing;
            ConsignesPrelevement = consignesPrelevement;
        }
    }
}
