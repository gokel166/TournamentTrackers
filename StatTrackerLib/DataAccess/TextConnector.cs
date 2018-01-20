﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StatTrackerLib.Models;
using StatTrackerLib.DataAccess.TextHelpers;

namespace StatTrackerLib.DataAccess
{
    public class TextConnector : IDataConnection
    {
        private const string PrizesFile = "PrizeModels.csv";
        //TODO - Wire up the CreatePrize from text files.
        public PrizeModel CreatePrize(PrizeModel model)
        {
            // Load the text file
            // Convert the text to List<PrizeModels>
            List<PrizeModel> prizes = PrizesFile.FullFilePath().LoadFile().ConvertToPrizeModels();

            // Find the max ID
            int currentId = prizes.OrderByDescending(x => x.Id).First().Id + 1;
            model.Id = currentId;

            // Add the new record with the new ID(max + 1)
            prizes.Add(model);
            
            
            // Convert the prizes to list<string>
            // Save the list<string> to the text file
        }
    }
}
