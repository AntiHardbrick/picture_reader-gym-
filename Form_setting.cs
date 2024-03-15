using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace picture_reader_gym_ {
    public partial class Form_setting : Form {
        //int latency;


        public Form_setting(int _latency) {
            InitializeComponent();
            //latency = _latency;
            numeric_latency.Value = _latency;
        }

        private void Form_setting_Load(object sender, EventArgs e) {

        }

        private void button_apply_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.OK;
            this.Close();
        }

        private void button_cancel_Click(object sender, EventArgs e) {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }
        public int GetSetting_latency() {
            return (int)numeric_latency.Value;
        }
    }
}
