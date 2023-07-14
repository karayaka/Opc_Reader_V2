﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Opc_Reader_V2.Models
{
    public class RunHisrtoryModel
    {
        public int ID { get; set; }
        public DateTime TimeStamp { get; set; }

        public Guid RunGuid { get; set; }

        public Guid JobGuid { get; set; }

        public Guid PlanGuid { get; set; }

        public Guid SortGuid { get; set; }

        public int RunNumber { get; set; }

        public int CutState { get; set; }

        public DateTime CutStartTime { get; set; }

        public DateTime CutEndTime { get; set; }
        public double ActualCutTime { get; set; }

        public double ActualStopTime { get; set; }

        public double ActualWaitTime { get; set; }

        public int SortState { get; set; }

        public double SheetOffsetX { get; set; }

        public double SheetOffsetY { get; set; }

        public string ChargeInfo { get; set; }
        public DateTime SortStartTime { get; set; }

        public DateTime SortEndTime { get; set; }
    }
}