using UnityEngine;
using System.Collections;

namespace BING
{
    /// <summary>
    /// �ǲߨ�P�{�ǡA²�٨� Coroutine
    /// �ت�:���{�����d�F�쵥�ݪ��ĪG
    /// </summary>
    public class LearnCoroutine : MonoBehaviour
    {
        // �ϥΨ�P�{�Ǫ��T�ӱ���
        // 1. �ޥΩR�W�Ŷ� System.Collections
        // 2. �w�q�@�ӶǦ^ IEnumerator ����k
        // 3. ��k�������ϥ� yield return (����)
        // 4. �ϥ� StartCoroutine �Ұ�

        private void Awake()
        {
            StartCoroutine(Test());
        }

        private IEnumerator Test()
        {
            print("<color=#33ff33>�Ĥ@��{��</color>");
            yield return new WaitForSeconds(2);
            print("<color=#ff3333>�ĤG��{��</color>");
            yield return new WaitForSeconds(3);
            print("<color=#3333ff>�ĤT��{��</color>");
        }
    }
}