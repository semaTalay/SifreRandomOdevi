using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace SifreRandomOdevi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }


        private void btnUret_Click(object sender, EventArgs e)
        {
            
            for (int i = 1; i <= nudSayi.Value; i++)
            {
                listView1.Items.Add($"{i}-) \n {PasswordGenerator(cboxBüyükHarf.Checked, cboxKücükHarf.Checked, cboxRakam.Checked, cboxOzelKarakter.Checked, int.Parse(nmdUzunluk.Text), int.Parse(nudSayi.Text))}");
                
            }

        }

        private string PasswordGenerator(bool lowerCase, bool upperCase, bool mumberic, bool specialCharacter, int length, int sayi)
        {
            const string kucukHarf = "abcçdefgðhýijklmnoöprsþtuüvyzxw";
            const string buyukHarf = "ABCÇDEFGÐHIÝJKLMNOÖPRSÞTUÜVYZXW";
            const string rakamlar = "0123456789";
            const string ozelKarakter = "/?*<!>,.;&%$";



            char[] password = new char[length];
            string charSet = "";
            System.Random _random = new Random();
            if (lowerCase)
                charSet += buyukHarf;
            if (upperCase)
                charSet += kucukHarf;
            if (mumberic)
                charSet += rakamlar;
            if (specialCharacter)
                charSet += ozelKarakter;
            for (int i = 0; i < length; i++)
                password[i] = charSet[_random.Next(charSet.Length - 1)];
            return string.Join(null, password);
        }
    }








    
}