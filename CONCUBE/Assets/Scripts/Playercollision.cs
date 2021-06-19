using UnityEngine;

public class Playercollision : MonoBehaviour
{
    public PlayerMovement movement;
    public GameManager gameManager;
    void OnCollisonEnter(Collision collisionInfo)
    {

        if (collisionInfo.collider.tag == "obstacle")
        {
            movement.enabled = false;
        }
    }
}
