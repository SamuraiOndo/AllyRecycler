using fileio;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System;
using System.Text;

namespace EnemyDispose
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            var filePath = openFileDialog1.FileName;
            byte[] ba = Encoding.Default.GetBytes(filePath);
            Debug.WriteLine(Convert.ToHexString(ba));
            listBox1.Items.Clear();
            if (!((string)filePath).Equals("openFileDialog1"))
            {
                file.ReadFile((string)filePath);
                for (int i = 0; i < file.headerData.count; i++)
                {
                    listBox1.Items.Add(file.enemyDisposeNodes[i].name);
                }
                listBox1.Show();
                flags1TextBox.Value = file.headerData.flags1;
                flags2TextBox.Value = file.headerData.flags2;
                flags3TextBox.Value = file.headerData.flags3;
            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                nameTextBox.Text = file.enemyDisposeNodes[listBox1.SelectedIndex].name;
                modelNameTextBox.Text = file.enemyDisposeNodes[listBox1.SelectedIndex].modelName;
                weaponTextBox.Text = file.enemyDisposeNodes[listBox1.SelectedIndex].weapon;
                btlStartTextBox.Text = file.enemyDisposeNodes[listBox1.SelectedIndex].btl_st;
                voiceTextBox.Text = file.enemyDisposeNodes[listBox1.SelectedIndex].voiceBank.ToString();
                if (!file.headerData.isYakuza4)
                {
                    AIComboBox.SelectedIndex = (int)file.enemyDisposeNodes[listBox1.SelectedIndex].aiPreset;
                    aiComboBoxY4.Hide();
                }
                else
                {
                    aiComboBoxY4.SelectedIndex = (int)file.enemyDisposeNodes[listBox1.SelectedIndex].aiPreset;
                    AIComboBox.Hide();
                }
                NPCTypeComboBox.SelectedIndex = (int)file.enemyDisposeNodes[listBox1.SelectedIndex].type - 1;
                xTextBox.Text = file.enemyDisposeNodes[listBox1.SelectedIndex].X.ToString();
                zTextBox.Text = file.enemyDisposeNodes[listBox1.SelectedIndex].Z.ToString();
                yTextBox.Text = file.enemyDisposeNodes[listBox1.SelectedIndex].Y.ToString();
                healthTextBox.Text = file.enemyDisposeNodes[listBox1.SelectedIndex].health.ToString();
                rotYTextBox.Text = file.enemyDisposeNodes[listBox1.SelectedIndex].rotY.ToString();
                unk1TextBox.Text = file.enemyDisposeNodes[listBox1.SelectedIndex].unk1.ToString();
                unk2TextBox.Text = file.enemyDisposeNodes[listBox1.SelectedIndex].unk2.ToString();
                unk3TextBox.Text = file.enemyDisposeNodes[listBox1.SelectedIndex].unk3.ToString();
                unk5TextBox.Text = file.enemyDisposeNodes[listBox1.SelectedIndex].unk5.ToString();
                unk4TextBox.Text = file.enemyDisposeNodes[listBox1.SelectedIndex].unk4.ToString();
                unk7TextBox.Text = file.enemyDisposeNodes[listBox1.SelectedIndex].unk7.ToString();
                unk6TextBox.Text = file.enemyDisposeNodes[listBox1.SelectedIndex].unk6.ToString();
                heightTrackBar.Value = (int)file.enemyDisposeNodes[listBox1.SelectedIndex].height;
                damageTrackBar.Value = (int)file.enemyDisposeNodes[listBox1.SelectedIndex].damage;
            }

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            file.enemyDisposeNodes[listBox1.SelectedIndex].btl_st = btlStartTextBox.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            file.enemyDisposeNodes[listBox1.SelectedIndex].aiPreset = Convert.ToByte(AIComboBox.SelectedIndex);
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            file.enemyDisposeNodes.Add(new EnemyDisposeData());
            file.headerData.count += 1;
            for (int i = 0; i < file.headerData.count; i++)
            {
                listBox1.Items.Add(file.enemyDisposeNodes[i].name);
            }
        }

        private void voiceTextBox_ValueChanged(object sender, EventArgs e)
        {
            file.enemyDisposeNodes[listBox1.SelectedIndex].voiceBank = Convert.ToByte(voiceTextBox.Value);
        }

        private void voiceTextBox_ValueChanged_1(object sender, EventArgs e)
        {
            file.enemyDisposeNodes[listBox1.SelectedIndex].voiceBank = Convert.ToByte(voiceTextBox.Value);
        }

        private void nameTextBox_TextChanged(object sender, EventArgs e)
        {
            file.enemyDisposeNodes[listBox1.SelectedIndex].name = nameTextBox.Text;
        }

        private void xTextBox_TextChanged(object sender, EventArgs e)
        {
            file.enemyDisposeNodes[listBox1.SelectedIndex].X = Convert.ToSingle(xTextBox.Text);
        }

        private void yTextBox_TextChanged(object sender, EventArgs e)
        {
            file.enemyDisposeNodes[listBox1.SelectedIndex].Y = Convert.ToSingle(yTextBox.Text);
        }

        private void zTextBox_TextChanged(object sender, EventArgs e)
        {
            file.enemyDisposeNodes[listBox1.SelectedIndex].Z = Convert.ToSingle(zTextBox.Text);
        }

        private void modelNameTextBox_TextChanged(object sender, EventArgs e)
        {
            file.enemyDisposeNodes[listBox1.SelectedIndex].modelName = modelNameTextBox.Text;
        }

        private void rotYTextBox_TextChanged(object sender, EventArgs e)
        {
            file.enemyDisposeNodes[listBox1.SelectedIndex].rotY = Convert.ToUInt16(rotYTextBox.Value);
        }

        private void unk1TextBox_TextChanged(object sender, EventArgs e)
        {
            file.enemyDisposeNodes[listBox1.SelectedIndex].unk1 = Convert.ToUInt16(unk1TextBox.Text);
        }

        private void unk2TextBox_TextChanged(object sender, EventArgs e)
        {
            file.enemyDisposeNodes[listBox1.SelectedIndex].unk2 = Convert.ToUInt16(unk2TextBox.Text);
        }

        private void weaponTextBox_TextChanged(object sender, EventArgs e)
        {
            file.enemyDisposeNodes[listBox1.SelectedIndex].weapon = weaponTextBox.Text;
        }

        private void healthTextBox_TextChanged(object sender, EventArgs e)
        {
            file.enemyDisposeNodes[listBox1.SelectedIndex].health = Convert.ToUInt16(healthTextBox.Text);
        }

        private void unk3TextBox_TextChanged(object sender, EventArgs e)
        {
            file.enemyDisposeNodes[listBox1.SelectedIndex].unk3 = Convert.ToUInt16(unk3TextBox.Text);
        }

        private void unk4TextBox_TextChanged(object sender, EventArgs e)
        {
            file.enemyDisposeNodes[listBox1.SelectedIndex].unk4 = Convert.ToByte(unk4TextBox.Text);
        }

        private void heightTrackBar_Scroll(object sender, EventArgs e)
        {
            file.enemyDisposeNodes[listBox1.SelectedIndex].height = Convert.ToByte(heightTrackBar.Value);
        }

        private void unk5TextBox_TextChanged(object sender, EventArgs e)
        {
            file.enemyDisposeNodes[listBox1.SelectedIndex].unk5 = Convert.ToByte(unk5TextBox.Text);
        }

        private void unk6TextBox_TextChanged(object sender, EventArgs e)
        {
            file.enemyDisposeNodes[listBox1.SelectedIndex].unk6 = Convert.ToByte(unk6TextBox.Text);
        }

        private void unk7TextBox_TextChanged(object sender, EventArgs e)
        {
            file.enemyDisposeNodes[listBox1.SelectedIndex].unk7 = Convert.ToByte(unk7TextBox.Text);
        }

        private void damageTrackBar_Scroll(object sender, EventArgs e)
        {
            file.enemyDisposeNodes[listBox1.SelectedIndex].damage = Convert.ToByte(damageTrackBar.Value);

        }

        private void NPCTypeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            file.enemyDisposeNodes[listBox1.SelectedIndex].type = Convert.ToByte(NPCTypeComboBox.SelectedIndex + 1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            saveFileDialog1.ShowDialog();
            var filePath = saveFileDialog1.FileName;
            if (!((string)filePath).Equals(""))
            {
                file.saveFile((string)filePath);
            }

        }

        private void rotYTextBox_ValueChanged(object sender, EventArgs e)
        {
            file.enemyDisposeNodes[listBox1.SelectedIndex].rotY = Convert.ToUInt16(rotYTextBox.Value);
        }

        private void unk1TextBox_ValueChanged(object sender, EventArgs e)
        {
            file.enemyDisposeNodes[listBox1.SelectedIndex].unk1 = Convert.ToUInt16(unk1TextBox.Value);
        }

        private void unk2TextBox_ValueChanged(object sender, EventArgs e)
        {
            file.enemyDisposeNodes[listBox1.SelectedIndex].unk2 = Convert.ToUInt16(unk2TextBox.Value);
        }

        private void healthTextBox_ValueChanged(object sender, EventArgs e)
        {
            file.enemyDisposeNodes[listBox1.SelectedIndex].health = Convert.ToUInt16(healthTextBox.Value);
        }

        private void unk3TextBox_ValueChanged(object sender, EventArgs e)
        {
            file.enemyDisposeNodes[listBox1.SelectedIndex].unk3 = Convert.ToUInt16(unk3TextBox.Value);
        }

        private void unk4TextBox_ValueChanged(object sender, EventArgs e)
        {
            file.enemyDisposeNodes[listBox1.SelectedIndex].unk4 = Convert.ToByte(unk4TextBox.Value);
        }

        private void unk5TextBox_ValueChanged(object sender, EventArgs e)
        {
            file.enemyDisposeNodes[listBox1.SelectedIndex].unk5 = Convert.ToByte(unk5TextBox.Value);
        }

        private void unk6TextBox_ValueChanged(object sender, EventArgs e)
        {
            file.enemyDisposeNodes[listBox1.SelectedIndex].unk6 = Convert.ToByte(unk6TextBox.Value);
        }

        private void unk7TextBox_ValueChanged(object sender, EventArgs e)
        {
            file.enemyDisposeNodes[listBox1.SelectedIndex].unk7 = Convert.ToByte(unk7TextBox.Value);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                file.enemyDisposeNodes.RemoveAt(listBox1.SelectedIndex);
                listBox1.Items.Clear();
                file.headerData.count -= 1;
                for (int i = 0; i < file.headerData.count; i++)
                {
                    listBox1.Items.Add(file.enemyDisposeNodes[i].name);
                }
            }
        }

        private void copyButton_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedIndex != -1)
            {
                EnemyDisposeData newData = new EnemyDisposeData(file.enemyDisposeNodes[listBox1.SelectedIndex]);
                listBox1.Items.Clear();
                file.enemyDisposeNodes.Add(newData);
                file.headerData.count += 1;
                for (int i = 0; i < file.headerData.count; i++)
                {
                    listBox1.Items.Add(file.enemyDisposeNodes[i].name);
                }
            }
        }

        private void weaponTextBox_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < file.headerData.count; i++)
            {
                listBox1.Items.Add(file.enemyDisposeNodes[i].name);
            }
            listBox1.Show();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private void flags1TextBox_ValueChanged(object sender, EventArgs e)
        {
            file.headerData.flags1 = Convert.ToUInt32(flags1TextBox.Value);
        }

        private void flags2TextBox_ValueChanged(object sender, EventArgs e)
        {
            file.headerData.flags2 = Convert.ToUInt32(flags2TextBox.Value);
        }

        private void flags3TextBox_ValueChanged(object sender, EventArgs e)
        {
            file.headerData.flags3 = Convert.ToUInt32(flags3TextBox.Value);
        }

        private void weaponTextBox_TextChanged_1(object sender, EventArgs e)
        {
            file.enemyDisposeNodes[listBox1.SelectedIndex].weapon = weaponTextBox.Text;
        }

        private void aiComboBoxY4_SelectedIndexChanged(object sender, EventArgs e)
        {
            file.enemyDisposeNodes[listBox1.SelectedIndex].aiPreset = Convert.ToByte(aiComboBoxY4.SelectedIndex);

        }
    }
}
