using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;
using System.IO;
namespace testDownloadFile
{
    public partial class Adjuntos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                
                List<HtmlAnchor> links = new List<HtmlAnchor>();

               var archivos = Directory.GetFiles(  Server.MapPath("AdjuntosT"));
                //esto es solo para ejemplo el nombre del archivo viene de base
               archivos.ToList()
                   .ForEach(a =>
                   {
                       var ax = new FileInfo(a);

                       links.Add(new HtmlAnchor() { HRef="DownloadFile.aspx?archivo="+ ax.Name, InnerText="Descarga"});
                       
                   });

            links.ForEach(l=>{
                Panel1.Controls.Add(l);
            });
              

            }

        }
    }
}