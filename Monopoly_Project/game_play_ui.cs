using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Monopoly_Project
{
    public partial class game_play_ui : Form
    {
        // Database
        Storage database = new Storage();
        // Locations for player pawns
        //Player1
        
        readonly Dictionary<string, int[]> player1_pawnLocations = new Dictionary<string, int[]>()
        {
            {"start", new int[]{930,920} },
            {"gdynia", new int[]{860,880}},
            {"cmLowerLeft",new int[]{800,840} },
            {"taipei", new int[]{720,790 } },
            {"incomeTax", new int[]{660,750} },
            {"grandCentral", new int[]{590,700} },
            {"tokyo", new int[]{510,660} },
            {"chanceLowerLeft", new int[]{450,620} },
            {"barcelona", new int[]{370,580} },
            {"athens", new int[]{300,540} },
            {"visitor", new int[]{240,480} },
            {"istanbul", new int[]{320,440} },
            {"electricCompany", new int[]{380,400} },
            {"kyiv", new int[]{450,350} },
            {"toronto", new int[]{520,310} },
            {"pooleHarbour", new int[]{590,270} },
            {"rome", new int[]{660,220} },
            {"cmUpperLeft", new int[]{730,180} },
            {"shanghai", new int[]{800,140} },
            {"vancouver", new int[]{870,90} },
            {"freePark", new int[]{940,50} },
            {"sydney", new int[]{1050,120} },
            {"chanceUpperRight", new int[]{1120,160} },
            {"newYork", new int[]{1190,210} },
            {"london", new int[]{1260,250} },
            {"englishHarbour", new int[]{1330,290} },
            {"beijing", new int[]{1400,330} },
            {"hongKong", new int[]{1470,380} },
            {"waterWorks", new int[]{1540,420} },
            {"jerusalem", new int[]{1600,460} },
            {"goToJail", new int[]{1670,510} },
            {"paris", new int[]{1570,570} },
            {"belgrade", new int[]{1500,610} },
            {"cmLowerRight", new int[]{1430,660} },
            {"capeTown", new int[]{1360,700} },
            {"heathrowAirport", new int[]{1290,740} },
            {"chanceLowerRight", new int[]{1220,790} },
            {"riga", new int[]{1150,830} },
            {"luxuryTax", new int[]{1080,870} },
            {"montreal", new int[]{1010,920} },
        };
        // Player2
        readonly Dictionary<string, int[]> player2_pawnLocations = new Dictionary<string, int[]>()
        {
            {"start", new int[]{970,930} },
            {"gdynia", new int[]{890,900}},
            {"cmLowerLeft",new int[]{820,860} },
            {"taipei", new int[]{750,820 } },
            {"incomeTax", new int[]{690,770} },
            {"grandCentral", new int[]{630,730} },
            {"tokyo", new int[]{550,690} },
            {"chanceLowerLeft", new int[]{490,640} },
            {"barcelona", new int[]{410,600} },
            {"athens", new int[]{340,560} },
            {"visitor", new int[]{210,500} },
            {"istanbul", new int[]{280,460} },
            {"electricCompany", new int[]{350,410} },
            {"kyiv", new int[]{420,370} },
            {"toronto", new int[]{490,330} },
            {"pooleHarbour", new int[]{560,290} },
            {"rome", new int[]{630,250} },
            {"cmUpperLeft", new int[]{700,200} },
            {"shanghai", new int[]{760,160} },
            {"vancouver", new int[]{830,110} },
            {"freePark", new int[]{900,70} },
            {"sydney", new int[]{1010,90} },
            {"chanceUpperRight", new int[]{1080,140} },
            {"newYork", new int[]{1150,180} },
            {"london", new int[]{1220,220} },
            {"englishHarbour", new int[]{1280,270} },
            {"beijing", new int[]{1350,310} },
            {"hongKong", new int[]{1420,350} },
            {"waterWorks", new int[]{1490,400} },
            {"jerusalem", new int[]{1560,440} },
            {"goToJail", new int[]{1630,480} },
            {"paris", new int[]{1600,550} },
            {"belgrade", new int[]{1530,590} },
            {"cmLowerRight", new int[]{1460,630} },
            {"capeTown", new int[]{1390,680} },
            {"heathrowAirport", new int[]{1320,720} },
            {"chanceLowerRight", new int[]{1250,760} },
            {"riga", new int[]{1180,810} },
            {"luxuryTax", new int[]{1110,850} },
            {"montreal", new int[]{1040,900} },
        };

        // Player3
        readonly Dictionary<string, int[]> player3_pawnLocations = new Dictionary<string, int[]>()
        {
            {"start", new int[]{890,940} },
            {"gdynia", new int[]{820,900}},
            {"cmLowerLeft",new int[]{750,850} },
            {"taipei", new int[]{680,810 } },
            {"incomeTax", new int[]{610,770} },
            {"grandCentral", new int[]{540,720} },
            {"tokyo", new int[]{470,680} },
            {"chanceLowerLeft", new int[]{410,630} },
            {"barcelona", new int[]{330,590} },
            {"athens", new int[]{270,550} },
            {"visitor", new int[]{210,520} },
            {"istanbul", new int[]{320,460} },
            {"electricCompany", new int[]{390,420} },
            {"kyiv", new int[]{470,370} },
            {"toronto", new int[]{530,330} },
            {"pooleHarbour", new int[]{610,290} },
            {"rome", new int[]{670,240} },
            {"cmUpperLeft", new int[]{750,210} },
            {"shanghai", new int[]{810,160} },
            {"vancouver", new int[]{880,110} },
            {"freePark", new int[]{930,100} },
            {"sydney", new int[]{970,110} },
            {"chanceUpperRight", new int[]{1030,160} },
            {"newYork", new int[]{1110,200} },
            {"london", new int[]{1180,240} },
            {"englishHarbour", new int[]{1240,290} },
            {"beijing", new int[]{1320,320} },
            {"hongKong", new int[]{1390,370} },
            {"waterWorks", new int[]{1450,420} },
            {"jerusalem", new int[]{1530,450} },
            {"goToJail", new int[]{1580,510} },
            {"paris", new int[]{1530,560} },
            {"belgrade", new int[]{1460,600} },
            {"cmLowerRight", new int[]{1380,640} },
            {"capeTown", new int[]{1320,690} },
            {"heathrowAirport", new int[]{1240,730} },
            {"chanceLowerRight", new int[]{1170,770} },
            {"riga", new int[]{1120,820} },
            {"luxuryTax", new int[]{1040,860} },
            {"montreal", new int[]{980,900} },
        };

        // Player4
        readonly Dictionary<string, int[]> player4_pawnLocations = new Dictionary<string, int[]>()
        {
            {"start", new int[]{940,950} },
            {"gdynia", new int[]{870,910}},
            {"cmLowerLeft",new int[]{800,870} },
            {"taipei", new int[]{740,830 } },
            {"incomeTax", new int[]{670,790} },
            {"grandCentral", new int[]{590,740} },
            {"tokyo", new int[]{530,700} },
            {"chanceLowerLeft", new int[]{460,660} },
            {"barcelona", new int[]{390,610} },
            {"athens", new int[]{320,570} },
            {"visitor", new int[]{250,530} },
            {"istanbul", new int[]{310,480} },
            {"electricCompany", new int[]{390,440} },
            {"kyiv", new int[]{440,390} },
            {"toronto", new int[]{510,350} },
            {"pooleHarbour", new int[]{590,310} },
            {"rome", new int[]{650,260} },
            {"cmUpperLeft", new int[]{730,220} },
            {"shanghai", new int[]{790,170} },
            {"vancouver", new int[]{860,130} },
            {"freePark", new int[]{980,80} },
            {"sydney", new int[]{1030,130} },
            {"chanceUpperRight", new int[]{1090,180} },
            {"newYork", new int[]{1170,220} },
            {"london", new int[]{1230,260} },
            {"englishHarbour", new int[]{1290,310} },
            {"beijing", new int[]{1380,350} },
            {"hongKong", new int[]{1450,390} },
            {"waterWorks", new int[]{1500,440} },
            {"jerusalem", new int[]{1580,480} },
            {"goToJail", new int[]{1640,530} },
            {"paris", new int[]{1570,530} },
            {"belgrade", new int[]{1510,580} },
            {"cmLowerRight", new int[]{1430,620} },
            {"capeTown", new int[]{1370,660} },
            {"heathrowAirport", new int[]{1290,700} },
            {"chanceLowerRight", new int[]{1220,740} },
            {"riga", new int[]{1160,790} },
            {"luxuryTax", new int[]{1080,830} },
            {"montreal", new int[]{1020,880} },
        };
        // to hide in_game_settings_panel
        const int WM_PARENTNOTIFY = 0x210;
        const int WM_LBUTTONDOWN = 0x201;

        // For dice
        private readonly Random _random = new Random();
        int dice_total;
        int dice_total_to_show;
        int dice1;
        int dice2;

        // For movement
        int playerNo = 4; // it will change !!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!!
        string landName;

        // Current landnames of players
        // string player1_landName;
        //string player2_landName;
        //string player3_landName;
        //string player4_landName;
        public game_play_ui()
        {
            InitializeComponent();
            
            openSelectPawnScreen();
        }
        public async void openSelectPawnScreen()
        {
            await Task.Delay(TimeSpan.FromMilliseconds(300));
            using (select_pawn_screen selectPawnScreen = new select_pawn_screen())
            {
                selectPawnScreen.ShowDialog();
            }
        }


        // Move methods
        private void startMove()
        {
            landName = "start";
            dice_total--;
            timer1.Start();
        }
        private void gdyniaMove()
        {
            landName = "gdynia";
            dice_total--;
            timer1.Start();
        }
        private void cmLowerLeftMove()
        {
            landName = "cmLowerLeft";
            dice_total--;
            timer1.Start();
        }
        private void taipeiMove()
        {
            landName = "taipei";
            dice_total--;
            timer1.Start();
        }
        private void incomeTaxMove()
        {
            landName = "incomeTax";
            dice_total--;
            timer1.Start();
        }
        private void grandCentralMove()
        {
            landName = "grandCentral";
            dice_total--;
            timer1.Start();
        }
        private void tokyoMove()
        {
            landName = "tokyo";
            dice_total--;
            timer1.Start();
        }
        private void chanceLowerLeftMove()
        {
            landName = "chanceLowerLeft";
            dice_total--;
            timer1.Start();
        }
        private void barcelonaMove()
        {
            landName = "barcelona";
            dice_total--;
            timer1.Start();
        }
        private void athensMove()
        {
            landName = "athens";
            dice_total--;
            timer1.Start();
        }
        private void visitorMove()
        {
            landName = "visitor";
            dice_total--;
            timer1.Start();
        }
        private void istanbulMove()
        {
            landName = "istanbul";
            dice_total--;
            timer1.Start();
        }
        private void electricCompanyMove()
        {
            landName = "electricCompany";
            dice_total--;
            timer1.Start();
        }
        private void kyivMove()
        {
            landName = "kyiv";
            dice_total--;
            timer1.Start();
        }
        private void torontoMove()
        {
            landName = "toronto";
            dice_total--;
            timer1.Start();
        }
        private void pooleHarbourMove()
        {
            landName = "pooleHarbour";
            dice_total--;
            timer1.Start();
        }
        private void romeMove()
        {
            landName = "rome";
            dice_total--;
            timer1.Start();
        }
        private void cmUpperLeftMove()
        {
            landName = "cmUpperLeft";
            dice_total--;
            timer1.Start();
        }
        private void shanghaiMove()
        {
            landName = "shanghai";
            dice_total--;
            timer1.Start();
        }
        private void vancouverMove()
        {
            landName = "vancouver";
            dice_total--;
            timer1.Start();
        }
        private void freeParkMove()
        {
            landName = "freePark";
            dice_total--;
            timer1.Start();
        }
        private void sydneyMove()
        {
            landName = "sydney";
            dice_total--;
            timer1.Start();
        }
        private void chanceUpperRightMove()
        {
            landName = "chanceUpperRight";
            dice_total--;
            timer1.Start();
        }
        private void newYorkMove()
        {
            landName = "newYork";
            dice_total--;
            timer1.Start();
        }
        private void londonMove()
        {
            landName = "london";
            dice_total--;
            timer1.Start();
        }
        private void englishHarbourMove()
        {
            landName = "englishHarbour";
            dice_total--;
            timer1.Start();
        }
        private void beijingMove()
        {
            landName = "beijing";
            dice_total--;
            timer1.Start();
        }
        private void hongKongMove()
        {
            landName = "hongKong";
            dice_total--;
            timer1.Start();
        }
        private void waterWorksMove()
        {
            landName = "waterWorks";
            dice_total--;
            timer1.Start();
        }
        private void jerusalemMove()
        {
            landName = "jerusalem";
            dice_total--;
            timer1.Start();
        }
        private void goToJailMove()
        {
            landName = "goToJail";
            dice_total--;
            timer1.Start();
        }
        private void parisMove()
        {
            landName = "paris";
            dice_total--;
            timer1.Start();
        }
        private void belgradeMove()
        {
            landName = "belgrade";
            dice_total--;
            timer1.Start();
        }
        private void cmLowerRightMove()
        {
            landName = "cmLowerRight";
            dice_total--;
            timer1.Start();
        }
        private void capeTownMove()
        {
            landName = "capeTown";
            dice_total--;
            timer1.Start();
        }
        private void heathrowAirportMove()
        {
            landName = "heathrowAirport";
            dice_total--;
            timer1.Start();
        }
        private void chanceLowerRightMove()
        {
            landName = "chanceLowerRight";
            dice_total--;
            timer1.Start();
        }
        private void rigaMove()
        {
            landName = "riga";
            dice_total--;
            timer1.Start();
        }
        private void luxuryTaxMove()
        {
            landName = "luxuryTax";
            dice_total--;
            timer1.Start();
        }
        private void montrealMove()
        {
            landName = "montreal";
            dice_total--;
            timer1.Start();
        }

        // Teleport
        private void teleport(int playerNo, string str)
        {
            if(playerNo == 1)
            {
                player1_pawn.Location = new Point(player1_pawnLocations[str][0], player1_pawnLocations[str][1]);
            }
            else if(playerNo == 2)
            {
                player2_pawn.Location = new Point(player2_pawnLocations[str][0], player2_pawnLocations[str][1]);
            }
            else if(playerNo == 3)
            {
                player3_pawn.Location = new Point(player3_pawnLocations[str][0], player3_pawnLocations[str][1]);
            }
            else
            {
                player4_pawn.Location = new Point(player4_pawnLocations[str][0], player4_pawnLocations[str][1]);
            }
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure wish to quit game?", "Quit Game", MessageBoxButtons.YesNo);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                this.Hide();
                using (main_screen_ui mainScreen = new main_screen_ui())
                {
                    mainScreen.ShowDialog();
                }
            }
        }

        private void dice_button_Click(object sender, EventArgs e)
        {
            //SystemSounds.Asterisk.Play();
            //SystemSounds.Question.Play();
            dice_panel.Visible = true;
            dice_timer.Start();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            player1_pawn.Location = new Point(930, 920);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            player1_pawn.Location = new Point(800, 840);
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            playerNo = 2;
            //player2_pawn.Location = new Point(970, 930);
            player2_pawn.BringToFront();

        }
        private void button4_Click(object sender, EventArgs e)
        {
            playerNo = 1;
            //player1_pawn.Location = new Point(930, 920);
            player1_pawn.BringToFront();
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            playerNo = 3;
            //player3_pawn.Location = new Point(890, 940);
            player3_pawn.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            playerNo = 4;
            // player4_pawn.Location = new Point(940, 950);
            player4_pawn.BringToFront();
        }



        // Hides settings panel if clicked outside
        protected override void WndProc(ref Message m)
        {
            if (m.Msg == WM_LBUTTONDOWN || (m.Msg == WM_PARENTNOTIFY &&
                (int)m.WParam == WM_LBUTTONDOWN))
                if (!in_game_settings_panel.ClientRectangle.Contains(
                                 in_game_settings_panel.PointToClient(Cursor.Position)))
                    in_game_settings_panel.Visible = false;
            base.WndProc(ref m);
        }

        private void pause_button_Click(object sender, EventArgs e)
        {
            in_game_settings_panel.Visible = true;
        }

        private void settings_in_game_Click(object sender, EventArgs e)
        {
            using (settingss_ui settingsScreen = new settingss_ui())
            {
                in_game_settings_panel.Visible = false;
                settingsScreen.ShowDialog();
            }
        }

        private void resumeButton_Click(object sender, EventArgs e)
        {
            in_game_settings_panel.Visible = false;
        }

        // Dice animations and start moves
        private void dice_timer_Tick(object sender, EventArgs e)
        {
            dicePrgBar.Increment(5);
            if (dicePrgBar.Value >= 100)
            {
                dice_total = dice1 + dice2;
                diceTotal_label.Text = dice_total.ToString();
                dice_timer.Stop();
                // Playerdan dicelar alınıp burda setlenecek gibi ??
                dicePrgBar.Value = 0;
                // start timer for move animation
                // jail oalyları
                
                    if (playerNo == 1)
                    {
                        if (player1_pawn.Location.X == player1_pawnLocations["start"][0] && player1_pawn.Location.Y == player1_pawnLocations["start"][1])
                        {
                            startMove();
                        }
                        else if (player1_pawn.Location.X == player1_pawnLocations["gdynia"][0] && player1_pawn.Location.Y == player1_pawnLocations["gdynia"][1])
                        {
                            gdyniaMove();
                        }
                        else if (player1_pawn.Location.X == player1_pawnLocations["cmLowerLeft"][0] && player1_pawn.Location.Y == player1_pawnLocations["cmLowerLeft"][1])
                        {
                            cmLowerLeftMove();
                        }
                        else if (player1_pawn.Location.X == player1_pawnLocations["taipei"][0] && player1_pawn.Location.Y == player1_pawnLocations["taipei"][1])
                        {
                            taipeiMove();
                        }
                        else if (player1_pawn.Location.X == player1_pawnLocations["incomeTax"][0] && player1_pawn.Location.Y == player1_pawnLocations["incomeTax"][1])
                        {
                            incomeTaxMove();
                        }
                        else if (player1_pawn.Location.X == player1_pawnLocations["grandCentral"][0] && player1_pawn.Location.Y == player1_pawnLocations["grandCentral"][1])
                        {
                            grandCentralMove();
                        }
                        else if (player1_pawn.Location.X == player1_pawnLocations["tokyo"][0] && player1_pawn.Location.Y == player1_pawnLocations["tokyo"][1])
                        {
                            tokyoMove();
                        }
                        else if (player1_pawn.Location.X == player1_pawnLocations["tokyo"][0] && player1_pawn.Location.Y == player1_pawnLocations["tokyo"][1])
                        {
                            tokyoMove();
                        }
                        else if (player1_pawn.Location.X == player1_pawnLocations["chanceLowerLeft"][0] && player1_pawn.Location.Y == player1_pawnLocations["chanceLowerLeft"][1])
                        {
                            chanceLowerLeftMove();
                        }
                        else if (player1_pawn.Location.X == player1_pawnLocations["barcelona"][0] && player1_pawn.Location.Y == player1_pawnLocations["barcelona"][1])
                        {
                            barcelonaMove();
                        }
                        else if (player1_pawn.Location.X == player1_pawnLocations["athens"][0] && player1_pawn.Location.Y == player1_pawnLocations["athens"][1])
                        {
                            athensMove();
                        }
                        else if (player1_pawn.Location.X == player1_pawnLocations["visitor"][0] && player1_pawn.Location.Y == player1_pawnLocations["visitor"][1])
                        {
                            visitorMove();
                        }
                        else if (player1_pawn.Location.X == player1_pawnLocations["istanbul"][0] && player1_pawn.Location.Y == player1_pawnLocations["istanbul"][1])
                        {
                            istanbulMove();
                        }
                        else if (player1_pawn.Location.X == player1_pawnLocations["electricCompany"][0] && player1_pawn.Location.Y == player1_pawnLocations["electricCompany"][1])
                        {
                            electricCompanyMove();
                        }
                        else if (player1_pawn.Location.X == player1_pawnLocations["kyiv"][0] && player1_pawn.Location.Y == player1_pawnLocations["kyiv"][1])
                        {
                            kyivMove();
                        }
                        else if (player1_pawn.Location.X == player1_pawnLocations["toronto"][0] && player1_pawn.Location.Y == player1_pawnLocations["toronto"][1])
                        {
                            torontoMove();
                        }
                        else if (player1_pawn.Location.X == player1_pawnLocations["pooleHarbour"][0] && player1_pawn.Location.Y == player1_pawnLocations["pooleHarbour"][1])
                        {
                            pooleHarbourMove();
                        }
                        else if (player1_pawn.Location.X == player1_pawnLocations["rome"][0] && player1_pawn.Location.Y == player1_pawnLocations["rome"][1])
                        {
                            romeMove();
                        }
                        else if (player1_pawn.Location.X == player1_pawnLocations["cmUpperLeft"][0] && player1_pawn.Location.Y == player1_pawnLocations["cmUpperLeft"][1])
                        {
                            cmUpperLeftMove();
                        }
                        else if (player1_pawn.Location.X == player1_pawnLocations["shanghai"][0] && player1_pawn.Location.Y == player1_pawnLocations["shanghai"][1])
                        {
                            shanghaiMove();
                        }
                        else if (player1_pawn.Location.X == player1_pawnLocations["vancouver"][0] && player1_pawn.Location.Y == player1_pawnLocations["vancouver"][1])
                        {
                            vancouverMove();
                        }
                        else if (player1_pawn.Location.X == player1_pawnLocations["freePark"][0] && player1_pawn.Location.Y == player1_pawnLocations["freePark"][1])
                        {
                            freeParkMove();
                        }
                        else if (player1_pawn.Location.X == player1_pawnLocations["sydney"][0] && player1_pawn.Location.Y == player1_pawnLocations["sydney"][1])
                        {
                            sydneyMove();
                        }
                        else if (player1_pawn.Location.X == player1_pawnLocations["chanceUpperRight"][0] && player1_pawn.Location.Y == player1_pawnLocations["chanceUpperRight"][1])
                        {
                            chanceUpperRightMove();
                        }
                        else if (player1_pawn.Location.X == player1_pawnLocations["newYork"][0] && player1_pawn.Location.Y == player1_pawnLocations["newYork"][1])
                        {
                            newYorkMove();
                        }
                        else if (player1_pawn.Location.X == player1_pawnLocations["london"][0] && player1_pawn.Location.Y == player1_pawnLocations["london"][1])
                        {
                            londonMove();
                        }
                        else if (player1_pawn.Location.X == player1_pawnLocations["englishHarbour"][0] && player1_pawn.Location.Y == player1_pawnLocations["englishHarbour"][1])
                        {
                            englishHarbourMove();
                        }
                        else if (player1_pawn.Location.X == player1_pawnLocations["beijing"][0] && player1_pawn.Location.Y == player1_pawnLocations["beijing"][1])
                        {
                            beijingMove();
                        }
                        else if (player1_pawn.Location.X == player1_pawnLocations["hongKong"][0] && player1_pawn.Location.Y == player1_pawnLocations["hongKong"][1])
                        {
                            hongKongMove();
                        }
                        else if (player1_pawn.Location.X == player1_pawnLocations["waterWorks"][0] && player1_pawn.Location.Y == player1_pawnLocations["waterWorks"][1])
                        {
                            waterWorksMove();
                        }
                        else if (player1_pawn.Location.X == player1_pawnLocations["jerusalem"][0] && player1_pawn.Location.Y == player1_pawnLocations["jerusalem"][1])
                        {
                            jerusalemMove();
                        }
                        else if (player1_pawn.Location.X == player1_pawnLocations["goToJail"][0] && player1_pawn.Location.Y == player1_pawnLocations["goToJail"][1])
                        {
                            goToJailMove();
                        }
                        else if (player1_pawn.Location.X == player1_pawnLocations["paris"][0] && player1_pawn.Location.Y == player1_pawnLocations["paris"][1])
                        {
                            parisMove();
                        }
                        else if (player1_pawn.Location.X == player1_pawnLocations["belgrade"][0] && player1_pawn.Location.Y == player1_pawnLocations["belgrade"][1])
                        {
                            belgradeMove();
                        }
                        else if (player1_pawn.Location.X == player1_pawnLocations["cmLowerRight"][0] && player1_pawn.Location.Y == player1_pawnLocations["cmLowerRight"][1])
                        {
                            cmLowerRightMove();
                        }
                        else if (player1_pawn.Location.X == player1_pawnLocations["capeTown"][0] && player1_pawn.Location.Y == player1_pawnLocations["capeTown"][1])
                        {
                            capeTownMove();
                        }
                        else if (player1_pawn.Location.X == player1_pawnLocations["heathrowAirport"][0] && player1_pawn.Location.Y == player1_pawnLocations["heathrowAirport"][1])
                        {
                            heathrowAirportMove();
                        }
                        else if (player1_pawn.Location.X == player1_pawnLocations["chanceLowerRight"][0] && player1_pawn.Location.Y == player1_pawnLocations["chanceLowerRight"][1])
                        {
                            chanceLowerRightMove();
                        }
                        else if (player1_pawn.Location.X == player1_pawnLocations["riga"][0] && player1_pawn.Location.Y == player1_pawnLocations["riga"][1])
                        {
                            rigaMove();
                        }
                        else if (player1_pawn.Location.X == player1_pawnLocations["luxuryTax"][0] && player1_pawn.Location.Y == player1_pawnLocations["luxuryTax"][1])
                        {
                            luxuryTaxMove();
                        }
                        else if (player1_pawn.Location.X == player1_pawnLocations["montreal"][0] && player1_pawn.Location.Y == player1_pawnLocations["montreal"][1])
                        {
                            montrealMove();
                        }
                    }
                    else if (playerNo == 2)
                    {
                        if (player2_pawn.Location.X == player2_pawnLocations["start"][0] && player2_pawn.Location.Y == player2_pawnLocations["start"][1])
                        {
                            startMove();
                        }
                        else if (player2_pawn.Location.X == player2_pawnLocations["gdynia"][0] && player2_pawn.Location.Y == player2_pawnLocations["gdynia"][1])
                        {
                            gdyniaMove();
                        }
                        else if (player2_pawn.Location.X == player2_pawnLocations["cmLowerLeft"][0] && player2_pawn.Location.Y == player2_pawnLocations["cmLowerLeft"][1])
                        {
                            cmLowerLeftMove();
                        }
                        else if (player2_pawn.Location.X == player2_pawnLocations["taipei"][0] && player2_pawn.Location.Y == player2_pawnLocations["taipei"][1])
                        {
                            taipeiMove();
                        }
                        else if (player2_pawn.Location.X == player2_pawnLocations["incomeTax"][0] && player2_pawn.Location.Y == player2_pawnLocations["incomeTax"][1])
                        {
                            incomeTaxMove();
                        }
                        else if (player2_pawn.Location.X == player2_pawnLocations["grandCentral"][0] && player2_pawn.Location.Y == player2_pawnLocations["grandCentral"][1])
                        {
                            grandCentralMove();
                        }
                        else if (player2_pawn.Location.X == player2_pawnLocations["tokyo"][0] && player2_pawn.Location.Y == player2_pawnLocations["tokyo"][1])
                        {
                            tokyoMove();
                        }
                        else if (player2_pawn.Location.X == player2_pawnLocations["tokyo"][0] && player2_pawn.Location.Y == player2_pawnLocations["tokyo"][1])
                        {
                            tokyoMove();
                        }
                        else if (player2_pawn.Location.X == player2_pawnLocations["chanceLowerLeft"][0] && player2_pawn.Location.Y == player2_pawnLocations["chanceLowerLeft"][1])
                        {
                            chanceLowerLeftMove();
                        }
                        else if (player2_pawn.Location.X == player2_pawnLocations["barcelona"][0] && player2_pawn.Location.Y == player2_pawnLocations["barcelona"][1])
                        {
                            barcelonaMove();
                        }
                        else if (player2_pawn.Location.X == player2_pawnLocations["athens"][0] && player2_pawn.Location.Y == player2_pawnLocations["athens"][1])
                        {
                            athensMove();
                        }
                        else if (player2_pawn.Location.X == player2_pawnLocations["visitor"][0] && player2_pawn.Location.Y == player2_pawnLocations["visitor"][1])
                        {
                            visitorMove();
                        }
                        else if (player2_pawn.Location.X == player2_pawnLocations["istanbul"][0] && player2_pawn.Location.Y == player2_pawnLocations["istanbul"][1])
                        {
                            istanbulMove();
                        }
                        else if (player2_pawn.Location.X == player2_pawnLocations["electricCompany"][0] && player2_pawn.Location.Y == player2_pawnLocations["electricCompany"][1])
                        {
                            electricCompanyMove();
                        }
                        else if (player2_pawn.Location.X == player2_pawnLocations["kyiv"][0] && player2_pawn.Location.Y == player2_pawnLocations["kyiv"][1])
                        {
                            kyivMove();
                        }
                        else if (player2_pawn.Location.X == player2_pawnLocations["toronto"][0] && player2_pawn.Location.Y == player2_pawnLocations["toronto"][1])
                        {
                            torontoMove();
                        }
                        else if (player2_pawn.Location.X == player2_pawnLocations["pooleHarbour"][0] && player2_pawn.Location.Y == player2_pawnLocations["pooleHarbour"][1])
                        {
                            pooleHarbourMove();
                        }
                        else if (player2_pawn.Location.X == player2_pawnLocations["rome"][0] && player2_pawn.Location.Y == player2_pawnLocations["rome"][1])
                        {
                            romeMove();
                        }
                        else if (player2_pawn.Location.X == player2_pawnLocations["cmUpperLeft"][0] && player2_pawn.Location.Y == player2_pawnLocations["cmUpperLeft"][1])
                        {
                            cmUpperLeftMove();
                        }
                        else if (player2_pawn.Location.X == player2_pawnLocations["shanghai"][0] && player2_pawn.Location.Y == player2_pawnLocations["shanghai"][1])
                        {
                            shanghaiMove();
                        }
                        else if (player2_pawn.Location.X == player2_pawnLocations["vancouver"][0] && player2_pawn.Location.Y == player2_pawnLocations["vancouver"][1])
                        {
                            vancouverMove();
                        }
                        else if (player2_pawn.Location.X == player2_pawnLocations["freePark"][0] && player2_pawn.Location.Y == player2_pawnLocations["freePark"][1])
                        {
                            freeParkMove();
                        }
                        else if (player2_pawn.Location.X == player2_pawnLocations["sydney"][0] && player2_pawn.Location.Y == player2_pawnLocations["sydney"][1])
                        {
                            sydneyMove();
                        }
                        else if (player2_pawn.Location.X == player2_pawnLocations["chanceUpperRight"][0] && player2_pawn.Location.Y == player2_pawnLocations["chanceUpperRight"][1])
                        {
                            chanceUpperRightMove();
                        }
                        else if (player2_pawn.Location.X == player2_pawnLocations["newYork"][0] && player2_pawn.Location.Y == player2_pawnLocations["newYork"][1])
                        {
                            newYorkMove();
                        }
                        else if (player2_pawn.Location.X == player2_pawnLocations["london"][0] && player2_pawn.Location.Y == player2_pawnLocations["london"][1])
                        {
                            londonMove();
                        }
                        else if (player2_pawn.Location.X == player2_pawnLocations["englishHarbour"][0] && player2_pawn.Location.Y == player2_pawnLocations["englishHarbour"][1])
                        {
                            englishHarbourMove();
                        }
                        else if (player2_pawn.Location.X == player2_pawnLocations["beijing"][0] && player2_pawn.Location.Y == player2_pawnLocations["beijing"][1])
                        {
                            beijingMove();
                        }
                        else if (player2_pawn.Location.X == player2_pawnLocations["hongKong"][0] && player2_pawn.Location.Y == player2_pawnLocations["hongKong"][1])
                        {
                            hongKongMove();
                        }
                        else if (player2_pawn.Location.X == player2_pawnLocations["waterWorks"][0] && player2_pawn.Location.Y == player2_pawnLocations["waterWorks"][1])
                        {
                            waterWorksMove();
                        }
                        else if (player2_pawn.Location.X == player2_pawnLocations["jerusalem"][0] && player2_pawn.Location.Y == player2_pawnLocations["jerusalem"][1])
                        {
                            jerusalemMove();
                        }
                        else if (player2_pawn.Location.X == player2_pawnLocations["goToJail"][0] && player2_pawn.Location.Y == player2_pawnLocations["goToJail"][1])
                        {
                            goToJailMove();
                        }
                        else if (player2_pawn.Location.X == player2_pawnLocations["paris"][0] && player2_pawn.Location.Y == player2_pawnLocations["paris"][1])
                        {
                            parisMove();
                        }
                        else if (player2_pawn.Location.X == player2_pawnLocations["belgrade"][0] && player2_pawn.Location.Y == player2_pawnLocations["belgrade"][1])
                        {
                            belgradeMove();
                        }
                        else if (player2_pawn.Location.X == player2_pawnLocations["cmLowerRight"][0] && player2_pawn.Location.Y == player2_pawnLocations["cmLowerRight"][1])
                        {
                            cmLowerRightMove();
                        }
                        else if (player2_pawn.Location.X == player2_pawnLocations["capeTown"][0] && player2_pawn.Location.Y == player2_pawnLocations["capeTown"][1])
                        {
                            capeTownMove();
                        }
                        else if (player2_pawn.Location.X == player2_pawnLocations["heathrowAirport"][0] && player2_pawn.Location.Y == player2_pawnLocations["heathrowAirport"][1])
                        {
                            heathrowAirportMove();
                        }
                        else if (player2_pawn.Location.X == player2_pawnLocations["chanceLowerRight"][0] && player2_pawn.Location.Y == player2_pawnLocations["chanceLowerRight"][1])
                        {
                            chanceLowerRightMove();
                        }
                        else if (player2_pawn.Location.X == player2_pawnLocations["riga"][0] && player2_pawn.Location.Y == player2_pawnLocations["riga"][1])
                        {
                            rigaMove();
                        }
                        else if (player2_pawn.Location.X == player2_pawnLocations["luxuryTax"][0] && player2_pawn.Location.Y == player2_pawnLocations["luxuryTax"][1])
                        {
                            luxuryTaxMove();
                        }
                        else if (player2_pawn.Location.X == player2_pawnLocations["montreal"][0] && player2_pawn.Location.Y == player2_pawnLocations["montreal"][1])
                        {
                            montrealMove();
                        }
                    }
                    else if (playerNo == 3)
                    {
                        if (player3_pawn.Location.X == player3_pawnLocations["start"][0] && player3_pawn.Location.Y == player3_pawnLocations["start"][1])
                        {
                            startMove();
                        }
                        else if (player3_pawn.Location.X == player3_pawnLocations["gdynia"][0] && player3_pawn.Location.Y == player3_pawnLocations["gdynia"][1])
                        {
                            gdyniaMove();
                        }
                        else if (player3_pawn.Location.X == player3_pawnLocations["cmLowerLeft"][0] && player3_pawn.Location.Y == player3_pawnLocations["cmLowerLeft"][1])
                        {
                            cmLowerLeftMove();
                        }
                        else if (player3_pawn.Location.X == player3_pawnLocations["taipei"][0] && player3_pawn.Location.Y == player3_pawnLocations["taipei"][1])
                        {
                            taipeiMove();
                        }
                        else if (player3_pawn.Location.X == player3_pawnLocations["incomeTax"][0] && player3_pawn.Location.Y == player3_pawnLocations["incomeTax"][1])
                        {
                            incomeTaxMove();
                        }
                        else if (player3_pawn.Location.X == player3_pawnLocations["grandCentral"][0] && player3_pawn.Location.Y == player3_pawnLocations["grandCentral"][1])
                        {
                            grandCentralMove();
                        }
                        else if (player3_pawn.Location.X == player3_pawnLocations["tokyo"][0] && player3_pawn.Location.Y == player3_pawnLocations["tokyo"][1])
                        {
                            tokyoMove();
                        }
                        else if (player3_pawn.Location.X == player3_pawnLocations["tokyo"][0] && player3_pawn.Location.Y == player3_pawnLocations["tokyo"][1])
                        {
                            tokyoMove();
                        }
                        else if (player3_pawn.Location.X == player3_pawnLocations["chanceLowerLeft"][0] && player3_pawn.Location.Y == player3_pawnLocations["chanceLowerLeft"][1])
                        {
                            chanceLowerLeftMove();
                        }
                        else if (player3_pawn.Location.X == player3_pawnLocations["barcelona"][0] && player3_pawn.Location.Y == player3_pawnLocations["barcelona"][1])
                        {
                            barcelonaMove();
                        }
                        else if (player3_pawn.Location.X == player3_pawnLocations["athens"][0] && player3_pawn.Location.Y == player3_pawnLocations["athens"][1])
                        {
                            athensMove();
                        }
                        else if (player3_pawn.Location.X == player3_pawnLocations["visitor"][0] && player3_pawn.Location.Y == player3_pawnLocations["visitor"][1])
                        {
                            visitorMove();
                        }
                        else if (player3_pawn.Location.X == player3_pawnLocations["istanbul"][0] && player3_pawn.Location.Y == player3_pawnLocations["istanbul"][1])
                        {
                            istanbulMove();
                        }
                        else if (player3_pawn.Location.X == player3_pawnLocations["electricCompany"][0] && player3_pawn.Location.Y == player3_pawnLocations["electricCompany"][1])
                        {
                            electricCompanyMove();
                        }
                        else if (player3_pawn.Location.X == player3_pawnLocations["kyiv"][0] && player3_pawn.Location.Y == player3_pawnLocations["kyiv"][1])
                        {
                            kyivMove();
                        }
                        else if (player3_pawn.Location.X == player3_pawnLocations["toronto"][0] && player3_pawn.Location.Y == player3_pawnLocations["toronto"][1])
                        {
                            torontoMove();
                        }
                        else if (player3_pawn.Location.X == player3_pawnLocations["pooleHarbour"][0] && player3_pawn.Location.Y == player3_pawnLocations["pooleHarbour"][1])
                        {
                            pooleHarbourMove();
                        }
                        else if (player3_pawn.Location.X == player3_pawnLocations["rome"][0] && player3_pawn.Location.Y == player3_pawnLocations["rome"][1])
                        {
                            romeMove();
                        }
                        else if (player3_pawn.Location.X == player3_pawnLocations["cmUpperLeft"][0] && player3_pawn.Location.Y == player3_pawnLocations["cmUpperLeft"][1])
                        {
                            cmUpperLeftMove();
                        }
                        else if (player3_pawn.Location.X == player3_pawnLocations["shanghai"][0] && player3_pawn.Location.Y == player3_pawnLocations["shanghai"][1])
                        {
                            shanghaiMove();
                        }
                        else if (player3_pawn.Location.X == player3_pawnLocations["vancouver"][0] && player3_pawn.Location.Y == player3_pawnLocations["vancouver"][1])
                        {
                            vancouverMove();
                        }
                        else if (player3_pawn.Location.X == player3_pawnLocations["freePark"][0] && player3_pawn.Location.Y == player3_pawnLocations["freePark"][1])
                        {
                            freeParkMove();
                        }
                        else if (player3_pawn.Location.X == player3_pawnLocations["sydney"][0] && player3_pawn.Location.Y == player3_pawnLocations["sydney"][1])
                        {
                            sydneyMove();
                        }
                        else if (player3_pawn.Location.X == player3_pawnLocations["chanceUpperRight"][0] && player3_pawn.Location.Y == player3_pawnLocations["chanceUpperRight"][1])
                        {
                            chanceUpperRightMove();
                        }
                        else if (player3_pawn.Location.X == player3_pawnLocations["newYork"][0] && player3_pawn.Location.Y == player3_pawnLocations["newYork"][1])
                        {
                            newYorkMove();
                        }
                        else if (player3_pawn.Location.X == player3_pawnLocations["london"][0] && player3_pawn.Location.Y == player3_pawnLocations["london"][1])
                        {
                            londonMove();
                        }
                        else if (player3_pawn.Location.X == player3_pawnLocations["englishHarbour"][0] && player3_pawn.Location.Y == player3_pawnLocations["englishHarbour"][1])
                        {
                            englishHarbourMove();
                        }
                        else if (player3_pawn.Location.X == player3_pawnLocations["beijing"][0] && player3_pawn.Location.Y == player3_pawnLocations["beijing"][1])
                        {
                            beijingMove();
                        }
                        else if (player3_pawn.Location.X == player3_pawnLocations["hongKong"][0] && player3_pawn.Location.Y == player3_pawnLocations["hongKong"][1])
                        {
                            hongKongMove();
                        }
                        else if (player3_pawn.Location.X == player3_pawnLocations["waterWorks"][0] && player3_pawn.Location.Y == player3_pawnLocations["waterWorks"][1])
                        {
                            waterWorksMove();
                        }
                        else if (player3_pawn.Location.X == player3_pawnLocations["jerusalem"][0] && player3_pawn.Location.Y == player3_pawnLocations["jerusalem"][1])
                        {
                            jerusalemMove();
                        }
                        else if (player3_pawn.Location.X == player3_pawnLocations["goToJail"][0] && player3_pawn.Location.Y == player3_pawnLocations["goToJail"][1])
                        {
                            goToJailMove();
                        }
                        else if (player3_pawn.Location.X == player3_pawnLocations["paris"][0] && player3_pawn.Location.Y == player3_pawnLocations["paris"][1])
                        {
                            parisMove();
                        }
                        else if (player3_pawn.Location.X == player3_pawnLocations["belgrade"][0] && player3_pawn.Location.Y == player3_pawnLocations["belgrade"][1])
                        {
                            belgradeMove();
                        }
                        else if (player3_pawn.Location.X == player3_pawnLocations["cmLowerRight"][0] && player3_pawn.Location.Y == player3_pawnLocations["cmLowerRight"][1])
                        {
                            cmLowerRightMove();
                        }
                        else if (player3_pawn.Location.X == player3_pawnLocations["capeTown"][0] && player3_pawn.Location.Y == player3_pawnLocations["capeTown"][1])
                        {
                            capeTownMove();
                        }
                        else if (player3_pawn.Location.X == player3_pawnLocations["heathrowAirport"][0] && player3_pawn.Location.Y == player3_pawnLocations["heathrowAirport"][1])
                        {
                            heathrowAirportMove();
                        }
                        else if (player3_pawn.Location.X == player3_pawnLocations["chanceLowerRight"][0] && player3_pawn.Location.Y == player3_pawnLocations["chanceLowerRight"][1])
                        {
                            chanceLowerRightMove();
                        }
                        else if (player3_pawn.Location.X == player3_pawnLocations["riga"][0] && player3_pawn.Location.Y == player3_pawnLocations["riga"][1])
                        {
                            rigaMove();
                        }
                        else if (player3_pawn.Location.X == player3_pawnLocations["luxuryTax"][0] && player3_pawn.Location.Y == player3_pawnLocations["luxuryTax"][1])
                        {
                            luxuryTaxMove();
                        }
                        else if (player3_pawn.Location.X == player3_pawnLocations["montreal"][0] && player3_pawn.Location.Y == player3_pawnLocations["montreal"][1])
                        {
                            montrealMove();
                        }
                    }
                    else if (playerNo == 4)
                    {
                        if (player4_pawn.Location.X == player4_pawnLocations["start"][0] && player4_pawn.Location.Y == player4_pawnLocations["start"][1])
                        {
                            startMove();
                        }
                        else if (player4_pawn.Location.X == player4_pawnLocations["gdynia"][0] && player4_pawn.Location.Y == player4_pawnLocations["gdynia"][1])
                        {
                            gdyniaMove();
                        }
                        else if (player4_pawn.Location.X == player4_pawnLocations["cmLowerLeft"][0] && player4_pawn.Location.Y == player4_pawnLocations["cmLowerLeft"][1])
                        {
                            cmLowerLeftMove();
                        }
                        else if (player4_pawn.Location.X == player4_pawnLocations["taipei"][0] && player4_pawn.Location.Y == player4_pawnLocations["taipei"][1])
                        {
                            taipeiMove();
                        }
                        else if (player4_pawn.Location.X == player4_pawnLocations["incomeTax"][0] && player4_pawn.Location.Y == player4_pawnLocations["incomeTax"][1])
                        {
                            incomeTaxMove();
                        }
                        else if (player4_pawn.Location.X == player4_pawnLocations["grandCentral"][0] && player4_pawn.Location.Y == player4_pawnLocations["grandCentral"][1])
                        {
                            grandCentralMove();
                        }
                        else if (player4_pawn.Location.X == player4_pawnLocations["tokyo"][0] && player4_pawn.Location.Y == player4_pawnLocations["tokyo"][1])
                        {
                            tokyoMove();
                        }
                        else if (player4_pawn.Location.X == player4_pawnLocations["tokyo"][0] && player4_pawn.Location.Y == player4_pawnLocations["tokyo"][1])
                        {
                            tokyoMove();
                        }
                        else if (player4_pawn.Location.X == player4_pawnLocations["chanceLowerLeft"][0] && player4_pawn.Location.Y == player4_pawnLocations["chanceLowerLeft"][1])
                        {
                            chanceLowerLeftMove();
                        }
                        else if (player4_pawn.Location.X == player4_pawnLocations["barcelona"][0] && player4_pawn.Location.Y == player4_pawnLocations["barcelona"][1])
                        {
                            barcelonaMove();
                        }
                        else if (player4_pawn.Location.X == player4_pawnLocations["athens"][0] && player4_pawn.Location.Y == player4_pawnLocations["athens"][1])
                        {
                            athensMove();
                        }
                        else if (player4_pawn.Location.X == player4_pawnLocations["visitor"][0] && player4_pawn.Location.Y == player4_pawnLocations["visitor"][1])
                        {
                            visitorMove();
                        }
                        else if (player4_pawn.Location.X == player4_pawnLocations["istanbul"][0] && player4_pawn.Location.Y == player4_pawnLocations["istanbul"][1])
                        {
                            istanbulMove();
                        }
                        else if (player4_pawn.Location.X == player4_pawnLocations["electricCompany"][0] && player4_pawn.Location.Y == player4_pawnLocations["electricCompany"][1])
                        {
                            electricCompanyMove();
                        }
                        else if (player4_pawn.Location.X == player4_pawnLocations["kyiv"][0] && player4_pawn.Location.Y == player4_pawnLocations["kyiv"][1])
                        {
                            kyivMove();
                        }
                        else if (player4_pawn.Location.X == player4_pawnLocations["toronto"][0] && player4_pawn.Location.Y == player4_pawnLocations["toronto"][1])
                        {
                            torontoMove();
                        }
                        else if (player4_pawn.Location.X == player4_pawnLocations["pooleHarbour"][0] && player4_pawn.Location.Y == player4_pawnLocations["pooleHarbour"][1])
                        {
                            pooleHarbourMove();
                        }
                        else if (player4_pawn.Location.X == player4_pawnLocations["rome"][0] && player4_pawn.Location.Y == player4_pawnLocations["rome"][1])
                        {
                            romeMove();
                        }
                        else if (player4_pawn.Location.X == player4_pawnLocations["cmUpperLeft"][0] && player4_pawn.Location.Y == player4_pawnLocations["cmUpperLeft"][1])
                        {
                            cmUpperLeftMove();
                        }
                        else if (player4_pawn.Location.X == player4_pawnLocations["shanghai"][0] && player4_pawn.Location.Y == player4_pawnLocations["shanghai"][1])
                        {
                            shanghaiMove();
                        }
                        else if (player4_pawn.Location.X == player4_pawnLocations["vancouver"][0] && player4_pawn.Location.Y == player4_pawnLocations["vancouver"][1])
                        {
                            vancouverMove();
                        }
                        else if (player4_pawn.Location.X == player4_pawnLocations["freePark"][0] && player4_pawn.Location.Y == player4_pawnLocations["freePark"][1])
                        {
                            freeParkMove();
                        }
                        else if (player4_pawn.Location.X == player4_pawnLocations["sydney"][0] && player4_pawn.Location.Y == player4_pawnLocations["sydney"][1])
                        {
                            sydneyMove();
                        }
                        else if (player4_pawn.Location.X == player4_pawnLocations["chanceUpperRight"][0] && player4_pawn.Location.Y == player4_pawnLocations["chanceUpperRight"][1])
                        {
                            chanceUpperRightMove();
                        }
                        else if (player4_pawn.Location.X == player4_pawnLocations["newYork"][0] && player4_pawn.Location.Y == player4_pawnLocations["newYork"][1])
                        {
                            newYorkMove();
                        }
                        else if (player4_pawn.Location.X == player4_pawnLocations["london"][0] && player4_pawn.Location.Y == player4_pawnLocations["london"][1])
                        {
                            londonMove();
                        }
                        else if (player4_pawn.Location.X == player4_pawnLocations["englishHarbour"][0] && player4_pawn.Location.Y == player4_pawnLocations["englishHarbour"][1])
                        {
                            englishHarbourMove();
                        }
                        else if (player4_pawn.Location.X == player4_pawnLocations["beijing"][0] && player4_pawn.Location.Y == player4_pawnLocations["beijing"][1])
                        {
                            beijingMove();
                        }
                        else if (player4_pawn.Location.X == player4_pawnLocations["hongKong"][0] && player4_pawn.Location.Y == player4_pawnLocations["hongKong"][1])
                        {
                            hongKongMove();
                        }
                        else if (player4_pawn.Location.X == player4_pawnLocations["waterWorks"][0] && player4_pawn.Location.Y == player4_pawnLocations["waterWorks"][1])
                        {
                            waterWorksMove();
                        }
                        else if (player4_pawn.Location.X == player4_pawnLocations["jerusalem"][0] && player4_pawn.Location.Y == player4_pawnLocations["jerusalem"][1])
                        {
                            jerusalemMove();
                        }
                        else if (player4_pawn.Location.X == player4_pawnLocations["goToJail"][0] && player4_pawn.Location.Y == player4_pawnLocations["goToJail"][1])
                        {
                            goToJailMove();
                        }
                        else if (player4_pawn.Location.X == player4_pawnLocations["paris"][0] && player4_pawn.Location.Y == player4_pawnLocations["paris"][1])
                        {
                            parisMove();
                        }
                        else if (player4_pawn.Location.X == player4_pawnLocations["belgrade"][0] && player4_pawn.Location.Y == player4_pawnLocations["belgrade"][1])
                        {
                            belgradeMove();
                        }
                        else if (player4_pawn.Location.X == player4_pawnLocations["cmLowerRight"][0] && player4_pawn.Location.Y == player4_pawnLocations["cmLowerRight"][1])
                        {
                            cmLowerRightMove();
                        }
                        else if (player4_pawn.Location.X == player4_pawnLocations["capeTown"][0] && player4_pawn.Location.Y == player4_pawnLocations["capeTown"][1])
                        {
                            capeTownMove();
                        }
                        else if (player4_pawn.Location.X == player4_pawnLocations["heathrowAirport"][0] && player4_pawn.Location.Y == player4_pawnLocations["heathrowAirport"][1])
                        {
                            heathrowAirportMove();
                        }
                        else if (player4_pawn.Location.X == player4_pawnLocations["chanceLowerRight"][0] && player4_pawn.Location.Y == player4_pawnLocations["chanceLowerRight"][1])
                        {
                            chanceLowerRightMove();
                        }
                        else if (player4_pawn.Location.X == player4_pawnLocations["riga"][0] && player4_pawn.Location.Y == player4_pawnLocations["riga"][1])
                        {
                            rigaMove();
                        }
                        else if (player4_pawn.Location.X == player4_pawnLocations["luxuryTax"][0] && player4_pawn.Location.Y == player4_pawnLocations["luxuryTax"][1])
                        {
                            luxuryTaxMove();
                        }
                        else if (player4_pawn.Location.X == player4_pawnLocations["montreal"][0] && player4_pawn.Location.Y == player4_pawnLocations["montreal"][1])
                        {
                            montrealMove();
                        }
                    }
                

            }
            else
            {
                dice1 = _random.Next(1, 7);
                dice2 = _random.Next(1, 7);
                // if's for animating dice 1
                if (dice1 == 1)
                {
                    picDice1.Image = global::Monopoly_Project.Properties.Resources._1;
                }
                else if (dice1 == 2)
                {
                    picDice1.Image = global::Monopoly_Project.Properties.Resources._2;
                }
                else if (dice1 == 3)
                {
                    picDice1.Image = global::Monopoly_Project.Properties.Resources._3;
                }
                else if (dice1 == 4)
                {
                    picDice1.Image = global::Monopoly_Project.Properties.Resources._4;
                }
                else if (dice1 == 5)
                {
                    picDice1.Image = global::Monopoly_Project.Properties.Resources._5;
                }
                else if (dice1 == 6)
                {
                    picDice1.Image = global::Monopoly_Project.Properties.Resources._6;
                }

                //if's for animating dice 2

                if (dice2 == 1)
                {
                    picDice2.Image = global::Monopoly_Project.Properties.Resources._1;

                }
                else if (dice2 == 2)
                {
                    picDice2.Image = global::Monopoly_Project.Properties.Resources._2;
                }
                else if (dice2 == 3)
                {
                    picDice2.Image = global::Monopoly_Project.Properties.Resources._3;
                }
                else if (dice2 == 4)
                {
                    picDice2.Image = global::Monopoly_Project.Properties.Resources._4;
                }
                else if (dice2 == 5)
                {
                    picDice2.Image = global::Monopoly_Project.Properties.Resources._5;
                }
                else if (dice2 == 6)
                {
                    picDice2.Image = global::Monopoly_Project.Properties.Resources._6;
                }
                dice_total_to_show = dice1 + dice2;
                diceTotal_label.Text = dice_total_to_show.ToString();
            }
        }
        // Move animations
        private void timer1_Tick(object sender, EventArgs e)
        {
            int x, y;
                
            if (playerNo == 1)
            {
                x = player1_pawn.Location.X;
                y = player1_pawn.Location.Y;
            }
            else if(playerNo == 2)
            {
                x = player2_pawn.Location.X;
                y = player2_pawn.Location.Y;
            }
            else if(playerNo == 3)
            {
                x = player3_pawn.Location.X;
                y = player3_pawn.Location.Y;
            }
            else
            {
                x = player4_pawn.Location.X;
                y = player4_pawn.Location.Y;
            }
            if (landName == "start")
            {
                if (playerNo == 1)
                {
                    player1_pawn.Location = new Point(x - 7, y - 4);
                    if (player1_pawn.Location.X == player1_pawnLocations["gdynia"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            gdyniaMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("gdynia"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
                else if (playerNo == 2)
                {
                    player2_pawn.Location = new Point(x - 8, y - 3);
                    if (player2_pawn.Location.X == player2_pawnLocations["gdynia"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            gdyniaMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("gdynia"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
                else if (playerNo == 3)
                {
                    player3_pawn.Location = new Point(x - 7, y - 4);
                    if (player3_pawn.Location.X == player3_pawnLocations["gdynia"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            gdyniaMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("gdynia"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
                else if (playerNo == 4)
                {
                    player4_pawn.Location = new Point(x - 7, y - 4);
                    if (player4_pawn.Location.X == player4_pawnLocations["gdynia"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            gdyniaMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("gdynia"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
            }
            else if (landName == "gdynia")
            {
                if (playerNo == 1)
                {
                    player1_pawn.Location = new Point(x - 6, y - 4);
                    if (player1_pawn.Location.X == player1_pawnLocations["cmLowerLeft"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            cmLowerLeftMove();
                        }
                        else
                        {
                            // to do

                        }
                    }
                }
                else if (playerNo == 2)
                {
                    player2_pawn.Location = new Point(x - 7, y - 4);
                    if (player2_pawn.Location.X == player2_pawnLocations["cmLowerLeft"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            cmLowerLeftMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                        }
                    }
                }
                else if (playerNo == 3)
                {
                    player3_pawn.Location = new Point(x - 7, y - 5);
                    if (player3_pawn.Location.X == player3_pawnLocations["cmLowerLeft"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            cmLowerLeftMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                        }
                    }
                }
                else if (playerNo == 4)
                {
                    player4_pawn.Location = new Point(x - 7, y - 4);
                    if (player4_pawn.Location.X == player4_pawnLocations["cmLowerLeft"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            cmLowerLeftMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                        }
                    }
                }
            }
            else if (landName == "cmLowerLeft")
            {
                if (playerNo == 1)
                {
                    player1_pawn.Location = new Point(x - 8, y - 5);
                    if (player1_pawn.Location.X == player1_pawnLocations["taipei"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            taipeiMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("taipei"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
                else if (playerNo == 2)
                {
                    player2_pawn.Location = new Point(x - 7, y - 4);
                    if (player2_pawn.Location.X == player2_pawnLocations["taipei"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            taipeiMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("taipei"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
                else if (playerNo == 3)
                {
                    player3_pawn.Location = new Point(x - 7, y - 4);
                    if (player3_pawn.Location.X == player3_pawnLocations["taipei"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            taipeiMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("taipei"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
                else if (playerNo == 4)
                {
                    player4_pawn.Location = new Point(x - 6, y - 4);
                    if (player4_pawn.Location.X == player4_pawnLocations["taipei"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            taipeiMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("taipei"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
            }
            else if (landName == "taipei")
            {
                if (playerNo == 1)
                {
                    player1_pawn.Location = new Point(x - 6, y - 4);
                    if (player1_pawn.Location.X == player1_pawnLocations["incomeTax"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            incomeTaxMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                        }
                    }
                }
                else if (playerNo == 2)
                {
                    player2_pawn.Location = new Point(x - 6, y - 5);
                    if (player2_pawn.Location.X == player2_pawnLocations["incomeTax"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            incomeTaxMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                        }
                    }
                }
                else if (playerNo == 3)
                {
                    player3_pawn.Location = new Point(x - 7, y - 4);
                    if (player3_pawn.Location.X == player3_pawnLocations["incomeTax"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            incomeTaxMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                        }
                    }
                }
                else if (playerNo == 4)
                {
                    player4_pawn.Location = new Point(x - 7, y - 4);
                    if (player4_pawn.Location.X == player4_pawnLocations["incomeTax"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            incomeTaxMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                        }
                    }
                }
            }
            else if (landName == "incomeTax")
            {
                if (playerNo == 1)
                {
                    player1_pawn.Location = new Point(x - 7, y - 5);
                    if (player1_pawn.Location.X == player1_pawnLocations["grandCentral"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            grandCentralMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("grandCentral"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
                else if (playerNo == 2)
                {
                    player2_pawn.Location = new Point(x - 6, y - 4);
                    if (player2_pawn.Location.X == player2_pawnLocations["grandCentral"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            grandCentralMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("grandCentral"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
                else if (playerNo == 3)
                {
                    player3_pawn.Location = new Point(x - 7, y - 5);
                    if (player3_pawn.Location.X == player3_pawnLocations["grandCentral"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            grandCentralMove();
                        }
                        else
                        {
                            // display grand central
                            using (buy_property_screen buyPropScreen = new buy_property_screen("grandCentral"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
                else if (playerNo == 4)
                {
                    player4_pawn.Location = new Point(x - 8, y - 5);
                    if (player4_pawn.Location.X == player4_pawnLocations["grandCentral"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            grandCentralMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("grandCentral"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
            }
            else if (landName == "grandCentral")
            {
                if (playerNo == 1)
                {
                    player1_pawn.Location = new Point(x - 8, y - 4);
                    if (player1_pawn.Location.X == player1_pawnLocations["tokyo"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            tokyoMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("tokyo"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
                else if (playerNo == 2)
                {
                    player2_pawn.Location = new Point(x - 8, y - 4);
                    if (player2_pawn.Location.X == player2_pawnLocations["tokyo"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            tokyoMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("tokyo"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
                else if (playerNo == 3)
                {
                    player3_pawn.Location = new Point(x - 7, y - 4);
                    if (player3_pawn.Location.X == player3_pawnLocations["tokyo"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            tokyoMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("tokyo"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
                else if (playerNo == 4)
                {
                    player4_pawn.Location = new Point(x - 6, y - 4);
                    if (player4_pawn.Location.X == player4_pawnLocations["tokyo"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            tokyoMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("tokyo"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
            }
            else if (landName == "tokyo")
            {
                if (playerNo == 1)
                {
                    player1_pawn.Location = new Point(x - 6, y - 4);
                    if (player1_pawn.Location.X == player1_pawnLocations["chanceLowerLeft"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            chanceLowerLeftMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                        }
                    }
                }
                else if (playerNo == 2)
                {
                    player2_pawn.Location = new Point(x - 6, y - 5);
                    if (player2_pawn.Location.X == player2_pawnLocations["chanceLowerLeft"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            chanceLowerLeftMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                        }
                    }
                }
                else if (playerNo == 3)
                {
                    player3_pawn.Location = new Point(x - 6, y - 5);
                    if (player3_pawn.Location.X == player3_pawnLocations["chanceLowerLeft"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            chanceLowerLeftMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                        }
                    }
                }
                else if (playerNo == 4)
                {
                    player4_pawn.Location = new Point(x - 7, y - 4);
                    if (player4_pawn.Location.X == player4_pawnLocations["chanceLowerLeft"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            chanceLowerLeftMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                        }
                    }
                }
            }
            else if (landName == "chanceLowerLeft")
            {
                if (playerNo == 1)
                {
                    player1_pawn.Location = new Point(x - 8, y - 4);
                    if (player1_pawn.Location.X == player1_pawnLocations["barcelona"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            barcelonaMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("barcelona"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
                else if (playerNo == 2)
                {
                    player2_pawn.Location = new Point(x - 8, y - 4);
                    if (player2_pawn.Location.X == player2_pawnLocations["barcelona"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            barcelonaMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("barcelona"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
                else if (playerNo == 3)
                {
                    player3_pawn.Location = new Point(x - 8, y - 4);
                    if (player3_pawn.Location.X == player3_pawnLocations["barcelona"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            barcelonaMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("barcelona"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
                else if (playerNo == 4)
                {
                    player4_pawn.Location = new Point(x - 7, y - 5);
                    if (player4_pawn.Location.X == player4_pawnLocations["barcelona"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            barcelonaMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("barcelona"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
            }
            else if (landName == "barcelona")
            {
                if (playerNo == 1)
                {
                    player1_pawn.Location = new Point(x - 7, y - 4);
                    if (player1_pawn.Location.X == player1_pawnLocations["athens"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            athensMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("athens"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
                else if (playerNo == 2)
                {
                    player2_pawn.Location = new Point(x - 7, y - 4);
                    if (player2_pawn.Location.X == player2_pawnLocations["athens"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            athensMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("athens"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
                else if (playerNo == 3)
                {
                    player3_pawn.Location = new Point(x - 6, y - 4);
                    if (player3_pawn.Location.X == player3_pawnLocations["athens"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            athensMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("athens"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
                else if (playerNo == 4)
                {
                    player4_pawn.Location = new Point(x - 7, y - 4);
                    if (player4_pawn.Location.X == player4_pawnLocations["athens"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            athensMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("athens"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
            }
            else if (landName == "athens")
            {
                if (playerNo == 1)
                {
                    player1_pawn.Location = new Point(x - 6, y - 6);
                    if (player1_pawn.Location.X == player1_pawnLocations["visitor"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            visitorMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                        }
                    }
                }
                else if (playerNo == 2)
                {
                    player2_pawn.Location = new Point(x - 13, y - 6);
                    if (player2_pawn.Location.X == player2_pawnLocations["visitor"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            visitorMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                        }
                    }
                }
                else if (playerNo == 3)
                {
                    player3_pawn.Location = new Point(x - 6, y - 3);
                    if (player3_pawn.Location.X == player3_pawnLocations["visitor"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            visitorMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                        }
                    }
                }
                else if (playerNo == 4)
                {
                    player4_pawn.Location = new Point(x - 7, y - 4);
                    if (player4_pawn.Location.X == player4_pawnLocations["visitor"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            visitorMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                        }
                    }
                }
            }
            else if (landName == "visitor")
            {
                if (playerNo == 1)
                {
                    player1_pawn.Location = new Point(x + 8, y - 4);
                    if (player1_pawn.Location.X == player1_pawnLocations["istanbul"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            istanbulMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("istanbul"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
                else if (playerNo == 2)
                {
                    player2_pawn.Location = new Point(x + 7, y - 4);
                    if (player2_pawn.Location.X == player2_pawnLocations["istanbul"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            istanbulMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("istanbul"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
                else if (playerNo == 3)
                {
                    player3_pawn.Location = new Point(x + 11, y - 6);
                    if (player3_pawn.Location.X == player3_pawnLocations["istanbul"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            istanbulMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("istanbul"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
                else if (playerNo == 4)
                {
                    player4_pawn.Location = new Point(x + 6, y - 5);
                    if (player4_pawn.Location.X == player4_pawnLocations["istanbul"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            istanbulMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("istanbul"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
            }
            else if (landName == "istanbul")
            {
                if (playerNo == 1)
                {
                    player1_pawn.Location = new Point(x + 6, y - 4);
                    if (player1_pawn.Location.X == player1_pawnLocations["electricCompany"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            electricCompanyMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("electricCompany"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
                else if (playerNo == 2)
                {
                    player2_pawn.Location = new Point(x + 7, y - 5);
                    if (player2_pawn.Location.X == player2_pawnLocations["electricCompany"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            electricCompanyMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("electricCompany"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
                else if (playerNo == 3)
                {
                    player3_pawn.Location = new Point(x + 7, y - 4);
                    if (player3_pawn.Location.X == player3_pawnLocations["electricCompany"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            electricCompanyMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("electricCompany"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
                else if (playerNo == 4)
                {
                    player4_pawn.Location = new Point(x + 8, y - 4);
                    if (player4_pawn.Location.X == player4_pawnLocations["electricCompany"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            electricCompanyMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("electricCompany"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
            }
            else if (landName == "electricCompany")
            {
                if (playerNo == 1)
                {
                    player1_pawn.Location = new Point(x + 7, y - 5);
                    if (player1_pawn.Location.X == player1_pawnLocations["kyiv"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            kyivMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("kyiv"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
                else if (playerNo == 2)
                {
                    player2_pawn.Location = new Point(x + 7, y - 4);
                    if (player2_pawn.Location.X == player2_pawnLocations["kyiv"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            kyivMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("kyiv"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
                else if (playerNo == 3)
                {
                    player3_pawn.Location = new Point(x + 8, y - 5);
                    if (player3_pawn.Location.X == player3_pawnLocations["kyiv"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            kyivMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("kyiv"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
                else if (playerNo == 4)
                {
                    player4_pawn.Location = new Point(x + 5, y - 5);
                    if (player4_pawn.Location.X == player4_pawnLocations["kyiv"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            kyivMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("kyiv"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
            }
            else if (landName == "kyiv")
            {
                if (playerNo == 1)
                {
                    player1_pawn.Location = new Point(x + 7, y - 4);
                    if (player1_pawn.Location.X == player1_pawnLocations["toronto"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            torontoMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("toronto"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
                else if (playerNo == 2)
                {
                    player2_pawn.Location = new Point(x + 7, y - 4);
                    if (player2_pawn.Location.X == player2_pawnLocations["toronto"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            torontoMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("toronto"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
                else if (playerNo == 3)
                {
                    player3_pawn.Location = new Point(x + 6, y - 4);
                    if (player3_pawn.Location.X == player3_pawnLocations["toronto"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            torontoMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("toronto"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
                else if (playerNo == 4)
                {
                    player4_pawn.Location = new Point(x + 7, y - 4);
                    if (player4_pawn.Location.X == player4_pawnLocations["toronto"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            torontoMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("toronto"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
            }
            else if (landName == "toronto")
            {
                if (playerNo == 1)
                {
                    player1_pawn.Location = new Point(x + 7, y - 4);
                    if (player1_pawn.Location.X == player1_pawnLocations["pooleHarbour"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            pooleHarbourMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("pooleHarbour"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
                else if (playerNo == 2)
                {
                    player2_pawn.Location = new Point(x + 7, y - 4);
                    if (player2_pawn.Location.X == player2_pawnLocations["pooleHarbour"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            pooleHarbourMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("pooleHarbour"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
                else if (playerNo == 3)
                {
                    player3_pawn.Location = new Point(x + 8, y - 4);
                    if (player3_pawn.Location.X == player3_pawnLocations["pooleHarbour"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            pooleHarbourMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("pooleHarbour"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
                else if (playerNo == 4)
                {
                    player4_pawn.Location = new Point(x + 8, y - 4);
                    if (player4_pawn.Location.X == player4_pawnLocations["pooleHarbour"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            pooleHarbourMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("pooleHarbour"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
            }
            else if (landName == "pooleHarbour")
            {
                if (playerNo == 1)
                {
                    player1_pawn.Location = new Point(x + 7, y - 5);
                    if (player1_pawn.Location.X == player1_pawnLocations["rome"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            romeMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("rome"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
                else if (playerNo == 2)
                {
                    player2_pawn.Location = new Point(x + 7, y - 4);
                    if (player2_pawn.Location.X == player2_pawnLocations["rome"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            romeMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("rome"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
                else if (playerNo == 3)
                {
                    player3_pawn.Location = new Point(x + 6, y - 5);
                    if (player3_pawn.Location.X == player3_pawnLocations["rome"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            romeMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("rome"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
                else if (playerNo == 4)
                {
                    player4_pawn.Location = new Point(x + 6, y - 5);
                    if (player4_pawn.Location.X == player4_pawnLocations["rome"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            romeMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("rome"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
            }
            else if (landName == "rome")
            {
                if (playerNo == 1)
                {
                    player1_pawn.Location = new Point(x + 7, y - 4);
                    if (player1_pawn.Location.X == player1_pawnLocations["cmUpperLeft"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            cmUpperLeftMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                        }
                    }
                }
                else if (playerNo == 2)
                {
                    player2_pawn.Location = new Point(x + 7, y - 5);
                    if (player2_pawn.Location.X == player2_pawnLocations["cmUpperLeft"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            cmUpperLeftMove();
                        }
                        else
                        {
                            // Play related sound and upload money


                            /*
                            dispaly tarrarararara

                                delay 60 saniye
                                endturn---->>> setplayer*/
                        }
                    }
                }
                else if (playerNo == 3)
                {
                    player3_pawn.Location = new Point(x + 8, y - 3);
                    if (player3_pawn.Location.X == player3_pawnLocations["cmUpperLeft"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            cmUpperLeftMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                        }
                    }
                }
                else if (playerNo == 4)
                {
                    player4_pawn.Location = new Point(x + 8, y - 4);
                    if (player4_pawn.Location.X == player4_pawnLocations["cmUpperLeft"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            cmUpperLeftMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                        }
                    }
                }
            }
            else if (landName == "cmUpperLeft")
            {
                if (playerNo == 1)
                {
                    player1_pawn.Location = new Point(x + 7, y - 4);
                    if (player1_pawn.Location.X == player1_pawnLocations["shanghai"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            shanghaiMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("shanghai"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
                else if (playerNo == 2)
                {
                    player2_pawn.Location = new Point(x + 6, y - 4);
                    if (player2_pawn.Location.X == player2_pawnLocations["shanghai"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            shanghaiMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("shanghai"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
                else if (playerNo == 3)
                {
                    player3_pawn.Location = new Point(x + 6, y - 5);
                    if (player3_pawn.Location.X == player3_pawnLocations["shanghai"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            shanghaiMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("shanghai"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
                else if (playerNo == 4)
                {
                    player4_pawn.Location = new Point(x + 6, y - 5);
                    if (player4_pawn.Location.X == player4_pawnLocations["shanghai"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            shanghaiMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("shanghai"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
            }
            else if (landName == "shanghai")
            {
                if (playerNo == 1)
                {
                    player1_pawn.Location = new Point(x + 7, y - 5);
                    if (player1_pawn.Location.X == player1_pawnLocations["vancouver"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            vancouverMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("vancouver"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
                else if (playerNo == 2)
                {
                    player2_pawn.Location = new Point(x + 7, y - 5);
                    if (player2_pawn.Location.X == player2_pawnLocations["vancouver"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            vancouverMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("vancouver"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
                else if (playerNo == 3)
                {
                    player3_pawn.Location = new Point(x + 7, y - 5);
                    if (player3_pawn.Location.X == player3_pawnLocations["vancouver"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            vancouverMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("vancouver"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
                else if (playerNo == 4)
                {
                    player4_pawn.Location = new Point(x + 7, y - 4);
                    if (player4_pawn.Location.X == player4_pawnLocations["vancouver"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            vancouverMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("vancouver"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
            }
            else if (landName == "vancouver")
            {
                if (playerNo == 1)
                {
                    player1_pawn.Location = new Point(x + 7, y - 4);
                    if (player1_pawn.Location.X == player1_pawnLocations["freePark"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            freeParkMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                        }
                    }
                }
                else if (playerNo == 2)
                {
                    player2_pawn.Location = new Point(x + 7, y - 4);
                    if (player2_pawn.Location.X == player2_pawnLocations["freePark"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            freeParkMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                        }
                    }
                }
                else if (playerNo == 3)
                {
                    player3_pawn.Location = new Point(x + 5, y - 1);
                    if (player3_pawn.Location.X == player3_pawnLocations["freePark"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            freeParkMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                        }
                    }
                }
                else if (playerNo == 4)
                {
                    player4_pawn.Location = new Point(x + 12, y - 5);
                    if (player4_pawn.Location.X == player4_pawnLocations["freePark"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            freeParkMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                        }
                    }
                }
            }
            else if (landName == "freePark")
            {
                if (playerNo == 1)
                {
                    player1_pawn.Location = new Point(x + 11, y + 7);
                    if (player1_pawn.Location.X == player1_pawnLocations["sydney"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            sydneyMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("sydney"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
                else if (playerNo == 2)
                {
                    player2_pawn.Location = new Point(x + 11, y + 2);
                    if (player2_pawn.Location.X == player2_pawnLocations["sydney"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            sydneyMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("sydney"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
                else if (playerNo == 3)
                {
                    player3_pawn.Location = new Point(x + 4, y + 1);
                    if (player3_pawn.Location.X == player3_pawnLocations["sydney"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            sydneyMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("sydney"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
                else if (playerNo == 4)
                {
                    player4_pawn.Location = new Point(x + 5, y + 5);
                    if (player4_pawn.Location.X == player4_pawnLocations["sydney"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            sydneyMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("sydney"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
            }
            else if (landName == "sydney")
            {
                if (playerNo == 1)
                {
                    player1_pawn.Location = new Point(x + 7, y + 4);
                    if (player1_pawn.Location.X == player1_pawnLocations["chanceUpperRight"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            chanceUpperRightMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                        }
                    }
                }
                else if (playerNo == 2)
                {
                    player2_pawn.Location = new Point(x + 7, y + 5);
                    if (player2_pawn.Location.X == player2_pawnLocations["chanceUpperRight"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            chanceUpperRightMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                        }
                    }
                }
                else if (playerNo == 3)
                {
                    player3_pawn.Location = new Point(x + 6, y + 5);
                    if (player3_pawn.Location.X == player3_pawnLocations["chanceUpperRight"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            chanceUpperRightMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                        }
                    }
                }
                else if (playerNo == 4)
                {
                    player4_pawn.Location = new Point(x + 6, y + 5);
                    if (player4_pawn.Location.X == player4_pawnLocations["chanceUpperRight"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            chanceUpperRightMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                        }
                    }
                }
            }
            else if (landName == "chanceUpperRight")
            {
                if (playerNo == 1)
                {
                    player1_pawn.Location = new Point(x + 7, y + 5);
                    if (player1_pawn.Location.X == player1_pawnLocations["newYork"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            newYorkMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("newYork"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
                else if (playerNo == 2)
                {
                    player2_pawn.Location = new Point(x + 7, y + 4);
                    if (player2_pawn.Location.X == player2_pawnLocations["newYork"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            newYorkMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("newYork"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
                else if (playerNo == 3)
                {
                    player3_pawn.Location = new Point(x + 8, y + 4);
                    if (player3_pawn.Location.X == player3_pawnLocations["newYork"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            newYorkMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("newYork"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
                else if (playerNo == 4)
                {
                    player4_pawn.Location = new Point(x + 8, y + 4);
                    if (player4_pawn.Location.X == player4_pawnLocations["newYork"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            newYorkMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("newYork"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
            }
            else if (landName == "newYork")
            {
                if (playerNo == 1)
                {
                    player1_pawn.Location = new Point(x + 7, y + 4);
                    if (player1_pawn.Location.X == player1_pawnLocations["london"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            londonMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("london"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
                else if (playerNo == 2)
                {
                    player2_pawn.Location = new Point(x + 7, y + 4);
                    if (player2_pawn.Location.X == player2_pawnLocations["london"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            londonMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("london"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
                else if (playerNo == 3)
                {
                    player3_pawn.Location = new Point(x + 7, y + 4);
                    if (player3_pawn.Location.X == player3_pawnLocations["london"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            londonMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("london"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
                else if (playerNo == 4)
                {
                    player4_pawn.Location = new Point(x + 6, y + 4);
                    if (player4_pawn.Location.X == player4_pawnLocations["london"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            londonMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("london"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
            }
            else if (landName == "london")
            {
                if (playerNo == 1)
                {
                    player1_pawn.Location = new Point(x + 7, y + 4);
                    if (player1_pawn.Location.X == player1_pawnLocations["englishHarbour"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            englishHarbourMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("englishHarbour"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
                else if (playerNo == 2)
                {
                    player2_pawn.Location = new Point(x + 6, y + 5);
                    if (player2_pawn.Location.X == player2_pawnLocations["englishHarbour"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            englishHarbourMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("englishHarbour"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
                else if (playerNo == 3)
                {
                    player3_pawn.Location = new Point(x + 6, y + 5);
                    if (player3_pawn.Location.X == player3_pawnLocations["englishHarbour"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            englishHarbourMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("englishHarbour"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
                else if (playerNo == 4)
                {
                    player4_pawn.Location = new Point(x + 6, y + 5);
                    if (player4_pawn.Location.X == player4_pawnLocations["englishHarbour"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            englishHarbourMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("englishHarbour"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
            }
            else if (landName == "englishHarbour")
            {
                if (playerNo == 1)
                {
                    player1_pawn.Location = new Point(x + 7, y + 4);
                    if (player1_pawn.Location.X == player1_pawnLocations["beijing"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            beijingMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("beijing"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
                else if (playerNo == 2)
                {
                    player2_pawn.Location = new Point(x + 7, y + 4);
                    if (player2_pawn.Location.X == player2_pawnLocations["beijing"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            beijingMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("beijing"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
                else if (playerNo == 3)
                {
                    player3_pawn.Location = new Point(x + 8, y + 3);
                    if (player3_pawn.Location.X == player3_pawnLocations["beijing"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            beijingMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("beijing"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
                else if (playerNo == 4)
                {
                    player4_pawn.Location = new Point(x + 9, y + 4);
                    if (player4_pawn.Location.X == player4_pawnLocations["beijing"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            beijingMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("beijing"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
            }
            else if (landName == "beijing")
            {
                if (playerNo == 1)
                {
                    player1_pawn.Location = new Point(x + 7, y + 5);
                    if (player1_pawn.Location.X == player1_pawnLocations["hongKong"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            hongKongMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("hongKong"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
                else if (playerNo == 2)
                {
                    player2_pawn.Location = new Point(x + 7, y + 4);
                    if (player2_pawn.Location.X == player2_pawnLocations["hongKong"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            hongKongMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("hongKong"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
                else if (playerNo == 3)
                {
                    player3_pawn.Location = new Point(x + 7, y + 5);
                    if (player3_pawn.Location.X == player3_pawnLocations["hongKong"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            hongKongMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("hongKong"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
                else if (playerNo == 4)
                {
                    player4_pawn.Location = new Point(x + 7, y + 4);
                    if (player4_pawn.Location.X == player4_pawnLocations["hongKong"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            hongKongMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("hongKong"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
            }
            else if (landName == "hongKong")
            {
                if (playerNo == 1)
                {
                    player1_pawn.Location = new Point(x + 7, y + 4);
                    if (player1_pawn.Location.X == player1_pawnLocations["waterWorks"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            waterWorksMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("waterWorks"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
                else if (playerNo == 2)
                {
                    player2_pawn.Location = new Point(x + 7, y + 5);
                    if (player2_pawn.Location.X == player2_pawnLocations["waterWorks"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            waterWorksMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("waterWorks"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
                else if (playerNo == 3)
                {
                    player3_pawn.Location = new Point(x + 6, y + 5);
                    if (player3_pawn.Location.X == player3_pawnLocations["waterWorks"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            waterWorksMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("waterWorks"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
                else if (playerNo == 4)
                {
                    player4_pawn.Location = new Point(x + 5, y + 5);
                    if (player4_pawn.Location.X == player4_pawnLocations["waterWorks"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            waterWorksMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("waterWorks"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
            }
            else if (landName == "waterWorks")
            {
                if (playerNo == 1)
                {
                    player1_pawn.Location = new Point(x + 6, y + 4);
                    if (player1_pawn.Location.X == player1_pawnLocations["jerusalem"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            jerusalemMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("jerusalem"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
                else if (playerNo == 2)
                {
                    player2_pawn.Location = new Point(x + 7, y + 4);
                    if (player2_pawn.Location.X == player2_pawnLocations["jerusalem"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            jerusalemMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("jerusalem"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
                else if (playerNo == 3)
                {
                    player3_pawn.Location = new Point(x + 8, y + 3);
                    if (player3_pawn.Location.X == player3_pawnLocations["jerusalem"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            jerusalemMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("jerusalem"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
                else if (playerNo == 4)
                {
                    player4_pawn.Location = new Point(x + 8, y + 4);
                    if (player4_pawn.Location.X == player4_pawnLocations["jerusalem"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            jerusalemMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("jerusalem"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
            }
            else if (landName == "jerusalem")
            {
                if (playerNo == 1)
                {
                    player1_pawn.Location = new Point(x + 7, y + 5);
                    if (player1_pawn.Location.X == player1_pawnLocations["goToJail"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            goToJailMove();
                        }
                        else
                        {
                            // TO DO
                        }
                    }
                }
                else if (playerNo == 2)
                {
                    player2_pawn.Location = new Point(x + 7, y + 4);
                    if (player2_pawn.Location.X == player2_pawnLocations["goToJail"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            goToJailMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                        }
                    }
                }
                else if (playerNo == 3)
                {
                    player3_pawn.Location = new Point(x + 5, y + 6);
                    if (player3_pawn.Location.X == player3_pawnLocations["goToJail"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            goToJailMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                        }
                    }
                }
                else if (playerNo == 4)
                {
                    player4_pawn.Location = new Point(x + 6, y + 5);
                    if (player4_pawn.Location.X == player4_pawnLocations["goToJail"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            goToJailMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                        }
                    }
                }
            }
            else if (landName == "goToJail")
            {
                if (playerNo == 1)
                {
                    player1_pawn.Location = new Point(x - 10, y + 6);
                    if (player1_pawn.Location.X == player1_pawnLocations["paris"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            parisMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("paris"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
                else if (playerNo == 2)
                {
                    player2_pawn.Location = new Point(x - 3, y + 7);
                    if (player2_pawn.Location.X == player2_pawnLocations["paris"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            parisMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("paris"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
                else if (playerNo == 3)
                {
                    player3_pawn.Location = new Point(x - 5, y + 5);
                    if (player3_pawn.Location.X == player3_pawnLocations["paris"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            parisMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("paris"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
                else if (playerNo == 4)
                {
                    player4_pawn.Location = new Point(x - 7, y);
                    if (player4_pawn.Location.X == player4_pawnLocations["paris"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            parisMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("paris"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
            }
            else if (landName == "paris")
            {
                if (playerNo == 1)
                {
                    player1_pawn.Location = new Point(x - 7, y + 4);
                    if (player1_pawn.Location.X == player1_pawnLocations["belgrade"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            belgradeMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("belgrade"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
                else if (playerNo == 2)
                {
                    player2_pawn.Location = new Point(x - 7, y + 4);
                    if (player2_pawn.Location.X == player2_pawnLocations["belgrade"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            belgradeMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("belgrade"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
                else if (playerNo == 3)
                {
                    player3_pawn.Location = new Point(x - 7, y + 4);
                    if (player3_pawn.Location.X == player3_pawnLocations["belgrade"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            belgradeMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("belgrade"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
                else if (playerNo == 4)
                {
                    player4_pawn.Location = new Point(x - 6, y + 5);
                    if (player4_pawn.Location.X == player4_pawnLocations["belgrade"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            belgradeMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("belgrade"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
            }
            else if (landName == "belgrade")
            {
                if (playerNo == 1)
                {
                    player1_pawn.Location = new Point(x - 7, y + 5);
                    if (player1_pawn.Location.X == player1_pawnLocations["cmLowerRight"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            cmLowerRightMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                        }
                    }
                }
                else if (playerNo == 2)
                {
                    player2_pawn.Location = new Point(x - 7, y + 4);
                    if (player2_pawn.Location.X == player2_pawnLocations["cmLowerRight"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            cmLowerRightMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                        }
                    }
                }
                else if (playerNo == 3)
                {
                    player3_pawn.Location = new Point(x - 8, y + 4);
                    if (player3_pawn.Location.X == player3_pawnLocations["cmLowerRight"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            cmLowerRightMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                        }
                    }
                }
                else if (playerNo == 4)
                {
                    player4_pawn.Location = new Point(x - 8, y + 4);
                    if (player4_pawn.Location.X == player4_pawnLocations["cmLowerRight"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            cmLowerRightMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                        }
                    }
                }
            }
            else if (landName == "cmLowerRight")
            {
                if (playerNo == 1)
                {
                    player1_pawn.Location = new Point(x - 7, y + 4);
                    if (player1_pawn.Location.X == player1_pawnLocations["capeTown"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            capeTownMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("capeTown"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
                else if (playerNo == 2)
                {
                    player2_pawn.Location = new Point(x - 7, y + 5);
                    if (player2_pawn.Location.X == player2_pawnLocations["capeTown"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            capeTownMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("capeTown"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
                else if (playerNo == 3)
                {
                    player3_pawn.Location = new Point(x - 6, y + 5);
                    if (player3_pawn.Location.X == player3_pawnLocations["capeTown"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            capeTownMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("capeTown"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
                else if (playerNo == 4)
                {
                    player4_pawn.Location = new Point(x - 6, y + 4);
                    if (player4_pawn.Location.X == player4_pawnLocations["capeTown"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            capeTownMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("capeTown"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
            }
            else if (landName == "capeTown")
            {
                if (playerNo == 1)
                {
                    player1_pawn.Location = new Point(x - 7, y + 4);
                    if (player1_pawn.Location.X == player1_pawnLocations["heathrowAirport"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            heathrowAirportMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("heathrowAirport"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
                else if (playerNo == 2)
                {
                    player2_pawn.Location = new Point(x - 7, y + 4);
                    if (player2_pawn.Location.X == player2_pawnLocations["heathrowAirport"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            heathrowAirportMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("heathrowAirport"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
                else if (playerNo == 3)
                {
                    player3_pawn.Location = new Point(x - 8, y + 4);
                    if (player3_pawn.Location.X == player3_pawnLocations["heathrowAirport"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            heathrowAirportMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("heathrowAirport"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
                else if (playerNo == 4)
                {
                    player4_pawn.Location = new Point(x - 8, y + 4);
                    if (player4_pawn.Location.X == player4_pawnLocations["heathrowAirport"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            heathrowAirportMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("heathrowAirport"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
            }
            else if (landName == "heathrowAirport")
            {
                if (playerNo == 1)
                {
                    player1_pawn.Location = new Point(x - 7, y + 5);
                    if (player1_pawn.Location.X == player1_pawnLocations["chanceLowerRight"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            chanceLowerRightMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                        }
                    }
                }
                else if (playerNo == 2)
                {
                    player2_pawn.Location = new Point(x - 7, y + 4);
                    if (player2_pawn.Location.X == player2_pawnLocations["chanceLowerRight"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            chanceLowerRightMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                        }
                    }
                }
                else if (playerNo == 3)
                {
                    player3_pawn.Location = new Point(x - 7, y + 4);
                    if (player3_pawn.Location.X == player3_pawnLocations["chanceLowerRight"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            chanceLowerRightMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                        }
                    }
                }
                else if (playerNo == 4)
                {
                    player4_pawn.Location = new Point(x - 7, y + 4);
                    if (player4_pawn.Location.X == player4_pawnLocations["chanceLowerRight"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            chanceLowerRightMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                        }
                    }
                }
            }
            else if (landName == "chanceLowerRight")
            {
                if (playerNo == 1)
                {
                    player1_pawn.Location = new Point(x - 7, y + 4);
                    if (player1_pawn.Location.X == player1_pawnLocations["riga"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            rigaMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("riga"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
                else if (playerNo == 2)
                {
                    player2_pawn.Location = new Point(x - 7, y + 5);
                    if (player2_pawn.Location.X == player2_pawnLocations["riga"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            rigaMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("riga"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
                else if (playerNo == 3)
                {
                    player3_pawn.Location = new Point(x - 5, y + 5);
                    if (player3_pawn.Location.X == player3_pawnLocations["riga"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            rigaMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("riga"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
                else if (playerNo == 4)
                {
                    player4_pawn.Location = new Point(x - 6, y + 5);
                    if (player4_pawn.Location.X == player4_pawnLocations["riga"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            rigaMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("riga"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
            }
            else if (landName == "riga")
            {
                if (playerNo == 1)
                {
                    player1_pawn.Location = new Point(x - 7, y + 4);
                    if (player1_pawn.Location.X == player1_pawnLocations["luxuryTax"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            luxuryTaxMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                        }
                    }
                }
                else if (playerNo == 2)
                {
                    player2_pawn.Location = new Point(x - 7, y + 4);
                    if (player2_pawn.Location.X == player2_pawnLocations["luxuryTax"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            luxuryTaxMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                        }
                    }
                }
                else if (playerNo == 3)
                {
                    player3_pawn.Location = new Point(x - 8, y + 4);
                    if (player3_pawn.Location.X == player3_pawnLocations["luxuryTax"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            luxuryTaxMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                        }
                    }
                }
                else if (playerNo == 4)
                {
                    player4_pawn.Location = new Point(x - 8, y + 4);
                    if (player4_pawn.Location.X == player4_pawnLocations["luxuryTax"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            luxuryTaxMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                        }
                    }
                }
            }
            else if (landName == "luxuryTax")
            {
                if (playerNo == 1)
                {
                    player1_pawn.Location = new Point(x - 7, y + 5);
                    if (player1_pawn.Location.X == player1_pawnLocations["montreal"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            montrealMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("montreal"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
                else if (playerNo == 2)
                {
                    player2_pawn.Location = new Point(x - 7, y + 5);
                    if (player2_pawn.Location.X == player2_pawnLocations["montreal"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            montrealMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("montreal"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
                else if (playerNo == 3)
                {
                    player3_pawn.Location = new Point(x - 6, y + 4);
                    if (player3_pawn.Location.X == player3_pawnLocations["montreal"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            montrealMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("montreal"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
                else if (playerNo == 4)
                {
                    player4_pawn.Location = new Point(x - 6, y + 5);
                    if (player4_pawn.Location.X == player4_pawnLocations["montreal"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            montrealMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                            using (buy_property_screen buyPropScreen = new buy_property_screen("montreal"))
                            {
                                buyPropScreen.ShowDialog();
                            }
                        }
                    }
                }
            }
            else if (landName == "montreal")
            {
                if (playerNo == 1)
                {
                    player1_pawn.Location = new Point(x - 8, y);
                    if (player1_pawn.Location.X == player1_pawnLocations["start"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            startMove();
                        }
                        else
                        {

                        }
                    }
                }
                else if (playerNo == 2)
                {
                    player2_pawn.Location = new Point(x - 7, y + 3);
                    if (player2_pawn.Location.X == player2_pawnLocations["start"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            startMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                        }
                    }
                }
                else if (playerNo == 3)
                {
                    player3_pawn.Location = new Point(x - 9, y + 4);
                    if (player3_pawn.Location.X == player3_pawnLocations["start"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            startMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                        }
                    }
                }
                else if (playerNo == 4)
                {
                    player4_pawn.Location = new Point(x - 8, y + 7);
                    if (player4_pawn.Location.X == player4_pawnLocations["start"][0])
                    {
                        timer1.Stop();
                        if (dice_total > 0)
                        {
                            startMove();
                        }
                        else
                        {
                            // Play related sound and upload money
                        }
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            //testShowProp.Tag = "gdynia";
            //button5.Text = testShowProp.Tag.ToString();
            using ( buy_property_screen buyPropScreen = new buy_property_screen(landName))
            {
                buyPropScreen.ShowDialog();
            }
        }

 

        private void button6_Click(object sender, EventArgs e)
        {
            using (bidding_screen bidScreen = new bidding_screen("newYork"))
            {
                bidScreen.ShowDialog();
            }
        }

        private void player1_show_info_Click(object sender, EventArgs e)
        {
            string[] arrDeneme = {"gdynia","taipei","grandCentral","tokyo","barcelona","athens",
                                    "istanbul","electricCompany","kyiv","toronto","pooleHarbour",
                                    "rome","shanghai","vancouver","sydney","newYork","london",
                                    "beijing","hongKong","waterWorks","jerusalem","paris","belgrade"
                                    ,"capeTown","heathrowAirport","riga","montreal"};
            using (ShowPropertiesScreen showPropsScreen = new ShowPropertiesScreen(arrDeneme,1,"batu",player1_icon.Image))
            {
                showPropsScreen.ShowDialog();
            }
        }

        private void player2_show_info_Click(object sender, EventArgs e)
        {
            // ARR DENEME YERİNE PLAYER.GETPROPERTİES OLACAK EZZZZZZZ
            string[] arrDeneme = {"gdynia","taipei","grandCentral","tokyo","barcelona","athens",
                                    "istanbul","electricCompany","kyiv","toronto","pooleHarbour",
                                    "rome","shanghai","vancouver","sydney","newYork","london",
                                    "beijing","hongKong","waterWorks","jerusalem","paris","belgrade"
                                    ,"capeTown","heathrowAirport","riga","montreal"};
            using (ShowPropertiesScreen showPropsScreen = new ShowPropertiesScreen(arrDeneme,2,"1batu",player2_icon.Image))
            {
                showPropsScreen.ShowDialog();
            }
        }

        private void playe3_show_info_Click(object sender, EventArgs e)
        {
            string[] arrDeneme = {"gdynia","taipei","grandCentral","tokyo","barcelona","athens",
                                    "istanbul","electricCompany","kyiv","toronto","pooleHarbour",
                                    "rome","shanghai","vancouver","sydney","newYork","london",
                                    "beijing","hongKong","waterWorks","jerusalem","paris","belgrade"
                                    ,"capeTown","heathrowAirport","riga","montreal"};
            using (ShowPropertiesScreen showPropsScreen = new ShowPropertiesScreen(arrDeneme,3, "batu2",player3_icon.Image))
            {
                showPropsScreen.ShowDialog();
            }
        }

        private void player4_show_info_Click(object sender, EventArgs e)
        {
            string[] arrDeneme = {"gdynia","taipei","grandCentral","tokyo","barcelona","athens",
                                    "istanbul","electricCompany","kyiv","toronto","pooleHarbour",
                                    "rome","shanghai","vancouver","sydney","newYork","london",
                                    "beijing","hongKong","waterWorks","jerusalem","paris","belgrade"
                                    ,"capeTown","heathrowAirport","riga","montreal"};
            using (ShowPropertiesScreen showPropsScreen = new ShowPropertiesScreen(arrDeneme,4, "batu3", player4_icon.Image))
            {
                showPropsScreen.ShowDialog();
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            using(outJail_screen outJailScreen = new outJail_screen())
            {
                outJailScreen.ShowDialog();
            }
        }
    }
}

