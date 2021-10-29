using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.IO;
namespace Maticsoft.DBUtility
{
    /// <summary>
    /// 公共操作类库（日志操作类）
    /// </summary>
   public  class LogOperation
    {
       private LogOperation() { }
       #region 错误日志记录
       /// <summary>
       /// 错误日志记录方法
       /// </summary>
       /// <param name="ErrUrl">产生错误的URL</param>
       /// <param name="ErrMsg">错误消息记录</param>
       public static void Log(string ErrMsg)
       {
           string temStr;
           string ErrUrl = HttpContext.Current.Request.Url.ToString();
           if (!Directory.Exists(HttpContext.Current.Server.MapPath(@"~/errorlog/")))
           {
               Directory.CreateDirectory(HttpContext.Current.Server.MapPath(@"~/errorlog/"));
           }
           temStr = System.DateTime.Now.ToString() + "          ";
           temStr += ErrUrl + "          ";
           temStr += ErrMsg + "\n";
           File.AppendAllText(HttpContext.Current.Server.MapPath(@"~/errorlog/ErrLog.txt"), temStr, Encoding.GetEncoding("gb2312"));
       }
       #endregion
    }
}
