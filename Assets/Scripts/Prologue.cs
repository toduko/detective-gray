using UnityEngine;
using UnityEngine.UI;

public class Prologue : TextWriter
{
    private Text holder;

    [TextArea]
    [SerializeField]
    private string input;

    [SerializeField]
    private float letterDelay;

    [SerializeField]
    private float lineDelay;

    private void Awake()
    {
        holder = GetComponent<Text>();

        StartCoroutine(WriteText(input, holder, letterDelay, lineDelay));
    }

}
