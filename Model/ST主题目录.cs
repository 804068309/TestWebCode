using System;
using System.Collections.Generic;
using System.Text;

namespace Model
{
    /// <summary>
    ///ST主题目录
    /// <summary>
    public class ST主题目录
    {
        /// <summary>
        /// ID:
        /// <summary>
        public long? ID { get; set; }

        /// <summary>
        /// 主题组合目录ID:
        /// <summary>
        public long? 主题组合目录ID { get; set; }

        /// <summary>
        /// 下钻树ID:
        /// <summary>
        public long? 下钻树ID { get; set; }

        /// <summary>
        /// 名称:
        /// <summary>
        public string 名称 { get; set; }

        /// <summary>
        /// 说明:
        /// <summary>
        public string 说明 { get; set; }

        /// <summary>
        /// 序号:
        /// <summary>
        public int? 序号 { get; set; }

        /// <summary>
        /// 启用标识:0=停用 1=启用
        /// <summary>
        public int? 启用标识 { get; set; }

        /// <summary>
        /// 显示标识:0=不显示 1=显示
        /// <summary>
        public int? 显示标识 { get; set; }

    }
}
