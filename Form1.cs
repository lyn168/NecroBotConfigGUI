using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace NecroBot_Config_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        string src_auth = "Config/auth.json";
        string src_config = "Config/config.json";
        JObject obj_auth, obj_config;

        public void load()
        {
            try
            {
                //呈現於面板中
                #region 基本設定
                if (obj_auth["AuthConfig"]["AuthType"].ToString() == "google")
                {
                    google_ptc.SelectedIndex = 0;
                    username.Text = obj_auth["AuthConfig"]["GoogleUsername"].ToString();
                    passwd.Text = obj_auth["AuthConfig"]["GooglePassword"].ToString();
                }
                else
                {
                    google_ptc.SelectedIndex = 1;
                    username.Text = obj_auth["AuthConfig"]["PtcUsername"].ToString();
                    passwd.Text = obj_auth["AuthConfig"]["PtcPassword"].ToString();
                }
                lang.Text = obj_config["ConsoleSettings"]["TranslationLanguageCode"].ToString();
                if (bool.Parse(obj_config["UpdateSettings"]["AutoUpdate"].ToString()))
                {
                    update_open.Checked = true;
                }
                else
                {
                    update_close.Checked = true;
                }
                #endregion
                #region 座標設定
                La.Text = obj_config["LocationSettings"]["DefaultLatitude"].ToString();
                Lo.Text = obj_config["LocationSettings"]["DefaultLongitude"].ToString();
                if (bool.Parse(obj_config["LocationSettings"]["UseWalkingSpeedVariant"].ToString()))
                {
                    va_open.Checked = true;
                }
                else
                {
                    va_close.Checked = true;
                }
                speedvalue.Value = decimal.Parse(obj_config["LocationSettings"]["WalkingSpeedInKilometerPerHour"].ToString());
                #endregion
                #region 狙擊模式
                if (bool.Parse(obj_config["SnipingSettings"]["UseSnipeLocationServer"].ToString()))
                {
                    snpanel.Enabled = true;
                }
                else
                {
                    snpanel.Enabled = false;
                }
                if (bool.Parse(obj_config["SnipingSettings"]["GetSniperInfoFromPokezz"].ToString()))
                {
                    sniper_server_list.SetItemChecked(0, true);
                }
                if (bool.Parse(obj_config["SnipingSettings"]["GetOnlyVerifiedSniperInfoFromPokezz"].ToString()))
                {
                    sniper_server_list.SetItemChecked(1, true);
                }
                if (bool.Parse(obj_config["SnipingSettings"]["GetSniperInfoFromPokeSnipers"].ToString()))
                {
                    sniper_server_list.SetItemChecked(2, true);
                }
                if (bool.Parse(obj_config["SnipingSettings"]["GetSniperInfoFromPokeWatchers"].ToString()))
                {
                    sniper_server_list.SetItemChecked(3, true);
                }
                if (bool.Parse(obj_config["SnipingSettings"]["GetSniperInfoFromSkiplagged"].ToString()))
                {
                    sniper_server_list.SetItemChecked(4, true);
                }
                sniper_delay.Text = obj_config["SnipingSettings"]["MinDelayBetweenSnipes"].ToString();
                #endregion
            }
            catch { }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //讀取Json
            try
            {
                obj_auth = JsonConvert.DeserializeObject<JObject>(File.ReadAllText(Path.GetFullPath(src_auth)));
                obj_config = JsonConvert.DeserializeObject<JObject>(File.ReadAllText(Path.GetFullPath(src_config)));
            }
            catch
            {
                MessageBox.Show("檔案錯誤，請檢察檔案完整性與正確路徑");
                this.Close();
            }
            load();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("確定要離開？", "設定儲存了嗎？", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }   
        }

        private void sn_open_CheckedChanged(object sender, EventArgs e)
        {
            snpanel.Enabled = true;
        }

        private void sn_close_CheckedChanged(object sender, EventArgs e)
        {
            snpanel.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {   //基本設定
            obj_auth["AuthConfig"]["AuthType"] = google_ptc.Text;
            if (obj_auth["AuthConfig"]["AuthType"].ToString() == "google")
            {
                obj_auth["AuthConfig"]["GoogleUsername"] = username.Text;
                obj_auth["AuthConfig"]["GooglePassword"] = passwd.Text;
            }
            else if(obj_auth["AuthConfig"]["AuthType"].ToString() == "ptc")
            {
                obj_auth["AuthConfig"]["PtcUsername"] = username.Text;
                obj_auth["AuthConfig"]["PtcPassword"] = passwd.Text;
            }
            obj_config["ConsoleSettings"]["TranslationLanguageCode"] = lang.Text;
            if (update_open.Checked == true)
            {
                obj_config["UpdateSettings"]["AutoUpdate"] = true;
            }
            else
            {
                update_close.Checked = true;
                obj_config["UpdateSettings"]["AutoUpdate"] = false;
            }
            //座標設定
            obj_config["LocationSettings"]["DefaultLatitude"] = La.Text;
            obj_config["LocationSettings"]["DefaultLongitude"] = Lo.Text;
            if(va_open.Checked == true)
            {
                obj_config["LocationSettings"]["UseWalkingSpeedVariant"] = true;
            }
            else
            {
                va_close.Checked = true;
                obj_config["LocationSettings"]["UseWalkingSpeedVariant"] = false;
            }
            obj_config["LocationSettings"]["WalkingSpeedInKilometerPerHour"] = speedvalue.Value;
            //狙擊模式
            if(sn_open.Checked == true)
            {
                obj_config["SnipingSettings"]["UseSnipeLocationServer"] = true;
            }
            else
            {
                obj_config["SnipingSettings"]["UseSnipeLocationServer"] = false;
            }
            obj_config["SnipingSettings"]["GetSniperInfoFromPokezz"] = sniper_server_list.GetItemChecked(0);
            obj_config["SnipingSettings"]["GetOnlyVerifiedSniperInfoFromPokezz"] = sniper_server_list.GetItemChecked(1);
            obj_config["SnipingSettings"]["GetSniperInfoFromPokeSnipers"] = sniper_server_list.GetItemChecked(2);
            obj_config["SnipingSettings"]["GetSniperInfoFromPokeWatchers"] = sniper_server_list.GetItemChecked(3);
            obj_config["SnipingSettings"]["GetSniperInfoFromSkiplagged"] = sniper_server_list.GetItemChecked(4);
            obj_config["SnipingSettings"]["MinDelayBetweenSnipes"] = sniper_delay.Text;

            using (StreamWriter writer_a = new StreamWriter(src_auth))
            using (StreamWriter writer_c = new StreamWriter(src_config))
            {
                JsonSerializer ser = new JsonSerializer();
                JsonWriter jw = new JsonTextWriter(writer_a);
                jw.Formatting = Formatting.Indented;
                ser.Serialize(jw, obj_auth);
                jw = new JsonTextWriter(writer_c);
                jw.Formatting = Formatting.Indented;
                ser.Serialize(jw, obj_config);
                MessageBox.Show("儲存成功", "恭喜", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
