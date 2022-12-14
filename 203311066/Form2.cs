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

        public Form2(string text)
        {
            InitializeComponent();
            label1.Text = text;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            _ = form2.ShowDialog();
            _ = form2.LabelIsim.Text = IsimS;
            LabelSoyisim.Text = SoyisimS;
            LabelMail.Text = MailS;
            LabelTel.Text = TelS.ToString();
            LabelPoz.Text = PozS;
            LabelKimlik.Text = KimlikS.ToString();
            string text = "İsim: " + IsimS + "\n" + "Soyisim: " + SoyisimS + "\n" + "Mail: " + MailS + "\n" + "Telefon: " + TelS + "\n" + "Pozisyon: " + PozS + "\n" + "Kimlik: " + KimlikS;
            _ = MessageBox.Show(text);
            Close();
        }
    }
}