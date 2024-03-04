using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace BagliListeler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LinkedListADT ll = new LinkedListADT();

            ll.InsertFirst(6);
            ll.InsertFirst(5);
            ll.InsertFirst(4);
            ll.InsertFirst(3);
            ll.InsertFirst(2);
            ll.InsertFirst(1);
            ll.InsertLast(7);
            ll.InsertLast(8);
            ll.InsertPos(2, 10);
            MessageBox.Show(ll.DisplayElements());

            ll.DeleteFirst();
            MessageBox.Show(ll.DisplayElements());

            ll.DeleteLast();
            MessageBox.Show(ll.DisplayElements());

            ll.DeleteLast();
            MessageBox.Show(ll.DisplayElements());

            ll.DeletePos(2);
            MessageBox.Show(ll.DisplayElements());

            Node testNode = ll.GetElement(4);
            MessageBox.Show(testNode.Data.ToString());


            //c# içerisinde Tanımlı olarak gelen LinkedListSınıfı

            /*
            LinkedList<int> list = new LinkedList<int>();
            
            list.AddFirst(1);
            list.AddFirst(2);
            list.AddLast(4);
            foreach (int str in list)
            {
                Debug.WriteLine(str);
            }
            */

        }
    }
}
