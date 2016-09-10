using UnityEngine;
using System.Collections;

public class duck_fall : MonoBehaviour {

    Rigidbody2D rb;

	// Use this for initialization
	void Start () {
        rb = this.gameObject.GetComponent<Rigidbody2D>();
    }
	
	// Update is called once per frame
	void Update () {
        if(rb.velocity.y < -5)
        {
            rb.velocity = new Vector2(rb.velocity.x, -5);
        }
	    if(this.transform.position.y < -4)
        {
            if (this.transform.position.x > -9 && this.transform.position.x < 9)
            {
                Application.LoadLevel("Game_Selector");
            }
            else Destroy(this.gameObject);
        }
	}
}
