using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _203311066
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public Label LabelIsim { get; set; }
        public Label LabelSoyisim { get; set; }
        public Label LabelMail { get; set; }
        public Label LabelTel { get; set; }
        public Label LabelPoz { get; set; }
        public Label LabelKimlik { get; set; }

        public string IsimS { get => LabelIsim.Text; set => LabelIsim.Text = value; }
        public string SoyisimS { get => LabelSoyisim.Text; set => LabelSoyisim.Text = value; }
        public string MailS { get => LabelMail.Text; set => LabelMail.Text = value; }
        public int TelS { get => Convert.ToInt32(LabelTel.Text); set => LabelTel.Text = value.ToString(); }
        public string PozS { get => LabelPoz.Text; set => LabelPoz.Text = value; }
        public int KimlikS { get => Convert.ToInt32(LabelKimlik.Text); set => LabelKimlik.Text = value.ToString(); }
    }
}
