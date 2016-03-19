using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            team[] teams = new team[8];
            int i = 0;
            foreach(Control c in Controls)
            {
                if (c is TextBox)
                {
                    teams[i]=new team();
                    teams[i].Name = c.Text;
                    teams[i].id = i;
                    i++;
                }
            }
            int[] index = new int[8];
            for(int j=0; j<8;j++)
            {
                index[j] = j;
            }
            Random r = new Random();
            int[] result = new int[8];
            int size = 8;
            int temp;
            for (int k = 0; k < 8;k++)
            {
                temp = r.Next(0, size-1);
                result[k] = index[temp];
                index[temp] = index[size-1];
                size--;
            }
            int n = 0;
            foreach(Control c in Controls)
            {
                if(c is TextBox)
                {
                    foreach(team t in teams)
                    {
                        if(t.id==result[n])
                        {
                            c.Text = t.Name;
                            n++;
                            break;
                        }
                    }
                }
            }
        }
    }
}
