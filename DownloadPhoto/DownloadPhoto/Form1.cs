using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DownloadPhoto
{
    public partial class Form1 : Form
    {
        private Searcher srch;
        private List<Image> lstImg;
        static int index = 0;
        public Form1()
        {
            InitializeComponent();
            srch = new Searcher();
        }

        private void bttnSrtat_Click(object sender, EventArgs e)
        {
            string SearchString = srch.Corect(txtBxSearch.Text);
            lblSearchResults.Visible = false;
            try
            {
                if (srch.DowloadHtml(SearchString))
                {
                    if (srch.FindCover())
                    {
                        lstImg = srch.Cover;
                        if (lstImg != null && lstImg.Count != 0)
                        {
                            pictureBox1.Image = lstImg[index];
                            bttnAutoSave.Enabled = true;
                            bttnSave.Enabled = true;
                        }
                        else
                        {
                            lblSearchResults.Text = "Search for patent images failed";
                            lblSearchResults.Visible = true;
                        }
                    }
                    else
                    {
                        lblSearchResults.Text = "Search for patent images failed";
                        lblSearchResults.Visible = true;
                    }
                }
                else
                {
                    lblSearchResults.Text = "Search for patent images failed";
                    lblSearchResults.Visible = true;
                }
            }
            catch (Exception)
            {
                lblSearchResults.Text = "Search for patent images failed";
                lblSearchResults.Visible = true;
            }
            
        }

        private void bttnR_Click(object sender, EventArgs e)
        {
            if (lstImg != null) {
                if (++index < lstImg.Count) pictureBox1.Image = lstImg[index];
                else index--;
            }
        }

        private void bttnL_Click(object sender, EventArgs e)
        {
            if (lstImg != null)
            {
                --index;
                if (index >= 0) pictureBox1.Image = lstImg[index];
                else index++;
            }
        }

        private void bttnSave_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "png Image (*.png)|*.png|All img (*.*)|*.*";
            saveFileDialog1.FilterIndex = 2;
            saveFileDialog1.RestoreDirectory = true;

            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Image not uploaded");
            }
           
            else if (saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                saveFileDialog1.Filter = "Images|*.png;*.bmp;*.jpg";
                pictureBox1.Image.Save(saveFileDialog1.FileName);
            }
        }

        private void bttnAutoSave_Click(object sender, EventArgs e)
        {
            srch.ImgDnld();
            MessageBox.Show("saving all photos to happen on disk D:");
        }
    }
}
