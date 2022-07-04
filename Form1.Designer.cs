namespace ApeirophobiaCodeCracker
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.redTextBox = new System.Windows.Forms.TextBox();
            this.greenTextBox = new System.Windows.Forms.TextBox();
            this.blueTextBox = new System.Windows.Forms.TextBox();
            this.yellowTextBox = new System.Windows.Forms.TextBox();
            this.purpleTextBox = new System.Windows.Forms.TextBox();
            this.orangeTextBox = new System.Windows.Forms.TextBox();
            this.greyTextBox = new System.Windows.Forms.TextBox();
            this.redLabel = new System.Windows.Forms.Label();
            this.greenLabel = new System.Windows.Forms.Label();
            this.blueLabel = new System.Windows.Forms.Label();
            this.greyLabel = new System.Windows.Forms.Label();
            this.yellowLabel = new System.Windows.Forms.Label();
            this.purpleLabel = new System.Windows.Forms.Label();
            this.orangeLabel = new System.Windows.Forms.Label();
            this.calculateButton = new System.Windows.Forms.Button();
            this.errorLabel = new System.Windows.Forms.Label();
            this.wrongInputErrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.codeIntroLabel = new System.Windows.Forms.Label();
            this.resultCodeLabel = new System.Windows.Forms.Label();
            this.copyButton = new System.Windows.Forms.Button();
            this.bannerLogoImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.wrongInputErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bannerLogoImage)).BeginInit();
            this.SuspendLayout();
            // 
            // redTextBox
            // 
            this.redTextBox.Location = new System.Drawing.Point(127, 180);
            this.redTextBox.MaxLength = 4;
            this.redTextBox.Name = "redTextBox";
            this.redTextBox.Size = new System.Drawing.Size(100, 27);
            this.redTextBox.TabIndex = 0;
            this.redTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.redTextBox_KeyPress);
            // 
            // greenTextBox
            // 
            this.greenTextBox.Location = new System.Drawing.Point(127, 252);
            this.greenTextBox.MaxLength = 4;
            this.greenTextBox.Name = "greenTextBox";
            this.greenTextBox.Size = new System.Drawing.Size(100, 27);
            this.greenTextBox.TabIndex = 0;
            this.greenTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.greenTextBox_KeyPress);
            // 
            // blueTextBox
            // 
            this.blueTextBox.Location = new System.Drawing.Point(127, 324);
            this.blueTextBox.MaxLength = 4;
            this.blueTextBox.Name = "blueTextBox";
            this.blueTextBox.Size = new System.Drawing.Size(100, 27);
            this.blueTextBox.TabIndex = 0;
            this.blueTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.blueTextBox_KeyPress);
            // 
            // yellowTextBox
            // 
            this.yellowTextBox.Location = new System.Drawing.Point(603, 180);
            this.yellowTextBox.MaxLength = 4;
            this.yellowTextBox.Name = "yellowTextBox";
            this.yellowTextBox.Size = new System.Drawing.Size(100, 27);
            this.yellowTextBox.TabIndex = 0;
            this.yellowTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.yellowTextBox_KeyPress);
            // 
            // purpleTextBox
            // 
            this.purpleTextBox.Location = new System.Drawing.Point(603, 252);
            this.purpleTextBox.MaxLength = 4;
            this.purpleTextBox.Name = "purpleTextBox";
            this.purpleTextBox.Size = new System.Drawing.Size(100, 27);
            this.purpleTextBox.TabIndex = 0;
            this.purpleTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.purpleTextBox_KeyPress);
            // 
            // orangeTextBox
            // 
            this.orangeTextBox.Location = new System.Drawing.Point(603, 324);
            this.orangeTextBox.MaxLength = 4;
            this.orangeTextBox.Name = "orangeTextBox";
            this.orangeTextBox.Size = new System.Drawing.Size(100, 27);
            this.orangeTextBox.TabIndex = 0;
            this.orangeTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.orangeTextBox_KeyPress);
            // 
            // greyTextBox
            // 
            this.greyTextBox.Location = new System.Drawing.Point(127, 396);
            this.greyTextBox.MaxLength = 4;
            this.greyTextBox.Name = "greyTextBox";
            this.greyTextBox.Size = new System.Drawing.Size(100, 27);
            this.greyTextBox.TabIndex = 0;
            this.greyTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.greyTextBox_KeyPress);
            // 
            // redLabel
            // 
            this.redLabel.AutoSize = true;
            this.redLabel.ForeColor = System.Drawing.Color.Silver;
            this.redLabel.Location = new System.Drawing.Point(56, 188);
            this.redLabel.Name = "redLabel";
            this.redLabel.Size = new System.Drawing.Size(39, 19);
            this.redLabel.TabIndex = 1;
            this.redLabel.Text = "Red";
            // 
            // greenLabel
            // 
            this.greenLabel.AutoSize = true;
            this.greenLabel.ForeColor = System.Drawing.Color.Silver;
            this.greenLabel.Location = new System.Drawing.Point(38, 255);
            this.greenLabel.Name = "greenLabel";
            this.greenLabel.Size = new System.Drawing.Size(57, 19);
            this.greenLabel.TabIndex = 1;
            this.greenLabel.Text = "Green";
            // 
            // blueLabel
            // 
            this.blueLabel.AutoSize = true;
            this.blueLabel.ForeColor = System.Drawing.Color.Silver;
            this.blueLabel.Location = new System.Drawing.Point(53, 332);
            this.blueLabel.Name = "blueLabel";
            this.blueLabel.Size = new System.Drawing.Size(42, 19);
            this.blueLabel.TabIndex = 1;
            this.blueLabel.Text = "Blue";
            // 
            // greyLabel
            // 
            this.greyLabel.AutoSize = true;
            this.greyLabel.ForeColor = System.Drawing.Color.Silver;
            this.greyLabel.Location = new System.Drawing.Point(49, 404);
            this.greyLabel.Name = "greyLabel";
            this.greyLabel.Size = new System.Drawing.Size(46, 19);
            this.greyLabel.TabIndex = 1;
            this.greyLabel.Text = "Grey";
            // 
            // yellowLabel
            // 
            this.yellowLabel.AutoSize = true;
            this.yellowLabel.ForeColor = System.Drawing.Color.Silver;
            this.yellowLabel.Location = new System.Drawing.Point(513, 188);
            this.yellowLabel.Name = "yellowLabel";
            this.yellowLabel.Size = new System.Drawing.Size(60, 19);
            this.yellowLabel.TabIndex = 1;
            this.yellowLabel.Text = "Yellow";
            // 
            // purpleLabel
            // 
            this.purpleLabel.AutoSize = true;
            this.purpleLabel.ForeColor = System.Drawing.Color.Silver;
            this.purpleLabel.Location = new System.Drawing.Point(515, 260);
            this.purpleLabel.Name = "purpleLabel";
            this.purpleLabel.Size = new System.Drawing.Size(58, 19);
            this.purpleLabel.TabIndex = 1;
            this.purpleLabel.Text = "Purple";
            // 
            // orangeLabel
            // 
            this.orangeLabel.AutoSize = true;
            this.orangeLabel.ForeColor = System.Drawing.Color.Silver;
            this.orangeLabel.Location = new System.Drawing.Point(504, 332);
            this.orangeLabel.Name = "orangeLabel";
            this.orangeLabel.Size = new System.Drawing.Size(69, 19);
            this.orangeLabel.TabIndex = 1;
            this.orangeLabel.Text = "Orange";
            // 
            // calculateButton
            // 
            this.calculateButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.calculateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(58)))), ((int)(((byte)(67)))));
            this.calculateButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.calculateButton.FlatAppearance.BorderSize = 2;
            this.calculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateButton.ForeColor = System.Drawing.Color.Silver;
            this.calculateButton.Location = new System.Drawing.Point(334, 539);
            this.calculateButton.Margin = new System.Windows.Forms.Padding(0);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(124, 41);
            this.calculateButton.TabIndex = 2;
            this.calculateButton.TabStop = false;
            this.calculateButton.Text = "Calculate";
            this.calculateButton.UseVisualStyleBackColor = false;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // errorLabel
            // 
            this.errorLabel.AutoSize = true;
            this.errorLabel.ForeColor = System.Drawing.Color.Red;
            this.errorLabel.Location = new System.Drawing.Point(12, 507);
            this.errorLabel.Name = "errorLabel";
            this.errorLabel.Size = new System.Drawing.Size(0, 19);
            this.errorLabel.TabIndex = 3;
            // 
            // wrongInputErrorProvider
            // 
            this.wrongInputErrorProvider.ContainerControl = this;
            this.wrongInputErrorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("wrongInputErrorProvider.Icon")));
            // 
            // codeIntroLabel
            // 
            this.codeIntroLabel.AutoSize = true;
            this.codeIntroLabel.ForeColor = System.Drawing.Color.Silver;
            this.codeIntroLabel.Location = new System.Drawing.Point(494, 518);
            this.codeIntroLabel.Name = "codeIntroLabel";
            this.codeIntroLabel.Size = new System.Drawing.Size(0, 19);
            this.codeIntroLabel.TabIndex = 4;
            // 
            // resultCodeLabel
            // 
            this.resultCodeLabel.AutoSize = true;
            this.resultCodeLabel.ForeColor = System.Drawing.Color.Silver;
            this.resultCodeLabel.Location = new System.Drawing.Point(494, 550);
            this.resultCodeLabel.Name = "resultCodeLabel";
            this.resultCodeLabel.Size = new System.Drawing.Size(0, 19);
            this.resultCodeLabel.TabIndex = 4;
            // 
            // copyButton
            // 
            this.copyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.copyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.copyButton.BackgroundImage = global::ApeirophobiaCodeCracker.Properties.Resources.clipboard;
            this.copyButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.copyButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.copyButton.FlatAppearance.BorderSize = 0;
            this.copyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.copyButton.ForeColor = System.Drawing.Color.Silver;
            this.copyButton.Location = new System.Drawing.Point(667, 539);
            this.copyButton.Margin = new System.Windows.Forms.Padding(0);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(36, 30);
            this.copyButton.TabIndex = 2;
            this.copyButton.TabStop = false;
            this.copyButton.UseVisualStyleBackColor = false;
            this.copyButton.Visible = false;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // bannerLogoImage
            // 
            this.bannerLogoImage.BackgroundImage = global::ApeirophobiaCodeCracker.Properties.Resources.banner_image;
            this.bannerLogoImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.bannerLogoImage.Location = new System.Drawing.Point(12, 12);
            this.bannerLogoImage.Name = "bannerLogoImage";
            this.bannerLogoImage.Size = new System.Drawing.Size(769, 143);
            this.bannerLogoImage.TabIndex = 5;
            this.bannerLogoImage.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(44)))), ((int)(((byte)(51)))));
            this.ClientSize = new System.Drawing.Size(793, 605);
            this.Controls.Add(this.bannerLogoImage);
            this.Controls.Add(this.resultCodeLabel);
            this.Controls.Add(this.codeIntroLabel);
            this.Controls.Add(this.errorLabel);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.greyLabel);
            this.Controls.Add(this.blueLabel);
            this.Controls.Add(this.greenLabel);
            this.Controls.Add(this.orangeLabel);
            this.Controls.Add(this.purpleLabel);
            this.Controls.Add(this.yellowLabel);
            this.Controls.Add(this.redLabel);
            this.Controls.Add(this.greyTextBox);
            this.Controls.Add(this.orangeTextBox);
            this.Controls.Add(this.blueTextBox);
            this.Controls.Add(this.purpleTextBox);
            this.Controls.Add(this.yellowTextBox);
            this.Controls.Add(this.greenTextBox);
            this.Controls.Add(this.redTextBox);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(62)))), ((int)(((byte)(120)))), ((int)(((byte)(138)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Apeirophobia Code Cracker";
            ((System.ComponentModel.ISupportInitialize)(this.wrongInputErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bannerLogoImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox redTextBox;
        private TextBox greenTextBox;
        private TextBox blueTextBox;
        private TextBox yellowTextBox;
        private TextBox purpleTextBox;
        private TextBox orangeTextBox;
        private TextBox greyTextBox;
        private Label redLabel;
        private Label greenLabel;
        private Label blueLabel;
        private Label greyLabel;
        private Label yellowLabel;
        private Label purpleLabel;
        private Label orangeLabel;
        private Button calculateButton;
        private Label errorLabel;
        private ErrorProvider wrongInputErrorProvider;
        private Label codeIntroLabel;
        private Label resultCodeLabel;
        private Button copyButton;
        private PictureBox bannerLogoImage;
    }
}