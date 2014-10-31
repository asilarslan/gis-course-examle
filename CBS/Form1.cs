using MapInfo;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CBS
{
    public partial class Form1 : Form
    {
        public static MapInfo.MapInfoApplication mi;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            mi = new MapInfo.MapInfoApplication();
            mi = Activator.CreateInstance(Type.GetTypeFromProgID("MapInfo.Application")) as MapInfoApplication;
            int p = panel1.Handle.ToInt32();
            mi.Do("set next document parent "+p.ToString()+"style 1");
            mi.Do("set application window "+p.ToString());
            mi.Do("run application \"" + "c:/Users/AsusPc/Desktop/cbs.wor" +"\"");

            for (int i = 1; i <= Convert.ToInt16(mi.Eval("tableInfo(ankara_mah,8)")); i++)
            {
                mi.Do("fetch rec " + i.ToString() + " from ankara_mah");
                comboBox1.Items.Add(mi.Eval("ankara_mah.mahalle_adi"));
            }
        }

        private void btnyakinlastir_Click(object sender, EventArgs e)
        {
            mi.Do("run menu command 1705");
        }

        private void btnuzaklastir_Click(object sender, EventArgs e)
        {
            mi.Do("run menu command 1706");
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            mi.Do("select * from ankara_mah where mahalle_adi= \"" + comboBox1.Text + "\" into sel");
            mi.Do("add map layer sel set map zoom entire layer sel");
        }

        private void btnmerkezle_Click(object sender, EventArgs e)
        {
            mi.Do("run menu command  1702");
        }
    }
}
