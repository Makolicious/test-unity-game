using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundScroll : MonoBehaviour
{

    public float scrollSpeed = -100f;
    public Transform player;
    public GameObject thisGround;
    public GameObject thisGround2;
    public int spawnPlatform = 0;

    void FixedUpdate()
    {
        thisGround.transform.Translate(0, 0, scrollSpeed * Time.deltaTime);

        if (thisGround.transform.position.z < player.position.z && spawnPlatform < 1)
        {
            Debug.Log("Passed");
            thisGround2 = Instantiate(thisGround);
            thisGround2.transform.position = new Vector3(0, 0, thisGround.transform.position.z + 200);
            spawnPlatform++;
        }

        if (thisGround.transform.position.z + 210 < player.position.z)
        {
            Destroy(thisGround);
        }
    }
}
