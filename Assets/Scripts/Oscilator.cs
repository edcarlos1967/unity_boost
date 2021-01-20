using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[DisallowMultipleComponent] //Só permite um script na scene
public class Oscilator : MonoBehaviour
{
    [SerializeField] Vector3 movementVector = new Vector3(10f, 10f, 10f);
    [SerializeField] float period = 2f;
    float movementFactor;
    Vector3 startingPos;

    // Start is called before the first frame update
    void Start()
    {
        startingPos = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        //Epsilon é o menor número permitido em um float
        if (period <= Mathf.Epsilon) { return; }

        //Set movement factor
        float cycles = Time.time / period; // Grows continually from 0

        const float tau = Mathf.PI * 2; // About 6.28
        float rawSinWave = Mathf.Sin(cycles * tau); // Goes from -1 to +1

        movementFactor = rawSinWave / 2f + 0.5f;

        Vector3 offset = movementFactor * movementVector;
        transform.position = startingPos + offset;
    }
}
