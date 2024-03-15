using System.Diagnostics;
using System.Runtime.InteropServices.Marshalling;
using System.Text;

namespace picture_reader_gym_ {
    public partial class Form1 : Form {

        static Form1 instance = null;
        bool started = false;
        List<string> file_blacklist;
        List<(Image, string)> usedResource_list;
        int latency = 1000;
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            footer_status.Text = "hi!";
            instance = this;
            file_blacklist = new List<string>();
            usedResource_list = new List<(Image, string)>();
        }

        private void button_execute_Click(object sender, EventArgs e) {
            if (!started) {
                if (!Path.Exists(textedit_path.Text)) {
                    MessageBox.Show("path missing");
                    footer_status.Text = "check your folder!";
                    return;
                }
                button_reset.Enabled = false;
                footer_status.Text = "running..";
                started = true;
                button_execute.Text = "бс";
                Task.Run(() => main_start());
            }
            else {
                button_reset.Enabled = true;
                started = false;
                button_execute.Text = "в║";
            }
        }
        /// <summary>
        /// this function should be called asyncronously
        /// </summary>
        private void main_start() {
            //Image bak_image = null;

            string used_folder_path = Path.Combine(textedit_path.Text, "used");
            if (!Directory.Exists(used_folder_path)) {
                Directory.CreateDirectory(used_folder_path);
            }

            while (started) {
                string[] files = Directory.GetFiles(textedit_path.Text);
                //foreach (string file in files)
                for (int t = 0; t < files.Length; t++) {
                    bool blacked = false;
                    //foreach (string black in file_blacklist)
                    for (int i = 0; i < file_blacklist.Count; i++) {
                        if (files[t] == file_blacklist[i]) {
                            blacked = true;
                            break;
                        }
                    }
                    if (blacked) {
                        continue;
                    }

                    StringBuilder name_without_frac_builder = new StringBuilder();
                    string filename_noex = Path.GetFileNameWithoutExtension(files[t]);
                    int period_index = 99;
                    for (int j = 0; j < filename_noex.Length; j++) {
                        if (j == period_index + 4)
                            break;
                        if (filename_noex[j] != '.') {
                            name_without_frac_builder.Append(filename_noex[j]);
                        }
                        else {
                            period_index = j;
                        }
                    }
                    //MessageBox.Show($"file:{name_without_frac_builder.ToString()} cur:{DateTimeOffset.UtcNow.ToUnixTimeMilliseconds()}");

                    long file_timestamp = long.Parse(name_without_frac_builder.ToString());
                    if (file_timestamp + latency > DateTimeOffset.UtcNow.ToUnixTimeMilliseconds()) {
                        //Thread.Sleep(100);
                        break;
                    }

                    StringBuilder extensionbuilder = new StringBuilder();
                    for (int i = files[t].Length - 3; i < files[t].Length; i++) {
                        extensionbuilder.Append(files[t][i]);
                    }
                    if (extensionbuilder.ToString() == "png") {
                        string folder_name = string.Empty;
                        try {
                            //Image bak_image = picturebox_main.Image;
                            folder_name = Path.GetDirectoryName(files[t]);
                            string filename = Path.GetFileName(files[t]);
                            folder_name = Path.Combine(folder_name, "used", filename);
                            File.Move(files[t], folder_name);

                            Image image = Image.FromFile(folder_name);
                            //used_imagePath_list.Add(files[t]);
                            usedResource_list.Add((image, folder_name));
                            picturebox_main.Image = image;

                            if (usedResource_list.Count > 5) {
                                usedResource_list[0].Item1.Dispose();
                                File.Delete(usedResource_list[0].Item2);
                                usedResource_list.RemoveAt(0);
                            }
                            //bak_image = picturebox_main.Image;
                            //bak_image = image;
                            //bak_path = files[t];
                        }
                        catch (IOException e) {
                            //file_blacklist.Add(files[t]);
                        }
                        catch (OutOfMemoryException e) {
                            file_blacklist.Add(folder_name);
                        }
                    }
                    else {
                        Form1.instance.Invoke(() => {
                            footer_status.Text = $"** not png file here, please remove it manually [{extensionbuilder.ToString()}]**";
                        });
                    }
                }

                string bak_status = footer_status.Text ?? "";
                int used_files_count = Directory.GetFiles(used_folder_path).Length;
                Form1.instance.Invoke(() => {
                    if (!bak_status.Contains('/')) {
                        footer_status.Text = $"{bak_status}/total_files:[{files.Length}]/used_files:[{used_files_count}]/blacklist_length:[{file_blacklist.Count}]";
                    }
                    else {
                        string[] splitted = bak_status.Split('/');
                        string updated_status = $"{splitted[0]}/total_files:[{files.Length}]/used_files:[{used_files_count}]/blacklist_length:[{file_blacklist.Count}]";
                        footer_status.Text = updated_status;
                    }
                });
            }
            Form1.instance.Invoke(() => {
                footer_status.Text = "stopped!";
            });
        }


        private void button_search_Click(object sender, EventArgs e) {
            FolderBrowserDialog dialog = new FolderBrowserDialog();
            DialogResult result = dialog.ShowDialog();

            if (result == DialogResult.OK) {
                textedit_path.Text = dialog.SelectedPath;
            }
        }

        private void button_reset_Click(object sender, EventArgs e) {
            if (started) {
                footer_status.Text = $"[running] can't reset while running!";
                return;
            }

            int total_blacklist = file_blacklist.Count;
            file_blacklist.Clear();
            Image cur_image = picturebox_main.Image;
            if (cur_image != null) {
                picturebox_main.Image = null;
                cur_image.Dispose();
            }

            int total_deleted_filecount = 0;

            for (int i = usedResource_list.Count - 1; i >= 0; i--) {
                usedResource_list[i].Item1.Dispose();
                File.Delete(usedResource_list[i].Item2);
                total_deleted_filecount++;
            }
            footer_status.Text = "clear saved array..";

            string used_path = Path.Combine(textedit_path.Text, "used");
            if (Directory.Exists(used_path)) {
                string[] files = Directory.GetFiles(used_path);
                for (int i = 0; i < files.Length; i++) {
                    File.Delete(files[i]);
                    total_deleted_filecount++;
                }
                footer_status.Text = "delete all used-folder's image";
            }

            string status_text = string.Empty;
            if (started)
                status_text = "running";
            else
                status_text = "not-running";
            footer_status.Text = $"[{status_text}]/used resources deleted[{total_deleted_filecount}]/file blacklist cleared!(total: {total_blacklist})";
        }

        private void button_setting_click(object sender, EventArgs e) {
            Form_setting setting = new Form_setting(latency);
            setting.ShowDialog();
            if(setting.DialogResult == DialogResult.OK) {
                latency = setting.GetSetting_latency();
            }
        }
    }
}
