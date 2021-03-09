using BusinessEntity;
using BusinessLogic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinLoadHtml
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void RefreshBut_Click(object sender, EventArgs e)
        {
            try
            {
                BancosBl bl = new BancosBl();

                var source = new BindingSource();
                List<BancosBe> lstBancos = bl.Listar(null);
                source.DataSource = lstBancos;
                dgrData.DataSource = source;
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
