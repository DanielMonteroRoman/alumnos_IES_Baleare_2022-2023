using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ApagaPanel : MonoBehaviour
{
    // Start is called before the first frame update
    public int seconds;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public IEnumerator ApagarCartel()
    {
        yield return new WaitForSeconds(seconds);

        this.gameObject.SetActive(false);
    }
}
