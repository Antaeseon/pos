using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfCustomControlLibrary1
{
    class fileReadFunction
    {

        /// <summary>
        /// 상품 마스터에있는 List 반환
        /// </summary>

        public static List<singleItem> getSingleItemList(string path = "item.mst")
        {
            string line;
            List<singleItem> itemList = new List<singleItem>();
            Hashtable hashtable = new Hashtable();
            System.IO.StreamReader masterItem =
                new System.IO.StreamReader(@"" + path);
            while ((line = masterItem.ReadLine()) != null)
            {
                char sep = ',';
                string[] result = line.Split(sep);

                for (int i = 0; i < result.Length; i++)
                {
                    if (result[i] == "")
                    {
                        throw new Exception("item 마스터 파일 문자열에 공백이 있습니다.");
                    }
                }

                if (result.Length != 3)
                {
                    throw new Exception("상품 마스터 파일 문자열이 잘못되었습니다.");
                }
                if (Convert.ToInt32(result[singleItem.c_itemPrice]) <= 0)
                {
                    throw new Exception(result[singleItem.c_itemId] + " 상품의 가격이 0원 이하입니다.");
                }
                if (hashtable.ContainsKey(result[singleItem.c_itemId]))
                {
                    throw new Exception(result[singleItem.c_itemId] + " 상품의 키가 중복됩니다.");
                }
                hashtable.Add(result[singleItem.c_itemId], true);
                itemList.Add(new singleItem()
                {
                    m_sItemId = result[singleItem.c_itemId],
                    m_sItemName = result[singleItem.c_itemName],
                    m_nItemPrice = Convert.ToInt32(result[singleItem.c_itemPrice])
                });
            }
            if (itemList.Count == 0)
            {
                throw new Exception("아이템 mst가 비어있습니다.");
            }
            masterItem.Close();
            return itemList;
        }



        public static List<tran> getTranList()
        {
            List<tran> tranList = new List<tran>();
            System.IO.StreamReader masterTran =
                 new System.IO.StreamReader(@"tran.mst");
            string line;
            while ((line = masterTran.ReadLine()) != null)
            {
                List<sItem> tItemList = new List<sItem>();
                sItem tempS;
                char sep = ',';
                string[] result = line.Split(sep);
                int resReceiveMoneyIndex = result.Length - 4;
                int resDiscountMoneyIndex = result.Length - 3;
                int resPriceMoneyIndex = result.Length - 2;
                int resTotalMoneyIndex = result.Length - 1;
                for (int i = 4; i < result.Length - 4; i++)
                {
                    tempS.sTranItemId = result[i++];
                    tempS.nTranItemNum = Convert.ToInt32(result[i++]);
                    tempS.sTranItemStatus = result[i];
                    tItemList.Add(tempS);
                }

                tranList.Add(new tran()
                {
                    m_nStatus = Convert.ToInt32(result[tran.c_status]),
                    m_sDate = result[tran.c_date],
                    m_sPosId = result[tran.c_posId],
                    m_sTradeId = result[tran.c_tradeId],
                    m_lItem = tItemList,
                    m_nReceiveMoney = Convert.ToInt32(result[resReceiveMoneyIndex]),
                    m_nPriceMoney = Convert.ToInt32(result[resPriceMoneyIndex]),
                    m_nDiscountMoney = Convert.ToInt32(result[resDiscountMoneyIndex]),
                    m_nTotalMoney = Convert.ToInt32(result[resTotalMoneyIndex])
                });
            }
            masterTran.Close();
            return tranList;
        }
    }
}
