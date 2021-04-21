using SimplePhotoDiary.Data_Access_Layer.Entities;
using SimplePhotoDiary.Service_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplePhotoDiary.Presentation_Layer
{
    public partial class ImageActions : Form
    {
        private int usingEventId;
        private int usingUserId;
        public ImageActions(int eventid, int userid)
        {
            InitializeComponent();
            this.usingEventId = eventid;
            this.usingUserId = userid;
        }

        private void ImageActions_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void AImageB_Click(object sender, EventArgs e)
        {
            ImageDataService imageDataService = new ImageDataService();
            byte[] pictures = imageDataService.ByteConversion(pictureBox.Image);
            int result = imageDataService.AddImage(pictures, ImageStoryBox.Text, ModificationDateBox.Text, this.usingEventId);
            if (result > 0)
            {
                MessageBox.Show("Image Added Succesfully!");
                imageListView.DataSource = imageDataService.GetImageList(this.usingEventId);
                pictureBox.Image = null;
                textBox1.Text = null;
            }
            else
            {
                MessageBox.Show("Sorry There Was An Error!");
                imageListView.DataSource = imageDataService.GetImageList(this.usingEventId);
                
            }
        }

        private void Upd_ImageB_Click(object sender, EventArgs e)
        {
            ImageDataService imageDataService = new ImageDataService();
            int result = imageDataService.UpdateImage(imageDataService.ByteConversion(pictureBox.Image) ,Upd_StoryBox.Text, Upd_DateBox.Text, Convert.ToInt32(Upd_ImageId.Text));
            if (result > 0)
            {
                MessageBox.Show("Image Updated Succesfully!");
                imageListView.DataSource = imageDataService.GetImageList(this.usingEventId);
                pictureBox.Image = null;
                textBox1.Text = null;
            }
            else
            {
                MessageBox.Show("Sorry There Was An Error!");
                imageListView.DataSource = imageDataService.GetImageList(this.usingEventId);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ImageDataService imageDataService = new ImageDataService();
            Images image = imageDataService.GetTheImage(Convert.ToInt32(Upd_ImageId.Text));
            if (image != null)
            {
                pictureBox.Image = imageDataService.ImageConversion(image.Pictures);
                Upd_StoryBox.Text = image.Story;
                Upd_DateBox.Text = image.ModificationDate;
            }
            else
            {
                MessageBox.Show("Invalid Image Id");
            }
        }

        private void Del_ImageB_Click(object sender, EventArgs e)
        {
            ImageDataService imageDataService = new ImageDataService();
            int result = imageDataService.DeleteImage(Convert.ToInt32(Del_ImageId.Text));
            if (result > 0)
            {
                MessageBox.Show("Image Deleted Succesfully!");
                imageListView.DataSource = imageDataService.GetImageList(this.usingEventId);
                pictureBox.Image = null;
                textBox1.Text = null;

            }
            else
            {
                MessageBox.Show("Sorry There Was An Error!");
                imageListView.DataSource = imageDataService.GetImageList(this.usingEventId);
            }

        }

        private void ImageActions_Load(object sender, EventArgs e)
        {
            ImageDataService imageDataService = new ImageDataService();
            imageListView.DataSource = imageDataService.GetImageList(this.usingEventId);
            if (imageListView.RowCount > 0)
            {
                byte[] image = (byte[])imageListView.Rows[0].Cells[1].Value;
                pictureBox.Image = imageDataService.ImageConversion(image);
                MessageBox.Show((imageListView.RowCount).ToString());

            }
            else
            {
                pictureBox.Image = null;
            }

        }

        private void imageListView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ImageDataService imageDataService = new ImageDataService();
            textBox1.Text = imageListView.Rows[e.RowIndex].Cells[2].Value.ToString();
            byte[] image = (byte[])imageListView.Rows[e.RowIndex].Cells[1].Value;
            pictureBox.Image = imageDataService.ImageConversion(image);
            Upd_ImageId.Text = imageListView.Rows[e.RowIndex].Cells[0].Value.ToString();

        }

        private void BrowseButton_Click(object sender, EventArgs e)
        {
            ImageDataService imageDataService = new ImageDataService();
            pictureBox.Image = imageDataService.BrowseImage();
            


        }

        private void button1_Click(object sender, EventArgs e)
        {
            ImageDataService imageDataService = new ImageDataService();
            Images images = imageDataService.GetTheImage(1);
            pictureBox.Image = imageDataService.ImageConversion(images.Pictures);
        }

        private void BackB_Click(object sender, EventArgs e)
        {
            this.Hide();
            EventActions eventActions = new EventActions(usingUserId);
            eventActions.Show();

        }
    }
}
