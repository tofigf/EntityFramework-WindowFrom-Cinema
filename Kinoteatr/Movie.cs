using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Kinoteatr.Model;

namespace Kinoteatr
{
    public partial class Movie : Form
    {
        CinemaEntities1 db = new CinemaEntities1();
        private Film selected = new Film();
        private FilmCountry selectcountry = new FilmCountry();
        private FilmGenre selectgenre = new FilmGenre();
        int clickRow = 0;
        public Movie()
        {
           InitializeComponent();
           fillLangua();
           FillGridFilms();
        }
        //private void FillCheckCountry()
        //{
        //    foreach (Model.Country item in db.Countries)
        //    {
        //        clbCountries.Items.Add(item.ID + "-" + item.Name);
        //    }
        //}
        // xanalari doldurmaq ucun
        private void fillLangua()
        {
            List<Language> lan = db.Languages.ToList();
            foreach (Language item in lan)
            {
                clbLanguage.Items.Add(item.Name);
                clbSub.Items.Add(item.Name);
            }
        }
        //Idleri tapmaq
        private int FindLanguagesById(string name)
        {
            int LangId = Convert.ToInt32(db.Languages.FirstOrDefault(l => l.Name == name).ID);
           
            return LangId;
        }
        private void FillGridFilms()
        {
            var list = db.Films.Select(s => new
            {   
                s.ID,
                s.Name,
                s.Year,
                s.Director,
                s.AgeRes,
                s.Duration,
                language = s.Language.Name,
                subtit = s.Language.Name,
                s.Premiere,
                s.is3D,
                s.About,
                s.Photo,
                s.Trialer
            }).ToList();
            foreach (var item in list)
            {
                dgvFilms.Rows.Add(
                     item.ID,
               item.Name,
               item.Year,
               item.Director,
               item.AgeRes,
               item.Duration,
               item.language,
               item.language,
               item.Premiere,
               item.is3D,
               item.About,
               item.Photo,
               item.Trialer
                    );
               dgvFilms.Columns[0].Visible = false;

            }
        }
        //film elave etmek
        private void btnAdd_Click(object sender, EventArgs e)
        {
           
            lblError.Text = "";
            string name = txtName.Text;
            string year = txtYear.Text;
            string director = txtDirector.Text;
            string ageres = txtAgeRes.Text;
            string duration =txtDuration.Text;
            string date = dtpPrimiere.Value.ToString();
            string about = rtxtAbout.Text;
            string langauge = clbLanguage.Text;
            string subtit = clbSub.Text;
          
            if(year == string.Empty ||director ==string.Empty||ageres ==string.Empty ||duration == string.Empty )
            {
                lblError.Text = "* olan Xanalari doldurun";
                return;
            }
            if(!int.TryParse(year,out int Year))
            {
                lblError.Text = "ili duzgun daxil edin";
            }
            if(!int.TryParse(duration,out int Duration))
            {
                lblError.Text = "Filmin muddetini duzgun yazin!";
                return;
            }
            Model.Film kino = new Model.Film
            {
                Name = name,
                Year = Year,
                Director = director,
                AgeRes = ageres,
                Duration = Duration,
                LanguageID = FindLanguagesById(clbLanguage.Text),
                CcID = FindLanguagesById(clbSub.Text),
                Premiere =dtpPrimiere.Value,
                 is3D = Convert.ToInt32(rbtn3D.Checked),
                About = about,
            };
            db.Films.Add(kino);
            db.SaveChanges();
            dgvFilms.Rows.Add(
               kino.ID,
               kino.Name,
               kino.Year,
               kino.Director,
               kino.AgeRes,
               kino.Duration,
               kino.Language.Name,
               kino.Language1.Name,
               kino.Premiere,
               kino.is3D,
               kino.About,
               kino.Photo,
               kino.Trialer


               );
            Reset();   
        }
        //olke ve janr elave etmek
        private void btnAddContrGenre_Click(object sender, EventArgs e)
        {
            AddConGen war = new AddConGen();
            war.ShowDialog();
        }
        private void Reset()
        {
           
            txtName.Text = "";
            txtYear.Text = "";
            txtDuration.Text = "";
            txtDirector.Text = "";
            txtAgeRes.Text = "";
            rbtn3D.Text = "";
            rtxtAbout.Text = "";
            clbLanguage.Text = "";
            clbSub.Text = "";
            lblAddInfo.Visible = true;
            lblErrorInfo.Visible = true;
            btnAddContrGenre.Visible = true;
        }
        //rowun kliki
        private void dgvFilms_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int id = Convert.ToInt32(dgvFilms.Rows[e.RowIndex].Cells[0].Value.ToString());
            this.selected = db.Films.Find(id);
            txtName.Text = this.selected.Name;
            txtYear.Text = this.selected.Year.Value.ToString();
            txtDirector.Text = this.selected.Director;
            txtAgeRes.Text = this.selected.AgeRes;
            txtDuration.Text = this.selected.Duration.ToString();
            dtpPrimiere.Value = this.selected.Premiere.Value;
            rtxtAbout.Text = this.selected.About;
            clbLanguage.Text = this.selected.Language.Name;
            clbSub.Text = this.selected.Language1.Name;

            this.clickRow = e.RowIndex;
            btnDelete.Visible = true;
            btnUpdate.Visible = true;


        }
        private void btnCreatePoster_Click(object sender, EventArgs e)
        {
            //if ();
            //{
            //    lblErrorInfo.Text = "if you didn't select contries and genres you can not create poster";
            //}
            //else
            //{
                this.Hide();
                Film_Posters fl_ps = new Film_Posters();
                fl_ps.Show();
           // }
           

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //if(this.selected.ID == 0)
            // {
            List<FilmCountry> contr = db.FilmCountries.ToList();
            List<FilmGenre> genr = db.FilmGenres.ToList();

            DialogResult r = MessageBox.Show("Eminsiniz mi ?", "Silme", MessageBoxButtons.OKCancel);
                if (r == DialogResult.OK)
                {
                foreach (FilmCountry item in contr)
                {
                    db.FilmCountries.Remove(item);
                }
                foreach (FilmGenre item in genr)
                {

                    db.FilmGenres.Remove(item);

                }
                db.Films.Remove(selected);
                db.SaveChanges();
                dgvFilms.Rows.RemoveAt(this.clickRow);
             
                      Reset();
                //}
            }
                }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
       
            lblError.Text = "";
            string name = txtName.Text;
            string year = txtYear.Text;
            string director = txtDirector.Text;
            string ageres = txtAgeRes.Text;
            string duration = txtDuration.Text;
            string date = dtpPrimiere.Value.ToString();
            string about = rtxtAbout.Text;
            string langauge = clbLanguage.Text;
            string subtit = clbSub.Text;

            if (year == string.Empty || director == string.Empty || ageres == string.Empty || duration == string.Empty)
            {
                lblError.Text = "* olan Xanalari doldurun";
                return;
            }
            if (!int.TryParse(year, out int Year))
            {
                lblError.Text = "ili duzgun daxil edin";
            }
            if (!int.TryParse(duration, out int Duration))
            {
                lblError.Text = "Filmin muddetini duzgun yazin!";
                return;
            }
            Model.Film kino = new Model.Film
            {
                Name = name,
                Year = Year,
                Director = director,
                AgeRes = ageres,
                Duration = Duration,
                LanguageID = FindLanguagesById(clbLanguage.Text),
                CcID = FindLanguagesById(clbSub.Text),
                Premiere = dtpPrimiere.Value,
              //  is3D = Convert.ToInt32(rbtn3D.Checked),
                About = about,
            };
            db.Films.Add(kino);
            db.SaveChanges();
            dgvFilms.Rows.Clear();
            FillGridFilms();
            Reset();


        }

        private void btnCreatePoster_MouseHover(object sender, EventArgs e)
        {
            lblErrorInfo.Text = "if you didn't select contries and genres you can not create poster";
        }
    }
        }
    

