using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShinyToolChainFishing
{
    public partial class ChainFishingTracker : Form
    {
        public int chainLen = 0;
        public int rolls = 1;
        public int shinyCharmRolls = 0;
        public int totalRolls = 0;
        public ChainFishingTracker()
        {
            InitializeComponent();
            chainLen = 0;
            rolls = 1;
            shinyCharmRolls = 0;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateRolls();
        }

        private void HookBtn_Click(object sender, EventArgs e)
        {
            chainLen++;
            totalRolls += rolls;
            UpdateChainText();
            UpdateRolls();
            GulpFish_FlashHook();
        }

        async void GulpFish_FlashHook()
        {
            this.gulpFish.Hide();
            await WaitFrames(100);
            this.gulpFish.Show();
        }

        async Task WaitFrames(int frames)
        {
            await Task.Delay(frames);
        }

        private void ToggleShinyCharm_CheckedChanged(object sender, EventArgs e)
        {
            if (toggleShinyCharm.Checked == true)
            {
                shinyCharmRolls = 2;
            }
            else
            {
                shinyCharmRolls = 0;
            }
            UpdateRolls();
        }

        private void ResetChainBtn_Click(object sender, EventArgs e)
        {
            chainLen = 0;
            totalRolls = 0;
            UpdateChainText();
            UpdateRolls();
        }

        private void UpdateRolls()
        {
            rolls = Math.Min(1 + chainLen * 2, 41) + shinyCharmRolls;
            UpdateRollsText();
        }

        private void UpdateChainText()
        {
            chainLengthText.Text = "You've hooked " + chainLen.ToString() + " PKMN in this chain.";
        }

        private void UpdateRollsText()
        {
            float odds = rolls * 100 / 4096f;
            numRollsText.Text = "This gives you " + rolls + " shiny rolls on your next hook.";
            oddsText.Text = "Your shiny odds are roughly " + odds.ToString()+"%";
            if (totalRolls >= 4096)
            {
                overUnderOddsText.Text = "You're over odds! Tough luck!";
            }
            else
            {
                overUnderOddsText.Text = "You're still under odds!";
            }
        }
    }
}
