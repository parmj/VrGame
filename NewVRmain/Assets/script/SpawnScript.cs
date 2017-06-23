using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SpawnScript : MonoBehaviour
{
    public GameObject obstacle;
    public GameObject powerup;

    float timeElapsed = 0;
    float spawnCycle = 0.4f;
    bool spawnPowerup = true;

    void Update()
    {
        
            timeElapsed += Time.deltaTime;
            if (timeElapsed > spawnCycle)
            {
                GameObject temp;
                if (spawnPowerup)
                {
                    temp = (GameObject)Instantiate(powerup);
                    Vector3 pos = temp.transform.position;
                    temp.transform.position = new Vector3(Random.Range(-11, 11), pos.y, pos.z);
				//spawnPowerup = !spawnPowerup;

                }
                else
                {
                    temp = (GameObject)Instantiate(obstacle);
                    Vector3 pos = temp.transform.position;
                    temp.transform.position = new Vector3(Random.Range(-11, 11), pos.y, pos.z);
				//spawnPowerup = true;

                }

                timeElapsed -= spawnCycle;
                spawnPowerup = !spawnPowerup;
            }
        }
    }
