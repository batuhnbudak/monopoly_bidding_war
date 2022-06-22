using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using FireSharp.Config;
using FireSharp.Interfaces;
using FireSharp.Response;

namespace Monopoly_Project
{
    public class Storage
    {
        int dice1;
        int dice2;
        String gameId;
        String name;
        String hostName;
        public Boolean serverError;

        IFirebaseConfig config = new FirebaseConfig
        {
            AuthSecret = "5AH6RmiHLWkVwAhMpscM8eOecHggchQcS4UzulDj",
            BasePath = "https://curious-furnace-297018-default-rtdb.europe-west1.firebasedatabase.app/"
        };

        IFirebaseClient client;

        public Storage()
        {
            gameId = "";
            name = "";
            dice1 = 0;
            dice2 = 0;
            serverError = true;
            client = new FireSharp.FirebaseClient(config);
        }

        public void Form1_Load()
        {
            if (client != null)
            {
                MessageBox.Show("Connection Succesful!");
            }
        }
        public async void hostGame(String gameId, String hostName)
        {

            FirebaseResponse response = await client.GetTaskAsync(gameId + "/hostName");

           // if (response.ResultAs<object>() != null)
           // {
                serverError = false;
                this.gameId = gameId;
                name = hostName;
                this.hostName = hostName;
                _ = await client.SetTaskAsync(gameId + "/hostName/", hostName);
                _ = await client.SetTaskAsync(gameId + "/numberOfPlayers/", 1);
           // }
            //else
              //  serverError = true;
        }
        public async void joinGame(String gameId, String joinName)
        {
            FirebaseResponse response1 = await client.GetTaskAsync(gameId + "/hostName");
            if (response1 == null)
                serverError = true;
            else
            {
                serverError = false;
                this.gameId = gameId;
                name = joinName;
                FirebaseResponse response2 = await client.GetTaskAsync(gameId + "/numberOfPlayers");
                int playerId = response2.ResultAs<int>();
                if (playerId < 4)
                {
                    serverError = false;
                    hostName = response1.ResultAs<String>();
                    // number of players info updated
                    playerId++;
                    SetResponse response4 = await client.SetTaskAsync(gameId + "/numberOfPlayers/", playerId);
                    // gameboard info is received
                }
                else
                    serverError = true;
            }
        }
        public async void setDice(int dice1, int dice2)
        {
            SetResponse responseDice1 = await client.SetTaskAsync(gameId + "/currentDice/dice1", dice1);
            SetResponse responseDice2 = await client.SetTaskAsync(gameId + "/currentDice/dice2", dice2);
        }
        public async void getDiceDB()
        {
            FirebaseResponse response1 = await client.GetTaskAsync(gameId + "/currentDice/dice1");
            dice1 = response1.ResultAs<int>();
            FirebaseResponse response2 = await client.GetTaskAsync(gameId + "/currentDice/dice1");
            dice2 = response2.ResultAs<int>();
        }
    }
}
