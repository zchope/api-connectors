/* 
 * BitMEX API
 *
 * ## REST API for the BitMEX Trading Platform  [View Changelog](/app/apiChangelog)    #### Getting Started  Base URI: [https://www.bitmex.com/api/v1](/api/v1)  ##### Fetching Data  All REST endpoints are documented below. You can try out any query right from this interface.  Most table queries accept `count`, `start`, and `reverse` params. Set `reverse=true` to get rows newest-first.  Additional documentation regarding filters, timestamps, and authentication is available in [the main API documentation](/app/restAPI).  *All* table data is available via the [Websocket](/app/wsAPI). We highly recommend using the socket if you want to have the quickest possible data without being subject to ratelimits.  ##### Return Types  By default, all data is returned as JSON. Send `?_format=csv` to get CSV data or `?_format=xml` to get XML data.  ##### Trade Data Queries  *This is only a small subset of what is available, to get you started.*  Fill in the parameters and click the `Try it out!` button to try any of these queries.  * [Pricing Data](#!/Quote/Quote_get)  * [Trade Data](#!/Trade/Trade_get)  * [OrderBook Data](#!/OrderBook/OrderBook_getL2)  * [Settlement Data](#!/Settlement/Settlement_get)  * [Exchange Statistics](#!/Stats/Stats_history)  Every function of the BitMEX.com platform is exposed here and documented. Many more functions are available.  ##### Swagger Specification  [⇩ Download Swagger JSON](swagger.json)    ## All API Endpoints  Click to expand a section. 
 *
 * OpenAPI spec version: 1.2.0
 * Contact: support@bitmex.com
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */

using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System.ComponentModel.DataAnnotations;
using SwaggerDateConverter = IO.Swagger.Client.SwaggerDateConverter;

namespace IO.Swagger.Model
{
    /// <summary>
    /// Best Bid/Offer Snapshots &amp; Historical Bins
    /// </summary>
    [DataContract]
    public partial class Quote :  IEquatable<Quote>, IValidatableObject
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Quote" /> class.
        /// </summary>
        [JsonConstructorAttribute]
        protected Quote() { }
        /// <summary>
        /// Initializes a new instance of the <see cref="Quote" /> class.
        /// </summary>
        /// <param name="timestamp">timestamp (required).</param>
        /// <param name="symbol">symbol (required).</param>
        /// <param name="bidSize">bidSize.</param>
        /// <param name="bidPrice">bidPrice.</param>
        /// <param name="askPrice">askPrice.</param>
        /// <param name="askSize">askSize.</param>
        public Quote(DateTime? timestamp = default(DateTime?), string symbol = default(string), decimal? bidSize = default(decimal?), double? bidPrice = default(double?), double? askPrice = default(double?), decimal? askSize = default(decimal?))
        {
            // to ensure "timestamp" is required (not null)
            if (timestamp == null)
            {
                throw new InvalidDataException("timestamp is a required property for Quote and cannot be null");
            }
            else
            {
                this.Timestamp = timestamp;
            }
            // to ensure "symbol" is required (not null)
            if (symbol == null)
            {
                throw new InvalidDataException("symbol is a required property for Quote and cannot be null");
            }
            else
            {
                this.Symbol = symbol;
            }
            this.BidSize = bidSize;
            this.BidPrice = bidPrice;
            this.AskPrice = askPrice;
            this.AskSize = askSize;
        }
        
        /// <summary>
        /// Gets or Sets Timestamp
        /// </summary>
        [DataMember(Name="timestamp", EmitDefaultValue=false)]
        public DateTime? Timestamp { get; set; }

        /// <summary>
        /// Gets or Sets Symbol
        /// </summary>
        [DataMember(Name="symbol", EmitDefaultValue=false)]
        public string Symbol { get; set; }

        /// <summary>
        /// Gets or Sets BidSize
        /// </summary>
        [DataMember(Name="bidSize", EmitDefaultValue=false)]
        public decimal? BidSize { get; set; }

        /// <summary>
        /// Gets or Sets BidPrice
        /// </summary>
        [DataMember(Name="bidPrice", EmitDefaultValue=false)]
        public double? BidPrice { get; set; }

        /// <summary>
        /// Gets or Sets AskPrice
        /// </summary>
        [DataMember(Name="askPrice", EmitDefaultValue=false)]
        public double? AskPrice { get; set; }

        /// <summary>
        /// Gets or Sets AskSize
        /// </summary>
        [DataMember(Name="askSize", EmitDefaultValue=false)]
        public decimal? AskSize { get; set; }

        /// <summary>
        /// Returns the string presentation of the object
        /// </summary>
        /// <returns>String presentation of the object</returns>
        public override string ToString()
        {
            var sb = new StringBuilder();
            sb.Append("class Quote {\n");
            sb.Append("  Timestamp: ").Append(Timestamp).Append("\n");
            sb.Append("  Symbol: ").Append(Symbol).Append("\n");
            sb.Append("  BidSize: ").Append(BidSize).Append("\n");
            sb.Append("  BidPrice: ").Append(BidPrice).Append("\n");
            sb.Append("  AskPrice: ").Append(AskPrice).Append("\n");
            sb.Append("  AskSize: ").Append(AskSize).Append("\n");
            sb.Append("}\n");
            return sb.ToString();
        }
  
        /// <summary>
        /// Returns the JSON string presentation of the object
        /// </summary>
        /// <returns>JSON string presentation of the object</returns>
        public virtual string ToJson()
        {
            return JsonConvert.SerializeObject(this, Formatting.Indented);
        }

        /// <summary>
        /// Returns true if objects are equal
        /// </summary>
        /// <param name="input">Object to be compared</param>
        /// <returns>Boolean</returns>
        public override bool Equals(object input)
        {
            return this.Equals(input as Quote);
        }

        /// <summary>
        /// Returns true if Quote instances are equal
        /// </summary>
        /// <param name="input">Instance of Quote to be compared</param>
        /// <returns>Boolean</returns>
        public bool Equals(Quote input)
        {
            if (input == null)
                return false;

            return 
                (
                    this.Timestamp == input.Timestamp ||
                    (this.Timestamp != null &&
                    this.Timestamp.Equals(input.Timestamp))
                ) && 
                (
                    this.Symbol == input.Symbol ||
                    (this.Symbol != null &&
                    this.Symbol.Equals(input.Symbol))
                ) && 
                (
                    this.BidSize == input.BidSize ||
                    (this.BidSize != null &&
                    this.BidSize.Equals(input.BidSize))
                ) && 
                (
                    this.BidPrice == input.BidPrice ||
                    (this.BidPrice != null &&
                    this.BidPrice.Equals(input.BidPrice))
                ) && 
                (
                    this.AskPrice == input.AskPrice ||
                    (this.AskPrice != null &&
                    this.AskPrice.Equals(input.AskPrice))
                ) && 
                (
                    this.AskSize == input.AskSize ||
                    (this.AskSize != null &&
                    this.AskSize.Equals(input.AskSize))
                );
        }

        /// <summary>
        /// Gets the hash code
        /// </summary>
        /// <returns>Hash code</returns>
        public override int GetHashCode()
        {
            unchecked // Overflow is fine, just wrap
            {
                int hashCode = 41;
                if (this.Timestamp != null)
                    hashCode = hashCode * 59 + this.Timestamp.GetHashCode();
                if (this.Symbol != null)
                    hashCode = hashCode * 59 + this.Symbol.GetHashCode();
                if (this.BidSize != null)
                    hashCode = hashCode * 59 + this.BidSize.GetHashCode();
                if (this.BidPrice != null)
                    hashCode = hashCode * 59 + this.BidPrice.GetHashCode();
                if (this.AskPrice != null)
                    hashCode = hashCode * 59 + this.AskPrice.GetHashCode();
                if (this.AskSize != null)
                    hashCode = hashCode * 59 + this.AskSize.GetHashCode();
                return hashCode;
            }
        }

        /// <summary>
        /// To validate all properties of the instance
        /// </summary>
        /// <param name="validationContext">Validation context</param>
        /// <returns>Validation Result</returns>
        IEnumerable<System.ComponentModel.DataAnnotations.ValidationResult> IValidatableObject.Validate(ValidationContext validationContext)
        {
            yield break;
        }
    }

}