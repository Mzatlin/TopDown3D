using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntryNode : MonoBehaviour, INode{
    public event Action OnEnter = delegate { };

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
   public void Transfer()
    {
        throw new NotImplementedException();
    }


}
