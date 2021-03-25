import requests
from urllib import parse
import sys, json
import base64


APIKEY = ""
headers = {
        "User-Agent": "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/86.0.4240.183 Safari/537.36",
        "Accept-Language": "ko-KR,ko;q=0.9,en-US;q=0.8,en;q=0.7",
        "Accept-Charset": "application/x-www-form-urlencoded; charset=UTF-8",
        "Origin": "https://developer.riotgames.com",
        "X-Riot-Token": APIKEY
    }
def user_level_tier(name):
    API="https://kr.api.riotgames.com/lol/summoner/v4/summoners/by-name/" + name
    getAPI=requests.get(API, headers=headers)
    apidata=getAPI.json()
    level=apidata["summonerLevel"]
    user_id=apidata["id"]
    API="https://kr.api.riotgames.com/lol/league/v4/entries/by-summoner/"+user_id
    getAPI=requests.get(API, headers=headers)
    apidata=getAPI.json()
    #insert_table(name,level,apidata[0]["tier"])
    return level,apidata[0]["tier"]
def user_tier(name):
    API="https://kr.api.riotgames.com/lol/summoner/v4/summoners/by-name/" + name
    getAPI=requests.get(API, headers=headers)
    apidata=getAPI.json()
    level=apidata["summonerLevel"]
    user_id=apidata["id"]
    API="https://kr.api.riotgames.com/lol/league/v4/entries/by-summoner/"+user_id
    getAPI=requests.get(API, headers=headers)
    apidata=getAPI.json()
    #insert_user_table(name,level,apidata[0]["tier"])
    return apidata[0]["tier"]
def game_id(name,num):
    API="https://kr.api.riotgames.com/lol/summoner/v4/summoners/by-name/" + name
    getAPI=requests.get(API, headers=headers)
    LOL_API_DATA=getAPI.json()
    accountid=LOL_API_DATA["accountId"]
    API="https://kr.api.riotgames.com/lol/match/v4/matchlists/by-account/" + accountid
    getAPI=requests.get(API, headers=headers)
    LOL_API_DATA=getAPI.json()['matches']
    #int값 리턴
    return LOL_API_DATA[num].get("gameId")
def season_country(name):
    API="https://kr.api.riotgames.com/lol/summoner/v4/summoners/by-name/" + name
    getAPI=requests.get(API, headers=headers)
    LOL_API_DATA=getAPI.json()
    accountid=LOL_API_DATA["accountId"]
    API="https://kr.api.riotgames.com/lol/match/v4/matchlists/by-account/" + accountid
    getAPI=requests.get(API, headers=headers)
    LOL_API_DATA=getAPI.json()['matches']
    #str값리턴
    #insert_match_table(name,LOL_API_DATA[0].get("platformId"),LOL_API_DATA[0].get("season"))
    return LOL_API_DATA[0].get("platformId"),LOL_API_DATA[0].get("season")
def opscore(name):
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
    score=round((kill*3+ass*2)/(death*3),2)+round((cs/(time/60)*0.2),2)+round(vision*0.05,2)
    return score


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
    score=round((kill*3+ass*2)/(death*3),2)+round((cs/(time/60)*0.2),2)+round(vision*0.05,2)
    #insert_game_table(name, round(kill/10,2),round(death/10,2),round(ass/10,2),round(cs/(time/60),2),round(vision/10,2))
    #insert_score_table(name,score)
    a=user_tier(name)
    if(a=='BRONZE'):
        b=0
    if (a == 'SILVER'):
        b = 1

    if (a == 'GOLD'):
        b = 2

    if (a == 'PLATINUM'):
        b = 3

    if (a == 'DIAMOND'):
        b = 4

    if (a == 'MASTER'):
        b = 5

    if (a == 'GRANDMASTER'):
        b = 6

    if (a == 'CHALLENGER'):
        b = 7

    return [round(kill/10,2),round(death/10,2),round(ass/10,2),round(cs/(time/60),2),round(vision/10,2),score,b]


def read_in():
       lines = sys.stdin.readlines()
       
       return base64.b64decode(lines[0]).decode("UTF-8")

def main():

    lines = read_in()
       
    user_tier(lines)
    season_country(lines)
       
    print(all_info(lines))


if __name__ == '__main__':
       main()


