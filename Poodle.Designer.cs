namespace Engine
{
    partial class Poodle
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Poodle));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.browseCorpus = new System.Windows.Forms.Button();
            this.browsePosting = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.goButton = new System.Windows.Forms.Button();
            this.isStem = new System.Windows.Forms.CheckBox();
            this.cacheButton = new System.Windows.Forms.Button();
            this.dictionaryButton = new System.Windows.Forms.Button();
            this.clearButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.LoadButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(81, 63);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(66, 20);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "corpus path";
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // browseCorpus
            // 
            this.browseCorpus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.browseCorpus.Location = new System.Drawing.Point(13, 63);
            this.browseCorpus.Name = "browseCorpus";
            this.browseCorpus.Size = new System.Drawing.Size(51, 20);
            this.browseCorpus.TabIndex = 1;
            this.browseCorpus.Text = "browse";
            this.browseCorpus.UseVisualStyleBackColor = true;
            this.browseCorpus.Click += new System.EventHandler(this.button1_Click);
            // 
            // browsePosting
            // 
            this.browsePosting.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.browsePosting.Location = new System.Drawing.Point(13, 96);
            this.browsePosting.Name = "browsePosting";
            this.browsePosting.Size = new System.Drawing.Size(50, 21);
            this.browsePosting.TabIndex = 2;
            this.browsePosting.Text = "browse";
            this.browsePosting.UseVisualStyleBackColor = true;
            this.browsePosting.Click += new System.EventHandler(this.button2_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(81, 97);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(66, 20);
            this.textBox2.TabIndex = 3;
            this.textBox2.Text = "posting path";
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // goButton
            // 
            this.goButton.Enabled = false;
            this.goButton.Location = new System.Drawing.Point(163, 73);
            this.goButton.Name = "goButton";
            this.goButton.Size = new System.Drawing.Size(34, 32);
            this.goButton.TabIndex = 4;
            this.goButton.Text = "Go!";
            this.goButton.UseVisualStyleBackColor = true;
            this.goButton.Click += new System.EventHandler(this.button3_Click);
            // 
            // isStem
            // 
            this.isStem.AutoSize = true;
            this.isStem.Location = new System.Drawing.Point(17, 140);
            this.isStem.Name = "isStem";
            this.isStem.Size = new System.Drawing.Size(67, 17);
            this.isStem.TabIndex = 5;
            this.isStem.Text = "Stemmer";
            this.isStem.UseVisualStyleBackColor = true;
            this.isStem.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // cacheButton
            // 
            this.cacheButton.Enabled = false;
            this.cacheButton.Location = new System.Drawing.Point(237, 18);
            this.cacheButton.Name = "cacheButton";
            this.cacheButton.Size = new System.Drawing.Size(91, 34);
            this.cacheButton.TabIndex = 7;
            this.cacheButton.Text = "Display Cache";
            this.cacheButton.UseVisualStyleBackColor = true;
        //    this.cacheButton.Click += new System.EventHandler(this.cacheButton_Click);
            // 
            // dictionaryButton
            // 
            this.dictionaryButton.Enabled = false;
            this.dictionaryButton.Location = new System.Drawing.Point(334, 18);
            this.dictionaryButton.Name = "dictionaryButton";
            this.dictionaryButton.Size = new System.Drawing.Size(105, 33);
            this.dictionaryButton.TabIndex = 8;
            this.dictionaryButton.Text = "Display Dictionary";
            this.dictionaryButton.UseVisualStyleBackColor = true;
        //    this.dictionaryButton.Click += new System.EventHandler(this.dictionaryButton_Click);
            // 
            // clearButton
            // 
            this.clearButton.Enabled = false;
            this.clearButton.Location = new System.Drawing.Point(17, 178);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(64, 31);
            this.clearButton.TabIndex = 9;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // saveButton
            // 
            this.saveButton.Enabled = false;
            this.saveButton.Location = new System.Drawing.Point(237, 58);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(202, 23);
            this.saveButton.TabIndex = 10;
            this.saveButton.Text = "Save Dictionary and Cache to Files";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // LoadButton
            // 
            this.LoadButton.Enabled = false;
            this.LoadButton.Location = new System.Drawing.Point(238, 90);
            this.LoadButton.Name = "LoadButton";
            this.LoadButton.Size = new System.Drawing.Size(200, 25);
            this.LoadButton.TabIndex = 11;
            this.LoadButton.Text = "Load Dictionary and Cache";
            this.LoadButton.UseVisualStyleBackColor = true;
            this.LoadButton.Click += new System.EventHandler(this.LoadButton_Click);
            // 
            // Poodle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(479, 353);
            this.Controls.Add(this.LoadButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.dictionaryButton);
            this.Controls.Add(this.cacheButton);
            this.Controls.Add(this.isStem);
            this.Controls.Add(this.goButton);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.browsePosting);
            this.Controls.Add(this.browseCorpus);
            this.Controls.Add(this.textBox1);
            this.Name = "Poodle";
            this.Text = "Poodle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button browseCorpus;
        private System.Windows.Forms.Button browsePosting;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.CheckBox stemmer;
    }
}

