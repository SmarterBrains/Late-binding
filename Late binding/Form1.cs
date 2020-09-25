using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Reflection;

namespace Late_binding
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void halfWaveToolStripMenuItem_Click(object sender, EventArgs e)
        {
                           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // declare a variable for the library
            Assembly executeAssembly = null; 

            //obtain infor from the library
            try
            {
                executeAssembly = Assembly.Load("Half-wave");
                if (executeAssembly == null)
                    return;
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }

            //get the instance from the dll
            Type dllClass;
            try
            {
                dllClass = executeAssembly.GetType("Half_wave.half_wave");

                //creat an instance of the lab class using late binding
                dynamic lab = Activator.CreateInstance(dllClass);

                //invoke the method in the class
                MethodInfo mtd;
                mtd = dllClass.GetMethod("areaCircle");

                double rad = 2;
                object[] paramenters = new object[] { rad };

                dynamic area = (dynamic)mtd.Invoke(lab, paramenters);
                Console.WriteLine("Area = {0}", area);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
