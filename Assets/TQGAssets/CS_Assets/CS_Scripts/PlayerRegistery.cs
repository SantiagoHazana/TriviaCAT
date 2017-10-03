using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Net.Mail;
using System.Text;

public class PlayerRegistery : MonoBehaviour {

	public Text nameSurnameEntered;
	public Text emailEntered;
	public Text companyEntered;

	public void Save(){

		BinaryFormatter bf = new BinaryFormatter ();

		FileStream file;

		if (File.Exists (Application.persistentDataPath + "/playerInfo.dat")) {
			file = File.Open (Application.persistentDataPath + "/playerInfo.dat", FileMode.Open);
		} else {
			file = File.Open (Application.persistentDataPath + "/playerInfo.dat", FileMode.Create);
		}

		PlayerData data = new PlayerData ();
		data.name = nameSurnameEntered.text;
		data.email = emailEntered.text;
		data.company = companyEntered.text;
			
		bf.Serialize (file, data);
		file.Close();
//		SendMail ();
	}

//	public static void SendMail(){
//		SmtpClient client = new SmtpClient();
//		client.Port = 587;
//		client.Host = "smtp.gmail.com";
//		client.EnableSsl = true;
//		client.Timeout = 10000;
//		client.DeliveryMethod = SmtpDeliveryMethod.Network;
//		client.UseDefaultCredentials = false;
//		client.Credentials = System.Net.ICredentialsByHost("santiagohazana@gmail.com","39069364");
//
//		MailMessage mm = new MailMessage("santiagohazana@gmail.com", "santiagohazana@hotmail.com");
//		mm.BodyEncoding = UTF8Encoding.UTF8;
//		mm.DeliveryNotificationOptions = DeliveryNotificationOptions.OnFailure;
//
//		client.Send(mm);
//	}

}

[System.Serializable]
class PlayerData{
	public string name;
	public string email;
	public string company;
}
