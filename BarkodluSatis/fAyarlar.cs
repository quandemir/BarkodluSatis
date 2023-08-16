using BarkodluSatis.Dal;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarkodluSatis
{
    public partial class fAyarlar : Form
    {
        public fAyarlar()
        {
            InitializeComponent();
        }
        private void Temizle()
        {
            tAdSoyad.Clear();
            tTelefon.Clear();
            tEPosta.Clear();
            tKullanıcıAdı.Clear();
            tSifre.Clear();
            tSifreTekrar.Clear();
            cSatışEkranı.Checked = false;
            cRaporEkranı.Checked = false;
            cStok.Checked = false;
            cÜrünGiriş.Checked = false;
            cAyarlar.Checked = false;
            cFiyatGüncelle.Checked = false;
            cYedekleme.Checked = false;
        }

        private void bKaydet_Click(object sender, EventArgs e)
        {
            if (bKaydet.Text == "Kaydet")
            {
                if (tAdSoyad.Text != "" && tTelefon.Text != "" && tKullanıcıAdı.Text != "" && tSifre.Text != "" && tSifreTekrar.Text != "" && tEPosta.Text != "")
                {
                    if (tSifre.Text == tSifreTekrar.Text)
                    {
                        try
                        {
                            using (var db = new Context())
                            {
                                if (!db.kullanicis.Any(x => x.KullaniciAdi == tKullanıcıAdı.Text))
                                {
                                    Kullanici k = new Kullanici();
                                    k.AdSoyad = tAdSoyad.Text;
                                    k.Telefon = tTelefon.Text;
                                    k.EPosta = tEPosta.Text;
                                    k.KullaniciAdi = tKullanıcıAdı.Text.Trim();
                                    k.Sifre = tSifre.Text;
                                    k.Satış = Convert.ToByte(cSatışEkranı.Checked);
                                    k.Rapor = Convert.ToByte(cRaporEkranı.Checked);
                                    k.Stok = Convert.ToByte(cStok.Checked);
                                    k.UrunGiris = Convert.ToByte(cÜrünGiriş.Checked);
                                    k.Ayarlar = Convert.ToByte(cAyarlar.Checked);
                                    k.FiyatGuncelle = Convert.ToByte(cFiyatGüncelle.Checked);
                                    k.Yedekleme = Convert.ToByte(cYedekleme.Checked);
                                    db.kullanicis.Add(k);
                                    db.SaveChanges();
                                    Doldur();
                                    Temizle();
                                }
                                else
                                {
                                    MessageBox.Show("Bu kullanıcı zaten kayıtlı");
                                }
                            }
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Hata Oluştu " + ex);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Şifreler Uyuşmuyor");
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen bilgileri doldurun");
                }
            }
            else if (bKaydet.Text == "Düzenle/Kaydet")
            {
                if (tAdSoyad.Text != "" && tTelefon.Text != "" && tKullanıcıAdı.Text != "" && tSifre.Text != "" && tSifreTekrar.Text != "" && tEPosta.Text != "")
                {
                    if (tSifre.Text == tSifreTekrar.Text)
                    {
                        int id = Convert.ToInt32(lKullanıcıId.Text);
                        using (var db = new Context())
                        {
                            var guncelle = db.kullanicis.Where(x => x.Id == id).FirstOrDefault();
                            guncelle.AdSoyad = tAdSoyad.Text;
                            guncelle.Telefon = tTelefon.Text;
                            guncelle.EPosta = tEPosta.Text;
                            guncelle.KullaniciAdi = tKullanıcıAdı.Text.Trim();
                            guncelle.Sifre = tSifre.Text;
                            guncelle.Satış = Convert.ToByte(cSatışEkranı.Checked);
                            guncelle.Rapor = Convert.ToByte(cRaporEkranı.Checked);
                            guncelle.Stok = Convert.ToByte(cStok.Checked);
                            guncelle.UrunGiris = Convert.ToByte(cÜrünGiriş.Checked);
                            guncelle.Ayarlar = Convert.ToByte(cAyarlar.Checked);
                            guncelle.FiyatGuncelle = Convert.ToByte(cFiyatGüncelle.Checked);
                            guncelle.Yedekleme = Convert.ToByte(cYedekleme.Checked);
                            db.SaveChanges();
                            MessageBox.Show("Güncelleme Yapıldı");
                            bKaydet.Text = "Kaydet";
                            Temizle();
                            Doldur();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Şifreler Uyuşmuyor");
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen bilgileri doldurun");
                }
            }
        }

        private void düzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (gridListKullanici.Rows.Count > 0)
            {
                int id = Convert.ToInt32(gridListKullanici.CurrentRow.Cells["Id"].Value.ToString());
                lKullanıcıId.Text = id.ToString();
                using (var db = new Context())
                {
                    var getir = db.kullanicis.Where(x => x.Id == id).FirstOrDefault();
                    tAdSoyad.Text = getir.AdSoyad;
                    tTelefon.Text = getir.Telefon;
                    tEPosta.Text = getir.EPosta;
                    tKullanıcıAdı.Text = getir.KullaniciAdi;
                    tSifre.Text = getir.Sifre;
                    tSifreTekrar.Text = getir.Sifre;
                    cSatışEkranı.Checked = Convert.ToBoolean(getir.Satış);
                    cRaporEkranı.Checked = Convert.ToBoolean(getir.Rapor);
                    cStok.Checked = Convert.ToBoolean(getir.Stok);
                    cÜrünGiriş.Checked = Convert.ToBoolean(getir.UrunGiris);
                    cAyarlar.Checked = Convert.ToBoolean(getir.Ayarlar);
                    cFiyatGüncelle.Checked = Convert.ToBoolean(getir.FiyatGuncelle);
                    cYedekleme.Checked = Convert.ToBoolean(getir.Yedekleme);
                    bKaydet.Text = "Düzenle/Kaydet";
                    Doldur();
                }
            }
            else
            {
                MessageBox.Show("Satır seç");
            }
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void fAyarlar_Load(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Doldur();
            Islemler.SabitVarsayılan();
            Cursor.Current = Cursors.Default;
        }
        private void Doldur()
        {
            using (var db = new Context())
            {
                if (db.kullanicis.Any())
                {
                    gridListKullanici.DataSource = db.kullanicis.Select(x => new { x.Id, x.AdSoyad, x.KullaniciAdi, x.Telefon }).ToList();
                    
                }
                Islemler.SabitVarsayılan();
                var yazici = db.sabits.FirstOrDefault();
                chYazmaDurumu.Checked = Convert.ToBoolean(yazici.Yazici);

                var sabitler=db.sabits.FirstOrDefault();
                tKartKomisyon.Text=sabitler.KartKomisyon.ToString();

                var terazionek = db.Terazis.ToList();
                cmbTeraziOnEk.DisplayMember = "TeraziÖnEk";
                cmbTeraziOnEk.ValueMember = "Id";
                cmbTeraziOnEk.DataSource = terazionek;

                tIsAdSoyad.Text = sabitler.AdSoyad;
                tIsUnvan.Text = sabitler.Unvan;
                tIsAdres.Text = sabitler.Adres;
                tIsTelefon.Text = sabitler.Telefon;
                tIsEPosta.Text = sabitler.Eposta;
            }
        }

        private void chYazmaDurumu_CheckedChanged(object sender, EventArgs e)
        {
            using (var db = new Context())
            {
                if (chYazmaDurumu.Checked)
                {

                    Islemler.SabitVarsayılan();
                    var ayarla = db.sabits.FirstOrDefault();
                    ayarla.Yazici = 1;
                    db.SaveChanges();
                    chYazmaDurumu.Text = "Yazma Durumu Pasif";
                }
                else
                {
                    Islemler.SabitVarsayılan();
                    var ayarla = db.sabits.FirstOrDefault();
                    ayarla.Yazici = 0;
                    db.SaveChanges();
                    chYazmaDurumu.Text = "Yazma Durumu Aktif";
                }
            }
        }

        private void bKomisyonKaydet_Click(object sender, EventArgs e)
        {
            if (tKartKomisyon.Text != "")
            {
                using(var db=new Context())
                {
                    var sabit=db.sabits.FirstOrDefault();
                    sabit.KartKomisyon = Convert.ToInt16(tKartKomisyon.Text);
                    db.SaveChanges() ;
                    MessageBox.Show("Kart Komisyon Kaydedildi");
                }
            }
            else
            {
                MessageBox.Show("Kart Komisyon Bilgisi Giriniz");
            }
        }

        private void bOnEkKAydet_Click(object sender, EventArgs e)
        {
            if (tTeraziOnEk.Text != "")
            {
                int onek = Convert.ToInt16(tTeraziOnEk.Text);
                using(var db=new Context())
                {
                    if (db.Terazis.Any(x => x.TeraziÖnEk == onek))
                    {
                        MessageBox.Show(onek.ToString() + " önek zaten kayıtli");
                    }
                    else
                    {
                        Terazi t =new Terazi();
                        t.TeraziÖnEk = onek;
                        db.Terazis.Add(t);
                        db.SaveChanges();
                        MessageBox.Show("Bilgiler Kaydedildi");
                        cmbTeraziOnEk.DisplayMember = "TeraziÖnEk";
                        cmbTeraziOnEk.ValueMember = "Id";
                        cmbTeraziOnEk.DataSource = db.Terazis.ToList();
                        tTeraziOnEk.Clear();
                    }
                }
            }
            else
            {
                MessageBox.Show("Terazi önek bilgisini giriniz");
            }
        }

        private void bTeraziOnEkSil_Click(object sender, EventArgs e)
        {
            if (cmbTeraziOnEk.Text != "")
            {
                int onekid = Convert.ToInt16(cmbTeraziOnEk.SelectedValue);
                DialogResult onay = MessageBox.Show(cmbTeraziOnEk.Text + "öneki silinsin mi?", "Önek Sil", MessageBoxButtons.YesNo);
                if (onay == DialogResult.Yes)
                {
                    using(var db=new Context())
                    {
                        var onek = db.Terazis.Find(onekid);
                        db.Terazis.Remove(onek);
                        db.SaveChanges();
                        cmbTeraziOnEk.DisplayMember = "TeraziÖnEk";
                        cmbTeraziOnEk.ValueMember = "Id";
                        cmbTeraziOnEk.DataSource = db.Terazis.ToList();
                        MessageBox.Show("Önek Silinmiştir");
                    }
                }
            }
            else
            {
                MessageBox.Show("Terazi Ön ek seçiniz !!!");
            }
        }

        private void bIsKaydet_Click(object sender, EventArgs e)
        {
            if(tIsAdSoyad.Text!="" && tIsUnvan.Text != "" && tIsAdres.Text != "" && tIsTelefon.Text != "")
            {
                using(var db=new Context())
                {
                    var ısyeri = db.sabits.FirstOrDefault();
                    ısyeri.AdSoyad = tIsAdSoyad.Text;
                    ısyeri.Unvan = tIsUnvan.Text;
                    ısyeri.Adres = tIsAdres.Text;
                    ısyeri.Telefon = tIsTelefon.Text;
                    ısyeri.Eposta = tIsEPosta.Text;
                    db.SaveChanges();
                    MessageBox.Show("Kaydedildi");
                    var yeni=db.sabits.FirstOrDefault();
                    tIsAdSoyad.Text = yeni.AdSoyad;
                    tIsUnvan.Text = yeni.Unvan;
                    tIsAdres.Text = yeni.Adres;
                    tIsTelefon.Text = yeni.Telefon;
                    tIsEPosta.Text = yeni.Eposta;
                }
            }
            else
            {
                MessageBox.Show("Bilgileri Doldurrr");
            }
        }

        private void bYedeğiYukle_Click(object sender, EventArgs e)
        {
            Process.Start(Application.StartupPath + @"\ProgramRestore.exe");
            Application.Exit();
        }
    }
}
