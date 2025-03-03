using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float velocidad;
    public float sensibilidad;

    void Update()
    {
        if (Input.GetKey(KeyCode.W)||Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(0,0,velocidad*Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.A) || Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate( -velocidad * Time.deltaTime,0,0);
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(0, 0,  -velocidad * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(velocidad * Time.deltaTime, 0, 0);
        }

        transform.Rotate(0, Input.GetAxis("Mouse X") * sensibilidad * Time.deltaTime, 0);
    }
}
