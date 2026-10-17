using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camera : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform Target;
    
    public float minX,minY,maxX,maxY;
    public float cameraspeed;

    
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
     if(Target !=null)  {

        Vector2 newCamposition = Vector2.Lerp(transform.position,Target.position,Time.deltaTime * cameraspeed);

        float ClampX = Mathf.Clamp(newCamposition.x,minX,maxX);
        float ClampY = Mathf.Clamp(newCamposition.y,minY,maxY);

       transform.position = new Vector3(ClampX,ClampY,-10f);

     } 
    }
}
