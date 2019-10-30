using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagentoApp
{
    class M2Invoice
    {
        [JsonProperty("base_currency_code")]
        public string BaseCurrencyCode { get; set; }

        [JsonProperty("base_discount_amount")]
        public int BaseDiscountAmount { get; set; }

        [JsonProperty("base_grand_total")]
        public double BaseGrandTotal { get; set; }

        [JsonProperty("base_discount_tax_compensation_amount")]
        public int BaseDiscountTaxCompensationAmount { get; set; }

        [JsonProperty("base_shipping_amount")]
        public int BaseShippingAmount { get; set; }

        [JsonProperty("base_shipping_discount_tax_compensation_amnt")]
        public int BaseShippingDiscountTaxCompensationAmnt { get; set; }

        [JsonProperty("base_shipping_incl_tax")]
        public int BaseShippingInclTax { get; set; }

        [JsonProperty("base_shipping_tax_amount")]
        public int BaseShippingTaxAmount { get; set; }

        [JsonProperty("base_subtotal")]
        public int BaseSubtotal { get; set; }

        [JsonProperty("base_subtotal_incl_tax")]
        public double BaseSubtotalInclTax { get; set; }

        [JsonProperty("base_tax_amount")]
        public double BaseTaxAmount { get; set; }

        [JsonProperty("base_to_global_rate")]
        public int BaseToGlobalRate { get; set; }

        [JsonProperty("base_to_order_rate")]
        public int BaseToOrderRate { get; set; }

        [JsonProperty("billing_address_id")]
        public int BillingAddressId { get; set; }

        [JsonProperty("can_void_flag")]
        public int CanVoidFlag { get; set; }

        [JsonProperty("created_at")]
        public string CreatedAt { get; set; }

        [JsonProperty("discount_amount")]
        public int DiscountAmount { get; set; }

        [JsonProperty("entity_id")]
        public int EntityId { get; set; }

        [JsonProperty("global_currency_code")]
        public string GlobalCurrencyCode { get; set; }

        [JsonProperty("grand_total")]
        public double GrandTotal { get; set; }

        [JsonProperty("discount_tax_compensation_amount")]
        public int DiscountTaxCompensationAmount { get; set; }

        [JsonProperty("increment_id")]
        public string IncrementId { get; set; }

        [JsonProperty("order_currency_code")]
        public string OrderCurrencyCode { get; set; }

        [JsonProperty("order_id")]
        public int OrderId { get; set; }

        [JsonProperty("shipping_address_id")]
        public int ShippingAddressId { get; set; }

        [JsonProperty("shipping_amount")]
        public int ShippingAmount { get; set; }

        [JsonProperty("shipping_discount_tax_compensation_amount")]
        public int ShippingDiscountTaxCompensationAmount { get; set; }

        [JsonProperty("shipping_incl_tax")]
        public int ShippingInclTax { get; set; }

        [JsonProperty("shipping_tax_amount")]
        public int ShippingTaxAmount { get; set; }

        [JsonProperty("state")]
        public int State { get; set; }

        [JsonProperty("store_currency_code")]
        public string StoreCurrencyCode { get; set; }

        [JsonProperty("store_id")]
        public int StoreId { get; set; }

        [JsonProperty("store_to_base_rate")]
        public int StoreToBaseRate { get; set; }

        [JsonProperty("store_to_order_rate")]
        public int StoreToOrderRate { get; set; }

        [JsonProperty("subtotal")]
        public int Subtotal { get; set; }

        [JsonProperty("subtotal_incl_tax")]
        public double SubtotalInclTax { get; set; }

        [JsonProperty("tax_amount")]
        public double TaxAmount { get; set; }

        [JsonProperty("total_qty")]
        public int TotalQty { get; set; }

        [JsonProperty("updated_at")]
        public string UpdatedAt { get; set; }

        [JsonProperty("items")]
        public IList<M2InvoiceItem> Items { get; set; }

        [JsonProperty("comments")]
        public IList<object> Comments { get; set; }
    }

    public class M2InvoiceItem
    {

        [JsonProperty("base_discount_tax_compensation_amount")]
        public int BaseDiscountTaxCompensationAmount { get; set; }

        [JsonProperty("base_price")]
        public int BasePrice { get; set; }

        [JsonProperty("base_price_incl_tax")]
        public double BasePriceInclTax { get; set; }

        [JsonProperty("base_row_total")]
        public int BaseRowTotal { get; set; }

        [JsonProperty("base_row_total_incl_tax")]
        public double BaseRowTotalInclTax { get; set; }

        [JsonProperty("base_tax_amount")]
        public double BaseTaxAmount { get; set; }

        [JsonProperty("entity_id")]
        public int EntityId { get; set; }

        [JsonProperty("discount_tax_compensation_amount")]
        public int DiscountTaxCompensationAmount { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("parent_id")]
        public int ParentId { get; set; }

        [JsonProperty("price")]
        public int Price { get; set; }

        [JsonProperty("price_incl_tax")]
        public double PriceInclTax { get; set; }

        [JsonProperty("product_id")]
        public int ProductId { get; set; }

        [JsonProperty("row_total")]
        public int RowTotal { get; set; }

        [JsonProperty("row_total_incl_tax")]
        public double RowTotalInclTax { get; set; }

        [JsonProperty("sku")]
        public string Sku { get; set; }

        [JsonProperty("tax_amount")]
        public double TaxAmount { get; set; }

        [JsonProperty("order_item_id")]
        public int OrderItemId { get; set; }

        [JsonProperty("qty")]
        public int Qty { get; set; }

        
    }
}
