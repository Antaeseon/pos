using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace PosProject

{
    class discount
    {
        private string sDiscountId;
        private int nCategory;
        private int nDiscount;

        /// <summary>
        /// 할인행사 Id
        /// </summary>
        public string m_sDiscountId
        {
            get { return this.sDiscountId; }
            set { this.sDiscountId = value; }
        }
        /// <summary>
        /// 카테고리( 1: 금액 2: 율(%) 3: N+1 )
        /// </summary>
        public int m_nCategory
        {
            get { return nCategory; }
            set { this.nCategory = value; }
        }
        /// <summary>
        /// 상품의 할인 정보
        /// </summary>
        public int m_nDiscount
        {
            get { return this.nDiscount; }
            set { this.nDiscount = value; }
        }
        
        //////////////////////변수목록

        /// <summary>
        /// 가격할인
        /// </summary>
        public const int s_categoryPrice = 1;
        /// <summary>
        /// 퍼센트할인
        /// </summary>
        public const int s_categoryPercent = 2;
        /// <summary>
        /// N+1 할인
        /// </summary>
        public const int s_categoryNplus1 = 3;
        /// <summary>
        /// discount Id
        /// </summary>
        public const int c_discountId = 0;
        /// <summary>
        /// category
        /// </summary>
        public const int c_category = 1;
        /// <summary>
        /// 할인양
        /// </summary>
        public const int c_discount = 2;
    }
}