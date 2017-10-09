using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using My;
using System.Data.SqlClient;
using System.Data;
using System.Net;
using System.Configuration;

namespace MovieAdvice
{
  public partial class _Default : Page
  {
    protected void Page_Load(object sender, EventArgs e)
    {
      if (!IsPostBack)
        l_result.Text = "<iframe src=\"http://www.imdb.com/list/_ajax/edit?public=YES&action=privacy&list_id=ratings\" style=\"display: none;\"/>";
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
      l_result.Text = "";
      long l = -1;
      long.TryParse(tb_userid.Text, out l);
      if (l != -1)
      {
        WebClient wc = new WebClient();
        String html = "";
        try
        {
          try
          {
            html = wc.DownloadString("http://www.imdb.com/user/ur" + tb_userid.Text);
//            if (html.Contains("The requested URL was not found on our server"))
            if (l_result.Text=="")
            {
              String nickname = html.OrtasiniGetir("\"avatar-frame\"", "</h1>", true).OrtasiniGetir("<h1>", "</h1>");
              int webdekioy = 0;
              int.TryParse(html.OrtasiniGetir("<a href=\"/user/ur" + tb_userid.Text + "/ratings\">See all ", " rating").Replace(",", ""), out webdekioy);
              if (html.OrtasiniGetir("Quick Links", "Ratings").OrtasiniGetir("subNavItem ", "\"") == "inactive")
                l_result.Text = nickname + " isimli kullanıcının oylamaları paylaşıma açılmamış. Bu kullanıcı ile imdb.com üzerinde <a target=\"_blank\" href=\"https://www.imdb.com/registration/signin\">oturum açtıktan sonra</a> oylamaları paylaşmak için: <a target=\"_blank\" href=\"http://www.imdb.com/user/ur" + tb_userid.Text + "/ratings\">\"Change List Settings\" seçeneğini kullanabilirsiniz.</a>";
              else if (webdekioy==0)
                l_result.Text = nickname + " isimli kullanıcının film beğenilerinin hesaplanması için en az 6 oyu olması gerekiyor.";
              else if (webdekioy != int.Parse(mfn.GetSqlResult("Select isNull((Select RateCount from Voter where voterid='" + tb_userid.Text + "'), 0)")))
                mfn.GetRatings(tb_userid.Text, ConfigurationManager.AppSettings["cookie"].ToString());
            }
          }
          catch (Exception ex)
          {
            if (ex.Message.Contains("(404)"))
              l_result.Text = "Kullanıcı kodu bulunamadı : " + tb_userid.Text;
            else
              l_result.Text = "Hata oluştu : "+ex.Message;
          }
        }
        finally
        {
          wc.Dispose();
        }
        if (l_result.Text == "")
        {
          String genrefilter = "";
          List<ListItem> selected = cbl_genre.Items.Cast<ListItem>().Where(li => li.Selected).ToList();
          foreach (var item in selected)
            genrefilter += item.Value;
          List<SqlParameter> sparams = new List<SqlParameter>();
          sparams.Add(new SqlParameter("voterid", tb_userid.Text));
          sparams.Add(new SqlParameter("Genre", genrefilter));
          sparams.Add(new SqlParameter("Type", ddl_Type.Text));
          sparams.Add(new SqlParameter("Year1", tb_Year1.Text));
          sparams.Add(new SqlParameter("Year2", tb_Year2.Text));
          DataTable dt = mfn.ExecSP("sp_GiveAdvice", sparams).Tables[0];
          for (int i = 0; i < dt.Rows.Count; i++)
            l_result.Text += (i + 1).ToString() + "-) <a target=\"_blank\" href=\"http://www.imdb.com/title/tt" + dt.Rows[i]["movieid"].ToString() + "/\">" + dt.Rows[i]["Name"].ToString() + "</a><br>";
        }
      }
      else l_result.Text = "Hatalı kullanıcı kodu";
      try
      {
        mfn.GetSqlResult("insert into Deneme (voterid, DT, aciklama) Select '" + tb_userid.Text + "', GetDate(), '" + l_result.Text.Replace("'", "''") + "'");
      }
      catch { }
    }
  }
}