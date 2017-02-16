//
// This file contains the sample code to use System.Net.WebRequest
// on the iPhone to communicate with HTTP and HTTPS servers
//
// Author:
//   Miguel de Icaza
//

using System;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Diagnostics;

namespace HttpClientSample
{
	public class DotNet {
		AppDelegate ad;

		public DotNet (AppDelegate ad)
		{
			this.ad = ad;
		}

		//
		// Asynchronous HTTP request
		//
		public void HttpSample ()
		{
			Application.Busy ();
			var request = WebRequest.Create (Application.WisdomUrl);
			request.BeginGetResponse (FeedDownloaded, request);
		}



			public int id { get; set; }
			public string name { get; set; }
			public int cod { get; set; }


		//
		// Invoked when we get the stream back from the twitter feed
		// We parse the RSS feed and push the data into a
		// table.
		//
		void FeedDownloaded (IAsyncResult result)
		{
			Application.Done ();
			var request = result.AsyncState as HttpWebRequest;

			try {
				var response = request.EndGetResponse (result);
				ad.RenderStream (response.GetResponseStream ());
			} catch (Exception e) {
				Debug.WriteLine (e);
			}
		}

		//
		// Asynchornous HTTPS request
		//


		//
		// For an explanation of this AcceptingPolicy class, see
		// http://mono-project.com/UsingTrustedRootsRespectfully
		//
		// This will not be needed in the future, when MonoTouch
		// pulls the certificates from the iPhone directly
		//

		//class AcceptingPolicy : ICertificatePolicy {
		//	public bool CheckValidationResult (ServicePoint sp, X509Certificate cert, WebRequest req, int error)
		//	{
		//		// Trust everything
		//		return true;
		//	}
		//}
	}
}
