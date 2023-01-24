using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleAnim : MonoBehaviour
{
    public float StartDeltaX;
    Vector3 startPos;
    Vector3 startScale;
    public float Speed;
    // Start is called before the first frame update
    void Start()
    {
        startPos = transform.position;
        startScale = transform.localScale;
        transform.Translate(StartDeltaX, 0, 0);
        StartCoroutine(Moving());
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position != startPos)
        {
            transform.Translate(Speed, 0, 0);
        }
    }
    IEnumerator Moving()
    {
        Vector3 pos = transform.position;
        float t = 0;
        while(t <= 1)
        {
            yield return null;
            transform.position = Vector3.Lerp(pos, startPos, t);
            t += 0.01f;
        }
    }
    IEnumerator Scaling()
    {
        float t = 0;
        while (t <= 1)
        {
            yield return new WaitForSeconds(0.01f);
            transform.localScale = Vector3.Lerp(Vector3.zero, startScale, t);
            t += 0.01f;
        }
    }
}
