using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImmoEF
{
    public partial class Form1 : Form
    {
        HausContext _context;

        public Form1()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _context = new HausContext();
            _context.Liegenschaft.Load();
            liegenschaftBindingSource.DataSource =
                _context.Liegenschaft.Local.ToBindingList();
        }

        private void liegenschaftBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();

            foreach (var haus in _context.Haus.Local.ToList())
            {
                if (haus.Liegenschaft == null)
                {
                    _context.Haus.Remove(haus);
                }

                _context.SaveChanges();
                liegenschaftDataGridView.Refresh();
                hausDataGridView.Refresh();
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            _context.Dispose();
        }
    }
}
