using UnityEngine;

public class WaterController : MonoBehaviour
{
    private float waterSpeed= 0.8f;
     private float waterwith= 3f;

     private Vector3 startPos;

        void Start()
    {
        startPos= transform.position;

        
    }

    // Update is called once per frame
    void Update()
    {
        float xOffset =Mathf.Sin(Time.time*waterSpeed)*waterwith;
        transform.position = new Vector3(startPos.x+xOffset,startPos.y,startPos.z);  // Move the water along the x-axis. 0, 0, 0 is the y-axis position. 0.03f is the speed of the water movement. 1.0f is the width of the water.  The water will flow from left to right.  If you want it to flow from right to left, change the sign of x
        
    }
}
