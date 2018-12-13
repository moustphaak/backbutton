using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BackButtonCIick10
{

    public class AccueilMenuItem
    {
        public AccueilMenuItem()
        {
            TargetType = typeof(AccueilDetail);
        }
        public int Id { get; set; }
        public string Title { get; set; }

        public Type TargetType { get; set; }
    }
}