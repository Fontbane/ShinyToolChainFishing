namespace ShinyToolChainFishing
{
    partial class ChainFishingTracker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChainFishingTracker));
            this.hookBtn = new System.Windows.Forms.Button();
            this.toggleShinyCharm = new System.Windows.Forms.CheckBox();
            this.chainLengthText = new System.Windows.Forms.Label();
            this.numRollsText = new System.Windows.Forms.Label();
            this.oddsText = new System.Windows.Forms.Label();
            this.overUnderOddsText = new System.Windows.Forms.Label();
            this.resetChainBtn = new System.Windows.Forms.Button();
            this.gulpFish = new System.Windows.Forms.PictureBox();
            this.gulpHook = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.gulpFish)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gulpHook)).BeginInit();
            this.SuspendLayout();
            // 
            // hookBtn
            // 
            this.hookBtn.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hookBtn.Location = new System.Drawing.Point(322, 67);
            this.hookBtn.Name = "hookBtn";
            this.hookBtn.Size = new System.Drawing.Size(67, 50);
            this.hookBtn.TabIndex = 0;
            this.hookBtn.Text = "Hook!";
            this.hookBtn.UseVisualStyleBackColor = true;
            this.hookBtn.Click += new System.EventHandler(this.HookBtn_Click);
            // 
            // toggleShinyCharm
            // 
            this.toggleShinyCharm.AutoSize = true;
            this.toggleShinyCharm.BackColor = System.Drawing.Color.Transparent;
            this.toggleShinyCharm.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.toggleShinyCharm.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleShinyCharm.Location = new System.Drawing.Point(305, 383);
            this.toggleShinyCharm.Name = "toggleShinyCharm";
            this.toggleShinyCharm.Size = new System.Drawing.Size(118, 46);
            this.toggleShinyCharm.TabIndex = 1;
            this.toggleShinyCharm.Text = "Shiny Charm?";
            this.toggleShinyCharm.UseVisualStyleBackColor = false;
            this.toggleShinyCharm.CheckedChanged += new System.EventHandler(this.ToggleShinyCharm_CheckedChanged);
            // 
            // chainLengthText
            // 
            this.chainLengthText.AutoSize = true;
            this.chainLengthText.BackColor = System.Drawing.Color.Transparent;
            this.chainLengthText.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chainLengthText.Location = new System.Drawing.Point(231, 155);
            this.chainLengthText.Name = "chainLengthText";
            this.chainLengthText.Size = new System.Drawing.Size(291, 21);
            this.chainLengthText.TabIndex = 2;
            this.chainLengthText.Text = "You\'ve hooked 0 PKMN in this chain.";
            // 
            // numRollsText
            // 
            this.numRollsText.AutoSize = true;
            this.numRollsText.BackColor = System.Drawing.Color.Transparent;
            this.numRollsText.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numRollsText.Location = new System.Drawing.Point(268, 199);
            this.numRollsText.Name = "numRollsText";
            this.numRollsText.Size = new System.Drawing.Size(217, 21);
            this.numRollsText.TabIndex = 3;
            this.numRollsText.Text = "This gives you 0 shiny rolls.";
            // 
            // oddsText
            // 
            this.oddsText.AutoSize = true;
            this.oddsText.BackColor = System.Drawing.Color.Transparent;
            this.oddsText.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oddsText.Location = new System.Drawing.Point(251, 242);
            this.oddsText.Name = "oddsText";
            this.oddsText.Size = new System.Drawing.Size(251, 21);
            this.oddsText.TabIndex = 4;
            this.oddsText.Text = "Your shiny odds are roughly 0%";
            // 
            // overUnderOddsText
            // 
            this.overUnderOddsText.AutoSize = true;
            this.overUnderOddsText.BackColor = System.Drawing.Color.Transparent;
            this.overUnderOddsText.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.overUnderOddsText.Location = new System.Drawing.Point(283, 294);
            this.overUnderOddsText.Name = "overUnderOddsText";
            this.overUnderOddsText.Size = new System.Drawing.Size(187, 21);
            this.overUnderOddsText.TabIndex = 5;
            this.overUnderOddsText.Text = "You\'re still under odds!";
            // 
            // resetChainBtn
            // 
            this.resetChainBtn.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetChainBtn.Location = new System.Drawing.Point(557, 383);
            this.resetChainBtn.Name = "resetChainBtn";
            this.resetChainBtn.Size = new System.Drawing.Size(102, 45);
            this.resetChainBtn.TabIndex = 6;
            this.resetChainBtn.Text = "Reset\nChain";
            this.resetChainBtn.UseVisualStyleBackColor = true;
            this.resetChainBtn.Click += new System.EventHandler(this.ResetChainBtn_Click);
            // 
            // gulpFish
            // 
            this.gulpFish.BackColor = System.Drawing.Color.Transparent;
            this.gulpFish.Image = ((System.Drawing.Image)(resources.GetObject("gulpFish.Image")));
            this.gulpFish.Location = new System.Drawing.Point(12, 37);
            this.gulpFish.Name = "gulpFish";
            this.gulpFish.Size = new System.Drawing.Size(80, 80);
            this.gulpFish.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.gulpFish.TabIndex = 7;
            this.gulpFish.TabStop = false;
            // 
            // gulpHook
            // 
            this.gulpHook.BackColor = System.Drawing.Color.Transparent;
            this.gulpHook.Image = ((System.Drawing.Image)(resources.GetObject("gulpHook.Image")));
            this.gulpHook.Location = new System.Drawing.Point(12, 37);
            this.gulpHook.Name = "gulpHook";
            this.gulpHook.Size = new System.Drawing.Size(80, 80);
            this.gulpHook.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.gulpHook.TabIndex = 8;
            this.gulpHook.TabStop = false;
            // 
            // ChainFishingTracker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(711, 450);
            this.Controls.Add(this.gulpFish);
            this.Controls.Add(this.gulpHook);
            this.Controls.Add(this.resetChainBtn);
            this.Controls.Add(this.overUnderOddsText);
            this.Controls.Add(this.oddsText);
            this.Controls.Add(this.numRollsText);
            this.Controls.Add(this.chainLengthText);
            this.Controls.Add(this.toggleShinyCharm);
            this.Controls.Add(this.hookBtn);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Microsoft New Tai Lue", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "ChainFishingTracker";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Text = "Chain Fishing Tracker";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gulpFish)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gulpHook)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button hookBtn;
        private System.Windows.Forms.CheckBox toggleShinyCharm;
        private System.Windows.Forms.Label chainLengthText;
        private System.Windows.Forms.Label numRollsText;
        private System.Windows.Forms.Label oddsText;
        private System.Windows.Forms.Label overUnderOddsText;
        private System.Windows.Forms.Button resetChainBtn;
        private System.Windows.Forms.PictureBox gulpFish;
        private System.Windows.Forms.PictureBox gulpHook;
    }
}

