using UnityEngine;
using System.Collections;

public class PolicyHolderBehaviour : MonoBehaviour
{
    public string policy_holder_name;
    public string id_number;
    public int age;

    // Use this for initialization
    void Start()
    {
        ((TextMesh)this.gameObject.transform.GetChild(2).GetComponent(typeof(TextMesh))).text = GetDisplayText();
    }

    private string GetDisplayText()
    {
        return string.Format("Policy holder name: {0}\n Id number: {1}\n Age: {2}", policy_holder_name, id_number, age);
    }
    // Update is called once per frame
    void Update()
    {

    }
}
