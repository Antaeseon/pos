using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosProject
{

    public struct sItem
    {
        /// <summary>
        /// 상품의 아이디
        /// </summary>
        public string sTranItemId;
        /// <summary>
        /// 상품의 수량
        /// </summary>
        public int nTranItemNum;
        /// <summary>
        /// 상품의 상태 ( 0 : 정상 , 1 : 보류)
        /// </summary>
        public string sTranItemStatus;
    }
    class tran
    {

        private int nStatus;
        private string sDate;
        private string sPosId;
        private string sTradeId;
        private int nReceiveMoney;
        private int nTotalMoney;
        /// <summary>
        /// 해당 거래의 상태 ( 0 : 보류, 1 : 거래완료, 2 : 일괄취소, 3: 복원 )
        /// </summary>
        public int m_nStatus
        {
            get { return nStatus; }
            set { this.nStatus = value; }
        }
        /// <summary>
        /// 해당 거래의 날짜
        /// </summary>
        public string m_sDate
        {
            get { return sDate; }
            set { this.sDate = value; }
        }
        /// <summary>
        /// 포스의 Id
        /// </summary>
        public string m_sPosId
        {
            get { return sPosId; }
            set { this.sPosId = value; }
        }
        /// <summary>
        /// 해당 거래의 Id
        /// </summary>
        public string m_sTradeId
        {
            get { return this.sTradeId; }
            set { this.sTradeId = value; }
        }
        /// <summary>
        /// 거래가 이루어진 상품 목록
        /// </summary>
        public List<sItem> m_lItem { get; set; }
        /// <summary>
        /// 해당 거래에서 받은 돈
        /// </summary>
        public int m_nReceiveMoney
        {
            get { return this.nReceiveMoney; }
            set { this.nReceiveMoney = value; }
        }
        /// <summary>
        /// 해당 거래의 결제 금액
        /// </summary>
        public int m_nTotalMoney
        {
            get { return this.nTotalMoney; }
            set { this.nTotalMoney = value; }
        }


        ///////////////////////////변수


        /// <summary>
        /// 보류하지 않은 상품
        /// </summary>
        public const int s_itemStatusNormal = 0; 
        /// <summary>
        /// 보류한 상품
        /// </summary>
        public const int s_itemStatusCancel = 1;
        /// <summary>
        /// 거래보류
        /// </summary>
        public const int s_tranHold = 0;
        /// <summary>
        /// 거래완료
        /// </summary>
        public const int s_tranFinish = 1;
        /// <summary>
        /// 거래취소
        /// </summary>
        public const int s_tranCancel = 2;
        /// <summary>
        /// 거래복원
        /// </summary>
        public const int s_tranRecover = 3;

    }
}
