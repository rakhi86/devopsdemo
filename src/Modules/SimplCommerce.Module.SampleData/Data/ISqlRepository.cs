﻿using System.Collections.Generic;

namespace SimplCommerce.Module.SampleData.Data
{
    public interface ISqlRepository
    {
        void RunCommand(string command);

        void RunCommands(IEnumerable<string> command);

        IEnumerable<string> ParseCommand(IEnumerable<string> lines);
    }
}