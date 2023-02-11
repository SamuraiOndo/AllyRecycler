namespace EnemyDispose
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button2 = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.modelNameTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btlStartTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AIComboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.NPCTypeComboBox = new System.Windows.Forms.ComboBox();
            this.heightTrackBar = new System.Windows.Forms.TrackBar();
            this.label7 = new System.Windows.Forms.Label();
            this.damageTrackBar = new System.Windows.Forms.TrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.xTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.zTextBox = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.yTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.voiceTextBox = new System.Windows.Forms.NumericUpDown();
            this.saveFile = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.rotYTextBox = new System.Windows.Forms.NumericUpDown();
            this.unk1TextBox = new System.Windows.Forms.NumericUpDown();
            this.unk2TextBox = new System.Windows.Forms.NumericUpDown();
            this.healthTextBox = new System.Windows.Forms.NumericUpDown();
            this.unk3TextBox = new System.Windows.Forms.NumericUpDown();
            this.unk4TextBox = new System.Windows.Forms.NumericUpDown();
            this.unk5TextBox = new System.Windows.Forms.NumericUpDown();
            this.unk6TextBox = new System.Windows.Forms.NumericUpDown();
            this.unk7TextBox = new System.Windows.Forms.NumericUpDown();
            this.copyButton = new System.Windows.Forms.Button();
            this.weaponTextBox = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.heightTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.damageTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.voiceTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotYTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unk1TextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unk2TextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.healthTextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unk3TextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unk4TextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unk5TextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unk6TextBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unk7TextBox)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog1_FileOk);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Open File";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(12, 91);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 334);
            this.listBox1.TabIndex = 3;
            this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(138, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(138, 109);
            this.nameTextBox.MaxLength = 32;
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(257, 23);
            this.nameTextBox.TabIndex = 5;
            this.nameTextBox.TextChanged += new System.EventHandler(this.nameTextBox_TextChanged);
            // 
            // modelNameTextBox
            // 
            this.modelNameTextBox.Location = new System.Drawing.Point(138, 153);
            this.modelNameTextBox.MaxLength = 26;
            this.modelNameTextBox.Name = "modelNameTextBox";
            this.modelNameTextBox.Size = new System.Drawing.Size(257, 23);
            this.modelNameTextBox.TabIndex = 7;
            this.modelNameTextBox.TextChanged += new System.EventHandler(this.modelNameTextBox_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(138, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "Model Name";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Weapon";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btlStartTextBox
            // 
            this.btlStartTextBox.Location = new System.Drawing.Point(138, 241);
            this.btlStartTextBox.MaxLength = 30;
            this.btlStartTextBox.Name = "btlStartTextBox";
            this.btlStartTextBox.Size = new System.Drawing.Size(257, 23);
            this.btlStartTextBox.TabIndex = 11;
            this.btlStartTextBox.TextChanged += new System.EventHandler(this.textBox5_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(138, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 15);
            this.label4.TabIndex = 10;
            this.label4.Text = "Battle Start";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // AIComboBox
            // 
            this.AIComboBox.FormattingEnabled = true;
            this.AIComboBox.Items.AddRange(new object[] {
            "KIRYU",
            "SUDE",
            "GANG",
            "GOTSUI",
            "DEBU",
            "BOXER",
            "KICKBOXER",
            "JAKA",
            "MAJIMA",
            "RIKIYA",
            "TAMASHIRO",
            "HASEBE",
            "RICHARD",
            "KANDA",
            "LAU",
            "KAZAMA",
            "MINE",
            "RIKIYA_NPC",
            "DATE",
            "YUUYA",
            "KAZUKI",
            "GARRET",
            "KOMAKI",
            "TAIGA",
            "INZEN",
            "BRAGS",
            "WAIWAT",
            "OTAKI",
            "YONASIRO",
            "WADE",
            "YAMAMOTO",
            "YAMAZAKI",
            "BARHEART",
            "OZAWA",
            "KITO",
            "KIRISIMA",
            "KLINSMAN",
            "KOMIYAMA",
            "CARTER",
            "ONIGASIM",
            "JACK",
            "IGARASI",
            "DEADBOY",
            "TAKI",
            "KLERK",
            "NAGAI",
            "OKOUCHI",
            "KAMIYAMA",
            "MITUI",
            "CARPACCI",
            "EBINUMA",
            "MUGURUMA",
            "ISAKA",
            "TATIBANA",
            "L0NG",
            "BACARO",
            "DONJU",
            "TATU",
            "BIGDANDY",
            "MIYAMA",
            "ISIGURO",
            "HIYAMA",
            "SOLDADOF",
            "TANIGUTI",
            "MEDEROS",
            "UEMATU",
            "ZEFARL",
            "CHO",
            "KEN",
            "SAKOTA",
            "TAKEO",
            "LOYD",
            "WOODS",
            "USUI",
            "HIGUCHI",
            "ANZAI",
            "FUJISIRO",
            "ETHAN",
            "ARSAN",
            "TAGEBINUMA",
            "TAGSOLDADOF",
            "TAGHIYAMA",
            "TAGHATAE",
            "TAGJINNO",
            "IF_TAMASHIRO",
            "IF_KANDA",
            "IF_MAJIMA",
            "IF_LAU",
            "IF_KAZAMA",
            "IF_KIRYU",
            "K_DESHI1",
            "K_DESHI2",
            "K_DESHI3",
            "K_DESHI4",
            "BATSU",
            "AKITSU",
            "KOHTARO",
            "ODA_HASBAND",
            "ODA_WIFE",
            "SHOO",
            "TETSUJI",
            "HASUTANI",
            "KURENAI",
            "KENGO",
            "ZEN",
            "TOKOYAMI",
            "SENTETSTU",
            "LORENTZ",
            "SAMEJIMA",
            "YUTO",
            "ISSEN",
            "GOUREN",
            "EGAMI",
            "SHINZAKI",
            "ARASE",
            "HITOJITI",
            "NIGE",
            "TOSENBO",
            "KOTEI",
            "GOWAN",
            "HITAMN",
            "DEBU_BOXER",
            "DANBIRA",
            "PROTECTOR",
            "KARATE",
            "TAKEO_SEICHO",
            "TATIBANA_SEICHO",
            "BACARO_SEICHO",
            "DONJU_SEICHO",
            "TATU_SEICHO",
            "BIGDANDY_SEICHO",
            "SAKOTO_SEICHO",
            "UEMATU_SEICHO",
            "MITUI_SEICHO",
            "MENDEROS_SEICHO",
            "RIKKY",
            "AMON",
            "MIKIO",
            "HAMASAKI",
            "BOMBER_TEARGAS",
            "BOMBER_SMOKE",
            "BOMBER_FLASH",
            "BOMBER_LITNNG"});
            this.AIComboBox.Location = new System.Drawing.Point(138, 333);
            this.AIComboBox.Name = "AIComboBox";
            this.AIComboBox.Size = new System.Drawing.Size(257, 23);
            this.AIComboBox.TabIndex = 13;
            this.AIComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(138, 315);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 15);
            this.label5.TabIndex = 14;
            this.label5.Text = "AI";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(138, 359);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(58, 15);
            this.label6.TabIndex = 16;
            this.label6.Text = "NPC Type";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // NPCTypeComboBox
            // 
            this.NPCTypeComboBox.AutoCompleteCustomSource.AddRange(new string[] {
            "Player",
            "Goon",
            "Follower",
            "Boss",
            "Mannequin"});
            this.NPCTypeComboBox.FormattingEnabled = true;
            this.NPCTypeComboBox.Items.AddRange(new object[] {
            "Player",
            "Goon",
            "Follower",
            "Boss",
            "Mannequin"});
            this.NPCTypeComboBox.Location = new System.Drawing.Point(138, 377);
            this.NPCTypeComboBox.Name = "NPCTypeComboBox";
            this.NPCTypeComboBox.Size = new System.Drawing.Size(257, 23);
            this.NPCTypeComboBox.TabIndex = 15;
            this.NPCTypeComboBox.SelectedIndexChanged += new System.EventHandler(this.NPCTypeComboBox_SelectedIndexChanged);
            // 
            // heightTrackBar
            // 
            this.heightTrackBar.Location = new System.Drawing.Point(401, 259);
            this.heightTrackBar.Maximum = 255;
            this.heightTrackBar.Name = "heightTrackBar";
            this.heightTrackBar.Size = new System.Drawing.Size(104, 45);
            this.heightTrackBar.TabIndex = 17;
            this.heightTrackBar.Scroll += new System.EventHandler(this.heightTrackBar_Scroll);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(401, 241);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(43, 15);
            this.label7.TabIndex = 19;
            this.label7.Text = "Height";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // damageTrackBar
            // 
            this.damageTrackBar.Location = new System.Drawing.Point(401, 325);
            this.damageTrackBar.Name = "damageTrackBar";
            this.damageTrackBar.Size = new System.Drawing.Size(104, 45);
            this.damageTrackBar.TabIndex = 21;
            this.damageTrackBar.Scroll += new System.EventHandler(this.damageTrackBar_Scroll);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(401, 307);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 15);
            this.label9.TabIndex = 22;
            this.label9.Text = "Damage";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(138, 271);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 15);
            this.label10.TabIndex = 23;
            this.label10.Text = "Voice Bank";
            this.label10.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // xTextBox
            // 
            this.xTextBox.Location = new System.Drawing.Point(405, 109);
            this.xTextBox.Name = "xTextBox";
            this.xTextBox.Size = new System.Drawing.Size(100, 23);
            this.xTextBox.TabIndex = 26;
            this.xTextBox.TextChanged += new System.EventHandler(this.xTextBox_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(405, 91);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 15);
            this.label11.TabIndex = 25;
            this.label11.Text = "X";
            // 
            // zTextBox
            // 
            this.zTextBox.Location = new System.Drawing.Point(617, 109);
            this.zTextBox.Name = "zTextBox";
            this.zTextBox.Size = new System.Drawing.Size(100, 23);
            this.zTextBox.TabIndex = 28;
            this.zTextBox.TextChanged += new System.EventHandler(this.zTextBox_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(617, 91);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 15);
            this.label12.TabIndex = 27;
            this.label12.Text = "Z";
            // 
            // yTextBox
            // 
            this.yTextBox.Location = new System.Drawing.Point(511, 109);
            this.yTextBox.Name = "yTextBox";
            this.yTextBox.Size = new System.Drawing.Size(100, 23);
            this.yTextBox.TabIndex = 30;
            this.yTextBox.TextChanged += new System.EventHandler(this.yTextBox_TextChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(511, 91);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(14, 15);
            this.label13.TabIndex = 29;
            this.label13.Text = "Y";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(405, 179);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 15);
            this.label14.TabIndex = 31;
            this.label14.Text = "Health";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(405, 135);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 15);
            this.label15.TabIndex = 33;
            this.label15.Text = "Rotation Y";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(511, 135);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(37, 15);
            this.label16.TabIndex = 35;
            this.label16.Text = "Unk 1";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(617, 135);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(37, 15);
            this.label17.TabIndex = 37;
            this.label17.Text = "Unk 2";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(511, 179);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(37, 15);
            this.label18.TabIndex = 39;
            this.label18.Text = "Unk 3";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(511, 223);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(37, 15);
            this.label19.TabIndex = 43;
            this.label19.Text = "Unk 5";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(617, 179);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(37, 15);
            this.label20.TabIndex = 41;
            this.label20.Text = "Unk 4";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(511, 267);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(37, 15);
            this.label21.TabIndex = 47;
            this.label21.Text = "Unk 7";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(617, 223);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(37, 15);
            this.label22.TabIndex = 45;
            this.label22.Text = "Unk 6";
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(67, 62);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(65, 23);
            this.addButton.TabIndex = 49;
            this.addButton.Text = "+ Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(12, 62);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(59, 23);
            this.deleteButton.TabIndex = 50;
            this.deleteButton.Text = "- Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(555, 398);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(8, 8);
            this.groupBox2.TabIndex = 52;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // voiceTextBox
            // 
            this.voiceTextBox.Location = new System.Drawing.Point(138, 289);
            this.voiceTextBox.Name = "voiceTextBox";
            this.voiceTextBox.Size = new System.Drawing.Size(257, 23);
            this.voiceTextBox.TabIndex = 53;
            this.voiceTextBox.ValueChanged += new System.EventHandler(this.voiceTextBox_ValueChanged_1);
            // 
            // saveFile
            // 
            this.saveFile.Location = new System.Drawing.Point(713, 10);
            this.saveFile.Name = "saveFile";
            this.saveFile.Size = new System.Drawing.Size(75, 23);
            this.saveFile.TabIndex = 54;
            this.saveFile.Text = "Save File";
            this.saveFile.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.saveFile.UseVisualStyleBackColor = true;
            this.saveFile.Click += new System.EventHandler(this.button4_Click);
            // 
            // rotYTextBox
            // 
            this.rotYTextBox.Location = new System.Drawing.Point(405, 154);
            this.rotYTextBox.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.rotYTextBox.Name = "rotYTextBox";
            this.rotYTextBox.Size = new System.Drawing.Size(100, 23);
            this.rotYTextBox.TabIndex = 55;
            this.rotYTextBox.ValueChanged += new System.EventHandler(this.rotYTextBox_ValueChanged);
            // 
            // unk1TextBox
            // 
            this.unk1TextBox.Location = new System.Drawing.Point(511, 153);
            this.unk1TextBox.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.unk1TextBox.Name = "unk1TextBox";
            this.unk1TextBox.Size = new System.Drawing.Size(100, 23);
            this.unk1TextBox.TabIndex = 56;
            this.unk1TextBox.ValueChanged += new System.EventHandler(this.unk1TextBox_ValueChanged);
            // 
            // unk2TextBox
            // 
            this.unk2TextBox.Location = new System.Drawing.Point(617, 153);
            this.unk2TextBox.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.unk2TextBox.Name = "unk2TextBox";
            this.unk2TextBox.Size = new System.Drawing.Size(100, 23);
            this.unk2TextBox.TabIndex = 57;
            this.unk2TextBox.ValueChanged += new System.EventHandler(this.unk2TextBox_ValueChanged);
            // 
            // healthTextBox
            // 
            this.healthTextBox.Location = new System.Drawing.Point(405, 198);
            this.healthTextBox.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.healthTextBox.Name = "healthTextBox";
            this.healthTextBox.Size = new System.Drawing.Size(100, 23);
            this.healthTextBox.TabIndex = 58;
            this.healthTextBox.ValueChanged += new System.EventHandler(this.healthTextBox_ValueChanged);
            // 
            // unk3TextBox
            // 
            this.unk3TextBox.Location = new System.Drawing.Point(511, 197);
            this.unk3TextBox.Maximum = new decimal(new int[] {
            65535,
            0,
            0,
            0});
            this.unk3TextBox.Name = "unk3TextBox";
            this.unk3TextBox.Size = new System.Drawing.Size(100, 23);
            this.unk3TextBox.TabIndex = 59;
            this.unk3TextBox.ValueChanged += new System.EventHandler(this.unk3TextBox_ValueChanged);
            // 
            // unk4TextBox
            // 
            this.unk4TextBox.Location = new System.Drawing.Point(617, 198);
            this.unk4TextBox.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.unk4TextBox.Name = "unk4TextBox";
            this.unk4TextBox.Size = new System.Drawing.Size(100, 23);
            this.unk4TextBox.TabIndex = 60;
            this.unk4TextBox.ValueChanged += new System.EventHandler(this.unk4TextBox_ValueChanged);
            // 
            // unk5TextBox
            // 
            this.unk5TextBox.Location = new System.Drawing.Point(511, 242);
            this.unk5TextBox.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.unk5TextBox.Name = "unk5TextBox";
            this.unk5TextBox.Size = new System.Drawing.Size(100, 23);
            this.unk5TextBox.TabIndex = 61;
            this.unk5TextBox.ValueChanged += new System.EventHandler(this.unk5TextBox_ValueChanged);
            // 
            // unk6TextBox
            // 
            this.unk6TextBox.Location = new System.Drawing.Point(617, 242);
            this.unk6TextBox.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.unk6TextBox.Name = "unk6TextBox";
            this.unk6TextBox.Size = new System.Drawing.Size(100, 23);
            this.unk6TextBox.TabIndex = 62;
            this.unk6TextBox.ValueChanged += new System.EventHandler(this.unk6TextBox_ValueChanged);
            // 
            // unk7TextBox
            // 
            this.unk7TextBox.Location = new System.Drawing.Point(511, 285);
            this.unk7TextBox.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.unk7TextBox.Name = "unk7TextBox";
            this.unk7TextBox.Size = new System.Drawing.Size(100, 23);
            this.unk7TextBox.TabIndex = 63;
            this.unk7TextBox.ValueChanged += new System.EventHandler(this.unk7TextBox_ValueChanged);
            // 
            // copyButton
            // 
            this.copyButton.Location = new System.Drawing.Point(12, 39);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(120, 23);
            this.copyButton.TabIndex = 64;
            this.copyButton.Text = "- Copy";
            this.copyButton.UseVisualStyleBackColor = true;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // weaponTextBox
            // 
            this.weaponTextBox.FormattingEnabled = true;
            this.weaponTextBox.Items.AddRange(new object[] {
            "Category Q Stick Test",
            "Invalid Weapon",
            "Trash Can",
            "Spray Bullet Test",
            "Test Machine Gun",
            "Test Smoke Ball",
            "Amon Twin Guns",
            "Amon Explosives",
            "Amon Explosive Bullets",
            "Amon Blade",
            "Relief",
            "Relief (Broken)",
            "Round Table",
            "Round Table (Broken)",
            "Flower Vase",
            "Flower Vase (Broken)",
            "Extravagant Stool",
            "Sweet Chair (Broken)",
            "Big Purple Sofa",
            "Sofa A (Broken)",
            "Purple Sofa",
            "Sofa B (Broken)",
            "Sturdy Table",
            "Table A (Broken)",
            "Table",
            "Table B (Broken)",
            "Table",
            "Table C (Broken)",
            "Chair",
            "Chair (Broken)",
            "Ashtray",
            "Ashtray (Broken)",
            "Huge Sofa",
            "Sofa A (Broken)",
            "Mini Sofa",
            "Sofa B (Broken)",
            "Table",
            "Table (Broken)",
            "Meat A",
            "Meat B",
            "Fish A",
            "Fish B",
            "Fish C",
            "Meat C",
            "Meat C Broken 1",
            "Meat C Chunk 1",
            "Meat C Broken 2",
            "Meat C Chunk 3",
            "Fish D",
            "Fish D Broken 1",
            "Fish D Chunk 1",
            "Fish D Chunk 2",
            "Fish E",
            "Fish E Chunk",
            "Fish F",
            "Fish F Chunk",
            "Fish G",
            "Fish G Broken",
            "Fish G Chunk 1",
            "Fish G Chunk 2",
            "Fish H",
            "Fish H Chunk",
            "Fish I",
            "Fish I Broken",
            "Fish I Chunk 1",
            "Fish I Chunk 2",
            "Fish J",
            "Fish J Broken",
            "Fish Chunk 1",
            "Fish Chunk 2",
            "Fish K",
            "Fish K Chunk",
            "Fish L",
            "Fish L Chunk",
            "Fish M",
            "Fish M Broken",
            "Fish M Chunk 1",
            "Fish M Chunk 2",
            "Fish N",
            "Fish N Chunk",
            "Meat D",
            "Meat D Chunk",
            "Meat E",
            "Meat E Broken",
            "Meat E Chunk 1",
            "Meat E Chunk 2",
            "Meat F",
            "Meat F Chunk",
            "Meat G",
            "Meat G Broken",
            "Meat G Chunk 1",
            "Meat G Chunk 2",
            "Meat H",
            "Meat H Broken",
            "Meat H Chunk 1",
            "Meat H Chunk 2",
            "Meat I",
            "Meat I Broken",
            "Meat I Chunk 1",
            "Meat I Chunk 2",
            "Meat J",
            "Meat J Broken",
            "Meat J Chunk 1",
            "Meat J Chunk 2",
            "Meat K",
            "Meat K Broken",
            "Meat K Chunk 1",
            "Meat K Chunk 2",
            "Meat L",
            "Meat L Broken",
            "Meat L Chunk 1",
            "Meat L Chunk 2",
            "Dining Room Table",
            "Dining Room Chair",
            "Dining Room Table A Base",
            "Dining Room Table",
            "Dining Room Table A Piece 1",
            "Dining Room Table A Piece 2",
            "Dining Room Table B Base",
            "Dining Room Table",
            "Dining Room Table B Piece 1",
            "Dining Room Table B Piece 2",
            "Dining Room Table C Base",
            "Dining Room Table",
            "Dining Room Table C Piece 1",
            "Dining Room Table C Piece 2",
            "Dining Room Chair",
            "Dining Room Chair A Piece",
            "Dining Room Chair",
            "Dining Room Chair B Piece",
            "Dining Room Chair",
            "Dining Room Chair C Piece",
            "Yellow Bench",
            "Yellow Bench Piece",
            "Kiddy Chair",
            "Dining Room Chair D Piece",
            "Pig Head Base",
            "Pig Head",
            "Pig Head Chunk 1",
            "Pig Head Chunk 2",
            "Tuna Head Base",
            "Tuna Head",
            "Tuna Head Chunk 1",
            "Tuna Head Chunk 2",
            "Tuna Base",
            "Tuna",
            "Tuna Chunk 1",
            "Tuna Chunk 2",
            "HACT Window",
            "HACT Window Broken",
            "Locker",
            "Lockers (Broken)",
            "Locker (Broken)",
            "Locker",
            "Desk",
            "Shelf Glass",
            "Shelf Glass (Fragment)",
            "Shelf Glass (Broken)",
            "Tamashiro Door",
            "Black Sofa",
            "Tamashiro Sofa (Broken)",
            "Black Desk",
            "Tamashiro Desk (Broken)",
            "Vacancy Sign",
            "Sign A (Broken)",
            "Help Wanted Sign",
            "Sign B (Broken)",
            "Open Sign",
            "Sign C (Broken)",
            "Bulletin Board",
            "Blackboard (Broken)",
            "Office Chair",
            "Office Chair (Broken)",
            "Stool",
            "Club Stool (Broken)",
            "Burnables Bin",
            "Red Trash Can (Broken)",
            "Unburnables Bin",
            "Blue Trash Can (Broken)",
            "Umbrella Stand",
            "Umbrella Stand (Broken)",
            "Trash Can",
            "Trash Can (Broken)",
            "Ash Tray",
            "Ash Tray (Broken)",
            "Sofa",
            "Sofa (Broken)",
            "Blinding Spray",
            "Flame Spray",
            "Machine Gun Grenade",
            "Glass",
            "Glass (Broken)",
            "Glass (Smashed)",
            "Fortune Set",
            "Brown Leather Sofa",
            "Sofa (Broken)",
            "Office Table",
            "Office Table (Broken)",
            "Office Desk",
            "Office Desk (Broken)",
            "Office Chair",
            "Office Chair 0 (Broken)",
            "Office Chair",
            "Armless Office Chair (Broken)",
            "Umbrella Stand",
            "Umbrella Stand (Broken)",
            "Victory Daruma",
            "Daruma (Broken)",
            "Horse Figurine",
            "Horse Figurine (Broken)",
            "Umbrella",
            "Umbrella (Broken)",
            "Chestnut Plant",
            "Uprooted Chestnut Plant",
            "Uprooted Chestnut Plant",
            "Vibrant Chestnut Plant",
            "Bottle",
            "Bottle (Broken Fragment)",
            "Cracked Bottle",
            "Pot",
            "Pot (Broken)",
            "Trash Can",
            "Trash Can (Broken)",
            "TV",
            "TV (Broken)",
            "TV Internals",
            "TV Internals (Broken)",
            "Coliseum Explosive (Short Fuse)",
            "Office Table",
            "Office Table (Broken)",
            "Metal Trash Can",
            "Metal Office Trash Can (Broken)",
            "Crystal Ashtray",
            "Glass Office Ashtray (Broken)",
            "Office Lamp",
            "Office Lamp (Broken)",
            "Coffee Maker",
            "Office Coffee Maker (Broken)",
            "Office Bag",
            "Office Bag (Broken)",
            "Vibrant Plant",
            "Vibrant Office Plant (Broken)",
            "Black Sofa",
            "Office Loveseat (Broken)",
            "LCD TV",
            "Office LCD TV (Broken)",
            "Office Desk",
            "Office Desk (Broken)",
            "Office Chair",
            "Office Chair (Broken)",
            "Partition",
            "Office Partition (Broken)",
            "Foyer Sofa",
            "Office Sofa 01 (Broken)",
            "Table",
            "Office Table 01 (Broken)",
            "Office Desk",
            "Trash Bag A (Clear Plastic)",
            "(Night) Taxi (Navy)",
            "(Night) Taxi (Orange)",
            "(Night) Taxi (White)",
            "(Night) Sedan (Navy)",
            "(Night) Light Van (White)",
            "(Day) Taxi (Navy)",
            "(Day) Taxi (Orange)",
            "(Day) Taxi (White)",
            "(Day) Sedan (Navy)",
            "(Day) Light Van (White)",
            "(Day) Phone Booth",
            "(Night) Phone Booth",
            "Fence",
            "(Revelation) Object for Jumping",
            "Fence (Broken)",
            "(Stationary Non-Weapon) Beer Keg",
            "(Stationary Non-Weapon) Beer Case",
            "(Stationary Non-Weapon) Cone (Red)",
            "(Stationary Non-Weapon) Cone (White/Red)",
            "(Stationary Non-Weapon) Cone",
            "(Stationary Non-Weapon) Plant",
            "Flag Base",
            "Beer Case",
            "Beer Case (Yellow) Broken",
            "Trash Can",
            "Plastic Trash Bucket (Broken)",
            "Cone",
            "Cone (Small, Broken)",
            "Packed Lunch Sign",
            "Sign A (Broken)",
            "Packed Lunch Sign",
            "Flag (Broken)",
            "Remodeled Slalom Flag",
            "Thank You Campaign Flag",
            "Red Net Cafﾃｩ Flag",
            "White Net Cafﾃｩ Flag",
            "Flag",
            "Cheap DVD Flag",
            "Miso Chanko Nabe Flag",
            "Jjigae Chanko Nabe Flag",
            "Ishikari Chanko Nabe Flag",
            "Free Information Flag",
            "Szechuan Hot Pot Flag",
            "400 Yen Store Flag",
            "Tuna Bowl Flag",
            "Golden Fried Rice Flag",
            "Yosenabe Flag",
            "Mahjong Flag",
            "Private DVD Viewing Flag",
            "Prescription Pickup Flag",
            "Sabotage Flag",
            "Discount Info Flag",
            "Quick Purchase Flag",
            "Seafood Flag",
            "TATower Flag",
            "TATower Flag",
            "Kyogoma Flag",
            "Edam Cheese Dog Flag",
            "Miuraya Diner Flag",
            "Superior Free Information Flag",
            "Flag",
            "Inozen Flag",
            "Checker Flag",
            "Signboard",
            "No Parking Sign",
            "No Parking Sign",
            "No Parking Sign",
            "No Parking Sign",
            "No Parking Sign",
            "Potted Plant",
            "Cone Connector",
            "Soba Shop Yamahachi Flag",
            "Expensive Antique Flag",
            "Antique Shop Flag",
            "Signboard A",
            "Signboard C",
            "Signboard B",
            "Signboard D",
            "Signboard E",
            "Signboard F",
            "Signboard G",
            "SEXYTOYS99 Sign",
            "Sexy Shop Sign",
            "Fusion Sign",
            "DVD Shop Sign",
            "Karanmaru Flag",
            "SJG Flag",
            "Original Dining Hasetsuka Sign",
            "Venus Sign",
            "Ten-no-Gu Ramen Sign",
            "Sanuki-Tei Sign",
            "Movie Sign",
            "Host Club Sign",
            "Kamuro Ramen Sign",
            "Soba Shop Umamoto Sign",
            "Yunagi Bar Sign",
            "Uchikawa Diner Sign",
            "Ranran-Tei Sign",
            "Tengyokaku Sign",
            "Kumanekoro Sign",
            "Yakiniku Hachisuke Sign",
            "Bobusanchi Sign",
            "Cafﾃｩ Signboard",
            "Cafﾃｩ Signboard",
            "Menu Sign",
            "Ramen Menu Sign",
            "Gyoza Daimyo Sign",
            "Koma Sign",
            "Today\'s Menu Sign",
            "Main Menu Sign",
            "Written in Dreams Sign",
            "Time Service Sign",
            "3 \"Nai\" Sign",
            "KUE Sign",
            "Brand New Sign",
            "CR Master Sign",
            "Fanciful Sign",
            "Burning Slot Soul Sign",
            "I Love Paella Sign",
            "I Love Pizza Sign",
            "Pizzeria Sign",
            "Recommendations Menu Sign",
            "Classic Menu Sign",
            "Ramen Menu Sign",
            "Bar Menu Sign",
            "Karaoke Bar Sign",
            "I Love Chinese Snacks Sign",
            "Koenro Sign",
            "Campaign Announcement Sign",
            "Deep Jungle Amazon",
            "Stylish Gentleman Bar Sign",
            "Private Viewing Sign",
            "Adult Book Sign",
            "GA Sign",
            "Mall Sign",
            "Killer Beach Sign",
            "Chinese Chiropractics Sign",
            "Super Gabriel Sign",
            "NYS Hamburger Sign",
            "Wild Jackson Sign",
            "Go Club Sign",
            "ABC Bar Sign",
            "Important Announcement Sign",
            "Smile Burger Sign",
            "Donraku Manager Wanted Sign",
            "Adult Toy Sign",
            "Porn Star Sign",
            "Video Viewing Sign",
            "Oh-Oku Sign",
            "Lambda Sign",
            "Tachibana Sign",
            "Japanese Food Menu Sign",
            "Dried Squid Shop",
            "Complex Sign",
            "Manga Cafﾃｩ Sign",
            "Beauty Salon Sign",
            "Alps Sign",
            "CRASH Sign",
            "SC Clinic Sign",
            "Corner House Sign",
            "Mortal Enemy Sign",
            "Asia Sign",
            "Rice Ball Shop Sign",
            "Signboard A Night",
            "Signboard B Night",
            "Signboard C Night",
            "Signboard D Night",
            "Signboard E Night",
            "Signboard F Night",
            "Signboard G Night",
            "Paid Tour Sign",
            "Hostess Club Sign",
            "Kamurocho Sisters Sign",
            "HIGHNESS Sign",
            "Legendary Sign",
            "Sign for Shop in Building",
            "Slot Lure Sign",
            "Sweets Sign",
            "Convenience Store Sign",
            "Sign to Cozy VIP Room",
            "Chiropractor Sign",
            "All-star Hostesses Sign",
            "Beef Tsukune Bowl Sign",
            "NYHD Sign",
            "AQUANON Sign",
            "Red Wanderer Flag",
            "Venerable Tonkatsu Shop Sign",
            "Again and Again DVD Sign",
            "Club Himiko Sign",
            "Extreme Spice Sign",
            "Swapmeet Announcement Sign",
            "Catering Plan Sign",
            "Big Family Bar Sign",
            "I Love Nabe Sign",
            "Beer-Colored Sign",
            "Medieval CR Sign",
            "Combat King Sign",
            "Special Today!!!! Sign",
            "Shindai Receiving Sign",
            "Ramen Locksmiths Sign",
            "Spa Aquanon Sign",
            "Nishikaze Tower Sign",
            "Free Information Sign",
            "175 Bargain Sign",
            "Hostess Sign",
            "Gorgeousness Sign",
            "Reception Sign",
            "Proud Taste Sign",
            "Venerable Tonkatsu Shop Sign",
            "Come Look Sign",
            "Pleasure Stop Sign",
            "100 Degrees Sign",
            "New Menu Sign",
            "Special Warning Sign",
            "Mantaro Sign",
            "Coffee Shop Sign",
            "Shrimp Heaven Sign",
            "Mahjong Shop Welcome Sign",
            "Taketori Sign",
            "White Turtle Sign",
            "Mahjong Riichi Sign",
            "Miuraya Diner Sign",
            "Convenience Store Sign",
            "Sign (Broken)",
            "SEXYTOYS99 Sign",
            "Paid Tour Sign",
            "Sexy Shop Sign",
            "Fusion Sign",
            "DVD Shop Sign",
            "Karanmaru Flag",
            "Hostess Club Sign",
            "Kamurocho Sisters Sign",
            "SJG Flag",
            "Legendary Sign",
            "Original Dining Hasetsuka Sign",
            "Venus Sign",
            "Sign for Shop in Building",
            "Slot Lure Sign",
            "Ten-no-Gu Ramen Sign",
            "Sanuki-Tei Sign",
            "Sweets Sign",
            "Convenience Store Sign",
            "Sign to Cozy VIP Room",
            "Chiropractor Sign",
            "All-star Hostesses Sign",
            "Movie Sign",
            "Beef Tsukune Bowl Sign",
            "Host Club Sign",
            "NYHD Sign",
            "Kamuro Ramen Sign",
            "Soba Shop Umamoto Sign",
            "AQUANON Sign",
            "Yunagi Bar Sign",
            "Uchikawa Diner Sign",
            "Ranran-Tei Sign",
            "All-You-Can-Play Sign",
            "Venerable Tonkatsu Shop Sign",
            "Tengyokaku Sign",
            "Kumanekoro Sign",
            "Yakiniku Hachisuke Sign",
            "Bob-sanchi Sign",
            "Again and Again DVD Sign",
            "Hostess Sign",
            "Cafﾃｩ Signboard",
            "Cafﾃｩ Signboard",
            "Menu Sign",
            "Extreme Spice Sign",
            "Ramen Menu Sign",
            "Swapmeet Announcement Sign",
            "Gyoza Daimyo Sign",
            "Koma Sign",
            "Today\'s Menu Sign",
            "Main Menu Sign",
            "Written in Dreams Sign",
            "Time Service Sign",
            "Catering Plan Sign",
            "Big Family Bar Sign",
            "I Love Nabe Sign",
            "Beer-Colored Sign",
            "3 \"Nai\" Sign",
            "KUE Sign",
            "Brand New Sign",
            "Combat King Sign",
            "Medieval CR Sign",
            "Burning Slot Soul Sign",
            "Medieval CR Sign",
            "Combat King Sign",
            "Complimentary Service Sign",
            "Shindai Receiving Sign",
            "I Love Paella Sign",
            "I Love Pizza Sign",
            "Pizzeria Sign",
            "Recommendations Menu Sign",
            "Classic Menu Sign",
            "Ramen Menu Sign",
            "Ramen Locksmiths Sign",
            "AQUANON Sign",
            "Bar Menu Sign",
            "Karaoke Bar Sign",
            "I Love Chinese Snacks Sign",
            "Nishikaze Tower Sign",
            "Campaign Announcement Sign",
            "Free Information Sign",
            "Deep Jungle Amazon",
            "Stylish Gentleman Bar Sign",
            "Private Viewing Sign",
            "Adult Book Sign",
            "175 Bargain Sign",
            "Hostess Sign",
            "Gorgeousness Sign",
            "Yellow Wanderer Flag",
            "Flag Frame",
            "Draft Beer Keg",
            "Patrol Area Annoncement Sign",
            "Special Warning Sign",
            "Steel Ashtray",
            "GA Sign",
            "Reception Sign",
            "Mall Sign",
            "Proud Taste Sign",
            "Venerable Tonkatsu Shop Sign",
            "Come Look Sign",
            "Pleasure Stop Sign",
            "Killer Beach Sign",
            "Chinese Chiropractics Sign",
            "Super Gabriel Sign",
            "NYS Hamburger Sign",
            "Wild Jackson Sign",
            "100 Degrees Sign",
            "New Menu Sign",
            "Go Club Sign",
            "ABC Bar Sign",
            "Important Area Annoncement Sign",
            "Special Warning Sign",
            "Mantaro Sign",
            "Smile Burger Sign",
            "Donraku Manager Wanted Sign",
            "Adult Toy Sign",
            "Porn Star Sign",
            "Video Viewing Sign",
            "Oh-Oku Sign",
            "Coffee Shop Sign",
            "Shrimp Heaven Sign",
            "Lambda Sign",
            "Tachibana Sign",
            "Complex Sign",
            "Dried Squid Shop",
            "Complex Sign",
            "Manga Cafﾃｩ Sign",
            "Mahjong Shop Welcome Sign",
            "Beauty Salon Sign",
            "Taketori Sign",
            "Alps Sign",
            "CRASH Sign",
            "SC Clinic Sign",
            "Corner House Sign",
            "Mortal Enemy Sign",
            "White Turtle Sign",
            "Mahjong Riichi Sign",
            "Asia Sign",
            "Rice Ball Shop Sign",
            "Miuraya Diner Sign",
            "Convenience Store Sign",
            "HIGHNESS Sign",
            "Draft Beer Keg (Broken)",
            "No Parking Sign (White, Broken)",
            "No Parking Sign (Blue, Broken)",
            "No Littering Sign (Broken)",
            "Kyushu No. 1 Star Sign",
            "Kyushu No. 1 Star Sign",
            "Blue Bicycle",
            "Orange Bicycle",
            "Red Bicycle",
            "Silver Bicycle",
            "Sturdy Bicycle",
            "Mountain Bike",
            "(ADV) Weapon Shop (Truck)",
            "(ADV) Velotaxi",
            "(Minigame)<Hostess Club> Fruit Platter Combination (Large)",
            "(Minigame)<Hostess Club> Fruit Platter Combination (Medium)",
            "(Minigame)<Hostess Club> Fruit Platter Combination (Small)",
            "(Mini Mission) Wood",
            "(Mini Mission) Wood Box",
            "(Mini Mission) Shisa (Closed Mouth)",
            "(Mini Mission) Shisa (Open Mouth)",
            "(Mini Mission) Fortune Teller\'s Table/Chair",
            "(Mini Mission) Box",
            "(Mini Mission) Bottle of Awamori",
            "(Mini Mission) Trout (Full)",
            "(Mini Mission) Trout (Empty)",
            "(Mini Mission) Beer (Full)",
            "(Mini Mission) Beer (Empty)",
            "(Mini Mission) Whisky (Full)",
            "(Mini Mission) Whisky (Empty)",
            "(Mini Mission) Wine (Full)",
            "(Mini Mission) Wine (Empty)",
            "(Mini Mission) Sign (Mr. Try and Hit Me)",
            "(Mini Mission) Water Purifier",
            "(Mini Mission) Trunk",
            "(Minigame) <Hostess Club> Watered Down Whisky",
            "(Minigame) <Hostess Club> Watered Down Shochu",
            "(Minigame) <Hostess Club> Empty Glass",
            "(Minigame) <Hostess Club> Beer Glass (Beer)",
            "(Minigame) <Hostess Club> Beer Glass (Orange Juice)",
            "(Minigame) <Hostess Club> Beer Glass (Empty)",
            "(Minigame) <Hostess Club> Champagne Glass",
            "(Minigame) <Hostess Club> Empty Champagne Glass",
            "(Minigame) <Hostess Club> Coaster",
            "(Minigame) <Hostess Club> Warm Towel",
            "(Chase Action) Safety Drum",
            "(Chase Action) Directional Sign",
            "(Chase Action) Construction Site Boundary",
            "(Mini Mission) Photo Magazine from Three Years Ago",
            "(Mini Mission) Photo Magazine (Next Week)",
            "(Mini Mission) Shonen Five",
            "(Scenario) (Sub) Riona\'s Bento",
            "(Chase Action) Dump",
            "(Chase Action) Building Materials (Concrete)",
            "(Chase Action) Dump Cargo Box",
            "(Chase Action) Dump (Afternoon)",
            "(Chase Action) Dump (Night)",
            "Ashtray Stand",
            "Cone",
            "Giant Cone",
            "Ashtray Stand",
            "Carboard Box",
            "Carboard Box",
            "Beer Case",
            "Plastic Tray",
            "No Bicycle Parking Sign",
            "Plank",
            "Metal Frame",
            "Cart",
            "Trash Can",
            "Bundle of Cardboard",
            "Steel Mesh Trash Can",
            "Blue Bicycle",
            "Orange Bicycle",
            "Red Bicycle",
            "Silver Bicycle",
            "Sturdy Bicycle",
            "Mountain Bike",
            "Small Flower Pot",
            "Small Flower Pot",
            "Small Flower Pot",
            "Small Flower Pot",
            "Small Flower Pot",
            "Small Flower Pot",
            "Small Flower Pot",
            "Standing Sign",
            "Aluminum Chair",
            "Cloth-covered Chair",
            "Can Recycling",
            "Can Recycling",
            "Chura-chan",
            "Shisa-kun",
            "Magazine",
            "Broken Cart",
            "Broken Blue Bicycle",
            "Bicycle Wheel",
            "Broken Orange Bicycle",
            "Bicycle Wheel",
            "Broken Red Bicycle",
            "Bicycle Wheel",
            "Broken Silver Bicycle",
            "Bicycle Wheel",
            "Broken Sturdy Bicycle",
            "Bicycle Wheel",
            "Broken Mountain Bike",
            "Mountain Bike Wheel",
            "Broken Shisa-kun",
            "Big Traffic Cone (Broken)",
            "Beer Case (Broken)",
            "Plastic Tray (Broken)",
            "Plank (Broken)",
            "Cart (Broken)",
            "Cart (Broken) 02",
            "Trash Bucket (Broken)",
            "Cardboard Bunde (Broken)",
            "Trash Can (Broken)",
            "Blue Bicycle Piece 1",
            "Blue Bicycle Piece 2",
            "Orange Bicycle Piece 1",
            "Orange Bicycle Piece 2",
            "Red Bicycle Piece 1",
            "Red Bicycle Piece 2",
            "Silver Bicycle Piece 1",
            "Silver Bicycle Piece 2",
            "Silver Bicycle 2 Piece 1",
            "Silver Bicycle 2 Piece 2",
            "Mountain Bike Piece 1",
            "Mountain Bike Piece 2",
            "Flower Pot 1 (Fragment)",
            "Flower Pot 2 (Fragment)",
            "Flower Pot 3 (Fragment)",
            "Flower Pot 4 (Fragment)",
            "Flower Pot 5 (Fragment)",
            "Flower Pot 6 (Fragment)",
            "Flower Pot 7 (Fragment)",
            "Standing Sign (Broken)",
            "Aluminum Chair (Broken)",
            "Cloth-covered Chair (Broken)",
            "Can Recycling (Black, Broken)",
            "Can Recycling (Gray, Broken)",
            "Chura-chan (Fragment)",
            "Shisa-kun (Fragment 1)",
            "Shisa-kun (Fragment 2)",
            "Magazine (Destroyed)",
            "Salt Shaker (Broken)",
            "Long Iron Pipe (Broken)",
            "Mysterious Syringe (Broken)",
            "Ashtray Stand (Broken)",
            "Corn (Small, Broken)",
            "Corn (Big, Broken)",
            "Broken Ashtray Stand (Dirty)",
            "Broken Cardboard Box (Closed)",
            "Broken Cardboard Box (Open)",
            "No Parking Sign (Broken)",
            "Plank (Broken)",
            "Blue Bicycle (Broken)",
            "Orange Bicycle (Broken)",
            "Red Bicycle (Broken)",
            "Silver Bicycle 1 (Broken)",
            "Silver Bicycle 2 (Broken)",
            "Mountain Bike (Broken)",
            "Long Iron Pipe (Broken)",
            "Salt Shaker (Broken)",
            "Chipped Dagger",
            "Mass-produced Blade",
            "Beer Bottle",
            "Well-used Metal Bat",
            "Shoddy Pistol",
            "Shoddy Shotgun",
            "Crude Spear",
            "Beer Case with Bottles",
            "Fragile Beer Bottle",
            "Broken Beer Bottle",
            "Chinese Broadsword",
            "Machine Gun",
            "Bicycle",
            "Hitman\'s Modified Lighter",
            "Tonfa",
            "Prop Daruma",
            "Richardson\'s Shotgun",
            "Super Mod Lighter",
            "Cheap 9-Iron",
            "Coliseum Knuckles",
            "Iron Pipe",
            "Broken Black Umbrella",
            "Broken Gentleman\'s Umbrella",
            "Broken Elegant Umbrella",
            "Broken Ballbuster",
            "Broken Army Knife",
            "Broken Jackknife",
            "Broken Sonic Knife",
            "Broken Expulsion S-12",
            "Broken Slime Gun",
            "Broken Smoke Gun",
            "Broken Slime Spray",
            "Broken Iron Plate",
            "Broken Empty Can",
            "Broken Rock",
            "Broken Gas Stove",
            "Broken Thick Sandal",
            "Broken Insecticide",
            "Broken Tear Gas Grenade",
            "Broken Army Knife Fragment",
            "Broken Jackknife Fragment",
            "Broken Sonic Knife Fragment",
            "Broken Iron Pipe",
            "Broken Brickshitter Beer",
            "Broken Blackjack",
            "Broken M1985",
            "Broken Tear Gas Spray",
            "Broken Fake Dynamite",
            "Broken Cedar Lumber",
            "Broken Steel Drum",
            "Smashed Goya",
            "Broken Brickshitter Bottle",
            "Broken Cedar Lumber Fragment",
            "One-handed Long Item Base (Gear)",
            "One-handed Blade Base (Gear)",
            "Two-handed Long Item Base (Gear)",
            "Blade Base (Gear)",
            "Hammer Base (Gear)",
            "Pole Base (Gear)",
            "Shotgun Base (Gear)",
            "Brass Knuckles Base (Gear)",
            "Spray Base (Gear)",
            "Tonfa Base (Gear)",
            "Nunchaku Base (Gear)",
            "Kali Stick Base (Gear)",
            "Handgun Base (Gear)",
            "Golf Club Base (Gear)",
            "Black Umbrella",
            "Gentleman\'s Umbrella",
            "Elegant Umbrella",
            "Brickshitter Beer",
            "Blackjack",
            "Ballbuster",
            "Special Police Baton",
            "Kamiyama Police Baton",
            "Army Knife",
            "Jackknife",
            "Sonic Knife",
            "Red Lion Dagger",
            "Wooden Short Sword",
            "Nameless Short Sword",
            "Spirit Spring Short Sword",
            "Shintogo Dagger",
            "Kogarasu Maru",
            "Radiant Sword",
            "Chinese Broadsword",
            "Lotus Clan Broadsword",
            "Stun Gun",
            "Hyper Stun Gun",
            "Divine Dragon Short Sword",
            "9-Iron",
            "Wooden Driver",
            "Black Shaft",
            "Patriarch\'s Driver",
            "Metal Bat",
            "Spiked Bat",
            "Patriarch\'s Bat",
            "Dragon Flash Driver",
            "Blue Dragon Bat",
            "Wooden Katana",
            "Nameless Katana",
            "Dark Wooden Sword",
            "Mail Order Katana",
            "Photon Blade RG",
            "Quality Steel Blade",
            "Nature Blade",
            "Ornate Blade",
            "Shadow Blade",
            "Sakura Storm",
            "Muramasa Blade",
            "Kanemitsu Bullet-Cutter",
            "Dragon Emblem Sword",
            "Collapsible Hammer",
            "Pepper Spray Hammer",
            "Toy Hammer",
            "Dragon Hammer",
            "Extendable Staff",
            "Compact Octagon Staff",
            "Blade Staff",
            "Assassin\'s Spear",
            "Steel Extendable Staff",
            "Spiked Staff",
            "Purgatory Rod",
            "White Dragon Spear",
            "Broken M1985",
            "Expulsion S-12",
            "Slime Gun",
            "Smoke Gun",
            "Brass Knuckles",
            "Paper Tiger Knuckles",
            "Pepper Knuckles",
            "Spiked Knuckles",
            "Ogre Knuckles",
            "Iron Gloves",
            "Dragon Knuckles",
            "Pepper Spray",
            "Fake Dynamite",
            "Slime Spray",
            "Modified Lighter",
            "Modified Stun Lighter",
            "Mail Order Tonfa",
            "Iron Tonfa",
            "Steel Tonfa",
            "Carbon Tonfa",
            "Bladed Tonfa",
            "Retrofire Tonfa",
            "Chinese Dragon Tonfa",
            "Wooden Nunchaku",
            "Long Nunchaku",
            "Heavy Nunchaku",
            "Twin Hangers",
            "Carbon Nunchaku",
            "Steel Nunchaku",
            "Dragon Nunchaku",
            "Double Slats",
            "Demon Taiko Sticks",
            "Spiked Taiko Sticks",
            "Double Sticks",
            "Double Shafts",
            "Double Stun Sticks",
            "Double Coils",
            "Premium Double Shafts",
            "Double Swords",
            "Double Broadswords",
            "Dragon Taiko Sticks",
            "9mm Automatic Pistol",
            "Double Action Revolver",
            "Fake Pistol",
            "Drow-Z 55",
            "Golden Pistol",
            "Gurukun",
            "Cedar Lumber",
            "Crowbar",
            "Pliers",
            "Flower Pot (Big)",
            "Iron Plate",
            "Broken LCD TV",
            "Giant Object",
            "Steel Drum",
            "Victory Daruma",
            "Incompatible DTTV",
            "Full Face Helmet",
            "Maneki-neko",
            "Long Iron Pipe",
            "Worn Leather Belt",
            "Old Chain",
            "Rope",
            "Empty Can",
            "Rock",
            "Broken Plate",
            "Gas Stove",
            "Hard Hat",
            "Goya",
            "Fire Extinguisher",
            "Economy-size Extreme Spice",
            "Huge Pot Cleaner",
            "Weathered Telephone Directory",
            "Industrial Pepper",
            "Mystery Liquid Bottle",
            "Mysterious Powder Bag",
            "Mysterious Syringe",
            "Salt Shaker",
            "House Ball",
            "Thick Sandal",
            "Bowling Ball",
            "Flimsy Safety Shoes",
            "Kettle",
            "Insecticide",
            "Tear Gas Grenade",
            "Smoke Grenade",
            "Flash Bang",
            "Lightning Bomb",
            "Pouch",
            "Staminan X",
            "Staminan XX",
            "Staminan Royale",
            "Staminan Spark",
            "Tauriner",
            "Tauriner +",
            "Tauriner ++",
            "Tauriner Maximum",
            "Toughness Z",
            "Toughness ZZ",
            "Toughness Emperor",
            "Toughness Infinity",
            "Trash Bag A (Clear Plastic)",
            "Signboard",
            "Beer Case",
            "Trash Can",
            "Sighboard (Type A) Izakaya 01",
            "Corn (Small)",
            "No Bicycle Parking Sign",
            "Cart",
            "Trash Can",
            "Trash Can",
            "Blue Bicycle",
            "Orange Bicycle",
            "Red Bicycle",
            "Bicycle",
            "Silver Bicycle",
            "Mountain Bike",
            "Test Explosion Blast Wave",
            "Tamashiro Knife",
            "Slime Gun Bullet",
            "Smoke Gun Bullet",
            "Slime Gun Slide Zone",
            "Smoke Gun Blind Zone",
            "Slime Spray Projectile",
            "Retrofire Tonfa Bullet",
            "(Weapon Master Grand Prix) Explosive Bullet",
            "Coliseum Explosive",
            "Coliseum Explosive",
            "Tear Gas Grenade Projectile",
            "Smoke Grenade Projectile",
            "Flash Bang Projectile",
            "Lightning Bomb Projectile",
            "Blue House Ball",
            "Broken Blue House Ball",
            "Red House Ball",
            "Broken Red House Ball",
            "Yellow House Ball",
            "Broken Yellow House Ball",
            "Green House Ball",
            "Broken Green House Ball",
            "Propane Gas Canister",
            "Broken Propane Gas Canister",
            "Mahjong Parlor Sign",
            "Broken Mahjong Sign",
            "Mahjong Parlor Nighttime Sign",
            "Broken Mahjong Nighttime Sign",
            "Soba Shop Chair",
            "Broken Soba Shop Chair",
            "Soba Shop Sign with Pig",
            "Broken Soba Shop Pig",
            "Soba Shop Sign",
            "Broken Soba Shop Sign",
            "Wooden Signboard",
            "Broken Wooden Signboard",
            "Canal Grande Sign",
            "Broken Signboard",
            "South Island Sign",
            "Broken Island Sign",
            "Signboard",
            "Broken Dealer Sign",
            "Signboard",
            "M Store Sign",
            "Broken Signboard",
            "M Store Sign",
            "Soki Soba Sign",
            "Broken Soba Sign",
            "Signboard",
            "Downtown Ryukyu Soba Flag",
            "Diving Flag",
            "Stone Wall",
            "Stone Wall Piece",
            "Stone Wall (Box)",
            "Stone Wall (Plane)",
            "Mini-Truck",
            "Trash Can",
            "Broken Trash Can",
            "Lamp",
            "Broken Lamp",
            "Vibrant Plant",
            "Vibrant Plant Pot Fragment",
            "Destroyed Vibrant Plant",
            "Vibrant Plant Stem",
            "Table",
            "Table Piece",
            "TV",
            "Broken TV",
            "Sofa",
            "Sofa (Broken)",
            "Coliseum_Abyss_Pre-Destruction_Transparent",
            "Coliseum_Abyss_First_Destruction_Transparent",
            "Coliseum_Abyss_First_Destruction_Fragment",
            "Coliseum_Abyss_Second_Destruction_Fragment",
            "Coliseum_Abyss_First_Destruction_Fragment",
            "Coliseum_Normal_Column",
            "Coliseum_Normal_Fence_Transparent",
            "Coliseum_Normal_Column_Transparent",
            "Coliseum_Abyss_Column",
            "Coliseum_Abyss_Column_Transparent",
            "Broken Photon Blade",
            "Broken Collapsible Hammer",
            "Broken Pepper Spray Hammer",
            "Broken Toy Hammer",
            "Broken Dragon Hammer",
            "Broken Blade Staff",
            "Broken Assassin\'s Spear",
            "Broken Steel Extendable Staff",
            "Broken Spiked Staff",
            "Broken Purgatory Rod",
            "Broken White Dragon Staff",
            "Broken Mail Order Tonfa",
            "Broken Iron Tonfa",
            "Broken Steel Tonfa",
            "Broken Carbon Tonfa",
            "Broken Bladed Tonfa",
            "Broken Retrofire Tonfa",
            "Broken Chinese Dragon Tonfa",
            "Broken Double Sticks",
            "Broken Double Shafts",
            "Broken Double Stun Sticks",
            "Broken Double Coils",
            "Broken Premium Double Shafts",
            "Broken Tabasco Bottle",
            "Broken Telephone Directory",
            "Broken Hot Peppers",
            "Broken Mystery Liquid Bottle",
            "Broken Mail Order Tonfa Fragment",
            "Broken Carbon Tonfa Fragment",
            "Broken Bladed Tonfa Fragment",
            "Broken Wooden Nunchaku Fragment",
            "Broken Long Nunchaku Fragment",
            "Broken Heavy Nunchaku Fragment",
            "Broken Carbon Nunchaku Fragment",
            "Broken Steel Nunchaku Fragment",
            "Broken Dragon Nunchaku Fragment",
            "Broken Double Sticks Fragment",
            "Broken Double Stun Sticks Fragment",
            "Broken Double Coils Fragment",
            "Broken Double Shafts",
            "Broken Dragon Tonfa",
            "Broken Bottle",
            "Broken Photon Blade Fragment",
            "Broken Hammer",
            "Broken Blade Staff Fragment",
            "Broken Assassin\'s Spear Fragment",
            "Broken Spiked Staff Fragment",
            "Broken Dragon Staff",
            "Wooden Bench",
            "Wooden Bench Fragment",
            "Small Wooden Sign",
            "Broken Sign",
            "Wooden Chair",
            "Broken Wooden Chair",
            "Wooden Table",
            "Broken Wooden Table",
            "Tasteful Urn",
            "Broken Urn",
            "No Hawking Sign",
            "Broken Arcade Sign",
            "Gambling Sign",
            "Broken Gambling Sign",
            "Sushi Sign",
            "Broken Sushi Sign",
            "Convenience Store Sign",
            "Broken Convenience Store Sign",
            "Accessory Sign",
            "Broken Accessory Sign",
            "Shisa Sign",
            "Broken Shisa Sign",
            "Dancing Sign",
            "Broken Dancing Sign",
            "Chinsuko Cookies Sign",
            "Broken Chinsuko Cookies Sign",
            "Sign\'s Contents",
            "Broken Sign\'s Contents",
            "Sign\'s Contents",
            "Broken Sign\'s Contents Small",
            "Sushi Sign",
            "Convenience Store Sign",
            "Shisa Sign",
            "Dancing Sign",
            "Cooking Shop Sign",
            "Broken Cooking Shop Sign",
            "Open Sign",
            "Open Sign Stepladder",
            "Broken Open Sign",
            "Broken Open Sign Stepladder",
            "AQUA Sign",
            "Broken AQUA Sign",
            "AQUA Sign",
            "Red Bench",
            "Broken Red Bench",
            "Chest",
            "Broken Hospital Chest Model 01",
            "Chest",
            "Broken Hospital Chest Model 02",
            "Bed",
            "Broken Hospital Bed",
            "Locker",
            "Broken Hospital Locker Model 01",
            "Broken Locker Fragment Model 01",
            "Partitioning Screen",
            "Broken Partitioning Screen Model",
            "Carboard Box",
            "Broken Cardboard Box",
            "Bench",
            "Bench Fragment",
            "Broken Bench",
            "Broken Bench Model",
            "Vibrant Plant",
            "Broken Vibrant Plant Model",
            "Table",
            "Broken Sofa Table",
            "Round Table",
            "Broken Round Table",
            "Sofa",
            "Broken Hospital Sofa Model 01",
            "Sofa",
            "Broken Hospital Sofa Model 02",
            "Extremely Robust Vase",
            "Broken Hospital Vase Model 01",
            "Vibrant Plant",
            "Broken Plant",
            "Burnables Bin",
            "Broken Garbage Can (Burnables)",
            "Unburnables Bin",
            "Broken Garbage Can (Unburnables)",
            "Receptionist Machine",
            "Broken Receptionist Machine",
            "Bench",
            "Bulletin Board",
            "Hospital Sign 01 Broken Model",
            "Table",
            "Broken Table",
            "Stretcher",
            "Broken Stretcher Model",
            "Sofa",
            "Broken Office Sofa 03 Model",
            "Catering Trolley",
            "Broken Catering Trolley Model",
            "Coat Rack",
            "Broken Coat Rack Model",
            "Lantern",
            "Lantern",
            "Tojo Clan Lantern (Broken)",
            "ADV Stationed Patrol Car",
            "(BTL) Snake Flower Triad Car",
            "(ADV) Ridden Taxi",
            "Memory Machine",
            "(Revelation hact) (ADV) Kabu",
            "(Revelation hact) (ADV) Tissue Box",
            "(Revelation hact) (ADV) Bowling Ball (3 Ball Set)",
            "(Revelation hact) (ADV) Old Woman\'s Scooter",
            "(Revelation hact) Old Woman\'s Scooter",
            "(Revelation hact) Kabu",
            "(Revelation hact) Soba Steamer",
            "(HACT) Broken Crown (Sedan) Windshield Glass",
            "(HACT) Broken Crown (Light Van) Windshield Glass",
            "(HACT) Nunchaku Chain",
            "(Recovery Item) Purse (Temp)",
            "(Scenario) (ADV) (Ch 1) Bouquet",
            "(Scenario) (ADV) (Ch 1) Beer Case",
            "(Scenario) (ADV) (Ch 2) Kiryu\'s Curry & Rice",
            "(Scenario) (ADV) (Ch 2) The Kids\' Curry & Rice",
            "(Scenario) (ADV) (Ch 2) Rikiya\'s Light Truck",
            "(Scenario) (ADV) (Ch 3) Lost Sketchbook",
            "(Scenario) (ADV) (Ch 3) Stardust Stack of Bills",
            "(Scenario) (ADV) (Ch 6) Youngster\'s Glass",
            "(Scenario) (ADV) (Ch 6) Tojo Clan Exec\'s Picture",
            "(Scenario) (ADV) (Ch 6) \"Base Defense Order\" Newspaper",
            "(Scenario) (ADV) (Ch 6) Picture of Susuzki and Majima",
            "(Scenario) (ADV) (Ch 5) Glass of Whisky and Water",
            "(Scenario) (ADV) (Ch 6) Kiryu\'s Glass",
            "(Scenario) (ADV) (Ch 6) Date\'s Glass",
            "(Scenario) (ADV) (Ch 9) Expensive Car",
            "(Scenario) (ADV) (Ch 10) Glass of Whisky and Water",
            "(Scenario) (ADV) (Ch 10) Date-san\'s Cigarettes",
            "(Scenario) (ADV) (Ch 11) Strip Club Glass",
            "(Scenario) (ADV) (Ch 11) Kiryu\'s Jacket",
            "(Scenario) (ADV) (Ch 2) Cushion",
            "(Scenario) (ADV) (Ch 5) Stardust: Table Set A",
            "(Scenario) (ADV) (Ch 5) Stardust: Table Set B",
            "(Scenario) (ADV) (Ch 5) Stardust: Table Set C",
            "(Scenario) (ADV) [Doghouse] Mame\'s House",
            "(Scenario) (ADV) [Doghouse] Mame\'s Destroyed House",
            "(Scenario) (BTL) (Ch 12) Daigo\'s Stretcher",
            "(Scenario) (Sub) Will",
            "(Scenario) (Sub) Shoes",
            "(Scenario) (Sub) Ayako\'s Bag",
            "(Scenario) (Sub) Forged Card",
            "(Bar) (Suntory) Yamazaki 25 Years",
            "(Bar) (Suntory) Yamazaki 12 Years",
            "(Bar) (Suntory) Hakushu 12 Years",
            "(Bar) (Suntory) The Macallan 1946",
            "(Bar) (Suntory) The Macallan 30 Years",
            "(Bar) (Suntory) The Macallan 12 Years",
            "(Bar) (Suntory) Laphroaig 30 Years",
            "(Bar) (Suntory) Laphroaig 10 Years",
            "(Bar) (Suntory) Bowmore 12 Years",
            "(Bar) (Suntory) Glenfiddich 30 Years",
            "(Bar) (Suntory) Glenfiddich 12 Years",
            "(Bar) (Suntory) Hibiki 30 Years Old",
            "(Bar) (Suntory) Hibiki",
            "(Bar) (Suntory) Hokuto 12 Years",
            "(Bar) (Suntory) Kakubin",
            "(Bar) (Suntory) The Suntory Old",
            "(Bar) (Suntory) Ballantine\'s 30 Years Old",
            "(Bar) (Suntory) Ballantine\'s 17 Years Old",
            "(Bar) (Suntory) Ballantine\'s Finest Scotch",
            "(Bar) (Suntory) Jack Daniel\'s",
            "(Bar) (Suntory) Early Times",
            "(Bar) (Suntory) XO Deluxe",
            "(Bar) (Suntory) Suntory Brandy V.S.O.P",
            "(Bar) (Suntory) V.O",
            "(Bar) (Suntory) Courvoisier XO",
            "(Bar) (Suntory) The Premium Malt\'s",
            "(Bar) (Suntory) Carlsberg",
            "(Bar) (Suntory) Kyogetsu Green",
            "(Bar) (Suntory) Ryukyu Awamori Churajima",
            "(Bar) (Suntory) Ryukyu Awamori Tenryugura",
            "(Bar) (Suntory) Beefeater",
            "(Bar) (Suntory) Lemon Hart Demerara",
            "(Bar) (Suntory) Herradura Silver Tequila",
            "(Bar) (Suntory) SKYY Vodka",
            "(Bar) (Higa Distillery) Umi No Iro",
            "(Minigame) (Higa Distillery) Zampa White",
            "(Bar) (Tantakatan) Tantakatan",
            "(Bar) Shot Glass",
            "(Bar) Tumbler",
            "(Bar) Whisky Glass",
            "(Bar) Brandy Glass",
            "(Bar) Tasting Glass (Gold)",
            "(Bar) Tasting Glass (Brown)",
            "(Bar) Tasting Glass (Sherry)",
            "(Bar) Beer Glass",
            "(Bar) Whisky Glass (Sherry)",
            "(Chase Action) 10,000 Yen Bill",
            "(Minigame) <Cee-lo> Dice",
            "Flag",
            "Fishing Rod",
            "(Minigame) <Hostess Club> Ice Bucket and Tong Set",
            "Broken Police Baton",
            "Broken Kamiyama Police Baton",
            "Broken Chinese Broadsword",
            "Broken Lotus Clan Broadsword",
            "Broken Stun Gun",
            "Broken Hyper Stun Gun",
            "Broken 9-Iron",
            "Broken Wooden Driver",
            "Broken Black Shaft",
            "Broken Patriarch\'s Driver",
            "Broken Dragon Flash Driver",
            "Broken Bat",
            "Broken Spiked Bat",
            "Broken Patriarch\'s Bat",
            "Broken Blue Dragon Bat",
            "Broken Oak Wood Katana",
            "Broken Nameless Katana",
            "Broken Dark Wooden Sword",
            "Broken Mail Order Katana",
            "Broken Quality Steel Blade",
            "Broken Nature Blade",
            "Broken Ornate Blade",
            "Broken Shadow Blade",
            "Broken Sakura Storm",
            "Broken Muramasa Blade",
            "Broken Kanemitsu Bullet-Cutter",
            "Broken Dragon Emblem Sword",
            "Broken Extendable Staff",
            "Broken Compact Octagon Staff",
            "Broken Brass Knuckles",
            "Broken Paper Tiger Knuckles",
            "Broken Pepper Knuckles",
            "Broken Spiked Knuckles",
            "Broken Ogre Knuckles",
            "Broken Iron Gloves",
            "Broken Dragon Knuckles",
            "Breaking Stun Gun",
            "Broken Modified Lighter",
            "Broken Modified Stun Lighter",
            "Broken Double Slats",
            "Broken Demon Taiko Sticks",
            "Broken Spiked Taiko Sticks",
            "Broken Dragon Taiko Sticks",
            "Broken Spear",
            "Machine Gun",
            "Worn-out Hammer",
            "Beer Bottle",
            "Tamashiro Brass Knuckles",
            "Tamashiro Knife",
            "Broken Beer Bottle",
            "Metal Bat",
            "Cheap Police Baton",
            "Switchblade",
            "Kanda\'s Hidden Blade",
            "Majima\'s Dagger",
            "Subordinate\'s Spear",
            "Liu Chinese Spear",
            "PS-1992",
            "Beer Case",
            "Red Lion Dagger Fragment",
            "Wooden Short Sword Fragment",
            "Nameless Short Sword Fragment",
            "Short Sword Fragment",
            "Shintogo Dagger Fragment",
            "Kogarasu Maru Fragment",
            "Radiant Sword Fragment",
            "Chinese Broadsword Fragment",
            "Lotus Clan Broadsword Fragment",
            "Dragon Short Sword Fragment",
            "Hyper Stun Gun Piece",
            "Wooden Driver Piece",
            "Spiked Bat Piece",
            "Extendable Staff Piece",
            "Compact Octagon Staff Piece",
            "Modified Stun Lighter Piece",
            "Twin Hangers Piece",
            "Double Slats Piece",
            "Spiked Taiko Sticks Piece",
            "Beer Bottle Fragment",
            "Lau\'s Spear Fragment",
            "Fragile Spear",
            "Nunchaku",
            "Gun",
            "D Stick",
            "Axe",
            "Knife",
            "Kitchen Knife",
            "Metal Bat",
            "Scythe",
            "Coliseum Katana",
            "Coliseum Dagger",
            "Coliseum Knuckles",
            "Coliseum Nunchaku",
            "Coliseum Metal Bat",
            "Coliseum Explosive",
            "Brass Knuckles",
            "Colored Ball",
            "Gurukun Chunk",
            "Crowbar Fragment",
            "Bench Piece",
            "Flower Pot Fragment",
            "Victory Daruma Piece",
            "Brown Tube TV (15 Inch) Piece",
            "Rope Piece",
            "Fire Extinguisher Piece",
            "Bowling Ball Fragment",
            "Kettle Piece",
            "Chipped Dagger Fragment",
            "Crude Spear Fragment",
            "Bowl",
            "Bat",
            "Colored Bat",
            "Flag",
            "Debug Tonfa",
            "Debug Kali Sticks",
            "Chinese Spear",
            "Pole",
            "Dagger",
            "Debug Gun",
            "Debug Shotgun",
            "Claw (Hooked)",
            "Iron Odachi",
            "Debug Nunchaku",
            "Twin Handguns (Normal)",
            "Debug Hammer",
            "Debug Katana",
            "Fire Extinguisher",
            "Cabinet",
            "Stardust Cabinet (Broken)",
            "Partition",
            "Partition",
            "Desk",
            "Desk",
            "Broken Red Lion Dagger",
            "Broken Wooden Short Sword",
            "Broken Nameless Short Sword",
            "Broken Spirit Spring Short Sword",
            "Broken Shintogo Dagger",
            "Broken Kogarasu Maru",
            "Broken Radiant Sword",
            "Broken Dragon Short Sword",
            "Wooden Katana Fragment",
            "Nameless Katana Fragment",
            "Dark Wood Sword Fragment",
            "Mail Order Katana Fragment",
            "Quality Steel Blade Fragment",
            "Nature Blade Fragment",
            "Ornate Blade Fragment",
            "Shadow Blade Fragment",
            "Sakura Storm Fragment",
            "Muramasa Blade Fragment",
            "Bullet-Cutter Fragment",
            "Dragon Emblem Sword Fragment",
            "Stool",
            "Broken Stardust Stool",
            "Blue Bench",
            "Broken Bench",
            "Ashcan",
            "Broken Batting Center Ashcan",
            "Portable Ashtray",
            "Square Ashtray (Broken)",
            "Counter Stool",
            "Stardust Counter Stool (Broken)",
            "Floor Lamp",
            "Stardust Floor Lamp 01 (Broken)",
            "Floor Lamp",
            "Stardust Floor Lamp 02 (Broken)",
            "Stardust Cabinet",
            "Stardust Cabinet (Broken)",
            "Batting Center Plastic Bucket",
            "Plastic Bucket (Broken)",
            "Sofa",
            "Batting Center Sofa (Broken)",
            "Stool",
            "Batting Center Stool (Broken)",
            "Trash Can",
            "Trash Can (Broken)",
            "Sofa",
            "Generic Office 04 Sofa (Broken)",
            "Table",
            "Generic Office 04 Table (Broken)",
            "Chair",
            "Generic Office 04 Chair (Broken)",
            "Desk",
            "Generic Office 04 Desk (Broken)",
            "Desk Drawer",
            "Desk Drawer (Broken)",
            "Generic Office 04 Partition",
            "Partition (Broken)",
            "No Weapon"});
            this.weaponTextBox.Location = new System.Drawing.Point(138, 198);
            this.weaponTextBox.Name = "weaponTextBox";
            this.weaponTextBox.Size = new System.Drawing.Size(257, 23);
            this.weaponTextBox.TabIndex = 65;
            this.weaponTextBox.SelectedIndexChanged += new System.EventHandler(this.weaponTextBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.weaponTextBox);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.unk7TextBox);
            this.Controls.Add(this.unk6TextBox);
            this.Controls.Add(this.unk5TextBox);
            this.Controls.Add(this.unk4TextBox);
            this.Controls.Add(this.unk3TextBox);
            this.Controls.Add(this.healthTextBox);
            this.Controls.Add(this.unk2TextBox);
            this.Controls.Add(this.unk1TextBox);
            this.Controls.Add(this.rotYTextBox);
            this.Controls.Add(this.saveFile);
            this.Controls.Add(this.voiceTextBox);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.yTextBox);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.zTextBox);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.xTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.damageTrackBar);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.heightTrackBar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.NPCTypeComboBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.AIComboBox);
            this.Controls.Add(this.btlStartTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.modelNameTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.button2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Ally Recycler";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.heightTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.damageTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.voiceTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rotYTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unk1TextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unk2TextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.healthTextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unk3TextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unk4TextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unk5TextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unk6TextBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unk7TextBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private OpenFileDialog openFileDialog1;
        private Button button2;
        private Label label1;
        private ListBox listBox1;
        private TextBox nameTextBox;
        private TextBox modelNameTextBox;
        private Label label2;
        private Label label3;
        private TextBox btlStartTextBox;
        private Label label4;
        private ComboBox AIComboBox;
        private Label label5;
        private Label label6;
        private ComboBox NPCTypeComboBox;
        private TrackBar heightTrackBar;
        private TrackBar trackBar2;
        private Label label7;
        private Label label8;
        private TrackBar damageTrackBar;
        private Label label9;
        private Label label10;
        private TextBox xTextBox;
        private Label label11;
        private TextBox zTextBox;
        private Label label12;
        private TextBox yTextBox;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Label label21;
        private Label label22;
        private Button addButton;
        private Button deleteButton;
        private GroupBox groupBox2;
        private NumericUpDown voiceTextBox;
        private Button saveFile;
        private SaveFileDialog saveFileDialog1;
        private NumericUpDown rotYTextBox;
        private NumericUpDown unk1TextBox;
        private NumericUpDown unk2TextBox;
        private NumericUpDown healthTextBox;
        private NumericUpDown unk3TextBox;
        private NumericUpDown unk4TextBox;
        private NumericUpDown unk5TextBox;
        private NumericUpDown unk6TextBox;
        private NumericUpDown unk7TextBox;
        private Button copyButton;
        private ComboBox weaponTextBox;
    }
}