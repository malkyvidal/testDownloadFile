using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace testDownloadFile
{
    /// <summary>
    /// Descripción breve de HandlerDownload
    /// </summary>
    public class HandlerDownload : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "texto/normal";
            context.Response.Write("Hola a todos");
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}