using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PosProject
{
    class fileReadFunction
    {
        
        /// <summary>
        /// 상품 마스터에있는 List 반환
        /// </summary>

        public static List<singleItem> getSingleItemList(string path ="item.mst")
        {
            string line;
            List<singleItem> itemList = new List<singleItem>();
            Hashtable hashtable = new Hashtable();
            System.IO.StreamReader file =
                new System.IO.StreamReader(@""+path);
            while ((line = file.ReadLine()) != null)
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
                if (Convert.ToInt32(result[2]) <= 0)
                {
                    throw new Exception(result[0] + " 상품의 가격이 0원 이하입니다.");
                }
                if (hashtable.ContainsKey(result[0]))
                {
                    throw new Exception(result[0] + " 상품의 키가 중복됩니다.");
                }
                hashtable.Add(result[0], true);
                itemList.Add(new singleItem()
                {
                    m_sItemId = result[0],
                    m_sItemName = result[1],
                    m_nItemPrice = Convert.ToInt32(result[2])
                });
            }
            if (itemList.Count == 0)
            {
                throw new Exception("아이템 mst가 비어있습니다.");
            }
            file.Close();
            return itemList;
        }

        /// <summary>
        /// 행사 마스터에 있는 행사 리스트 반환
        /// </summary>
        public static List<discount> getDiscountList(string path = "dis.mst")
        {
            string line;
            List<discount> disList = new List<discount>();
            System.IO.StreamReader file2 = new System.IO.StreamReader(@""+path);

            Hashtable hashtable = new Hashtable();

            while ((line = file2.ReadLine()) != null)
            {
                bool flag = false;
                char sep = ',';
                string[] result = line.Split(sep);
                for (int i = 0; i < result.Length; i++)
                {
                    if (result[i] == "")
                    {
                        throw new Exception("할인 마스터 파일 문자열에 공백이 있습니다.");
                    }
                }
                if (result.Length != 3)
                {
                    throw new Exception("할인 마스터 파일 세미콜론 문제");
                }

                if (Convert.ToInt32(result[1]) <= 0 || Convert.ToInt32(result[1]) >= 4)
                {
                    throw new Exception(result[0] + " 행사상품의 카테고리가 잘못되었습니다.");
                }

                if (hashtable.ContainsKey(result[0]))
                {
                    throw new Exception(result[0] + " 행사상품의 키가 중복됩니다.");
                }
                if (Convert.ToInt32(result[1]) == 1)
                {
                    if (Convert.ToInt32(result[2]) <= 0)
                        flag = true;
                }
                else if (Convert.ToInt32(result[1]) == 2)
                {
                    if (Convert.ToInt32(result[2]) <= 0 || Convert.ToInt32(result[2]) >= 100)
                        flag = true;

                }
                else if (Convert.ToInt32(result[1]) == 3)
                {
                    if (Convert.ToInt32(result[2]) <= 0)
                        flag = true;
                }
                if (flag)
                {
                    throw new Exception(result[0] + " 행사상품의 할인값이 잘못되었습니다.");
                }
                hashtable.Add(result[0], true);
                disList.Add(new discount()
                {
                    m_sDiscountId = result[0],
                    m_nCategory = Convert.ToInt32(result[1]),
                    m_nDiscount = Convert.ToInt32(result[2])
                });
            }
            file2.Close();
            return disList;
        }


        /// <summary>
        /// 상품과 행사목록 연결시키는 참조 테이블
        /// </summary>
        public static List<refTb> GetRefTb()
        {
            string line;
            List<refTb> refList = new List<refTb>();
            System.IO.StreamReader file3 = new System.IO.StreamReader(@"ref.mst");
            while ((line = file3.ReadLine()) != null)
            {
                char sep = ',';
                string[] result = line.Split(sep);
                for (int i = 0; i < result.Length; i++)
                {
                    if (result[i] == "")
                    {
                        throw new Exception("ref 마스터 파일 문자열에 공백이 있습니다.");
                    }
                }
                if (result.Length != 2)
                {
                    throw new Exception("ref 마스터 파일 세미콜론 문제");
                }
                refList.Add(new refTb()
                {
                    m_sItemId = result[0],
                    m_sDiscountId = result[1]
                });
            }
            file3.Close();
            return refList;
        }

        /// <summary>
        /// tran의 LIst 반환
        /// </summary>
        public static List<tran> getTranList()
        {
            List<tran> tranList = new List<tran>();
            System.IO.StreamReader file4 =
                 new System.IO.StreamReader(@"tran.mst");
            string line;
            while ((line = file4.ReadLine()) != null)
            {
                List<sItem> s = new List<sItem>();
                sItem tempS;
                char sep = ',';
                string[] result = line.Split(sep);
                for (int i = 4; i < result.Length - 2; i++)
                {
                    tempS.sTranItemId = result[i++];
                    tempS.nTranItemNum = Convert.ToInt32(result[i++]);
                    tempS.sTranItemStatus = result[i];
                    s.Add(tempS);
                }

                tranList.Add(new tran()
                {
                    m_nStatus = Convert.ToInt32(result[0]),
                    m_sDate = result[1],
                    m_sPosId = result[2],
                    m_sTradeId = result[3],
                    m_lItem = s,
                    m_nReceiveMoney = Convert.ToInt32(result[result.Length - 2]),
                    m_nTotalMoney = Convert.ToInt32(result[result.Length - 1])
                });
            }
            file4.Close();
            return tranList;
        }
    }
}
