using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Gmail.v1.Data;
using Google.Apis.Services;
using Google.Apis.Util.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Attendance_Scanning
{
    class Email
    {
        //static string ApplicationName = "Gmail API .NET Quickstart";

        //static void Main(string[] args)
        //{
        //   // UserCredential credential;
        //    // Create Gmail API service.
        //    var service = new GmailService(new BaseClientService.Initializer()
        //    {
        //       // HttpClientInitializer = credential,
        //        ApplicationName = ApplicationName,
        //    });

        //    // Define parameters of request.
        //    UsersResource.LabelsResource.ListRequest request = service.Users.Labels.List("me");

        //    // List labels.
        //    IList<Label> labels = request.Execute().Labels;
        //    Console.WriteLine("Labels:");
        //    if (labels != null && labels.Count > 0)
        //    {
        //        foreach (var labelItem in labels)
        //        {
        //            Console.WriteLine("{0}", labelItem.Name);
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("No labels found.");
        //    }
        //}
    }
}
