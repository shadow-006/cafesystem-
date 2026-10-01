namespace CafeSystem;

partial class Form1
{
    private System.ComponentModel.IContainer components = null;

    private Panel panelSol;
    private Label lblCafe;
    private Label lblCoffee;
    private Label lblMuddet;
    private TextBox txtMuddet;
    private Label lblMebleg;
    private TextBox txtMebleg;
    private Label lblQaliq;
    private TextBox txtQaliq;
    private Button btnHesabla;
    private Button btnTemizle;

    private Panel panelSag;
    private Label lblSebet;
    private ListBox listBoxSebet;
    private Button btnSil;
    private Button btnYenile;
    private Button btnYekun;
    private Label lblHesab;
    private TextBox txtHesab;

    private Panel panelMenu;
    private Label lblMenu;
    private Button btnTort;
    private Button btnCola;
    private Button btnSok;
    private Button btnBurger;
    private Button btnSendvic;
    private Button btnPizza;
    private Button btnMaffin;
    private Button btnHotdog;
    private Button btnKurabiye;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        components = new System.ComponentModel.Container();

        panelSol = new Panel();
        lblCafe = new Label();
        lblCoffee = new Label();
        lblMuddet = new Label();
        txtMuddet = new TextBox();
        lblMebleg = new Label();
        txtMebleg = new TextBox();
        lblQaliq = new Label();
        txtQaliq = new TextBox();
        btnHesabla = new Button();
        btnTemizle = new Button();

        panelSag = new Panel();
        lblSebet = new Label();
        listBoxSebet = new ListBox();
        btnSil = new Button();
        btnYenile = new Button();
        btnYekun = new Button();
        lblHesab = new Label();
        txtHesab = new TextBox();

        panelMenu = new Panel();
        lblMenu = new Label();
        btnTort = new Button();
        btnCola = new Button();
        btnSok = new Button();
        btnBurger = new Button();
        btnSendvic = new Button();
        btnPizza = new Button();
        btnMaffin = new Button();
        btnHotdog = new Button();
        btnKurabiye = new Button();

        SuspendLayout();

        // Form
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(820, 520);
        Text = "Cafe system";
        StartPosition = FormStartPosition.CenterScreen;

        // panelSol
        panelSol.BackColor = Color.Gray;
        panelSol.Dock = DockStyle.Left;
        panelSol.Width = 175;
        panelSol.Controls.Add(lblCafe);
        panelSol.Controls.Add(lblCoffee);
        panelSol.Controls.Add(lblMuddet);
        panelSol.Controls.Add(txtMuddet);
        panelSol.Controls.Add(lblMebleg);
        panelSol.Controls.Add(txtMebleg);
        panelSol.Controls.Add(lblQaliq);
        panelSol.Controls.Add(txtQaliq);
        panelSol.Controls.Add(btnHesabla);
        panelSol.Controls.Add(btnTemizle);

        lblCafe.Text = "Cafe";
        lblCafe.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
        lblCafe.Location = new Point(55, 20);
        lblCafe.AutoSize = true;

        lblCoffee.Text = "☕";
        lblCoffee.Font = new Font("Segoe UI", 42F);
        lblCoffee.Location = new Point(40, 60);
        lblCoffee.AutoSize = true;

        lblMuddet.Text = "Müddət:";
        lblMuddet.Location = new Point(15, 165);
        lblMuddet.AutoSize = true;

        txtMuddet.Location = new Point(70, 162);
        txtMuddet.Width = 90;
        txtMuddet.Enabled = false;

        lblMebleg.Text = "Məbləğ";
        lblMebleg.Location = new Point(15, 205);
        lblMebleg.AutoSize = true;

        txtMebleg.Location = new Point(15, 225);
        txtMebleg.Width = 145;

        lblQaliq.Text = "Qalıq";
        lblQaliq.Location = new Point(15, 260);
        lblQaliq.AutoSize = true;

        txtQaliq.Location = new Point(15, 280);
        txtQaliq.Width = 145;
        txtQaliq.ReadOnly = true;

        btnHesabla.Text = "Hesabla";
        btnHesabla.BackColor = Color.SeaGreen;
        btnHesabla.ForeColor = Color.White;
        btnHesabla.Location = new Point(15, 325);
        btnHesabla.Size = new Size(145, 35);
        btnHesabla.Click += new EventHandler(btnHesabla_Click);

        btnTemizle.Text = "Təmizlə";
        btnTemizle.BackColor = Color.Firebrick;
        btnTemizle.ForeColor = Color.White;
        btnTemizle.Location = new Point(15, 370);
        btnTemizle.Size = new Size(145, 35);
        btnTemizle.Click += new EventHandler(btnTemizle_Click);

        // panelSag
        panelSag.BackColor = Color.Gray;
        panelSag.Dock = DockStyle.Right;
        panelSag.Width = 215;
        panelSag.Controls.Add(lblSebet);
        panelSag.Controls.Add(listBoxSebet);
        panelSag.Controls.Add(btnSil);
        panelSag.Controls.Add(btnYenile);
        panelSag.Controls.Add(btnYekun);
        panelSag.Controls.Add(lblHesab);
        panelSag.Controls.Add(txtHesab);

        lblSebet.Text = "Səbət";
        lblSebet.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        lblSebet.Location = new Point(70, 20);
        lblSebet.AutoSize = true;

        listBoxSebet.Location = new Point(15, 60);
        listBoxSebet.Size = new Size(185, 250);

        btnSil.Text = "Səbətdən sil";
        btnSil.Location = new Point(15, 325);
        btnSil.Size = new Size(185, 30);
        btnSil.Click += new EventHandler(btnSil_Click);

        btnYenile.Text = "Yenilə";
        btnYenile.Location = new Point(15, 362);
        btnYenile.Size = new Size(185, 30);
        btnYenile.Click += new EventHandler(btnYenile_Click);

        btnYekun.Text = "Yekun hesab";
        btnYekun.Location = new Point(15, 399);
        btnYekun.Size = new Size(185, 30);
        btnYekun.Click += new EventHandler(btnYekun_Click);

        lblHesab.Text = "Hesab:";
        lblHesab.Location = new Point(15, 445);
        lblHesab.AutoSize = true;

        txtHesab.Location = new Point(70, 442);
        txtHesab.Width = 130;
        txtHesab.ReadOnly = true;

        // panelMenu
        panelMenu.BackColor = Color.White;
        panelMenu.Dock = DockStyle.Fill;
        panelMenu.Controls.Add(lblMenu);
        panelMenu.Controls.Add(btnTort);
        panelMenu.Controls.Add(btnCola);
        panelMenu.Controls.Add(btnSok);
        panelMenu.Controls.Add(btnBurger);
        panelMenu.Controls.Add(btnSendvic);
        panelMenu.Controls.Add(btnPizza);
        panelMenu.Controls.Add(btnMaffin);
        panelMenu.Controls.Add(btnHotdog);
        panelMenu.Controls.Add(btnKurabiye);

        lblMenu.Text = "MENU";
        lblMenu.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
        lblMenu.Location = new Point(175, 20);
        lblMenu.AutoSize = true;

        btnTort.Text = "🍰 Tort\n4.50 AZN";
        btnTort.Location = new Point(30, 60);
        btnTort.Size = new Size(120, 100);
        btnTort.Click += new EventHandler(btnTort_Click);

        btnCola.Text = "🥤 Cola\n2.00 AZN";
        btnCola.Location = new Point(160, 60);
        btnCola.Size = new Size(120, 100);
        btnCola.Click += new EventHandler(btnCola_Click);

        btnSok.Text = "🧃 Sok\n2.50 AZN";
        btnSok.Location = new Point(290, 60);
        btnSok.Size = new Size(120, 100);
        btnSok.Click += new EventHandler(btnSok_Click);

        btnBurger.Text = "🍔 Burger\n5.00 AZN";
        btnBurger.Location = new Point(30, 175);
        btnBurger.Size = new Size(120, 100);
        btnBurger.Click += new EventHandler(btnBurger_Click);

        btnSendvic.Text = "🥪 Sendviç\n3.50 AZN";
        btnSendvic.Location = new Point(160, 175);
        btnSendvic.Size = new Size(120, 100);
        btnSendvic.Click += new EventHandler(btnSendvic_Click);

        btnPizza.Text = "🍕 Pizza\n3.00 AZN";
        btnPizza.Location = new Point(290, 175);
        btnPizza.Size = new Size(120, 100);
        btnPizza.Click += new EventHandler(btnPizza_Click);

        btnMaffin.Text = "🧁 Maffin\n2.00 AZN";
        btnMaffin.Location = new Point(30, 290);
        btnMaffin.Size = new Size(120, 100);
        btnMaffin.Click += new EventHandler(btnMaffin_Click);

        btnHotdog.Text = "🌭 Hot-doq\n3.00 AZN";
        btnHotdog.Location = new Point(160, 290);
        btnHotdog.Size = new Size(120, 100);
        btnHotdog.Click += new EventHandler(btnHotdog_Click);

        btnKurabiye.Text = "🍪 Kurabiyə\n1.50 AZN";
        btnKurabiye.Location = new Point(290, 290);
        btnKurabiye.Size = new Size(120, 100);
        btnKurabiye.Click += new EventHandler(btnKurabiye_Click);

        Controls.Add(panelMenu);
        Controls.Add(panelSag);
        Controls.Add(panelSol);

        ResumeLayout(false);
    }
}
