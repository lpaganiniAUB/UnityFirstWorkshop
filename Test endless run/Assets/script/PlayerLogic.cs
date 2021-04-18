using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerLogic : MonoBehaviour
{
    public TMP_Text Gears;
    public AudioSource CollectibleSound;


    // Start is called before the first frame update
    void Start()
    {
        int start = 0;
        Gears.text = start.ToString();
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    //Upon collision with another GameObject, this GameObject will reverse direction
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log(other.name);
        Destroy(other.gameObject);
        int counter = int.Parse(Gears.text);
        counter += 1;
        Gears.text =counter.ToString();
        CollectibleSound.Play();


    }
}
