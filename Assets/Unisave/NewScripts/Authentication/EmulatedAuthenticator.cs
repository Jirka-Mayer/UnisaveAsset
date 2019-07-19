using System;
using RSG;

namespace Unisave.Authentication
{
    public class EmulatedAuthenticator : IAuthenticator
    {
        /// <summary>
        /// Authenticated player
        /// </summary>
        public UnisavePlayer Player { get; private set; }

        /// <summary>
        /// Is some player logged in
        /// </summary>
        public bool LoggedIn => Player != null;

        /// <summary>
        /// Token that is used to access the server when authenticated
        /// </summary>
        public string AccessToken { get; private set; }

        /// <inheritdoc/>
        public IPromise Login(string email, string password)
		{
			// TODO: do some checks against the emulated player database
            return Promise.Resolved();
		}

        /// <inheritdoc/>
        public IPromise Logout()
        {
            Player = null;
            AccessToken = null;
            return Promise.Resolved();
        }

        public IPromise Register(string email, string password)
        {
            // TODO: do updates on the emulated database
            return Promise.Resolved();
        }

        /// <summary>
        /// Logs in the fake emulated player
        /// </summary>
        public void LoginEmulatedPlayer()
        {
            Player = new UnisavePlayer("emulated-player-id");
            AccessToken = "emulated-player-access-token";
        }
    }
}