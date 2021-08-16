using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public Rigidbody2D Player;
    public Transform finishLine;
    public LayerMask playerMask;

    public int maxScore = 0;
    // Start is called before the first frame update
    void Start(){
        Screen.orientation = ScreenOrientation.LandscapeLeft;
    }

    // Update is called once per frame
    void FixedUpdate(){
        if(Player.position.x> maxScore)
        {
            maxScore = (int)Player.position.x;
        }

        if(Physics2D.OverlapCircle(finishLine.position, 0.1f, playerMask))
        {
            Debug.Log("QUIT");
            Application.Quit();
        }
    }
}
