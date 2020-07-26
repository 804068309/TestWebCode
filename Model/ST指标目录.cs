using QWPlatform.DataIntface;
using QWPlatform.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    /// <summary>
    ///ST指标目录
    /// <summary>
    public class ST指标目录
    {
        /// <summary>
        /// ID:
        /// <summary>
        public long? ID { get; set; }

        /// <summary>
        /// 主题ID:
        /// <summary>
        public long? 主题ID { get; set; }

        /// <summary>
        /// 序号:
        /// <summary>
        public int? 序号 { get; set; }

        /// <summary>
        /// 启用标识:
        /// <summary>
        public int? 启用标识 { get; set; }

        /// <summary>
        /// 名称:
        /// <summary>
        public string 名称 { get; set; }

        /// <summary>
        /// 说明:
        /// <summary>
        public string 说明 { get; set; }

        /// <summary>
        /// 明细调阅地址:
        /// <summary>
        public string 明细调阅地址 { get; set; }

        /// <summary>
        /// 显示标识:
        /// <summary>
        public int? 显示标识 { get; set; }

        /// <summary>
        /// 显示表达式:
        /// <summary>
        public string 显示表达式 { get; set; }

        /// <summary>
        /// SQL:
        /// <summary>

        //[ColumnType(DataType.Blob)]
        public string SQL { get; set; }

        /// <summary>
        /// 单位:
        /// <summary>
        public string 单位 { get; set; }

    }
}
