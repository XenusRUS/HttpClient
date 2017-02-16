//
// This sample shows how to use the two Http stacks in MonoTouch:
// The System.Net.WebRequest.
// The MonoTouch.Foundation.NSMutableUrlRequest
//

using UIKit;

namespace HttpClientSample
{
	public class Application
	{
		// URL where we fetch the wisdom from
		//public const string WisdomUrl = "http://httpbin.org/ip";
		public static string api_key = "060b5772750f7a709e84de20eb0dc09b";
		public static string WisdomUrl = "http://api.openweathermap.org/data/2.5/weather?lat=55.164442&lon=61.436843&appid=060b5772750f7a709e84de20eb0dc09b";

		static void Main (string[] args)
		{
			UIApplication.Main (args);
		}

		public static void Busy ()
		{
			UIApplication.SharedApplication.NetworkActivityIndicatorVisible = true;
		}

		public static void Done ()
		{
			UIApplication.SharedApplication.NetworkActivityIndicatorVisible = false;
		}

	}

}
