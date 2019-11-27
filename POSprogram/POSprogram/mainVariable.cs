using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosProject
{
    class mainVariable
    {
        private bool bPayFlag;
        private bool bAdminAccess1;
        private bool bAdminAccess2;
        private bool bAdminFlag;
        private bool bInGrid;
        private bool bPayProgress;
        private int nTotalMoney;
        private int nReceiveMoney;
        /// <summary>
        /// 결제진행중 플래그 
        /// </summary>
        public bool m_bPayFlag
        {
            get { return this.bPayFlag; }
            set { this.bPayFlag = value; }
        }
        /// <summary>
        /// 왼쪽하단 버튼 활성화
        /// </summary>
        public bool m_bAdminAccess1
        {
            get { return this.bAdminAccess1; }
            set { this.bAdminAccess1 = value; }
        }
        /// <summary>
        /// 오른쪽 하단 버튼 활성화
        /// </summary>
        public bool m_bAdminAccess2
        {
            get { return this.bAdminAccess2; }
            set { this.bAdminAccess2 = value; }
        }
       /// <summary>
       /// 관리자 활성화
       /// </summary>
        public bool m_bAdminFlag
        {
            get { return this.bAdminFlag; }
            set { this.bAdminFlag = value; }
        }

        /// <summary>
        /// 
        /// </summary>
        public bool m_bInGrid
        {
            get { return this.bInGrid; }
            set { this.bInGrid = value; }
        }
        public bool m_bPayProgress
        {
            get { return this.bPayProgress; }
            set { this.bPayProgress = value; }
        }
        public int m_nTotalMoney
        {
            get { return this.nTotalMoney; }
            set { this.nTotalMoney = value; }
        }

        public int m_nReceiveMoney
        {
            get { return this.nReceiveMoney; }
            set { this.nReceiveMoney = value; }
        }


        /// <summary>
        /// 변수 초기화
        /// </summary>
        public mainVariable()
        {
            this.bPayFlag = false;
            this.bAdminAccess1 = false;
            this.bAdminAccess2 = false;
            this.bAdminFlag = false;
            this.bInGrid = false;
            this.bPayProgress = false;
            this.nTotalMoney = 0;
            this.nReceiveMoney = 0;
        }
    }
}
