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
    public partial class Film_Posters : Form
    {
        CinemaEntities1 db = new CinemaEntities1();
        public Film_Posters()
        {
            InitializeComponent();
            FillDGridFilms();
            FillFilms();
        }

        private void Film_Posters_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Film_Posters_Load(object sender, EventArgs e)
        {
            //Model.Film kino = new Model.Film { };
            //dgvFilmsAllInfo.Rows.Add(
            // kino.ID,
            // kino.Name,
            // kino.Year,
            // kino.Director,
            // kino.AgeRes,
            // kino.Duration,
            // kino.Language.Name,
            // kino.Language1.Name,
            // kino.Premiere,
            // kino.is3D,
            // kino.About,
            // kino.Photo,
            // kino.Trialer
            // );

        }
        private void FillDGridFilms()
        {
            foreach (Film item in db.Films.OrderByDescending(f => f.ID).ToList())
            {
                dgvFilmsAllInfo.Rows.Add(
                     item.ID,
                     item.Name,
                     item.Year,
                     item.Director,
                     item.AgeRes,
                     item.Duration,
                     item.Language.Name,
                     item.Language1.Name,
                     item.Premiere,
                     item.is3D,
                     item.About,
                     item.Photo,
                     item.Trialer
                    );
            }
        }
        private void FillFilms()
        {
            List<Film> fil = db.Films.ToList();
            foreach (Film item in fil)
            {

               cmbFilms.Items.Add(item.Name);

            }
        }
    }
}
