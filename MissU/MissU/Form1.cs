using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace MissU
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private bool buttonGenerated = false;
        private void button1_Click(object sender, EventArgs e)
        {
            string[] lines = File.ReadAllLines("MissUniverse.txt");

            foreach (string line in lines)
            {
              
               Top20.Items.Add(line);
                
            }
         if (!buttonGenerated)
          {
        Button newButton = new Button();
        newButton.Text = "Click me!";
         Top20.Items.Add(newButton);

        buttonGenerated = true;
        }
        }
        private void Top20_SelectedIndexChanged(object sender, EventArgs e)
        {


            }

        private void button2_Click(object sender, EventArgs e)
        {
            var selectedItems = Top20.SelectedItems;

            foreach (var item in selectedItems)
            {

                if (!Top10.Items.Contains(item) && Top10.Items.Count <= 9) 
                {
                    Top10.Items.Add(item);
                }
            }


        }
            private void button3_Click(object sender, EventArgs e)
        {
            var selectedItem = Top10.SelectedItem;

            if (selectedItem != null)
            {
                Top10.Items.Remove(selectedItem);
            }
      

        }

        private void button4_Click(object sender, EventArgs e)
        {
            var selectedItems = Top10.SelectedItems;

            foreach (var item in selectedItems)
            {

                if (!Top3.Items.Contains(item) && Top3.Items.Count <= 2)
                {
                    Top3.Items.Add(item);
                }

            }

        }

        private void button5_Click(object sender, EventArgs e)
        {

            var selectedItem = Top3.SelectedItem;

            if (selectedItem != null)
            {
                Top3.Items.Remove(selectedItem);
            }

        }

        private void button6_Click(object sender, EventArgs e)
        {
            var selectedItems = Top3.SelectedItems;

            foreach (var item in selectedItems)
            {


                if (!Top1.Items.Contains(item) && Top1.Items.Count <= 0)
                {
                    Top1.Items.Add(item);
                    MessageBox.Show(item + " is the new Miss Universe");
                }
            }


            }

        private void button7_Click(object sender, EventArgs e)
        {
            var selectedItem = Top1.SelectedItem;

            if (selectedItem != null)
            {
                Top1.Items.Remove(selectedItem);
               
            }

        }
    }
    }

