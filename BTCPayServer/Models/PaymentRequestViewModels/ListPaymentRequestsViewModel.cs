using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using BTCPayServer.Services.PaymentRequests;
using BTCPayServer.Services.Rates;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BTCPayServer.Models.PaymentRequestViewModels
{
    public class ListPaymentRequestsViewModel
    {
        public int Skip { get; set; }
        public int Count { get; set; }

        public List<ViewPaymentRequestViewModel> Items { get; set; }

        public string StatusMessage { get; set; }
        public int Total { get; set; }
    }

    public class UpdatePaymentRequestViewModel
    {
        public UpdatePaymentRequestViewModel()
        {
        }

        public UpdatePaymentRequestViewModel(PaymentRequestData data)
        {
            if (data == null)
            {
                return;
            }

            Id = data.Id;
            StoreId = data.StoreDataId;

            var blob = data.GetBlob();
            Title = blob.Title;
            Amount = blob.Amount;
            Currency = blob.Currency;
            Description = blob.Description;
            ExpiryDate = blob.ExpiryDate;
            Email = blob.Email;
            CustomCSSLink = blob.CustomCSSLink;
            EmbeddedCSS = blob.EmbeddedCSS;
            AllowCustomPaymentAmounts = blob.AllowCustomPaymentAmounts;
        }

        public string Id { get; set; }
        [Required] public string StoreId { get; set; }
        [Required][Range(0, double.PositiveInfinity)]public decimal Amount { get; set; }

        [Display(Name = "La moneda utilizada para la solicitud de pago. (por ejemplo, BTC, LTC, USD, etc.)")]
        public string Currency { get; set; }

        [Display(Name = "Fecha de caducidad")]
        public DateTime? ExpiryDate { get; set; }
        [Required] public string Title { get; set; }
        public string Description { get; set; }
        public string StatusMessage { get; set; }

        public SelectList Stores { get; set; }
        [EmailAddress]
        public string Email { get; set; }
        
        [MaxLength(500)]
        [Display(Name = "Archivo CSS bootstrap personalizado")]
        public string CustomCSSLink { get; set; }

        [Display(Name = "Código CSS personalizado")]
        public string EmbeddedCSS { get; set; }        
        [Display(Name = "Permitir que el beneficiario cree facturas en su propia denominación")]
        public bool AllowCustomPaymentAmounts { get; set; }
    }

    public class ViewPaymentRequestViewModel
    {
        public ViewPaymentRequestViewModel(PaymentRequestData data)
        {
            Id = data.Id;
            var blob = data.GetBlob();
            Title = blob.Title;
            Amount = blob.Amount;
            Currency = blob.Currency;
            Description = blob.Description;
            ExpiryDate = blob.ExpiryDate;
            Email = blob.Email;
            EmbeddedCSS = blob.EmbeddedCSS;
            CustomCSSLink = blob.CustomCSSLink;
            AllowCustomPaymentAmounts = blob.AllowCustomPaymentAmounts;
            switch (data.Status)
            {
                case PaymentRequestData.PaymentRequestStatus.Pending:
                    Status = ExpiryDate.HasValue ? $"Expires on {ExpiryDate.Value:g}" : "Pendiente";
                    IsPending = true;
                    break;
                case PaymentRequestData.PaymentRequestStatus.Completed:
                    Status = "Aceptado";
                    break;
                case PaymentRequestData.PaymentRequestStatus.Expired:
                    Status = "Expirado";
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
        }

        public bool AllowCustomPaymentAmounts { get; set; }


        public string Email { get; set; }

        public string Status { get; set; }
        public bool IsPending { get; set; }

        public decimal AmountCollected { get; set; }
        public decimal AmountDue { get; set; }
        public string AmountDueFormatted { get; set; }
        public decimal Amount { get; set; }
        public string Id { get; set; }
        public string Currency { get; set; }

        public DateTime? ExpiryDate { get; set; }

        public string Title { get; set; }
        public string Description { get; set; }
        
        public string EmbeddedCSS { get; set; }
        public string CustomCSSLink { get; set; }

        public List<PaymentRequestInvoice> Invoices { get; set; } = new List<PaymentRequestInvoice>();
        public DateTime LastUpdated { get; set; }
        public CurrencyData CurrencyData { get; set; }
        public string AmountCollectedFormatted { get; set; }
        public string AmountFormatted { get; set; }
        public bool AnyPendingInvoice { get; set; }
        public bool PendingInvoiceHasPayments { get; set; }
        public string HubPath { get; set; }
        public string StatusMessage { get; set; }

        public class PaymentRequestInvoice
        {
            public string Id { get; set; }
            public DateTime ExpiryDate { get; set; }
            public decimal Amount { get; set; }
            public string AmountFormatted { get; set; }
            public string Status { get; set; }

            public List<PaymentRequestInvoicePayment> Payments { get; set; }
            public string Currency { get; set; }
        }

        public class PaymentRequestInvoicePayment
        {
            public string PaymentMethod { get; set; }
            public decimal Amount { get; set; }
            public string Link { get; set; }
            public string Id { get; set; }
        }
    }
}
