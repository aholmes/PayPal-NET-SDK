// This class was generated on Tue, 30 Jan 2018 11:15:39 PST by version 0.1.0-dev+6beb51-dirty of Braintree SDK Generator
// OrderAuthorizeRequest.cs
// @version 0.1.0-dev+6beb51-dirty
// @type request
// @data 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
// DO NOT EDIT
using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Collections.Generic;
using BraintreeHttp;


namespace PayPal.v1.Payments
{
    /// <summary>
    /// Authorizes an order, by ID. In the JSON request body, include an `amount` object.
    /// </summary>
    public class OrderAuthorizeRequest : HttpRequest
    {
        public OrderAuthorizeRequest(string OrderId) : base("/v1/payments/orders/{order_id}/authorize?", HttpMethod.Post, typeof(Authorization))
        {
            try {
                this.Path = this.Path.Replace("{order_id}", Uri.EscapeDataString(Convert.ToString(OrderId) ));
            } catch (IOException) {}
            
            this.ContentType =  "application/json";
        }
        
        public OrderAuthorizeRequest RequestBody(Order Order)
        {
            this.Body = Order;
            return this;
        }
    }
}