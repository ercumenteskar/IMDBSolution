namespace IMDBDownload
{
  partial class Form1
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
      this.tb_movies = new System.Windows.Forms.TextBox();
      this.button1 = new System.Windows.Forms.Button();
      this.webBrowser1 = new System.Windows.Forms.WebBrowser();
      this.tb_users = new System.Windows.Forms.TextBox();
      this.tb_ratings = new System.Windows.Forms.TextBox();
      this.SuspendLayout();
      // 
      // tb_movies
      // 
      this.tb_movies.Location = new System.Drawing.Point(12, 29);
      this.tb_movies.MaxLength = 0;
      this.tb_movies.Multiline = true;
      this.tb_movies.Name = "tb_movies";
      this.tb_movies.Size = new System.Drawing.Size(111, 443);
      this.tb_movies.TabIndex = 0;
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(3, 478);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(406, 66);
      this.button1.TabIndex = 1;
      this.button1.Text = "button1";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // webBrowser1
      // 
      this.webBrowser1.Location = new System.Drawing.Point(433, 29);
      this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
      this.webBrowser1.Name = "webBrowser1";
      this.webBrowser1.ScriptErrorsSuppressed = true;
      this.webBrowser1.Size = new System.Drawing.Size(984, 515);
      this.webBrowser1.TabIndex = 2;
      this.webBrowser1.Url = new System.Uri("http://www.imdb.com", System.UriKind.Absolute);
      // 
      // tb_users
      // 
      this.tb_users.Location = new System.Drawing.Point(129, 29);
      this.tb_users.MaxLength = 0;
      this.tb_users.Multiline = true;
      this.tb_users.Name = "tb_users";
      this.tb_users.Size = new System.Drawing.Size(137, 443);
      this.tb_users.TabIndex = 3;
      // 
      // tb_ratings
      // 
      this.tb_ratings.Location = new System.Drawing.Point(272, 29);
      this.tb_ratings.MaxLength = 0;
      this.tb_ratings.Multiline = true;
      this.tb_ratings.Name = "tb_ratings";
      this.tb_ratings.Size = new System.Drawing.Size(137, 443);
      this.tb_ratings.TabIndex = 4;
      this.tb_ratings.WordWrap = false;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1429, 556);
      this.Controls.Add(this.tb_ratings);
      this.Controls.Add(this.tb_users);
      this.Controls.Add(this.webBrowser1);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.tb_movies);
      this.Name = "Form1";
      this.Text = "Form1";
      this.Load += new System.EventHandler(this.Form1_Load);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TextBox tb_movies;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.WebBrowser webBrowser1;
    private System.Windows.Forms.TextBox tb_users;
    private System.Windows.Forms.TextBox tb_ratings;
  }
}

