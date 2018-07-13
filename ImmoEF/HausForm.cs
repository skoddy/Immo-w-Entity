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
    public partial class HausForm : Form
    {
        WohnungContext _context;
        public HausForm()
        {
            InitializeComponent();
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            _context = new WohnungContext();
            _context.Wohnung.Load();
            hausBindingSource.DataSource =
                _context.Haus.Local.ToBindingList();
        }

        private void hausBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            Validate();

            foreach (var wohnung in _context.Wohnung.Local.ToList())
            {
                if (wohnung == null)
                {
                    _context.Wohnung.Remove(wohnung);
                }

                _context.SaveChanges();
                hausDataGridView.Refresh();
                wohnungDataGridView.Refresh();
            }
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            base.OnClosing(e);
            _context.Dispose();
        }
    }
}
