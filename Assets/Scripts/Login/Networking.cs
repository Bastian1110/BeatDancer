using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Networking;

public class Networking : MonoBehaviour
{
    public TMP_InputField usernameInput;
    public TMP_InputField passwordInput;

    public TextMeshProUGUI output;
    public struct UserData
    {
        public string name;
        public string password;
    }
    public UserData data;

    public void RequestLogin()
    {
        StartCoroutine(RequestLoginHandler());
    }

    private IEnumerator RequestLoginHandler()
    {
        data.name = usernameInput.text;
        data.password = passwordInput.text;
        print(JsonUtility.ToJson(data));

        WWWForm form = new WWWForm();
        form.AddField("dataPacket", JsonUtility.ToJson(data));

        UnityWebRequest request = UnityWebRequest.Post("http://157.245.9.203/API/LoginUnity.php", form);

        yield return request.SendWebRequest();

        

        if(request.result == UnityWebRequest.Result.Success)
        {
            string text = request.downloadHandler.text;
            output.text = text;
        }
        else
        {
            output.text = "Error : " + request.responseCode;
        }
    }

}
