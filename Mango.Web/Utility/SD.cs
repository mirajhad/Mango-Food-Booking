﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mango.Web.Utility
{
    public class SD
    {
        public static string CouponAPIBase {  get; set; }
        public static string AuthAPIBase {  get; set; }
        public enum ApiType
        {
            GET,
            POST, 
            PUT, 
            DELETE
        }
    }
}
