using UnityEngine;

namespace BING
{
    /// <summary>
    /// �{�Ѱj��:���ư���{��
    /// for�Bwhile�Bdo while�Bforeach
    /// </summary>
    public class LearnLoop : MonoBehaviour
    {
        private void Awake()
        {
            // for �j��y�k:
            // for (��l�ȡF���L�� ����F�j�鵲������ϰ�){ �{���϶� }
            for (int i = 0; i < 10; i++) 
            {
                print("for �j�餺�e:" + i);
            }

            for (int number = 0; number < 5; number++) 
            {
                print("�j��:" + number);
            }
        }
    }
}
