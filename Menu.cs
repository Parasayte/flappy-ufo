using System;
using System.Windows.Forms;

namespace flapp
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void Menu_Start(object sender, EventArgs e)
        {
            Game game = new Game();
            game.Show();
            Hide();
        }

        private void Menu_option_button(object sender, EventArgs e)
        {
            Option option = new Option();
            Hide();
            option.Show();
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }
    }
}