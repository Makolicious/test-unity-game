using UnityEngine;

public class NewGroundScroll : MonoBehaviour {

    public float scrollSpeed = -100f;
    public Transform player;
    public GameObject thisGround;
    public GameObject thisGround2;
    public int spawnPlatform = 0;

    void FixedUpdate()
    {
        thisGround.transform.Translate(0, 0, scrollSpeed * Time.deltaTime);
        thisGround2.transform.Translate(0, 0, scrollSpeed * Time.deltaTime);

        if (thisGround.transform.position.z < player.position.z && spawnPlatform < 1)
        {
            Debug.Log("Passed1");
            thisGround2.transform.position = new Vector3(0, 0, thisGround.transform.position.z + 400);
            spawnPlatform++;
        }

        else if (thisGround2.transform.position.z < player.position.z && spawnPlatform > 0)
        {
            Debug.Log("Passed2");
            thisGround.transform.position = new Vector3(0, 0, thisGround2.transform.position.z + 400);
            spawnPlatform--;
        }
    }
}
