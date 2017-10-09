using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using My;
using System.Threading;
using System.Text.RegularExpressions;

namespace IMDBDownload
{
  public partial class Form1 : Form
  {
    int counter = 0;
    public Form1()
    {
      InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
      tb_ratings.Text = GetCookies();
      return;
      //button1.Visible = false;
      string str = "";
      int userc = 0;
      /*
      int filmc = 0;
      String lastid = "";
      List<String> ulist = new List<String>();
      foreach (string line in tb_movies.Lines)
      {
        if (line.Trim() != "")
        {
          filmc++;
          Console.WriteLine(filmc.ToString() + ". film başlıyor" + DateTime.Now.ToLongTimeString());
          WebClient wcm = new WebClient();
          wcm.Headers.Add("Cookie: " + GetCookies());
          wcm.Headers.Add("Content-Type", "application/x-www-form-urlencoded");
          wcm.DownloadStringCompleted += Wcm_DownloadStringCompleted;
          str = wcm.DownloadString(new Uri(@"http://www.imdb.com/title/tt" + line + "/reviews-index?start=0;count=100000"));
          String pattern = string.Format(
              "{0}({1}){2}",
              Regex.Escape("user/ur"),
              ".+?",
               Regex.Escape("/"));
          MatchCollection mc = Regex.Matches(str, pattern);
          foreach (Match m in mc)
            if (lastid != m.Groups[1].Value)
            {
              ulist.Add(m.Groups[1].Value);
              lastid = m.Groups[1].Value;
            }
        }
        this.Text = filmc.ToString() + " / " + tb_movies.Lines.Count().ToString()+" ("+ ulist.Count().ToString()+ ")";
      }
      Console.WriteLine("Kullanıcı listesi sıralaması ve temizlemesi başlıyor : " + DateTime.Now.ToLongTimeString());
      tb_users.Lines = ulist.ToArray();
      File.WriteAllText(@"C:\beforeFormat.txt", tb_users.Text);
      tb_users.Lines = ulist.Distinct().ToArray();
      File.WriteAllText(@"C:\afterFormat.txt", tb_users.Text);
      Console.WriteLine("Kullanıcı listesi sıralaması ve temizlemesi bitti : " + DateTime.Now.ToLongTimeString());
      */
      ///*
      foreach (var line in tb_users.Lines)
      {
        userc++;
        Console.WriteLine(userc.ToString() + ". kullanıcının işlemine başlıyor : " + DateTime.Now.ToLongTimeString() + ". Toplam kullanıcı : " + tb_users.Lines.Count().ToString());
        string cookie = GetCookies();
        if ((line.Trim() != "") && (mfn.GetSqlResult("Select top 1 1 from Rating where userid='" + line + "'") != "1"))
        {
          mfn.GetRatings(line, cookie);
          this.Text = userc.ToString() + " / " + tb_users.Lines.Count().ToString();
        }
      }
      //*/
    }


    /*
private void Wcm_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
{
 counter--;
 try
 {
   string str = e.Result;
   while (str.Contains("/user/ur"))
   {
     tb_users.Text += Environment.NewLine + str.Substring(str.IndexOf("/user/ur") + 8, 7);
     str = str.Substring(str.IndexOf("/user/ur") + 10);
   }
 }
 catch (Exception ex) { Console.WriteLine(ex.Message); }
 ((WebClient)sender).Dispose();
}

private void Wcu_DownloadStringCompleted(object sender, DownloadStringCompletedEventArgs e)
{
 counter--;
 Console.WriteLine("Bir kullanıcı sayfası açıldı...");
 try
 {
   mfn.GetSqlResult("inser into tbl Select '" + e.Result.Replace("'", "''") + "'");
 }
 catch { }
 ((WebClient)sender).Dispose();
}

*/
    private string GetCookies()
    {
      if (webBrowser1.InvokeRequired)
      {
        return (string)webBrowser1.Invoke(new Func<string>(() => GetCookies()));
      }
      else
      {
        return webBrowser1.Document.Cookie;
      }
    }

    private void Form1_Load(object sender, EventArgs e)
    {

    }
  }
}
