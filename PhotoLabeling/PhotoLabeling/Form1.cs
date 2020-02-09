using System;
using System.IO;
using System.Windows.Forms;

//notations:
//  "_" in front of variabil name => global variabile


namespace PhotoLabeling
{
    public partial class Form1 : Form
    {
        #region variabiles
        string _path = "";
        //all files from path
        //future optimization : batch size
        string[] _files;
        int _rootIndex = 0;
        int _currentIndex = 0;
        //store all photos from a batch/label
        string[] _currnetPhotos;
        #endregion

        public Form1()
        {
            InitializeComponent();
            picPrev.SizeMode = PictureBoxSizeMode.StretchImage;
            picCurrent.SizeMode = PictureBoxSizeMode.StretchImage;
            picNext.SizeMode = PictureBoxSizeMode.StretchImage;
            //text path
            txtPath.Text = @"E:\Licenta\Hands\testLabel";
        }

        private void btnChosePath_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(chosePath());
            chosePath("");
            txtPath.Text = _path;
        }


        private void btnConfirm_Click(object sender, EventArgs e)
        {
            chosePath(txtPath.Text);
        }

        private void chosePath(string path)
        {
            if (string.IsNullOrEmpty(path))
            {
                using (var fbd = new FolderBrowserDialog())
                {
                    DialogResult result = fbd.ShowDialog();
                    if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
                    {
                        _path = fbd.SelectedPath;
                        _files = Directory.GetFiles(fbd.SelectedPath);
                        //System.Windows.Forms.MessageBox.Show("Files found: " + files.Length.ToString(), "Message");
                    }
                }
            }
            else
            {
                _path = path;
                _files = Directory.GetFiles(_path);
            }
        }

        //call just once!
        private void start()
        {
            loadImagesInPictureBox(0);
        }


        private void next()
        {
            loadImagesInPictureBox(1);
        }

        private void prev()
        {
            loadImagesInPictureBox(-1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            start();
        }



        private void loadImagesInPictureBox(int incrementValue)
        {
            _rootIndex = _rootIndex + incrementValue;

            try
            {
                picPrev.ImageLocation = _files[_rootIndex - 1];
            }
            catch (Exception e) {
                picPrev.InitialImage = null;
            }

            try
            {
                picCurrent.ImageLocation = _files[_rootIndex];
            }
            catch (Exception e) {
                picCurrent.InitialImage = null;
            }

            try
            {
                picNext.ImageLocation = _files[_rootIndex + 1];
            }
            catch (Exception e) {
                picNext.InitialImage = null;
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            next();
        }

        private void btnPrev_Click(object sender, EventArgs e)
        {
            prev();
        }
    }
}
