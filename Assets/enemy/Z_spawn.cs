using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Z_spawn : MonoBehaviour
{
    [SerializeField] private float cooldown = 3.0f;
    [SerializeField] private float spawn_start = 3.0f;
    int rnd;
    private float time;
    private float all_time;
    public GameObject Up_z_EnemyObj;
    public GameObject Middle_z_EnemyObj;
    public GameObject Down_z_EnemyObj;

    // Start is called before the first frame update
    void Start()
    {


    }

    // Update is called once per frame
    void Update()
    {
        all_time += Time.deltaTime;
        time += Time.deltaTime;

        if (all_time > spawn_start)
        {
            if (time > cooldown)
            {
                rnd = Random.Range(1, 4); //1~3の値をランダムで
            }


            if (rnd == 1)
            {
                Instantiate(Up_z_EnemyObj, new Vector3(15, 0, 0), Quaternion.identity);
                time = 0;
                rnd = 0;
            }
            else if (rnd == 2)
            {
                Instantiate(Middle_z_EnemyObj, new Vector3(20, 0, 0), Quaternion.identity);
                time = 0;
                rnd = 0;
            }
            else if (rnd == 3)
            {
                Instantiate(Down_z_EnemyObj, new Vector3(25, 0, 0), Quaternion.identity);
                time = 0;
                rnd = 0;
            }
        }
    }
}
