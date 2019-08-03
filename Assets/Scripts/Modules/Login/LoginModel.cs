using UnityEngine;
using System.Collections;
using Pb;
using MessageId;

public class LoginModel : BaseModel<LoginModel>
{
    protected override void InitAddTocHandler()
    {
        AddTocHandler(typeof(LoginReq), LoginReq);
        AddTocHandler(typeof(LoginResp), LoginResp);
    }

    private void LoginReq(object data)
    {
        LoginReq toc = data as LoginReq;
        SendTos(toc);
    }
    private void LoginResp(object data)
    {
        LoginReq toc = data as LoginReq;
        Debug.Log("Login success !!!");
    }
}
