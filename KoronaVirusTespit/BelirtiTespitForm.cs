using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KoronaVirusTespit
{
    public partial class BelirtiTespitForm : Form
    {
        string[] _sehirler = new string[3]
        {
            "Ankara", "İstanbul", "İzmir"
        };

        string sonuc;
        public BelirtiTespitForm()
        {
            InitializeComponent();
        }

        private void BelirtiTespitForm_Load(object sender, EventArgs e)
        {
            this.Text = "Belirti Tespit";

            //1.yöntem:
            // ddlSehir.Items.Add("Ankara");
            // ddlSehir.Items.Add("İstanbul");
            // ddlSehir.Items.Add("izmir");

            //2.yöntem
            //foreach (string sehir in _sehirler)
            //{
            //    ddlSehir.Items.Add(sehir);
            //}

            //3.yöntem
            ddlSehir.Items.AddRange(_sehirler);
            ddlSehir.SelectedIndex = 0;

            dtpTarih.Value = DateTime.Now;

            rbKadin.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            KontrolEt()
        }

        private void KontrolEt()
        {
            sonuc = "";
            if (rbKadin.Checked)
            {
                sonuc += "Bayan ";
            }
            else
            {
                sonuc += "Bay ";
            }
            sonuc += tbAdi.Text + " " + tbSoyadi.Text + "/r/n";
            sonuc += "Şehriniz: " + ddlSehir.Text + "/r/n";
            sonuc += "Yaşınız: " + nudYas.Value + "/r/n";
            sonuc += "Kontrol tarihi: " + dtpTarih.Value.ToLongDateString() + "/r/n";

            if (cbAtes.Checked || (cbOksuruk.Checked && cbBogaz.Checked))
            {
                sonuc += "Koronavirüs olabilirsiniz.";
            }
            else
            {
                sonuc += "Koronavirüs olmayabilirsiniz.";
            }
        }
    }
}
