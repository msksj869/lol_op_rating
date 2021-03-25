# Troll.gg

![N|Solid](https://ifh.cc/g/PAs6FB.png)

  

# 접속
- aws 서버가 3~10분마다 끊기는 현상이 발생하여 이 주소로 배포합니다.
- 
  
  
Troll.gg는 검색한 유저의 최근 플레이를 분석하고 에이스 스코어를 계산하여 트롤, 에이스 플레이어의 기준을 알려줍니다.
 ![N|Solid](https://ifh.cc/g/BptisC.jpg)


# 공통 요구사항
- MySQL
- Python
- NodeJS

# 개발 도구
- Visual Studio Code
- WebStorm

# 사용한 API 
  - /lol/match/v4/matchlists/by-account/{encryptedAccountId}
  - /lol/summoner/v4/summoners/by-name/{summonerName}
  - /lol/match/v4/matches/{matchId}
#
#

# 개발기간

| 기간 | 내용 |
| ------ | ------ |
| 2020-11-11 | Riot Developer API 신청 |
| 2020-11-14 | API 데이터 처리 테스트 코드 작성 |
| 2020-11-15 | API 데이터 분석 및 가공코드 작성 |
| 2020-11-20 | C# Winform UI 개발 시작 |
| 2020-11-30 | UI개발 마무리 |
| 2020-12-01 | MySQL DB 생성 및 테이블 생성 |
| 2020-12-02 | UI-PYTHON 코드 연동 시작 |
| 2020-12-04 | UI 변경 NodeJs express로 개발 |
| 2020-12-06 | Python code & UI 연동 |
| 2020-12-10 | 테스트 및 프로젝트 종료|
| 2020-12-11 | 배포용 코드로 수정|
#
#

# DB 초기화
- MySQL DB을 사용하여 설정이 복잡해져 업로드 코드는 DB코드를 삭제하였습니다

```

# 실행방법
- Riot Developer에 접속하여 API 발급(임시 API는 즉시 발급가능)
- 발급받은 API를 Python코드의 APIKEY=""에 입력
- 위 파이썬 코드변경 후 WebStorm으로 trollgg 파일 프로젝트를 open(폴더)
```
$ npm install  
$ npm start
```
- localhost:3002에 접속

# 주의사항
- 없는 유저를 검색할 경우 오류가 발생할 수 있다.
- 현재 Python 코드에 입력된 API는 임시키로 매일 갱신하거나 영구키를 발급 받아 사용해야한다.
