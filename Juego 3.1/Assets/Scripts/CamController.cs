using UnityEngine;

public class CamController : MonoBehaviour
{

public BallController ball;

private float offset;


    void Start()

    {
        if (ball == null)
        {
            ball = GameObject.FindGameObjectWithTag("Ball").GetComponent<BallController>();
        }

        offset = transform.position.y - ball.transform.position.y;
        offset = transform.position.y - ball.transform.position.y
;

    }

    void Update()

    {
        Vector3 actualPos = transform.position;
        actualPos.y = ball.transform.position.y + offset;
        transform.position = actualPos;
        
    }
}
