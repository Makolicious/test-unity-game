using UnityEngine;

public class BlockScroll : MonoBehaviour {

    public Transform obstacle;
    public Transform thisGround;

    void FixedUpdate()
    {
        obstacle.position = thisGround.position + new Vector3(0, 1, 0);
    }

}
