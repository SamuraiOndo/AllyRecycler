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
            openFileDialog1 = new OpenFileDialog();
            button2 = new Button();
            listBox1 = new ListBox();
            label1 = new Label();
            nameTextBox = new TextBox();
            modelNameTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            btlStartTextBox = new TextBox();
            label4 = new Label();
            AIComboBox = new ComboBox();
            label5 = new Label();
            label6 = new Label();
            NPCTypeComboBox = new ComboBox();
            heightTrackBar = new TrackBar();
            label7 = new Label();
            damageTrackBar = new TrackBar();
            label9 = new Label();
            label10 = new Label();
            xTextBox = new TextBox();
            label11 = new Label();
            zTextBox = new TextBox();
            label12 = new Label();
            yTextBox = new TextBox();
            label13 = new Label();
            label14 = new Label();
            label15 = new Label();
            label16 = new Label();
            label17 = new Label();
            label18 = new Label();
            label19 = new Label();
            label20 = new Label();
            label21 = new Label();
            label22 = new Label();
            addButton = new Button();
            deleteButton = new Button();
            groupBox2 = new GroupBox();
            voiceTextBox = new NumericUpDown();
            saveFile = new Button();
            saveFileDialog1 = new SaveFileDialog();
            rotYTextBox = new NumericUpDown();
            unk1TextBox = new NumericUpDown();
            unk2TextBox = new NumericUpDown();
            healthTextBox = new NumericUpDown();
            unk3TextBox = new NumericUpDown();
            unk4TextBox = new NumericUpDown();
            unk5TextBox = new NumericUpDown();
            unk6TextBox = new NumericUpDown();
            unk7TextBox = new NumericUpDown();
            copyButton = new Button();
            refreshButton = new Button();
            flags1Label = new Label();
            flags2Label = new Label();
            flags3Label = new Label();
            flags1TextBox = new NumericUpDown();
            flags2TextBox = new NumericUpDown();
            flags3TextBox = new NumericUpDown();
            weaponTextBox = new TextBox();
            aiComboBoxY4 = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)heightTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)damageTrackBar).BeginInit();
            ((System.ComponentModel.ISupportInitialize)voiceTextBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)rotYTextBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)unk1TextBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)unk2TextBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)healthTextBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)unk3TextBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)unk4TextBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)unk5TextBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)unk6TextBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)unk7TextBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)flags1TextBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)flags2TextBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)flags3TextBox).BeginInit();
            SuspendLayout();
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            openFileDialog1.FileOk += openFileDialog1_FileOk;
            // 
            // button2
            // 
            button2.Location = new Point(12, 10);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 1;
            button2.Text = "Open File";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 91);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(120, 334);
            listBox1.TabIndex = 3;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(138, 91);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 4;
            label1.Text = "Name";
            label1.Click += label1_Click_1;
            // 
            // nameTextBox
            // 
            nameTextBox.Location = new Point(138, 109);
            nameTextBox.MaxLength = 32;
            nameTextBox.Name = "nameTextBox";
            nameTextBox.Size = new Size(257, 23);
            nameTextBox.TabIndex = 5;
            nameTextBox.TextChanged += nameTextBox_TextChanged;
            // 
            // modelNameTextBox
            // 
            modelNameTextBox.Location = new Point(138, 153);
            modelNameTextBox.MaxLength = 26;
            modelNameTextBox.Name = "modelNameTextBox";
            modelNameTextBox.Size = new Size(257, 23);
            modelNameTextBox.TabIndex = 7;
            modelNameTextBox.TextChanged += modelNameTextBox_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(138, 135);
            label2.Name = "label2";
            label2.Size = new Size(76, 15);
            label2.TabIndex = 6;
            label2.Text = "Model Name";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(138, 179);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 8;
            label3.Text = "Weapon";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // btlStartTextBox
            // 
            btlStartTextBox.Location = new Point(138, 241);
            btlStartTextBox.MaxLength = 30;
            btlStartTextBox.Name = "btlStartTextBox";
            btlStartTextBox.Size = new Size(257, 23);
            btlStartTextBox.TabIndex = 11;
            btlStartTextBox.TextChanged += textBox5_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(138, 223);
            label4.Name = "label4";
            label4.Size = new Size(64, 15);
            label4.TabIndex = 10;
            label4.Text = "Battle Start";
            label4.TextAlign = ContentAlignment.TopCenter;
            label4.Click += label4_Click;
            // 
            // AIComboBox
            // 
            AIComboBox.FormattingEnabled = true;
            AIComboBox.Items.AddRange(new object[] { "KIRYU", "SUDE", "GANG", "GOTSUI", "DEBU", "BOXER", "KICKBOXER", "JAKA", "MAJIMA", "RIKIYA", "TAMASHIRO", "HASEBE", "RICHARD", "KANDA", "LAU", "KAZAMA", "MINE", "RIKIYA_NPC", "DATE", "YUUYA", "KAZUKI", "GARRET", "KOMAKI", "TAIGA", "INZEN", "BRAGS", "WAIWAT", "OTAKI", "YONASIRO", "WADE", "YAMAMOTO", "YAMAZAKI", "BARHEART", "OZAWA", "KITO", "KIRISIMA", "KLINSMAN", "KOMIYAMA", "CARTER", "ONIGASIM", "JACK", "IGARASI", "DEADBOY", "TAKI", "KLERK", "NAGAI", "OKOUCHI", "KAMIYAMA", "MITUI", "CARPACCI", "EBINUMA", "MUGURUMA", "ISAKA", "TATIBANA", "L0NG", "BACARO", "DONJU", "TATU", "BIGDANDY", "MIYAMA", "ISIGURO", "HIYAMA", "SOLDADOF", "TANIGUTI", "MEDEROS", "UEMATU", "ZEFARL", "CHO", "KEN", "SAKOTA", "TAKEO", "LOYD", "WOODS", "USUI", "HIGUCHI", "ANZAI", "FUJISIRO", "ETHAN", "ARSAN", "TAGEBINUMA", "TAGSOLDADOF", "TAGHIYAMA", "TAGHATAE", "TAGJINNO", "IF_TAMASHIRO", "IF_KANDA", "IF_MAJIMA", "IF_LAU", "IF_KAZAMA", "IF_KIRYU", "K_DESHI1", "K_DESHI2", "K_DESHI3", "K_DESHI4", "BATSU", "AKITSU", "KOHTARO", "ODA_HASBAND", "ODA_WIFE", "SHOO", "TETSUJI", "HASUTANI", "KURENAI", "KENGO", "ZEN", "TOKOYAMI", "SENTETSTU", "LORENTZ", "SAMEJIMA", "YUTO", "ISSEN", "GOUREN", "EGAMI", "SHINZAKI", "ARASE", "HITOJITI", "NIGE", "TOSENBO", "KOTEI", "GOWAN", "HITAMN", "DEBU_BOXER", "DANBIRA", "PROTECTOR", "KARATE", "TAKEO_SEICHO", "TATIBANA_SEICHO", "BACARO_SEICHO", "DONJU_SEICHO", "TATU_SEICHO", "BIGDANDY_SEICHO", "SAKOTO_SEICHO", "UEMATU_SEICHO", "MITUI_SEICHO", "MENDEROS_SEICHO", "RIKKY", "AMON", "MIKIO", "HAMASAKI", "BOMBER_TEARGAS", "BOMBER_SMOKE", "BOMBER_FLASH", "BOMBER_LITNNG" });
            AIComboBox.Location = new Point(138, 333);
            AIComboBox.Name = "AIComboBox";
            AIComboBox.Size = new Size(257, 23);
            AIComboBox.TabIndex = 13;
            AIComboBox.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(138, 315);
            label5.Name = "label5";
            label5.Size = new Size(18, 15);
            label5.TabIndex = 14;
            label5.Text = "AI";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(138, 359);
            label6.Name = "label6";
            label6.Size = new Size(58, 15);
            label6.TabIndex = 16;
            label6.Text = "NPC Type";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // NPCTypeComboBox
            // 
            NPCTypeComboBox.AutoCompleteCustomSource.AddRange(new string[] { "Player", "Goon", "Follower", "Boss", "Mannequin" });
            NPCTypeComboBox.FormattingEnabled = true;
            NPCTypeComboBox.Items.AddRange(new object[] { "Player", "Goon", "Follower", "Boss", "Mannequin" });
            NPCTypeComboBox.Location = new Point(138, 377);
            NPCTypeComboBox.Name = "NPCTypeComboBox";
            NPCTypeComboBox.Size = new Size(257, 23);
            NPCTypeComboBox.TabIndex = 15;
            NPCTypeComboBox.SelectedIndexChanged += NPCTypeComboBox_SelectedIndexChanged;
            // 
            // heightTrackBar
            // 
            heightTrackBar.Location = new Point(401, 259);
            heightTrackBar.Maximum = 255;
            heightTrackBar.Name = "heightTrackBar";
            heightTrackBar.Size = new Size(104, 45);
            heightTrackBar.TabIndex = 17;
            heightTrackBar.Scroll += heightTrackBar_Scroll;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(401, 241);
            label7.Name = "label7";
            label7.Size = new Size(43, 15);
            label7.TabIndex = 19;
            label7.Text = "Height";
            label7.Click += label7_Click;
            // 
            // damageTrackBar
            // 
            damageTrackBar.Location = new Point(401, 325);
            damageTrackBar.Maximum = 255;
            damageTrackBar.Name = "damageTrackBar";
            damageTrackBar.Size = new Size(104, 45);
            damageTrackBar.TabIndex = 21;
            damageTrackBar.Scroll += damageTrackBar_Scroll;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(401, 307);
            label9.Name = "label9";
            label9.Size = new Size(51, 15);
            label9.TabIndex = 22;
            label9.Text = "Damage";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(138, 271);
            label10.Name = "label10";
            label10.Size = new Size(64, 15);
            label10.TabIndex = 23;
            label10.Text = "Voice Bank";
            label10.TextAlign = ContentAlignment.TopCenter;
            // 
            // xTextBox
            // 
            xTextBox.Location = new Point(405, 109);
            xTextBox.Name = "xTextBox";
            xTextBox.Size = new Size(100, 23);
            xTextBox.TabIndex = 26;
            xTextBox.TextChanged += xTextBox_TextChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(405, 91);
            label11.Name = "label11";
            label11.Size = new Size(14, 15);
            label11.TabIndex = 25;
            label11.Text = "X";
            // 
            // zTextBox
            // 
            zTextBox.Location = new Point(617, 109);
            zTextBox.Name = "zTextBox";
            zTextBox.Size = new Size(100, 23);
            zTextBox.TabIndex = 28;
            zTextBox.TextChanged += zTextBox_TextChanged;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(617, 91);
            label12.Name = "label12";
            label12.Size = new Size(14, 15);
            label12.TabIndex = 27;
            label12.Text = "Z";
            // 
            // yTextBox
            // 
            yTextBox.Location = new Point(511, 109);
            yTextBox.Name = "yTextBox";
            yTextBox.Size = new Size(100, 23);
            yTextBox.TabIndex = 30;
            yTextBox.TextChanged += yTextBox_TextChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(511, 91);
            label13.Name = "label13";
            label13.Size = new Size(14, 15);
            label13.TabIndex = 29;
            label13.Text = "Y";
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(405, 179);
            label14.Name = "label14";
            label14.Size = new Size(42, 15);
            label14.TabIndex = 31;
            label14.Text = "Health";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(405, 135);
            label15.Name = "label15";
            label15.Size = new Size(62, 15);
            label15.TabIndex = 33;
            label15.Text = "Rotation Y";
            // 
            // label16
            // 
            label16.AutoSize = true;
            label16.Location = new Point(511, 135);
            label16.Name = "label16";
            label16.Size = new Size(37, 15);
            label16.TabIndex = 35;
            label16.Text = "Unk 1";
            // 
            // label17
            // 
            label17.AutoSize = true;
            label17.Location = new Point(617, 135);
            label17.Name = "label17";
            label17.Size = new Size(37, 15);
            label17.TabIndex = 37;
            label17.Text = "Unk 2";
            // 
            // label18
            // 
            label18.AutoSize = true;
            label18.Location = new Point(511, 179);
            label18.Name = "label18";
            label18.Size = new Size(27, 15);
            label18.TabIndex = 39;
            label18.Text = "EXP";
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(511, 223);
            label19.Name = "label19";
            label19.Size = new Size(37, 15);
            label19.TabIndex = 43;
            label19.Text = "Unk 5";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Location = new Point(617, 179);
            label20.Name = "label20";
            label20.Size = new Size(37, 15);
            label20.TabIndex = 41;
            label20.Text = "Unk 4";
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(511, 267);
            label21.Name = "label21";
            label21.Size = new Size(37, 15);
            label21.TabIndex = 47;
            label21.Text = "Unk 7";
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(617, 223);
            label22.Name = "label22";
            label22.Size = new Size(37, 15);
            label22.TabIndex = 45;
            label22.Text = "Unk 6";
            // 
            // addButton
            // 
            addButton.Location = new Point(67, 62);
            addButton.Name = "addButton";
            addButton.Size = new Size(65, 23);
            addButton.TabIndex = 49;
            addButton.Text = "Add";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += button1_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(12, 62);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(59, 23);
            deleteButton.TabIndex = 50;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += button3_Click;
            // 
            // groupBox2
            // 
            groupBox2.Location = new Point(555, 398);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(8, 8);
            groupBox2.TabIndex = 52;
            groupBox2.TabStop = false;
            groupBox2.Text = "groupBox2";
            // 
            // voiceTextBox
            // 
            voiceTextBox.Location = new Point(138, 289);
            voiceTextBox.Name = "voiceTextBox";
            voiceTextBox.Size = new Size(257, 23);
            voiceTextBox.TabIndex = 53;
            voiceTextBox.ValueChanged += voiceTextBox_ValueChanged_1;
            // 
            // saveFile
            // 
            saveFile.Location = new Point(713, 10);
            saveFile.Name = "saveFile";
            saveFile.Size = new Size(75, 23);
            saveFile.TabIndex = 54;
            saveFile.Text = "Save File";
            saveFile.TextImageRelation = TextImageRelation.ImageAboveText;
            saveFile.UseVisualStyleBackColor = true;
            saveFile.Click += button4_Click;
            // 
            // rotYTextBox
            // 
            rotYTextBox.Location = new Point(405, 154);
            rotYTextBox.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            rotYTextBox.Name = "rotYTextBox";
            rotYTextBox.Size = new Size(100, 23);
            rotYTextBox.TabIndex = 55;
            rotYTextBox.ValueChanged += rotYTextBox_ValueChanged;
            // 
            // unk1TextBox
            // 
            unk1TextBox.Location = new Point(511, 153);
            unk1TextBox.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            unk1TextBox.Name = "unk1TextBox";
            unk1TextBox.Size = new Size(100, 23);
            unk1TextBox.TabIndex = 56;
            unk1TextBox.ValueChanged += unk1TextBox_ValueChanged;
            // 
            // unk2TextBox
            // 
            unk2TextBox.Location = new Point(617, 153);
            unk2TextBox.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            unk2TextBox.Name = "unk2TextBox";
            unk2TextBox.Size = new Size(100, 23);
            unk2TextBox.TabIndex = 57;
            unk2TextBox.ValueChanged += unk2TextBox_ValueChanged;
            // 
            // healthTextBox
            // 
            healthTextBox.Location = new Point(405, 198);
            healthTextBox.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            healthTextBox.Name = "healthTextBox";
            healthTextBox.Size = new Size(100, 23);
            healthTextBox.TabIndex = 58;
            healthTextBox.ValueChanged += healthTextBox_ValueChanged;
            // 
            // unk3TextBox
            // 
            unk3TextBox.Location = new Point(511, 197);
            unk3TextBox.Maximum = new decimal(new int[] { 65535, 0, 0, 0 });
            unk3TextBox.Name = "unk3TextBox";
            unk3TextBox.Size = new Size(100, 23);
            unk3TextBox.TabIndex = 59;
            unk3TextBox.ValueChanged += unk3TextBox_ValueChanged;
            // 
            // unk4TextBox
            // 
            unk4TextBox.Location = new Point(617, 198);
            unk4TextBox.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            unk4TextBox.Name = "unk4TextBox";
            unk4TextBox.Size = new Size(100, 23);
            unk4TextBox.TabIndex = 60;
            unk4TextBox.ValueChanged += unk4TextBox_ValueChanged;
            // 
            // unk5TextBox
            // 
            unk5TextBox.Location = new Point(511, 242);
            unk5TextBox.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            unk5TextBox.Name = "unk5TextBox";
            unk5TextBox.Size = new Size(100, 23);
            unk5TextBox.TabIndex = 61;
            unk5TextBox.ValueChanged += unk5TextBox_ValueChanged;
            // 
            // unk6TextBox
            // 
            unk6TextBox.Location = new Point(617, 242);
            unk6TextBox.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            unk6TextBox.Name = "unk6TextBox";
            unk6TextBox.Size = new Size(100, 23);
            unk6TextBox.TabIndex = 62;
            unk6TextBox.ValueChanged += unk6TextBox_ValueChanged;
            // 
            // unk7TextBox
            // 
            unk7TextBox.Location = new Point(511, 285);
            unk7TextBox.Maximum = new decimal(new int[] { 255, 0, 0, 0 });
            unk7TextBox.Name = "unk7TextBox";
            unk7TextBox.Size = new Size(100, 23);
            unk7TextBox.TabIndex = 63;
            unk7TextBox.ValueChanged += unk7TextBox_ValueChanged;
            // 
            // copyButton
            // 
            copyButton.Location = new Point(67, 39);
            copyButton.Name = "copyButton";
            copyButton.Size = new Size(65, 23);
            copyButton.TabIndex = 64;
            copyButton.Text = "Copy";
            copyButton.UseVisualStyleBackColor = true;
            copyButton.Click += copyButton_Click;
            // 
            // refreshButton
            // 
            refreshButton.Location = new Point(12, 39);
            refreshButton.Name = "refreshButton";
            refreshButton.Size = new Size(59, 23);
            refreshButton.TabIndex = 66;
            refreshButton.Text = "Refresh";
            refreshButton.UseVisualStyleBackColor = true;
            refreshButton.Click += button1_Click_1;
            // 
            // flags1Label
            // 
            flags1Label.AutoSize = true;
            flags1Label.Location = new Point(138, 21);
            flags1Label.Name = "flags1Label";
            flags1Label.Size = new Size(51, 15);
            flags1Label.TabIndex = 67;
            flags1Label.Text = "Flags (1)";
            flags1Label.Click += label23_Click;
            // 
            // flags2Label
            // 
            flags2Label.AutoSize = true;
            flags2Label.Location = new Point(357, 21);
            flags2Label.Name = "flags2Label";
            flags2Label.Size = new Size(51, 15);
            flags2Label.TabIndex = 69;
            flags2Label.Text = "Flags (2)";
            // 
            // flags3Label
            // 
            flags3Label.AutoSize = true;
            flags3Label.Location = new Point(582, 22);
            flags3Label.Name = "flags3Label";
            flags3Label.Size = new Size(51, 15);
            flags3Label.TabIndex = 71;
            flags3Label.Text = "Flags (3)";
            // 
            // flags1TextBox
            // 
            flags1TextBox.Location = new Point(138, 41);
            flags1TextBox.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            flags1TextBox.Name = "flags1TextBox";
            flags1TextBox.Size = new Size(213, 23);
            flags1TextBox.TabIndex = 73;
            flags1TextBox.ValueChanged += flags1TextBox_ValueChanged;
            // 
            // flags2TextBox
            // 
            flags2TextBox.Location = new Point(357, 41);
            flags2TextBox.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            flags2TextBox.Name = "flags2TextBox";
            flags2TextBox.Size = new Size(219, 23);
            flags2TextBox.TabIndex = 73;
            flags2TextBox.ValueChanged += flags2TextBox_ValueChanged;
            // 
            // flags3TextBox
            // 
            flags3TextBox.Location = new Point(582, 41);
            flags3TextBox.Maximum = new decimal(new int[] { -1, 0, 0, 0 });
            flags3TextBox.Name = "flags3TextBox";
            flags3TextBox.Size = new Size(206, 23);
            flags3TextBox.TabIndex = 73;
            flags3TextBox.ValueChanged += flags3TextBox_ValueChanged;
            // 
            // weaponTextBox
            // 
            weaponTextBox.Location = new Point(138, 197);
            weaponTextBox.MaxLength = 9;
            weaponTextBox.Name = "weaponTextBox";
            weaponTextBox.Size = new Size(257, 23);
            weaponTextBox.TabIndex = 74;
            weaponTextBox.TextChanged += weaponTextBox_TextChanged_1;
            // 
            // aiComboBoxY4
            // 
            aiComboBoxY4.FormattingEnabled = true;
            aiComboBoxY4.Items.AddRange(new object[] { "KIRYU", "AKIYAMA", "SAEJIMA", "TANIMURA", "SUDE", "SUDE_SOUL", "GANG", "GOTSUI", "GOTSUI_SOUL", "DEBU", "BOXER", "BOXER_SOUL", "KICKBOXER", "JAKA", "NIGE", "TOSENBO", "KOTEI", "GOWAN", "HITMAN", "DEBU_BOXER", "DANBIRA", "PROTECTOR", "KARATE", "BOMBER_TEARGAS", "BOMBER_SMOKE", "BOMBER_FLASH", "BOMBER_LITNNG", "TSUKAMI", "BAT", "SNIPER", "ZOMBIE", "KENKA", "PUNCH", "SAT", "MAJIMA", "IHARA", "SAITO", "MIDORIKAWA", "MINAMI", "IWAN", "SUGIUTI", "KIDO", "ARAI", "MAJIMA_SOUL", "DAIGO", "MUNAKATA", "SHIBATA_KATANA", "SHIBATA_JUU", "EN_KIRYU", "EN_AKIYAMA", "EN_SAEJIMA", "EN_TANIMURA", "KASAI", "AYASAKI", "TOYOSAKI", "MIKOSIBA", "HORIE", "NAKANOWATARI", "SUZUMIYA", "IJUUIN", "ONITAKE", "HIDE", "BIG_KID", "KING_J", "MR_PURPLE", "DAIKOKUIN", "DJ_BLACK", "DOKUGUMO", "ANKOKUOU", "ANKOKUSIN", "AMON1", "AMON2", "AMON3", "AMON4", "MIC_MINAMI", "CHASER", "NAIRU", "NAIRU_NPC", "SENNIN", "GG", "SAIGOU", "HANA", "NPC_KIRYU", "NPC_AKIYAMA", "NPC_SAEJIMA", "NPC_TANIMURA", "NPC_AKAISI", "NPC_HAMASAKI", "NPC_SUKEKAWA", "GARRET", "KOMAKI", "INZEN", "BRAGS", "WAIWAT", "OTAKI", "YONASIRO", "WADE", "YAMAMOTO", "NISIKAWA", "BARHEART", "OZAWA", "KITO", "KLINSMAN", "BLOODER", "CARTER", "ONIGASIMA", "JACK", "HIKKY", "DEADBOY", "KAMIYAMA", "MITUI", "CARPACCIO", "EBINUMA", "MUGURUMA", "ISAKA", "TATIBANA", "KAMATA", "BACARO", "DONJU", "TATU", "SAWAI", "KARIYA", "UEMATU", "CHO", "HIROYUKI", "WOODS", "USUI", "HIGUCHI", "ETHAN", "ARSAN", "YAMAOKA", "KUROKAWA", "ADABANA", "GINGA", "REIJI", "HIMURO", "KUROTAKA", "ROBIN", "UTAMARO", "ALBERT", "JAON", "CHEN", "KAWASAKI", "KINTARO", "WILLIAM", "SIBUSAWA", "JOE", "HIROYUKI_SEICHO", "WILLIAM_SEICHO", "TATU_SEICHO", "JOE_SEICHO", "MITUI_SEICHO", "IF_MAJIMA", "IF_KIRYU", "IF_AKIYAMA", "IF_SAEJIMA", "IF_TANIMURA", "IF_IHARA", "IF_MIDORIKAWA", "IF_SAITO", "IF_MINAMI", "IF_SUGIUTI", "OCHIAI_IKUSEI", "SUGIYAMA_IKUSEI", "EHAMA_IKUSEI", "OTOKITA_IKUSEI", "WATANABE_IKUSEI", "IKUSEI_KENKA", "IKUSEI_GOTUI", "IKUSEI_BOXER", "IKUSEI_KICK", "IKUSEI_WRESTLER", "IKUSEI_KARATE", "IKUSEI_GIKOU", "IKUSEI_DAGEKI", "NPC_GOEI", "NPC_KOTARO", "NPC_NERAWARE" });
            aiComboBoxY4.Location = new Point(138, 333);
            aiComboBoxY4.Name = "aiComboBoxY4";
            aiComboBoxY4.Size = new Size(257, 23);
            aiComboBoxY4.TabIndex = 75;
            aiComboBoxY4.SelectedIndexChanged += aiComboBoxY4_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(aiComboBoxY4);
            Controls.Add(weaponTextBox);
            Controls.Add(flags3TextBox);
            Controls.Add(flags2TextBox);
            Controls.Add(flags1TextBox);
            Controls.Add(flags3Label);
            Controls.Add(flags2Label);
            Controls.Add(flags1Label);
            Controls.Add(refreshButton);
            Controls.Add(copyButton);
            Controls.Add(unk7TextBox);
            Controls.Add(unk6TextBox);
            Controls.Add(unk5TextBox);
            Controls.Add(unk4TextBox);
            Controls.Add(unk3TextBox);
            Controls.Add(healthTextBox);
            Controls.Add(unk2TextBox);
            Controls.Add(unk1TextBox);
            Controls.Add(rotYTextBox);
            Controls.Add(saveFile);
            Controls.Add(voiceTextBox);
            Controls.Add(groupBox2);
            Controls.Add(deleteButton);
            Controls.Add(addButton);
            Controls.Add(label21);
            Controls.Add(label22);
            Controls.Add(label19);
            Controls.Add(label20);
            Controls.Add(label18);
            Controls.Add(label17);
            Controls.Add(label16);
            Controls.Add(label15);
            Controls.Add(label14);
            Controls.Add(yTextBox);
            Controls.Add(label13);
            Controls.Add(zTextBox);
            Controls.Add(label12);
            Controls.Add(xTextBox);
            Controls.Add(label11);
            Controls.Add(label10);
            Controls.Add(label9);
            Controls.Add(damageTrackBar);
            Controls.Add(label7);
            Controls.Add(heightTrackBar);
            Controls.Add(label6);
            Controls.Add(NPCTypeComboBox);
            Controls.Add(label5);
            Controls.Add(AIComboBox);
            Controls.Add(btlStartTextBox);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(modelNameTextBox);
            Controls.Add(label2);
            Controls.Add(nameTextBox);
            Controls.Add(label1);
            Controls.Add(listBox1);
            Controls.Add(button2);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "Ally Recycler";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)heightTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)damageTrackBar).EndInit();
            ((System.ComponentModel.ISupportInitialize)voiceTextBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)rotYTextBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)unk1TextBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)unk2TextBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)healthTextBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)unk3TextBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)unk4TextBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)unk5TextBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)unk6TextBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)unk7TextBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)flags1TextBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)flags2TextBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)flags3TextBox).EndInit();
            ResumeLayout(false);
            PerformLayout();
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
        private Label flags2Label;
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
        private Button refreshButton;
        private Label flags1Label;
        private Label flags3Label;
        private NumericUpDown flags1TextBox;
        private NumericUpDown flags2TextBox;
        private NumericUpDown flags3TextBox;
        private TextBox weaponTextBox;
        private ComboBox aiComboBoxY4;
    }
}