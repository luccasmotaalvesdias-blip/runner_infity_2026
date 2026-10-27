using UnityEngine;

public class PlayerBehavior : MonoBehaviour
{
    [SerializeField] private float movespeed = 5;
    private float movex;
    private float movey;
    void Update()
    {
        movex = Input.GetAxis("Horizontal") * Time.deltaTime * movespeed;
        movey = Input.GetAxis("Vertical") * Time.deltaTime * movespeed;
        print($"input: {movex}; input Y: {movey}");
        transform.Translate(movex, movey, 0);
    }
}
