﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyICommand.MyICommand;
using Utilities;

namespace MyICommand.MyICommand.CampaignCommands
{
    public class InsertCampaign : CommandManager, ICommand
    {
        public InsertCampaign(Logger log) : base(log)
        {
        }

        public object ExecuteCommand(params object[] param)
        {
            throw new NotImplementedException();
        }
    }
}