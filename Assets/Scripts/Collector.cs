using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    GameObject MainCube;
    int Height;
    SoundsS soundsS;
    public ParticleSystem effect;
    public Animator animator;
    private void Awake()
    {
        MainCube = GameObject.Find("MainCube");
        soundsS = GameObject.FindObjectOfType<SoundsS>();
        // MainCube = GameObject.FindObjectOfType<MovementCube>().gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        MainCube.transform.position = new Vector3(transform.position.x, Height + 1, transform.position.z);
        this.transform.localPosition = new Vector3(0, -Height, 0);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("collectable")&& other.gameObject.GetComponent<CollectableCube>().GETiswastaken()==false)
        {
            Height++;
            other.gameObject.GetComponent<CollectableCube>().doitTaken();
            other.gameObject.GetComponent<CollectableCube>().Setindex(Height);
            other.gameObject.transform.parent = MainCube.transform;
            soundsS.TakeCubeSound();
            effect.Play();
        }
    }

    public void HeightReduction()
    {
        Height--;
    }
}
