using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StatTrackerLib.Models;

namespace StatTrackerLib.DataAccess
{
    public class TextConnector : IDataConnection
    {
        //TODO - Wire up the CreatePrize from text files.
        public PrizeModel CreatePrize(PrizeModel model)
        {
            model.Id = 1;

            return model;
        }
    }
}
