using System;
using System.Windows.Forms;

namespace _203311066
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string IsimS
        {
            get => IsimS1;
            set => IsimS1 = value;
        }
        public string SoyisimS
        {
            get => SoyisimS1;
            set => SoyisimS1 = value;
        }
        public string MailS
        {
            get => MailS1;
            set => MailS1 = value;
        }
        public int TelS
        {
            get => TelS1;
            set => TelS1 = value;
        }
        public string PozS
        {
            get => PozS1;
            set => PozS1 = value;
        }
        public int KimlikS
        {
            get => KimlikS1;
            set => KimlikS1 = value;
        }
        public string IsimS1 { get; set; }
        public string SoyisimS1 { get; set; }
        public string MailS1 { get; set; }
        public int TelS1 { get; set; }
        public string PozS1 { get; set; }
        public int KimlikS1 { get; set; }

        private void buttonFinal_Click(object sender, EventArgs e)
        {
            IsimS = textBoxIsim.Text;
            SoyisimS = textBoxSoy.Text;
            MailS = textBoxMail.Text;
            TelS = Convert.ToInt32(textBoxTel.Text);
            PozS = textBoxPoz.Text;
            KimlikS = Convert.ToInt32(textBoxKimlik.Text);
            _ = MessageBox.Show("Kayıt Başarılı");

            _ = new Form1
            {
                IsimS = textBoxIsim.Text,
                SoyisimS = textBoxSoy.Text,
                MailS = textBoxMail.Text,
                TelS = Convert.ToInt32(textBoxTel.Text),
                PozS = textBoxPoz.Text,
                KimlikS = Convert.ToInt32(textBoxKimlik.Text)
            };

            Form2 f2 = new Form2()
            {
                IsimS = textBoxIsim.Text,
                SoyisimS = textBoxSoy.Text,
                MailS = textBoxMail.Text,
                TelS = Convert.ToInt32(textBoxTel.Text),
                PozS = textBoxPoz.Text,
                KimlikS = Convert.ToInt32(textBoxKimlik.Text)
            };
            _ = f2.ShowDialog();
        }
        private void ButtonCV_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog
            {
                Filter = "PDF Dosyanızı Seçiniz|*.pdf|Word Dosyanızı Seçiniz|*.doc;*docx"
            };
            _ = dlg.ShowDialog();
        }
    }
}