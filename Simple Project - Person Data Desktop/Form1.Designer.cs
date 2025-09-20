namespace Simple_Project___Person_Data_Desktop
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            LabID = new Label();
            textBoxID = new TextBox();
            textBoxName = new TextBox();
            labelName = new Label();
            textBoxAddress = new TextBox();
            label1 = new Label();
            buttonAdd = new Button();
            btnFind = new Button();
            btnShowAll = new Button();
            toolTip1 = new ToolTip(components);
            label2 = new Label();
            pictureBoxImage = new PictureBox();
            button1 = new Button();
            pictureBoxBack = new PictureBox();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBack).BeginInit();
            SuspendLayout();
            // 
            // LabID
            // 
            LabID.AutoSize = true;
            LabID.BackColor = Color.White;
            LabID.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            LabID.ForeColor = Color.RoyalBlue;
            LabID.Location = new Point(36, 360);
            LabID.Name = "LabID";
            LabID.Size = new Size(35, 30);
            LabID.TabIndex = 0;
            LabID.Text = "ID";
            // 
            // textBoxID
            // 
            textBoxID.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxID.Location = new Point(133, 361);
            textBoxID.Multiline = true;
            textBoxID.Name = "textBoxID";
            textBoxID.Size = new Size(303, 29);
            textBoxID.TabIndex = 1;
            toolTip1.SetToolTip(textBoxID, "This is ID Person");
            // 
            // textBoxName
            // 
            textBoxName.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxName.Location = new Point(133, 430);
            textBoxName.Multiline = true;
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(303, 29);
            textBoxName.TabIndex = 3;
            toolTip1.SetToolTip(textBoxName, "This is Name Person");
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.BackColor = Color.White;
            labelName.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            labelName.ForeColor = Color.RoyalBlue;
            labelName.Location = new Point(36, 429);
            labelName.Name = "labelName";
            labelName.Size = new Size(71, 30);
            labelName.TabIndex = 2;
            labelName.Text = "Name";
            labelName.Click += labelName_Click;
            // 
            // textBoxAddress
            // 
            textBoxAddress.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBoxAddress.Location = new Point(133, 505);
            textBoxAddress.Multiline = true;
            textBoxAddress.Name = "textBoxAddress";
            textBoxAddress.Size = new Size(303, 29);
            textBoxAddress.TabIndex = 5;
            toolTip1.SetToolTip(textBoxAddress, "This is Address Person ");
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.White;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold);
            label1.ForeColor = Color.RoyalBlue;
            label1.Location = new Point(36, 504);
            label1.Name = "label1";
            label1.Size = new Size(91, 30);
            label1.TabIndex = 4;
            label1.Text = "Address";
            // 
            // buttonAdd
            // 
            buttonAdd.BackColor = Color.RoyalBlue;
            buttonAdd.Cursor = Cursors.Hand;
            buttonAdd.FlatStyle = FlatStyle.Popup;
            buttonAdd.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAdd.ForeColor = Color.White;
            buttonAdd.Location = new Point(193, 672);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(119, 47);
            buttonAdd.TabIndex = 6;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // btnFind
            // 
            btnFind.BackColor = Color.RoyalBlue;
            btnFind.Cursor = Cursors.Hand;
            btnFind.FlatStyle = FlatStyle.Popup;
            btnFind.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFind.ForeColor = Color.White;
            btnFind.Location = new Point(329, 672);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(119, 47);
            btnFind.TabIndex = 6;
            btnFind.Text = "Find";
            btnFind.UseVisualStyleBackColor = false;
            btnFind.Click += btnFind_Click;
            // 
            // btnShowAll
            // 
            btnShowAll.BackColor = Color.RoyalBlue;
            btnShowAll.Cursor = Cursors.Hand;
            btnShowAll.FlatStyle = FlatStyle.Popup;
            btnShowAll.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShowAll.ForeColor = Color.White;
            btnShowAll.Location = new Point(465, 672);
            btnShowAll.Name = "btnShowAll";
            btnShowAll.Size = new Size(119, 47);
            btnShowAll.TabIndex = 6;
            btnShowAll.Text = "Show All";
            btnShowAll.UseVisualStyleBackColor = false;
            btnShowAll.Click += btnShowAll_Click;
            // 
            // toolTip1
            // 
            toolTip1.IsBalloon = true;
            toolTip1.ToolTipIcon = ToolTipIcon.Info;
            toolTip1.ToolTipTitle = "Note ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Modern No. 20", 120F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.RoyalBlue;
            label2.Location = new Point(12, 96);
            label2.Name = "label2";
            label2.Size = new Size(876, 164);
            label2.TabIndex = 7;
            label2.Text = "Person Data";
            // 
            // pictureBoxImage
            // 
            pictureBoxImage.BackColor = Color.Transparent;
            pictureBoxImage.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBoxImage.Image = (Image)resources.GetObject("pictureBoxImage.Image");
            pictureBoxImage.Location = new Point(467, 308);
            pictureBoxImage.Name = "pictureBoxImage";
            pictureBoxImage.Size = new Size(251, 248);
            pictureBoxImage.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxImage.TabIndex = 8;
            pictureBoxImage.TabStop = false;
            // 
            // button1
            // 
            button1.BackColor = Color.RoyalBlue;
            button1.Cursor = Cursors.Hand;
            button1.FlatStyle = FlatStyle.Popup;
            button1.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(523, 562);
            button1.Name = "button1";
            button1.Size = new Size(138, 47);
            button1.TabIndex = 6;
            button1.Text = "Select Image";
            button1.UseVisualStyleBackColor = false;
            button1.Click += buttonSelectImage_Click;
            // 
            // pictureBoxBack
            // 
            pictureBoxBack.Image = (Image)resources.GetObject("pictureBoxBack.Image");
            pictureBoxBack.Location = new Point(110, 672);
            pictureBoxBack.Name = "pictureBoxBack";
            pictureBoxBack.Size = new Size(66, 47);
            pictureBoxBack.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBoxBack.TabIndex = 9;
            pictureBoxBack.TabStop = false;
            pictureBoxBack.Click += pictureBoxBack_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.RoyalBlue;
            button2.Cursor = Cursors.Hand;
            button2.FlatStyle = FlatStyle.Popup;
            button2.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.White;
            button2.Location = new Point(110, 738);
            button2.Name = "button2";
            button2.Size = new Size(474, 47);
            button2.TabIndex = 6;
            button2.Text = "Show All IInformation And Image Person";
            button2.UseVisualStyleBackColor = false;
            button2.Click += btnShowAllImagePerso_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1256, 834);
            Controls.Add(pictureBoxBack);
            Controls.Add(pictureBoxImage);
            Controls.Add(label2);
            Controls.Add(button1);
            Controls.Add(button2);
            Controls.Add(btnShowAll);
            Controls.Add(btnFind);
            Controls.Add(buttonAdd);
            Controls.Add(textBoxAddress);
            Controls.Add(label1);
            Controls.Add(textBoxName);
            Controls.Add(labelName);
            Controls.Add(textBoxID);
            Controls.Add(LabID);
            DoubleBuffered = true;
            ForeColor = Color.CornflowerBlue;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "Form1";
            Text = "Person Data";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBoxImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBoxBack).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label LabID;
        private TextBox textBoxID;
        private TextBox textBoxName;
        private Label labelName;
        private TextBox textBoxAddress;
        private Label label1;
        private Button buttonAdd;
        private Button btnFind;
        private Button btnShowAll;
        private ToolTip toolTip1;
        private Label label2;
        private PictureBox pictureBoxImage;
        private Button button1;
        private PictureBox pictureBoxBack;
        private Button button2;
    }
}
