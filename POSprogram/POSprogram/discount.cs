using System;

using System.Collections.Generic;

using System.Linq;

using System.Text;

using System.Threading.Tasks;



namespace PosProject

{
    class discount
    {
        /// <summary>
        /// 상품코드
        /// </summary>
        public string sDiscountId { get; set; }
        /// <summary>
        /// 카테고리( 1: 금액 2: 율(%) 3: N+1 )
        /// </summary>
        public int nCategory { get; set; }
        /// <summary>
        /// 상품의 할인 정보
        /// </summary>
        public int nDiscount { get; set; }

        /////
        ///
        public int nId = 0;
    }
}