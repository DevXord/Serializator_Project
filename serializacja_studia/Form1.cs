using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace serializacja_studia
{
    public partial class Form1 : Form
    {
        private string FILE_PATH = Path.GetFullPath(Path.Combine(Application.ExecutablePath, "..\\", "..\\", "..\\", "save\\"));
        private string FILE_FILTER = "JSON files (*.json)|*.json";
        private int FILTER_INDEX = 1;
        private int TUR_NUMBER = 1;
        private Player player;
        private Wolf wolf = new Wolf(1, 25, 3);
        Random rd = new Random();

        public Form1()
        {
            InitializeComponent();

            resetValue(0);
        }
        private void createNewWolf()
        {
            int l = rd.Next(player.getPlayerLevel() > 5 ? player.getPlayerLevel() - 5 :player.getPlayerLevel() + 1, player.getPlayerLevel() > 5 ? player.getPlayerLevel() + 5 : player.getPlayerLevel() + 1);
            wolf = new Wolf(l, 25 * l, rd.Next(1+l, 4+l));
        }
        private void showPlayerAttackElements()
        {
            atackp_pc.Visible = true;
            atackw_pc.Visible = false;
            at_bt.Enabled = false;
            mat_bt.Enabled = false;
            turaliczba_lb.Text = Convert.ToString(TUR_NUMBER);
            hit_lb.Text = Convert.ToString(Math.Round(player.getDamage(), 2));
            hit_lb.ForeColor = Color.Green;
        }
        private void showWolfAttackElements()
        {
            at_bt.Invoke(new Action(delegate () { at_bt.Enabled = true; }));
            mat_bt.Invoke(new Action(delegate () { mat_bt.Enabled = true; }));
            atackp_pc.Invoke(new Action(delegate () { atackp_pc.Visible = false; }));
            atackw_pc.Invoke(new Action(delegate () { atackw_pc.Visible = true;}));
            turaliczba_lb.Invoke(new Action(delegate () { turaliczba_lb.Text = Convert.ToString(TUR_NUMBER); }));
            hit_lb.Invoke(new Action(delegate () { hit_lb.Text = Convert.ToString(Math.Round(wolf.getDamage(), 2)); }));
            hit_lb.ForeColor = Color.Red;
        }
        private void resetValue(int type)
        {
            if (type == 1)
            {
                at_bt.Visible = true;
                mat_bt.Visible = true;
                player_pic.Visible = true;
                wolf_pic.Visible = true;
                atackw_pc.Visible = false;
                atackp_pc.Visible = false;
                hit_lb.Visible = false;
                playerinfo_lb.Visible = true;
                wolfinfo_lb.Visible = true;
                turaliczba_lb.Visible = true;
                tura_lb.Visible = true;
                hit_lb.Visible = false;
                reloadStats();
                TUR_NUMBER = 1;
            }
            if (type == 0)
            {
                at_bt.Visible = false;
                atackw_pc.Visible = false;
                atackp_pc.Visible = false;
                mat_bt.Visible = false;
                player_pic.Visible = false;
                wolf_pic.Visible = false;
                hit_lb.Visible = false;
                playerinfo_lb.Visible = false;
                wolfinfo_lb.Visible = false;
                turaliczba_lb.Visible = false;
                tura_lb.Visible = false;
                hit_lb.Visible = false;
                player = null;
                wolf = null;
                new_bt.Enabled = true;
            }
            
            FILE_PATH = Path.GetFullPath(Path.Combine(Application.ExecutablePath, "..\\", "..\\", "..\\", "save\\"));
        }
        private void reloadStats()
        {
            if (wolf != null)
                wolfinfo_lb.Invoke(new Action(delegate () { wolfinfo_lb.Text = "Health " + wolf.getHealthPoints() + "\nLevel " + wolf.getWolflevel() + "\nStrong " + wolf.getWolfstrong(); }));
            if (player != null)
                wolfinfo_lb.Invoke(new Action(delegate () { playerinfo_lb.Text = "Name " + player.getPlayerName() + "\nHealth " + player.getHealthPoints() + "\nLevel " + 
                + player.getPlayerLevel() + "\nStrong " + player.getPlayerStrong() + "\nDexterity " + player.getPlayerDexterity() + "\nIntelligence " + player.getPlayerIntelligence(); }));
        }
        private void configurateStream(ref SaveFileDialog obj)
        {
            obj.InitialDirectory = FILE_PATH;
            obj.Filter = FILE_FILTER;
            obj.FilterIndex = FILTER_INDEX;
            obj.RestoreDirectory = true;
        }
        private void configurateStream(ref OpenFileDialog obj)
        {
            obj.InitialDirectory = FILE_PATH;
            obj.Filter = FILE_FILTER;
            obj.FilterIndex = FILTER_INDEX;
            obj.RestoreDirectory = true;
        }
        private void saveObject(Player obje)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            configurateStream(ref sfd);
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                FILE_PATH = sfd.FileName;
                string objstr = JsonConvert.SerializeObject(obje, Formatting.Indented);
                File.WriteAllText(FILE_PATH, objstr);
            }
        }
        private Player loadObject()
        {
            Player p;
            OpenFileDialog ofd = new OpenFileDialog();
            configurateStream(ref ofd);
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FILE_PATH = ofd.FileName;
                string obsj = File.ReadAllText(FILE_PATH);
                p = JsonConvert.DeserializeObject<Player>(obsj);
            }
            else
                p = null;
            return p;
        }
        private void SetTimeout(Action ac, int millis, Action ac2 = null, Action ac3 = null)
        {
            var cts = new CancellationTokenSource();
            var ct = cts.Token;
            _ = Task.Run(() =>
            {
                Thread.Sleep(millis);
                if (!ct.IsCancellationRequested)
                {
                    ac();
                    if (ac2 != null)
                        ac2();
                    if (ac3 != null)
                        ac3();
                }
            }, ct);
        }
        private void gameOver()
        {
            resetValue(0);
            hit_lb.Visible = true;
            hit_lb.Text = "GAME OVER!";
            hit_lb.ForeColor = Color.Red;
            turaliczba_lb.Visible = true;
            tura_lb.Visible = true;
            save_bt.Enabled = false;

        }
        private void gameStart()
        {
            player = null;
            wolf = null;
            if (player == null)
                player = new Player("Anonim");
            if (wolf == null)
                wolf = new Wolf(1, 25, 3);
            resetValue(1);
            new_bt.Enabled = false;
            at_bt.Enabled = true;
            mat_bt.Enabled = true;
            save_bt.Enabled = true;
        }

        private void save_bt_Click(object sender, EventArgs e)
        {
            Player od = player;
            if (player != null)
            {
                saveObject(od);
                resetValue(0);
            }
        }
        private void load_bt_Click(object sender, EventArgs e)
        {
            Player od = loadObject();
            if (od != null)
            {
                player = od;
                resetValue(1);
                new_bt.Enabled = false;
                at_bt.Enabled = true;
                mat_bt.Enabled = true;
            }
        }
        private void new_bt_Click(object sender, EventArgs e)
        {
            gameStart();
        }
        private void at_bt_Click(object sender, EventArgs e)
        {
            if (player != null && wolf != null)
            {
                player.attack(ref wolf);
                resetValue(1);
                hit_lb.Visible = true;
                showPlayerAttackElements();
                if (wolf.getHealthPoints() <= 0)
                {
                    TUR_NUMBER = 1;
                    player.setPlayerExpPoint(player.getPlayerExpPoint() + (50 * wolf.getWolflevel()));
                    player.checkLevelUp();
                    reloadStats();
                    wolf = null;
                    createNewWolf();
                    resetValue(1);
                    at_bt.Enabled = true;
                    mat_bt.Enabled = true;
                }
                else
                {
                    wolf.attackWolf(ref player);
                    TUR_NUMBER++;
                    if (player.getHealthPoints() <= 0)
                    {
                        gameOver();
                    }
                    else
                        SetTimeout(showWolfAttackElements, 2000, reloadStats);
                }
            }
        }
        private void mat_bt_Click(object sender, EventArgs e)
        {
            if (player != null && wolf != null)
            {
                player.magicAtack(ref wolf);
                resetValue(1);
                hit_lb.Visible = true;
                showPlayerAttackElements();
                if (wolf.getHealthPoints() <= 0)
                {
                    TUR_NUMBER = 1;
                    player.setPlayerExpPoint(player.getPlayerExpPoint() + (50 * wolf.getWolflevel()));
                    player.checkLevelUp();
                    reloadStats();
                    wolf = null;
                    createNewWolf();
                    resetValue(1);
                    at_bt.Enabled = true;
                    mat_bt.Enabled = true;
                }
                else
                {
                    wolf.attackWolf(ref player);
                    TUR_NUMBER++;
                    if (player.getHealthPoints() <= 0)
                    {
                        gameOver();
                    }
                    else 
                        SetTimeout(showWolfAttackElements, 2000, reloadStats);
                }
            }
        }
    }
}
