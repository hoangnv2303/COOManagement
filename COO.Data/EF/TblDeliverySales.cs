﻿using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace COO.Data.EF
{
    public partial class TblDeliverySales
    {
        public TblDeliverySales()
        {
            TblDsmanual = new HashSet<TblDsmanual>();
        }
        public Guid Id { get; set; }
        public long Delivery { get; set; }
        public long InvoiceNo { get; set; }
        public string MaterialParent { get; set; }
        public string MaterialDesc { get; set; }
        public string ShipToCountry { get; set; }
        public string ShipToCountryName { get; set; } // From config table
        public string HMDShipToCode { get; set; } // From config table
        public string PartyName { get; set; }
        public long? CustomerInvoiceNo { get; set; }
        public string SaleUnit { get; set; }
        public DateTime ActualGidate { get; set; }
        public decimal NetValue { get; set; }
        public long Dnqty { get; set; }
        public decimal NetPrice { get; set; }
        public string HarmonizationCode { get; set; }
        public string Address { get; set; }
        public string Plant { get; set; }
        public DateTime PlanGidate { get; set; }
        public DateTime PlanGisysDate { get; set; }
        public DateTime InsertedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public int? Status { get; set; }

        [JsonIgnore]
        [IgnoreDataMember]
        public virtual ICollection<TblDsmanual> TblDsmanual { get; set; }
    }
}
