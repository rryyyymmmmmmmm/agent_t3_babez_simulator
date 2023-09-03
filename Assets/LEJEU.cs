using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class LEJEU : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI score;
    public Shooting killer;
    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        score.text = killer.numDead.ToString();
    }
}
