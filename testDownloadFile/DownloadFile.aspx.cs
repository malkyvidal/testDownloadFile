using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
namespace testDownloadFile
{
    public partial class DownloadFile : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!Page.IsPostBack)
            {
                var archivo = Request.QueryString["archivo"];
                if (archivo!=null)
                {
                    ObtenerArchivo(archivo);
                }
            }
        }

        private void ObtenerArchivo(string archivo)
        {

            //la ruta fisica se guarda en el web config o en base
            var des = @"C:\Adjuntos\" + archivo;
            //solo la aplicacion conoce la ruta fisica del archivo.
            // si usamos la ruta virtual, cualquiera que conoce la url del archivo se lo descarga
            // los archivos estan fuera del sitio

            FileInfo fil = new FileInfo(des);

            Response.Clear();
            Response.AddHeader("Content-Disposition",
           "attachment; filename=" + archivo);
            Response.AddHeader("Content-Length",
                       fil.Length.ToString());
            Response.ContentType = "application/octet-stream";
            Response.WriteFile(fil.FullName);
            Response.End();
        }
    }
}