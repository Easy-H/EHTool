# EasyH

게임 개발에 사용할 수 있는 유용하고 구조화된 코드 집합으로, 게임 개발의 반복적인 작업을 최소화하고 핵심 로직에 집중할 수 있도록 돕습니다. 현재는 Unity용 모듈이 주를 이루고 있으며, Unreal용 모듈도 개발 중입니다.

## ✨ 주요 기능 (현재 사용 가능)

### 🎯 Core
| 모듈 | 핵심 기능 |
| :--- | :--- |
|Core| 자료 읽기(AssetOpener), 딕셔너리 변환(DictionaryConnector), 큐(Queue) 등 C# 핵심 유틸리티 제공. |
|Spline| Hermite 등 곡선 게산 알고리즘 |
|Search| BFS, A* 등의 탐색 알고리즘 |
|Singleton| 코드 중복 없는 템플릿 기반 싱글톤 구현체 제공. |

### ⬡ Unity
| 모듈 | 핵심 기능 |
| :--- | :--- |
|UIKit| 우선순위에 따른 GUIFullScreen 및 GUIPopUp 관리 시스템 제공. |
|LangKit| 키 기반으로 언어가 변경될 때 Text, TextMeshPro 등의 텍스트를 자동 업데이트하는 다국어 지원 기능. |

### 🎮 Gaming
| 모듈 | 핵심 기능 |
| :--- | :--- |
|TurnBased| 턴제 게임 로직 개발에 특화된 모듈. (네트워크 턴제 구현 경험 보유) |
|PathBased| 경로 기반(PathBased) 게임 로직 개발에 특화된 모듈.|

## 🛠️ 사용 프로젝트
EasyH 코드가 실제로 사용된 프로젝트들입니다.

- [BreakOut](https://github.com/Easy-H/Break-Out)
- [Prepper](https://github.com/Team-Prepper/unreal/)
- [Happy-Planet](https://github.com/Team-Prepper/Happy-Planet)
- [SWEng](https://github.com/Team-Prepper/Project_SWENG)

## 🗺️ 기능 상세 및 개발 로드맵

### ✅ Unity용 EasyH (현재 구현 완료)

- 🎯 Core: 범용 C# 모듈
    - AssetOpener: 레거시 지원을 위한 코드, 유니티 에셋, 텍스트 에셋 로드
    - Singleton: 싱글톤 템플릿
    - Unsubscriber: C# System의 IDisposable 구현체
    - FileConnector: 텍스트 에셋 접근
        - UnityFileConnector: Resources를 이용한 유니티 텍스트 에셋 접근
    - DictionaryConnector: 파일의 내용을 딕셔너리로 변환
        - Json, XML에 대해 제공
    - ListConnector: 파일의 내용을 리스트로 변환
        - Json, XML에 대해 제공
    - Queue: push, pop을 제공하는 queue
        - StablePriorityQueue, Heap 등 큐 구현체
    - Search: 탐색 알고리즘
        - BFS, A* 탐색 알고리즘
    - Spline: 곡선 계산 알고리즘
        - Hermite 곡선 계산 알고리즘
    - LangKit: 딕셔너리 파일의 언어 키/값 시스템을 이용한 언어 변경 기능

- ⬡ Unity: Unity 6 특화 모듈
    - SerializableDictionary: 직렬화 가능한 Dictionary
    - MonoSingleton: 유니티 생명 주기를 포함하는 Singleton 템플릿
    - UIKit: GUIFullScreen, GUIPopUp로 명명된 UI 관리
    - LangKit: Text, TextMeshPro UI 지원

- 🎮 Gaming: 게임 로직 특화 모듈
    - Gaming: 게임 로직과 관련된 구현
        - TurnBased: 턴제 게임 로직
        - PathBased: 경로 기반 보드게임 이동 로직
    - Inventory: 인벤토리 기능
        - Stacked

### ⏳ 향후 계획 (To Do)

- 🎯 Core: 범용 C# 모듈
    - AssetOpener: System.IO를 이용한 C# 프로젝트를 위한 구현체
    - AssetOpener: Addressable Asset System을 도입한 구현체
    - ListConnector: Json, XML 파일을 리스트로 변환
    - Search: DFS 탐색 알고리즘 추가
- ⬡ Unity: Unity 6 특화 모듈
    - SoundKit: BGM, 효과음 등을 관리하는 기능
    - EffectKit: 게임에 유용한 효과 관리 기능
- 🎮 Gaming: 게임 로직 특화 모듈
    - Inventory: 단일 공간 차지형 인벤토리 추가 예정
- 𝓾 Unreal용 EasyH
    - Unity용 EasyH의 기능을 모두 구현할 계획이며, 현재 개발 중입니다.

## ⚖️ 라이선스
- MIT 라이선스에 따라 배포됩니다.
- 자세한 내용은 LICENSE 파일을 참고해주세요.

## 📧 연락처
궁금한 점이나 피드백은 언제든지 환영합니다!

- 이메일: skysea001010@gmail.com