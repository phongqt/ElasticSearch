using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ES_CRUD.DTO;

namespace ES_CRUD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                BLL.Customer customerBLL = new BLL.Customer();
                for (var i = 0; i < 10; i++)
                {
                    DTO.Customer customer = new Customer()
                    {
                        Age = i + 10,
                        Birthday = DateTime.Now.ToString(DTO.Constants.BASIC_DATE),
                        EnrollmentFee = 11.4,
                        HasChildren = false,
                        Name = "alex " + i.ToString(),
                        Opinion = "alex",
                        Id = i+1
                    };
                    
                    customerBLL.Index(customer);
                }
                MessageBox.Show("Indexed");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            BLL.Customer customerBLL = new BLL.Customer();

            var items = customerBLL.QueryById(txtSearch.ToString());
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            BLL.Customer customerBLL = new BLL.Customer();
            customerBLL.Delete(txtSearch.ToString());
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            BLL.Customer customerBLL = new BLL.Customer();
            customerBLL.DeleteAll();
        }
    }
}
