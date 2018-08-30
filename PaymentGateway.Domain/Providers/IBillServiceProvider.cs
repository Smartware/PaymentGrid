using PaymentGateway.Domain.Payload;
using PaymentGateway.Domain.Payload.Quickteller;
using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentGateway.Domain.Providers
{
    public interface IBillServiceProvider
    {
        NameEnquiry ValidateName(string bankCode, string accountId);
        List<QuicktellerBillCategory> GetBillCategories();
        List<QuicktellerBiller> GetBillers();
        BillsPaymentResponseViewModel SendBillPaymentNotification(string paymentcode, string customerUniqueReference, string customerMobile, string customerEmail, string transactionUniqueReference, decimal amount);
        QuicktellerCustomerViewModel ValidateCustomer(string paymentCode, string subscriberId);

        QuicktellerPaymentItemsViewModel GetBillerById(string billerId);
    }
}
