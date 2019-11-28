using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosProject
{
    class singleItem
    {
        private string sItemId;
        private string sItemName;
        private int nItemPrice;

        /// <summary>
        /// 상품의 아이디
        /// </summary>
        public string m_sItemId
        {
            get { return sItemId; }
            set { this.sItemId = value; }
        }
        /// <summary>
        /// 상품의 이름
        /// </summary>
        public string m_sItemName
        {
            get { return sItemName; }
            set { this.sItemName = value; }
        }
        /// <summary>
        /// 상품의 가격
        /// </summary>
        public int m_nItemPrice
        {
            get { return nItemPrice; }
            set { this.nItemPrice = value; }
        }
        /// <summary>
        /// itemId의 인덱스
        /// </summary>
        public const int c_itemId = 0;
        /// <summary>
        /// itemName의 인덱스
        /// </summary>
        public const int c_itemName = 1;
        /// <summary>
        /// itemPrice의 인덱스
        /// </summary>
        public const int c_itemPrice = 2;


    }



    
}