﻿using eProdaja.WinUI;
using MoviePick.Data.Model;
using MoviePick.Data.Request;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoviePick.WindowsFormsUI.Forms
{
    public partial class frmMovieAndTvShowDetails : Form
    {
        APIService _serviceMovieAndTvShow = new APIService("MovieAndTvShow");
        APIService _serviceProductionCompany = new APIService("ProductionCompany");

        private MovieAndTvshow _MTVS;

        public frmMovieAndTvShowDetails(MovieAndTvshow MTVS)
        {
            _MTVS = MTVS;
            InitializeComponent();
        }

        protected async override void OnLoad(EventArgs e)
        {
            await LoadProductionCompany();
            if (_MTVS != null)
            {
                txtTitle.Text = _MTVS.Title;
                txtBudget.Text = _MTVS.Budget.ToString();
                rtxtDescription.Text = _MTVS.Description;
                chkFinished.Checked = (bool)_MTVS.Finished;
                txtLang.Text = _MTVS.Language;
                dtRelaseDate.Value = _MTVS.ReleaseDate;
                txtRtime.Text = _MTVS.RunningTime;
                if (_MTVS.Poster != null && _MTVS.Poster.Length > 0)
                {
                    pictureBox2.Image = GetImage(_MTVS.Poster);
                    request.Poster = _MTVS.Poster;
                }
                if (_MTVS.TvshowSeason.Count() == 0)
                {
                    chkTvShow.Checked = false;
                    btnEditSeasons.Visible = false;
                }
                else
                {
                    chkTvShow.Checked = true;
                    btnEditSeasons.Visible = true;
                }
                cmbProductionComp.SelectedIndex = _MTVS.ProductionCompanyId;
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
                btnEditCast.Visible = true;
                btnQuotes.Visible = true;
            }
        }

        private async Task LoadProductionCompany()
        {
            var list = await _serviceProductionCompany.GetAll<List<ProductionCompany>>();
            cmbProductionComp.DataSource = list;
            list.Insert(0, new ProductionCompany());
            cmbProductionComp.ValueMember = "Id";
            cmbProductionComp.DisplayMember = "ProductionCompanyName";
        }

        private void btnImage_Click(object sender, EventArgs e)
        {
            var result = openFileDialog.ShowDialog();

            if (result == DialogResult.OK)
            {
                var fileName = openFileDialog.FileName;
                var file = File.ReadAllBytes(fileName);
                request.Poster = file;
                txtPoster.Text = fileName;

                Image img = Image.FromFile(fileName);
                pictureBox2.Image = img;
                pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private static Image GetImage(byte[] data)
        {
            using (MemoryStream ms = new MemoryStream(data))
            {
                return (Image.FromStream(ms));
            }
        }

        MovieAndTvshowUpsertRequest request = new MovieAndTvshowUpsertRequest();

        private async void btnSave_Click(object sender, EventArgs e)
        {
            request.Title = txtTitle.Text;
            request.Budget = double.Parse(txtBudget.Text);
            request.Description = rtxtDescription.Text;
            request.Finished = chkFinished.Checked;
            request.Language = txtLang.Text;
            request.NumberOfRatings = 0;
            request.ReleaseDate = dtRelaseDate.Value;
            request.RunningTime = txtRtime.Text;

            var idProductionComp = cmbProductionComp.SelectedValue;

            if (int.TryParse(idProductionComp.ToString(), out int idProductionCompany))
            {
                request.ProductionCompanyId = idProductionCompany;
            }

            var mtvs = await _serviceMovieAndTvShow.Update<MovieAndTvshow>(_MTVS.Id, request);
            MessageBox.Show("Operation successfully completed", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnEditCast_Click_1(object sender, EventArgs e)
        {
            frmCastAdd frm = new frmCastAdd(_MTVS);
            frm.ShowDialog();
        }

        private void btnQuotes_Click_1(object sender, EventArgs e)
        {
            frmQuoteDetails frm = new frmQuoteDetails(_MTVS);
            frm.ShowDialog();
        }

        private void btnEditSeasons_Click_1(object sender, EventArgs e)
        {
            frmTvShowSeasonEpisodesAdd frm = new frmTvShowSeasonEpisodesAdd(_MTVS);
            frm.ShowDialog();
        }

        private void chkTvShow_CheckedChanged_1(object sender, EventArgs e)
        {
            if (_MTVS != null)
            {
                if (chkTvShow.Checked)
                    btnEditSeasons.Visible = true;
                else
                    btnEditSeasons.Visible = false;
            }
        }
    }
}