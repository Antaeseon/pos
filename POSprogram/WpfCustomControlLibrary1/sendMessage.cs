using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfCustomControlLibrary1
{
    class sendMessage
    {
        /// <summary>
        /// 총 아이템 수
        /// </summary>
        public const int c_totalItemNum = 0;
        /// <summary>
        /// 아이템 id
        /// </summary>
        public const int c_itemId = 1;
        /// <summary>
        /// 아이템 이름
        /// </summary>
        public const int c_itemName = 2;
        /// <summary>
        /// 아이템 수량
        /// </summary>
        public const int c_itemNum = 3;
        /// <summary>
        /// 아이템 가격
        /// </summary>
        public const int c_itemPrice = 4;
        /// <summary>
        /// 아이템 결제가격
        /// </summary>
        public const int c_itemTotal = 5;
        /// <summary>
        /// 아이템 상태 ( 0 : 정상 1: 보류)
        /// </summary>
        public const int c_itemStatus = 6;

        /// <summary>
        /// 정상 아이템
        /// </summary>
        public const int s_normal = 0;
        /// <summary>
        /// 보류된 아이템
        /// </summary>
        public const int s_hold = 1;
    }
}
