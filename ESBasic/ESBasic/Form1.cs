using Elasticsearch.Net;
using Nest;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESBasic
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            var uri = new Uri("http://localhost:9200");

            

            
            var settings = new ConnectionSettings(uri)
                .DefaultIndex("people1");

            var client = new ElasticClient(settings);

            var person = new Person
            {
                Id = 1,
                FirstName = "Martijn",
                LastName = "Laarman"
            };

            var indexResponse = client.Index(person);

            var asyncIndexResponse = await client.IndexAsync(person);
        }
    }

    [ElasticsearchType(Name = "company")]
    public class Company
    {
        [Keyword(NullValue = "null", Similarity = "BM25")]
        public string Name { get; set; }

        [Text(Name = "office_hours")]
        public TimeSpan? HeadOfficeHours { get; set; }

        [Object(Store = false)]
        public List<Employee> Employees { get; set; }
    }

    [ElasticsearchType(Name = "employee")]
    public class Employee
    {
        [Text(Name = "first_name")]
        public string FirstName { get; set; }

        [Text(Name = "last_name")]
        public string LastName { get; set; }

        [Number(DocValues = false, IgnoreMalformed = true, Coerce = true)]
        public int Salary { get; set; }

        [Date(Format = "MMddyyyy")]
        public DateTime Birthday { get; set; }

        [Boolean(NullValue = false, Store = true)]
        public bool IsManager { get; set; }

        [Nested]
        [JsonProperty("empl")]
        public List<Employee> Employees { get; set; }
    }

    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
