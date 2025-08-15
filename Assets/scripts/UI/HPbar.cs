using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPbar : MonoBehaviour
{
    [SerializeField]float LerpSpeed = 5f;
    private float currentValue = 100;
    private float targetValue = 100;

    
    void Start()
    {
        EventManager.Instance().StartListening(EEvents.PLYR_HP_CHANGE, ChangeValue);
    }

    private void Update()
    {
        currentValue = Mathf.Lerp(currentValue, targetValue, Time.deltaTime * LerpSpeed);
        GetComponent<Slider>().value = currentValue;
    }


    private void ChangeValue(Dictionary<string, object> parameters)
    {
        if (parameters.ContainsKey("newHP"))
        {
            targetValue = (float)parameters["newHP"];
        }
    }
}
