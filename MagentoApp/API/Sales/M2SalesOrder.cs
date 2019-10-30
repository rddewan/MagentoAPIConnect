using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagentoApp
{
    public class OrderItem
    {

        [JsonProperty("amount_refunded")]
        public double amount_refunded { get; set; }

        [JsonProperty("base_amount_refunded")]
        public double base_amount_refunded { get; set; }

        [JsonProperty("base_discount_amount")]
        public double base_discount_amount { get; set; }

        [JsonProperty("base_discount_invoiced")]
        public double base_discount_invoiced { get; set; }

        [JsonProperty("base_discount_tax_compensation_amount")]
        public double base_discount_tax_compensation_amount { get; set; }

        [JsonProperty("base_original_price")]
        public double base_original_price { get; set; }

        [JsonProperty("base_price")]
        public double base_price { get; set; }

        [JsonProperty("base_price_incl_tax")]
        public double base_price_incl_tax { get; set; }

        [JsonProperty("base_row_invoiced")]
        public double base_row_invoiced { get; set; }

        [JsonProperty("base_row_total")]
        public double base_row_total { get; set; }

        [JsonProperty("base_row_total_incl_tax")]
        public double base_row_total_incl_tax { get; set; }

        [JsonProperty("base_tax_amount")]
        public double base_tax_amount { get; set; }

        [JsonProperty("base_tax_invoiced")]
        public double base_tax_invoiced { get; set; }

        [JsonProperty("created_at")]
        public string created_at { get; set; }

        [JsonProperty("discount_amount")]
        public double discount_amount { get; set; }

        [JsonProperty("discount_invoiced")]
        public double discount_invoiced { get; set; }

        [JsonProperty("discount_percent")]
        public double discount_percent { get; set; }

        [JsonProperty("free_shipping")]
        public double free_shipping { get; set; }

        [JsonProperty("discount_tax_compensation_amount")]
        public double discount_tax_compensation_amount { get; set; }

        [JsonProperty("is_qty_decimal")]
        public double is_qty_decimal { get; set; }

        [JsonProperty("is_virtual")]
        public int is_virtual { get; set; }

        [JsonProperty("item_id")]
        public int item_id { get; set; }

        [JsonProperty("name")]
        public string name { get; set; }

        [JsonProperty("no_discount")]
        public int no_discount { get; set; }

        [JsonProperty("order_id")]
        public int order_id { get; set; }

        [JsonProperty("original_price")]
        public double original_price { get; set; }

        [JsonProperty("price")]
        public double price { get; set; }

        [JsonProperty("price_incl_tax")]
        public double price_incl_tax { get; set; }

        [JsonProperty("product_id")]
        public int product_id { get; set; }

        [JsonProperty("product_type")]
        public string product_type { get; set; }

        [JsonProperty("qty_canceled")]
        public int qty_canceled { get; set; }

        [JsonProperty("qty_invoiced")]
        public int qty_invoiced { get; set; }

        [JsonProperty("qty_ordered")]
        public int qty_ordered { get; set; }

        [JsonProperty("qty_refunded")]
        public int qty_refunded { get; set; }

        [JsonProperty("qty_shipped")]
        public int qty_shipped { get; set; }

        [JsonProperty("quote_item_id")]
        public int quote_item_id { get; set; }

        [JsonProperty("row_invoiced")]
        public int row_invoiced { get; set; }

        [JsonProperty("row_total")]
        public double row_total { get; set; }

        [JsonProperty("row_total_incl_tax")]
        public double row_total_incl_tax { get; set; }

        [JsonProperty("row_weight")]
        public int row_weight { get; set; }

        [JsonProperty("sku")]
        public string sku { get; set; }

        [JsonProperty("store_id")]
        public int store_id { get; set; }

        [JsonProperty("tax_amount")]
        public double tax_amount { get; set; }

        [JsonProperty("tax_invoiced")]
        public double tax_invoiced { get; set; }

        [JsonProperty("tax_percent")]
        public double tax_percent { get; set; }

        [JsonProperty("updated_at")]
        public string updated_at { get; set; }

        [JsonProperty("weight")]
        public int weight { get; set; }
    }

    public class M2SalesOrderBillingAddress
    {

        [JsonProperty("address_type")]
        public string address_type { get; set; }

        [JsonProperty("city")]
        public string city { get; set; }

        [JsonProperty("country_id")]
        public string country_id { get; set; }

        [JsonProperty("email")]
        public string email { get; set; }

        [JsonProperty("entity_id")]
        public int entity_id { get; set; }

        [JsonProperty("firstname")]
        public string firstname { get; set; }

        [JsonProperty("lastname")]
        public string lastname { get; set; }

        [JsonProperty("parent_id")]
        public int parent_id { get; set; }

        [JsonProperty("postcode")]
        public string postcode { get; set; }

        [JsonProperty("region")]
        public string region { get; set; }

        [JsonProperty("region_code")]
        public string region_code { get; set; }

        [JsonProperty("region_id")]
        public int region_id { get; set; }

        [JsonProperty("street")]
        public IList<string> street { get; set; }

        [JsonProperty("telephone")]
        public string telephone { get; set; }
    }

    public class Payment
    {

        [JsonProperty("account_status")]
        public object account_status { get; set; }

        [JsonProperty("additional_information")]
        public IList<string> additional_information { get; set; }

        [JsonProperty("amount_authorized")]
        public double amount_authorized { get; set; }

        [JsonProperty("amount_ordered")]
        public double amount_ordered { get; set; }

        [JsonProperty("base_amount_authorized")]
        public double base_amount_authorized { get; set; }

        [JsonProperty("base_amount_ordered")]
        public double base_amount_ordered { get; set; }

        [JsonProperty("base_shipping_amount")]
        public double base_shipping_amount { get; set; }

        [JsonProperty("cc_last4")]
        public object cc_last4 { get; set; }

        [JsonProperty("entity_id")]
        public int entity_id { get; set; }

        [JsonProperty("last_trans_id")]
        public string last_trans_id { get; set; }

        [JsonProperty("method")]
        public string method { get; set; }

        [JsonProperty("parent_id")]
        public int parent_id { get; set; }

        [JsonProperty("shipping_amount")]
        public double shipping_amount { get; set; }
    }

    public class StatusHistory
    {

        [JsonProperty("comment")]
        public string comment { get; set; }

        [JsonProperty("created_at")]
        public string created_at { get; set; }

        [JsonProperty("entity_id")]
        public int entity_id { get; set; }

        [JsonProperty("entity_name")]
        public string entity_name { get; set; }

        [JsonProperty("is_customer_notified")]
        public int? is_customer_notified { get; set; }

        [JsonProperty("is_visible_on_front")]
        public int is_visible_on_front { get; set; }

        [JsonProperty("parent_id")]
        public int parent_id { get; set; }

        [JsonProperty("status")]
        public string status { get; set; }
    }

    public class Address
    {

        [JsonProperty("address_type")]
        public string address_type { get; set; }

        [JsonProperty("city")]
        public string city { get; set; }

        [JsonProperty("country_id")]
        public string country_id { get; set; }

        [JsonProperty("customer_address_id")]
        public int customer_address_id { get; set; }

        [JsonProperty("email")]
        public string email { get; set; }

        [JsonProperty("entity_id")]
        public int entity_id { get; set; }

        [JsonProperty("firstname")]
        public string firstname { get; set; }

        [JsonProperty("lastname")]
        public string lastname { get; set; }

        [JsonProperty("parent_id")]
        public int parent_id { get; set; }

        [JsonProperty("postcode")]
        public string postcode { get; set; }

        [JsonProperty("region")]
        public string region { get; set; }

        [JsonProperty("region_code")]
        public string region_code { get; set; }

        [JsonProperty("region_id")]
        public int region_id { get; set; }

        [JsonProperty("street")]
        public IList<string> street { get; set; }

        [JsonProperty("telephone")]
        public string telephone { get; set; }
    }

    public class Total
    {

        [JsonProperty("base_shipping_amount")]
        public double base_shipping_amount { get; set; }

        [JsonProperty("base_shipping_discount_amount")]
        public double base_shipping_discount_amount { get; set; }

        [JsonProperty("base_shipping_discount_tax_compensation_amnt")]
        public double base_shipping_discount_tax_compensation_amnt { get; set; }

        [JsonProperty("base_shipping_incl_tax")]
        public double base_shipping_incl_tax { get; set; }

        [JsonProperty("base_shipping_tax_amount")]
        public double base_shipping_tax_amount { get; set; }

        [JsonProperty("shipping_amount")]
        public double shipping_amount { get; set; }

        [JsonProperty("shipping_discount_amount")]
        public double shipping_discount_amount { get; set; }

        [JsonProperty("shipping_discount_tax_compensation_amount")]
        public double shipping_discount_tax_compensation_amount { get; set; }

        [JsonProperty("shipping_incl_tax")]
        public double shipping_incl_tax { get; set; }

        [JsonProperty("shipping_tax_amount")]
        public double shipping_tax_amount { get; set; }
    }

    public class Shipping
    {

        [JsonProperty("address")]
        public Address address { get; set; }

        [JsonProperty("method")]
        public string method { get; set; }

        [JsonProperty("total")]
        public Total total { get; set; }
    }   

    public class ShippingAssignment
    {

        [JsonProperty("shipping")]
        public Shipping shipping { get; set; }

        [JsonProperty("items")]
        public IList<OrderItem> items { get; set; }
    }

    public class ExtensionAttributes
    {

        [JsonProperty("shipping_assignments")]
        public IList<ShippingAssignment> shipping_assignments { get; set; }
    }

    public class M2SalesOrder
    {

        [JsonProperty("base_currency_code")]
        public string base_currency_code { get; set; }

        [JsonProperty("base_discount_amount")]
        public double base_discount_amount { get; set; }

        [JsonProperty("base_grand_total")]
        public double base_grand_total { get; set; }

        [JsonProperty("base_discount_tax_compensation_amount")]
        public double base_discount_tax_compensation_amount { get; set; }

        [JsonProperty("base_shipping_amount")]
        public double base_shipping_amount { get; set; }

        [JsonProperty("base_shipping_discount_amount")]
        public double base_shipping_discount_amount { get; set; }

        [JsonProperty("base_shipping_discount_tax_compensation_amnt")]
        public double base_shipping_discount_tax_compensation_amnt { get; set; }

        [JsonProperty("base_shipping_incl_tax")]
        public double base_shipping_incl_tax { get; set; }

        [JsonProperty("base_shipping_tax_amount")]
        public double base_shipping_tax_amount { get; set; }

        [JsonProperty("base_subtotal")]
        public double base_subtotal { get; set; }

        [JsonProperty("base_subtotal_incl_tax")]
        public double base_subtotal_incl_tax { get; set; }

        [JsonProperty("base_tax_amount")]
        public double base_tax_amount { get; set; }

        [JsonProperty("base_total_due")]
        public double base_total_due { get; set; }

        [JsonProperty("base_to_global_rate")]
        public double base_to_global_rate { get; set; }

        [JsonProperty("base_to_order_rate")]
        public double base_to_order_rate { get; set; }

        [JsonProperty("billing_address_id")]
        public int billing_address_id { get; set; }

        [JsonProperty("created_at")]
        public string created_at { get; set; }

        [JsonProperty("customer_email")]
        public string customer_email { get; set; }

        [JsonProperty("customer_firstname")]
        public string customer_firstname { get; set; }

        [JsonProperty("customer_group_id")]
        public int customer_group_id { get; set; }

        [JsonProperty("customer_id")]
        public int customer_id { get; set; }

        [JsonProperty("customer_is_guest")]
        public int customer_is_guest { get; set; }

        [JsonProperty("customer_lastname")]
        public string customer_lastname { get; set; }

        [JsonProperty("customer_note_notify")]
        public int customer_note_notify { get; set; }

        [JsonProperty("discount_amount")]
        public double discount_amount { get; set; }

        [JsonProperty("email_sent")]
        public int email_sent { get; set; }

        [JsonProperty("entity_id")]
        public int entity_id { get; set; }

        [JsonProperty("global_currency_code")]
        public string global_currency_code { get; set; }

        [JsonProperty("grand_total")]
        public double grand_total { get; set; }

        [JsonProperty("discount_tax_compensation_amount")]
        public double discount_tax_compensation_amount { get; set; }

        [JsonProperty("increment_id")]
        public string increment_id { get; set; }

        [JsonProperty("is_virtual")]
        public int is_virtual { get; set; }

        [JsonProperty("order_currency_code")]
        public string order_currency_code { get; set; }

        [JsonProperty("protect_code")]
        public string protect_code { get; set; }

        [JsonProperty("quote_id")]
        public int quote_id { get; set; }

        [JsonProperty("remote_ip")]
        public string remote_ip { get; set; }

        [JsonProperty("shipping_amount")]
        public double shipping_amount { get; set; }

        [JsonProperty("shipping_description")]
        public string shipping_description { get; set; }

        [JsonProperty("shipping_discount_amount")]
        public double shipping_discount_amount { get; set; }

        [JsonProperty("shipping_discount_tax_compensation_amount")]
        public double shipping_discount_tax_compensation_amount { get; set; }

        [JsonProperty("shipping_incl_tax")]
        public double shipping_incl_tax { get; set; }

        [JsonProperty("shipping_tax_amount")]
        public double shipping_tax_amount { get; set; }

        [JsonProperty("state")]
        public string state { get; set; }

        [JsonProperty("status")]
        public string status { get; set; }

        [JsonProperty("store_currency_code")]
        public string store_currency_code { get; set; }

        [JsonProperty("store_id")]
        public int store_id { get; set; }

        [JsonProperty("store_name")]
        public string store_name { get; set; }

        [JsonProperty("store_to_base_rate")]
        public double store_to_base_rate { get; set; }

        [JsonProperty("store_to_order_rate")]
        public double store_to_order_rate { get; set; }

        [JsonProperty("subtotal")]
        public double subtotal { get; set; }

        [JsonProperty("subtotal_incl_tax")]
        public double subtotal_incl_tax { get; set; }

        [JsonProperty("tax_amount")]
        public double tax_amount { get; set; }

        [JsonProperty("total_due")]
        public double total_due { get; set; }

        [JsonProperty("total_item_count")]
        public double total_item_count { get; set; }

        [JsonProperty("total_qty_ordered")]
        public double total_qty_ordered { get; set; }

        [JsonProperty("updated_at")]
        public string updated_at { get; set; }

        [JsonProperty("weight")]
        public int weight { get; set; }

        [JsonProperty("items")]
        public IList<OrderItem> items { get; set; }

        [JsonProperty("billing_address")]
        public M2SalesOrderBillingAddress billing_address { get; set; }

        [JsonProperty("payment")]
        public Payment payment { get; set; }

        [JsonProperty("status_histories")]
        public IList<StatusHistory> status_histories { get; set; }

        [JsonProperty("extension_attributes")]
        public ExtensionAttributes extension_attributes { get; set; }
    }
}
