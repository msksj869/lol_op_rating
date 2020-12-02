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
def level(name):
    API="https://kr.api.riotgames.com/lol/summoner/v4/summoners/by-name/" + name
    getAPI=requests.get(API, headers=headers)
    apidata=getAPI.json()
    return apidata["summonerLevel"]
