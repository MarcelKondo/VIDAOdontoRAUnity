using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;

public abstract class USocketHandler : MonoBehaviour {
    public string ip = "localhost";
    public int port = 44444;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public abstract void SendSMessage(string message);

    protected byte[] EncodeMessage(string message)
    {
        /*to-do encoding*/
        return Encoding.UTF8.GetBytes(message);
    }


}
