using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfCustomControlLibrary1
{
    class receiptString
    {
        private string companyName;
        private string companyTel;
        private string companyCeo;
        private string companyAddress;
        private string referText;
        private string divideLine;

        public string m_companyName
        {
            get { return companyName; }
        }
        public string m_companyTel
        {
            get { return companyTel; }
        }
        public string m_companyCeo
        {
            get { return companyCeo; }
        }
        public string m_companyAddress
        {
            get { return companyAddress; }
        }

        public string m_referText
        {
            get { return referText; }
        }

        public string m_divideLine
        {
            get { return divideLine; }
        }
        public receiptString()
        {
            this.companyName = "emart";
            this.companyTel = "이마트 성수점 (02)1234-1234";
            this.companyCeo = "111-12-12345 안태선";
            this.companyAddress = "서울시 성동구 뚝섬로 379";
            this.referText= "영수증 미지참시 교환/환불 불가(30일내)\n" +
                "교환/환불 구매점에서 가능 (결제카드 지참)\n" +
                "체크카드/신용카드 청구취소 반영은\n" +
                "최대 3~5일 소요 (주말 공휴일 제외)";
            this.divideLine = "---------------------------------------------------\n";
        }
    }
}
