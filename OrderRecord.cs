using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dispatch
{
    class OrderRecord
    {
        public int OD_ID;//调度令号
        public int OD_NUM_ID;//调度指令序列号
        public string OMS_DOWN_TIME;//台运行系统下发时间
        public string DISPATCH_DOWN_TIME;//分发系统下发时间
        public string DOWN_PERSON;//下发人
        public string RECEIVE_DEPT;//接收部门
        public string RECEIVE_TIME;//接收时间
        public string RECEIVE_PERSON;//接收人
        public string INEXE_REASON;//不可执行原因
        public string BROADCAST_TIME;//开启时间

        public OrderRecord()
        {
            OD_ID = -1;
            OD_NUM_ID = -1;
            OMS_DOWN_TIME = "";
            DISPATCH_DOWN_TIME = "";
            DOWN_PERSON = "";
            RECEIVE_DEPT = "";
            RECEIVE_TIME = "";
            RECEIVE_PERSON = "";
            INEXE_REASON = "";
            BROADCAST_TIME = "";
        }
    }
}
