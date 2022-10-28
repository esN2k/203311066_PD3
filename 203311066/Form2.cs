using System;
using System.Drawing;
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
            {
                // Creating and setting the label
                Label mylab = new Label
                {
                    Text = "GeeksforGeeks",
                    Location = new Point(222, 90),
                    AutoSize = true,
                    Font = new Font("Calibri", 18),
                    BorderStyle = BorderStyle.Fixed3D,
                    ForeColor = Color.Green,
                    Padding = new Padding(6)
                };

                // Adding this control to the form
                Controls.Add(mylab);

                // Creating and setting the label
                Label mylab1 = new Label
                {
                    Text = "Welcome To GeeksforGeeks",
                    Location = new Point(155, 170),
                    AutoSize = true,
                    BorderStyle = BorderStyle.Fixed3D,
                    Font = new Font("Calibri", 18),
                    Padding = new Padding(6)
                };

                // Adding this control to the form
                Controls.Add(mylab1);
            }
            LabelIsim.Text = IsimS;
            LabelSoyisim.Text = SoyisimS;
            LabelMail.Text = MailS;
            LabelTel.Text = TelS.ToString();
            LabelPoz.Text = PozS;
            LabelKimlik.Text = KimlikS.ToString();
        }

        public Form2(string text)
        {
            InitializeComponent();
            label1.Text = text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label7_Click(object sender, EventArgs e)
        {
            // Creating and setting the label
            Label mylab = new Label
            {
                Text = "GeeksforGeeks",
                Location = new Point(222, 90),
                AutoSize = true,
                Font = new Font("Calibri", 18),
                BorderStyle = BorderStyle.Fixed3D,
                ForeColor = Color.Green,
                Padding = new Padding(6)
            };

            // Adding this control to the form
            Controls.Add(mylab);

            // Creating and setting the label
            Label mylab1 = new Label
            {
                Text = "Welcome To GeeksforGeeks",
                Location = new Point(155, 170),
                AutoSize = true,
                BorderStyle = BorderStyle.Fixed3D,
                Font = new Font("Calibri", 18),
                Padding = new Padding(6)
            };

            // Adding this control to the form
            Controls.Add(mylab1);
        }
    }
}
