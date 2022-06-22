using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monopoly_Project
{
    public partial class join_game_ui : Form
    {
        Storage dataBase;
        public join_game_ui(Storage s)
        {
            dataBase = s;
            InitializeComponent();
        }

        private void join_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void join_enter_button_Click(object sender, EventArgs e)
        {
            dataBase.joinGame(join_gameID_textbox.Text, join_PlayerID_textbox.Text);
            if (dataBase.serverError == false)
            {
                using (game_play_ui gamePlayScreen = new game_play_ui())
                {
                    this.Hide();
                    this.Owner.Hide();
                    gamePlayScreen.ShowDialog();
                }
            }
            else
            {
                DialogResult result = MessageBox.Show("Bi sıkıntı var joinn", "Paniiik", MessageBoxButtons.YesNo);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    Application.Exit();
                }
            }
        }
    }
}
