using System;
using System.Web.Http.Filters;
using System.Net.Http;
using System.Net;
using System.IO;

namespace LibraryManagementAPI.Helpers
{
    public class GlobalExceptionHandler: ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext context)
        {
            LogException(context.Exception);

            //Respond with Internal Server error
            HttpResponseMessage objHttpResponseMessage = new HttpResponseMessage(HttpStatusCode.InternalServerError)
            {
                Content = new StringContent("An unexpected error occured, Please contact Admin"),
                ReasonPhrase = "Internal Server Error"
            };
            context.Response = objHttpResponseMessage;
        }
        /// <summary>
        /// Log Exception in logfile
        /// </summary>
        /// <param name="ex"></param>
        public void LogException(Exception ex)
        {
            //string logFilePath = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\Err\errorlogs.txt");
            string logFilePath = @"F:\Raj - 365\Raj-Mandaviya\API_Basic_Training\Basics of Web Development\LibraryManagementAPI\Helpers\errorlogs.txt";

            //Append error message with timestamp in logFile
            using (StreamWriter objStreamWriter = File.AppendText(logFilePath))
            {
                objStreamWriter.WriteLine($"{DateTime.Now} - {ex.Message}");
            }

        }
    }
}