using System.Collections.Generic;
using System.Xml.Serialization;

namespace Scheduler.BusinessLogicLibrary.Model
{
    public class PaymentOrder
    {
        ///
        public string DATA_SOURCE { get; set; }
        /// 
        public string INVOICE_NUM { get; set; }
        /// 
        public string VENDOR_NAME { get; set; }
        /// 
        public double INVOICE_AMOUNT { get; set; }
        /// 
        public double INVOICE_FUNCTIONAL_CURR_AMT { get; set; }
        /// 
        public string INVOICE_CURRENCY_CODE { get; set; }
        /// 
        public string INVOICE_DATE { get; set; }
        /// 
        public string EXCHANGE_RATE { get; set; }
        /// 
        public string EXCHANGE_RATE_TYPE { get; set; }
        /// 
        public string EXCHANGE_DATE { get; set; }
        /// 
        public string DESCRIPTION { get; set; }
        /// 
        public string GOODS_RECEIVED_DATE { get; set; }
        /// 
        public string INVOICE_RECEIVED_DATE { get; set; }
        /// 
        public string GL_DATE { get; set; }
        /// 
        public int CONTROL_AMOUNT { get; set; }
        /// 
        public string ACCOUNTING_DATE { get; set; }
        /// 
        public int LINE_NUMBER { get; set; }
        /// 
        public string LINE_TYPE_LOOKUP_CODE { get; set; }
        /// 
        public double LINE_AMOUNT { get; set; }
        /// 
        public double LINE_FUNCTIONAL_CURR_AMT { get; set; }
        /// 
        public string LINE_DESCRIPTION { get; set; }
        /// 
        public string BALANCING_SEGMENT { get; set; }
        /// 
        public string COST_CENTER_SEGMENT { get; set; }
        /// 
        public string ACCOUNT_SEGMENT { get; set; }
        /// 
        public string SUB_ACCOUNT { get; set; }
        /// 
        public string ANALYSIS_KEY { get; set; }
        /// 
        public string ATTRIBUTE1 { get; set; }
        /// 
        public string ATTRIBUTE2 { get; set; }
        /// 
        public string ATTRIBUTE3 { get; set; }
        /// 
        public string PREPAYMENT_NO { get; set; }
        /// 
        public string PREPAYMENT_AMT { get; set; }
        /// 
        public string HDR_ATTRIBUTE1 { get; set; }
        /// 
        public string HDR_ATTRIBUTE2 { get; set; }
        /// 
        public string HDR_ATTRIBUTE3 { get; set; }
        /// 
        public string HDR_ATTRIBUTE4 { get; set; }
        /// 
        public string HDR_ATTRIBUTE5 { get; set; }
        /// 
        public string HDR_ATTRIBUTE6 { get; set; }
        /// 
        public string HDR_ATTRIBUTE7 { get; set; }
        /// 
        public string HDR_ATTRIBUTE8 { get; set; }
        /// 
        public string HDR_ATTRIBUTE9 { get; set; }
        /// 
        public string HDR_ATTRIBUTE10 { get; set; }
        /// 
        public string HDR_ATTRIBUTE11 { get; set; }
        /// 
        public string HDR_ATTRIBUTE12 { get; set; }
        /// 
        public string DOC_CATEGORY_CODE { get; set; }
        /// 
        public string VENDOR_ID { get; set; }
        /// 
        public string VENDOR_SITE_ID { get; set; }
        /// 
        public string INVOICE_TYPE_LOOKUP_CODE { get; set; }
        /// 
        public string ORG_ID { get; set; }
        /// 
        public string INV_URL { get; set; }
        /// 
        public string AMOUNT_INCLUDES_TAX_FLAG { get; set; }
        /// 
        public string TAX_CODE { get; set; }
        /// 
        public string AWT_GROUP_NAME { get; set; }
        /// 
        public string ATTRIBUTE5 { get; set; }
        /// 
        public string ATTRIBUTE4 { get; set; }
        /// 
        public string ATTRIBUTE6 { get; set; }
        /// 
        public string ATTRIBUTE7 { get; set; }
        /// 
        public string ATTRIBUTE8 { get; set; }
        /// 
        public string ASSETS_TRACKING_FLAG { get; set; }
        /// 
        public string PAYMENT_METHOD_LOOKUP_CODE { get; set; }
        /// 
        public string SHIP_TO_LOCATION { get; set; }
    }

}
