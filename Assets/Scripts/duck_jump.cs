using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class duck_jump : MonoBehaviour {

    Rigidbody2D rb;
    //int velDecay = 250;

	// Use this for initialization
	void Start () {
        rb = this.gameObject.GetComponent<Rigidbody2D>();
    }

	// Update is called once per frame
	void Update () {
	    if(rb.velocity.y > -.1 && rb.velocity.y < .1) {
            if (Input.GetKeyDown(KeyCode.Space)) {
                rb.AddForce(new Vector2(0, 500));
            }
        }

        if(this.transform.position.x >= 8) SceneManager.LoadScene("Game_Selector");
        if(this.transform.position.y <= -6) SceneManager.LoadScene("Game_Selector_Fail");

    }
}
