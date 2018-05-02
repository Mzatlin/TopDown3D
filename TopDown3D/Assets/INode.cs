using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public interface INode 
{
    event System.Action OnEnter;
    void Transferplayer(); //this method will transfer the player's position to the position of the node
}
