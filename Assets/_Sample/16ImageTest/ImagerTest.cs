using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ImagerTest : MonoBehaviour
{
    [SerializeField] Button skillButton;
    [SerializeField] Image skillButtonImage;

    [SerializeField] float coolTime = 5f;

    private float coolcool;
    private bool iscoolTime = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        coolcool = coolTime; // 쿨타임 전체로 시작
        skillButtonImage.fillAmount = 1f; // 이미지도 가득 차 있게
        skillButton.onClick.AddListener(SkillCool);
        
    }

    // Update is called once per frame
    void Update()
    {
        SkillUse();
        
    }

    private void SkillUse()
    {
        if (iscoolTime)
        {
            coolcool -= Time.deltaTime;
            skillButtonImage.fillAmount = Mathf.Clamp01(coolcool / coolTime);
            if (coolcool <= 0f)
            {
                iscoolTime = false;
                skillButton.interactable = true;
                skillButtonImage.fillAmount = 1f;
            }
        }
        //백분율 : 현재값량 / 총량(5)
        
    }

    void SkillCool()
    {
        if (iscoolTime) return;
        Debug.Log("스킬 사용");
        coolcool = coolTime;
        iscoolTime = true;
        skillButton.interactable = false;
    }
}
