using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableCube : MonoBehaviour
{
    bool iswastaken=false;
    int index;
    public Collector collector;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (iswastaken==true)
        {
            if (transform.parent != null)
            {
                transform.localPosition = new Vector3(0, -index, 0);
            }
        }
       
        
    }

    public bool GETiswastaken()
    {
        return iswastaken;
    }

    public void doitTaken()
    {
        iswastaken = true;
    }
    public int GETindex()
    {
        return index;
    }
    public void Setindex(int index)
    {
        this.index = index;// this.index globaldekidir  
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Barrier"))
        {
            collector.HeightReduction();
            this.transform.parent = null;
            this.gameObject.GetComponent<BoxCollider>().enabled = false;
            other.gameObject.GetComponent<BoxCollider>().enabled = false;

        }
    }

}
