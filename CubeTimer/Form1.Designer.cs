namespace CubeTimer
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.L_time = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.scramble = new System.Windows.Forms.Label();
            this.B_change = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.B_show = new System.Windows.Forms.Button();
            this.History = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.AverageLabel = new System.Windows.Forms.Label();
            this.BestLabel = new System.Windows.Forms.Label();
            this.WorstLabel = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.檔案ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newDropDown = new System.Windows.Forms.ToolStripMenuItem();
            this.showHideToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showHideToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.登入登出ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logInToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.staticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.網頁版ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cstimernetToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mingZesYouTubeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.客製文字ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foreColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.backColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.environmentColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonColorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.foreColorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.backColorToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonFontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instructionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instructionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.textToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.videoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.videoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.creditsToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // L_time
            // 
            this.L_time.AutoSize = true;
            this.L_time.Font = new System.Drawing.Font("Segoe UI", 108F);
            this.L_time.Location = new System.Drawing.Point(221, 143);
            this.L_time.Name = "L_time";
            this.L_time.Size = new System.Drawing.Size(430, 239);
            this.L_time.TabIndex = 0;
            this.L_time.Text = "0.00";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // scramble
            // 
            this.scramble.AutoSize = true;
            this.scramble.Font = new System.Drawing.Font("Segoe UI", 25F);
            this.scramble.Location = new System.Drawing.Point(198, 80);
            this.scramble.Name = "scramble";
            this.scramble.Size = new System.Drawing.Size(0, 57);
            this.scramble.TabIndex = 1;
            this.scramble.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // B_change
            // 
            this.B_change.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.B_change.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.B_change.Location = new System.Drawing.Point(41, 529);
            this.B_change.Name = "B_change";
            this.B_change.Size = new System.Drawing.Size(124, 100);
            this.B_change.TabIndex = 3;
            this.B_change.TabStop = false;
            this.B_change.Text = "new";
            this.B_change.UseVisualStyleBackColor = false;
            this.B_change.Click += new System.EventHandler(this.B_change_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 697);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 32);
            this.label1.TabIndex = 4;
            // 
            // B_show
            // 
            this.B_show.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.B_show.Font = new System.Drawing.Font("Segoe UI", 18F);
            this.B_show.Location = new System.Drawing.Point(171, 529);
            this.B_show.Name = "B_show";
            this.B_show.Size = new System.Drawing.Size(178, 100);
            this.B_show.TabIndex = 7;
            this.B_show.TabStop = false;
            this.B_show.Text = "Hide";
            this.B_show.UseVisualStyleBackColor = false;
            this.B_show.Click += new System.EventHandler(this.B_show_Click);
            // 
            // History
            // 
            this.History.AutoSize = true;
            this.History.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.History.Location = new System.Drawing.Point(65, 122);
            this.History.Name = "History";
            this.History.Size = new System.Drawing.Size(0, 30);
            this.History.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 30);
            this.label2.TabIndex = 0;
            this.label2.Text = "Average : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 30);
            this.label3.TabIndex = 1;
            this.label3.Text = "Best : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 30);
            this.label5.TabIndex = 3;
            this.label5.Text = "Worst : ";
            // 
            // AverageLabel
            // 
            this.AverageLabel.AutoSize = true;
            this.AverageLabel.Location = new System.Drawing.Point(152, 70);
            this.AverageLabel.Name = "AverageLabel";
            this.AverageLabel.Size = new System.Drawing.Size(0, 30);
            this.AverageLabel.TabIndex = 5;
            this.AverageLabel.Click += new System.EventHandler(this.label7_Click);
            // 
            // BestLabel
            // 
            this.BestLabel.AutoSize = true;
            this.BestLabel.Location = new System.Drawing.Point(152, 142);
            this.BestLabel.Name = "BestLabel";
            this.BestLabel.Size = new System.Drawing.Size(0, 30);
            this.BestLabel.TabIndex = 6;
            // 
            // WorstLabel
            // 
            this.WorstLabel.AutoSize = true;
            this.WorstLabel.Location = new System.Drawing.Point(152, 222);
            this.WorstLabel.Name = "WorstLabel";
            this.WorstLabel.Size = new System.Drawing.Size(0, 30);
            this.WorstLabel.TabIndex = 8;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.WorstLabel);
            this.groupBox1.Controls.Add(this.BestLabel);
            this.groupBox1.Controls.Add(this.AverageLabel);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 13F);
            this.groupBox1.Location = new System.Drawing.Point(985, 238);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(288, 448);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Statistics";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Microsoft JhengHei UI", 15F);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(50, 50);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.檔案ToolStripMenuItem,
            this.showHideToolStripMenuItem,
            this.登入登出ToolStripMenuItem,
            this.statisticsToolStripMenuItem,
            this.網頁版ToolStripMenuItem,
            this.客製文字ToolStripMenuItem,
            this.instructionToolStripMenuItem,
            this.creditsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1328, 40);
            this.menuStrip1.TabIndex = 10;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 檔案ToolStripMenuItem
            // 
            this.檔案ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newDropDown});
            this.檔案ToolStripMenuItem.Name = "檔案ToolStripMenuItem";
            this.檔案ToolStripMenuItem.Size = new System.Drawing.Size(80, 36);
            this.檔案ToolStripMenuItem.Text = "New";
            this.檔案ToolStripMenuItem.Click += new System.EventHandler(this.檔案ToolStripMenuItem_Click);
            // 
            // newDropDown
            // 
            this.newDropDown.Name = "newDropDown";
            this.newDropDown.ShortcutKeyDisplayString = "";
            this.newDropDown.Size = new System.Drawing.Size(149, 36);
            this.newDropDown.Text = "New";
            this.newDropDown.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // showHideToolStripMenuItem
            // 
            this.showHideToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showHideToolStripMenuItem1});
            this.showHideToolStripMenuItem.Name = "showHideToolStripMenuItem";
            this.showHideToolStripMenuItem.Size = new System.Drawing.Size(156, 36);
            this.showHideToolStripMenuItem.Text = "Show/Hide";
            // 
            // showHideToolStripMenuItem1
            // 
            this.showHideToolStripMenuItem1.Name = "showHideToolStripMenuItem1";
            this.showHideToolStripMenuItem1.Size = new System.Drawing.Size(225, 36);
            this.showHideToolStripMenuItem1.Text = "Show/Hide";
            this.showHideToolStripMenuItem1.Click += new System.EventHandler(this.showHideToolStripMenuItem1_Click);
            // 
            // 登入登出ToolStripMenuItem
            // 
            this.登入登出ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logInToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.登入登出ToolStripMenuItem.Name = "登入登出ToolStripMenuItem";
            this.登入登出ToolStripMenuItem.Size = new System.Drawing.Size(80, 36);
            this.登入登出ToolStripMenuItem.Text = "User";
            // 
            // logInToolStripMenuItem
            // 
            this.logInToolStripMenuItem.Name = "logInToolStripMenuItem";
            this.logInToolStripMenuItem.Size = new System.Drawing.Size(216, 36);
            this.logInToolStripMenuItem.Text = "Log In";
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(216, 36);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.B_logout_Click);
            // 
            // statisticsToolStripMenuItem
            // 
            this.statisticsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.staticsToolStripMenuItem,
            this.historyToolStripMenuItem});
            this.statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
            this.statisticsToolStripMenuItem.Size = new System.Drawing.Size(128, 36);
            this.statisticsToolStripMenuItem.Text = "Statistics";
            // 
            // staticsToolStripMenuItem
            // 
            this.staticsToolStripMenuItem.Name = "staticsToolStripMenuItem";
            this.staticsToolStripMenuItem.Size = new System.Drawing.Size(179, 36);
            this.staticsToolStripMenuItem.Text = "Statics";
            // 
            // historyToolStripMenuItem
            // 
            this.historyToolStripMenuItem.Name = "historyToolStripMenuItem";
            this.historyToolStripMenuItem.Size = new System.Drawing.Size(179, 36);
            this.historyToolStripMenuItem.Text = "History";
            // 
            // 網頁版ToolStripMenuItem
            // 
            this.網頁版ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cstimernetToolStripMenuItem,
            this.mingZesYouTubeToolStripMenuItem});
            this.網頁版ToolStripMenuItem.Name = "網頁版ToolStripMenuItem";
            this.網頁版ToolStripMenuItem.Size = new System.Drawing.Size(133, 36);
            this.網頁版ToolStripMenuItem.Text = "Websites";
            // 
            // cstimernetToolStripMenuItem
            // 
            this.cstimernetToolStripMenuItem.Name = "cstimernetToolStripMenuItem";
            this.cstimernetToolStripMenuItem.Size = new System.Drawing.Size(325, 36);
            this.cstimernetToolStripMenuItem.Text = "cstimer.net";
            this.cstimernetToolStripMenuItem.Click += new System.EventHandler(this.cstimernetToolStripMenuItem_Click);
            // 
            // mingZesYouTubeToolStripMenuItem
            // 
            this.mingZesYouTubeToolStripMenuItem.Name = "mingZesYouTubeToolStripMenuItem";
            this.mingZesYouTubeToolStripMenuItem.Size = new System.Drawing.Size(325, 36);
            this.mingZesYouTubeToolStripMenuItem.Text = "Ming-Ze\'s YouTube";
            this.mingZesYouTubeToolStripMenuItem.Click += new System.EventHandler(this.mingZesYouTubeToolStripMenuItem_Click);
            // 
            // 客製文字ToolStripMenuItem
            // 
            this.客製文字ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeColorToolStripMenuItem,
            this.changeFontToolStripMenuItem,
            this.buttonColorToolStripMenuItem,
            this.buttonFontToolStripMenuItem});
            this.客製文字ToolStripMenuItem.Name = "客製文字ToolStripMenuItem";
            this.客製文字ToolStripMenuItem.Size = new System.Drawing.Size(150, 36);
            this.客製文字ToolStripMenuItem.Text = "Customize";
            // 
            // changeColorToolStripMenuItem
            // 
            this.changeColorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.foreColorToolStripMenuItem,
            this.backColorToolStripMenuItem,
            this.environmentColorToolStripMenuItem});
            this.changeColorToolStripMenuItem.Name = "changeColorToolStripMenuItem";
            this.changeColorToolStripMenuItem.Size = new System.Drawing.Size(245, 36);
            this.changeColorToolStripMenuItem.Text = "Text Color";
            this.changeColorToolStripMenuItem.Click += new System.EventHandler(this.changeColorToolStripMenuItem_Click);
            // 
            // foreColorToolStripMenuItem
            // 
            this.foreColorToolStripMenuItem.Name = "foreColorToolStripMenuItem";
            this.foreColorToolStripMenuItem.Size = new System.Drawing.Size(315, 36);
            this.foreColorToolStripMenuItem.Text = "Fore Color";
            this.foreColorToolStripMenuItem.Click += new System.EventHandler(this.foreColorToolStripMenuItem_Click);
            // 
            // backColorToolStripMenuItem
            // 
            this.backColorToolStripMenuItem.Name = "backColorToolStripMenuItem";
            this.backColorToolStripMenuItem.Size = new System.Drawing.Size(315, 36);
            this.backColorToolStripMenuItem.Text = "Back Color";
            this.backColorToolStripMenuItem.Click += new System.EventHandler(this.backColorToolStripMenuItem_Click);
            // 
            // environmentColorToolStripMenuItem
            // 
            this.environmentColorToolStripMenuItem.Name = "environmentColorToolStripMenuItem";
            this.environmentColorToolStripMenuItem.Size = new System.Drawing.Size(315, 36);
            this.environmentColorToolStripMenuItem.Text = "Environment Color";
            this.environmentColorToolStripMenuItem.Click += new System.EventHandler(this.environmentColorToolStripMenuItem_Click);
            // 
            // changeFontToolStripMenuItem
            // 
            this.changeFontToolStripMenuItem.Name = "changeFontToolStripMenuItem";
            this.changeFontToolStripMenuItem.Size = new System.Drawing.Size(245, 36);
            this.changeFontToolStripMenuItem.Text = "Text Font";
            this.changeFontToolStripMenuItem.Click += new System.EventHandler(this.changeFontToolStripMenuItem_Click);
            // 
            // buttonColorToolStripMenuItem
            // 
            this.buttonColorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.foreColorToolStripMenuItem1,
            this.backColorToolStripMenuItem1});
            this.buttonColorToolStripMenuItem.Name = "buttonColorToolStripMenuItem";
            this.buttonColorToolStripMenuItem.Size = new System.Drawing.Size(245, 36);
            this.buttonColorToolStripMenuItem.Text = "Button Color";
            // 
            // foreColorToolStripMenuItem1
            // 
            this.foreColorToolStripMenuItem1.Name = "foreColorToolStripMenuItem1";
            this.foreColorToolStripMenuItem1.Size = new System.Drawing.Size(220, 36);
            this.foreColorToolStripMenuItem1.Text = "Fore Color";
            this.foreColorToolStripMenuItem1.Click += new System.EventHandler(this.foreColorToolStripMenuItem1_Click);
            // 
            // backColorToolStripMenuItem1
            // 
            this.backColorToolStripMenuItem1.Name = "backColorToolStripMenuItem1";
            this.backColorToolStripMenuItem1.Size = new System.Drawing.Size(220, 36);
            this.backColorToolStripMenuItem1.Text = "Back Color";
            this.backColorToolStripMenuItem1.Click += new System.EventHandler(this.backColorToolStripMenuItem1_Click);
            // 
            // buttonFontToolStripMenuItem
            // 
            this.buttonFontToolStripMenuItem.Name = "buttonFontToolStripMenuItem";
            this.buttonFontToolStripMenuItem.Size = new System.Drawing.Size(245, 36);
            this.buttonFontToolStripMenuItem.Text = "Button Font";
            this.buttonFontToolStripMenuItem.Click += new System.EventHandler(this.buttonFontToolStripMenuItem_Click);
            // 
            // instructionToolStripMenuItem
            // 
            this.instructionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.instructionToolStripMenuItem1,
            this.videoToolStripMenuItem});
            this.instructionToolStripMenuItem.Name = "instructionToolStripMenuItem";
            this.instructionToolStripMenuItem.Size = new System.Drawing.Size(162, 36);
            this.instructionToolStripMenuItem.Text = "Instructions";
            // 
            // instructionToolStripMenuItem1
            // 
            this.instructionToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.textToolStripMenuItem,
            this.videoToolStripMenuItem1});
            this.instructionToolStripMenuItem1.Name = "instructionToolStripMenuItem1";
            this.instructionToolStripMenuItem1.Size = new System.Drawing.Size(311, 36);
            this.instructionToolStripMenuItem1.Text = "Application";
            this.instructionToolStripMenuItem1.Click += new System.EventHandler(this.instructionToolStripMenuItem1_Click);
            // 
            // textToolStripMenuItem
            // 
            this.textToolStripMenuItem.Name = "textToolStripMenuItem";
            this.textToolStripMenuItem.Size = new System.Drawing.Size(165, 36);
            this.textToolStripMenuItem.Text = "Text";
            this.textToolStripMenuItem.Click += new System.EventHandler(this.textToolStripMenuItem_Click);
            // 
            // videoToolStripMenuItem1
            // 
            this.videoToolStripMenuItem1.Name = "videoToolStripMenuItem1";
            this.videoToolStripMenuItem1.Size = new System.Drawing.Size(165, 36);
            this.videoToolStripMenuItem1.Text = "Video";
            this.videoToolStripMenuItem1.Click += new System.EventHandler(this.videoToolStripMenuItem1_Click);
            // 
            // videoToolStripMenuItem
            // 
            this.videoToolStripMenuItem.Name = "videoToolStripMenuItem";
            this.videoToolStripMenuItem.Size = new System.Drawing.Size(311, 36);
            this.videoToolStripMenuItem.Text = "Competition Rules";
            this.videoToolStripMenuItem.Click += new System.EventHandler(this.videoToolStripMenuItem_Click);
            // 
            // creditsToolStripMenuItem
            // 
            this.creditsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.creditsToolStripMenuItem1});
            this.creditsToolStripMenuItem.Name = "creditsToolStripMenuItem";
            this.creditsToolStripMenuItem.Size = new System.Drawing.Size(109, 36);
            this.creditsToolStripMenuItem.Text = "Credits";
            // 
            // creditsToolStripMenuItem1
            // 
            this.creditsToolStripMenuItem1.Name = "creditsToolStripMenuItem1";
            this.creditsToolStripMenuItem1.Size = new System.Drawing.Size(178, 36);
            this.creditsToolStripMenuItem1.Text = "Credits";
            this.creditsToolStripMenuItem1.Click += new System.EventHandler(this.creditsToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkGray;
            this.ClientSize = new System.Drawing.Size(1328, 760);
            this.Controls.Add(this.History);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.B_show);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.B_change);
            this.Controls.Add(this.scramble);
            this.Controls.Add(this.L_time);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CubeTimer";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label L_time;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label scramble;
        private System.Windows.Forms.Button B_change;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button B_show;
        private System.Windows.Forms.Label History;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label AverageLabel;
        private System.Windows.Forms.Label BestLabel;
        private System.Windows.Forms.Label WorstLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 檔案ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newDropDown;
        private System.Windows.Forms.ToolStripMenuItem 登入登出ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 網頁版ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cstimernetToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 客製文字ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logInToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instructionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instructionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem mingZesYouTubeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem videoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem staticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showHideToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem showHideToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem changeColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeFontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem foreColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem backColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem environmentColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem buttonColorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem foreColorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem backColorToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem buttonFontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem creditsToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem textToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem videoToolStripMenuItem1;
    }
}

