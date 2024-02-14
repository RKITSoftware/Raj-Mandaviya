using System;
using System.Web.Http.Filters;
using System.Net.Http;
using System.Net;
using System.IO;

namespace ExceptionFilter
{
    public class GlobalExceptionHandler: ExceptionFilterAttribute
    {
        public override void OnException(HttpActionExecutedContext context)
        {
            LogException(context.Exception);
            var errorResponse = new HttpResponseMessage(HttpStatusCode.InternalServerError)
            {
                Content = new StringContent("An unexpected error occured, Please contact Admin"),
                ReasonPhrase = "Internal Server Error"
            };
            context.Response = errorResponse;
        }
        public void LogException(Exception ex)
        {
            //string logFilePath = Path.Combine(Directory.GetCurrentDirectory(), @"..\..\Err\errorlogs.txt");

            string logFilePath = @"F:\Raj - 365\Raj-Mandaviya\API_Basic_Training\Basics of Web Development\ExceptionFilter\Err\errorlogs.txt";

            using (StreamWriter sw = File.AppendText(logFilePath))
            {
                sw.WriteLine($"{DateTime.Now} - {ex.Message}");
            }

        }
    }
}