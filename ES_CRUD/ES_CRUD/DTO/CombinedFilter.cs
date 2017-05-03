using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES_CRUD.DTO
{
    public class CombinedFilter
    {

        #region [ Properties ] 

        /// <summary>
        /// List of ages
        /// </summary>
        public List<string> Ages { get; set; }

        /// <summary>
        /// List of names
        /// </summary>
        public List<string> Names { get; set; }

        /// <summary>
        /// Haschildren flag
        /// </summary>
        public bool HasChildren { get; set; }

        #endregion
    }
}
