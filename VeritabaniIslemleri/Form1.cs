using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VeritabaniIslemleri
{
    public partial class Form1 : Form
    {
        private SqlConnection baglanti;
        private SqlCommand komut;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            baglanti = new SqlConnection("Data Source=.;Initial Catalog=Calisma;Integrated Security=True");
            komut = new SqlCommand();
            komut.Connection = baglanti;

            DersleriGetir();
        }

        private void buttonDersKaydet_Click(object sender, EventArgs e)
        {
            komut.CommandText = "insert into Dersler (Ders) values (@ders)";
            komut.Parameters.AddWithValue("@ders", textBoxDEAd.Text);

            int sonuc = KomutuCalistir();
            MessageBox.Show($"{sonuc} ders eklendi");
            DersleriGetir();
        }

        private void DersleriGetir()
        {
            komut.CommandText = "select * from Dersler";

            try
            {
                if (baglanti.State != ConnectionState.Open)
                {
                    baglanti.Open();

                    
                    dataGridViewDersler.Rows.Clear();
                    comboBoxDersler.Items.Clear();
                    comboBoxDerslerSilme.Items.Clear();

                    SqlDataReader sqlDataReader = komut.ExecuteReader();
                    if (sqlDataReader.HasRows)
                    {
                        while (sqlDataReader.Read())
                        {
                            dataGridViewDersler.Rows.Add(sqlDataReader.GetInt32(0), sqlDataReader.GetString(1));
                            comboBoxDersler.Items.Add(sqlDataReader.GetString(1));
                            comboBoxDerslerSilme.Items.Add(sqlDataReader.GetString(1));
                        }
                    }
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($"{exception.Message}\n{(exception.InnerException == null ? String.Empty : exception.InnerException.Message)}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                komut.Parameters.Clear();
                komut.CommandText = String.Empty;

                if (baglanti.State != ConnectionState.Closed)
                {
                    baglanti.Close();
                }
            }
        }

        private int KomutuCalistir()
        {
            try
            {
                if (baglanti.State != ConnectionState.Open)
                {
                    baglanti.Open();
                    return komut.ExecuteNonQuery();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($"{exception.Message}\n{(exception.InnerException == null ? String.Empty : exception.InnerException.Message)}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                komut.Parameters.Clear();
                komut.CommandText = String.Empty;

                if (baglanti.State != ConnectionState.Closed)
                {
                    baglanti.Close();
                }
            }

            return -1;
        }

        private void buttonDersSecG_Click(object sender, EventArgs e)
        {
            textBoxDersYeniAd.Text = comboBoxDersler.SelectedItem.ToString();
        }

        private void buttonDersGuncelle_Click(object sender, EventArgs e)
        {
            komut.CommandText = "update Dersler set Ders = @yAd where Ders = @eAd";
            komut.Parameters.AddWithValue("@yAd", textBoxDersYeniAd.Text);
            komut.Parameters.AddWithValue("@eAd", comboBoxDersler.SelectedItem.ToString());

            int komutuCalistir = KomutuCalistir();
            if (komutuCalistir > 0)
            {
                textBoxDersYeniAd.Text=String.Empty;
            }
            MessageBox.Show($"{komutuCalistir} ders güncellendi");
            DersleriGetir();
        }

        private void buttonDersSil_Click(object sender, EventArgs e)
        {
            string ders = comboBoxDerslerSilme.SelectedItem.ToString();
            DialogResult dialogResult = MessageBox.Show($"{ders} silinecek. Onaylıyor musunuz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult != DialogResult.Yes)
            {
                return;
            }

            komut.CommandText = "delete Dersler where Ders = @dAd";
            komut.Parameters.AddWithValue("@dAd", ders);
            int komutuCalistir = KomutuCalistir();
            MessageBox.Show($"{komutuCalistir} ders silindi");
            DersleriGetir();
        }
    }
}
