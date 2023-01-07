namespace HspMakinesi
{
    public partial class Form1 : Form
    {
        int _ilkSayi;
        bool operatorDurum = false;
        double sonuc = 0;
        string opt = "";
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void RakamGiris(object sender, EventArgs e)
        {
            if (textSonuc.Text == "0" || operatorDurum)
                textSonuc.Clear();
            operatorDurum = false;

                Button btn = (Button)sender;
            textSonuc.Text += btn.Text;
        }

        private void OperatorIslem(object sender, EventArgs e)
        {
            int ikinciSayi = Convert.ToInt32(textSonuc.Text);
            operatorDurum = true;
            Button btn = (Button)sender;
            string yeniOpt=btn.Text;

            labelSonuc.Text = labelSonuc.Text + " " + textSonuc.Text + " " + yeniOpt;
            switch (opt)
            {
                case "+":textSonuc.Text = (sonuc + Double.Parse(textSonuc.Text)).ToString(); break;
                case "-":textSonuc.Text = (sonuc - Double.Parse(textSonuc.Text)).ToString(); break;
                case "*":textSonuc.Text = (sonuc * Double.Parse(textSonuc.Text)).ToString(); break;
                case "/":textSonuc.Text = (sonuc / Double.Parse(textSonuc.Text)).ToString();
                    if (ikinciSayi != 0)
                    {
                        sonuc = _ilkSayi / ikinciSayi;
                    }
                    else
                    {
                        MessageBox.Show("hata");
                        sonuc = 0;
                    }
                    break;
            }
            sonuc=Double.Parse(textSonuc.Text);
            textSonuc.Text = sonuc.ToString();
            opt = yeniOpt;

        }

        private void button19_Click(object sender, EventArgs e)
        {
            if (Convert.ToDouble(textSonuc.Text)>0)
            {
                textSonuc.Text = textSonuc.Text.Remove(textSonuc.Text.Length - 1, 1);
                if (textSonuc.Text.Length == 0)
                {
                    textSonuc.Text = "0";
                }

            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            textSonuc.Text = "0";
            labelSonuc.Text = "";
            opt = "";
            sonuc = 0;
            operatorDurum = false;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            int ikinciSayi = Convert.ToInt32(textSonuc.Text);
            labelSonuc.Text = "";
            operatorDurum=true;

            switch (opt)
            {
                case "+": textSonuc.Text = (sonuc + Double.Parse(textSonuc.Text)).ToString(); break;
                case "-": textSonuc.Text = (sonuc - Double.Parse(textSonuc.Text)).ToString(); break;
                case "*": textSonuc.Text = (sonuc * Double.Parse(textSonuc.Text)).ToString(); break;
                case "/": textSonuc.Text = (sonuc / Double.Parse(textSonuc.Text)).ToString();
                    if(ikinciSayi != 0)
                    {
                        sonuc = _ilkSayi / ikinciSayi;
                    } else
                    {
                        MessageBox.Show("hata");
                        sonuc = 0;
                    }break;
            }
            sonuc = Double.Parse(textSonuc.Text);
            textSonuc.Text = sonuc.ToString();
            opt = "";
        }

        private void buttonnokta_Click(object sender, EventArgs e)
        {
            if (textSonuc.Text =="0")
            {
                textSonuc.Text = "0";

            }
            else if(operatorDurum)
            {
                textSonuc.Text = "0";
            }

            if (!textSonuc.Text.Contains("."))
            {
                textSonuc.Text += ",";
            }
            operatorDurum = false;
        }
    }
}