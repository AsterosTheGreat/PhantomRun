using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ChangeLevel : MonoBehaviour
{
    public Transform teleporter;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision other) 
    {
        SceneManager.LoadScene((SceneManager.GetActiveScene()).buildIndex + 1);
    }
}
