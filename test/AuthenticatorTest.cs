﻿using System;
using System.Net;
using NUnit.Framework;
using System.Threading;

namespace Conjur.Test
{
    public class AuthenticatorTest : Base
    {
        protected static readonly NetworkCredential credential = new NetworkCredential("username", "api-key");

        protected ApiKeyAuthenticator Authenticator;
        
        [SetUp]
        public void CreateAuthenticator()
        {
            Authenticator = new ApiKeyAuthenticator(new Uri("test:///authn"), TestAccount, credential);
        }

    // TODO: These tests have been commented out and will be fixed in Issue #45 (https://github.com/cyberark/conjur-api-dotnet/issues/45)

        //[Test]
        //public void TestTokenCaching()
        //{
        //    MockToken("token1");
        //    Assert.AreEqual("token1", Authenticator.GetToken());
        //    MockToken("token2");

        //    Assert.AreEqual("token1", Authenticator.GetToken());
        //    MockTokenExpiration ();
        //    Assert.AreEqual("token2", Authenticator.GetToken());
        //}

    //    [Test]
    //    public void TestTokenThreadSafe()
    //    {
    //        int authenticationCount = 0;
    //        Action<WebRequest> verifier = (WebRequest wr) =>
    //        {
    //            ApiKeyVerifier(wr);
    //            Thread.Sleep (10);
    //            Interlocked.Increment(ref authenticationCount);
    //        };

    //        string token = "token1";

    //        MockToken(token).Verifier = verifier;

    //        Assert.AreEqual(token, Authenticator.GetToken());
    //        Assert.AreEqual(1, authenticationCount);

    //        ThreadStart checker = () =>
    //        {
    //            Assert.AreEqual(token, Authenticator.GetToken());
    //        };

    //        Thread t1 = new Thread(checker);
    //        Thread t2 = new Thread(checker);

    //        t1.Start(); t2.Start();
    //        t1.Join(); t2.Join();

    //        Assert.AreEqual(1, authenticationCount);

    //        MockTokenExpiration();

    //        token = "token2";
    //        MockToken(token).Verifier = verifier;

    //        t1 = new Thread(checker);
    //        t2 = new Thread(checker);

    //        Assert.AreEqual(1, authenticationCount);
    //        t1.Start(); t2.Start();
    //        t1.Join(); t2.Join();
    //        Assert.AreEqual(2, authenticationCount);
    //    }

    //    static protected readonly Action<WebRequest> ApiKeyVerifier = (WebRequest wr) =>
    //    {
    //        var req = wr as WebMocker.MockRequest;
    //        Assert.AreEqual("POST", wr.Method);
    //        Assert.AreEqual("api-key", req.Body);
    //    };


    //    protected WebMocker.MockRequest MockToken(string token)
    //    {
    //        var mock = Mocker.Mock(new Uri($"test:///authn/{TestAccount}/username/authenticate"), token);
    //        mock.Verifier = ApiKeyVerifier;
    //        Console.WriteLine (mock.Verifier);
    //        return mock;
    //    }

    //    protected void MockTokenExpiration()
    //    {
    //        Authenticator.StartTokenTimer(new TimeSpan(0, 0, 0, 0, 1));
    //        Thread.Sleep(10);
    //    }
    }
}
