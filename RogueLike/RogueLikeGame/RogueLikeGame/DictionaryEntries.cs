﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RogueLikeGame
{
    class DictionaryEntries
    {
        public string Key { get; set; }
        public int Value { get; set; }

        public DictionaryEntries(string key, int value)
        {
            this.Key = key;
            this.Value = value;
        }
    }
}