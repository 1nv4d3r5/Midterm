/* Author: System was created by Colin Bero
 * Date: 10/22/2013
 * Class: CIS 334, Dr. Shannon McMurtrey
 * Purpose: POS system for a pizza company, Gino's East.
 * Allows a user to login with a username and password
 * And also select amount of pizzas and cokes to order.
 * Then the POS system calculates the total cost.
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaPOS
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Login: User Name
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        // Login: Password
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            // Password is set to no text
            //textBox2.Text = "";

            // Password is masked with asteriks
            textBox2.PasswordChar = '*';
            
            // Password can only be 14 characters long
            textBox2.MaxLength = 14;

        }

        // Login: Username label
        private void label1_Click(object sender, EventArgs e)
        {
            // Nothing will happen in this method
        }

        // Login: Password label
        private void label2_Click(object sender, EventArgs e)
        {
            // Nothing will happen in this method
        }

        // Login: Login label
        private void label3_Click(object sender, EventArgs e)
        {
            // Nothing will happen in this method
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Assigns userName and password to the text
            string userName = textBox1.Text;
            string password = textBox2.Text;

            // Defines if login was successful or unsuccessful
            if (userName == "Colin Bero")
            {
                if (password == "password")
                { MessageBox.Show("Login Successful!"); }
                else
                { 
                    MessageBox.Show("Username/Password Incorrect. Try again"); 
                }

            }
        }

        // Login: Exit
        private void button2_Click(object sender, EventArgs e)
        {
            // Closes form
            this.Close();

        }
    }
}
