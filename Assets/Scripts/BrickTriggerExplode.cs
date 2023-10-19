using System.Collections; 
using System.Collections.Generic; 
using UnityEngine; 

public class BrickTriggerExplode : MonoBehaviour 
{ 
public GameObject brickArray;

public void OnMouseDown() 
{ 
    brickArray.GetComponent<Animator>().Play("explode"); 
} 

} 
