using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntryNode : MonoBehaviour, INode{
    public event Action OnEnter = delegate { };
    public GameObject player;
    //Use this for initialization
    void Start () {
     //Transfer();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
   public void Transferplayer()
    {
        player.transform.parent = transform;
       // player.GetCompoent<Rigidbody>().enabled = false;
        player.transform.position = transform.position;
    }
    public void Relinquishplayer()
    {
        player.transform.parent = null;
    }


}
