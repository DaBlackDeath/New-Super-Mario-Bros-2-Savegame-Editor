using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace New_Super_Mario_Bros_2_Savegame_Editor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public string savegame;
        public int moneyall;
        public static byte[] BLKDTH_StringToByteArray(string hex)
        {
            return Enumerable.Range(0, hex.Length)
                             .Where(x => x % 2 == 0)
                             .Select(x => Convert.ToByte(hex.Substring(x, 2), 16))
                             .ToArray();

        }
        
        private void BLKDTH_get_openfile()
        {
            OpenFileDialog openFD = new OpenFileDialog();
            if (openFD.ShowDialog() == DialogResult.OK)
            {
                savegame = openFD.FileName;
            }
        }

        private void BLKDTH_get_data()
        {

            {
                FileStream savegame_fs = new FileStream(savegame, FileMode.Open);
                BinaryReader savegame_br = new BinaryReader(savegame_fs);
                long length = savegame_fs.Length;
                // money
                savegame_br.BaseStream.Position = 0x1F18;
                byte[] money = savegame_br.ReadBytes(4);
                int moneyall = BitConverter.ToInt32(money, 0);
                box_money.Text = (moneyall.ToString());
                // lives save 1
                savegame_br.BaseStream.Position = 0x1C;
                byte[] lives1 = savegame_br.ReadBytes(4);
                int f1l = BitConverter.ToInt16(lives1, 0);
                box_file1_lives.Text = (f1l.ToString());
                // star coins save 1
                savegame_br.BaseStream.Position = 0x24;
                byte[] scoins1 = savegame_br.ReadBytes(4);
                int f1c = BitConverter.ToInt16(scoins1, 0);
                box_file1_coins.Text = (f1c.ToString());
                // lives save 2
                savegame_br.BaseStream.Position = 0xA70;
                byte[] lives2 = savegame_br.ReadBytes(4);
                int f2l = BitConverter.ToInt16(lives2, 0);
                box_file2_lives.Text = (f2l.ToString());
                // star coins save 2
                savegame_br.BaseStream.Position = 0xA78;
                byte[] scoins2 = savegame_br.ReadBytes(4);
                int f2c = BitConverter.ToInt16(scoins2, 0);
                box_file2_coins.Text = (f2c.ToString());
                // lives save 3
                savegame_br.BaseStream.Position = 0x14C4;
                byte[] lives3 = savegame_br.ReadBytes(4);
                int f3l = BitConverter.ToInt16(lives3, 0);
                box_file3_lives.Text = (f3l.ToString());
                // star coins save 3
                savegame_br.BaseStream.Position = 0x14CC;
                byte[] scoins3 = savegame_br.ReadBytes(4);
                int f3c = BitConverter.ToInt16(scoins3, 0);
                box_file3_coins.Text = (f3c.ToString());
                savegame_br.Close();
            }

        }
        private void BLKDTH_set_data()
        {
            FileStream update_save_open = null;
            BinaryWriter update_save_write = null;
            update_save_open = new System.IO.FileStream(savegame, System.IO.FileMode.OpenOrCreate);
            update_save_write = new System.IO.BinaryWriter(update_save_open);

            #region data

            byte[] money = BLKDTH_StringToByteArray(int.Parse(box_money.Text).ToString("X8"));
            Array.Reverse(money);
            update_save_open.Position = Convert.ToInt64("1F18", 16);
            update_save_write.Write(money);
                         
            byte[] f1_lives = BLKDTH_StringToByteArray(int.Parse(box_file1_lives.Text).ToString("X8"));
            Array.Reverse(f1_lives);
            update_save_open.Position = Convert.ToInt64("1C", 16);
            update_save_write.Write(f1_lives);

            byte[] f1_coins = BLKDTH_StringToByteArray(int.Parse(box_file1_coins.Text).ToString("X8"));
            Array.Reverse(f1_coins);
            update_save_open.Position = Convert.ToInt64("24", 16);
            update_save_write.Write(f1_coins);

            byte[] f2_lives = BLKDTH_StringToByteArray(int.Parse(box_file2_lives.Text).ToString("X8"));
            Array.Reverse(f2_lives);
            update_save_open.Position = Convert.ToInt64("A70", 16);
            update_save_write.Write(f2_lives);

            byte[] f2_coins = BLKDTH_StringToByteArray(int.Parse(box_file2_coins.Text).ToString("X8"));
            Array.Reverse(f2_coins);
            update_save_open.Position = Convert.ToInt64("A78", 16);
            update_save_write.Write(f2_coins);

            byte[] f3_lives = BLKDTH_StringToByteArray(int.Parse(box_file3_lives.Text).ToString("X8"));
            Array.Reverse(f3_lives);
            update_save_open.Position = Convert.ToInt64("14C4", 16);
            update_save_write.Write(f3_lives);

            byte[] f3_coins = BLKDTH_StringToByteArray(int.Parse(box_file3_coins.Text).ToString("X8"));
            Array.Reverse(f3_coins);
            update_save_open.Position = Convert.ToInt64("14CC", 16);
            update_save_write.Write(f3_coins);
            #endregion

            update_save_open.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            BLKDTH_get_openfile();
            if (string.IsNullOrEmpty(savegame))
            {
                MessageBox.Show("no savegame selected");
            }
            else
            {
                BLKDTH_get_data();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BLKDTH_set_data();
            MessageBox.Show("Data saved");
        }


    }
}
