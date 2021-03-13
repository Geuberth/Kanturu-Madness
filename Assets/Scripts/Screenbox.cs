using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Screenbox : MonoBehaviour
{
    public int iLevel;
    public string sLevel;

    public bool useInteger = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision) {
        GameObject collisionGO = collision.gameObject; 
        if(collisionGO.name == "Player"){
            loadScene();
        }
    }
    
    void loadScene(){
        if(useInteger){
            SceneManager.LoadScene(iLevel);
        }
        else {
            SceneManager.LoadScene(sLevel);
        }
    }
}
