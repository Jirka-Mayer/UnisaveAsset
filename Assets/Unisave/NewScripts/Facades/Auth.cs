﻿using System.Collections;
using System.Collections.Generic;
using RSG;

namespace Unisave
{
    /// <summary>
    /// Facade for player authentication
    /// </summary>
    public static class Auth
    {
        /// <summary>
        /// Attempt player login
        /// </summary>
        public static IPromise Login(string email, string password)
        {
            return UnisaveServer.DefaultInstance.Authenticator.Login(email, password);
        }

        /// <summary>
        /// Attempt to logout current player
        /// </summary>
        public static IPromise Logout()
        {
            return UnisaveServer.DefaultInstance.Authenticator.Logout();
        }

        /// <summary>
        /// Attempt to register a new player
        /// </summary>
        public static IPromise Register(string email, string password)
        {
            return UnisaveServer.DefaultInstance.Authenticator.Register(email, password);
        }
    }
}