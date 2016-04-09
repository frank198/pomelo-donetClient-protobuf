using UnityEngine;
using System.Collections;

public class PomeloSocketTest : MonoBehaviour {

	// Use this for initialization
	void Start () {
        PomeloSocket pomeloSocket = new PomeloSocket();
        pomeloSocket.Login(3000);

    }
	
	// Update is called once per frame
	void Update () {
	
	}
}
