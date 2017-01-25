using UnityEngine;
using System.Collections;

public class Player_Controller : MonoBehaviour {
    /*This class controls the terrain transform performed by the player.
     */
    public float horizontalSpeed, verticalSpeed = 0.2F;
    public float resetSpeed = 0.005F;
    public float horizontalLimit, verticalLimit = 15F;
    public bool canMoveHorz, canMoveVert;
    public Quaternion startPosition;

    void Start()
    {
        startPosition = transform.rotation; // saves the initial rotation setup
    }

    void FixedUpdate()
    {
        //Takes Input from WASD keys. WS Tied to Z axis transformation, AD tied to X axis transformation.
        float horzSpeed = horizontalSpeed;
        float vertSpeed = verticalSpeed;
        canMoveHorz = (transform.localRotation.eulerAngles.z <= horizontalLimit) | (-horizontalLimit <= (transform.localRotation.eulerAngles.z - 360));
        canMoveVert = (transform.localRotation.eulerAngles.x <= verticalLimit) | (-verticalLimit <= (transform.localRotation.eulerAngles.x - 360));
        print(transform.localRotation.eulerAngles.x);
        if ((Input.GetKey(KeyCode.A)) & (canMoveHorz))
            transform.Rotate(0, 0, horzSpeed);
        if ((Input.GetKey(KeyCode.D)) & (canMoveHorz))
            transform.Rotate(0, 0, -horzSpeed);
        if ((Input.GetKey(KeyCode.S)) & (canMoveVert))
            transform.Rotate(-vertSpeed, 0, 0);
        if ((Input.GetKey(KeyCode.W)) & (canMoveVert))
            transform.Rotate(vertSpeed, 0, 0);
        if (!Input.anyKey)
            transform.rotation = Quaternion.Slerp(transform.rotation, startPosition, Time.time * resetSpeed);
    }
}
