# 인생은 산 넘어 산



## 게임 개요
제목:	인생은 산 넘어 산

플랫폼: PC

장르: 플랫포머

시점: 2D 사이드 뷰

컨셉: 등산, 아버지와 아들


![그림2](https://user-images.githubusercontent.com/26238417/143542993-20bf687b-0b2c-46de-8646-656ea5d1017e.png)

등산을 함께하는 아버지와 아들이 나이에 따라 변해가는 관계가 인생 전체에서 아버지와 아들의 관계 변화와 유사하다고 생각했다. 
또한 인생 자체가 산처럼 여러 번의 굴곡을 넘는 것과 비슷하고 아들은 어릴 땐 아버지의 도움을 최대한 받으며 산을 오르지만 점점 자립하여 나중엔 
오히려 아버지의 짐을 대신 들어주는 등 입장이 바뀐다. 

결국엔 어린 아들도 누군가의 아버지가 되어 자신이 바라보았던 아버지의 역할을 그대로 하게 되는 모습을 게임의 주제로 정했다.



## 시놉시스
![그림1](https://user-images.githubusercontent.com/26238417/143542897-603aa6c8-b348-49e5-81c4-248fa9b878db.png)

주인공은 등산을 그다지 좋아하지 않는 어린 소년이다. 하지만 그의 아버지는 등산을 정말 좋아했고 항상 아들과 함께 하고 싶어했다. 
주인공도 그 맘을 모르진 않았기 때문에 가끔 아버지의 등산에 어울리기로 한다. 

아버지는 특히 새해가 되면 마음을 다잡는 의미에서 등산하길 좋아하셨고 매년 1월 1일이면 부자가 함께 등산을 가는 약속이 생긴다.
덕분에 매년 나이를 먹을 때 마다 아버지와 등산을 하던 주인공은 어느 순간마다 아버지와 자신의 관계가 조금씩 변화함을 느낀다.



## 특징
![그림3](https://user-images.githubusercontent.com/26238417/143543692-3dd1c725-3b26-4d40-baab-b3a7b4f6fa70.png)

1. 복잡한 시스템 없이 그저 산을 배경으로 한 플랫포머 게임이지만 플레이어와 아버지 캐릭터의 스테이지 진행에 따른 변화를 통해 스토리텔링을 하고자 했다.

2. 처음 게임을 시작하면 플레이어는 자신보다 훨씬 빠른 아버지(NPC)를 따라가며 목적지까지 가는 것이 게임의 목표입니다. 첫 스테이지에선 아버지와 아들 캐릭터의 능력 차이가 눈에 보이게 난다. 하지만 스테이지가 진행되면서 아들이 성인이 되고 아버지가 중년이 됨에 따라 둘의 능력은 동등 해진다. 마지막 스테이지에서 아들은 20대 후반 아버지는 50대 후반이 되면서 둘의 능력 차이는 첫 스테이지와는 정반대가 된다. 첫 스테이지에선 아버지NPC가 플레이어에게 방해가 되는 장애물을 제거하며 나아가서 플레이어가 열심히 쫓아가야 했지만 마지막 스테이지에선 플레이어가 뒤쳐지는 아버지NPC와 거리를 유지하며 직접 방해 요소들을 제거해 나가야 한다.

3. 에필로그 스테이지에선 플레이어가 아버지가 되고 새로운 아들 캐릭터(NPC)를 등장시켜 플레이어를 따라오게 한다.

4. 스테이지마다 달라지는 아버지NPC와 아들(플레이어)를 통해 인생에서 아버지와 아들의 관계를 등산이라는 특정 상황으로 표현하고자 한다.




### 아버지 NPC의 Update 부분
- 아들의 위치와 행동에 따라 이동 및 특정 대사가 나오도록 만들었다.
```
void Start()
    {
        runSpeed = 1;
        father_ready = false;

        rigid = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (father_ready == true && (son.transform.position.x > gameObject.transform.position.x))
        {
            FlipPlayer();
            father_ready = false;
        }

        if (father_ready)
        {
            anim.SetBool("father_ready",true);
            runSpeed = 0;
        }
        else
        {
            anim.SetBool("father_ready", false);
            runSpeed = 1;
        }

        rigid.velocity = (new Vector2((1.0f) * runSpeed, rigid.velocity.y));
        //CameraOutCheck();
    }
    
        private void OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == "wall")
        {
            anim.SetTrigger("f_jump");
            gameObject.GetComponent<AudioSource>().Play();
            rigid.velocity = Vector2.up * jumpPower;
        }

        if (col.tag == "fall_wall")
        {
            anim.SetTrigger("f_jump");
            gameObject.GetComponent<AudioSource>().Play();
            runSpeed = 10;
            rigid.velocity = Vector2.up * jumpPower * 2.5f;
            
        }

        if (col.tag == "apple")
        {
            father_ready = true;
            gameObject.GetComponent<ChatBox>().Talk_apple();
            Destroy(col);
        }

        if (col.tag == "son_wait_pos")
        {
            FlipPlayer();
            father_ready = true;
            gameObject.GetComponent<ChatBox>().Talk_danger();
            Destroy(col);
        }
```
        
### 스테이지 진행 상태 jSon 저장 

```
public class json_save : MonoBehaviour
{
    public GameObject stage2_bt;
    public GameObject stage3_bt;
    public GameObject stage4_bt;

    public PlayerData playerData;

    [ContextMenu("To json Data")]
    public void savePlayerData_Json()
    {
        string jsonData = JsonUtility.ToJson(playerData, true);
        string path = Path.Combine(Application.dataPath, "playerData.json");
        File.WriteAllText(path, jsonData);
    }

    [ContextMenu("From Json Data")]
    public  void LoadPlayerDataToJson()
    {
        string path = Path.Combine(Application.dataPath, "playerData.json");
        string jsonData = File.ReadAllText(path);
        playerData = JsonUtility.FromJson<PlayerData>(jsonData);
        check_stage();
    }

    public void check_stage()
    {
        if (playerData.clear_stage >= 2)
        {
            stage2_bt.GetComponent<Button>().interactable = true;
        }

        if (playerData.clear_stage >= 3)
        {
            stage3_bt.GetComponent<Button>().interactable = true;
        }

        if (playerData.clear_stage >= 4)
        {
            stage4_bt.GetComponent<Button>().interactable = true;
        }
    }

}
[System.Serializable]
public class PlayerData
{
    public int clear_stage;
}


