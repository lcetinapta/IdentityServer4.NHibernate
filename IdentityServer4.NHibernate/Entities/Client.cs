﻿namespace IdentityServer4.NHibernate.Entities
{
    using System.Collections.Generic;
    using IdentityServer4.Models;

    public class Client : EntityBase<int>
    {
        private readonly ICollection<ClientSecret> _clientSecrets = new List<ClientSecret>();
        private readonly ICollection<ClientGrantType> _allowedGrantTypes = new List<ClientGrantType>();
        private readonly ICollection<ClientRedirectUri> _clientRedirectUris = new List<ClientRedirectUri>();
        private readonly ICollection<ClientPostLogoutRedirectUri> _clientPostLogoutRedirectUris = new List<ClientPostLogoutRedirectUri>();
        private readonly ICollection<ClientScope> _allowedScopes = new List<ClientScope>();
        private readonly ICollection<ClientIdPRestriction> _identityProviderRestrictions = new List<ClientIdPRestriction>();
        private readonly ICollection<ClientClaim> _clientClaims = new List<ClientClaim>();
        private readonly ICollection<ClientCorsOrigin> _clientCorsOrigins = new List<ClientCorsOrigin>();
        private readonly ICollection<ClientProperty> _clientProperties = new List<ClientProperty>();

        public virtual bool Enabled { get; set; } = true;
        public virtual string ClientId { get; set; }
        public virtual string ProtocolType { get; set; } = IdentityServerConstants.ProtocolTypes.OpenIdConnect;
        public virtual IEnumerable<ClientSecret> ClientSecrets { get { return _clientSecrets; } }
        public virtual bool RequireClientSecret { get; set; } = true;
        public virtual string ClientName { get; set; }
        public virtual string Description { get; set; }
        public virtual string ClientUri { get; set; }
        public virtual string LogoUri { get; set; }
        public virtual bool RequireConsent { get; set; } = true;
        public virtual bool AllowRememberConsent { get; set; } = true;
        public virtual bool AlwaysIncludeUserClaimsInIdToken { get; set; }
        public virtual IEnumerable<ClientGrantType> AllowedGrantTypes { get { return _allowedGrantTypes; } }
        public virtual bool RequirePkce { get; set; }
        public virtual bool AllowPlainTextPkce { get; set; }
        public virtual bool AllowAccessTokensViaBrowser { get; set; }
        public virtual IEnumerable<ClientRedirectUri> RedirectUris { get { return _clientRedirectUris; } }
        public virtual IEnumerable<ClientPostLogoutRedirectUri> PostLogoutRedirectUris { get { return _clientPostLogoutRedirectUris; } }
        public virtual string FrontChannelLogoutUri { get; set; }
        public virtual bool FrontChannelLogoutSessionRequired { get; set; } = true;
        public virtual string BackChannelLogoutUri { get; set; }
        public virtual bool BackChannelLogoutSessionRequired { get; set; } = true;
        public virtual bool AllowOfflineAccess { get; set; }
        public virtual IEnumerable<ClientScope> AllowedScopes { get { return _allowedScopes; } }
        public virtual int IdentityTokenLifetime { get; set; } = 300;
        public virtual int AccessTokenLifetime { get; set; } = 3600;
        public virtual int AuthorizationCodeLifetime { get; set; } = 300;
        public virtual int? ConsentLifetime { get; set; } = null;
        public virtual int AbsoluteRefreshTokenLifetime { get; set; } = 2592000;
        public virtual int SlidingRefreshTokenLifetime { get; set; } = 1296000;
        public virtual int RefreshTokenUsage { get; set; } = (int)TokenUsage.OneTimeOnly;
        public virtual bool UpdateAccessTokenClaimsOnRefresh { get; set; }
        public virtual int RefreshTokenExpiration { get; set; } = (int)TokenExpiration.Absolute;
        public virtual int AccessTokenType { get; set; } = (int)Models.AccessTokenType.Jwt;
        public virtual bool EnableLocalLogin { get; set; } = true;
        public virtual IEnumerable<ClientIdPRestriction> IdentityProviderRestrictions { get { return _identityProviderRestrictions; } }
        public virtual bool IncludeJwtId { get; set; }
        public virtual IEnumerable<ClientClaim> Claims { get { return _clientClaims; } }
        public virtual bool AlwaysSendClientClaims { get; set; }
        public virtual string ClientClaimsPrefix { get; set; } = "client_";
        public virtual string PairWiseSubjectSalt { get; set; }
        public virtual IEnumerable<ClientCorsOrigin> AllowedCorsOrigins { get; }
        public virtual IEnumerable<ClientProperty> Properties { get; }
    }
}
