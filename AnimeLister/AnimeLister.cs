using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Newtonsoft.Json;

namespace AnimeLister
{
    public partial class AnimeLister : Form
    {
        Settings.Rootobject anime_list = null;

        public AnimeLister()
        {
            InitializeComponent();
        }

        private void AnimeLister_Load(object sender, EventArgs e)
        {
            box_grade.SelectedIndex = 0;
            load_anime().Wait();
        }

        private Task load_anime()
        {
            ListViewItem item = null;

            anime_list = JsonConvert.DeserializeObject<Settings.Rootobject>(
                File.ReadAllText("settings.json")
            );
            box_items.Items.Clear();

            for (int i = 0; i < anime_list.anime.Count; i++)
            {
                item = new ListViewItem(new[] {
                    $"{anime_list.anime[i].name}",
                    $"{anime_list.anime[i].grade}"
                });
                box_items.Items.Add(item);
            }

            return (Task.CompletedTask);
        }

        private Task add_anime()
        {
            bool updated = false;
            Settings.Anime data = new Settings.Anime();
            data.name = box_name.Text;
            data.grade = $"{box_grade.SelectedItem}";

            for (int i = 0; i < anime_list.anime.Count; i++)
            {
                if (anime_list.anime[i].name == data.name)
                {
                    anime_list.anime[i].grade = data.grade;
                    updated = true;
                }
            }
            if (updated == false)
                anime_list.anime.Add(data);

            File.WriteAllText("settings.json", JsonConvert.SerializeObject(anime_list));
            box_grade.SelectedIndex = 0;
            box_name.Text = "";

            return (Task.CompletedTask);
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (box_name.Text.Length > 0)
            {
                add_anime().Wait();
                load_anime().Wait();
            } else
            {
                MessageBox.Show("No anime name specified", "Anime name error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
