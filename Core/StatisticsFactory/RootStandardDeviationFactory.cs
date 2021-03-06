﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.StatisticsFactory
{
    public class RootStandardDeviationFactory : IStatisticsFactory
    {
        public override IDataTransformer GetDataTransformer()
        {
            return new RootTransformer();
        }

        public override IMeanCalculator GetMeanCalculator()
        {
            return new StandardDeviationCalculator();
        }
    }
}
