import requests
from urllib import parse
name=parse.quote(input("검색을 원하는 유저 이름을 입력하세요"))
APIKEY="RGAPI-4a16839e-3e5c-4b4e-8b13-1e44b8d621d7"
headers={
     "User-Agent": "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/86.0.4240.183 Safari/537.36",
    "Accept-Language": "ko-KR,ko;q=0.9,en-US;q=0.8,en;q=0.7",
    "Accept-Charset": "application/x-www-form-urlencoded; charset=UTF-8",
    "Origin": "https://developer.riotgames.com",
    "X-Riot-Token": APIKEY
     }
def get_account_id():
    API="https://kr.api.riotgames.com/lol/summoner/v4/summoners/by-name/" + name
    getAPI=requests.get(API, headers=headers)
    LOL_API_DATA=getAPI.json()
    return LOL_API_DATA["accountId"]
def return_key():
    return APIKEY
def return_name():
    return name


