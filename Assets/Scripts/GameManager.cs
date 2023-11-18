using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public List<GameObject> gameObjects;
    public Player player;
    GameObject Target;
    public float wait = 1.5f;
    bool isWait;
    int count;
    // Start is called before the first frame update
    void Start()
    {
        isWait = true;
        Instance();
    }

    // Update is called once per frame
    void Update()
    {
        if(isWait)
        {
            Target.transform.position = player.Target.transform.position;
            Target.GetComponent<Rigidbody2D>().simulated = false;
        }
        
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(isWait)
            {
                Invoke("Instance",wait);
                isWait = false;
                Target.GetComponent<Rigidbody2D>().simulated = true;
            }
        }
    }
    public void Instance()
    {
        Target = Instantiate(gameObjects[Random.Range(0, 5)], new Vector3(player.Target.transform.position.x, player.Target.transform.position.y),Quaternion.identity);
        isWait = true;
    }
    public void Generate(Transform pos, int Level)
    {
        if(Level != gameObjects.Count)
        {
            count++;
            if (count == 2)
            {
                Instantiate(gameObjects[Level], new Vector3(pos.position.x, pos.position.y), Quaternion.identity);
                count = 0;
            }
        }
    }
}
