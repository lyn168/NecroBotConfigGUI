namespace NecroBot_Config_GUI
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
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.login = new System.Windows.Forms.GroupBox();
            this.google_ptc = new System.Windows.Forms.ComboBox();
            this.pwd = new System.Windows.Forms.Label();
            this.username = new System.Windows.Forms.TextBox();
            this.account_type = new System.Windows.Forms.Label();
            this.passwd = new System.Windows.Forms.TextBox();
            this.user = new System.Windows.Forms.Label();
            this.lang = new System.Windows.Forms.TextBox();
            this.update_panel = new System.Windows.Forms.Panel();
            this.update_close = new System.Windows.Forms.RadioButton();
            this.update_open = new System.Windows.Forms.RadioButton();
            this.auto_update = new System.Windows.Forms.Label();
            this.language = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.reals = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.speedvalue = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.va_close = new System.Windows.Forms.RadioButton();
            this.va_open = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.location = new System.Windows.Forms.GroupBox();
            this.Lo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.La = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.sniper_openpanel = new System.Windows.Forms.Panel();
            this.ms = new System.Windows.Forms.Label();
            this.sniper_delay = new System.Windows.Forms.TextBox();
            this.sniper_delay_text = new System.Windows.Forms.Label();
            this.sniper_server_list = new System.Windows.Forms.CheckedListBox();
            this.info = new System.Windows.Forms.Label();
            this.sniper_panel = new System.Windows.Forms.Panel();
            this.sniper_close = new System.Windows.Forms.RadioButton();
            this.sniper_open = new System.Windows.Forms.RadioButton();
            this.sniper_mode = new System.Windows.Forms.Label();
            this.save = new System.Windows.Forms.Button();
            this.exit = new System.Windows.Forms.Button();
            this.donate = new System.Windows.Forms.PictureBox();
            this.version = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.login.SuspendLayout();
            this.update_panel.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.reals.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speedvalue)).BeginInit();
            this.panel1.SuspendLayout();
            this.location.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.sniper_openpanel.SuspendLayout();
            this.sniper_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.donate)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(12, 9);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(309, 295);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.login);
            this.tabPage1.Controls.Add(this.lang);
            this.tabPage1.Controls.Add(this.update_panel);
            this.tabPage1.Controls.Add(this.auto_update);
            this.tabPage1.Controls.Add(this.language);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(301, 269);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "基本設定";
            // 
            // login
            // 
            this.login.Controls.Add(this.google_ptc);
            this.login.Controls.Add(this.pwd);
            this.login.Controls.Add(this.username);
            this.login.Controls.Add(this.account_type);
            this.login.Controls.Add(this.passwd);
            this.login.Controls.Add(this.user);
            this.login.Location = new System.Drawing.Point(6, 6);
            this.login.Name = "login";
            this.login.Size = new System.Drawing.Size(260, 148);
            this.login.TabIndex = 11;
            this.login.TabStop = false;
            this.login.Text = "登入";
            // 
            // google_ptc
            // 
            this.google_ptc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.google_ptc.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.google_ptc.FormattingEnabled = true;
            this.google_ptc.Items.AddRange(new object[] {
            "google",
            "ptc"});
            this.google_ptc.Location = new System.Drawing.Point(91, 26);
            this.google_ptc.Margin = new System.Windows.Forms.Padding(8);
            this.google_ptc.Name = "google_ptc";
            this.google_ptc.Size = new System.Drawing.Size(149, 25);
            this.google_ptc.TabIndex = 4;
            // 
            // pwd
            // 
            this.pwd.AutoSize = true;
            this.pwd.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.pwd.Location = new System.Drawing.Point(38, 111);
            this.pwd.Name = "pwd";
            this.pwd.Size = new System.Drawing.Size(47, 17);
            this.pwd.TabIndex = 1;
            this.pwd.Text = "密碼：";
            // 
            // username
            // 
            this.username.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.username.Location = new System.Drawing.Point(91, 67);
            this.username.Margin = new System.Windows.Forms.Padding(8);
            this.username.Name = "username";
            this.username.Size = new System.Drawing.Size(149, 25);
            this.username.TabIndex = 5;
            // 
            // account_type
            // 
            this.account_type.AutoSize = true;
            this.account_type.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.account_type.Location = new System.Drawing.Point(12, 29);
            this.account_type.Margin = new System.Windows.Forms.Padding(3);
            this.account_type.Name = "account_type";
            this.account_type.Size = new System.Drawing.Size(73, 17);
            this.account_type.TabIndex = 3;
            this.account_type.Text = "帳號類型：";
            // 
            // passwd
            // 
            this.passwd.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.passwd.Location = new System.Drawing.Point(91, 108);
            this.passwd.Margin = new System.Windows.Forms.Padding(8);
            this.passwd.Name = "passwd";
            this.passwd.PasswordChar = '*';
            this.passwd.Size = new System.Drawing.Size(149, 25);
            this.passwd.TabIndex = 6;
            // 
            // user
            // 
            this.user.AutoSize = true;
            this.user.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.user.Location = new System.Drawing.Point(38, 70);
            this.user.Name = "user";
            this.user.Size = new System.Drawing.Size(47, 17);
            this.user.TabIndex = 0;
            this.user.Text = "帳號：";
            // 
            // lang
            // 
            this.lang.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lang.Location = new System.Drawing.Point(97, 165);
            this.lang.Margin = new System.Windows.Forms.Padding(8);
            this.lang.Name = "lang";
            this.lang.Size = new System.Drawing.Size(149, 25);
            this.lang.TabIndex = 10;
            // 
            // update_panel
            // 
            this.update_panel.Controls.Add(this.update_close);
            this.update_panel.Controls.Add(this.update_open);
            this.update_panel.Location = new System.Drawing.Point(97, 201);
            this.update_panel.Name = "update_panel";
            this.update_panel.Size = new System.Drawing.Size(104, 24);
            this.update_panel.TabIndex = 9;
            // 
            // update_close
            // 
            this.update_close.AutoSize = true;
            this.update_close.Location = new System.Drawing.Point(56, 4);
            this.update_close.Name = "update_close";
            this.update_close.Size = new System.Drawing.Size(47, 16);
            this.update_close.TabIndex = 1;
            this.update_close.Text = "關閉";
            this.update_close.UseVisualStyleBackColor = true;
            // 
            // update_open
            // 
            this.update_open.AutoSize = true;
            this.update_open.Location = new System.Drawing.Point(3, 4);
            this.update_open.Name = "update_open";
            this.update_open.Size = new System.Drawing.Size(47, 16);
            this.update_open.TabIndex = 0;
            this.update_open.Text = "開啟";
            this.update_open.UseVisualStyleBackColor = true;
            // 
            // auto_update
            // 
            this.auto_update.AutoSize = true;
            this.auto_update.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.auto_update.Location = new System.Drawing.Point(18, 204);
            this.auto_update.Name = "auto_update";
            this.auto_update.Size = new System.Drawing.Size(73, 17);
            this.auto_update.TabIndex = 8;
            this.auto_update.Text = "自動更新：";
            // 
            // language
            // 
            this.language.AutoSize = true;
            this.language.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.language.Location = new System.Drawing.Point(44, 168);
            this.language.Name = "language";
            this.language.Size = new System.Drawing.Size(47, 17);
            this.language.TabIndex = 2;
            this.language.Text = "語言：";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.reals);
            this.tabPage3.Controls.Add(this.location);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(301, 269);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "座標設定";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // reals
            // 
            this.reals.Controls.Add(this.label5);
            this.reals.Controls.Add(this.speedvalue);
            this.reals.Controls.Add(this.label4);
            this.reals.Controls.Add(this.panel1);
            this.reals.Controls.Add(this.label3);
            this.reals.Location = new System.Drawing.Point(17, 129);
            this.reals.Name = "reals";
            this.reals.Size = new System.Drawing.Size(268, 126);
            this.reals.TabIndex = 1;
            this.reals.TabStop = false;
            this.reals.Text = "擬真";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label5.Location = new System.Drawing.Point(179, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 17);
            this.label5.TabIndex = 14;
            this.label5.Text = "公里/小時";
            // 
            // speedvalue
            // 
            this.speedvalue.DecimalPlaces = 2;
            this.speedvalue.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.speedvalue.Increment = new decimal(new int[] {
            1,
            0,
            0,
            131072});
            this.speedvalue.Location = new System.Drawing.Point(106, 79);
            this.speedvalue.Maximum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.speedvalue.Name = "speedvalue";
            this.speedvalue.Size = new System.Drawing.Size(67, 23);
            this.speedvalue.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label4.Location = new System.Drawing.Point(27, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 12;
            this.label4.Text = "移動時速：";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.va_close);
            this.panel1.Controls.Add(this.va_open);
            this.panel1.Location = new System.Drawing.Point(106, 34);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(104, 24);
            this.panel1.TabIndex = 11;
            // 
            // va_close
            // 
            this.va_close.AutoSize = true;
            this.va_close.Checked = true;
            this.va_close.Location = new System.Drawing.Point(56, 4);
            this.va_close.Name = "va_close";
            this.va_close.Size = new System.Drawing.Size(47, 16);
            this.va_close.TabIndex = 1;
            this.va_close.TabStop = true;
            this.va_close.Text = "關閉";
            this.va_close.UseVisualStyleBackColor = true;
            // 
            // va_open
            // 
            this.va_open.AutoSize = true;
            this.va_open.Location = new System.Drawing.Point(3, 4);
            this.va_open.Name = "va_open";
            this.va_open.Size = new System.Drawing.Size(47, 16);
            this.va_open.TabIndex = 0;
            this.va_open.Text = "開啟";
            this.va_open.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(27, 37);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(73, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "自動變速：";
            // 
            // location
            // 
            this.location.Controls.Add(this.Lo);
            this.location.Controls.Add(this.label2);
            this.location.Controls.Add(this.La);
            this.location.Controls.Add(this.label1);
            this.location.Location = new System.Drawing.Point(17, 3);
            this.location.Name = "location";
            this.location.Size = new System.Drawing.Size(268, 116);
            this.location.TabIndex = 0;
            this.location.TabStop = false;
            this.location.Text = "座標";
            // 
            // Lo
            // 
            this.Lo.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Lo.Location = new System.Drawing.Point(84, 63);
            this.Lo.Margin = new System.Windows.Forms.Padding(8);
            this.Lo.Name = "Lo";
            this.Lo.Size = new System.Drawing.Size(149, 25);
            this.Lo.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(31, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "經度：";
            // 
            // La
            // 
            this.La.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.La.Location = new System.Drawing.Point(84, 22);
            this.La.Margin = new System.Windows.Forms.Padding(8);
            this.La.Name = "La";
            this.La.Size = new System.Drawing.Size(149, 25);
            this.La.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(31, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "緯度：";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.sniper_openpanel);
            this.tabPage4.Controls.Add(this.sniper_panel);
            this.tabPage4.Controls.Add(this.sniper_mode);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(301, 269);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "狙擊模式";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // sniper_openpanel
            // 
            this.sniper_openpanel.Controls.Add(this.ms);
            this.sniper_openpanel.Controls.Add(this.sniper_delay);
            this.sniper_openpanel.Controls.Add(this.sniper_delay_text);
            this.sniper_openpanel.Controls.Add(this.sniper_server_list);
            this.sniper_openpanel.Controls.Add(this.info);
            this.sniper_openpanel.Enabled = false;
            this.sniper_openpanel.Location = new System.Drawing.Point(3, 48);
            this.sniper_openpanel.Name = "sniper_openpanel";
            this.sniper_openpanel.Size = new System.Drawing.Size(295, 218);
            this.sniper_openpanel.TabIndex = 14;
            // 
            // ms
            // 
            this.ms.AutoSize = true;
            this.ms.Font = new System.Drawing.Font("微軟正黑體 Light", 9F);
            this.ms.Location = new System.Drawing.Point(219, 162);
            this.ms.Name = "ms";
            this.ms.Size = new System.Drawing.Size(32, 16);
            this.ms.TabIndex = 13;
            this.ms.Text = "毫秒";
            // 
            // sniper_delay
            // 
            this.sniper_delay.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.sniper_delay.Location = new System.Drawing.Point(95, 159);
            this.sniper_delay.Margin = new System.Windows.Forms.Padding(8);
            this.sniper_delay.Name = "sniper_delay";
            this.sniper_delay.Size = new System.Drawing.Size(120, 25);
            this.sniper_delay.TabIndex = 12;
            // 
            // sniper_delay_text
            // 
            this.sniper_delay_text.AutoSize = true;
            this.sniper_delay_text.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.sniper_delay_text.Location = new System.Drawing.Point(16, 162);
            this.sniper_delay_text.Name = "sniper_delay_text";
            this.sniper_delay_text.Size = new System.Drawing.Size(73, 17);
            this.sniper_delay_text.TabIndex = 11;
            this.sniper_delay_text.Text = "狙擊延遲：";
            // 
            // sniper_server_list
            // 
            this.sniper_server_list.CausesValidation = false;
            this.sniper_server_list.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.sniper_server_list.FormattingEnabled = true;
            this.sniper_server_list.Items.AddRange(new object[] {
            "PogoLocationFeeder",
            "Pokezz(全部)",
            "Pokezz(已驗證)",
            "PokeSnipers",
            "PokeWatchers",
            "Skiplagged"});
            this.sniper_server_list.Location = new System.Drawing.Point(95, 21);
            this.sniper_server_list.Name = "sniper_server_list";
            this.sniper_server_list.Size = new System.Drawing.Size(164, 112);
            this.sniper_server_list.TabIndex = 6;
            // 
            // info
            // 
            this.info.AutoSize = true;
            this.info.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.info.Location = new System.Drawing.Point(16, 21);
            this.info.Margin = new System.Windows.Forms.Padding(3);
            this.info.Name = "info";
            this.info.Size = new System.Drawing.Size(73, 17);
            this.info.TabIndex = 5;
            this.info.Text = "資料來源：";
            // 
            // sniper_panel
            // 
            this.sniper_panel.Controls.Add(this.sniper_close);
            this.sniper_panel.Controls.Add(this.sniper_open);
            this.sniper_panel.Location = new System.Drawing.Point(98, 18);
            this.sniper_panel.Name = "sniper_panel";
            this.sniper_panel.Size = new System.Drawing.Size(104, 24);
            this.sniper_panel.TabIndex = 13;
            // 
            // sniper_close
            // 
            this.sniper_close.AutoSize = true;
            this.sniper_close.Checked = true;
            this.sniper_close.Location = new System.Drawing.Point(56, 4);
            this.sniper_close.Name = "sniper_close";
            this.sniper_close.Size = new System.Drawing.Size(47, 16);
            this.sniper_close.TabIndex = 1;
            this.sniper_close.TabStop = true;
            this.sniper_close.Text = "關閉";
            this.sniper_close.UseVisualStyleBackColor = true;
            this.sniper_close.CheckedChanged += new System.EventHandler(this.sniper_close_CheckedChanged);
            // 
            // sniper_open
            // 
            this.sniper_open.AutoSize = true;
            this.sniper_open.Location = new System.Drawing.Point(3, 4);
            this.sniper_open.Name = "sniper_open";
            this.sniper_open.Size = new System.Drawing.Size(47, 16);
            this.sniper_open.TabIndex = 0;
            this.sniper_open.Text = "開啟";
            this.sniper_open.UseVisualStyleBackColor = true;
            this.sniper_open.CheckedChanged += new System.EventHandler(this.sniper_open_CheckedChanged);
            // 
            // sniper_mode
            // 
            this.sniper_mode.AutoSize = true;
            this.sniper_mode.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.sniper_mode.Location = new System.Drawing.Point(19, 21);
            this.sniper_mode.Name = "sniper_mode";
            this.sniper_mode.Size = new System.Drawing.Size(73, 17);
            this.sniper_mode.TabIndex = 12;
            this.sniper_mode.Text = "狙擊模式：";
            // 
            // save
            // 
            this.save.Location = new System.Drawing.Point(324, 207);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(159, 56);
            this.save.TabIndex = 1;
            this.save.Text = "儲存";
            this.save.UseVisualStyleBackColor = true;
            this.save.Click += new System.EventHandler(this.button1_Click);
            // 
            // exit
            // 
            this.exit.Location = new System.Drawing.Point(324, 268);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(159, 30);
            this.exit.TabIndex = 2;
            this.exit.Text = "離開";
            this.exit.UseVisualStyleBackColor = true;
            this.exit.Click += new System.EventHandler(this.button2_Click);
            // 
            // donate
            // 
            this.donate.Image = ((System.Drawing.Image)(resources.GetObject("donate.Image")));
            this.donate.Location = new System.Drawing.Point(324, 31);
            this.donate.Name = "donate";
            this.donate.Size = new System.Drawing.Size(159, 91);
            this.donate.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.donate.TabIndex = 3;
            this.donate.TabStop = false;
            // 
            // version
            // 
            this.version.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.version.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.version.Location = new System.Drawing.Point(324, 132);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(159, 72);
            this.version.TabIndex = 4;
            this.version.Text = "開發者：偵錯桐人 YuPai\r\n發布版本：v0.1.0";
            this.version.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微軟正黑體", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label6.ForeColor = System.Drawing.Color.Red;
            this.label6.Location = new System.Drawing.Point(319, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(162, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "適用版本：NecroBot v0.9.3";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(493, 310);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.version);
            this.Controls.Add(this.donate);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.save);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "NecroBot 圖形化設定程式 - NecroBot Config GUI";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.login.ResumeLayout(false);
            this.login.PerformLayout();
            this.update_panel.ResumeLayout(false);
            this.update_panel.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.reals.ResumeLayout(false);
            this.reals.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.speedvalue)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.location.ResumeLayout(false);
            this.location.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.sniper_openpanel.ResumeLayout(false);
            this.sniper_openpanel.PerformLayout();
            this.sniper_panel.ResumeLayout(false);
            this.sniper_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.donate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button save;
        private System.Windows.Forms.Button exit;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Label pwd;
        private System.Windows.Forms.TextBox passwd;
        private System.Windows.Forms.ComboBox google_ptc;
        private System.Windows.Forms.Label user;
        private System.Windows.Forms.Label account_type;
        private System.Windows.Forms.TextBox username;
        private System.Windows.Forms.Label language;
        private System.Windows.Forms.Panel update_panel;
        private System.Windows.Forms.RadioButton update_close;
        private System.Windows.Forms.RadioButton update_open;
        private System.Windows.Forms.Label auto_update;
        private System.Windows.Forms.TextBox lang;
        private System.Windows.Forms.GroupBox login;
        private System.Windows.Forms.PictureBox donate;
        private System.Windows.Forms.Label version;
        private System.Windows.Forms.Label info;
        private System.Windows.Forms.CheckedListBox sniper_server_list;
        private System.Windows.Forms.Panel sniper_openpanel;
        private System.Windows.Forms.Panel sniper_panel;
        private System.Windows.Forms.RadioButton sniper_close;
        private System.Windows.Forms.RadioButton sniper_open;
        private System.Windows.Forms.Label sniper_mode;
        private System.Windows.Forms.TextBox sniper_delay;
        private System.Windows.Forms.Label sniper_delay_text;
        private System.Windows.Forms.Label ms;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox location;
        private System.Windows.Forms.TextBox Lo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox La;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox reals;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton va_close;
        private System.Windows.Forms.RadioButton va_open;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown speedvalue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
    }
}

