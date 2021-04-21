using SimplePhotoDiary.Data_Access_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimplePhotoDiary.Data_Access_Layer
{
    class ImageDataAccess: DataBaseAccess
    {
        public List<Images> GetImages(int eventid)
        {
            string sql = "SELECT * FROM Images WHERE EventId =" + eventid;
            SqlDataReader reader = this.GetData(sql);
            List<Images> images = new List<Images>();
            if (reader.Read())
            {
                int co = 0;
                while (reader.Read())
                {
                    Images image = new Images();
                    image.ImageId = (int)reader["ImageId"];
                    image.Pictures = (byte[])reader["Pictures"];
                    image.Story = reader["Story"].ToString();
                    image.ModificationDate = reader["ModificationDate"].ToString();
                    image.EventId = (int)reader["EventId"];
                    images.Add(image);
                    co++;
                }
                MessageBox.Show("count " + Convert.ToString(co));
                MessageBox.Show("list " + Convert.ToString(images.Count));
                return images;
            }
            else
            {
                return null;
            }
        }

        public Images GetImage(int imageid)
        {
            string sql = "SELECT * FROM Images WHERE ImageId =" + imageid;
            SqlDataReader reader = this.GetData(sql);
            if (reader.Read())
            {
                Images image = new Images();
                image.ImageId = (int)reader["ImageId"];
                image.Pictures = (byte[])reader["Pictures"];
                image.Story = reader["Story"].ToString();
                image.ModificationDate = reader["ModificationDate"].ToString();
                image.EventId = (int)reader["EventId"];
                return image;
            }
            return null;
        }

        public int AddAnImage(Images receive)
        {
            string sql = "INSERT INTO Images (Story, ModificationDate, EventId, Pictures) VALUES ('" + receive.Story + "', '" + receive.ModificationDate + "', '" + receive.EventId + "', @pictures)";
            return this.ImageAdditionQueryExecution(sql, receive.Pictures);

        }

        public int UpdateAnImage(Images receive)
        {
            string sql = "UPDATE Images SET Story = '" + receive.Story + "', ModificationDate = '" + receive.ModificationDate + "', Pictures = @pictures WHERE ImageId = " + receive.ImageId;
            return this.ImageAdditionQueryExecution(sql, receive.Pictures);

        }

        public int DeleteAnImage(int id)
        {
            string sql = "DELETE FROM Images WHERE ImageId =" + id;
            return this.QueryExecution(sql);


        }

        public byte[] ConvertImageToBytes(Image receive)
        {
            MemoryStream memoryStream = new MemoryStream();
            receive.Save(memoryStream, receive.RawFormat);
            byte[] image = memoryStream.GetBuffer();
            memoryStream.Close();
            return image;
            


            //MemoryStream memoryStream = new MemoryStream();
            //receive.Save(memoryStream, ImageFormat.Bmp);
            //byte[] photo = new byte[memoryStream.Length];
            //return photo;
            ////return true;
        }

        public Image ConvertBytesToImage(byte[] image)
        {
            MemoryStream memoryStream = new MemoryStream(image);
            return Image.FromStream(memoryStream);
        }


        public Image BrowseAnImage ()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpeg;*.jpg;*.png;*bmp;)|*.jpeg;*.jpg;*.png;*bmp;";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                return Image.FromFile(openFileDialog.FileName);
            }
            return null;
        }
    }
}
