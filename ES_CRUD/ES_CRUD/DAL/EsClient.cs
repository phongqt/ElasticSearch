using Nest;
using System;

namespace ES_CRUD.DAL
{
    public class EsClient
    {
        /// URI 
        private const string ES_URI = "http://localhost:9200";

        /// Elastic settings
        private ConnectionSettings _settings;

        /// Current instantiated client
        public ElasticClient Current { get; set; }


        /// Constructor
        public EsClient()
        {
            var node = new Uri(ES_URI);

            _settings = new ConnectionSettings(node);
            _settings.SetDefaultIndex(DTO.Constants.DEFAULT_INDEX);
            _settings.MapDefaultTypeNames(m => m.Add(typeof(DTO.Customer), DTO.Constants.DEFAULT_INDEX_TYPE));

            Current = new ElasticClient(_settings);
            Current.Map<DTO.Customer>(m => m.MapFromAttributes());

        }
    }
}
