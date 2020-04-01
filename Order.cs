using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dispatch
{
    class Order
    {
        public int OD_ID;//调度令序号
        public int ORDER_YEAR;//年份
        public string ORDER_CODE;//文号
        public string SOURCE_TYPE;//调度令性质
        public string ORDER_STATUS;//状态
        public string STATUS_DATE;//状态日期
        public string SENDER;//发送人
        public string SEND_DATE;//发送时间
        public string SEND_ASSESSOR;//发送审核人
        public string SEND_DEPT;//发送单位
        public string RECEIVER;//台站接收人
        public string RECEIVER_DATE;//接收时间
        public string CORRECTOR;//接收校对人
        public string CORRECT_DATE;//校对时间
        public string RMKS;//备注
        public string CREATE_TYPE;//创建类型
        public string INS_ST_CODE;//故障台站编号
        public string INS_TRANS_CODE;//故障发射机使用编号
        public string REASON;//代播原因
        public string ORDER_FORMAT;//任务格式
        public string FLAG_REPLY;//可执行反馈
        public string REPLY_DATE;//可执行反馈时间
        public string INSTEAD_FLAG;
        public int INS_ID;//
        public Order()
        { 
            OD_ID=-1;
            ORDER_YEAR=-1;
            ORDER_CODE="";
            SOURCE_TYPE="";
            ORDER_STATUS = "";
            STATUS_DATE = "";
            SENDER = "";
            SEND_DATE = "";
            SEND_ASSESSOR = "";
            SEND_DEPT = "";
            RECEIVER = "";
            RECEIVER_DATE = "";
            CORRECTOR = "";
            CORRECT_DATE = "";
            RMKS = "";
            CREATE_TYPE = "";
            INS_ST_CODE = "";
            INS_TRANS_CODE = "";
            REASON = "";
            ORDER_FORMAT = "";
            FLAG_REPLY = "";
            REPLY_DATE = "";
            INSTEAD_FLAG = "";
            INS_ID = -1;
        }
    }
}
