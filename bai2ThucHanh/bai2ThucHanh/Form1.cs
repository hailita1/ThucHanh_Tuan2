using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bai2ThucHanh
{
    public partial class Form1 : Form
    {
        List<Country_Capital> listCountry_Capitals = new List<Country_Capital>();
        string capital = "";
        string country = "";
        public Form1()
        {
            addData();
            
            InitializeComponent();
        }

        private void EmptyOption()
        {
            rdoAnkara.Checked = false;
            rdoAires.Checked = false;
            rdoBrazilCap.Checked = false;
            rdoTokyo.Checked = false;
            rdoRome.Checked = false;
            rdoWashington.Checked = false;
            rdoMadrid.Checked = false;
            rdoLondon.Checked = false;
            rdoBudapest.Checked = false;
            rdoParis.Checked = false;
        }

        private void addData()
        {
            listCountry_Capitals.Add(new Country_Capital("France", "Paris"));
            listCountry_Capitals.Add(new Country_Capital("Japan", "Tokyo"));
            listCountry_Capitals.Add(new Country_Capital("Hungary", "Budapest"));
            listCountry_Capitals.Add(new Country_Capital("Spain", "Madrid"));
            listCountry_Capitals.Add(new Country_Capital("Turkey", "Ankara"));
            listCountry_Capitals.Add(new Country_Capital("The UK", "London"));
            listCountry_Capitals.Add(new Country_Capital("Italia", "Rome"));
            listCountry_Capitals.Add(new Country_Capital("Argentina", "Buenos Aires"));
            listCountry_Capitals.Add(new Country_Capital("Brazil", "Brazil"));
            listCountry_Capitals.Add(new Country_Capital("The USA", "Washington"));
        }
        bool check(string country, string capital)
        {
            foreach(Country_Capital i in listCountry_Capitals)
            {
                if(i.Country1.Equals(country) && i.Capital1.Equals(capital))
                {
                    return true;
                }
            }
            return false;
        }
        private String getNotification(String country)
        {
            EmptyOption();
            return "Hãy chọn thủ đô cho " + country;
        }

        private void GroupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void RdoFrance_CheckedChanged(object sender, EventArgs e)
        {
            country = rdoFrance.Text;
            lbYeuCau.Text = getNotification(country);
        }



        private void RdoJapan_CheckedChanged(object sender, EventArgs e)
        {
            country = rdoJapan.Text;
            lbYeuCau.Text = getNotification(country);
        }

        private void RdoHungary_CheckedChanged(object sender, EventArgs e)
        {
            country = rdoHungary.Text;
            lbYeuCau.Text = getNotification(country);
        }

        private void Spain_CheckedChanged(object sender, EventArgs e)
        {
            country = Spain.Text;
            lbYeuCau.Text = getNotification(country);
        }

        private void RdoTurkey_CheckedChanged(object sender, EventArgs e)
        {
            country = rdoTurkey.Text;
            lbYeuCau.Text = getNotification(country);
        }

        private void RdoUK_CheckedChanged(object sender, EventArgs e)
        {
            country = rdoUK.Text;
            lbYeuCau.Text = getNotification(country);
        }

        private void RdoItalia_CheckedChanged(object sender, EventArgs e)
        {
            country = rdoItalia.Text;
            lbYeuCau.Text = getNotification(country);
        }

        private void RdoArgentina_CheckedChanged(object sender, EventArgs e)
        {
            country = rdoArgentina.Text;
            lbYeuCau.Text = getNotification(country);
        }

        private void RdoBrazil_CheckedChanged(object sender, EventArgs e)
        {
            country = rdoBrazil.Text;
            lbYeuCau.Text = getNotification(country);
        }

        private void RdoUSA_CheckedChanged(object sender, EventArgs e)
        {
            country = rdoUSA.Text;
            lbYeuCau.Text = getNotification(country);
        }

        private void RdoParis_CheckedChanged(object sender, EventArgs e)
        {
            capital = rdoParis.Text;
            if (check(country, capital))
            {
                lbYeuCau.Text = "Chúc mừng bạn, thủ đô của " + country + " là: " + capital;
            }
            else
            {
                lbYeuCau.Text = "Bạn sai rồi, thủ đô của " + country + " không phải là: " + capital;
            }
        }
        private void RdoAires_CheckedChanged(object sender, EventArgs e)
        {
            capital = rdoAires.Text;
            if (check(country, capital))
            {
                lbYeuCau.Text = "Chúc mừng bạn, thủ đô của " + country + " là: " + capital;
            }
            else
            {
                lbYeuCau.Text = "Bạn sai rồi, thủ đô của " + country + " không phải là: " + capital;
            }
        }

        private void RdoBrazilCap_CheckedChanged(object sender, EventArgs e)
        {
            capital = rdoBrazilCap.Text;
            if (check(country, capital))
            {
                lbYeuCau.Text = "Chúc mừng bạn, thủ đô của " + country + " là: " + capital;
            }
            else
            {
                lbYeuCau.Text = "Bạn sai rồi, thủ đô của " + country + " không phải là: " + capital;
            }
        }

        private void RdoTokyo_CheckedChanged(object sender, EventArgs e)
        {
            capital = rdoTokyo.Text;
            if (check(country, capital))
            {
                lbYeuCau.Text = "Chúc mừng bạn, thủ đô của " + country + " là: " + capital;
            }
            else
            {
                lbYeuCau.Text = "Bạn sai rồi, thủ đô của " + country + " không phải là: " + capital;
            }
        }

        private void RdoRome_CheckedChanged(object sender, EventArgs e)
        {
            capital = rdoRome.Text;
            if (check(country, capital))
            {
                lbYeuCau.Text = "Chúc mừng bạn, thủ đô của " + country + " là: " + capital;
            }
            else
            {
                lbYeuCau.Text = "Bạn sai rồi, thủ đô của " + country + " không phải là: " + capital;
            }
        }

        private void RdoWashington_CheckedChanged(object sender, EventArgs e)
        {
            capital = rdoWashington.Text;
            if (check(country, capital))
            {
                lbYeuCau.Text = "Chúc mừng bạn, thủ đô của " + country + " là: " + capital;
            }
            else
            {
                lbYeuCau.Text = "Bạn sai rồi, thủ đô của " + country + " không phải là: " + capital;
            }
        }

        private void RdoMadrid_CheckedChanged(object sender, EventArgs e)
        {
            capital = rdoMadrid.Text;
            if (check(country, capital))
            {
                lbYeuCau.Text = "Chúc mừng bạn, thủ đô của " + country + " là: " + capital;
            }
            else
            {
                lbYeuCau.Text = "Bạn sai rồi, thủ đô của " + country + " không phải là: " + capital;
            }
        }

        private void RdoLondon_CheckedChanged(object sender, EventArgs e)
        {
            capital = rdoLondon.Text;
            if (check(country, capital))
            {
                lbYeuCau.Text = "Chúc mừng bạn, thủ đô của " + country + " là: " + capital;
            }
            else
            {
                lbYeuCau.Text = "Bạn sai rồi, thủ đô của " + country + " không phải là: " + capital;
            }
        }

        private void RdoAnkara_CheckedChanged(object sender, EventArgs e)
        {
            capital = rdoAnkara.Text;
            if (check(country, capital))
            {
                lbYeuCau.Text = "Chúc mừng bạn, thủ đô của " + country + " là: " + capital;
            }
            else
            {
                lbYeuCau.Text = "Bạn sai rồi, thủ đô của " + country + " không phải là: " + capital;
            }
        }

        private void RdoBudapest_CheckedChanged(object sender, EventArgs e)
        {
            capital = rdoBudapest.Text;
            if (check(country, capital))
            {
                lbYeuCau.Text = "Chúc mừng bạn, thủ đô của " + country + " là: " + capital;
            }
            else
            {
                lbYeuCau.Text = "Bạn sai rồi, thủ đô của " + country + " không phải là: " + capital;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn thoát không ???", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==System.Windows.Forms.DialogResult.Yes)
                this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.Alt)
            {
                if (e.KeyCode.Equals(Keys.M))
                {
                    Button1_Click(null, null);
                }
            }
        }
    }
}
