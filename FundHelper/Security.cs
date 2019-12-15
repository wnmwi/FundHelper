﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FundHelper
{
    /// <summary>
    /// 证券
    /// </summary>
    abstract class Security
    {
        public string Code { get; set; } // 基金编码
        public string Name { get; set; } //基金名称
        public double? realIncrease { get; set; } //实时涨幅
        public Dictionary<DateTime,double?> historyDic { get; set; }
        public DateTime lastDay { get; set; }

        public abstract void GetHistory();
        public abstract double? GetIncrease(int days);
    }
}
