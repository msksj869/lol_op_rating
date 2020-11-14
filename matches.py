import Get_Account_Id
import Get_Game_Id
import requests
APIKEY=Get_Account_Id.return_key()
name=Get_Account_Id.return_name().replace(" ","").lower()
headers = {
     "User-Agent": "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/86.0.4240.183 Safari/537.36",
    "Accept-Language": "ko-KR,ko;q=0.9,en-US;q=0.8,en;q=0.7",
    "Accept-Charset": "application/x-www-form-urlencoded; charset=UTF-8",
    "Origin": "https://developer.riotgames.com",
    "X-Riot-Token": APIKEY
     }
def game_result(num):
    champid=Get_Game_Id.get_champ_id(num)
    gameid=Get_Game_Id.get_game_id(num)
    API="https://kr.api.riotgames.com/lol/match/v4/matches/" + str(gameid)
    getAPI=requests.get(API, headers=headers)
    LOL_API_DATA=getAPI.json()
    find_user=-1
    result=" "
    for i in range(0,10):
        if LOL_API_DATA["participants"][i]["championId"]==champid:
            if LOL_API_DATA["participants"][i]["stats"]["win"]==True:
                result="승리"
            else:
                result="패배"
    print(result)
 

for j in range(0,10):
    game_result(j)
