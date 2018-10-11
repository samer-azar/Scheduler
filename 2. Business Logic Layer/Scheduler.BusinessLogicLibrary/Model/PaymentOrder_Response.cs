using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Scheduler.BusinessLogicLibrary.Model
{
    /// Response base class: Message is a generic Type
    public class ResponseMessage<T> where T : class
    {
        /// Success code
        public string SuccessCode { get; set; }
        /// Message
        public T Message { get; set; }
    }


    /// Payment order response model to be used as response to clients, inherits from ResponseMessage base class
    public class PaymentOrder_Response : ResponseMessage<object>
    {
        /// Default constructor
        public PaymentOrder_Response() { }

        /// Parameterized constructor
        public PaymentOrder_Response(string successCode, object message)
        {
            SuccessCode = successCode;
            Message = message;
        }
    }

    public class PaymentOrders_Response : ResponseMessage<List<PaymentOrder>>
    {
        /// Default constructor
        public PaymentOrders_Response() { }

        /// Parameterized constructor
        public PaymentOrders_Response(string successCode, List<PaymentOrder> message)
        {
            SuccessCode = successCode;
            Message = message;
        }

    }

}
