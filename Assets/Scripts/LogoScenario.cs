using UnityEngine;

public class LogoScenario : MonoBehaviour
{
    [SerializeField]
    private Progress    progress;

    private void Awake()
    {
        SystemSetup();
    }

    private void SystemSetup()
    {
        // Ȱ��ȭ���� ���� ���¿����� ������ ��� ����
        Application.runInBackground = true;

        // �ػ� ���� (9:18.5, 1440x2960)
        int width   = Screen.width;
        int height  = (int)(Screen.width * 18.5 / 9);
        Screen.SetResolution(width, height, true);

        // ȭ���� ������ �ʵ��� ����
        Screen.sleepTimeout = SleepTimeout.NeverSleep;

        // �ε� �ִϸ��̼� ����, ��� �Ϸ�� OnAfterProgress() �޼ҵ� ����
        progress.Play(OnAfterProgress);
    }

    private void OnAfterProgress()
    {

    }
}
