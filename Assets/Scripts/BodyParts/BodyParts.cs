using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[System.Serializable]
public enum Parts { Hair, Head, Body, Arms, Legs }
public abstract class BodyParts: MonoBehaviour 
{
    public Parts PartType;
    public List<GameObject> PartVariant = new List<GameObject>();
    
}
