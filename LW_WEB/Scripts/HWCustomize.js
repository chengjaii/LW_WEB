$(function() {
    //----火星人語錄
    var MartianTalk = new Array(15);
    MartianTalk[0] = "失敗只有一種，那就是放棄努力！";
    MartianTalk[1] = "正直！熱情！敏銳！";
    MartianTalk[2] = "這世界上沒有優秀的理念，只有腳踏實地的結果！";
    MartianTalk[3] = "噓~~~要假裝沒看見我！";
    MartianTalk[4] = "堅持到底就是成功！";
    MartianTalk[5] = "幫台灣麗偉成為全球領先的工具機品牌！";
    MartianTalk[6] = "我對台灣麗偉的景仰，有如滔滔江水，連綿不絕，更有如黃河氾濫，一發不可收拾！";
    MartianTalk[7] = "不管輸掉什麼，都別輸掉精神；不管放棄什麼，都別放棄努力！";
    MartianTalk[8] = "台灣麗偉因為有你而存在！";
    MartianTalk[9] = "不要抓我去研究！我只是個跑龍套的演員！";
    MartianTalk[10] = "如果你想得到，你就會得到，你所需要付出的只是行動！";
    MartianTalk[11] = "最困難之時，就是我們離成功不遠之日！";
    MartianTalk[12] = "只要路是對的，就不怕路遠！";
    MartianTalk[13] = "永遠要把對手想得非常強大，哪怕非常弱小，你也要把他想得非常強大！";
    MartianTalk[14] = "不為失敗找理由，要為成功找方法！";
    MartianTalk[15] = "每天給自己一個微笑！";
    var RandNum = Math.floor(Math.random() * 16);
    $('#MartianTalk').attr("data-tooltip", MartianTalk[RandNum]);
    //----
})