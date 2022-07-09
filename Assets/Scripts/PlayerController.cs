using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // variable declarations
    private Vector2 mouseInput;
    public GameObject ball;
    public static bool isActive;




    // Start is called before the first frame update
    void Start()
    {
        isActive = false;
    }



    // Update is called once per frame
    void Update()
    {

        // set mouse position every frame
        mouseInput = Input.mousePosition;
        // convert to game world (or something)
        mouseInput = Camera.main.ScreenToWorldPoint(mouseInput);
        // set X position to mouseInput 
        transform.position = new Vector2(mouseInput.x, transform.position.y);

        if (Input.GetMouseButtonDown(0))
        {
            if (isActive == false)
            {
                // spawn a ball on top of the paddle
                Instantiate(ball, new Vector2(transform.position.x, transform.position.y + 0.4f), Quaternion.identity);
                isActive = true;

            }

        }
    }


}
