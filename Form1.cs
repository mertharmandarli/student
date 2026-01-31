using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        calisma_DBFirst_OgrBilgiSistemiEntities db = new calisma_DBFirst_OgrBilgiSistemiEntities();

        private bool VerilerGecerliMi(bool idKontrolEdilsinMi)
        {
            bool kontrol = false;
            foreach (Control item in this.Controls)
            {
                // Eğer kontrol 'Öğrenci Numarası' kutusuysa ve biz ID kontrolü istemiyorsak atla
                if (item.Name == "txtOgrenciNo" && idKontrolEdilsinMi == false)
                {
                    continue;
                }

                if (string.IsNullOrWhiteSpace(txtOgrName.Text))
                {
                    MessageBox.Show("İsim Bilgisini Giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return kontrol;
                }

                if (string.IsNullOrWhiteSpace(txtOgrSurname.Text))
                {
                    MessageBox.Show("Soyadı Bilgisini Giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return kontrol;
                }

                if (cmbOgrFaculty.SelectedIndex == -1)
                {
                    MessageBox.Show("Fakülte Bilgisini Giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return kontrol;
                }

                if (string.IsNullOrWhiteSpace(txtOgrTc.Text))
                {
                    MessageBox.Show("Tc Numarası Bilgisini Giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return kontrol;
                }

                if (txtOgrTc.Text.Length < 11)
                {
                    MessageBox.Show("Tc Numarasını En Az 11 Haneli Giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return kontrol;
                }

                if (string.IsNullOrWhiteSpace(dtBirthday.Text))
                {
                    MessageBox.Show("Doğum Tarihi Bilgisini Giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return kontrol;
                }
                
                if (cmbBloodType.SelectedIndex == -1)
                {
                    MessageBox.Show("Kan Grubu Bilgisini Giriniz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return kontrol;
                }
            }

            kontrol = true;

            return kontrol;
        }

        private void AlanlariTemizle()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    item.Text = string.Empty;
                }
                if (item is ComboBox)
                {
                    ((ComboBox)item).SelectedIndex = -1; 
                }
            }
        }

        private void VerileriListele()
        {
            using (var db = new calisma_DBFirst_OgrBilgiSistemiEntities()) 
            {
                var liste = db.Student.Select(x => new
                {
                    x.ogr_ID,           
                    x.ogr_Name,
                    x.ogr_Surname,
                    Bölüm = x.Bolumler.bolum_Adı,    
                    KanGrubu = x.Kan_Grubu_Bilgi.Kan_Grubu,
                    x.ogr_Tc,
                    x.ogr_Dogum_Tarihi
                }).ToList();

                dataGridView1.DataSource = liste; 
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var ogrBloodType = db.Kan_Grubu_Bilgi.Select(x => new
            {
                BloodType = x.Kan_Grubu,
                x.Kan_Grubu_ID
            }).Distinct().ToList();

            cmbBloodType.DisplayMember = "BloodType";
            cmbBloodType.ValueMember = "Kan_Grubu_ID";
            cmbBloodType.DataSource = ogrBloodType;

            var ogrFaculty = db.Bolumler.Select(x => new
            {
                Faculty = x.bolum_Adı,
                x.bolum_ID
            }).Distinct().ToList();

            cmbOgrFaculty.DisplayMember = "Faculty";
            cmbOgrFaculty.ValueMember = "bolum_Id";
            cmbOgrFaculty.DataSource = ogrFaculty;

            foreach (var btn in this.Controls.OfType<Button>())
            {
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;

                // Ana Renk
                btn.BackColor = ColorTranslator.FromHtml("#2980B9");
                btn.ForeColor = Color.White;

                // Üzerine gelince rengin bir ton açılması için
                btn.FlatAppearance.MouseOverBackColor = ColorTranslator.FromHtml("#3498DB");
            }

            VerileriListele();
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            VerileriListele();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            if (!VerilerGecerliMi(false)) return;

            Student student = new Student();
            
            student.ogr_Name = txtOgrName.Text;
            student.ogr_Surname = txtOgrSurname.Text;
            student.ogr_Kan_Grubu_ID = int.Parse(cmbBloodType.SelectedValue.ToString());
            student.ogr_Bolum_ID = int.Parse(cmbOgrFaculty.SelectedValue.ToString());
            student.ogr_Tc = txtOgrTc.Text;
            student.ogr_Dogum_Tarihi = dtBirthday.Text;

            db.Student.Add(student);
            db.SaveChanges();
            MessageBox.Show("Ekleme İşleminiz Başarıyla Tamamlandı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            AlanlariTemizle();
            var values = db.Student.ToList(); 
            
            VerileriListele();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOgrNumber.Text))
            {
                MessageBox.Show("Silme işlemi için lütfen bir Öğrenci Numarası girin!", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtOgrNumber.Focus();
                return;
            }

            if (!int.TryParse(txtOgrNumber.Text, out int id))
            {
                MessageBox.Show("Geçersiz ID.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOgrNumber.Focus();
                return;
            }

            var secim = MessageBox.Show("Bu öğrenciyi silmek istediğinize emin misiniz?", "Onay",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (secim != DialogResult.Yes)
            {
                MessageBox.Show("İşlem iptal edildi.");
                return;
            }

            var deleteValue = db.Student.Find(id);
            if (deleteValue == null)
            {
                MessageBox.Show($"ID = {id} numaralı öğrenci bulunamadı.", "Bilgi",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            db.Student.Remove(deleteValue);
            db.SaveChanges();

            MessageBox.Show("Kayıt Silme İşlemi Tamamlandı.");
            AlanlariTemizle();
            VerileriListele();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtOgrNumber.Text))
            {
                MessageBox.Show("Güncelleme işlemi için lütfen bir Öğrenci Numarası girin!", "Uyarı",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtOgrNumber.Focus();
                return;
            }

            if (!int.TryParse(txtOgrNumber.Text, out int id))
            {
                MessageBox.Show("Geçersiz ID.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOgrNumber.Focus();
                return;
            }

            var updateValue = db.Student.Find(id);

            if (!VerilerGecerliMi(false)) return;

            updateValue.ogr_Name = txtOgrNumber.Text;
            updateValue.ogr_Surname = txtOgrNumber.Text;
            updateValue.ogr_Kan_Grubu_ID = int.Parse(cmbBloodType.SelectedValue.ToString());
            updateValue.ogr_Bolum_ID = int.Parse(cmbOgrFaculty.SelectedValue.ToString());
            updateValue.ogr_Tc = txtOgrTc.Text;
            updateValue.ogr_Dogum_Tarihi = dtBirthday.Text;

            db.SaveChanges();
            MessageBox.Show("Güncelleme İşleminiz Başarılı.");
            
            AlanlariTemizle();

            VerileriListele();
        }

        private void btnGetByID_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtOgrNumber.Text))
            {
                MessageBox.Show("Silme işlemi için lütfen bir Öğrenci Numarası girin!", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtOgrNumber.Focus();
                return;
            }

            if (!int.TryParse(txtOgrNumber.Text, out int id))
            {
                MessageBox.Show("Geçersiz ID.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtOgrNumber.Focus();
                return;
            }

            id = int.Parse(txtOgrNumber.Text);
            var values = db.Student.Where(x => x.ogr_ID == id).ToList();
            dataGridView1.DataSource = values;

            AlanlariTemizle();
        }
    }
}
