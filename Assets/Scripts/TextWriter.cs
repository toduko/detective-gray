using System.Collections;
using UnityEngine;
using UnityEngine.UI;


public class TextWriter : MonoBehaviour
{
    protected IEnumerator WriteText(string input, Text holder, float letterDelay, float lineDelay)
    {
        string []lines = input.Split('\n');
        for (int i = 0; i < lines.Length; ++i)
        {
            for (int j = 0; j < lines[i].Length; ++j)
            {
                holder.text += lines[i][j];
                yield return new WaitForSeconds(letterDelay);
            }
            holder.text += '\n';
            yield return new WaitForSeconds(lineDelay);
        }
    }
}
