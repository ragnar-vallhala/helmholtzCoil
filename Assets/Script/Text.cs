using System.Collections;
using UnityEngine.UI;
using UnityEngine;
using TMPro;

public class Text: MonoBehaviour
{
    private TMP_Text m_TextComponent;


    [SerializeField] Probe pb;
    void Update()
    {
        m_TextComponent = GetComponent<TMP_Text>();
        string st = "Field Strength " + pb.GetField()+" G" + "\nDistance " + pb.GetDist()+" cm";
        m_TextComponent.text = st;
        
    }
}
