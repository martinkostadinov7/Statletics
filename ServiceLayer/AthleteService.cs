using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BusinessLayer;
using DataLayer;
namespace ServiceLayer
{
    public class AthleteService
    {
        private AthleteContext context;

        public AthleteService(AthleteContext context)
        {
            this.context = context;
        }

        
    }
}
