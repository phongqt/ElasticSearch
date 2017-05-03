using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES_CRUD.DTO
{
    public static class Constants
    {
        /// Elastic index name
        public const string DEFAULT_INDEX = "crud_sample";

        /// Elastic type of a given index
        public const string DEFAULT_INDEX_TYPE = "Customer_Info";

        /// Basic date format
        public const string BASIC_DATE = "yyyyMMdd";
    }
}
