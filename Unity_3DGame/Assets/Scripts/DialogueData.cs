using UnityEngine;

namespace BING
{
    /// <summary>
    /// ��ܸ��
    /// </summary>
    [CreateAssetMenu(menuName = "BING/DialogueData", fileName = "New Dialogue Data")]
    public class DialogueData : ScriptableObject
    {
        [Header("��ܪ̦W��")]
        public string dialogueName;
        [Header("��ܪ̤��e"), TextArea(2, 10)]
        public string[] dialogueContents;
    }
}
