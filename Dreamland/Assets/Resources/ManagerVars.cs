﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// 管理器容器
/// </summary>
// 在 ManagerVars 中声明的变量都可以在 ManagerVarsContainer 里显示
//[CreateAssetMenu(menuName = "CreatManagerVarsContainer")] // 用于生成 Asset 文件
public class ManagerVars : ScriptableObject {

    // 背景图片
    public List<Sprite> bgThemeSpriteList = new List<Sprite>();

    // 皮肤
    public List<Sprite> skinSpriteList = new List<Sprite>(); // 正面
    public List<Sprite> playerSpriteList = new List<Sprite>(); // 背面

    // 平台主题
    public List<Sprite> platformThemeSpriteList = new List<Sprite>();

    // 下一个平台较上一个平台的位置差，如果往右边生成都为正，如果往左边生成 x 取负，y 取正
    public float nextXPos = 0.554f;
    public float nextYPos = 0.645f;

    // 预制体
    public GameObject characterPre;  // 人物
    public GameObject normalPlatformPre; // 默认平台
    public List<GameObject> commonPlatformGroup = new List<GameObject>(); // 通用组合平台
    public List<GameObject> grassPlatformGroup = new List<GameObject>(); // 草地组合平台
    public List<GameObject> winterPlatformGroup = new List<GameObject>(); // 冬季组合平台
    public GameObject spikePlatformLeft; // 左边钉子组合平台
    public GameObject spikePlatformRight; // 右边钉子组合平台
    public GameObject deathEffect; // 死亡特效
    public GameObject diamondPre; // 钻石
    public GameObject skinCurrentPre; // 当前选择的皮肤
    public List<string> skinNameList = new List<string>(); // 皮肤的名字
    public List<int> skinPrice = new List<int>(); // 皮肤的价格

    // 音效
    public AudioClip jump, fall, hit, diamond, btn;
    public Sprite musicOn, musicOff;

    // 获取 管理器容器
    public static ManagerVars GetManagerVars()
    {
        return Resources.Load<ManagerVars>("ManagerVarsContainer");
    }
}
