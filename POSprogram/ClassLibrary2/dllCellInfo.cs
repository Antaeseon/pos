using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary2
{
    public class dllCellInfo
    {
        private int cItemId;
        private int cItemName;
        private int cItemNum;
        private int cItemPrice;
        private int cItemTotal;
        private int cItemStatus;

        /// <summary>
        /// 0번째 열 : 상품Id
        /// </summary>
        public int m_cItemId
        { get { return this.cItemId; } }
        /// <summary>
        /// 1번째 열 : 상품 이름
        /// </summary>
        public int m_cItemName
        { get { return this.cItemName; } }
        /// <summary>
        /// 2번째 열 : 상품 수량
        /// </summary>
        public int m_cItemNum
        { get { return this.cItemNum; } }
        /// <summary>
        /// 3번째 열 : 상품 가격
        /// </summary>
        public int m_cItemPrice
        { get { return this.cItemPrice; } }
        /// <summary>
        /// 4번째 열 : 상품 합계가격
        /// </summary>
        public int m_cItemTotal
        { get { return this.cItemTotal; } }
        /// <summary>
        /// 5번째 열 : 상품 지정취소 상태
        /// </summary>
        public int m_cItemStatus
        { get { return this.cItemStatus; } }

        public dllCellInfo()
        {
            this.cItemId = 0;
            this.cItemName = 1;
            this.cItemPrice = 2;
            this.cItemNum = 3;
            this.cItemTotal = 4;
            this.cItemStatus = 5;
        }
    }
}
