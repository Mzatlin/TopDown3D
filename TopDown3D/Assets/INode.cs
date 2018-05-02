using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public interface INode 
{
    event System.Action OnEnter;
    void Transfer();
}
