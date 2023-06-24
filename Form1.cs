using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityFrameworkExample2.DataModel;

namespace EntityFrameworkExample2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DbSinavOgrenciEntities db = new DbSinavOgrenciEntities();

        private void buttonOrderByAscThenGroupBy_Click(object sender, EventArgs e)
        {
            var query = db.TBLOGRENCI.
                OrderBy(x => x.Sehir).
                    GroupBy(y => y.Sehir).
                        Select(z =>
                            new
                            {
                                City = z.Key,
                                Sum = z.Count()
                            });
            dataGridView1.DataSource = query.ToList();
        }

        private void buttonOrderByDescThenGroupBy_Click(object sender, EventArgs e)
        {
            var query = db.TBLOGRENCI.
                            OrderBy(x => x.Sehir).
                                GroupBy(y => y.Sehir).
                                    Select(z =>
                                        new
                                        {
                                            City = z.Key,
                                            Sum = z.Count()
                                        }).
                                            OrderByDescending(z=>z.City);
            dataGridView1.DataSource = query.ToList();
        }
    }
}
