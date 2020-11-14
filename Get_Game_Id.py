import Get_Account_Id
import requests
accountid=Get_Account_Id.get_account_id()
APIKEY=Get_Account_Id.return_key()
headers = {
     "User-Agent": "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/86.0.4240.183 Safari/537.36",
    "Accept-Language": "ko-KR,ko;q=0.9,en-US;q=0.8,en;q=0.7",
    "Accept-Charset": "application/x-www-form-urlencoded; charset=UTF-8",
    "Origin": "https://developer.riotgames.com",
    "X-Riot-Token": APIKEY
     }
API="https://kr.api.riotgames.com/lol/match/v4/matchlists/by-account/" + accountid
getAPI=requests.get(API, headers=headers)
LOL_API_DATA=getAPI.json()['matches']
def get_game_id(index):
    return LOL_API_DATA[index].get("gameId")
def get_champ_id(index):
    return LOL_API_DATA[index].get("champion")
