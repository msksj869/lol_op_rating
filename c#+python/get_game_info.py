import requests
from urllib import parse
APIKEY="RGAPI-43184546-b903-4eb3-a170-d37ed1de39ff"
headers={
     "User-Agent": "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/86.0.4240.183 Safari/537.36",
    "Accept-Language": "ko-KR,ko;q=0.9,en-US;q=0.8,en;q=0.7",
    "Accept-Charset": "application/x-www-form-urlencoded; charset=UTF-8",
    "Origin": "https://developer.riotgames.com",
    "X-Riot-Token": APIKEY
     }
def all_info(name):
    API="https://kr.api.riotgames.com/lol/summoner/v4/summoners/by-name/" + name
    getAPI=requests.get(API, headers=headers)
    LOL_API_DATA=getAPI.json()
    accountid=LOL_API_DATA["accountId"]
    API="https://kr.api.riotgames.com/lol/match/v4/matchlists/by-account/" + accountid
    getAPI=requests.get(API, headers=headers)
    LOL_API_DATA1=getAPI.json()['matches']
    kill=0
    death=0
    ass=0
    vision=0
    cs=0
    time=0
    for i in range(0,10):
        checkpoint=0
        gameid=LOL_API_DATA1[i].get("gameId")
        API="https://kr.api.riotgames.com/lol/match/v4/matches/" + str(gameid)
        getAPI=requests.get(API, headers=headers)
        LOL_API_DATA=getAPI.json()
        for j in range(0,10):
            if(LOL_API_DATA["participantIdentities"][j]["player"]["summonerName"]==name):
                checkpoint=j
                j=10
        kill=kill+LOL_API_DATA["participants"][checkpoint]["stats"]["kills"]
        death=death+LOL_API_DATA["participants"][checkpoint]["stats"]["deaths"]
        ass=ass+LOL_API_DATA["participants"][checkpoint]["stats"]["assists"]
        cs=cs+LOL_API_DATA["participants"][checkpoint]["stats"]["totalMinionsKilled"]+\
            LOL_API_DATA["participants"][checkpoint]["stats"]["neutralMinionsKilled"]
        vision=vision+LOL_API_DATA["participants"][checkpoint]["stats"]["visionScore"]
        time=time+LOL_API_DATA["gameDuration"]

    
    return kill,death,ass,cs,vision,time

