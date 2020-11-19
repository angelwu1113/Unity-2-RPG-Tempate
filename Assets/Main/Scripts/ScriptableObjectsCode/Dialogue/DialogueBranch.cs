using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Branch", menuName="CustomObject/Branch")]
public class DialogueBranch : ScripatbleObject
{
    public string dialogueId = "";
    public List<string> DialogueLines;
    public List<ResponseBranch> ResponseOption;
}

[System.Serializabble]
public class ResponseBranch
{
    public string text;
    public DialogueBranch nextbranch;
}
