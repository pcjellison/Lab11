/*
 * Payton Jellison
 * Varun Varshnay 7:30am Friday
 * This lab creates a calculator allowing the user to click numbers and clear numbers.
 * */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        private Button[] buttons;
        public Form1()
        {
            InitializeComponent();
            buttons = new Button[10];
            buttons[0] = button_0;
            buttons[0].Click += new EventHandler(numberClick);
            buttons[1] = button_1;
            buttons[1].Click += new EventHandler(numberClick);
            buttons[2] = button_2;
            buttons[2].Click += new EventHandler(numberClick);
            buttons[3] = button_3;
            buttons[3].Click += new EventHandler(numberClick);
            buttons[4] = button_4;
            buttons[4].Click += new EventHandler(numberClick);
            buttons[5] = button_5;
            buttons[5].Click += new EventHandler(numberClick);
            buttons[6] = button_6;
            buttons[6].Click += new EventHandler(numberClick);
            buttons[7] = button_7;
            buttons[7].Click += new EventHandler(numberClick);
            buttons[8] = button_8;
            buttons[8].Click += new EventHandler(numberClick);
            buttons[9] = button_9;
            buttons[9].Click += new EventHandler(numberClick);
            clearButton.Click += new EventHandler(clearClick);
            

        }
        private void numberClick(object sender, EventArgs e)
        {
            if (answerText.Text.Length < 14)        //Allows for 15 numbers
            {
                Button b = (Button)sender;
                answerText.Text += b.Text;
            }
            else
            {
                for (int i = 0; i < buttons.Length; i++)
                {
                    buttons[i].Enabled = false;
                }
            }
        }

        private void clearClick(object sender, EventArgs e)
        {
            answerText.Text = "";
            for (int i = 0; i < buttons.Length; i++)
            {
                buttons[i].Enabled = true;
            }
        }

        private void button11_Click(object sender, EventArgs e)
        {

        }
    }
}
