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
    public partial class AddConGen : Form
    {
        CinemaEntities1 db = new CinemaEntities1();
        public AddConGen()
        {
            InitializeComponent();
            FillFilms();
            FillGenres();
            FillCountries();
        }
        private void FillFilms()
        {
            List<Film> fil = db.Films.ToList();
            foreach (Film item in fil)
            {

                cmbFilm.Items.Add(item.Name);

            }
        }
        private void FillGenres()
        {
            List<Genre> gnr = db.Genres.ToList();
            foreach (Genre item in gnr)
            {
                clbGenre.Items.Add(item.Name);
            }
        }
        private void FillCountries()
        {
            List<Country> cont = db.Countries.ToList();
            foreach (Country item in cont)
            {
                clbCountry.Items.Add(item.Name);
            }
        }
        private int FindFilmIdByName()
        {
            int filmId = Convert.ToInt32(db.Films.FirstOrDefault(l => l.Name == cmbFilm.Text).ID);
            return filmId;
        }
        private int FindCountryIdByName()
        {
            int CounId = Convert.ToInt32(db.Countries.FirstOrDefault(l => l.Name == clbCountry.Text).ID);
            return CounId;
        }
        private int FindGenreIdByName()
        {
            int GenrId = Convert.ToInt32(db.Genres.FirstOrDefault(l => l.Name == clbGenre.Text).ID);
            return GenrId;
        }

        private void bntAdd_Click(object sender, EventArgs e)
        {
            FilmCountry filmCon = new FilmCountry();
            FilmGenre filmGen = new FilmGenre();
            filmCon.FilmID = FindFilmIdByName();
            filmCon.CountryID = FindCountryIdByName();
            filmGen.FilmID = FindFilmIdByName();
            filmGen.GenreID = FindGenreIdByName();
            db.FilmCountries.Add(filmCon);
            db.FilmGenres.Add(filmGen);
            db.SaveChanges();
            MessageBox.Show("successfully sent");
        }

        private void AddConGen_FormClosed(object sender, FormClosedEventArgs e)
        {
           // Application.Exit();
        }
    }
}
