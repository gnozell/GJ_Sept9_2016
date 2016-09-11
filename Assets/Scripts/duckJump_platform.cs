using UnityEngine;
using System.Collections;

public class duckJump_platform : MonoBehaviour {

    public float maxX;
    public float minX;
    int dir = 1;
    Rigidbody2D rb;
    
	// Use this for initialization
	void Start () {
        rb = this.gameObject.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
	    if(this.gameObject.transform.position.x > maxX)
        {
            dir = -1;
        }
        if (this.gameObject.transform.position.x < minX)
        {
            dir = 1;
        }
        rb.velocity = new Vector2(3f * dir, 0);
    }
}
