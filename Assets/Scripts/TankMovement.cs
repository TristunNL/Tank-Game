using UnityEngine;

public class TankMovement : MonoBehaviour
{
    bool isAanDeBeurt = false;
    public int playerNumber = 1;
    private void Start()
    {

    }

    void Update()
    {
        if (playerNumber == 1)
        {
            transform.Translate(new Vector2(Input.GetAxis("Player1") * 10 * Time.deltaTime, 0));
        }
        if (playerNumber == 2)
        {
            transform.Translate(new Vector2(Input.GetAxis("Player2") * 10 * Time.deltaTime, 0));
        }
    }
}