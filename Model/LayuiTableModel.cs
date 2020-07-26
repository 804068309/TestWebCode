using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    public class LayuiTableModel<T>
    {
        public int code { get; set; }
        public string msg { get; set; }
        public int count { get; set; }
        public List<T> data { get; set; }
    }
}
