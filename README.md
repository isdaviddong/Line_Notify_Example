# Line Notify Example

<br/>這個範例展示如何使用 Line Notify ，透過OAuth取得可發送Line訊息給用戶的Token
<br/>並透過該Token免費發送Line Message
<br/>Line Notify 概念請參考 http://studyhost.blogspot.tw/2016/12/linebot6-botline-notify.html

<br/>說明: 
<ol>
<li>使用此範例Source code，請先更換程式碼中《你的Client_id》<br/> (位於default.aspx) </li>
<li>並且調整你申請好的LineNotify設定的callback url <br/> (測試階段應為http://localhost:3696/Callback.aspx) </li>
<li>同時Callback.aspx.cs中的client_id與client_secret必須改為擬申請LineNotify後取得的正確資料</li>
<li>相關說明請參考 : http://studyhost.blogspot.tw/2016/12/linebot6-botline-notify.html </li>
</ol>
<br/>使用(請於VS2015中，執行default.aspx): 
<ol>
<li>請點選用戶註冊，將會取得該登入用戶的發送訊息token</li>
<li>接著輸入訊息後，按下發送鈕即可測試</li>
</ol>

## Hands-on lab

https://hackmd.io/s/H1FjUse_4
