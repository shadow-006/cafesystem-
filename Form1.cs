namespace CafeSystem;

public partial class Form1 : Form
{
    double yekun = 0;

    public Form1()
    {
        InitializeComponent();
    }

    private void btnTort_Click(object sender, EventArgs e)
    {
        listBoxSebet.Items.Add("Tort - 4.50 AZN");
        yekun = yekun + 4.50;
    }

    private void btnCola_Click(object sender, EventArgs e)
    {
        listBoxSebet.Items.Add("Cola - 2.00 AZN");
        yekun = yekun + 2.00;
    }

    private void btnSok_Click(object sender, EventArgs e)
    {
        listBoxSebet.Items.Add("Sok - 2.50 AZN");
        yekun = yekun + 2.50;
    }

    private void btnBurger_Click(object sender, EventArgs e)
    {
        listBoxSebet.Items.Add("Burger - 5.00 AZN");
        yekun = yekun + 5.00;
    }

    private void btnSendvic_Click(object sender, EventArgs e)
    {
        listBoxSebet.Items.Add("Sendvic - 3.50 AZN");
        yekun = yekun + 3.50;
    }

    private void btnPizza_Click(object sender, EventArgs e)
    {
        listBoxSebet.Items.Add("Pizza - 3.00 AZN");
        yekun = yekun + 3.00;
    }

    private void btnMaffin_Click(object sender, EventArgs e)
    {
        listBoxSebet.Items.Add("Maffin - 2.00 AZN");
        yekun = yekun + 2.00;
    }

    private void btnHotdog_Click(object sender, EventArgs e)
    {
        listBoxSebet.Items.Add("Hot-doq - 3.00 AZN");
        yekun = yekun + 3.00;
    }

    private void btnKurabiye_Click(object sender, EventArgs e)
    {
        listBoxSebet.Items.Add("Kurabiye - 1.50 AZN");
        yekun = yekun + 1.50;
    }

    private void btnSil_Click(object sender, EventArgs e)
    {
        if (listBoxSebet.SelectedIndex == -1)
        {
            if (listBoxSebet.Items.Count == 0)
            {
                MessageBox.Show("Səbətdə yemək yoxdur!");
            }
            else
            {
                MessageBox.Show("Zəhmət olmasa silmək üçün yemək seçin!");
            }
        }
        else
        {
            string secilen = listBoxSebet.SelectedItem.ToString();
            string ad = secilen;

            if (secilen.IndexOf("-") > 0)
            {
                ad = secilen.Substring(0, secilen.IndexOf("-")).Trim();
            }
            else
            {
                ad = secilen;
            }

            if (secilen == "Tort - 4.50 AZN")
            {
                yekun = yekun - 4.50;
            }
            else
            {
                if (secilen == "Cola - 2.00 AZN")
                {
                    yekun = yekun - 2.00;
                }
                else
                {
                    if (secilen == "Sok - 2.50 AZN")
                    {
                        yekun = yekun - 2.50;
                    }
                    else
                    {
                        if (secilen == "Burger - 5.00 AZN")
                        {
                            yekun = yekun - 5.00;
                        }
                        else
                        {
                            if (secilen == "Sendvic - 3.50 AZN")
                            {
                                yekun = yekun - 3.50;
                            }
                            else
                            {
                                if (secilen == "Pizza - 3.00 AZN")
                                {
                                    yekun = yekun - 3.00;
                                }
                                else
                                {
                                    if (secilen == "Maffin - 2.00 AZN")
                                    {
                                        yekun = yekun - 2.00;
                                    }
                                    else
                                    {
                                        if (secilen == "Hot-doq - 3.00 AZN")
                                        {
                                            yekun = yekun - 3.00;
                                        }
                                        else
                                        {
                                            if (secilen == "Kurabiye - 1.50 AZN")
                                            {
                                                yekun = yekun - 1.50;
                                            }
                                            else
                                            {
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }

            if (yekun < 0)
            {
                yekun = 0;
            }
            else
            {
            }

            listBoxSebet.Items.RemoveAt(listBoxSebet.SelectedIndex);

            if (listBoxSebet.Items.Count == 0)
            {
                yekun = 0;
                txtHesab.Text = "";
            }
            else
            {
                if (txtHesab.Text == "")
                {
                }
                else
                {
                    txtHesab.Text = yekun.ToString("F2");
                }
            }

            MessageBox.Show(ad + " səbətdən silindi");
        }
    }

    private void btnYenile_Click(object sender, EventArgs e)
    {
        DialogResult cavab = MessageBox.Show("Xanalar sıfırlansınmı?", "Təsdiq", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

        if (cavab == DialogResult.Yes)
        {
            listBoxSebet.Items.Clear();
            txtMuddet.Text = "";
            txtMebleg.Text = "";
            txtQaliq.Text = "";
            txtHesab.Text = "";
            yekun = 0;
        }
        else
        {
        }
    }

    private void btnYekun_Click(object sender, EventArgs e)
    {
        if (listBoxSebet.Items.Count == 0)
        {
            MessageBox.Show("Səbətdə yemək yoxdur!");
        }
        else
        {
            txtHesab.Text = yekun.ToString("F2");
        }
    }

    private void btnHesabla_Click(object sender, EventArgs e)
    {
        if (txtHesab.Text == "")
        {
            MessageBox.Show("Əvvəlcə Yekun hesabı hesablayın!");
        }
        else
        {
            if (txtMebleg.Text == "")
            {
                MessageBox.Show("Zəhmət olmasa Məbləğ xanasını doldurun!");
            }
            else
            {
                double hesab = 0;
                double mebleg = 0;

                if (double.TryParse(txtHesab.Text, out hesab))
                {
                    if (double.TryParse(txtMebleg.Text, out mebleg))
                    {
                        if (mebleg < hesab)
                        {
                            MessageBox.Show("Daxil edilən məbləğ hesabdan azdır");
                        }
                        else
                        {
                            double qaliq = mebleg - hesab;
                            txtQaliq.Text = qaliq.ToString("F2");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Məbləğ düzgün daxil edilməyib!");
                    }
                }
                else
                {
                    MessageBox.Show("Hesab duzgun deyil!");
                }
            }
        }
    }

    private void btnTemizle_Click(object sender, EventArgs e)
    {
        if (txtMebleg.Text == "" )
        {
            if (txtQaliq.Text == "")
            {
            }
            else
            {
                txtMebleg.Text = "";
                txtQaliq.Text = "";
            }
        }
        else
        {
            txtMebleg.Text = "";
            txtQaliq.Text = "";
        }
    }
}
