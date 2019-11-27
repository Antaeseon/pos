using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosProject
{

    
    class refTb
    {
        private string sItemId;
        private string sDiscountId;

        /// <summary>
        /// 상품의 아이디
        /// </summary>
        public string m_sItemId
        {
            get { return sItemId; }
            set { this.sItemId = value; }
        }
        /// <summary>
        /// 할인코드의 아이디
        /// </summary>
        public string m_sDiscountId
        {
            get { return sDiscountId; }
            set { this.sDiscountId = value; }
        }

    }
}
