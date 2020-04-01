using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dispatch
{
    class RSData
    {

        public string commType = "";//通讯类型的定义
        public string commTime = "";//通讯时间的定义

        //调令下发的操作变量
        public List<Order> downOrderList = null;//调令集
        public List<OrderOp> downOrderOpList = null;//调度指令集
        public List<OrderRecord> downOrderRecordList = null;//调令跟踪记录

        public RSData()
        {
        }
    }
}
