using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace GPA
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        String Connection = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\sinmiloluwa\Documents\GPA.accdb";
        private void button1_Click(object sender, EventArgs e)
        {
            int k1,k2,k3,k4,k5,k6,k7,k8,k9,k10,u1,u2,u3,u4,u5,u6,u7,u8,u9,u10;
            float gpa,tlu, tunit;            
            tlu = 0; tunit = 0;
            // units conversion//
            u1 = Int32.Parse(comboBox1.Text);
            u2 = Int32.Parse(comboBox2.Text);
            u3 = Int32.Parse(comboBox3.Text);
            u4 = Int32.Parse(comboBox4.Text);
            u5 = Int32.Parse(comboBox5.Text);
            u6 = Int32.Parse(comboBox6.Text);
            u7 = Int32.Parse(comboBox7.Text);
            u8 = Int32.Parse(comboBox8.Text);
            u9 = Int32.Parse(comboBox9.Text);
            u10 = Int32.Parse(comboBox10.Text);
            tunit = u1 + u2 + u3 + u4 + u5 + u6 + u7 + u8 + u9 + u10;
            if (comboBox11.SelectedIndex == 0)
                    k1 = 5 * u1;
                else
                    if (comboBox11.SelectedIndex == 1)
                        k1 = 4 * u1;
                    else
                        if (comboBox11.SelectedIndex == 2)
                            k1 = 3 * u1;
                        else
                            if (comboBox11.SelectedIndex == 3)
                                k1 = 2 * u1;
                            else
                                if (comboBox11.SelectedIndex == 4)
                                    k1 = 1 * u1;
                                else
                                    k1 = 0;
            // 2nd course
            if (comboBox12.SelectedIndex == 0)
                k2 = 5 * u2;
            else
                if (comboBox12.SelectedIndex == 1)
                    k2 = 4 * u2;
                else
                    if (comboBox12.SelectedIndex == 2)
                        k2 = 3 * u2;
                    else
                        if (comboBox12.SelectedIndex == 3)
                            k2 = 2 * u2;
                        else
                            if (comboBox12.SelectedIndex == 4)
                                k2 = 1 * u2;
                            else
                                k2 = 0;
            /* 3rd course */
            if (comboBox13.SelectedIndex == 0)
                k3 = 5 * u3;
            else
                if (comboBox13.SelectedIndex == 1)
                    k3 = 4 * u3;
                else
                    if (comboBox13.SelectedIndex == 2)
                        k3 = 3 * u3;
                    else
                        if (comboBox13.SelectedIndex == 3)
                            k3 = 2 * u3;
                        else
                            if (comboBox13.SelectedIndex == 4)
                                k3 = 1 * u3;
                            else
                                k3 = 0;
            // fourth course
            if (comboBox14.SelectedIndex == 0)
                k4 = 5 * u4;
            else
                if (comboBox14.SelectedIndex == 1)
                    k4 = 4 * u4;
                else
                    if (comboBox14.SelectedIndex == 2)
                        k4 = 3 * u4;
                    else
                        if (comboBox14.SelectedIndex == 3)
                            k4 = 2 * u4;
                        else
                            if (comboBox14.SelectedIndex == 4)
                                k4 = 1 * u4;
                            else
                                k4 = 0;
            // fifth course
            if (comboBox15.SelectedIndex == 0)
                k5 = 5 * u5;
            else
                if (comboBox15.SelectedIndex == 1)
                    k5 = 4 * u5;
                else
                    if (comboBox15.SelectedIndex == 2)
                        k5 = 3 * u5;
                    else
                        if (comboBox15.SelectedIndex == 3)
                            k5 = 2 * u5;
                        else
                            if (comboBox15.SelectedIndex == 4)
                                k5 = 1 * u5;
                            else
                                k5 = 0;
            // sixth coures
            if (comboBox16.SelectedIndex == 0)
                k6 = 5 * u6;
            else
                if (comboBox16.SelectedIndex == 1)
                    k6 = 4 * u6;
                else
                    if (comboBox16.SelectedIndex == 2)
                        k6 = 3 * u6;
                    else
                        if (comboBox16.SelectedIndex == 3)
                            k6 = 2 * u6;
                        else
                            if (comboBox16.SelectedIndex == 4)
                                k6 = 1 * u6;
                            else
                                k6 = 0;
            // seventh course
            if (comboBox17.SelectedIndex == 0)
                k7 = 5 * u7;
            else
                if (comboBox17.SelectedIndex == 1)
                    k7 = 4 * u7;
                else
                    if (comboBox17.SelectedIndex == 2)
                        k7 = 3 * u7;
                    else
                        if (comboBox17.SelectedIndex == 3)
                            k7 = 2 * u7;
                        else
                            if (comboBox17.SelectedIndex == 4)
                                k7 = 1 * u7;
                            else
                                k7 = 0;
            // 8th course
            if (comboBox18.SelectedIndex == 0)
                k8 = 5 * u8;
            else
                if (comboBox18.SelectedIndex == 1)
                    k8 = 4 * u8;
                else
                    if (comboBox18.SelectedIndex == 2)
                        k8 = 3 * u8;
                    else
                        if (comboBox18.SelectedIndex == 3)
                            k8 = 2 * u8;
                        else
                            if (comboBox18.SelectedIndex == 4)
                                k8 = 1 * u8;
                            else
                                k8 = 0;
            // 9th course
            if (comboBox19.SelectedIndex == 0)
                k9 = 5 * u9;
            else
                if (comboBox19.SelectedIndex == 1)
                    k9 = 4 * u9;
                else
                    if (comboBox19.SelectedIndex == 2)
                        k9 = 3 * u9;
                    else
                        if (comboBox19.SelectedIndex == 3)
                            k9 = 2 * u9;
                        else
                            if (comboBox19.SelectedIndex == 4)
                                k9 = 1 * u9;
                            else
                                k9 = 0;
            // 10th course
            if (comboBox20.SelectedIndex == 0)
                k10 = 5 * u10;
            else
                if (comboBox20.SelectedIndex == 1)
                    k10 = 4 * u10;
                else
                    if (comboBox20.SelectedIndex == 2)
                        k10 = 3 * u10;
                    else
                        if (comboBox20.SelectedIndex == 3)
                            k10 = 2 * u10;
                        else
                            if (comboBox20.SelectedIndex == 4)
                                k10 = 1 * u10;
                            else
                                k10 = 0;
            tlu = k1 + k2 + k3 + k4 + k5 + k6 + k7 + k8 + k9 + k10;
            gpa = tlu / tunit;
            
            richTextBox1.Text =String.Format("{0:f}",gpa);
            if (u1 == 0)
            {
                richTextBox1.Text = "";
                MessageBox.Show("Enter valid data","",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

            if ( gpa >= 4.0&gpa <= 5.0)
            {
                label15.Text = "";
                label15.Text += "Nice one\n Keep it Up !";
            }
            if (gpa >= 3.5 & gpa < 4.0)
            {
                label15.Text = "";
                label15.Text += "Good\n Work Harder !";
            }
            if (gpa >= 2.0&gpa < 3.5)
            {
                label15.Text = "";
                label15.Text += "Not Good\nWork Harder !";
            }
            if (gpa < 2)
            {
                label15.Text = "";
                label15.Text += "Very Poor\n Work Harder !";
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("This App calculates GPA on 5.0 scale\n\t Free Version\n\t     (C)2014");
        }

        private void label7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Email: sinmiloluwasunday@yahoo.com\n Phone no: 08162524537\n facebook: GPA Calculator", "GPA Calculator", MessageBoxButtons.OK, MessageBoxIcon.Information);
                
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            label8.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox11.Text == "luv4jesus")
            {
                label1.Show();
                label2.Show();
                label3.Show();
                label4.Show();
                label5.Show();
                label6.Hide();
                label7.Show();
                label8.Hide();
                richTextBox1.Show();
                comboBox1.Show();
                comboBox2.Show();
                comboBox3.Show();
                comboBox4.Show();
                comboBox5.Show();
                comboBox6.Show();
                comboBox7.Show();
                comboBox8.Show();
                comboBox9.Show();
                comboBox10.Show();
                comboBox11.Show();
                comboBox12.Show();
                comboBox13.Show();
                comboBox14.Show();
                comboBox15.Show();
                comboBox16.Show();
                comboBox17.Show();
                comboBox18.Show();
                comboBox19.Show();
                comboBox20.Show();
                textBox1.Show();
                textBox2.Show();
                textBox3.Show();
                textBox4.Show();
                textBox5.Show();
                textBox6.Show();
                textBox7.Show();
                textBox8.Show();
                textBox9.Show();
                textBox10.Show();
                textBox11.Hide();
                textBox12.Hide();
                button1.Show();
                button3.Show();
                button2.Hide();
                label9.Hide();
                label10.Hide();
                label12.Hide();
                label13.Hide();
                label14.Hide();
                label17.Hide();
                linkLabel1.Hide();
                pictureBox1.Show();
                label15.Show();
                panel1.Show();
                
                label11.Text += "logged in as: " + textBox12.Text;
                if (textBox12.Text == "")
                {
                    label11.Text = "";
                    label11.Text += "logged in as: unknown";
                }
            }
            else
            {
                MessageBox.Show("Wrong password", "GPA Calculator", MessageBoxButtons.OK, MessageBoxIcon.Error);
                label13.Show();
                linkLabel1.Show();
            }
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            label14.Show();
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("firefox", "https://www.facebook.com/groups/1397432813860570/");
            
        }

        private void label8_Click(object sender, EventArgs e)
        {
            label16.Show();
            label18.Show();
            
        }

        private void label18_Click(object sender, EventArgs e)
        {
            label8.Hide();
            label16.Hide();
            label18.Hide();
        }
    }
}
