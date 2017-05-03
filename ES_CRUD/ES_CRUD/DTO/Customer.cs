using Nest;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES_CRUD.DTO
{
    [ElasticType(Name = "Customer_Info")]
    public class Customer
    {
        /// _id field
        [ElasticProperty(Name = "id", NumericType = NumberType.Long)]
        public int Id { get; set; }

        /// name field
        [ElasticProperty(Name = "name", Index = FieldIndexOption.NotAnalyzed)]
        public string Name { get; set; }

        /// age field
        [ElasticProperty(Name = "age", NumericType = NumberType.Integer)]
        public int Age { get; set; }

        /// birthday field
        [ElasticProperty(Name = "birthday", Type = FieldType.Date, DateFormat = "basic_date")]
        public string Birthday { get; set; }

        /// haschildren field
        [ElasticProperty(Name = "hasChildren")]
        public bool HasChildren { get; set; }

        /// enrollmentFee field
        [ElasticProperty(Name = "enrollmentFee", NumericType = NumberType.Double)]
        public double EnrollmentFee { get; set; }

        /// opnion field
        [ElasticProperty(Name = "opinion", Index = FieldIndexOption.NotAnalyzed)]
        public string Opinion { get; set; }
    }
}
