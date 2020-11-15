import Get_Account_Id
import Get_Game_Id
import requests
APIKEY=Get_Account_Id.return_key()
headers = {
     "User-Agent": "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/86.0.4240.183 Safari/537.36",
    "Accept-Language": "ko-KR,ko;q=0.9,en-US;q=0.8,en;q=0.7",
    "Accept-Charset": "application/x-www-form-urlencoded; charset=UTF-8",
    "Origin": "https://developer.riotgames.com",
    "X-Riot-Token": APIKEY
     }
def op_score(ac_id):
    API="https://kr.api.riotgames.com/lol/match/v4/matchlists/by-account/" + ac_id
    getAPI=requests.get(API, headers=headers)
    DATA=getAPI.json()["matches"]
    score=0
    for i in range(0,5):
        score+=first_step(DATA[i].get("gameId"),ac_id)
    return score

def first_step(gameid,ac_id):
    API="https://kr.api.riotgames.com/lol/match/v4/matches/" + str(gameid)
    print(gameid)
    getAPI=requests.get(API, headers=headers)
    f_step_api=getAPI.json()
    t_score=0
    for i in range(0,10):
        if (f_step_api["participantIdentities"][i]["player"]["accountId"]==ac_id):
            if f_step_api["participants"][i]["stats"]["deaths"]==0:
                t_score=round((f_step_api["participants"][i]["stats"]["kills"]*3+f_step_api["participants"][i]["stats"]["assists"]*0.5)/\
                       1,2)+round(f_step_api["participants"][i]["stats"]["totalMinionsKilled"]\
                       /(f_step_api["gameDuration"]/60)*0.2,2)+round(f_step_api["participants"][i]["stats"]["visionScore"]*0.05,2)
            else:
                t_score=round((f_step_api["participants"][i]["stats"]["kills"]*3+f_step_api["participants"][i]["stats"]["assists"]*0.5)/\
                         (f_step_api["participants"][i]["stats"]["deaths"]*3),2)+round(f_step_api["participants"][i]["stats"]["totalMinionsKilled"]\
                         /(f_step_api["gameDuration"]/60)*0.2,2)+round(f_step_api["participants"][i]["stats"]["visionScore"]*0.05,2)
            i=10
    return t_score
                   
