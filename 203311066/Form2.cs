using System;
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

        public string IsimS { get; set; }
        public string SoyisimS { get; set; }
        public string MailS { get; set; }
        public int TelS { get; set; }
        public string PozS { get; set; }
        public int KimlikS { get; set; }

        private void Form2_Load(object sender, EventArgs e)
        {
            LabelIsim.Text = IsimS;
            LabelSoyisim.Text = SoyisimS;
            LabelMail.Text = MailS;
            LabelTel.Text = TelS.ToString();
            LabelPoz.Text = PozS;
            LabelKimlik.Text = KimlikS.ToString();
        }
    }
}
