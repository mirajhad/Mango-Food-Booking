﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mango.Services.RewardAPI.Message
{
    public class RewardsMessage
    {
        public string UserId { get; set; }
        public int RewardsActivity { get; set; }
        public int OrderId { get; set; }
    }
}
