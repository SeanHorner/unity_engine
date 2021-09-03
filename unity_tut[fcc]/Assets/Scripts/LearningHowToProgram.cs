using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LearningHowToProgram : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(ExecuteSomething(2));

        StartCoroutine("ExecuteSomething");
        // Using the String parameterized StartCoroutine() allows the use of the 
        // following StopCoroutine() method.
        StopCoroutine("ExecuteSomething");
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    // Coroutines return IEnumerator types (they have to "yield return")
    IEnumerator ExecuteSomething(float time) {
        yield return new WaitForSeconds(time);
        Debug.Log("Executing something...");
    }
}
