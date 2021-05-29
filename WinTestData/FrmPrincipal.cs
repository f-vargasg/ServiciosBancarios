using ServiciosBancarios.DTO;
using ServiciosBancarios.Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinTestData
{
    public partial class Form1 : Form
    {
        GiroBancarioBL giroBancarioBL = new GiroBancarioBL();
        public Form1()
        {
            InitializeComponent();
        }

        private void butLoad_Click(object sender, EventArgs e)
        {
            try
            {
               List<GiroBancarioBE> lst =   giroBancarioBL.GetList();

                dgrData.DataSource = lst;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
