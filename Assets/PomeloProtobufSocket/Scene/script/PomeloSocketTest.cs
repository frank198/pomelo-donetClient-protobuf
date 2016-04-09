using UnityEngine;
using System.Collections;

public class PomeloSocketTest : MonoBehaviour {

	public string host = "192.168.1.107";
	public int port = 3000;
	// Use this for initialization
	void Start () {
        PomeloSocket pomeloSocket = new PomeloSocket();
		pomeloSocket.Login(host,port);

    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
