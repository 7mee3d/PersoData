
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

            this.Size = new Size(1214, 854);
           

        }

        private void btnShowAll_Click(object sender, EventArgs e)
        {
            Form frmShowAll = new Form();
            TextBox txtShowAll = new TextBox();

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

                SW.Close();
                ResetTextBoxs();

                pictureBoxImage.Image = Image.FromFile("C:\\Users\\PC\\Desktop\\Files Icons and Images\\NothingMan.jpg");

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
                            FileStream Filet = File.Open(pathImage, FileMode.Open);

                            Bitmap BTM = new Bitmap(Filet);

                            Filet.Close();

                            pictureBoxImage.Image = BTM;

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
    }
}

