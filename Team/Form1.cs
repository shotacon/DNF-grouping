using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Team
{
    public partial class Form1 : Form
    {
        Dictionary<string, int> nameMap = new Dictionary<string, int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void box_name_Enter(object sender, EventArgs e)
        {
        }

        private void box_name_Leave(object sender, EventArgs e)
        {
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void box_name_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13 || e.KeyChar == 108)
            {
                addName();
            }
        }

        private void addName()
        {
            String names = box_name.Text.Trim().Replace("，", ",");
            if (names.Contains(","))
            {
                String[] nameArray = names.Split(',');
                foreach (String name in nameArray)
                {
                    addNameToBox(name);
                }
            }
            else
            {
                addNameToBox(names);
            }
            clearBox();
        }

        private void addNameToBox(String name)
        {
            if (!nameMap.ContainsKey(name))
            {
                listBox_player.Items.Add(name);
                nameMap.Add(name, 0);
            }
        }

        private void clearBox()
        {
            box_name.Clear();
        }

        private void btn_add_Click(object sender, EventArgs e)
        {
            addName();
        }

        private void listBox_player_DoubleClick(object sender, EventArgs e)
        {
            int index = listBox_player.SelectedIndex;
            String name = listBox_player.Items[index].ToString();
            nameMap.Remove(name);
            listBox_player.Items.RemoveAt(index);
        }

        private void btn_add_Click_1(object sender, EventArgs e)
        {
            addName();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            listBox_player.Items.Clear();
            nameMap.Clear();
            listBox_red.Items.Clear();
            listBox_blue.Items.Clear();
        }

        private void btn_packet_Click(object sender, EventArgs e)
        {
            if (nameMap.Count % 2 != 0)
            {
                return;
            }
            listBox_red.Items.Clear();
            listBox_blue.Items.Clear();

            int c = nameMap.Count / 2;
            Random random = new Random();
            List<String> newList = new List<String>();
            foreach (String name in nameMap.Keys)
            {
                newList.Insert(random.Next(newList.Count + 1), name);
            }
            foreach (String name in newList.GetRange(0, c))
            {
                listBox_red.Items.Add(name);
            }
            foreach (String name in newList.GetRange(c, nameMap.Count - c))
            {
                listBox_blue.Items.Add(name);
            }
        }

        private void integralMsg(String msg)
        {
            String time = DateTime.Now.ToUniversalTime().ToString();
            listBox_integral.Items.Add(time + ": " + msg);
        }

        private void btn_red_win_Click(object sender, EventArgs e)
        {
            win(true);
        }

        private void win(Boolean isRedWin)
        {
            int redCount = listBox_red.Items.Count;
            int blueCount = listBox_blue.Items.Count;
            if (redCount - blueCount != 0)
            {
                return;
            }

            if (isRedWin)
            {
                integralMsg("红队胜利! 队员: " + doMsg(listBox_red.Items) + " 积分 +1 ~");
            }
            else
            {
                integralMsg("蓝队胜利! 队员: " + doMsg(listBox_blue.Items) + " 积分 +1 ~");
            }

            listView_rank.BeginUpdate();
            listView_rank.Items.Clear();
            List<KeyValuePair<string, int>> list = DictionarySort(nameMap);
            for (int i = 0; i < list.Count(); i++)
            {
                KeyValuePair<string, int> map = list[i];
                ListViewItem item = new ListViewItem();
                item.Text = (i + 1) + "";
                item.SubItems.Add(map.Key);
                item.SubItems.Add(map.Value + "");
                listView_rank.Items.Add(item);
            }
            listView_rank.EndUpdate();
        }

        private String doMsg(ListBox.ObjectCollection items)
        {
            String msg = "";
            foreach (String name in items)
            {
                msg += name + ",";
                int score = nameMap[name];
                nameMap[name] = score + 1;
            }
            return msg;
        }

        private List<KeyValuePair<string, int>> DictionarySort(Dictionary<string, int> dic)
        {
            if (dic.Count > 0)
            {
                List<KeyValuePair<string, int>> lst = new List<KeyValuePair<string, int>>(dic);
                lst.Sort(delegate (KeyValuePair<string, int> s1, KeyValuePair<string, int> s2)
                {
                    return s2.Value.CompareTo(s1.Value);
                });
                return lst;
            }
            return null;
        }

        private void 清空ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listView_rank.Items.Clear();
        }

        private void btn_blue_win_Click(object sender, EventArgs e)
        {
            win(false);
        }

        private void 清空ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            listBox_integral.Items.Clear();
        }

        private void listView_rank_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
