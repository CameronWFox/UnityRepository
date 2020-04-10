using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int currentLevel;
    public int currentHealth;

    [SerializeField] public float jumpHeight = 2.0f;

    void Awake()
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    // Movement Input Actions
    public void Move()
    {
        
    }
    public void Jump()
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + jumpHeight, transform.position.z);
    }

    // Combat Input Actions
    public void Shoot()
    {

    }

    public void Reload()
    {

    }
}
