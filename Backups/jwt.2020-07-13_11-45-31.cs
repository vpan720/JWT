using System;
using System.Collections;
using System.Data;
using OutSystems.HubEdition.RuntimePlatform;
using OutSystems.RuntimePublic.Db;
using Newtonsoft.Json.Linq;
using System.Text;

namespace OutSystems.Nssjwt {

	public class Cssjwt: Issjwt {

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssPaymentId"></param>
		/// <param name="ssOrderId"></param>
		/// <param name="ssSecret"></param>
		/// <param name="ssSignedToken"></param>
		public void MssCreateToken(string ssPaymentId, string ssOrderId, string ssSecret, out string ssSignedToken) {
			ssSignedToken = "";
			// TODO: Write implementation for action

		} // MssCreateToken

		/// <summary>
		/// 
		/// </summary>
		/// <param name="ssJWT_Token"></param>
		/// <param name="ssPaymentId"></param>
		/// <param name="ssOrderId"></param>
		public void MssReadToken(string ssJWT_Token, out string ssPaymentId, out string ssOrderId) {
			
			// TODO: Write implementation for action
			var data = ssJWT_Token.Substring(ssJWT_Token.IndexOf(".") + 1);
			var Maindata = data.Substring(0, data.IndexOf(".")) + "=";
			

			byte[] base64EncodedBytes = Convert.FromBase64String(Maindata);
			var jsonData = Encoding.UTF8.GetString(base64EncodedBytes);
			

			var details = JObject.Parse(jsonData);
			var paymentId = details["paymentId"];
			var orderDetails = details["orderDetails"];
			var orderId = orderDetails["orderId"];

			ssPaymentId = paymentId.ToString();
			ssOrderId = orderId.ToString();

		} // MssReadToken


	} // Cssjwt

} // OutSystems.Nssjwt

