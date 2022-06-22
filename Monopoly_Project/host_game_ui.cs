using System;
using System.Windows.Forms;

namespace Monopoly_Project
{
    public partial class host_game_ui : Form
    {
        Storage dataBase;
        public host_game_ui(Storage s)
        {
            dataBase = new Storage();
            InitializeComponent();
        }

        private void host_exit_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private async void host_enter_button_Click(object sender, EventArgs e)
        {
            //dataBase.hostGame(host_gameID_textbox.Text, host_playerID_textbox.Text);
            //dataBase.hostGame("123","batu");
            //await Task.Delay(TimeSpan.FromMilliseconds(300));
            using (game_play_ui gamePlayScreen = new game_play_ui())
            {
                this.Hide();
                this.Owner.Hide();
                gamePlayScreen.ShowDialog();
            }
            /* if (dataBase.serverError == false)
             {

             }
             else
             {
                 DialogResult result = MessageBox.Show("Bi sıkıntı var hostt", "Paniiik", MessageBoxButtons.YesNo);
                 if (result == System.Windows.Forms.DialogResult.Yes)
                 {
                     Application.Exit();
                 }
             }*/
        }
    }
}
