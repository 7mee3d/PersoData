
using System.IO;
namespace Simple_Project___Person_Data_Desktop
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void labelName_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            //The Form Exit or Application Exit 

            // Application.Exit();


            //Back Form 

            Application.OpenForms[0].Show();
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // هاد الكود بغيرلك او بجيبلك الملف او صورة الملف حتى لو تغير اسمه بجيبلك اسمه حتى لو تغير 
            // عشان يقدر يجيبلك الصورة الايقونة وما يستهلك مساحة ف الذاكرة 

            //this.Icon = Icon.ExtractAssociatedIcon(AppDomain.CurrentDomain.FriendlyName); 

            int xWidth = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;
            int yHeight = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;

            this.Location = new Point(xWidth, yHeight);

            this.Size = new Size(1276, 877);


        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {

            int xWidth = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;
            int yHeight = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;

      


            Form frmShowAll = new Form();
            TextBox txtShowAll = new TextBox();
            frmShowAll.Text = "Information All Persons";
            frmShowAll.Icon = Icon.ExtractAssociatedIcon("C:\\Users\\PC\\Desktop\\Files Icons and Images\\open-book_16682324.ico");
            frmShowAll.MinimizeBox = false; 
            frmShowAll.MaximizeBox = false;
            frmShowAll.Size = new Size(1276, 877);
            frmShowAll.Location = new Point(xWidth, yHeight); 


            txtShowAll.Font = new Font("Modern No. 20", 35f, FontStyle.Bold);
            frmShowAll.Location = this.Location;
            frmShowAll.Size = this.Size;
            frmShowAll.StartPosition = FormStartPosition.CenterScreen;

            txtShowAll.Multiline = true;
            txtShowAll.Dock = DockStyle.Fill;

            // اقرأ البيانات أول
            string alldata = "";
            using (StreamReader SRR = new StreamReader("DataPerson.txt"))
            {
                alldata = SRR.ReadToEnd();
            }

            txtShowAll.Text = alldata;
            frmShowAll.Controls.Add(txtShowAll);

            // بعد ما تعبي البيانات افتح الفورم
            frmShowAll.ShowDialog();
        }


        private void ResetTextBoxs()
        {
            foreach (Control con in this.Controls)
            {
                if (con is TextBox)
                    con.Text = "";
            }

            textBoxID.Focus();
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text.Trim() == "" || textBoxAddress.Text.Trim() == "" || textBoxName.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter the All Boxes ", "Note", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                return;
            }
            StreamReader SR = new StreamReader("DataPerson.txt");
            string line = "";

            bool Exsits = false;


            while ((line = SR.ReadLine()) != null)
            {

                string[] splits = line.Split(";");

                if (splits[0] == textBoxID.Text)
                {
                    Exsits = true;
                    break;

                }
            }

            SR.Close();

            if (Exsits)
            {
                MessageBox.Show("Person is Already Exsits,Try Add Agian ", "Note", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                pictureBoxImage.Image = Image.FromFile("C:\\Users\\PC\\Desktop\\Files Icons and Images\\NothingMan.jpg");

                ResetTextBoxs();

            }
            else
            {

                StreamWriter SW = new StreamWriter("DataPerson.txt", true);
                string lineInformationPerson = textBoxID.Text + ";" + textBoxName.Text + ";" + textBoxAddress.Text;

                SW.WriteLine(lineInformationPerson);
                if (!Directory.Exists("img"))
                {
                    Directory.CreateDirectory("img");

                }

                pictureBoxImage.Image.Save("img/" + textBoxID.Text + ".jpg");
                MessageBox.Show("Person Add Sccessfully", "Note", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

               

                pictureBoxImage.Image = Image.FromFile("C:\\Users\\PC\\Desktop\\Files Icons and Images\\NothingMan.jpg");
                SW.Close();
                ResetTextBoxs();
            }
        }



        private void btnFind_Click(object sender, EventArgs e)
        {
            if (textBoxID.Text.Trim() != "")
            {
                string line = "";
                StreamReader SR = new StreamReader("DataPerson.txt");

                bool isExsits = false;

                string[] Splits = { "", "", "" };

                while ((line = SR.ReadLine()) != "")
                {
                    if (line != null)
                        Splits = line.Split(";");
                    else
                        break;


                    if (Splits[0] == textBoxID.Text)
                    {

                        textBoxName.Text = Splits[1];
                        textBoxAddress.Text = Splits[2];
                        string pathImage = "img/" + textBoxID.Text + ".jpg";

                        if (File.Exists(pathImage))
                        {


                            pictureBoxImage.Image = Image.FromFile(pathImage);
                            /*FileStream Filet = File.Open(pathImage, FileMode.Open);

                            Bitmap BTM = new Bitmap(Filet);

                            Filet.Close();

                            pictureBoxImage.Image = BTM;*/


                        }
                        else
                        {
                            pictureBoxImage.Image = Image.FromFile("C:\\Users\\PC\\Desktop\\Files Icons and Images\\NothingMan.jpg");

                        }
                        isExsits = true;

                        break;

                    }

                }
                SR.Close();

                if (!isExsits)
                {
                    MessageBox.Show("This Person Not Found , Enter another ID Person to Cheak is Exsits or not ", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
                    textBoxID.Focus();
                    textBoxID.SelectAll();
                    pictureBoxImage.Image = Image.FromFile("C:\\Users\\PC\\Desktop\\Files Icons and Images\\NothingMan.jpg");

                }
            }
            else
            {
                MessageBox.Show("Please Enter the ID Person to Find", "Warning", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                pictureBoxImage.Image = Image.FromFile("C:\\Users\\PC\\Desktop\\Files Icons and Images\\NothingMan.jpg");

            }

        }

        private void buttonSelectImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog OFD = new OpenFileDialog();
            OFD.Title = "Select Image";
            OFD.Filter = "Images|*.png;*jpg";
            if (OFD.ShowDialog() == DialogResult.OK)
            {

                pictureBoxImage.Image = Image.FromFile(OFD.FileName);


            }
        }

        private void pictureBoxBack_Click(object sender, EventArgs e)
        {
            Application.OpenForms[0].Show();
            this.Close();
        }

        private void btnShowAllImagePerso_Click(object sender, EventArgs e)
        {
            int xWidth = (Screen.PrimaryScreen.Bounds.Width - this.Width) / 2;
            int yHeight = (Screen.PrimaryScreen.Bounds.Height - this.Height) / 2;

            Form FrmNew = new Form();

            FrmNew.Text = "Information & Images All Persons";
            FrmNew.Icon = Icon.ExtractAssociatedIcon("C:\\Users\\PC\\Desktop\\Files Icons and Images\\open-book_16682324.ico");
            FrmNew.MinimizeBox = false;
            FrmNew.MaximizeBox = false;
            FrmNew.Size = new Size(1276, 877);
            FrmNew.Location = new Point(xWidth, yHeight);

            Label newLabelInformation = new Label();
            Label newLabelImage = new Label();
            newLabelInformation.Text = "Information";
            newLabelInformation.Top = 30;
            newLabelInformation.Left = 100;
            newLabelInformation.AutoSize = true;
            newLabelInformation.Font = new Font("Modern No. 20", 25f, FontStyle.Bold);
            newLabelInformation.ForeColor = Color.RoyalBlue;


            newLabelImage.Text = "Image";
            newLabelImage.Top = 30;
            newLabelImage.Left = 750;
            newLabelImage.AutoSize = true;
            newLabelImage.Font = new Font("Modern No. 20", 25f, FontStyle.Bold);
            newLabelImage.ForeColor = Color.RoyalBlue;


            FrmNew.Location = new Point (101, 730 ) ;
            FrmNew.Size = this.Size;
            FrmNew.StartPosition = FormStartPosition.CenterScreen;
            FrmNew.BackColor = Color.White; 

            FrmNew.AutoScroll = true;

            int TopControlsTxt =100;
            string line = "";

            StreamReader SR = new StreamReader("DataPerson.txt");

            do
            {
                line = SR.ReadLine(); 

                if (line !=null)
                {

                    string[] informationPersonOne = line.Split(";");
                    TextBox txtBox = new TextBox();
                    txtBox.Left = 10;
                    txtBox.Top = TopControlsTxt;
                    txtBox.Width =550;
                    txtBox.Multiline = true; 
                    txtBox.Height = 250;
                    txtBox.Font = new Font("Modern No. 20", 20f, FontStyle.Bold);


                    txtBox.Text = Environment.NewLine + Environment.NewLine  +  "ID Person : " + informationPersonOne[0].ToString() + Environment.NewLine + Environment.NewLine 
                        + "Name Person : " + informationPersonOne[1].ToString() + Environment.NewLine  + Environment.NewLine 
                        + "Address Person : " + informationPersonOne[2].ToString();


                    PictureBox picBox = new PictureBox();
                    picBox.Width = 250;
                    picBox.Height = 250;
                    picBox.Left = txtBox.Width + 100;
                    picBox.Top = TopControlsTxt;

                    string pathImage = "img/" + informationPersonOne[0] + ".jpg";
                    picBox.SizeMode = PictureBoxSizeMode.StretchImage; 
                    if(File.Exists(pathImage ))
                    {
                        picBox.Image = Image.FromFile(pathImage);

                    }
                    FrmNew.Controls.Add(txtBox); 
                    FrmNew.Controls.Add(picBox); 

                }

                TopControlsTxt += 350;
            } while (line != null);
            FrmNew.Controls.Add(newLabelInformation);
            FrmNew.Controls.Add(newLabelImage);

            SR.Close(); 

            FrmNew.ShowDialog();
        }
    }
}

