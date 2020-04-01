using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dispatch
{
    class OrderOp
    {
        public int OD_NUM_ID;//指令序号
        public int OD_ID;//调度令序号
        public int NUM;//调度指令序号
        public string ORDER_TYPE;//任务类型
        public int TR_ID;//发射机序号
        public int AN_ID;//天线序号
        public string START_DATE;//开始执行日期
        public string END_DATE;//结束执行日期
        public string START_TIME;//开始播音时间
        public string END_TIME;//结束播音时间
        public int FREQ;//频率
        public int POWER;//功率
        public int PG_ID;//节目序号
        public string AZIMUTH_M;//方向
        public string AZIMUTH_DE;//偏向
        public string ANT_PROG;//
        public string OPERATE;//操作，0-停，1-开
        public int TARGET;//对象台
        public string SERV_AREA;//服务区
        public string DAYS;//周期
        public string MSG_NUM;//需求文号
        public string CHANNEL;//节目通道
        public string SEASON;//季节
        public string MOD;//调制方式
        public string RMKS;//备注
        public string STATUS;//状态
        public string STATUS_DATE;//状态日期
        public string INEXE_REASON_CODE;//不可执行原因
        public string INEXE_PERSON;//机房确认人
        public string BROADCAST_TIME;
        public string INNER_INSTEAD_TASK_INFO;
        public string INS_ST_CODE;
        public string INS_TRANS_USED_CODE;

        public OrderOp()
        {

            OD_NUM_ID = -1;
            OD_ID = -1;
            NUM = -1;
            ORDER_TYPE = "";
            TR_ID = -1;
            AN_ID = -1;
            START_DATE = "";
            END_DATE = "";
            START_TIME = "";
            END_TIME = "";
            FREQ = -1;
            POWER = -1;
            PG_ID = -1;
            AZIMUTH_M = "";
            AZIMUTH_DE = "";
            ANT_PROG = "";
            OPERATE = "";
            TARGET = -1;
            SERV_AREA = "";
            DAYS = "";
            MSG_NUM = "";
            CHANNEL = "";
            SEASON = "";
            MOD = "";
            RMKS = "";
            STATUS = "";
            STATUS_DATE = "";
            INEXE_REASON_CODE = "";
            INEXE_PERSON = "";
        }
    }
}
