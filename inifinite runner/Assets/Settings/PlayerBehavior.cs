using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    private float movex;
    private float movey;
    void Update()
    {
        movex = Input.GetAxis("Horizontal") * Time.deltaTime * 5f;
        movey = Input.GetAxis("Vertical") * Time.deltaTime * 5f;
        transform.Translate(movex, movey, 0);
    }
}
