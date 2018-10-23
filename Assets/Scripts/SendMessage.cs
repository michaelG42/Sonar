using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SendMessage : MonoBehaviour {

	public void SendFungusMessage(string s)
    {
        Fungus.Flowchart.BroadcastFungusMessage(s);
    }
}
